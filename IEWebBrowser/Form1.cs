using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEWebBrowser
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void WebAddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddressMoveButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(WebAddressTextBox.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate("https://accounts.kakao.com/login?continue=https%3A%2F%2Flogins.daum.net%2Faccounts%2Fksso.do%3Frescue%3Dtrue%26url%3Dhttps%253A%252F%252Fwww.daum.net%252F");
            WebLogin();
        }

        private async void WebLogin()
        {
            await Task.Delay(1500);
            webBrowser1.Document.GetElementById("id_email_2").SetAttribute("value", "ghqnftk@kakao.com");
            webBrowser1.Document.GetElementById("id_password_3").SetAttribute("value", "wjddlfghk1");
           
            await Task.Delay(1500);
            HtmlElementCollection loginButton = webBrowser1.Document.GetElementsByTagName("button");
            foreach (HtmlElement seachLogin in loginButton)
            {
                if (seachLogin.InnerText == "로그인")
                {
                    seachLogin.InvokeMember("click");
                }
            }

        }
    }
}
