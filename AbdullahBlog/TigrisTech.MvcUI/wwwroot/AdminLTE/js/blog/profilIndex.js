$(document).ready(function () {

    /* DataTables start here.*/

    const dataTable = $('#profilsTable').DataTable({
        dom: "<'row'<'col-sm-3'l><'col-sm-6 text-center'B><'col-sm-3'f>>" +
            "<'row'<'col-sm-12'tr>>" +
            "<'row'<'col-sm-5'i><'col-sm-7'p>>",
        buttons: [
            {
                text: 'Ekle',
                attr: {
                    id: "btnAdd",
                },
                className: 'btn btn-success',
                action: function (e, dt, node, config) {

                }
            }
        ],
        language: {
            "sDecimal": ",",
            "sEmptyTable": "Tabloda herhangi bir veri mevcut değil",
            "sInfo": "_TOTAL_ kayıttan _START_ - _END_ arasındaki kayıtlar gösteriliyor",
            "sInfoEmpty": "Kayıt yok",
            "sInfoFiltered": "(_MAX_ kayıt içerisinden bulunan)",
            "sInfoPostFix": "",
            "sInfoThousands": ".",
            "sLengthMenu": "Sayfada _MENU_ kayıt göster",
            "sLoadingRecords": "Yükleniyor...",
            "sProcessing": "İşleniyor...",
            "sSearch": "Ara:",
            "sZeroRecords": "Eşleşen kayıt bulunamadı",
            "oPaginate": {
                "sFirst": "İlk",
                "sLast": "Son",
                "sNext": "Sonraki",
                "sPrevious": "Önceki"
            },
            "oAria": {
                "sSortAscending": ": artan sütun sıralamasını aktifleştir",
                "sSortDescending": ": azalan sütun sıralamasını aktifleştir"
            },
            "select": {
                "rows": {
                    "_": "%d kayıt seçildi",
                    "0": "",
                    "1": "1 kayıt seçildi"
                }
            }

        },
    });

    /* DataTables ends here */

    /*Ajax GET / Getting the _ProfilAddPartial as Modal Form starts from here.*/

    $(function () {
        const url = '/Admin/Profil/Add';
        const placeHolderDiv = $('#modalPlaceHolder');
        $('#btnAdd').click(function () {
            $.get(url).done(function (data) {
                placeHolderDiv.html(data);
                placeHolderDiv.find(".modal").modal('show');
            });
        });

        /* Ajax GET / Getting the _ProfilAddPartial as Modal Form ends here.*/

        /* Ajax POST / Posting the FormData as ProfilAddDto starts from here.*/

        placeHolderDiv.on('click',
            '#btnSave',
            function (event) {
                event.preventDefault();
                const form = $('#form-profil-add');
                const actionUrl = form.attr('action');
                const dataToSend = new FormData(form.get(0));
                $.ajax({
                    url: actionUrl,
                    type: 'POST',
                    data: dataToSend,
                    processData: false,
                    contentType: false,
                    success: function (data) {
                        const profilAddAjaxModel = jQuery.parseJSON(data);
                        const newFormBody = $('.modal-body', profilAddAjaxModel.ProfilAddPartial);
                        placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                        const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                        if (isValid) {
                            placeHolderDiv.find('.modal').modal('hide');
                            const newTableRow = dataTable.row.add([
                                profilAddAjaxModel.ProfilDto.Profil.Id,
                                profilAddAjaxModel.ProfilDto.Profil.FirstName,
                                profilAddAjaxModel.ProfilDto.Profil.LastName,
                                profilAddAjaxModel.ProfilDto.Profil.About.length > 75 ? profilAddAjaxModel.ProfilDto.Profil.About.substring(0, 75) : profilAddAjaxModel.ProfilDto.Profil.About,
                                `<img src="/img/${profilAddAjaxModel.ProfilDto.Profil.Picture}" alt="${profilAddAjaxModel.ProfilDto.Profil.FirstName}" class="my-image-table" />`,
                                profilAddAjaxModel.ProfilDto.Profil.IsActive ? "Evet" : "Hayır",
                                profilAddAjaxModel.ProfilDto.Profil.IsDeleted ? "Evet" : "Hayır",
                                convertToShortDate(profilAddAjaxModel.ProfilDto.Profil.CreateDate),
                                profilAddAjaxModel.ProfilDto.Profil.CreateByName,
                                convertToShortDate(profilAddAjaxModel.ProfilDto.Profil.ModifiedDate),
                                profilAddAjaxModel.ProfilDto.Profil.ModifiedByName,
                                `
                                <button class="btn btn-primary btn-sm btn-update" data-id="${profilAddAjaxModel.ProfilDto.Profil.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${profilAddAjaxModel.ProfilDto.Profil.Id}"><span class="fas fa-minus-circle"></span></button>
                            `
                            ]).node();
                            const jqueryTableRow = $(newTableRow);
                            jqueryTableRow.attr('name', `${profilAddAjaxModel.ProfilDto.Profil.Id}`);
                            dataTable.row(newTableRow).draw();
                            toastr.success(`${profilAddAjaxModel.ProfilDto.Message}`, 'Başarılı İşlem!');
                        } else {
                            let summaryText = "";
                            $('#validation-summary > ul > li').each(function () {
                                let text = $(this).text();
                                summaryText = `*${text}\n`;
                            });
                            toastr.warning(summaryText);
                        }
                    },
                    error: function (err) {
                        console.log(err);
                        toastr.error(`${err.responseText}`, 'Hata!');
                    }
                });

            });
    });

    /* Ajax POST / Deleting a User starts from here. */

    $(document).on('click', '.btn-delete', function (event) {
        event.preventDefault();
        const id = $(this).attr('data-id');
        const tableRow = $(`[name="${id}"]`);
        const profilTitle = tableRow.find('td:eq(2)').text();//1 index Name 
        Swal.fire({
            title: 'Silmek istediğinize emin misiniz?',
            text: `${profilTitle} başlılı makale silinecektir.`,
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Evet, silmek istiyorum.',
            cancelButtonText: 'Hayır, silmek istemiyorum.'
        }).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                    type: 'POST',
                    dataType: 'json',
                    data: { profilId: id },
                    url: '/Admin/Profil/HardDelete/',
                    success: function (data) {
                        const profilResult = jQuery.parseJSON(data);
                        if (profilResult.ResultStatus === 0) {
                            Swal.fire(
                                'Silindi',
                                `${profilResult.Message}`,
                                'success'
                            );

                            dataTable.row(tableRow).remove().draw();
                        }
                        else {
                            Swal.fire({
                                icon: 'error',
                                title: 'Başarısız işlem!',
                                text: `${profilResult.Message}`,
                            })
                        }
                    },
                    error: function (err) {
                        toastr.error(`${err.responseText}`, "Hata!")
                    }
                })
            }
        });
    });

    /*Ajax GET / Getting the _ProfilUpdatePartial as Modal Form starts from here.*/

    $(function () {
        const url = '/Admin/Profil/Update/';
        const placeHolderDiv = $('#modalPlaceHolder');
        $(document).on('click',
            '.btn-update',
            function (event) {
                event.preventDefault();
                const id = $(this).attr('data-id');
                $.get(url, { profilId: id }).done(function (data) {
                    placeHolderDiv.html(data);
                    placeHolderDiv.find('.modal').modal('show');
                }).fail(function (err) {
                    toastr.error(`${err.responseText}`, 'Hata!');
                });
            });

        /* Ajax POST / Updating a Slider starts from here */

        placeHolderDiv.on('click',
            '#btnUpdate',
            function (event) {
                event.preventDefault();

                const form = $('#form-profil-update');
                const actionUrl = form.attr('action');
                const dataToSend = new FormData(form.get(0));
                $.ajax({
                    url: actionUrl,
                    type: 'POST',
                    data: dataToSend,
                    processData: false,
                    contentType: false,
                    success: function (data) {
                        const profilUpdateAjaxModel = jQuery.parseJSON(data);
                        const newFormBody = $('.modal-body', profilUpdateAjaxModel.ProfilUpdatePartial);
                        placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                        const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                        if (isValid) {
                            const id = profilUpdateAjaxModel.ProfilDto.Profil.Id;
                            console.log(id);
                            const tableRow = $(`[name="${id}"]`);
                            placeHolderDiv.find('.modal').modal('hide');
                            dataTable.row(tableRow).data([
                                profilUpdateAjaxModel.ProfilDto.Profil.Id,
                                profilUpdateAjaxModel.ProfilDto.Profil.FirstName,
                                profilUpdateAjaxModel.ProfilDto.Profil.LastName,
                                profilUpdateAjaxModel.ProfilDto.Profil.About.length > 75 ? profilUpdateAjaxModel.ProfilDto.Profil.About.substring(0, 75) : profilUpdateAjaxModel.ProfilDto.Profil.About,
                                `<img src="/img/${profilUpdateAjaxModel.ProfilDto.Profil.Picture}" alt="${profilUpdateAjaxModel.ProfilDto.Profil.Title}" class="my-image-table" />`,
                                profilUpdateAjaxModel.ProfilDto.Profil.IsActive ? "Evet" : "Hayır",
                                profilUpdateAjaxModel.ProfilDto.Profil.IsDeleted ? "Evet" : "Hayır",
                                convertToShortDate(profilUpdateAjaxModel.ProfilDto.Profil.CreateDate),
                                profilUpdateAjaxModel.ProfilDto.Profil.CreateByName,
                                convertToShortDate(profilUpdateAjaxModel.ProfilDto.Profil.ModifiedDate),
                                profilUpdateAjaxModel.ProfilDto.Profil.ModifiedByName,
                                `
                                <button class="btn btn-primary btn-sm btn-update" data-id="${profilUpdateAjaxModel.ProfilDto.Profil.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${profilUpdateAjaxModel.ProfilDto.Profil.Id}"><span class="fas fa-minus-circle"></span></button>
                            `
                            ]);
                            tableRow.attr("name", `${id}`);
                            dataTable.row(tableRow).invalidate();
                            toastr.success(`${profilUpdateAjaxModel.ProfilDto.Message}`, "Başarılı İşlem!");
                        } else {
                            let summaryText = "";
                            $('#validation-summary > ul > li').each(function () {
                                let text = $(this).text();
                                summaryText = `*${text}\n`;
                            });
                            toastr.warning(summaryText);
                        }
                    },
                    error: function (error) {
                        toastr.error(`${err.responseText}`, 'Hata!');
                    }
                });
            });

    });
});
