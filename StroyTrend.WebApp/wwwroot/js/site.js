// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
function dtAjaxHandler(url, data, callback) {
    $.ajax({
        url: url,
        type: 'POST',
        contentType: "application/json",
        dataType: "json",
        data: JSON.stringify(dtAjaxQueryToObj(data)),
        success: function (res) {
            callback({
                recordsTotal: res.metadata.totalItemCount,
                recordsFiltered: res.metadata.totalItemCount,
                data: res.data,
                draw: data.draw
            });
        }
    })
}