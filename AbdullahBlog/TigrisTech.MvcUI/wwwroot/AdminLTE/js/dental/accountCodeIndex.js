

$(document).ready(function () {

    /*DataTables start here. */

    const dataTable = $('#accountCodesTable').DataTable({
        dom:
            "<'row'<'col-sm-3'l><'col-sm-6 text-center'B><'col-sm-3'f>>" +
            "<'row'<'col-sm-12'tr>>" +
            "<'row'<'col-sm-5'i><'col-sm-7'p>>",
        buttons: [
            {
                text: 'Ekle',
                attr: {
                      id:"btnAdd",
                },
                className: 'btn btn-success',
                action: function (e, dt, node, config) {

                }
            },
            {
                text: 'Yenile',
                className: 'btn btn-warning',
                action(e, dt, node, config) {
                    $.ajax({
                        type: 'GET',
                        url: '/Admin/AccountCode/GetAllAccountCodes/',
                        contentType: "application/json",
                        beforeSend: function () {
                            $('#accountCodesTable').hide();
                            $('.spinner-border').show();
                        },
                        success: function (data) {
                            const accountCodeListDto = JQuery.parseJSON(data);
                            dataTable.clear();
                            if (accountCodeListDto.ResultStatus === 0) {
                                $.each(accountCodeListDto.AccountCode.$values, function (index, accountCode) {
                                    const newTableRow = dataTable.row.add([
                                        accountCode.Id,
                                        accountCode.Name,
                                        accountCode.Description,

                                        `
                                <button class="btn btn-info btn-sm btn-detail" data-id="${patient.Id}"><span class="fas fa-newspaper"></span></button>
                                <button class="btn btn-warning btn-sm btn-assign" data-id="${patient.Id}"><span class="fas fa-user-shield"></span></button>
                                <button class="btn btn-primary btn-sm btn-update" data-id="${patient.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${patient.Id}"><span class="fas fa-minus-circle"></span></button>
                                            `
                                    ]).node();
                                    const jqueryTableRow = $(newTableRow);
                                    jqueryTableRow.attr('name', `${accountCode.Id}`);
                                });
                                dataTable.draw();
                                $('.spinner-border').hide();
                                $('#accountCodesTable').fadeIn("1400");
                            } else {
                                toastr.error(`${accountCodeListDto.Message}`, 'İşlem Başarısız!');
                            }
                        },
                        error: function (err) {
                            $('.spinner-border').hide();
                            $('#accountCodesTable').fadeIn(1000);
                            toastr.error(`${err.responseText}`, 'Hata!');
                        }
                    });
                }
            },

            { extend: "excel", className: "btn-sm btn-info" },
            { extend: "pdfHtml5", className: "btn-sm btn-info" },
            { extend: "print", className: "btn-sm btn-info" },
            { extend: "colvis", className: "btn-sm btn-info" },
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
    })

    /*DataTables end here*/

    /*Ajax Get / Getting the _AccountCodeAddPartial as Modal Form starts from here.*/

    $(function () {
        const url = '/Admin/AccountCode/Add/';
        const placeHolderDiv = $('#modalPlaceHolder');
        $('#btnAdd').click(function () {
            $.get(url).done(function (data) {
                placeHolderDiv.html(data);
                placeHolderDiv.find(".modal").modal('show');
            });
        });

        /*Ajax GET / Getting the _AccountCodeAddPartial as Modal Form ends here.*/

        /*Ajas POST / Posting the FormData as AccountCodeAddDto starts from here.*/

        placeHolderDiv.on('click', '#btnSave', function (event) {
            event.preventDefault();
            const form = $('#form-accountcode-add');
            const actionUrl = form.attr('action');
            const dataToSend = form.serialize();
            $.post(actionUrl, dataToSend).done(function (data) {
                const accountCodeAddAjaxModel = jQuery.parseJSON(data);
                console.log(accountCodeAddAjaxModel);
                const newFormBody = $('.modal-body', accountCodeAddAjaxModel.AccountCodeAddPartial);
                placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                if (isValid) {
                    placeHolderDiv.find('.modal').modal('hide');
                    const newTableRow = dataTable.row.add([
                        accountCodeAddAjaxModel.AccountCodeDto.AccountCode.Id,
                        accountCodeAddAjaxModel.AccountCodeDto.AccountCode.Name,
                        accountCodeAddAjaxModel.AccountCodeDto.AccountCode.Description,
                        accountCodeAddAjaxModel.AccountCodeDto.AccountCode.IsActive ? "Evet" : "Hayır",
                        accountCodeAddAjaxModel.AccountCodeDto.AccountCode.IsDeleted ? "Evet" : "Hayır",
                        accountCodeAddAjaxModel.AccountCodeDto.AccountCode.Note,
                        convertToShortDate(accountCodeAddAjaxModel.AccountCodeDto.AccountCode.CreatedDate),
                        accountCodeAddAjaxModel.AccountCodeDto.AccountCode.CreatedByName,
                        convertToShortDate(accountCodeAddAjaxModel.AccountCodeDto.AccountCode.ModifiedDate),
                        accountCodeAddAjaxModel.AccountCodeDto.AccountCode.ModifiedDate,
                        `
                                <button class="btn btn-primary btn-sm btn-update" data-id="${accountCodeAddAjaxModel.AccountCodeDto.AccountCode.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${accountCodeAddAjaxModel.AccountCodeDto.AccountCode.Id}"><span class="fas fa-minus-circle"></span></button>
                                            `
                    ]).node();
                    const jqueryTableRow = $(newTableRow);
                    jqueryTableRow.attr('name', `${accountCodeAddAjaxModel.AccountCodeDto.AccountCode.Id}`);
                    dataTable.draw();
                    toastr.success(`${accountCodeAddAjaxModel.AccountCodeDto.Message}`, 'Başarılı İşlem!');
                }
                else {
                    let summaryText = "";
                    $('#validation-summary > ul > li').each(function () {
                        let text = $(this).text();
                        summaryText = `*${text}\n`;
                    });
                    toastr.warning(summaryText);
                }
            });
        });
    })
});