    let getDataTable = function (apiCall, columns) {
    
    function init() {
        const $tbl = $('#item-tbl').DataTable({
            language: {
                url: '//cdn.datatables.net/plug-ins/1.13.7/i18n/ru.json'},
            searching: true,
            "bLengthChange": false,
            searchDelay: 300,
            stateSave: true,
            processing: true,
            serverSide: true,
            ordering: true,
            order: [[ 1, "desc" ]],
            rowId: 'id',
            ajax: function(data, callback) {
                dtAjaxHandler('/AgeGroup/List', data, callback)

            },
            columnDefs: [
                { targets: 1, title: "Название", data: "name" },
                { targets: 2, title: "Минимальный возраст", data: "minAge" },
                { targets: 3, title: "Максимальный возраст", data: "maxAge" },
                
            ]
        });
        
        
    }

    return {
        init
    }
}