const getElement = document.querySelector.bind(document);
let uri = "../../api/ContactFormsAPI";


const sendFeedback = async () => {
    let contentFeedback = getElement('#feedback').value;
    let message = {
        "id": 0,
        "user_id": 3,
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

    window.location.href = "../../Home";
}

