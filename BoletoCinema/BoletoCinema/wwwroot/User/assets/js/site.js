




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

document.querySelector('#btnPostDiscusstion').addEventListener('click', async (e) => {

    let movieId = parseInt(document.querySelector('#movieId').getAttribute('value'));
    let content = document.querySelector('#discusstion').value;

    let commentSection = document.querySelector('.review-section');

    let outterDiv = document.createElement('div');
    let authorDiv = document.createElement('div');
    let authorThumbDiv = document.createElement('div');
    let authorInfoDiv = document.createElement('div');

    let contentDiv = document.createElement('div');

    let authorLink = document.createElement('a');
    let authorImg = document.createElement('img');
    let authorName = document.createElement('h6');
    let authorNameLink = document.createElement('a');
    let authorPostDate = document.createElement('span');
    let dateIcon = document.createElement('i');

    let reportDiv = document.createElement('div');
    let discusstionContentDiv = document.createElement('div');
    let discusstionContent = document.createElement('p');
    let reportIcon = document.createElement('i');
    let reportLink = document.createElement('a');

    reportDiv.classList = "review-meta";
    reportIcon.classList = "fa fa-flag red-icon";
    discusstionContentDiv.classList = "movie-review-content";
    dateIcon.classList = "far fa-clock";
    authorName.classList = "subtitle";
    authorInfoDiv.classList = "movie-review-info";
    outterDiv.classList = "movie-review-item";
    authorDiv.classList = "author";
    authorThumbDiv.classList = "thumb";

    contentDiv.classList = "movie-review-content";

    reportLink.href = "#0";
    authorNameLink.href = "#";
    reportLink.innerHTML = ` Report Abuse `;
    authorImg.src = "https://localhost:44350/User/assets/images/cast/cast02.jpg";


    const url = `https://localhost:44350/user/api/reviewsapi/postreview`;
    const respone = await fetch(url, {
        method: 'POST',
        body: JSON.stringify({
            "user_id": 1,
            "movie_id": movieId,
            "content": content,
            "heart_rate": 0,
            "create_date": "2020-12-22"
        }),

        headers: {
            "Content-type": "application/json; charset=UTF-8"
        }
    });
    const responeJson = await respone.json();   

    if (responeJson.result == 'fail') {
        alert('Post review fail!');
        return;
    }

    discusstionContent.innerHTML = responeJson.content;
    authorNameLink.innerHTML = responeJson.user_name;
    authorPostDate.innerHTML = responeJson.date;

    reportLink.appendChild(reportIcon);
    reportDiv.appendChild(reportLink);
    discusstionContentDiv.appendChild(discusstionContent);
    discusstionContentDiv.appendChild(reportDiv);
    authorPostDate.appendChild(dateIcon);
    authorName.appendChild(authorNameLink);
    authorInfoDiv.appendChild(authorName);

    authorInfoDiv.appendChild(authorPostDate);

    authorLink.appendChild(authorImg);
    authorThumbDiv.appendChild(authorLink);

    authorDiv.appendChild(authorThumbDiv);
    authorDiv.appendChild(authorInfoDiv);

    outterDiv.appendChild(authorDiv);
    outterDiv.appendChild(discusstionContentDiv);

    commentSection.appendChild(outterDiv);

    alert("Your comment have been posted!");
});

