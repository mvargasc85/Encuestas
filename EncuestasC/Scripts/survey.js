$(document).ready(function () {

//set onChange eventHandler for CpspDropdownList
    //    $("#cpspDdl").change(GetTelephonesForCpsp);
    $("#cpspDdl").change(GetSurveyInfo);

    GetCPSPInfo();
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
                        Telefono1: { type: "number" }
                    }
                }
            },
            pageSize: 10
        },
        height: 50,
        scrollable: true,
        sortable: true,
        filterable: true,
        columns: [
            { field: "Id", title: "Id", width: "50px" },
            { field: "Telefono1", title: "Telefono",width: "50px" }]
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
            pageSize: 10
        },
        height: 50,
        scrollable: true,
        sortable: true,
        filterable: true,
        columns: [
            { field: "Id", title: "Id", width: "50px" },
            { field: "Correo", title: "Email", width: "50px" },
            { field: "Nombre", title: "Nombre", width: "50px"}]
    });
}



function CreateDropDownlist(divId,items,text,value) {

    $("#" + divId).kendoDropDownList({
        dataTextField: text,
        dataValueField: value,
        dataSource: items,
        index: 0,
        change: GetSurveyInfo
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
            CreateDropDownlist("cpspDdlDiv", result, "Nombre", "Id");
        },
        error: function(e) { display(e); }
    });

}
