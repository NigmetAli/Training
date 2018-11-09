/*******JAVASCRIPT****** */
function toplaJS(x, y) {
    return x + y;
}
console.log(toplaJS(2, 3));
console.log(toplaJS(2, "Adana"));
/*******TYPESCRIPT****** */
function toplaTS(x, y) {
    return x + y;
}
console.log(toplaTS(2, 32));
//console.log(toplaTS(2, "ada")) // olmaaaz ,hata 
var toplaTS2 = function (x, y) {
    return x + y;
};
console.log(toplaTS2(5, 6));
//console.log(toplaTS2(2, "ada")) // olmaaaz ,hata 
function toplaTS3(x, y) {
    if (y === void 0) { y = 0; }
    return x + y;
}
console.log(toplaTS3(3)); // default değerini fonksiyonu tanımlarken verdiğimiz için sıkıntı çıkmaz
console.log(toplaTS3(3, 5));
function toplaTS4(x, y) {
    return x + y;
}
console.log(toplaTS4(5)); // şimdi bu şekilde kullanabiliriz fakat böyl eyaparsak bize soınuıç olarak NaN(Not a Number) döndürecektir. Bu yüzden
function toplaTS5(x, y) {
    if (y) {
        return x + y;
    }
    return x;
}
console.log(toplaTS5(5)); // şimdi doğru şekilde çalışacaktır 
