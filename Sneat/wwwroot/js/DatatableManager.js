const DatatableManager =
{
    defaultDom: '<"card-header"<"head-label text-center"><"dt-action-buttons text-end"B>><"d-flex justify-content-between align-items-center row"<"col-sm-12 col-md-6"l><"col-sm-12 col-md-6"f>>t<"d-flex justify-content-between row"<"col-sm-12 col-md-6"i><"col-sm-12 col-md-6"p>>',
    defaultLengthMenu: [
        [10, 25, 50, 100, - 1],
        [10, 25, 50, 100, 'Tümü']
    ],
    exportButton: {
        extend: 'collection',
        className: 'btn btn-label-secondary dropdown-toggle mx-2',
        text: '<i class="icon-base bx bx-export me-1"></i> <span class="d-none d-lg-inline-block">Dışa Aktar</span>',
        buttons: [
            {
                extend: 'print',
                text: '<i class="icon-base bx bx-printer me-1" ></i>Yazdır',
                className: 'dropdown-item',
                exportOptions: {} //columns: [3, 4, 5, 6, 7]
            },
            {
                extend: 'excel',
                text: '<i class="icon-base bx bx-file me-1" ></i>Excel',
                className: 'dropdown-item',
                exportOptions: {}
            },
            {
                extend: 'pdf',
                text: '<i class="icon-base bx bxs-file-pdf me-1"></i>Pdf',
                className: 'dropdown-item',
                exportOptions: {}
            },
            {
                extend: 'copy',
                text: '<i class="icon-base bx bx-copy me-1" ></i>Kopyala',
                className: 'dropdown-item',
                exportOptions: {}
            }
        ]
    },


    Generate: function ({
        serverSide = false,
        path = "",
        method = "GET",
        requestData = null,
        formId = null,
        tableId = "",
        buttonId = null,
        dom = null,
        columns = [],
        columnDefs = [],
        order = [],
        ordering = true,
        searching = true,
        stateSave = false,
        scrollCollapse = true,
        scrollY = 700,
        exportEnable = true,
        exportColumns = [],
        customButtons = [],
        pageLength = 10,
        lengthMenu = null,
        responsive = true,
        hiddenColumnsInModal = [],
        extendedProps = {},
        onBefore = null,
        onSuccess = null,
        onAfter = null,
        onError = null
    }) {
        if (responsive == true) {
            const thList = $(`#${tableId} thead tr th`);
            if (thList != null && thList.length > 0 && !$(thList[0]).hasClass("control")) {
                let thOfResponsive = document.createElement("th");
                thOfResponsive.className = "control";
                $(`#${tableId} thead tr `).prepend(thOfResponsive);

                columns.unshift(
                    {
                        data: '',
                        className: 'control',
                        orderable: false,
                        searchable: false,
                        responsivePriority: 2,
                        targets: 0,
                        render: function (data, type, full, meta) {
                            return '';
                        }
                    })
            }
        }

        const _exportButton = structuredClone(this.exportButton);
        if (exportEnable == true && exportColumns != null && exportColumns.length > 0) {
            _exportButton.buttons.forEach(d => d.exportOptions.columns = exportColumns);
        }

        let _baseUrl = RequestManager.baseUrl;

        //if ($(`#${tableId}`).length > 0) $(`#${tableId}`).destroy();

        const dt = $(`#${tableId}`).DataTable({
            ajax: function (data, callback, settings) {
                data = serverSide == true ? data : {};
                if (requestData != null && typeof requestData === 'object') Object.assign(data, requestData);
                
                if (formId != null) {
                    const formDataArray = $(`#${formId}`).serializeArray();
                    const formDataObj = {};
                    formDataArray.forEach(item => {
                        formDataObj[item.name] = item.value;
                    });
                    Object.assign(data, formDataObj);
                }

                let originalBtnContent = '...';
                $.ajax({
                    url: `${_baseUrl}/${path}`,
                    type: method,
                    dataType: 'json',
                    data: data,
                    beforeSend: function () {
                        if (buttonId != null) {
                            let btn = $(`#${buttonId}`);
                            originalBtnContent = $(`#${buttonId}`).html();
                            btn.prop("disabled", true);
                            btn.html('<i class="fa-solid fa-spinner me-2"></i> Bekleyiniz');
                        }
                        if (onBefore != null && typeof onBefore === 'function') onBefore();
                    },
                    success: function (response) {
                        callback(response);
                        if (onSuccess != null && typeof onSuccess === 'function') onSuccess();
                    },
                    error: function (xhr, status, error) {
                        const isThereOnError = onError != null && typeof onError === 'function';
                        AlertManager.Error({
                            text: "Bilgiler Alınırken Bir Sorun Oluştu!",
                            callback: isThereOnError ? () => onError(error) : null
                        });
                        callback({ data: [] });
                    },
                    complete: function () {
                        if (buttonId != null) {
                            let btn = $(`#${buttonId}`);
                            btn.prop("disabled", false);
                            btn.html(originalBtnContent);
                        }
                        if (onAfter != null && typeof onAfter === 'function') onAfter();
                    }
                });
            },
            retrieve: true,
            destroy: true,
            processing: true,
            serverSide: serverSide, 
            dom: dom == null ? this.defaultDom : dom,
            columns: columns,
            columnDefs: columnDefs,
            order: order,
            ordering: ordering,
            searching: searching,
            stateSave: stateSave,
            scrollCollapse: scrollCollapse,
            scrollY: scrollY,
            buttons: exportEnable == true ? [...customButtons, _exportButton] : [...customButtons],
            pageLength: pageLength,
            lengthMenu: lengthMenu == null ? this.defaultLengthMenu : lengthMenu,
            responsive: responsive != true ? false :
                {
                    details: {
                        display: $.fn.dataTable.Responsive.display.modal({
                            header: function (row) {
                                //var data = row.data();  //+ data['full_name'];
                                return '<h4 class="pb-2">Detay</h4>';
                            }
                        }),
                        type: 'column',
                        renderer: function (api, rowIdx, columns) {
                            var data = $.map(columns, function (col, i) {
                                return (!hiddenColumnsInModal.includes(col.columnIndex) && col.title !== '') ? // col.hidden &&
                                    `<tr data-dt-row="${col.rowIndex}" data-dt-column="${col.columnIndex}">
                                    <td class="fw-bold">${col.title}</td>  
                                    <td>${col.data}</td>
                                </tr>` : '';
                            }).join('');

                            return data ? $('<table class="table"/><tbody />').append(data) : false;
                        }
                    }
                },
            ...extendedProps
        });

        return {
            table: dt,
            api: () => dt,
            reload: () => dt.ajax.reload(),
            clear: () => dt.clear().draw(),
            rowCount: () => dt.rows({ search: 'applied' }).count(),
            getSelectedRows: () => dt.rows().nodes().to$().find('input[type="checkbox"]:checked').closest('tr').map(() => dt.row(this).data()).get()
        };
    },
     
    GenerateByExistData: function ({
        data = [],
        tableId = "", 
        dom = null,
        columns = [],
        columnDefs = [],
        order = [],
        ordering = true,
        searching = true,
        stateSave = false,
        scrollCollapse = true,
        scrollY = 700,
        exportEnable = true,
        exportColumns = [],
        customButtons = [],
        pageLength = 10,
        lengthMenu = null,
        responsive = true,
        hiddenColumnsInModal = [],
        extendedProps = {}, 
    }) {
        if (responsive == true) {
            const thList = $(`#${tableId} thead tr th`);
            if (thList != null && thList.length > 0 && !$(thList[0]).hasClass("control")) {
                var thOfResponsive = document.createElement("th");
                thOfResponsive.className = "control";
                $(`#${tableId} thead tr `).prepend(thOfResponsive);

                columns.unshift(
                    {
                        data: '',
                        className: 'control',
                        orderable: false,
                        searchable: false,
                        responsivePriority: 2,
                        targets: 0,
                        render: function (data, type, full, meta) {
                            return '';
                        }
                    })
            }
        }

        const _exportButton = structuredClone(this.exportButton);
        if (exportEnable == true && exportColumns != null && exportColumns.length > 0) {
            _exportButton.buttons.forEach(d => d.exportOptions.columns = exportColumns);
        } 

        //if ($(`#${tableId}`).length > 0) $(`#${tableId}`).destroy();

        const dt = $(`#${tableId}`).DataTable({
            data: data,
            retrieve: true,
            destroy: true,
            processing: true, 
            dom: dom == null ? this.defaultDom : dom,
            columns: columns,
            columnDefs: columnDefs,
            order: order,
            ordering: ordering,
            searching: searching,
            stateSave: stateSave,
            scrollCollapse: scrollCollapse,
            scrollY: scrollY,
            buttons: exportEnable == true ? [...customButtons, _exportButton] : [...customButtons],
            pageLength: pageLength,
            lengthMenu: lengthMenu == null ? this.defaultLengthMenu : lengthMenu,
            responsive: responsive != true ? false :
                {
                    details: {
                        display: $.fn.dataTable.Responsive.display.modal({
                            header: function (row) {
                                //var data = row.data();  //+ data['full_name'];
                                return '<h4 class="pb-2">Detay</h4>';
                            }
                        }),
                        type: 'column',
                        renderer: function (api, rowIdx, columns) {
                            var data = $.map(columns, function (col, i) {
                                return (!hiddenColumnsInModal.includes(col.columnIndex) && col.title !== '') ? // col.hidden &&
                                    `<tr data-dt-row="${col.rowIndex}" data-dt-column="${col.columnIndex}">
                                    <td class="fw-bold">${col.title}</td>  
                                    <td>${col.data}</td>
                                </tr>` : '';
                            }).join('');

                            return data ? $('<table class="table"/><tbody />').append(data) : false;
                        }
                    }
                },
            ...extendedProps
        });

        return {
            table: dt,
            api: () => dt,
            reload: () => dt.ajax.reload(),
            clear: () => dt.clear().draw(),
            rowCount: () => dt.rows({ search: 'applied' }).count(),
            getSelectedRows: () => dt.rows().nodes().to$().find('input[type="checkbox"]:checked').closest('tr').map(() => dt.row(this).data()).get()
        };
    },
     
    GenerateByExistTable: function ({ 
        tableId = "",
        dom = null,
        columns = [],
        columnDefs = [],
        order = [],
        ordering = true,
        searching = true,
        stateSave = false,
        scrollCollapse = true,
        scrollY = 700,
        exportEnable = true,
        exportColumns = [],
        customButtons = [],
        pageLength = 10,
        lengthMenu = null,
        responsive = true,
        hiddenColumnsInModal = [],
        extendedProps = {},
    }) {
        if (responsive == true) {
            const thList = $(`#${tableId} thead tr th`);
            if (thList != null && thList.length > 0 && !$(thList[0]).hasClass("control")) {
                var thOfResponsive = document.createElement("th");
                thOfResponsive.className = "control";
                $(`#${tableId} thead tr `).prepend(thOfResponsive);

                columns.unshift(
                    {
                        data: '',
                        className: 'control',
                        orderable: false,
                        searchable: false,
                        responsivePriority: 2,
                        targets: 0,
                        render: function (data, type, full, meta) {
                            return '';
                        }
                    })
            }
        }

        const _exportButton = structuredClone(this.exportButton);
        if (exportEnable == true && exportColumns != null && exportColumns.length > 0) {
            _exportButton.buttons.forEach(d => d.exportOptions.columns = exportColumns);
        }

        //if ($(`#${tableId}`).length > 0) $(`#${tableId}`).destroy();

        const dt = $(`#${tableId}`).DataTable({
            retrieve: true,
            destroy: true,
            processing: true,
            dom: dom == null ? this.defaultDom : dom,
            columns: columns,
            columnDefs: columnDefs,
            order: order,
            ordering: ordering,
            searching: searching,
            stateSave: stateSave,
            scrollCollapse: scrollCollapse,
            scrollY: scrollY,
            buttons: exportEnable == true ? [...customButtons, _exportButton] : [...customButtons],
            pageLength: pageLength,
            lengthMenu: lengthMenu == null ? this.defaultLengthMenu : lengthMenu,
            responsive: responsive != true ? false :
                {
                    details: {
                        display: $.fn.dataTable.Responsive.display.modal({
                            header: function (row) {
                                //var data = row.data();  //+ data['full_name'];
                                return '<h4 class="pb-2">Detay</h4>';
                            }
                        }),
                        type: 'column',
                        renderer: function (api, rowIdx, columns) {
                            var data = $.map(columns, function (col, i) {
                                return (!hiddenColumnsInModal.includes(col.columnIndex) && col.title !== '') ? // col.hidden &&
                                    `<tr data-dt-row="${col.rowIndex}" data-dt-column="${col.columnIndex}">
                                    <td class="fw-bold">${col.title}</td>  
                                    <td>${col.data}</td>
                                </tr>` : '';
                            }).join('');

                            return data ? $('<table class="table"/><tbody />').append(data) : false;
                        }
                    }
                },
            ...extendedProps
        });

        return {
            table: dt,
            api: () => dt,
            reload: () => dt.ajax.reload(),
            clear: () => dt.clear().draw(),
            rowCount: () => dt.rows({ search: 'applied' }).count(),
            getSelectedRows: () => dt.rows().nodes().to$().find('input[type="checkbox"]:checked').closest('tr').map(() => dt.row(this).data()).get()
        };
    },
}