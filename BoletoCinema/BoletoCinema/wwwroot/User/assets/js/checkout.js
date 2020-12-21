var seatPlan = JSON.parse(sessionStorage.getItem("seatPlan"));
var tmpPrice = seatPlan["totalPrice"];
document.querySelector('#ticket-tmpPrice').innerText