<!--下拉菜单-->
function displaySubMenu(li) {
    var subMenu = li.getElementsByTagName("ul")[0];
    subMenu.style.display = "block";
}

function hideSubMenu(li) {
    var subMenu = li.getElementsByTagName("ul")[0];
    subMenu.style.display = "none";
}
<!-- 图片轮播-->
$(function() {
    <!--调用Luara示例-->
    $(".example").luara({ width: "1042", height: "334", interval: 2000, selected: "seleted" });
});
<!--登录弹窗-->
$(function($) {
    //弹出登录
    $("#example").hover(function() {
        $(this).stop().animate({
            opacity: '1'
        }, 600);
    }, function() {
        $(this).stop().animate({
            opacity: '0.6'
        }, 1000);
    }).on('click', function() {
        $("body").append("<div id='mask'></div>");
        $("#mask").addClass("mask").fadeIn("slow");
        $("#LoginBox").fadeIn("slow");
    });
    //
    //按钮的透明度
    $("#loginbtn").hover(function() {
        $(this).stop().animate({
            opacity: '1'
        }, 600);
    }, function() {
        $(this).stop().animate({
            opacity: '0.8'
        }, 1000);
    });

    //关闭
    $(".close_btn").hover(function() { $(this).css({ color: 'black' }) }, function() { $(this).css({ color: '#999' }) }).on('click', function() {
        $("#LoginBox").fadeOut("fast");
        $("#mask").css({ display: 'none' });
    });
});
$(function($) {
    //弹出登录
    $("#example1").hover(function() {
        $(this).stop().animate({
            opacity: '1'
        }, 600);
    }, function() {
        $(this).stop().animate({
            opacity: '0.6'
        }, 1000);
    }).on('click', function() {
        $("body").append("<div id='dmask'></div>");
        $("#dmask").addClass("mask").fadeIn("slow");
        $("#dLoginBox").fadeIn("slow");
    });
    //
    //按钮的透明度
    $("#dloginbtn").hover(function() {
        $(this).stop().animate({
            opacity: '1'
        }, 600);
    }, function() {
        $(this).stop().animate({
            opacity: '0.8'
        }, 1000);
    });
    //文本框不允许为空---按钮触发
    $("#dloginbtn").on('click', function() {
        var txtName = $("#dtxtName").val();
        var txtPwd = $("#dtxtPwd").val();
        if (txtName == "" || txtName == undefined || txtName == null) {
            if (txtPwd == "" || txtPwd == undefined || txtPwd == null) {
                $(".dwarning").css({ display: 'block' });
            } else {
                $("#dwarn").css({ display: 'block' });
                $("#dwarn2").css({ display: 'none' });
            }
        } else {
            if (txtPwd == "" || txtPwd == undefined || txtPwd == null) {
                $("#dwarn").css({ display: 'none' });
                $(".dwarn2").css({ display: 'block' });
            } else {
                $(".dwarning").css({ display: 'none' });
            }
        }
    });
    //文本框不允许为空---单个文本触发
    $("#txtName").on('blur', function() {
        var txtName = $("#txtName").val();
        if (txtName == "" || txtName == undefined || txtName == null) {
            $("#warn").css({ display: 'block' });
        } else {
            $("#warn").css({ display: 'none' });
        }
    });
    $("#txtName").on('focus', function() {
        $("#warn").css({ display: 'none' });
    });
    //
    $("#txtPwd").on('blur', function() {
        var txtName = $("#txtPwd").val();
        if (txtName == "" || txtName == undefined || txtName == null) {
            $("#warn2").css({ display: 'block' });
        } else {
            $("#warn2").css({ display: 'none' });
        }
    });
    $("#txtPwd").on('focus', function() {
        $("#warn2").css({ display: 'none' });
    });
    //关闭
    $(".dclose_btn").hover(function() { $(this).css({ color: 'black' }) }, function() { $(this).css({ color: '#999' }) }).on('click', function() {
        $("#dLoginBox").fadeOut("fast");
        $("#dmask").css({ display: 'none' });
    });
});
