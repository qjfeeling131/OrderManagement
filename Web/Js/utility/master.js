/// <reference path="jquery.min.js" />

function createDialog(url, parameters) {
    $.get(url, parameters, function (data) {
        for (i = 0; i < $(data).length; i++) {
            var item = $(data)[i];
            if ($(item).hasClass("modal")) {
                modal = $(item);
                $(modal).appendTo('#dialog_content');
                $(modal).modal({
                    keyboard: true,
                    show: true,
                    backdrop: 'static'
                })
            }
        }
    }, "html");
}


function alertInfo(title,msg) {
    var model = { 'Title':  title , 'Message': msg };
    createDialog('../base/exception', model);
}

//exception wrapper
function getAsynData(path, data, func) {
    $.post(path, data, function (json) {
        if (json.Code == 0)
            eval('(' + json.Data + ')');
        else
            func(json);
    }, "json");
}

