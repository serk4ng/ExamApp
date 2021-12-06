
$('.s1 li').each(function (index) {
    if ($('input', this).prop('checked')) {
        $(this).addClass('checked');
    }
});


$('.s1 li').click(function () {

    $('.s1 input').removeAttr('checked');
    $('input', this).attr('checked', 'checked');
    $('input', this).prop({
        checked: true
    });
    $('.s1 li').removeAttr('class');
    $(this).addClass('checked');

});


$('.s2 li').click(function () {

    $('.s2 input').removeAttr('checked');
    $('input', this).attr('checked', 'checked');
    $('input', this).prop({
        checked: true
    });
    $('.s2 li').removeAttr('class');
    $(this).addClass('checked');

});



$('.s3 li').click(function () {

    $('.s3 input').removeAttr('checked');
    $('input', this).attr('checked', 'checked');
    $('input', this).prop({
        checked: true
    });
    $('.s3 li').removeAttr('class');
    $(this).addClass('checked');

});


$('.s4 li').click(function () {

    $('.s4 input').removeAttr('checked');
    $('input', this).attr('checked', 'checked');
    $('input', this).prop({
        checked: true
    });
    $('.s4 li').removeAttr('class');
    $(this).addClass('checked');

});

localStorage.setItem('examcheckurl', '/Exam/CheckExam');