
//inital value
let seats = [];
var colPerRow = 14;
var row = parseInt(seats.length / colPerRow);
var ticketPrice = 50;
var totalPrice;
var seatSelected = new Set();
var dataSeatPos = new Set();
var seat_container_single = document.querySelector(".seat-area2");
var seat_container_couple = document.querySelector(".seat-area2.couple");
//call API
const uri = `https://localhost:44350/api/seats`;
fetch(uri)
    .then(response => response.json())
    .then(data => _getData(data))
    .catch(error => console.error('Unable to get items.', error));
function _getData(data) {
    seats = data;
    seatStatus = [];
    
    console.log(data);
    row = parseInt(data.length / colPerRow);
    renderSeat(row);
    checkStatus();
    var btn = document.querySelector("#proceed-btn");
    btn.addEventListener("click", () => {
        addSession();
    });
}

function checkStatus() {
    seats.forEach(item => {
        seatStatus.unshift(item["status"]);
    });
    var allSeat = document.querySelectorAll(".seat-area2 li.single-seat");
    for (let i = 0; i < allSeat.length; i++) {
        if (seatStatus[i] == 1) {
            allSeat[i].classList.remove("seat-free");
            if (allSeat[i].classList.contains("seat-free-two"))
                allSeat[i].querySelector('img').src = "../User/assets/images/movie/seat02.png";
            else allSeat[i].querySelector('img').src = "../User/assets/images/movie/seat01.png";
        }
    }
}
//proceed btn
function addSession() {
    var seatObj = {
        seatPos: [],
        seatSelected: [],
        totalPrice:0
    };
    seatSelected.forEach(item => { seatObj["seatSelected"].push(item) });
    dataSeatPos.forEach(item => { seatObj["seatPos"].push(item) });
    seatObj.totalPrice = totalPrice;
    sessionStorage.setItem("seatPlan", JSON.stringify(seatObj));
    //var selectedObj = seatSelected;
    //var total = totalPrice;
    //sessionStorage.setItem("seatPos", JSON.stringify(posObj));
    //sessionStorage.setItem("seatSelected", JSON.stringify(selectedObj));
    //sessionStorage.setItem("totalPrice", total);
}

//render
function renderSeat(row) {

    function createFontSeat(number, area) {
        let seat_group = document.createElement("ul");
        for (let j = 0; j < number; j++) {

            let seat_img = document.createElement("img");
            let seat_type = document.createElement("li");
            seat_img.src = "../User/assets/images/movie/seat01-free.png";
            seat_type.className = "single-seat seat-free";
            seat_img.alt = "seat";
            seat_type.appendChild(seat_img);
            seat_group.appendChild(seat_type);
        }
        let front_seat = document.createElement("li");
        front_seat.className = "front-seat";
        front_seat.appendChild(seat_group);
        area.appendChild(front_seat);
    }
    function createTag(seatline, tag) {
        let seat_tag = document.createElement("span");
        seat_tag.innerText = tag;
        seatline.appendChild(seat_tag);
    }
    function createSeatLine(element, tag) {
        let seat_line = document.createElement("li");
        seat_line.className = "seat-line";

        let seat_area = document.createElement("ul");
        seat_area.className = "seat--area";
        createFontSeat(4, seat_area);
        createFontSeat(6, seat_area);
        createFontSeat(4, seat_area);
        createTag(seat_line, tag);
        seat_line.appendChild(seat_area);
        createTag(seat_line, tag);
        element.appendChild(seat_line);
    }

    for (let r = row; r > 0; r--) {
        let seat_tag = String.fromCharCode(65 + r - 1);
        createSeatLine(seat_container_single, seat_tag);

    }
    let allSingleSeat = document.querySelectorAll(".seat-area2 li.single-seat");//sua
    let showTicket = document.querySelector(".book-item:nth-child(1) h3");
    let showTotalPrice = document.querySelector(".book-item:nth-child(2) h3")
    var seatPos = function () {
        allSingleSeat.className = "single-seat seat-free";
        let j = row;
        let k = 0;
        for (let i = 0; i < allSingleSeat.length; i++) {
            let seatPos = document.createElement("span");
            seatPos.className = "sit-num";
            let posTag = String.fromCharCode(65 + j - 1);
            seatPos.innerText = posTag + (k + 1);
            allSingleSeat[i].appendChild(seatPos);
            k++;
            if (k == colPerRow) {
                j--;
                k = 0;
            }
            allSingleSeat[i].setAttribute("data-seat-pos", i);
        }
    }();
    function showSeatSelected() {
        let textString = "";
        seatSelected.forEach(item => {
            textString += item + ", ";
        });
        showTicket.innerText = textString;
    }
    function showPrice() {
        let ticketNumber = dataSeatPos.size;
        let coupleSeat = allSingleSeat.length - colPerRow / 2;
        let couplePos = 0;
        dataSeatPos.forEach(item => {
            if (item >= coupleSeat)
                couplePos++;
        });
        totalPrice = (couplePos * 2 + (ticketNumber - couplePos)) * ticketPrice;
        showTotalPrice.innerText = "$" + totalPrice;
    }
    allSingleSeat.forEach(item => {
        item.addEventListener("click", () => {
            let img = item.querySelector('img');
            let itemText = item.querySelector("span").innerText;
            img.classList.toggle("booked");
            if (img.classList.contains("booked")) {
                seatSelected.add(itemText);
                dataSeatPos.add(item.getAttribute("data-seat-pos"));
                if (item.classList.contains("seat-free-two")) {
                    img.src = "../User/assets/images/movie/seat02-booked.png";
                }
                else {
                    img.src = "../User/assets/images/movie/seat01-booked.png";
                }
            }
            else if (!img.classList.contains("booked")) {
                seatSelected.delete(itemText);
                dataSeatPos.delete(item.getAttribute("data-seat-pos"));
                if (item.classList.contains("seat-free-two")) {
                    img.src = "../User/assets/images/movie/seat02-free.png";
                }
                else {
                    img.src = "../User/assets/images/movie/seat01-free.png";
                }
            }
            showSeatSelected();
            showPrice();
            console.log(dataSeatPos);
        });
    });
}