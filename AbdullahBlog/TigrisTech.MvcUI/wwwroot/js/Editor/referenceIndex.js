$(document).ready(function () {

    /* DataTables start here.*/

    const dataTable = $('#referenceTable').DataTable({
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
            },
            "buttons": {
                "collection": "Koleksiyon <span class=\"ui-button-icon-primary ui-icon ui-icon-triangle-1-s\"><\/span>",
                "colvis": "Sütun görünürlüğü",
                "colvisRestore": "Görünürlüğü eski haline getir",
                "copySuccess": {
                    "1": "1 satır panoya kopyalandı",
                    "_": "%ds satır panoya kopyalandı"
                },
                "copyTitle": "Panoya kopyala",
                "csv": "CSV",
                "excel": "Excel",
                "pageLength": {
                    "-1": "Bütün satırları göster",
                    "1": "-",
                    "_": "%d satır göster"
                },
                "pdf": "PDF",
                "print": "Yazdır",
                "copy": "Kopyala",
                "copyKeys": "Tablodaki veriyi kopyalamak için CTRL veya u2318 + C tuşlarına basınız. İptal etmek için bu mesaja tıklayın veya escape tuşuna basın."
            },
        },
    });

    /* DataTables ends here */

    /*Ajax GET / Getting the _GaleryAddParital as Modal Form starts from here.*/

    $(function () {
        const url = '/Admin/Galery/Add';
        const placeHolderDiv = $('#modalPlaceHolder');
        $('#btnAdd').click(function () {
            $.get(url).done(function (data) {
                placeHolderDiv.html(data);
                placeHolderDiv.find(".modal").modal('show');
            });
        });
        /* Ajax GET / Getting the _GaleryAddPartial as Modal Form ends here.*/

        /* Ajax POST / Posting the FormData as GaleryAddDto starts from here.*/

        placeHolderDiv.on('click',
            '#btnSave',
            function (event) {
                event.preventDefault();
                const form = $('#form-galery-add');
                const actionUrl = form.attr('action');
                const dataToSend = new FormData(form.get(0));
                $.ajax({
                    url: actionUrl,
                    type: 'POST',
                    data: dataToSend,
                    processData: false,
                    contentType: false,
                    success: function (data) {
                        console.log(data);
                        const galeryAddAjaxModel = jQuery.parseJSON(data);
                        console.log(galeryAddAjaxModel);
                        const newFormBody = $('.modal-body', galeryAddAjaxModel.GaleryAddPartial);
                        placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                        const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                        if (isValid) {
                            placeHolderDiv.find('.modal').modal('hide');
                            const newTableRow = dataTable.row.add([
                                galeryAddAjaxModel.GaleryDto.Galery.Id,
                                galeryAddAjaxModel.GaleryDto.Galery.Title,
                                galeryAddAjaxModel.GaleryDto.Galery.Description.length > 75 ? galeryAddAjaxModel.GaleryDto.Galery.Description.substring(0, 75) : galeryAddAjaxModel.GaleryDto.Galery.Description,
                                `<img src="/img/${galeryAddAjaxModel.GaleryDto.Galery.Picture}" alt="${galeryAddAjaxModel.GaleryDto.Galery.Title}" class="my-image-table" />`,
                                galeryAddAjaxModel.GaleryDto.Galery.IsActive ? "Evet" : "Hayır",
                                galeryAddAjaxModel.GaleryDto.Galery.IsDeleted ? "Evet" : "Hayır",
                                convertToShortDate(galeryAddAjaxModel.GaleryDto.Galery.CreateDate),
                                galeryAddAjaxModel.GaleryDto.Galery.CreateByName,
                                convertToShortDate(galeryAddAjaxModel.GaleryDto.Galery.ModifiedDate),
                                galeryAddAjaxModel.GaleryDto.Galery.ModifiedByName,
                                `
                                <button class="btn btn-primary btn-sm btn-update" data-id="${galeryAddAjaxModel.GaleryDto.Galery.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${galeryAddAjaxModel.GaleryDto.Galery.Id}"><span class="fas fa-minus-circle"></span></button>
                            `
                            ]).node();
                            const jqueryTableRow = $(newTableRow);
                            jqueryTableRow.attr('name', `${galeryAddAjaxModel.GaleryDto.Galery.Id}`);
                            dataTable.row(newTableRow).draw();
                            toastr.success(`${galeryAddAjaxModel.GaleryDto.Message}`, 'Başarılı İşlem!');
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
    })
    /* Ajax POST / Deleting a User starts from here. */

    $(document).on('click', '.btn-delete', function (event) {
        event.preventDefault();
        const id = $(this).attr('data-id');
        const tableRow = $(`[name="${id}"]`);
        const galeryTitle = tableRow.find('td:eq(2)').text();//1 index Name 
        Swal.fire({
            title: 'Silmek istediğinize emin misiniz?',
            text: `${galeryTitle} başlılı makale silinecektir.`,
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
                    data: { galeryId: id },
                    url: '/Admin/Galery/HardDelete/',
                    success: function (data) {
                        const galeryResult = jQuery.parseJSON(data);
                        if (galeryResult.ResultStatus === 0) {
                            Swal.fire(
                                'Silindi',
                                `${galeryResult.Message}`,
                                'success'
                            );

                            dataTable.row(tableRow).remove().draw();
                        }
                        else {
                            Swal.fire({
                                icon: 'error',
                                title: 'Başarısız işlem!',
                                text: `${galeryResult.Message}`,
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

    /*Ajax GET / Getting the _GaleryUpdatePartial as Modal Form starts from here.*/

    $(function () {
        const url = '/Admin/Galery/Update/';
        const placeHolderDiv = $('#modalPlaceHolder');
        $(document).on('click',
            '.btn-update',
            function (event) {
                event.preventDefault();
                const id = $(this).attr('data-id');
                $.get(url, { galeryId: id }).done(function (data) {
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

                const form = $('#form-galery-update');
                const actionUrl = form.attr('action');
                const dataToSend = new FormData(form.get(0));
                $.ajax({
                    url: actionUrl,
                    type: 'POST',
                    data: dataToSend,
                    processData: false,
                    contentType: false,
                    success: function (data) {
                        const galeryUpdateAjaxModel = jQuery.parseJSON(data);
                        const newFormBody = $('.modal-body', galeryUpdateAjaxModel.GaleryUpdatePartial);
                        placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                        const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                        if (isValid) {
                            const id = galeryUpdateAjaxModel.GaleryDto.Galery.Id;
                            console.log(id);
                            const tableRow = $(`[name="${id}"]`);
                            placeHolderDiv.find('.modal').modal('hide');
                            dataTable.row(tableRow).data([
                                galeryUpdateAjaxModel.GaleryDto.Galery.Id,
                                galeryUpdateAjaxModel.GaleryDto.Galery.Title,
                                galeryUpdateAjaxModel.GaleryDto.Galery.Description.length > 75 ? galeryUpdateAjaxModel.GaleryDto.Galery.Description.substring(0, 75) : galeryUpdateAjaxModel.GaleryDto.Galery.Description,
                                `<img src="/img/${galeryUpdateAjaxModel.GaleryDto.Galery.Picture}" alt="${galeryUpdateAjaxModel.GaleryDto.Galery.Title}" class="my-image-table" />`,
                                galeryUpdateAjaxModel.GaleryDto.Galery.IsActive ? "Evet" : "Hayır",
                                galeryUpdateAjaxModel.GaleryDto.Galery.IsDeleted ? "Evet" : "Hayır",
                                convertToShortDate(galeryUpdateAjaxModel.GaleryDto.Galery.CreateDate),
                                galeryUpdateAjaxModel.GaleryDto.Galery.CreateByName,
                                convertToShortDate(galeryUpdateAjaxModel.GaleryDto.Galery.ModifiedDate),
                                galeryUpdateAjaxModel.GaleryDto.Galery.ModifiedByName,
                                `
                                <button class="btn btn-primary btn-sm btn-update" data-id="${galeryUpdateAjaxModel.GaleryDto.Galery.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${galeryUpdateAjaxModel.GaleryDto.Galery.Id}"><span class="fas fa-minus-circle"></span></button>
                            `
                            ]);
                            tableRow.attr("name", `${id}`);
                            dataTable.row(tableRow).invalidate();
                            toastr.success(`${galeryUpdateAjaxModel.GaleryDto.Message}`, "Başarılı İşlem!");
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
                        console.log(error);
                        toastr.error(`${err.responseText}`, 'Hata!');
                    }
                });
            });

    });
});
