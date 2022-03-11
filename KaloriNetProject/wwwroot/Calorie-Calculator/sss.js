var sayi1 = document.getElementById("s1");
var sayi2 = document.getElementById("s3");
var sayi2 = document.getElementById("sonuc1");


function hesapla() {


    var KosuDegeri = Number(sayi1.value) * Number(sayi3.value);
    sonuc1.InnerHTML = KosuDegeri;

}
sayi1.oninput = hesapla;
sayi2.oninput = hesapla;


