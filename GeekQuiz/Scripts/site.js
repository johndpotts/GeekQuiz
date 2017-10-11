//section scroll
$('.section-scroll').on('click', function (e) {
    var target = this.hash;
    var $target = $(target);

    $('html, body').stop().animate({
        'scrollTop': $target.offset().top -80
    }, 900, 'swing');

    e.preventDefault();
});