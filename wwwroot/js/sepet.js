function sepeteEkle(btn) {

    let urunId = $(btn).parent().parent().children("p").text();
    console.log(urunId);

    let fiyat = $(btn).prev().text();
    console.log(fiyat);

    let urunadi = $(btn).prev().prev().text();
    console.log(urunadi);
    
    let adet = $(btn).next().val();
    console.log(adet);




    $("tbody").append("<tr id='yaz'> <td style='display:none;'>" + urunId + "</td><td>" + urunadi + "</td><td>" + adet + "</td><td>" + fiyat + "</td></tr >");
    
};
