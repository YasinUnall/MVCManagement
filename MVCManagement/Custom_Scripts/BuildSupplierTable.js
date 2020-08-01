$(document).ready(function () {
    $('#SupplierButton').click(function () {
        $.ajax({
            url: '/Management/BuildSupplierTable',
            success: function (result) {
                $('#tableDiv').html(result);
            }
        });
    });
});