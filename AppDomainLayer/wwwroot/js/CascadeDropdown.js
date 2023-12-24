$(document).ready(function(){
    GetCountryList();
    //GetStateList();
    $("#state").attr('disabled', true);
    $("#city").attr('disabled', true);
    $("#country").change(function () {
        $("#state").attr('disabled', false);
        var id = $(this).val();
        $("#state").empty();
        $("#state").append('<Option>-Select State-</Option>');
        $.ajax({
            url: '/Cascade/StateList?id=' + id,
            success: function (result) {
                console.log(result);
                $.each(result, function (i, data) {
                    $("#state").append('<Option value=' + data.id + '>' + data.name + '</Option>');
                })
            }
        })
    });

    $("#state").change(function () {
        $("#city").attr('disabled', false);
        var id = $(this).val();
        $("#city").empty();
        $("#city").append('<Option>-Select City-</Option>');
        $.ajax({
            url: '/Cascade/CityList?id=' + id,
            success: function (result) {
                console.log(result);
                $.each(result, function (i, data) {
                    $("#city").append('<Option value=' + data.id + '>' + data.cityName + '</Option>');
                })
            }
        })
    });
});

function GetCountryList() {
    $.ajax({
        url: '/Cascade/CountryList',
        success: function (result) {
            console.log(result);
            $.each(result, function (i, data) {
                $("#country").append('<Option value=' + data.id + '>' + data.countryName +'</Option>');
            })
        }
    })
}

//function GetStateList() {
//    $.ajax({
//        url: '/Cascade/StateList',
//        success: function (result) {
//            console.log("State",result);
//            $.each(result, function (i, data) {
//                $("#state").append('<Option value=' + data.id + '>' + data.name + '</Option>');
//            })
//        }
//    })
//}

//function GetStateList() {
//    $.ajax({
//        url: '/Cascade/CityList',
//        success: function (result) {
//            console.log(result);
//            $.each(result, function (i, data) {
//                $("#city").append('<Option value=' + data.id + '>' + data.countryName + '</Option>');
//            })
//        }
//    })
//}