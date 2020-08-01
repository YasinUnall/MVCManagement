$(document).ready(function () {
    $('#CategoryButton').click(function () {
        $.ajax({
            url: '/Management/BuildCategoryTable',
            success: function (result) {
                $('#tableDiv').html(result);
            }
        });
    });
});