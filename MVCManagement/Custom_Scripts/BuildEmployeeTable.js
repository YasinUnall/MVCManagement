$(document).ready(function () {
    $.ajax({
        url: '/Management/BuildEmployeeTable',
        success: function (result) {
            $('#tableDiv').html(result);
        }
    });
});