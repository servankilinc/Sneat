﻿//const DatatableManager =
//{
//    // Aşağıdkai Gibi metodları extendedProps içerinde gönderilmesi yeterli
//    //createdRow = null,
//    //footerCallback = null,
//    //initComplete = null,

//    // Tabloya buttonlar eklenebilir
//    //extendedButtons:[{
//    //    text: '<i class="icon-base bx bx-plus me-1"></i> <span class="d-none d-lg-inline-block">Add New Record</span>',
//    //    className: 'create-new btn btn-primary'
//    //}]


//    GenerateByData: function ({
//        tableId = "",
//        data = [],
//        dom = null,
//        columns = [],
//        columnDefs = [],
//        order = [],
//        ordering = true,
//        searching = true,
//        stateSave = false,
//        scrollCollapse = true,
//        scrollY = 700,
//        exportEnable = true,
//        exportColumns = null,
//        customButtons = [],
//        displayLength = 10,
//        lengthMenu = null,
//        responsive = true,
//        extendedProps = {}
//    }) {
//        let _exportButton = structuredClone(this.exportButton);
//        if (exportEnable == true && exportColumns != null) {
//            _exportButton.buttons.forEach(d => d.exportOptions.columns = exportColumns);
//        }

//        var _dataTable = new DataTable(`#${tableId}`, {
//            data: data,
//            dom: dom == null ? this.defaultDom : dom,
//            columns: columns,
//            columnDefs: columnDefs,
//            order: order,
//            ordering: ordering,
//            searching: searching,
//            stateSave: stateSave,
//            scrollCollapse: scrollCollapse,
//            scrollY: scrollY,
//            buttons: exportEnable == true ? [...customButtons, _exportButton] : [...customButtons],
//            displayLength: displayLength,
//            lengthMenu: lengthMenu == null ? this.defaultLengthMenu : lengthMenu,
//            responsive: responsive != true ? false :
//                {
//                    details: {
//                        display: $.fn.dataTable.Responsive.display.modal({
//                            header: function (row) {
//                                var data = row.data();
//                                return '<h4 class="pb-2">Detay</h4>'; //+ data['full_name'];
//                            }
//                        }),
//                        type: 'column',
//                        renderer: function (api, rowIdx, columns) {
//                            var data = $.map(columns, function (col, i) {
//                                return col.title !== '' ?
//                                    `<tr data-dt-row="${col.rowIndex}" data-dt-column="${col.columnIndex}">
//                                    <td class="fw-bold">${col.title}</td>  
//                                    <td>${col.data}</td>
//                                </tr>` : '';
//                            }).join('');

//                            return data ? $('<table class="table"/><tbody />').append(data) : false;
//                        }
//                    }
//                },
//            ...extendedProps
//        });

//        return _dataTable;
//    },

//    GenerateServerSide: function ({
//        url = "",
//        method = "GET",
//        requestData = null,
//        formId = null,
//        tableId = "",
//        dom = null,
//        columns = [],
//        columnDefs = [],
//        order = [],
//        ordering = true,
//        searching = true,
//        stateSave = false,
//        scrollCollapse = true,
//        scrollY = 700,
//        exportEnable = true,
//        exportColumns = null,
//        customButtons = [],
//        pageLength = 10,
//        lengthMenu = null,
//        responsive = true,
//        hiddenColumnsInModal = [],
//        extendedProps = {},
//        onBefore = null,
//        onLoaded = null
//    }) {
//        if (responsive == true) {
//            var thList = $(`#${tableId} thead tr th`);
//            if (thList != null && thList.length > 0 && !$(thList[0]).hasClass("control")) {
//                var thOfResponsive = document.createElement("th");
//                thOfResponsive.className = "control";
//                $(`#${tableId} thead tr `).prepend(thOfResponsive);

//                columns.unshift(
//                    {
//                        data: '',
//                        className: 'control',
//                        orderable: false,
//                        searchable: false,
//                        responsivePriority: 2,
//                        targets: 0,
//                        render: function (data, type, full, meta) {
//                            return '';
//                        }
//                    })
//            }
//        }

//        var _exportButton = structuredClone(this.exportButton);
//        if (exportEnable == true && exportColumns != null) {
//            _exportButton.buttons.forEach(d => d.exportOptions.columns = exportColumns);
//        }

//        var _dataTable = $(`#${tableId}`).DataTable({
//            ajax: function (data, callback, settings) {
//                if (formId != null) {
//                    const formDataArray = $(formId).serializeArray();
//                    const formDataObj = {};
//                    formDataArray.forEach(item => {
//                        formDataObj[item.name] = item.value;
//                    });
//                    Object.assign(data, formDataObj);
//                }
//                if (requestData != null && typeof requestData === 'object') {
//                    Object.assign(data, requestData);
//                }

//                $.ajax({
//                    url: url,
//                    type: method,
//                    dataType: 'json',
//                    data: data,
//                    beforeSend: function () {
//                        if (onBefore != null && typeof onBefore === 'function') onBefore();
//                    },
//                    success: function (response) {
//                        callback(dataSrc == null ? { data: response } : { data: response[dataSrc] });
//                    },
//                    error: function (xhr, status, error) {
//                        // Hata Mesajı Gösterilmeli
//                        callback({ data: [] });
//                    },
//                    complete: function () {
//                        if (onLoaded != null && typeof onLoaded === 'function') onLoaded();
//                    }
//                });
//            },
//            processing: true,
//            serverSide: true,
//            dom: dom == null ? this.defaultDom : dom,
//            columns: columns,
//            columnDefs: columnDefs,
//            order: order,
//            ordering: ordering,
//            searching: searching,
//            stateSave: stateSave,
//            scrollCollapse: scrollCollapse,
//            scrollY: scrollY,
//            buttons: exportEnable == true ? [...customButtons, _exportButton] : [...customButtons],
//            pageLength: pageLength,
//            lengthMenu: lengthMenu == null ? this.defaultLengthMenu : lengthMenu,
//            responsive: responsive != true ? false :
//                {
//                    details: {
//                        display: $.fn.dataTable.Responsive.display.modal({
//                            header: function (row) {
//                                //var data = row.data();  //+ data['full_name'];
//                                return '<h4 class="pb-2">Detay</h4>';
//                            }
//                        }),
//                        type: 'column',
//                        renderer: function (api, rowIdx, columns) {
//                            var data = $.map(columns, function (col, i) {
//                                return (!hiddenColumnsInModal.includes(col.columnIndex) && col.title !== '') ? // col.hidden &&
//                                    `<tr data-dt-row="${col.rowIndex}" data-dt-column="${col.columnIndex}">
//                                    <td class="fw-bold">${col.title}</td>  
//                                    <td>${col.data}</td>
//                                </tr>` : '';
//                            }).join('');

//                            return data ? $('<table class="table"/><tbody />').append(data) : false;
//                        }
//                    }
//                },
//            ...extendedProps
//        });

//        return _dataTable;
//    },

//    GenerateClientSide: function ({
//        url = "",
//        method = "GET",
//        requestData = null,
//        dataSrc = null,
//        formId = null,
//        tableId = "",
//        dom = null,
//        columns = [],
//        columnDefs = [],
//        order = [],
//        ordering = true,
//        searching = true,
//        stateSave = false,
//        scrollCollapse = true,
//        scrollY = 700,
//        exportEnable = true,
//        exportColumns = null,
//        customButtons = [],
//        pageLength = 10,
//        lengthMenu = null,
//        responsive = true,
//        hiddenColumnsInModal = [],
//        extendedProps = {},
//        onBefore = null,
//        onLoaded = null
//    }) {
//        debugger;
//        if (responsive == true) {
//            var thList = $(`#${tableId} thead tr th`);
//            if (thList != null && thList.length > 0 && !$(thList[0]).hasClass("control")) {
//                var thOfResponsive = document.createElement("th");
//                thOfResponsive.className = "control";
//                $(`#${tableId} thead tr `).prepend(thOfResponsive);

//                columns.unshift(
//                    {
//                        data: '',
//                        className: 'control',
//                        orderable: false,
//                        searchable: false,
//                        responsivePriority: 2,
//                        targets: 0,
//                        render: function (data, type, full, meta) {
//                            return '';
//                        }
//                    })
//            }
//        }

//        let _exportButton = structuredClone(this.exportButton);
//        if (exportEnable == true && exportColumns != null) {
//            _exportButton.buttons.forEach(d => d.exportOptions.columns = exportColumns);
//        }

//        var _dataTable = $(`#${tableId}`).DataTable({
//            ajax: function (data, callback, settings) {
//                $.ajax({
//                    url: url,
//                    type: method,
//                    dataType: 'json',
//                    data: requestData != null ? requestData : {},
//                    beforeSend: function () {
//                        if (onBefore != null && typeof onBefore === 'function') onBefore();
//                    },
//                    success: function (response) {
//                        callback(dataSrc == null ? { data: response } : { data: response[dataSrc] });
//                    },
//                    error: function (xhr, status, error) {
//                        // Hata Mesajı Gösterilmeli
//                        callback({ data: [] });
//                    },
//                    complete: function () {
//                        if (onLoaded != null && typeof onLoaded === 'function') onLoaded();
//                    }
//                });
//            },
//            processing: true,
//            dom: dom == null ? this.defaultDom : dom,
//            columns: columns,
//            columnDefs: columnDefs,
//            order: order,
//            ordering: ordering,
//            searching: searching,
//            stateSave: stateSave,
//            scrollCollapse: scrollCollapse,
//            scrollY: scrollY,
//            buttons: exportEnable == true ? [...customButtons, _exportButton] : [...customButtons],
//            pageLength: pageLength,
//            lengthMenu: lengthMenu == null ? this.defaultLengthMenu : lengthMenu,
//            responsive: responsive != true ? false :
//                {
//                    details: {
//                        display: $.fn.dataTable.Responsive.display.modal({
//                            header: function (row) {
//                                /*var data = row.data();*/ //+ data['full_name'];
//                                return '<h4 class="pb-2">Detay</h4>';
//                            }
//                        }),
//                        type: 'column',
//                        renderer: function (api, rowIdx, columns) {
//                            var data = $.map(columns, function (col, i) {
//                                return (!hiddenColumnsInModal.includes(col.columnIndex) && col.title !== '') ? // col.hidden &&
//                                    `<tr data-dt-row="${col.rowIndex}" data-dt-column="${col.columnIndex}">
//                                    <td class="fw-bold">${col.title}</td>  
//                                    <td>${col.data}</td>
//                                </tr>` : '';
//                            }).join('');

//                            return data ? $('<table class="table"/><tbody />').append(data) : false;
//                        }
//                    }
//                },
//            ...extendedProps
//        });

//        return _dataTable;
//    },



//    defaultDom: '<"card-header"<"head-label text-center"><"dt-action-buttons text-end"B>><"d-flex justify-content-between align-items-center row"<"col-sm-12 col-md-6"l><"col-sm-12 col-md-6"f>>t<"d-flex justify-content-between row"<"col-sm-12 col-md-6"i><"col-sm-12 col-md-6"p>>',
//    defaultLengthMenu: [
//        [10, 25, 50, 100, - 1],
//        [10, 25, 50, 100, 'Tümü']
//    ],
//    exportButton: {
//        extend: 'collection',
//        className: 'btn btn-label-secondary dropdown-toggle mx-2',
//        text: '<i class="icon-base bx bx-export me-1"></i> <span class="d-none d-lg-inline-block">Dışa Aktar</span>',
//        buttons: [
//            {
//                extend: 'print',
//                text: '<i class="icon-base bx bx-printer me-1" ></i>Yazdır',
//                className: 'dropdown-item',
//                exportOptions: {} //columns: [3, 4, 5, 6, 7]
//            },
//            {
//                extend: 'excel',
//                text: '<i class="icon-base bx bx-file me-1" ></i>Excel',
//                className: 'dropdown-item',
//                exportOptions: {}
//            },
//            {
//                extend: 'pdf',
//                text: '<i class="icon-base bx bxs-file-pdf me-1"></i>Pdf',
//                className: 'dropdown-item',
//                exportOptions: {}
//            },
//            {
//                extend: 'copy',
//                text: '<i class="icon-base bx bx-copy me-1" ></i>Kopyala',
//                className: 'dropdown-item',
//                exportOptions: {}
//            }
//        ]
//    }
//}