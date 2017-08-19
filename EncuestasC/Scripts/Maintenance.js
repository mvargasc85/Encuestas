
$(document).ready(function () {
    //    getCodPresData(); safis

    $("#saveCpspBtn").on("click", SaveCpsp) // aca se le asigna el handler al evento click del boton guardar
    $("#cancelCpspBtn").on("click", cancelCpsp);
});


function createCodPresGrid(divId, items) {
    $("#" + divId).kendoGrid({
        dataSource: {
            data: items,
            schema: {
                model: {
                    fields: {
                        Id: { type: "number" ,editable: false},
                        Codigo: { type: "number" }
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
            { field: "Codigo", title: "Codigo", width: "50px" },
            { command: ["edit", "destroy"], title: "&nbsp;", width: "250px"}],
        editable: "inline"
    });
}




function getCodPresData() {
    $.ajax({
        type: "Get",
        url: "/Maintenance/GetCodPresList",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (result) {
            createCodPresGrid("codPresGridDiv", result);
        },
        error: function (e) { display(e); }
    });
}


function display(e) {

    alert(e);
}



function getLocationModel() {

       var locationDataModel = 
    {
        Id: null,
        Nombre: $("#cpspName").val(),
        ProvinciaId: dropDownListObject("provinciaDdl").value(),
        CantonId: dropDownListObject("cantonDdl").value() ,
        DistritoId: dropDownListObject("distritoDdl").value() 

    };

    return locationDataModel;
}//perqueñas cosass


function SaveCpsp() {
    var cpspData = getLocationModel();
    $.ajax({
        type: "Post",
        url: "/maintenance/CreateCPSP",
        data: cpspData,
        success: function (result) {
            var url = "/maintenance/GetAllCPSP"; 
            window.location.href = url;
        },
        error: function (e) { display(e); }
    });
}


function cancelCpsp() {
    var url = "/maintenance/GetAllCPSP";
    window.location.href = url;
}