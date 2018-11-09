function selamVer(isim) {
    return "Merhaba Gardaşım " + isim;
}
var mesaj = selamVer('Niğmet Ali');
console.log(mesaj);
var sayi;
sayi = 10;
sayi = 10.4;
//sayi = "Ali" // olmaaaaaaz
var sehir;
sehir = "Ankara";
//sehir = 20 // olmaaaaaazzz 
var dougruMu;
dougruMu = true;
dougruMu = false;
var sayilar = [1, 2, 3];
var sayilar2 = [1, 2, 3];
var dizi = [2, "Adana"];
var Renk;
(function (Renk) {
    Renk[Renk["Kirmizi"] = 1] = "Kirmizi";
    Renk[Renk["Siyah"] = 2] = "Siyah";
    Renk[Renk["Mavi"] = 3] = "Mavi";
})(Renk || (Renk = {})); //başlangıç değeri verebiliriz, kendisi otomatik olarak atratırır
var renk = Renk.Kirmizi;
