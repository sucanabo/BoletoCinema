$(document).ready(function () {
    console.log('okok');
    $('.my-modal').show()
    setTimeout(() => {
        $('.my-modal').hide()
    }, 5000);
    $('.my-modal .modal-close').click(function () {
        console.log(this.parentElement.style.display = "none");
    });
});