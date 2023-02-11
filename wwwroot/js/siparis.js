function satinal(btn) {
    var orderDetails = [];
    var toplamAdet = 0;
    var toplamFiyat = 0;

    $(btn).prev().children("tbody").children("tr").each((index, satir) => {
        let Ide = parseInt($(satir).children("td").eq(0).text());
        console.log("ürünId: " + Ide);

        let urunAd = $(satir).children("td").eq(1).text();
        console.log("urunAd: " + urunAd);

        let urunAdet = parseInt($(satir).children("td").eq(2).text());
        console.log("urunAdet: " + urunAdet);

        let urunFiyat = parseInt($(satir).children("td").eq(3).text());
        console.log("urunFiyat: " + urunFiyat);

        toplamAdet += urunAdet;
        toplamFiyat += urunAdet * urunFiyat;


        //let product =
        //{
        //    Id: Ide, // input hidden olarak düzelt, oradan gelecek
        //    ProductName: urunAd,
        //    Price: urunFiyat
        //}

        var ordDtl =
        {
            /*Id: index + 1,*/
            /*OrderId: index + 1,*/
            Quantity: urunAdet,
            /*Product: product,*/
            ProductId: Ide
        }
        orderDetails.push(ordDtl);
        
    });

    var d = (new Date()).toUTCString();
    console.log(d);


    let order = {
        /*Id: 1,*/
        CreatedDate: d,
        Ouantity: parseInt(toplamAdet),
        Price: parseFloat(toplamFiyat),
        AppUserId: 1001,
        OrderDetails: orderDetails

    }

    $.ajax({
        method: "POST",
        url: "/Member/AjaxIlePost",
        //dataType: "application/json",
        data: { siparis: order }, // JSON.stringify(order)
        error: function (response) {
            alert("Başarısız. Hata : " + response.detail);
        },
        success: function () {
            alert("Başarılı");
        }


    });
}

