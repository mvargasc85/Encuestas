$(document).ready(function () {


    GetCPSPInfo();
    createDropDownsForLocation();

//    $("input[name=statusRdbtn]:radio").change(showCallInformation);
    showCallInformation();
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
    if (cpspId === "")
        $("#cpspInfoTbl").hide();
    else {
        $.ajax({
            type: "Get",
            url: "/Survey/GetCpspInfo?cpspId=" + cpspId,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function(result) {
                if (result) $("#cpspInfoTbl").show();
                else $("#cpspInfoTbl").hide();
                setLocationInfo(result.Location);
                ShowTelephonesGrid(result);
                ShowEmailsGrid(result);
                setCallInfo(result);
            },
            error: function(e) { display(e); }
        });
    }
}

function display(e) {alert(e);}


function setLocationInfo(data) {

    $("#provinciaIdLbl").text(data.Provincia.Nombre);
    $("#cantonIdLbl").text(data.Canton.Nombre);
    $("#distritoIdLbl").text(data.Distrito.Nombre);
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
            CreateDropDownlist("cantonDdl", result, "Nombre", "Id", filterDistrites, "Seleccionar Cantón");
        },
        error: function (e) { display(e); }
    });

       $.ajax({
        type: "Get",
        url: "/GeographicInfo/GetAllDistritesData",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (result) {
            CreateDropDownlist("distritoDdl", result, "Nombre", "Id",null,"Seleccionar distrito");
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
};



    function filterDistrites(e) {
    var dataItem = e.sender.dataItem(e.sender.selectedIndex);
    var cantonId = dataItem.Id;
    var ddl = $("#distritoDdl").data("kendoDropDownList");
    ddl.dataSource.filter({
        field: 'ParentId',
        operator: 'eq',
        value: cantonId
     })};

//    $("#cantonDdl").removeAttr("disabled");
//    $("#cantonDdl").prop('disabled', false);


function setCallInfo(data) {
//    CreateDropDownlist("serviceStatusDdl", data.EstadosServicio, "Estado", "Id",null,"Seleccionar ...");
    CreateDropDownlist("codPresDdl", data.CodPresupuestarios, "Codigo", "Id",null,"Seleccionar ...");

    for (var i = 0; i < data.EstadosServicio.length; i++) {
        var radioBtn = $('<label class="k-radio-label" for="status_'+data.EstadosServicio[i].Id+'"><input type="radio" name="statusRdbtn" id="status_'+data.EstadosServicio[i].Id+'" class="k-radio"/>'+data.EstadosServicio[i].Estado+'</label><br/>');
        radioBtn.appendTo('#serviceStatusDdl');
    }

 


 
}

function showCallInformation() {
    $("input:radio[name='answercallRdbtn']").change(function() {
        var contesta = $("#contesta")[0].checked;
       if (contesta) {
           $("#callInformationfs").show();
       }else
           $("#callInformationfs").hide();
    });

    $("#bottonsDiv").show();
};
