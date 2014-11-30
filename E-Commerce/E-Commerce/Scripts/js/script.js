

var mainSliderValue = 0, newArrivalsValue = 0;
var newArrItemsNo = $('#ContentPlaceHolder1_upNewArrivals > .owl-item').length;
function slideMe() {
    setInterval(
  function () {

      if (mainSliderValue == 0) {
          mainSliderValue = -1000;
          $('#slider').animate({ left: mainSliderValue });

      }
      else if (mainSliderValue == -1000) {
          mainSliderValue = -1950;
          $('#slider').animate({ left: mainSliderValue });

      }
      else if (mainSliderValue == -1950) {
          mainSliderValue = -2850;
          $('#slider').animate({ left: mainSliderValue });

      }
      else if (mainSliderValue == -2850) {
          mainSliderValue = 0;
          $('#slider').animate({ left: mainSliderValue });

      }

  }, 5000);



   

}

$('#ps-prev').click(function () {
    if (mainSliderValue == 0) {
        mainSliderValue = -2850;
        $('#slider').animate({ left: mainSliderValue });

    }
    else if (mainSliderValue == -1000) {
        mainSliderValue = 0;
        $('#slider').animate({ left: mainSliderValue });

    }
    else if (mainSliderValue == -1950) {
        mainSliderValue = -1000;
        $('#slider').animate({ left: mainSliderValue });

    }
    else if (mainSliderValue == -2850) {
        mainSliderValue = -1950;
        $('#slider').animate({ left: mainSliderValue });

    }
});


$('#ps-next').click(function () {
    if (mainSliderValue == 0) {
        mainSliderValue = -1000;
        $('#slider').animate({ left: mainSliderValue });

    }
    else if (mainSliderValue == -1000) {
        mainSliderValue = -1950;
        $('#slider').animate({ left: mainSliderValue });

    }
    else if (mainSliderValue == -1950) {
        mainSliderValue = -2850;
        $('#slider').animate({ left: mainSliderValue });

    }
    else if (mainSliderValue == -2850) {
        mainSliderValue = 0;
        $('#slider').animate({ left: mainSliderValue });

    }
});

slideMe();



$(".panel-heading , .dropdown-tree-a").click(function () {

   
    $header = $(this);
    $content = $header.next();
    $listItem = $header.parent();
    if ($listItem.hasClass("category-heading")) {
        $listItem.removeClass("category-heading");
    }
    else {
        $listItem.addClass("category-heading");
    }
    $content.slideToggle(500, function () {
        $header.text(function () {
        });
    });
});



$('#UpdatePanel1').click(function () {
    
    $('#ModalLogin').modal('show');
});

Sys.WebForms.PageRequestManager.getInstance().add_endRequest(InIEvent);

function InIEvent() {

    $(".panel-heading , .dropdown-tree-a").click(function () {

        
        $header = $(this);
        $content = $header.next();
        $listItem = $header.parent();
        if ($listItem.hasClass("category-heading")) {
            $listItem.removeClass("category-heading");
        }
        else {
            $listItem.addClass("category-heading");
        }
        $content.slideToggle(500, function () {
            $header.text(function () {
            });
        });
    });



    $('#ps-next').click(function () {
        if (mainSliderValue == 0) {
            mainSliderValue = -1000;
            $('#slider').animate({ left: mainSliderValue });

        }
        else if (mainSliderValue == -1000) {
            mainSliderValue = -1950;
            $('#slider').animate({ left: mainSliderValue });

        }
        else if (mainSliderValue == -1950) {
            mainSliderValue = -2850;
            $('#slider').animate({ left: mainSliderValue });

        }
        else if (mainSliderValue == -2850) {
            mainSliderValue = 0;
            $('#slider').animate({ left: mainSliderValue });

        }
    });

    $('#ps-prev').click(function () {
        if (mainSliderValue == 0) {
            mainSliderValue = -2850;
            $('#slider').animate({ left: mainSliderValue });

        }
        else if (mainSliderValue == -1000) {
            mainSliderValue = 0;
            $('#slider').animate({ left: mainSliderValue });

        }
        else if (mainSliderValue == -1950) {
            mainSliderValue = -1000;
            $('#slider').animate({ left: mainSliderValue });

        }
        else if (mainSliderValue == -2850) {
            mainSliderValue = -1950;
            $('#slider').animate({ left: mainSliderValue });

        }
    });
}


$(document).ready(function () {
   

    //harlem shake 
 
});





