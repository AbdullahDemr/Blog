$(document).ready(function () {

    /* DataTables start here.*/

    const dataTable = $('#articlesTable').DataTable({
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
            },
            {
                text: 'Yenile',
                className: 'btn btn-warning',
                action: function (e, dt, node, config) {
                    $.ajax({
                        type: 'GET',
                        url: '/Admin/Article/GetAllArticles/',
                        contentType: "application/json",
                        beforeSend: function () {
                            $('#articlesTable').hide();
                            $('.spinner-border').show();
                        },
                        success: function (data) {
                           
                            const articleResult = jQuery.parseJSON(data);
                            console.log(articleResult);

                            dataTable.clear();
                            if (articleResult.Data) {
                                let categoriesArray = [];
                                $.each(articleResult.Data.Articles.$values, function (index, article) {
                                    const newArticle = getJsonNetObject(article, articleResult.Data.Articles.$values);
                                    let newCategory = getJsonNetObject(newArticle.Category, newArticle);
                                    if (newCategory !== null) {
                                        categoriesArray.push(newCategory);
                                    }
                                    if (newCategory === null) {
                                        newCategory = categoriesArray.find((category) => {
                                            return category.$id === newArticle.Category.$ref;
                                        })
                                    }
                                    console.log(newArticle);
                                    console.log(newCategory);
                                        const newTableRow = dataTable.row.add([
                                            newArticle.Id,
                                            newCategory.Name,
                                            newArticle.Title,
                                            `<img src="/img/${newArticle.Thumbnail}" alt="${newArticle.Title}" class="my-image-table" />`,
                                            `${convertToShortDate(newArticle.Date)}`,
                                            newArticle.ViewsCount,
                                            newArticle.CommentCount,
                                            `${newArticle.IsActive ? "Evet" : "Hayır"}`,
                                            `${newArticle.IsDeleted ? "Evet" : "Hayır"}`,
                                            `${convertToShortDate(newArticle.CreateDate)}`,
                                             newArticle.CreateByName,
                                            `${convertToShortDate(newArticle.ModifiedDate)}`,
                                            newArticle.ModifiedByName,
                                            `
                                <a class="btn btn-primary btn-sm btn-update" href="/Admin/Article/Update?${newArticle.Id}"><span class="fas fa-edit"></span></a>
                                <a class="btn btn-danger btn-sm btn-delete" href="/Admin/Article/Delete?${newArticle.Id}""><span class="fas fa-minus-circle"></span></a>
                                            `
                                        ]).node();
                                        const jqueryTableRow = $(newTableRow);
                                        jqueryTableRow.attr('name', `${newArticle.Id}`);
                                    });
                                dataTable.draw();
                                $('.spinner-border').hide();
                                $('#articlesTable').fadeIn(1400);
                            }
                            else {
                                toastr.error(`${articleResult.Message}`, 'Blog Sayfası yüklenirken hata oluştu!')
                            }
                        },
                        error: function (err) {
                            console.log(err);
                            $('.spinner-border').hide();
                            $('#articlesTable').fadeIn(1000);
                            toastr.error(`${err.responseText}`, 'Hata!')
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
    });

    /* DataTables ends here */

    /* Ajax POST / Deleting a User starts from here. */

    $(document).on('click', '.btn-delete', function (event) {
        event.preventDefault();
        const id = $(this).attr('data-id');
        const tableRow = $(`[name="${id}"]`);
        const articleTitle = tableRow.find('td:eq(2)').text();//1 index Name 
        Swal.fire({
            title: 'Silmek istediğinize emin misiniz?',
            text: `${articleTitle} başlılı makale silinecektir.`,
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
                    data: { articleId: id },
                    url: '/Admin/Article/Delete/',
                    success: function (data) {
                        const articleResult = jQuery.parseJSON(data);
                        if (articleResult.ResultStatus === 0) {
                            Swal.fire(
                                'Silindi',
                                `${articleResult.Message}`,
                                'success'
                            );

                            dataTable.row(tableRow).remove().draw();
                        }
                        else {
                            Swal.fire({
                                icon: 'error',
                                title: 'Başarısız işlem!',
                                text: `${articleResult.Message}`,
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


});
