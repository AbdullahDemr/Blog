$(document).ready(function () {

    /* DataTables start here. */

    const dataTable = $('#patientsTable').DataTable({
        dom:
            "<'row'<'col-sm-3'l><'col-sm-6 text-center'B><'col-sm-3'f>>" +
            "<'row'<'col-sm-12'tr>>" +
            "<'row'<'col-sm-5'i><'col-sm-7'p>>",
            "order": [[3, "desc"]],
        buttons: [

            {
                text: 'Ekle',
                attr: {
                    id: "btnAdd",
                },
                className: 'btn  btn-success',
                action: function (e, dt, node, config) {
                }
            },
            {
                text: 'Yenile',
                className: 'btn  btn-warning',
                action: function (e, dt, node, config) {
                    $.ajax({
                        type: 'GET',
                        url: '/Admin/Patient/GetAllPatients/',
                        contentType: "application/json",
                        beforeSend: function () {
                            $('#patientsTable').hide();
                            $('.spinner-border').show();
                        },
                        success: function (data) {
                            const patientListDto = jQuery.parseJSON(data);
                            dataTable.clear();
                            console.log(patientListDto);
                            if (patientListDto.ResultStatus === 0) {
                                $.each(patientListDto.Patient.$values,
                                    function (index, patient) {
                                        const newTableRow = dataTable.row.add([
                                           
                                            patient.FirstName,
                                            patient.LastName,
                                            patient.PhoneNumber,
                                            convertToShortDate(patient.CreateDate),
                                            `
                                <button class="btn btn-info btn-sm btn-detail" data-id="${patient.Id}"><span class="fa fa-info-circle"></span></button>
                                <button class="btn btn-primary btn-sm btn-update" data-id="${patient.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${patient.Id}"><span class="fas fa-minus-circle"></span></button>
                                            `
                                        ]).node();
                                        const jqueryTableRow = $(newTableRow);
                                        jqueryTableRow.attr('name', `${patient.Id}`);
                                    });
                                dataTable.draw();
                                $('.spinner-border').hide();
                                $('#usersTable').fadeIn(1400);
                            } else {
                                toastr.error(`${patientListDto.Message}`, 'İşlem Başarısız!');
                            }
                        },
                        error: function (err) {
                            console.log(err);
                            $('.spinner-border').hide();
                            $('#patientsTable').fadeIn(1000);
                            toastr.error(`${err.responseText}`, 'Hata!');
                        }
                    });
                }
            },

            { extend: "excel", className: "btn-sm btn-secondary" },
            { extend: "pdfHtml5", className: "btn-sm btn-secondary" },
            { extend: "print", className: "btn-sm btn-secondary" },

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

    /* DataTables end here */

    /* Ajax GET / Getting the _PatientAddPartial as Modal Form starts from here. */

    $(function () {
        const url = '/Admin/Patient/Add/';
        const placeHolderDiv = $('#modalPlaceHolder');
     
        $('#btnAdd').click(function () {
            $.get(url).done(function (data) {
                placeHolderDiv.html(data);
                placeHolderDiv.find(".modal").modal('show');
            });
        });

        /* Ajax GET / Getting the _PatientAddPartial as Modal Form ends here. */

        /* Ajax POST / Posting the FormData as PatientAddDto starts from here. */

        placeHolderDiv.on('click',
            '#btnSave',
            function (event) {
                event.preventDefault();
                const form = $('#form-patient-add');
                const actionUrl = form.attr('action');
                const dataToSend = form.serialize();
                $.post(actionUrl, dataToSend).done(function (data) {
                    const patientAddAjaxModel = jQuery.parseJSON(data);
                    const newFormBody = $('.modal-body', patientAddAjaxModel.PatientAddPartial);
                    placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                    const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                    if (isValid) {
                        placeHolderDiv.find('.modal').modal('hide');
                        const newTableRow = dataTable.row.add([
                            patientAddAjaxModel.PatientDto.Patient.FirstName,
                            patientAddAjaxModel.PatientDto.Patient.LastName,
                            patientAddAjaxModel.PatientDto.Patient.Phone,
                            convertToShortDate(patientAddAjaxModel.PatientDto.Patient.CreateDate),
                            patientAddAjaxModel.PatientDto.Patient.UserId,
                            `<td class="table-warning">Bakiye Girilmemiş</td>`,
                            `
                             <td class="text-right">
                                 <button class="btn btn-success btn-xs btn-detail" data-id="${patientAddAjaxModel.PatientDto.Patient.Id}"><span class="fa fa-info-circle"></span></button>
                                <button class="btn btn-primary btn-xs btn-update" data-id="${patientAddAjaxModel.PatientDto.Patient.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-xs btn-delete" data-id="${patientAddAjaxModel.PatientDto.Patient.Id}"><span class="fas fa-minus-circle"></span></button>
                             </td>
                            `
                        ]).node();
                        const jqueryTableRow = $(newTableRow);
                        jqueryTableRow.attr('name', `${patientAddAjaxModel.PatientDto.Patient.Id}`);
                        dataTable.draw();
                        toastr.success(`${patientAddAjaxModel.PatientDto.Message}`, 'Başarılı İşlem!');
                    } else {
                        let summaryText = "";
                        $('#validation-summary > ul > li').each(function () {
                            let text = $(this).text();
                            summaryText = `*${text}\n`;
                        });
                           toastr.warning(summaryText);
                        toastr.success('warning messages');
                    }
                });
            });
    });

    /* Ajax POST / Deleting a Patient starts from here */

    $(document).on('click',
        '.btn-delete',
        function (event) {
            event.preventDefault();
            const id = $(this).attr('data-id');
            const tableRow = $(`[name="${id}"]`);
            const categoryName = tableRow.find('td:eq(1)').text();
            Swal.fire({
                title: 'Silmek istediğinize emin misiniz?',
                text: `${categoryName} adlı hasta silinicektir!`,
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
                        data: { patientId: id },
                        url: '/Admin/Patient/Delete/',
                        success: function (data) {
                            const patientDto = jQuery.parseJSON(data);
                            if (patientDto.ResultStatus === 0) {
                                Swal.fire(
                                    'Silindi!',
                                    `${patientDto.Patient.FirstName} adlı hasta başarıyla silinmiştir.`,
                                    'success'
                                );
                                dataTable.row(tableRow).remove().draw();
                            } else {
                                Swal.fire({
                                    icon: 'error',
                                    title: 'Başarısız İşlem!',
                                    text: `${patientDto.Message}`,
                                });
                            }
                        },
                        error: function (err) {
                            console.log(err);
                            toastr.error(`${err.responseText}`, "Hata!")
                        }
                    });
                }
            });
        });

    /* Ajax GET / Getting the _PatientUpdatePartial as Modal Form starts from here. */

    $(function () {
        const url = '/Admin/Patient/Update/';
        const placeHolderDiv = $('#modalPlaceHolder');
        $(document).on('click',
            '.btn-update',
            function (event) {
                event.preventDefault();
                const id = $(this).attr('data-id');
                $.get(url, { patientId: id }).done(function (data) {
                    placeHolderDiv.html(data);
                    placeHolderDiv.find('.modal').modal('show');
                }).fail(function () {
                    toastr.error("Bir hata oluştu.");
                });
            });

        /* Ajax POST / Updating a Patient starts from here */

        placeHolderDiv.on('click',
            '#btnUpdate',
            function (event) {
                event.preventDefault();
                const form = $('#form-patient-update');
                const actionUrl = form.attr('action');
                const dataToSend = form.serialize();
                $.post(actionUrl, dataToSend).done(function (data) {
                    const patientUpdateAjaxModel = jQuery.parseJSON(data);
                    const newFormBody = $('.modal-body', patientUpdateAjaxModel.PatientUpdatePartial);
                    placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                    const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                    if (isValid) {
                        const id = patientUpdateAjaxModel.PatientDto.Patient.Id;
                        const tableRow = $(`[name="${id}"]`);
                        placeHolderDiv.find('.modal').modal('hide');
                        dataTable.row(tableRow).data([
                            patientUpdateAjaxModel.PatientDto.Patient.FirstName,
                            patientUpdateAjaxModel.PatientDto.Patient.LastName,
                            patientUpdateAjaxModel.PatientDto.Patient.Phone,
                            convertToShortDate(patientUpdateAjaxModel.PatientDto.Patient.CreateDate),
                            patientUpdateAjaxModel.PatientDto.Patient.UserId,
                            `<td class="table-warning">Bakiye Girilmemiş</td>`,
                            `   <button class="btn btn-success btn-xs btn-detail" data-id="${patientUpdateAjaxModel.PatientDto.Patient.Id}"><span class="fa fa-info-circle"></span></button>
                                <button class="btn btn-primary btn-xs btn-update" data-id="${patientUpdateAjaxModel.PatientDto.Patient.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-xs btn-delete" data-id="${patientUpdateAjaxModel.PatientDto.Patient.Id}"><span class="fas fa-minus-circle"></span></button>
                             `
                        ]);
                        tableRow.attr("name", `${id}`);
                        dataTable.row(tableRow).invalidate();
                        toastr.success(`${patientUpdateAjaxModel.PatientDto.Message}`, "Başarılı İşlem!");
                    } else {
                        let summaryText = "";
                        $('#validation-summary > ul > li').each(function () {
                            let text = $(this).text();
                            summaryText += `*${text}\n`;
                        });
                        toastr.warning(summaryText);
                    }
                }).fail(function (response) {
                    console.log(response);
                });
            });

    });
});