using System;
using System.Web.Configuration;
using BLL.SystemManage;
using Entity;

//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
//using Entity;
//using BLL.EntityManage;

public partial class homePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        var user=new Entity.User();
        if (txtName.Value == "")
        {
            Response.Write("<script>alert('账号不能为空！');</script>");
            return;
        }
        if (txtPwd.Value == "")
        {
            Response.Write("<script>alert('密码不能为空！');</script>");
            return;
        }
        user.UserId=txtName.Value;
        user.PassWord = txtPwd.Value;
        var systemManage = new UserManage();
        user = systemManage.Login(user);
        if (user == null)
        {
            Response.Write("<script>alert('账号或密码错误，请重新输入！');</script>");
        }
        else
        {
            Session["UserInfo"] = user;
        }

    }

    protected void BtnRegister_Click(object sender, EventArgs e)
    {
        var user=new User();
        if (dtxtName.Value == "")
        {
            Response.Write("<script>alert('邮箱不能为空！');</script>");
            return;
        }
        if (dtxtPwd3.Value == "")
        {
            Response.Write("<script>alert('密码不能为空！');</script>");
            return;
        }
        if (dtxtPwd2.Value == "")
        {
            Response.Write("<script>alert('密码不能为空！');</script>");
            return;
        }
        if (dtxtPwd1.Value == "")
        {
            Response.Write("<script>alert('验证码不能为空！');</script>");
            return;
        }
        var systemManage = new BLL.SystemManage.UserManage();
        if(systemManage.Register(user)>0)
        {
            Response.Write("<script>alert('注册成功！');</script>");
        }
        else
        {
            Response.Write("<script>alert('注册失败！');</script>");
        }
    }

    protected void BtnSendRegisterCode_Click(object sender, EventArgs e)
    {
        
    }
}