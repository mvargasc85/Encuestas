$(document).ready(function () {

//set onChange eventHandler for CpspDropdownList
    $("#cantonDdl").change(GetProvinciasForCanton);
});


//get a list of telephones for the selected cpsp
function GetProvinciasForCanton() {
    var cantonId = $("#cantonDdl").val();
    if (cantonId !== "") {
        $.ajax({
            type: "post",
            url: "/Provincia/GetAllProvincia",
            dataType: "html",
            data: "cantonId=" + cantonId,
            contentType: "application/x-www-form-urlencoded;charset=utf-8",
            //  async: true,
            success: function (result) { ShowProvinciasGrid(result); },
            error: function (e) { display(e); }
        });
      
    }
}

function ShowProvinciasGrid(result) {
    if (result !== "")
        $("#provinciasDiv").show();
    else
        $("#provinciasDiv").hide();
    $("#provinciapv").html("");
    $("#provinciapv").html(result);
}
