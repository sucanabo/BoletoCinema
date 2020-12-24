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
        var allSpan = modal.querySelectorAll(".modal-container span");
        allSpan.forEach(item => {
            var itemText = item.innerText;
            if (itemText.toUpperCase().indexOf(filter) > -1) {
                item.style.display = "";
            }
            else item.style.display = "none";
        });
    })
}

var listCast = new Set();
var listCate = new Set();
var modalContent = document.querySelectorAll(".modal-content");
modalContent.forEach(item =>{
    let saveBtn = item.querySelector(".save-btn");
    let list = new Set();
    let input = item.querySelectorAll("input[type='checkbox']");
    input.forEach(item2 => {
        item2.addEventListener("click", () => {
            if (item2.checked) {
                console.log("checked");
                list.add(item2.value);
            }
            else list.delete(item2.value);
        });
    });
    saveBtn.addEventListener('click', () => {
        if (saveBtn.id == "save-cate") {
            listCate = list; console.log(listCate);
            let inputCon = document.querySelector(".movie-cate");
            listCate.forEach(item => {
                let input = document.createElement("input")
            });
        }
        else { listCast = list; console.log(listCast);}
    });
});
