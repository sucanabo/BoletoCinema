function readURL(input, idImg) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $(idImg).attr('src', e.target.result);
        }
        reader.readAsDataURL(input.files[0]);
    }
}
$("#ful").change(function () {
    readURL(this, '#imgPre');
});