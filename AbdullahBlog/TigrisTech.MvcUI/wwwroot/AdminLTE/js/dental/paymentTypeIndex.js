$(document).ready(function () {

    /* DataTables start here. */

    const dataTable = $('#paymentTypesTables').DataTable({
        dom:
            "<'row'<'col-sm-3'l><'col-sm-6 text-center'B><'col-sm-3'f>>" +
            "<'row'<'col-sm-12'tr>>" +
            "<'row'<'col-sm-5'i><'col-sm-7'p>>",
       /* "order": [[6, "desc"]],*/
        buttons: [
            {
                text: 'Ekle',
                attr: {
                    id: "btnAdd",
                },
                className: 'btn btn-success',
                action: function (e, dt, node, config) {
                }
            },
            {
                text: 'Yenile',
                className: 'btn btn-warning',
                action: function (e, dt, node, config) {

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
    });

    /* DataTables end here*/

    /* Ajax GET / Getting the _PaymentTypeAddPartila as Modal Form starts from here. */

    $(function () {
        const url = '/Admin/PaymentType/Add/';
        const placeHolderDiv = $('#modalPlaceHolder');
        $('#btnAdd').click(function () {
            $.get(url).done(function (data) {
               
                placeHolderDiv.html(data);
                placeHolderDiv.find(".modal").modal('show');
            });
        });

        /* Ajax GET / Getting the _PaymentTypeAddPartial as Modal Form ends here.*/

        /* Ajax POST / Posting the FormData as PaymentAddDto starts from here.*/

        placeHolderDiv.on('click', '#btnSave', function (event) {
            event.preventDefault();
            const form = $('#form-paymenttype-add');
            const actionUrl = form.attr('action');
            const dataToSend = form.serialize();
            $.post(actionUrl, dataToSend).done(function (data) {
                const paymentTypeAddAjaxModel = jQuery.parseJSON(data);
                console.log(paymentTypeAddAjaxModel);
                const newFormBody = $('.modal-body', paymentTypeAddAjaxModel.PaymentTypeAddPartial);
                placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                if (isValid) {
                    placeHolderDiv.find('.modal').modal('hide');
                    const newTableRow = dataTable.row.add([
                        paymentTypeAddAjaxModel.PaymentTypeDto.PaymentType.Id,
                        paymentTypeAddAjaxModel.PaymentTypeDto.PaymentType.Name,
                        paymentTypeAddAjaxModel.PaymentTypeDto.PaymentType.IsActive ? "Evet" : "Hayır",
                        paymentTypeAddAjaxModel.PaymentTypeDto.PaymentType.IsDeleted ? "Evet" : "Hayır",
                        paymentTypeAddAjaxModel.PaymentTypeDto.PaymentType.Note,
                        convertToShortDate(paymentTypeAddAjaxModel.PaymentTypeDto.PaymentType.CreatedDate),
                        categoryAddAjaxModel.paymentTypeAddAjaxModel.PaymentTypeDto.PaymentType.CreatedByName,
                        convertToShortDate(paymentTypeAddAjaxModel.PaymentTypeDto.PaymentType.ModifiedDate),
                        paymentTypeAddAjaxModel.PaymentTypeDto.PaymentType.ModifiedByName,
                        `
                                <button class="btn btn-primary btn-sm btn-update" data-id="${paymentTypeAddAjaxModel.PaymentTypeDto.PaymentType.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${cpaymentTypeAddAjaxModel.PaymentTypeDto.PaymentType.Id}"><span class="fas fa-minus-circle"></span></button>
                                            `
                    ]).node();
                    const jqueryTableRow = $(newTableRow);
                    jqueryTableRow.attr('name', `${paymentTypeAddAjaxModel.PaymentTypeDto.PaymentType.Id}`);
                    dataTable.draw();
                    toastr.success(`${paymentTypeAddAjaxModel.PaymentTypeDto.Message}`, 'Başarılı İşlem!');
                } else {
                    let summaryText = "";
                    $('#validation-summary > ul > li').each(function () {
                        let text = $(this).text();
                        summaryText = `*${text}\n`;
                    });
                    toastr.warning(summaryText);
/*                    toastr.warning('warning messages');*/
                }
            });
        });
    });

    /* Ajax POST / Posting the FormData as PaymentTypeAddDto ends here. */

    /* Ajax POST / Deleting a PaymentType starts from here.*/

});