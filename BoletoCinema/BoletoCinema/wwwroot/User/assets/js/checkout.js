var seatPlan = JSON.parse(sessionStorage.getItem("seatPlan"));
var tmpPrice = document.querySelectorAll('.ticket-tmpPrice');
tmpPrice.forEach(item => {
    item.innerText = "$" + seatPlan["totalPrice"];
});
var showSeat = function () {
    let str = "";
    seatPlan['seatSelected'].forEach(item => {
        str += item + ", ";
    });
    document.querySelector('#ticket-seat').innerText = str;
}();
var VAT = document.querySelector('#ticket-VAT');
let vatPrice = seatPlan['totalPrice'] * 0.1;
VAT.innerText = "$" + vatPrice;
var amount = document.querySelector('#ticket-totalPrice');
amount.innerText = `$` + (vatPrice + seatPlan["totalPrice"]);
