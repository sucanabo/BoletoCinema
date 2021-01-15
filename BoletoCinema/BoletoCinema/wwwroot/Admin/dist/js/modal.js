async function deleteReview(id) {

    let url = `https://localhost:44350/user/api/reviewsapi/deletereview/${id}`;
    const respone = await fetch(url, { method: "DELETE" });
    const responeJson = await respone.json();

    if (responeJson.result == "success") {
        console.log("ok");
        $('#deleteSuccess').modal('show');

        setTimeout(function () {
            location.reload();
        }, 2000);
    } else {

    }
}