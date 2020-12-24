//$(document).ready(function () {
//    $("input[type='submit']").click(function () {
//        cate_uri = 'api/movie_category';
//        listCate.forEach(item => {
//            fetch($`cate_uri`, {
//                method: 'POST',
//                headers: {
//                    'Accept': 'application/json',
//                    'Content-Type': 'application/json'
//                },
//                body: JSON.stringify({
//                    "id": 0,
//                    "category_id": item,
//                    "movie_id": 
//                })
//            })
//                //.then(respone => respone.json())
//                //.then(responeAsJson => {
//                //    location.reload();
//                //    console.log(responeAsJson);
//                //})
//                .catch(error => console.log(error));
//        });
//    });
//});