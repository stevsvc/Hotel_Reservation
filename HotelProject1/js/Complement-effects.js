
//parsing URL to get dates
var getUrlParameter = function getUrlParameter(sParam) {
    var sPageURL = decodeURIComponent(window.location.search.substring(1)),
        sURLVariables = sPageURL.split('&'),
        sParameterName,
        i;

    for (i = 0; i < sURLVariables.length; i++) {
        sParameterName = sURLVariables[i].split('=');

        if (sParameterName[0] === sParam) {
            return sParameterName[1] === undefined ? true : sParameterName[1];
        }
    }
};
var room_Type = getUrlParameter('Room_Type');
var check_In_Date = getUrlParameter('Check_In');
var check_Out_Date = getUrlParameter('Check_Out');


document.getElementById('room_Type').innerHTML = room_Type;
document.getElementById('check_In_Date').innerHTML = check_In_Date;
document.getElementById('check_Out_Date').innerHTML = check_Out_Date;

//checking error data
document.getElementById('contact-submit').onclick = function () {
    var room_Type = getUrlParameter('Room_Type');
    var check_In_Date = getUrlParameter('Check_In');
    var check_Out_Date = getUrlParameter('Check_Out');
    var confirm_Room = document.getElementById('confirm_Room_Type').value;
    var confirm_Check_In = document.getElementById('date-Start').value;
    var confirm_Check_Out = document.getElementById('date-End').value;

    if (room_Type != confirm_Room) {
        //send a warning, room types don't match
        $("#contact").submit(function (e) {
            alert("Los tipos de habitaciones no concuerdan");
            e.preventDefault(e);
            location.reload();
        })
    }
    if (check_In_Date != confirm_Check_In) {
        //send a warning check in dates don't match
        $("#contact").submit(function (e) {
            alert("Las fechas no concuerdan");
            e.preventDefault(e);
            location.reload();
        })
    }
    if (check_Out_Date != confirm_Check_Out) {
        //send a warning check out dates don't match
        $("#contact").submit(function (e) {
            alert("Las fechas no concuerdan");
            e.preventDefault(e);
            location.reload();
        })
    }
}

//redirect to change dates 
document.getElementById('changeDates').onclick = function () {
    location.href = "index.html";
}