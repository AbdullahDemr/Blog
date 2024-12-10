$(document).ready(function () {
    const dataTableToday = $('#todayTable').DataTable({
        dom:
            "<'row'<'col-sm-3'l><'col-sm-6 text-center'B><'col-sm-3'f>>" +
            "<'row'<'col-sm-12'tr>>" +
            "<'row'<'col-sm-5'i><'col-sm-7'p>>",
        buttons: [
            {
                text: 'Yenile',
                className: 'btn btn-xs  btn-warning',
                action: function (e, dt, node, config) {

                }
            },

            { extend: "excel", className: "btn-xs btn-secondary" },
            { extend: "pdfHtml5", className: "btn-xs btn-secondary" },
            { extend: "print", className: "btn-xs btn-secondary" },
            { extend: "colvis", className: "btn-xs btn-secondary" },
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
        "footerCallback": function (row, data, start, end, display) {
            var api = this.api(), data;

            // Remove the formatting to get integer data for summation
            var intVal = function (i) {
                return typeof i === 'string' ?
                    i.replace(/[\$,]/g, '') * 1 :
                    typeof i === 'number' ?
                        i : 0;
            };
            //Total over all pages DebtAmount
            var totalDebt = display.map(el => data[el][1]).reduce((a, b) => intVal(parseInt(a)) + intVal(parseInt(b)), 0);

            //Total over this page DebtAmount
            pageTotalDebt = api
                .column(1, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(parseInt(a)) + intVal(parseInt(b));
                }, 0);

            //Update footer DebtAmount
            $(api.column(1).footer()).html(
                '₺ ' + pageTotalDebt + ' ( ₺ ' + totalDebt + ' Toplam)').css('color', 'blue');

            //Total over all pages PaymentAmount
            var totalPayment = display.map(el => data[el][2]).reduce((a, b) => intVal(parseInt(a)) + intVal(parseInt(b)), 0);

            //Total over this page PaymentAmount
            pageTotalPayment = api
                .column(2, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(parseInt(a)) + intVal(parseInt(b));
                }, 0);
            //Update footer PaymentAmount
            $(api.column(2).footer()).html(
                '₺ ' + pageTotalPayment + ' ( ₺ ' + totalPayment + ' Toplam)').css('color', 'blue');

            // Total over all pages
            var total = display.map(el => data[el][3]).reduce((a, b) => intVal(parseInt(a)) + intVal(parseInt(b)), 0);


            // Total over this page
            pageTotal = api
                .column(3, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(parseInt(a)) + intVal(parseInt(b));
                }, 0);


            // Update footer
            $(api.column(3).footer()).html(
                '₺ ' + pageTotal + ' ( ₺ ' + total + ' Toplam)').css('color', 'blue');
        },
    });
    const dataTableWeek = $('#weekTable').DataTable({
        dom:
            "<'row'<'col-sm-3'l><'col-sm-6 text-center'B><'col-sm-3'f>>" +
            "<'row'<'col-sm-12'tr>>" +
            "<'row'<'col-sm-5'i><'col-sm-7'p>>",
        buttons: [
            {
                text: 'Yenile',
                className: 'btn btn-xs btn-warning',
                action: function (e, dt, node, config) {

                }
            },

            { extend: "excel", className: "btn-xs btn-secondary" },
            { extend: "pdfHtml5", className: "btn-xs btn-secondary" },
            { extend: "print", className: "btn-xs btn-secondary" },
            { extend: "colvis", className: "btn-xs btn-secondary" },
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
        "footerCallback": function (row, data, start, end, display) {
            var api = this.api(), data;

            // Remove the formatting to get integer data for summation
            var intVal = function (i) {
                return typeof i === 'string' ?
                    i.replace(/[\$,]/g, '') * 1 :
                    typeof i === 'number' ?
                        i : 0;
            };
            //Total over all pages DebtAmount
            var totalDebt = display.map(el => data[el][1]).reduce((a, b) => intVal(parseInt(a)) + intVal(parseInt(b)), 0);

            //Total over this page DebtAmount
            pageTotalDebt = api
                .column(1, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(parseInt(a)) + intVal(parseInt(b));
                }, 0);

            //Update footer DebtAmount
            $(api.column(1).footer()).html(
                '₺ ' + pageTotalDebt + ' ( ₺ ' + totalDebt + ' Toplam)'
            ).css('color', 'blue');




            //Total over all pages PaymentAmount
            var totalPayment = display.map(el => data[el][2]).reduce((a, b) => intVal(parseInt(a)) + intVal(parseInt(b)), 0);

            //Total over this page PaymentAmount
            pageTotalPayment = api
                .column(2, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(parseInt(a)) + intVal(parseInt(b));
                }, 0);
            //Update footer PaymentAmount
            $(api.column(2).footer()).html(
                '₺ ' + pageTotalPayment + ' ( ₺ ' + totalPayment + ' Toplam)'
            ).css('color', 'blue');



            // Total over all pages
            var total = display.map(el => data[el][3]).reduce((a, b) => intVal(parseInt(a)) + intVal(parseInt(b)), 0);


            // Total over this page
            pageTotal = api
                .column(3, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(parseInt(a)) + intVal(parseInt(b));
                }, 0);


            // Update footer
            $(api.column(3).footer()).html(
                '₺ ' + pageTotal + ' ( ₺ ' + total + ' Toplam)'
            ).css('color', 'blue');
        },
    });
    const dataTableMonth = $('#monthTable').DataTable({
        dom:
            "<'row'<'col-sm-3'l><'col-sm-6 text-center'B><'col-sm-3'f>>" +
            "<'row'<'col-sm-12'tr>>" +
            "<'row'<'col-sm-5'i><'col-sm-7'p>>",
        buttons: [
            {
                text: 'Yenile',
                className: 'btn btn-xs btn-warning',
                action: function (e, dt, node, config) {

                }
            },

            { extend: "excel", className: "btn-xs btn-secondary" },
            { extend: "pdfHtml5", className: "btn-xs btn-secondary" },
            { extend: "print", className: "btn-xs btn-secondary" },
            { extend: "colvis", className: "btn-xs btn-secondary" },
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
        "footerCallback": function (row, data, start, end, display) {
            var api = this.api(), data;

            // Remove the formatting to get integer data for summation
            var intVal = function (i) {
                return typeof i === 'string' ?
                    i.replace(/[\$,]/g, '') * 1 :
                    typeof i === 'number' ?
                        i : 0;
            };
            //Total over all pages DebtAmount
            var totalDebt = display.map(el => data[el][1]).reduce((a, b) => intVal(parseInt(a)) + intVal(parseInt(b)), 0);

            //Total over this page DebtAmount
            pageTotalDebt = api
                .column(1, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(parseInt(a)) + intVal(parseInt(b));
                }, 0);

            //Update footer DebtAmount
            $(api.column(1).footer()).html(
                '₺ ' + pageTotalDebt + ' ( ₺ ' + totalDebt + ' Toplam)'
            ).css('color', 'blue');




            //Total over all pages PaymentAmount
            var totalPayment = display.map(el => data[el][2]).reduce((a, b) => intVal(parseInt(a)) + intVal(parseInt(b)), 0);

            //Total over this page PaymentAmount
            pageTotalPayment = api
                .column(2, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(parseInt(a)) + intVal(parseInt(b));
                }, 0);
            //Update footer PaymentAmount
            $(api.column(2).footer()).html(
                '₺ ' + pageTotalPayment + ' ( ₺ ' + totalPayment + ' Toplam)'
            ).css('color', 'blue');



            // Total over all pages
            var total = display.map(el => data[el][3]).reduce((a, b) => intVal(parseInt(a)) + intVal(parseInt(b)), 0);


            // Total over this page
            pageTotal = api
                .column(3, { page: 'current' })
                .data()
                .reduce(function (a, b) {
                    return intVal(parseInt(a)) + intVal(parseInt(b));
                }, 0);


            // Update footer
            $(api.column(3).footer()).html(
                '₺ ' + pageTotal + ' ( ₺ ' + total + ' Toplam)'
            ).css('color', 'blue');
        },
    });
});