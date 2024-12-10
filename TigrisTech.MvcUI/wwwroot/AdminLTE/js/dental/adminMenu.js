
console.log("hakim")
    $('ul li ul li a').click(function () {
        console.log("zerya");
        $('li a').removeClass("active");
        $(this).addClass("active");

    });

