$(document).ready(function () {

//set onChange eventHandler for CpspDropdownList
    $("#cpspDdl").change(GetTelephonesForCpsp);
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
    if (result !== "")
        $("#telephonesDiv").show();
    else
        $("#telephonesDiv").hide();
    $("#telephonepv").html("");
    $("#telephonepv").html(result);
}

function ShowEmailsGrid(result) {
    if (result !== "")
        $("#emailsDiv").show();
    else
        $("#emailsDiv").hide();
    $("#emailpv").html("");
    $("#emailpv").html(result);
}

//function display(e) { }