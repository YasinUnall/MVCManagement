$(document).ready(function () {
    $.ajax({
        url: '/Management/BuildEmployeeTable',
        success: function (result) {
            $('#tableDiv').html(result);
        }
    });
});

$(document).ready(function () {
    $('#EmployeeButton').click(function () {
        $.ajax({
            url: '/Management/BuildEmployeeTable',
            success: function (result) {
                $('#tableDiv').html(result);
            }
        });
    });
});