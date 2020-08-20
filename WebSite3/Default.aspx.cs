using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    public string lang = "ru";
    protected void Page_Load(object sender, EventArgs e)
    {   
        //читаем куки
        HttpCookie cookie = Request.Cookies["Preferences"];
        if (cookie != null && cookie["Language"] != null) {
            output.Text = cookie["Language"];
        }
        
    }

    protected void deleteLangCookieButton_Click(object sender, EventArgs e)
    {
        HttpCookie cookie = new HttpCookie("Preferences");
        cookie.Expires = DateTime.Now.AddDays(-1);
        Response.Cookies.Add(cookie);
    }

    protected void setLangCookieButton_Click(object sender, EventArgs e)
    {
        // Создать объект cookie-набора.
        HttpCookie cookie = new HttpCookie("Preferences");
        // Установить значение в нем.
        cookie["Language"] = "English";
        // Добавить в него еще одно значение.
        cookie["Country"] = "US";
        // Хранить 1 год
        cookie.Expires = DateTime.Now.AddYears(1);
        // Добавить cookie-набор к текущему веб-ответу.
        Response.Cookies.Add(cookie);
    }
}