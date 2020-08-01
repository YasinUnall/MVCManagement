$(document).ready(function () {
    $('#ProductButton').click(function () {
        $.ajax({
            url: '/Management/BuildProductTable',
            success: function (result) {
                $('#tableDiv').html(result);
            }
        });
    });
});