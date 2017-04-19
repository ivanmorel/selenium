using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
 
    class Program
    {
        
       
        static void Main(string[] args)
        {
            
        }

        [SetUp]
        public void Init()
        {
            Driver.driver = new ChromeDriver();
        }

        [Test]
        public void FacebookRegister()
        {

            Method.GoToUrl("http://www.facebook.com");

            FacebookRegister fbregister = new FacebookRegister();

            fbregister.firstName.EnterText("Ivan");
            fbregister.lastName.EnterText("Morel");
            fbregister.email.EnterText("ivanmorel94@gmail.com");
            fbregister.emailCheck.EnterText("ivanmorel94@gmail.com");
            fbregister.password.EnterText("12345678");

            fbregister.day.DropdownSelect("20");
            fbregister.month.DropdownSelect("Aug");
            fbregister.year.DropdownSelect("1994");

            fbregister.btn1.Click();
            fbregister.btn2.Click();


            //------- Old Method ------------------------------------

            //Method.FillText( "name", "firstname", "Ivan");
            //Method.FillText( "name", "lastname", "Morel");
            //Method.FillText( "id", "u_0_6", "ivanmorel94@gmail.com");
            //Method.FillText( "id", "u_0_9", "ivanmorel94@gmail.com");
            //Method.FillText( "id", "u_0_d", "12345678");
            //Method.SelectDropdown( "id", "day", "20");
            //Method.SelectDropdown( "id", "month", "Aug");
            //Method.SelectDropdown( "id", "year", "1994");
            //Method.Click( "id", "u_0_h");
            //Method.Click( "id", "u_0_l");
        }

        [Test]
        public void FacebookLogIn()
        {
            Method.GoToUrl( "http://www.facebook.com");

            FacebookLogin fblogin = new FacebookLogin();

            fblogin.email.EnterText("ivanmorel94@hotmail.com");
            fblogin.pass.EnterText("12345678");
            fblogin.btnlogin.Click();

            //------- Old Method ------------------------------------

            //Method.FillText( "name", "email", "ivanmorel94@hotmail.com");
            //Method.FillText( "name", "pass", "12345678");
            //Method.Click( "id", "loginbutton");
        }


        [Test]
        public void Ebay()
        {
            Method.GoToUrl( "https://reg.ebay.com/reg/PartialReg?ru=http%3A%2F%2Fwww.ebay.com%2F");

            Ebay ebay = new Ebay();

            ebay.email.EnterText("ivanmorel94@gmail.com");
            ebay.remail.EnterText("ivanmorel94@gmail.com");
            ebay.password.EnterText("12345678");
            ebay.firstName.EnterText("Ivan");
            ebay.lastName.EnterText("Morel");
            ebay.phone.EnterText("8299302336");
            ebay.btn.Click();

            //------- Old Method ------------------------------------

            //Method.FillText( "name", "email", "ivanmorel94@gmail.com");
            //Method.FillText( "name", "remail", "ivanmorel94@gmail.com");
            //Method.FillText( "name", "PASSWORD", "12345678");
            //Method.FillText( "name", "firstname", "Ivan");
            //Method.FillText( "name", "lastname", "Morel");
            //Method.FillText( "name", "phoneFlagComp1", "8299302336");
            //Method.Click( "id", "sbtBtn");
        }

        [Test]
        public void Amazon()
        {
            Amazon amazon = new Amazon();

            Method.GoToUrl("https://www.amazon.com/ap/register?_encoding=UTF8&openid.assoc_handle=usflex&openid.claimed_id=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.identity=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.mode=checkid_setup&openid.ns=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0&openid.ns.pape=http%3A%2F%2Fspecs.openid.net%2Fextensions%2Fpape%2F1.0&openid.pape.max_auth_age=0&openid.return_to=https%3A%2F%2Fwww.amazon.com%2Fgp%2Fyourstore%2Fhome%3Fie%3DUTF8%26ref_%3Dnav_newcust");

            amazon.customerName.EnterText("Ivan Morel");
            amazon.email.EnterText("ivanmorel94@gmail.com");
            amazon.password.EnterText("12345678");
            amazon.passwordCheck.EnterText("12345678");
            amazon.btncontinue.Click();

            //------- Old Method ------------------------------------

            //Method.FillText("name", "customerName", "Ivan Morel");
            //Method.FillText("name", "email", "ivanmorel94@gmail.com");
            //Method.FillText("name", "password", "12345678");
            //Method.FillText("name", "passwordCheck", "12345678");
            //Method.Click("id", "continue");
        }

        [Test]
        public void Google()
        {
            Method.GoToUrl( "https://accounts.google.com/SignUp?hl=en");

            Google google = new Google();

            google.firstName.EnterText("Ivan");
            google.lastName.EnterText("Morel");
            google.gmailAddr.EnterText("ivanmorel809");
            google.pass.EnterText("12345678");
            google.passCheck.EnterText("12345678");

            System.Threading.Thread.Sleep(80);
            google.month.Click();
            google.monthdrop.Click();

            google.birthDay.EnterText("20");
            google.birthYear.EnterText("1994");

            google.gender.Click();
            google.male.Click();

            google.phoneRec.EnterText("9302336");
            google.emailRec.EnterText("ivanmorel94@gmail.com");

            //------- Old Method ------------------------------------

            //Method.FillText( "name", "FirstName", "Ivan");
            //Method.FillText( "name", "LastName", "Morel");
            //Method.FillText( "name", "GmailAddress", "ivanmorel809");
            //Method.FillText( "name", "Passwd", "12345678");
            //Method.FillText( "name", "PasswdAgain", "12345678");

            //System.Threading.Thread.Sleep(80);
            //Method.Click( "id", "BirthMonth");
            //Method.Click( "id", ":4");

            //Method.FillText( "name", "BirthDay", "20");
            //Method.FillText( "name", "BirthYear", "1994");

            //Method.Click( "id", "Gender");
            //Method.Click( "id", ":f");

            //Method.FillText( "name", "RecoveryPhoneNumber", "9302336");
            //Method.FillText( "name", "RecoveryEmailAddress", "ivanmorel94@gmail.com");
            //Method.Click( "name", "submitbutton");
        }


        [TearDown]
        public void Close()
        {
            Driver.driver.Close();
        }
    }
}
