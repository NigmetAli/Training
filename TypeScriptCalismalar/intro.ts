function selamVer(isim: string) {
    return "Merhaba Gardaşım " + isim
}

let mesaj = selamVer('Niğmet Ali');

console.log(mesaj)

let sayi: number;
sayi = 10;
sayi = 10.4;
//sayi = "Ali" // olmaaaaaaz


/*************************************************   değişken tipleri  *****************************************************************/
let sehir: string
sehir = "Ankara"
//sehir = 20 // olmaaaaaazzz 

let dougruMu: boolean
dougruMu = true
dougruMu = false

let sayilar: number[] = [1, 2, 3];
let sayilar2: Array<number> = [1, 2, 3]

let dizi: [number, string] = [2, "Adana"]

/*************************************************   enum  *****************************************************************/
enum Renk { Kirmizi = 1, Siyah, Mavi } //başlangıç değeri verebiliriz, kendisi otomatik olarak atratırır
let renk: Renk = Renk.Kirmizi;

/*************************************************   any  *****************************************************************/
let deger: any = "Adana"
deger = 5
deger = false

/*************************************************   void  *****************************************************************/
let bos: void = null
let tanimlanmamis: void = undefined
//let olurmu:void = 6 // olmaaaaz void e değer atayamazsın

function selam(): void {
    console.log("Selamun Aleyküm")
    //return 4 // olmaaaz döndüremezsin çünkü void
}
