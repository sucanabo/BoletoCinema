﻿
var seatPlan = JSON.parse(sessionStorage.getItem("seatPlan"));
var tmpPrice = document.querySelectorAll('.ticket-tmpPrice');
var sch_id = parseInt(sessionStorage.getItem('sch-id'));
//var uri_schedule = `../../api/ `;
//const showTime = fetch () {

//}
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

//-----------
//proceed
const getElement = document.querySelector.bind(document);
const ticket_uri = `../../api/TicketsAPI`;
const order_uri = `../../api/OrdersAPI`;
const seat_status_uri = `../../api/Seat_Status/PostSeat_Status`;
const user_uri = `../../api/UsersAPI`;


const saveOrder = async () => {
    

    if (!document.getElementById('user-displayname')) {
        alert("Vui lòng đăng nhập !!!");
        window.location.href = "../../Auth/Login";
    }
    else {
        //get id user
        let getUser = await fetch(user_uri);
        let user = await getUser.json();
        console.log(user);

        let getDisplayname = document.getElementById('user-displayname').innerText;
        console.log(getDisplayname);

        let getIdUser;
        for (var i = 0; i < user.length; i++) {
            if (user[i].displayname == getDisplayname)
                getIdUser = user[i].id;
        }
        console.log(getIdUser);

        //saveOrder
        let item_order = {
            "id": 0,
            "user_id": getIdUser,
            "total_price": vatPrice + seatPlan["totalPrice"],
            "status": 1,
            "create_date": new Date().toISOString()
        };
        console.log('item ne: ', item_order);
        let order = await fetch(order_uri, {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(item_order)
        });

        let data_order = await order.json();
        let order_id = await data_order.id;

        console.log(order_id);

        //get last id ticket
        let maxTicketId = await fetch(ticket_uri, {
        })
        let get_ticket = await maxTicketId.json();
        console.log(get_ticket);

        let get_last_ticket = get_ticket.pop();
        console.log(get_last_ticket);

        let get_last_ticketid = get_last_ticket.id;
        console.log(get_last_ticketid);

        var countSeatId = seatPlan['seatId'].length;
        console.log(countSeatId);



        //saveTicket
        for (var i = get_last_ticket.id + 1; i <= get_last_ticket.id + countSeatId; i++) {
            var ticket = await fetch(ticket_uri, {
                method: 'POST',
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(
                    {
                        "id": 0,
                        "order_id": order_id,
                        "schedule_id": sch_id,
                        "price": 50
                    })
            });

        }

        let data_ticket = await ticket.json();
        let ticket_id = await data_ticket.id;
        console.log(data_ticket);

        //saveSeatStatus
        seatPlan['seatId'].forEach(async function (item) {
            fetch(seat_status_uri, {
                method: 'POST',
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(
                    {
                        "id": 0,
                        "seat_id": item,
                        "ticket_id": ticket_id,
                        "status": 1

                    })
            });
        });

        var ok_btn = document.querySelector("#ok_btn");
        ok_btn.addEventListener("click", () => {
            window.location.href = "../../Home";
        });
        
    }
    
}
       
    
