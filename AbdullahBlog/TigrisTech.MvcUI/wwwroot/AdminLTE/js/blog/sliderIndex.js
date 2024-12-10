$(document).ready(function () {
    
    /* DataTables start here.*/

    const dataTable = $('#slidersTable').DataTable({
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

    /*Ajax GET / Getting the _SliderAddPartial as Modal Form starts from here.*/

    $(function () {
        const url = '/Admin/Slider/Add';
        const placeHolderDiv = $('#modalPlaceHolder');
        $('#btnAdd').click(function () {
            $.get(url).done(function (data) {
                placeHolderDiv.html(data);
                placeHolderDiv.find(".modal").modal('show');
            });
        });

        /* Ajax GET / Getting the _SliderAddPartial as Modal Form ends here.*/

        /* Ajax POST / Posting the FormData as SliderAddDto starts from here.*/

        placeHolderDiv.on('click',
            '#btnSave',
            function (event) {
                event.preventDefault();
                const form = $('#form-slider-add');
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
                        const sliderAddAjaxModel = jQuery.parseJSON(data);
                        console.log(sliderAddAjaxModel);
                        const newFormBody = $('.modal-body', sliderAddAjaxModel.UserAddPartial);
                        placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                        const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                        if (isValid) {
                            placeHolderDiv.find('.modal').modal('hide');
                            const newTableRow = dataTable.row.add([
                                sliderAddAjaxModel.SliderDto.Slider.Id,
                                sliderAddAjaxModel.SliderDto.Slider.Title,
                                sliderAddAjaxModel.SliderDto.Slider.Description.length > 75 ? sliderAddAjaxModel.SliderDto.Slider.Description.substring(0, 75) : sliderAddAjaxModel.SliderDto.Slider.Description,
                                `<img src="/img/${sliderAddAjaxModel.SliderDto.Slider.Picture}" alt="${sliderAddAjaxModel.SliderDto.Slider.Title}" class="my-image-table" />`,
                                sliderAddAjaxModel.SliderDto.Slider.IsActive ? "Evet" : "Hayır",
                                sliderAddAjaxModel.SliderDto.Slider.IsDeleted ? "Evet" : "Hayır",
                                convertToShortDate(sliderAddAjaxModel.SliderDto.Slider.CreateDate),
                                sliderAddAjaxModel.SliderDto.Slider.CreateByName,
                                convertToShortDate(sliderAddAjaxModel.SliderDto.Slider.ModifiedDate),
                                sliderAddAjaxModel.SliderDto.Slider.ModifiedByName,
                                `
                                <button class="btn btn-primary btn-sm btn-update" data-id="${sliderAddAjaxModel.SliderDto.Slider.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${sliderAddAjaxModel.SliderDto.Slider.Id}"><span class="fas fa-minus-circle"></span></button>
                            `
                            ]).node();
                            const jqueryTableRow = $(newTableRow);
                            jqueryTableRow.attr('name', `${sliderAddAjaxModel.SliderDto.Slider.Id}`);
                            dataTable.row(newTableRow).draw();
                            toastr.success(`${sliderAddAjaxModel.SliderDto.Message}`, 'Başarılı İşlem!');
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
        const sliderTitle = tableRow.find('td:eq(2)').text();//1 index Name 
        Swal.fire({
            title: 'Silmek istediğinize emin misiniz?',
            text: `${sliderTitle} başlılı makale silinecektir.`,
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
                    data: { sliderId: id },
                    url: '/Admin/Slider/HardDelete/',
                    success: function (data) {
                        const sliderResult = jQuery.parseJSON(data);
                        if (sliderResult.ResultStatus === 0) {
                            Swal.fire(
                                'Silindi',
                                `${sliderResult.Message}`,
                                'success'
                            );

                            dataTable.row(tableRow).remove().draw();
                        }
                        else {
                            Swal.fire({
                                icon: 'error',
                                title: 'Başarısız işlem!',
                                text: `${sliderResult.Message}`,
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


    /*Ajax GET / Getting the _SliderUpdatePartial as Modal Form starts from here.*/

    $(function () {
        const url = '/Admin/Slider/Update/';
        const placeHolderDiv = $('#modalPlaceHolder');
        $(document).on('click',
            '.btn-update',
            function (event) {
                event.preventDefault();
                const id = $(this).attr('data-id');
                $.get(url, { sliderId: id }).done(function (data) {
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

                const form = $('#form-slider-update');
                const actionUrl = form.attr('action');
                const dataToSend = new FormData(form.get(0));
                $.ajax({
                    url: actionUrl,
                    type: 'POST',
                    data: dataToSend,
                    processData: false,
                    contentType: false,
                    success: function (data) {
                        const sliderUpdateAjaxModel = jQuery.parseJSON(data);
                        const newFormBody = $('.modal-body', sliderUpdateAjaxModel.UserUpdatePartial);
                        placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                        const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                        if (isValid) {
                            const id = sliderUpdateAjaxModel.SliderDto.Slider.Id;
                            console.log(id);
                            const tableRow = $(`[name="${id}"]`);
                            placeHolderDiv.find('.modal').modal('hide');
                            dataTable.row(tableRow).data([
                                sliderUpdateAjaxModel.SliderDto.Slider.Id,
                                sliderUpdateAjaxModel.SliderDto.Slider.Title,
                                sliderUpdateAjaxModel.SliderDto.Slider.Description.length > 75 ? sliderUpdateAjaxModel.SliderDto.Slider.Description.substring(0, 75) : sliderUpdateAjaxModel.SliderDto.Slider.Description,
                                `<img src="/img/${sliderUpdateAjaxModel.SliderDto.Slider.Picture}" alt="${sliderUpdateAjaxModel.SliderDto.Slider.Title}" class="my-image-table" />`,
                                sliderUpdateAjaxModel.SliderDto.Slider.IsActive ? "Evet" : "Hayır",
                                sliderUpdateAjaxModel.SliderDto.Slider.IsDeleted ? "Evet" : "Hayır",
                                convertToShortDate(sliderUpdateAjaxModel.SliderDto.Slider.CreateDate),
                                sliderUpdateAjaxModel.SliderDto.Slider.CreateByName,
                                convertToShortDate(sliderUpdateAjaxModel.SliderDto.Slider.ModifiedDate),
                                sliderUpdateAjaxModel.SliderDto.Slider.ModifiedByName,
                                `
                                <button class="btn btn-primary btn-sm btn-update" data-id="${sliderUpdateAjaxModel.SliderDto.Slider.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${sliderUpdateAjaxModel.SliderDto.Slider.Id}"><span class="fas fa-minus-circle"></span></button>
                            `
                            ]);
                            tableRow.attr("name", `${id}`);
                            dataTable.row(tableRow).invalidate();
                            toastr.success(`${sliderUpdateAjaxModel.SliderDto.Message}`, "Başarılı İşlem!");
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
