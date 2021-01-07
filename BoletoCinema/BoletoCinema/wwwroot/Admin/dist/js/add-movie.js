const getElement = document.querySelector.bind(document);
var submit_btn = getElement('#submit-btn');
const movie_uri = `../../api/movies`;
const cate_uri = `../../api/movie_category`;
const cast_uri = `../../api/movie_actor`;
const img_uri = `../../api/images`;

function cutString(str) {
    return str = str.slice(str.indexOf('=') + 1, str.length);
}

const createMovie = async () => {
    let item = {
        "id": 0,
        "name": getElement('#name').value,
        "summery": getElement('#sum').value,
        "poster": getElement('#poster').value,
        "trailer_path": cutString(getElement('#trailer').value),
        "status": getElement('#status').value,
        "duration": getElement('#duration').value,
        "published_date": getElement('#date').value
    };
    console.log('item',item);
    let movie = await fetch(movie_uri, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(item)
    });
    let data = await movie.json();
    console.log('data',data);
    let movie_id = await data.id;
    console.log('movie id',movie_id);
    listCate.forEach(item => {
        fetch(cate_uri, {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                "id": 0,
                "category_id": item,
                "movie_id": movie_id    
            })
        })
    });
    listCast.forEach(item => {
        fetch(cast_uri, {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body:JSON.stringify({
                "id": 0,
                "movie_id": movie_id,
                "actor_id": item,
            })
        })
    });
    window.location.href = "../../admin/movies";
}
