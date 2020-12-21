var openBtn = document.querySelectorAll(".modal-btn");
openBtn.forEach(item => {
    item.addEventListener("click", function () {
        var target = item.getAttribute("data-bs-target");
        filterHandle(target);
    });
});
function filterHandle(target) {
    var modal = document.querySelector(target);
    var inputSearch = modal.querySelector(".search-box > input");
    inputSearch.addEventListener('keyup', function () {
        var filter = inputSearch.value.toUpperCase();
        var allSpan = modal.querySelectorAll(".cate-container span");
        allSpan.forEach(item => {
            var itemText = item.innerText;
            if (itemText.toUpperCase().indexOf(filter) > -1) {
                item.style.display = "";
            }
            else item.style.display = "none";
        });
    })
}
    
