
$(document).ready(function () {
    $('.slickclass').slick({
        slidesToShow: 1,
        slidesToScroll: 1,
        autoplay: true,
        autoplaySpeed: 8000,
        arrows: false,
        fade: true,
        pauseOnFocus: false,
        pauseOnHover: false,
        easing: 'pulse'
    });

    $('.slickclass2').slick({
        dots: false,
        infinite: true,
        arrows: false,
        autoplay: true,
        pauseOnFocus: false,
        pauseOnHover: false,
        speed: 300,
        slidesToShow: 3,
        slidesToScroll: 1,
        responsive: [{
            breakpoint: 991,
            settings: {
                slidesToShow: 2,
                slidesToScroll: 1
            }
        },
        {
            breakpoint: 600,
            settings: {
                slidesToShow: 1,
                slidesToScroll: 1
            }
        }
        // You can unslick at a given breakpoint now by adding:
        // settings: "unslick"
        // instead of a settings object
        ]
    });

    $('.clientslick').slick({
        dots: false,
        infinite: true,
        arrows: false,
        autoplay: true,
        pauseOnFocus: false,
        pauseOnHover: false,
        speed: 300,
        slidesToShow: 3,
        slidesToScroll: 1,
        responsive: [
        {
            breakpoint: 768,
            settings: {
                slidesToShow: 2,
                slidesToScroll: 1
            }
        }]
    });

    var myCenter = new google.maps.LatLng(29.2730019, 48.0164527);
    function initialize() {
        var mapProp = {
            center: myCenter,
            zoom: 18,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        };
        var map = new google.maps.Map(document.getElementById("map"), mapProp);

        var marker = new google.maps.Marker({
            position: myCenter,
        });
        marker.setMap(map);
    }
    google.maps.event.addDomListener(window, 'load', initialize);
});