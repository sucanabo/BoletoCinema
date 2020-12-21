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
var ful = document.querySelector('#mful');
ful.addEventListener('change', function () {
    readURL(this, '#imgsPreview')
});
function readURL(input, preview) {
    $(preview).empty();
    if (input.files) {
        var filesSize = input.files.length;
        for (var i = 0; i < filesSize; i++) {
            var reader = new FileReader();
            reader.onload = function (e) {
                var img = document.createElement('img');
                img.setAttribute('src', e.target.result);
                var imgItem = document.createElement('div');
                imgItem.classList.add('img-item');
                imgItem.append(img);
                var container = document.querySelector(preview);
                container.append(imgItem);
            }
            reader.readAsDataURL(input.files[i]);
        }
    }
}