<%@ Page Language="C#" AutoEventWireup="true" CodeFile="homePage.aspx.cs" Inherits="homePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="renderer" content="webkit"/>
    <meta http-equiv="X-FRAME-OPTIONS" content="DENY" />
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=9"/>
    <title>index</title>
    <link rel="stylesheet" href="css/index.css"/>
    <link rel="stylesheet" href="css/luara.css" />
    <link rel="Stylesheet" type="text/css" href="css/loginDialog.css" />
    <link rel="Stylesheet" type="text/css" href="css/loginDialog2.css" />
</head>
<body>
 <form id="form1" runat="server">
     <div id="content">
        <div id="head">
            <img id="logo" src="" alt=""/>
            <img id="headPhoto" src="img/head.png" alt=""/>
            <a class="register" href=""></a>
        </div>
        <a href="#" id="example">登录</a>
        <div id="LoginBox">
            <div class="row1">
                登录<a href="javascript:void(0)" title="关闭窗口" class="close_btn" id="closeBtn">×</a>
            </div>
            <div class="row">
                用户名: <span class="inputBox"/>
                <input runat="server" type="text" id="txtName" placeholder="账号/邮箱" />
        </div>
        <div class="row">
            密&nbsp码: <span class="inputBox"/>
                <input runat="server" type="password" id="txtPwd" placeholder="密码" />
        </div>
        <div class="row">
            <a href="#" runat="server" OnServerClick="BtnLogin_Click" id="loginbtn">登录</a>
<%--            <asp:Button id="loginbtn" runat="server" Text="登录" OnClick="BtnLogin_Click"/>--%>
        </div>
    </div>
    <a href="#" id="example1">注册</a>
    <div id="dLoginBox">
        <div class="drow1">
            注册<a href="javascript:void(0)" title="关闭窗口" class="dclose_btn" id="dcloseBtn">×</a>
        </div>
        <div class="drow">
            学生邮箱: <span class="dinputBox">
                <input runat="server" type="text" id="dtxtName" placeholder="学生邮箱" />
            </span><a href="javascript:void(0)" title="提示" class="dwarning" id="dwarn">*</a>
            </div>
            <div class="drow">
                密&nbsp码: <span class="dinputBox">
                <input runat="server" type="password" id="dtxtPwd3" placeholder="密码" />
            </span><a href="javascript:void(0)" title="提示" class="dwarning" id="dwarn2">*</a>
            </div>
            <div class="drow">
                确认密码: <span class="dinputBox">
                <input runat="server" type="password" id="dtxtPwd2" placeholder="再次输入密码" />
            </span><a href="javascript:void(0)" title="提示" class="dwarning" id="dwarn2">*</a>
            </div>
            <div class="drow">
                验证码: <span class="dinputBox">
                <input runat="server" type="text" id="dtxtPwd1" placeholder="邮件" />
            </span><a href="javascript:void(0)" title="提示" class="dwarning" id="dwarn2">*</a>
            </div>
            <div class="drow">
                <a href="#" runat="server" id="dloginbtn" OnServerClick="BtnRegister_Click">注册</a>
<%--                <asp:Button id="dloginbtn" runat="server" Text="注册" OnClick="BtnRegister_Click"/>--%>
            </div>
            <div class="drow2">
                <a href="#" runat="server" OnServerClick="BtnSendRegisterCode_Click" id="dloginbtn1">发送验证码</a>
<%--                <asp:Button id="dloginbtn1" runat="server" Text="发送验证码" OnClick="BtnSendRegisterCode_Click"/>--%>
            </div>
        </div>
        <div id="main">
            <div id="menu">
                <ul class="mainnav">
                    <li class="homepage"><a href="">首页</a></li>
                    <li class="navOne" onmouseover="displaySubMenu(this)" onmouseout="hideSubMenu(this)"><a href="">闲置商品</a>
                        <ul class="">
                            <li class="subnavone"><a href="">商品分类</a></li>
                            <li class="subnavone"><a href="">一键淘书</a></li>
                            <li class="subnavone"><a href="">技术协助</a></li>
                            <li class="subnavone" style="border-radius: 0px 0px 10px 10px;"><a href="">团购</a></li>
                        </ul>
                    </li>
                    <li class="navTwo" onmouseover="displaySubMenu(this)" onmouseout="hideSubMenu(this)"><a href="">论坛专区</a>
                        <ul>
                            <li class="subnavtwo"><a href="">发布帖子</a></li>
                            <li class="subnavtwo" style="border-radius: 0px 0px 10px 10px;"><a href="">我的回复</a></li>
                        </ul>
                    </li>
                    <li class="navThree" onmouseover="displaySubMenu(this)" onmouseout="hideSubMenu(this)"><a href="">我的闲置</a>
                        <ul>
                            <li class="subnavthree"><a href="">发布闲置</a></li>
                            <li class="subnavthree"><a href="">查看闲置</a></li>
                            <li class="subnavthree" style="border-radius: 0px 0px 10px 10px;"><a href="">个人主页</a></li>
                        </ul>
                    </li>
                </ul>
                <input type="button" class="searchbutton">
                <input type="text" class="search" value="请输入搜索内容">
            </div>
            <div class="example">
                <ul>
                    <li class="photo"><a href=""><img style="width:1042px;" src="img/01.jpg" alt="" /></a></li>
                    <li class="photo"><a href=""><img style="width:1042px;" src="img/02.jpg" alt="" /></a></li>
                    <li class="photo"><a href=""><img style="width:1042px;" src="img/03.jpg" alt="" /></a></li>
                    <li class="photo"><a href=""><img style="width:1042px;" src="img/04.jpg" alt="" /></a></li>
                </ul>
                <ol>
                    <li></li>
                    <li></li>
                    <li></li>
                    <li></li>
                </ol>
            </div>
            <div id="link">
                <div class="linkOne">
                    <a href="" class="linkTo">推荐闲置</a>
                    <a href="" class="arrow"><img src="img/arrow.png" alt=""></a>
                </div>
                <div class="linkTwo">
                    <a href="" class="linkTo">限时商品</a>
                    <a href="" class="arrow"><img src="img/arrow.png" alt=""></a>
                </div>
                <div class="linkThree">
                    <a href="" class="linkTo">热门讨论</a>
                    <a href="" class="arrow"><img src="img/arrow.png" alt=""></a>
                </div>
            </div>
            <div id="sidebar">
                <div id="sidebarOne">
                    <div class="theme">
                        <img src="img/themeOne.png" alt="">
                        <p>闲置商品</p>
                    </div>
                    <div class="sidecontainer">
                        <img src="img/sidearrow.png" alt="">
                        <ul class="list">
                            <li><a href="">商品分类</a></li>
                            <li><a href="">一键淘书</a></li>
                            <li><a href="">技术协助</a></li>
                            <li><a href="">团购</a></li>
                        </ul>
                    </div>
                </div>
                <div id="sidebarTwo">
                    <div class="theme">
                        <img src="img/themeTwo.png" alt="">
                        <p>论坛专区</p>
                    </div>
                    <div class="sidecontainer">
                        <img src="img/sidearrow.png" alt="">
                        <ul class="list">
                            <li><a href="">发布帖子</a></li>
                            <li><a href="">我的回复</a></li>
                        </ul>
                    </div>
                </div>
                <div id="sidebarThree">
                    <div class="theme">
                        <img src="img/themeThree.png" alt="">
                        <p>我的闲置</p>
                    </div>
                    <div class="sidecontainer">
                        <img src="img/sidearrow.png" alt="">
                        <ul class="list">
                            <li><a href="">发布闲置</a></li>
                            <li><a href="">查看闲置</a></li>
                            <li><a href="">个人主页</a></li>
                        </ul>
                    </div>
                </div>
                <div id="banner">
                    <ul>
                        <li>广告</li>
                        <li>广告</li>
                        <li>广告</li>
                        <li>广告</li>
                        <li>广告</li>
                        <li>广告</li>
                    </ul>
                </div>
            </div>
            <div id="shop">
                <div class="product">
                    <img style="height:172px;" src="img/product.png" alt="">
                    <p class="price">¥56.5</p>
                    <p class="productname">C高级编程</p>
                    <div class="buy">
                        <p><a href="">购买</a></p>
                    </div>
                    <div class="details">
                        <p><a href="">详情</a></p>
                        <a href=""><img  src="img/productarrow.png" alt=""/></a>
                    </div>
                </div>
                <div class="product">
                    <img style="height:172px;" src="img/product.png" alt="">
                    <p class="price">¥56.5</p>
                    <p class="productname">C高级编程</p>
                    <div class="buy">
                        <p><a href="">购买</a></p>
                    </div>
                    <div class="details">
                        <p><a href="">详情</a></p>
                        <a href=""><img src="img/productarrow.png" alt=""></a>
                    </div>
                </div>
                <div class="product">
                    <img style="height:172px;" src="img/product.png" alt="">
                    <p class="price">¥56.5</p>
                    <p class="productname">C高级编程</p>
                    <div class="buy">
                        <p><a href="">购买</a></p>
                    </div>
                    <div class="details">
                        <p><a href="">详情</a></p>
                        <a href=""><img src="img/productarrow.png" alt=""></a>
                    </div>
                </div>
                <div class="product">
                    <img style="height:172px;" src="img/product.png" alt="">
                    <p class="price">¥56.5</p>
                    <p class="productname">C高级编程</p>
                    <div class="buy">
                        <p><a href="">购买</a></p>
                    </div>
                    <div class="details">
                        <p><a href="">详情</a></p>
                        <a href=""><img src="img/productarrow.png" alt=""></a>
                    </div>
                </div>
                <div class="product">
                    <img style="height:172px;" src="img/product.png" alt="">
                    <p class="price">¥56.5</p>
                    <p class="productname">C高级编程</p>
                    <div class="buy">
                        <p><a href="">购买</a></p>
                    </div>
                    <div class="details">
                        <p><a href="">详情</a></p>
                        <a href=""><img src="img/productarrow.png" alt=""></a>
                    </div>
                </div>
                <div class="product">
                    <img style="height:172px;" src="img/product.png" alt="">
                    <p class="price">¥56.5</p>
                    <p class="productname">C高级编程</p>
                    <div class="buy">
                        <p><a href="">购买</a></p>
                    </div>
                    <div class="details">
                        <p><a href="">详情</a></p>
                        <a href=""><img src="img/productarrow.png" alt=""></a>
                    </div>
                </div>
                <div class="product">
                    <img style="height:172px;" src="img/product.png" alt="">
                    <p class="price">¥56.5</p>
                    <p class="productname">C高级编程</p>
                    <div class="buy">
                        <p><a href="">购买</a></p>
                    </div>
                    <div class="details">
                        <p><a href="">详情</a></p>
                        <a href=""><img src="img/productarrow.png" alt=""></a>
                    </div>
                </div>
                <div class="product">
                    <img style="height:172px;" src="img/product.png" alt="">
                    <p class="price">¥56.5</p>
                    <p class="productname">C高级编程</p>
                    <div class="buy">
                        <p><a href="">购买</a></p>
                    </div>
                    <div class="details">
                        <p><a href="">详情</a></p>
                        <a href=""><img src="img/productarrow.png" alt=""></a>
                    </div>
                </div>
                <div class="product">
                    <img style="height:172px;" src="img/product.png" alt="">
                    <p class="price">¥56.5</p>
                    <p class="productname">C高级编程</p>
                    <div class="buy">
                        <p><a href="">购买</a></p>
                    </div>
                    <div class="details">
                        <p><a href="">详情</a></p>
                        <a href=""><img src="img/productarrow.png" alt=""></a>
                    </div>
                </div>
            </div>
            <div id="footer">
                <img class="footerone" src="img/footerone.png" alt="">
                <div class="dashone"></div>
                <img class="footertwo" src="img/footertwo.png" alt="">
                <div class="dashtwo"></div>
                <img class="footerthree" src="img/footerthree.png" alt="">
                <div class="dashthree"></div>
                <img class="footerfour" src="img/footerfour.png" alt="">
                <div class="dashfour"></div>
                <img class="footerfive" src="img/footerfive.png" alt="">
            </div>
        </div>
        <a class="about" href="">关于Hand2U</a>
        <ul class="copyright">
            <li><a href="">友情链接</a></li>
            <li><a href="">诚聘英才</a></li>
            <li><a href="">联系我们</a></li>
            <li><a href="">网站地图</a></li>
            <li><a href="">意见反馈</a></li>
            <li><a href="">帮助中心</a></li>
            <li>客服电话：110-110-110-110</li>
        </ul>
    </div>
    <script src="js/jquery-1.8.3.min.js"></script>
    <script src="js/jquery.luara.0.0.1.min.js"></script>
    <script type="text/javascript" src="js/index.js"></script>
    </form>
</body>
</html>
