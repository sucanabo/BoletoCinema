const getElement = document.querySelector.bind(document);
let uri = "../../api/ContactFormsAPI";
const user_uri = `../../api/UsersAPI`;

const sendFeedback = async () => {
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

        let contentFeedback = getElement('#feedback').value;
        let message = {
            "id": 0,
            "user_id": getIdUser,
            "content": contentFeedback,
            "status": 1,
            "create_date": new Date().toISOString()
        }
        console.log(message);

        let feedback = await fetch(uri, {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(message)
        });

        let data_feedback = await feedback.json();
        console.log(data_feedback);

        var ok_contact_btn = document.querySelector("#contact_btn");
        ok_contact_btn.addEventListener("click", () => {
            window.location.href = "../../Home";
        });
    }
}

