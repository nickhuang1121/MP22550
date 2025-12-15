const xhr = new XMLHttpRequest();
xhr.open("GET", "https://jsonplaceholder.typicode.com/posts/1", true);
xhr.onload = function (e) {
    console.log(this.response)
};
xhr.send();