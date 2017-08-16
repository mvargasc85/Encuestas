$(document).ready(function () {


    GetCPSPInfo();
    createDropDownsForLocation();


});


//get a list of telephones for the selected cpsp
function GetTelephonesForCpsp() {
    var cpspId = $("#cpspDdl").val();
    if (cpspId !== "") {
        $.ajax({
            type: "post",
            url: "/Survey/GetTelephones",
            dataType: "html",
            data: "cpspId=" + cpspId,
            contentType: "application/x-www-form-urlencoded;charset=utf-8",
            //  async: true,
            success: function (result) { ShowTelephonesGrid(result); },
            error: function (e) { display(e); }
        });
        $.ajax({
            type: "post",
            url: "/Survey/GetEmails",
            dataType: "html",
            data: "cpspId=" + cpspId,
            contentType: "application/x-www-form-urlencoded;charset=utf-8",
            //  async: true,
            success: function (result) { ShowEmailsGrid(result); },
            error: function (e) { display(e); }
        });
    }
}


function ShowTelephonesGrid(result) {

    if (result !== "") {
        createTelephoneGrid("telephonepv", result.Telefonos);
        $("#telephonesDiv").show();
    } else
        $("#telephonesDiv").hide();

}


function ShowEmailsGrid(result) {
    if (result !== "") {

        createEmailGrid("emailpv", result.Emails);
//        $("#telephonepv").style()
        $("#emailsDiv").show();
    } else
        $("#emailsDiv").hide();

}



function GetSurveyInfo() {
    var cpspId = $("#cpspDdlDiv").val();

    $.ajax({
        type: "Get",
        url: "/Survey/GetCpspInfo?cpspId=" + cpspId,
        contentType: "application/json; charset=utf-8",
        dataType: "json", 
        success: function(result) {
            ShowTelephonesGrid(result);
            ShowEmailsGrid(result);
        },
        error: function (e) { display(e); }
    });

}

function display(e) {

    alert(e);
}


function createTelephoneGrid(divId, items) {
    $("#"+divId).kendoGrid({
        dataSource: {
            data: items,
            schema: {
                model: {
                    fields: {
                        Id: { type: "number" },
                        Telefono: { type: "string" }
                    }
                }
            },
            pageSize: 5
        },
//        height: 100,
        scrollable: false,
        sortable: true,
        filterable: true,
        columns: [
            { field: "Id", title: "Id", width: "50px" },
            { field: "Telefono", title: "Telefono",width: "50px" }]
    });
}

function createEmailGrid(divId, items) {
    $("#" + divId).kendoGrid({
        dataSource: {
            data: items,
            schema: {
                model: {
                    fields: {
                        Id: { type: "number" },
                        Correo: { type: "string" },
                        Nombre: { type: "string" }

                    }
                }
            },
            pageSize: 5
        },
//        height: 100,
        scrollable: false,
        sortable: true,
        filterable: true,
        columns: [
            { field: "Id", title: "Id", width: "50px" },
            { field: "Correo", title: "Email", width: "50px" },
            { field: "Nombre", title: "Nombre", width: "50px"}]
    });
}



function CreateDropDownlist(divId,items,text,value,onchanceEventHandler,selectPlaceHolder) {

    $("#" + divId).kendoDropDownList({
        optionLabel: selectPlaceHolder,
        dataTextField: text,
        dataValueField: value,
        dataSource: items,
        index: 0,
        change: onchanceEventHandler
    });
}


// obtener datos para llenar el combo de los cpsps
function GetCPSPInfo() {
    $.ajax({
        type: "Get",
        url: "/Survey/GetAllCpsp",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function(result) {
            CreateDropDownlist("cpspDdlDiv", result, "Nombre", "Id", GetSurveyInfo,"Seleccione ...");
        },
        error: function(e) { display(e); }
    });

}



function createDropDownsForLocation() {

    $.ajax({
        type: "Get",
        url: "/GeographicInfo/GetAllProvicesData",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (result) {
            CreateDropDownlist("provinciaDdl", result, "Nombre", "Id", filterCantones,"Seleccionar Provincia");
        },
        error: function (e) { display(e); }
    });

    $.ajax({
        type: "Get",
        url: "/GeographicInfo/GetAllCantonesData",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (result) {
            CreateDropDownlist("cantonDdl", result, "Nombre", "Id",null,"Seleccionar Cantón");
        },
        error: function (e) { display(e); }
    });

}


function filterCantones(e) {
    var dataItem = e.sender.dataItem(e.sender.selectedIndex);
    var provinceId = dataItem.Id;
    var ddl = $("#cantonDdl").data("kendoDropDownList");
    ddl.dataSource.filter({
        field: 'ParentId',
        operator: 'eq',
        value: provinceId
    });

//    $("#cantonDdl").removeAttr("disabled");
//    $("#cantonDdl").prop('disabled', false);
}
