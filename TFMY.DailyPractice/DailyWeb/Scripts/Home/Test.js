$('#ClickMe').on('click', function myfunction() {
    //layer.msg('Hello layer', {time:800});
    //layer.open({
    //    type: 1,
    //    title: false,
    //    content: 'Hello'
    //});

    //layer.open({
    //    type: 2,
    //    content: 'http://www.zizhiguanjia.com' //这里content是一个URL，如果你不想让iframe出现滚动条，你还可以content: ['http://sentsin.com', 'no']
    //});
    layer.open({
        type: 1,
        content: '测试' //数组第二项即吸附元素选择器或者DOM
    });
});