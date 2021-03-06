﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Interactions.Internal;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-notifications");
            Driver.driver = new ChromeDriver(options);
            //Manage().Window.Maximize();
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
        }
        [Test]
        public void FacebookLogIn()
        {
            Method.GoToUrl( "http://www.facebook.com");
            FacebookLogin fblogin = new FacebookLogin();
            fblogin.email.EnterText("ivanmorel94@hotmail.com");
            fblogin.pass.EnterText("12345678");
            fblogin.btnlogin.Click();
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

            waitClickable("id", "BirthMonth");
            google.month.Click();
            google.monthdrop.Click();
            google.birthDay.EnterText("20");
            google.birthYear.EnterText("1994");
            google.gender.Click();
            google.male.Click();
            google.phoneRec.EnterText("9302336");
            google.emailRec.EnterText("ivanmorel94@gmail.com");
        }
        [Test]
        public void AmazonBuyItems()
        {
            AmazonBuyItem amazon = new AmazonBuyItem();
            Method.GoToUrl("https://www.amazon.com/");
            amazon.signIn.Click();
            amazon.email.EnterText("ivanmorel08@gmail.com");
            amazon.pass.EnterText("12345678");
            amazon.btnSignIn.Click();

            //Laptop Backpack----------------------------------------------
            Search(amazon, "laptop backpack", false);
            amazon.item.Click();
            amazon.btnAddToCart.Click();

            //iPhone 7 Case------------------------------------------------
            Search(amazon, "iphone 7 case", true);
            amazon.item2.Click();
            amazon.btnAddToCart.Click();

            //Laptop Sleeve-------------------------------------------------
            Search(amazon, "laptop sleeve", true);
            amazon.item3.Click();
            amazon.btnAddToCart.Click();
            CheckoutButtonWaitClick(amazon);

            //Shipping Address-----------------------------------------
            amazon.deleteAddr.Click();
            waitInvisible("Delete");
            amazon.fullName.EnterText("Test Johnson");
            amazon.addressLine.EnterText("Av Juan Pablo Duarte #7");
            amazon.addressLine2.EnterText("Residencial Apt. 4");
            amazon.city.EnterText("Santiago");
            amazon.state.EnterText("Santiago");
            amazon.zip.EnterText("51000");
            amazon.country.DropdownSelect("Dominican Republic");
            amazon.phone.EnterText("8091234567");
            amazon.btnContinue.Click();

            //Empty Cart-----------------------------------------------
            Method.GoToUrl("https://www.amazon.com/");
            amazon.cart.Click();
            waitClickable("name", AmazonBuyItem.deleteItemName1);
            amazon.deleteItem.Click();
            waitClickable("name", AmazonBuyItem.deleteItemName2);
            amazon.deleteItem2.Click();
            waitClickable("name", AmazonBuyItem.deleteItemName3);
            amazon.deleteItem3.Click();

            Method.GoToUrl("https://www.amazon.com/");
        }
        [Test]
        public void GmailSendEmail()
        {
            Method.GoToUrl("https://www.gmail.com/");
            GmailSend gmail = new GmailSend();
            gmail.email.EnterText("test829930@gmail.com");
            gmail.next.Click();
            waitClickable("name", "Passwd");
            gmail.pass.EnterText("123456123");
            gmail.signIn.Click();

            waitVisible("xpath", GmailSend.composeXpath);
            gmail.compose.Click();

            waitVisible("xpath", GmailSend.recipientXpath);
            gmail.recipients.EnterText("test829930@gmail.com");
            gmail.subject.EnterText("Test");
            gmail.textarea.EnterText("Funcionando");
            gmail.sendBtn.Click();
            gmail.inbox.Click();

            waitVisible("xpath", GmailSend.clickEmailXpath);
            gmail.selectEmail.Click();
            gmail.trash.Click();
        }
        [Test]
        public void FacebookPublishStatus()
        {
            Method.GoToUrl("https://www.facebook.com/");
            FacebookPublish fb = new FacebookPublish();
            fb.email.EnterText("test829930@gmail.com");
            fb.pass.EnterText("123456123");
            fb.loginBtn.Click();
            fb.publish.EnterText("Test publish");

            waitClickable("xpath", FacebookPublish.btnPublishXpath);
            fb.btnPublish.Click();

            waitClickable("xpath", FacebookPublish.optionsXpath);
            fb.options.Click();

            waitClickable("xpath", FacebookPublish.eliminarXpath);
            fb.eliminar.Click();

            waitClickable("xpath", FacebookPublish.eliminarPublishXpath);
            fb.eliminarPublish.Click();
        }
        [Test]
        public void YoutubeTest()
        {
            Method.GoToUrl("https://www.youtube.com/");
            Youtube yt = new Youtube();
            yt.signIn.Click();
            yt.email.EnterText("test829930@gmail.com");
            yt.next.Click();
            waitClickable("name", "Passwd");
            yt.pass.EnterText("123456123");
            yt.signIn2.Click();
            yt.searchBar.EnterText("youtube music");
            yt.searchBar.Submit();
            yt.musicLink.Click();

            waitClickable("xpath", Youtube.subscribeXpath);
            yt.subscribe.Click();

            waitClickable("xpath", Youtube.subscribeXpath);
            yt.subscribe.Click();

            waitClickable("xpath", Youtube.unsubscribeXpath);
            yt.unsubscribe.Click();
        }
        [Test]
        public void TakingScreenshot()
        {
            Navigate().GoToUrl("https://www.youtube.com");
            Driver.driver.GetScreenshot().SaveAsFile("C:\\Users\\Ivan\\Documents\\one.png", ScreenshotImageFormat.Png);
        }
        [Test]
        public void SetGetDeleteCookie()
        {
            Navigate().GoToUrl("https://www.youtube.com");
            Cookie cookie = new Cookie("username", "ivanmorel");
            Manage().Cookies.AddCookie(cookie);
            System.Console.WriteLine(Manage().Cookies.GetCookieNamed("username"));
            Manage().Cookies.DeleteCookieNamed("username");
        }
        [Test]
        public void GetTitlePageSource()
        {
            Navigate().GoToUrl("https://www.youtube.com/");
            System.Console.WriteLine("Title: "+Driver.driver.Title);
            System.Console.WriteLine("Page Source: "+Driver.driver.PageSource);
        }
        [Test]
        public void KeyboardMouse()
        {
            string xpath = "//*[@id='yt-masthead-signin']/div/button";

            Method.GoToUrl("https://www.youtube.com/");
            Keyboard().PressKey(Keys.Shift);
            Keyboard().SendKeys("Music");
            Keyboard().ReleaseKey(Keys.Shift);
          
            Mouse().Click(Id("search-btn").Coordinates);
            Mouse().ContextClick(Id("masthead-search-term").Coordinates);

            Mouse().MouseMove(Xpath(xpath).Coordinates);
            Mouse().MouseDown(Xpath(xpath).Coordinates);
            Mouse().MouseUp(Xpath(xpath).Coordinates);
            
            //ILocatable alternative
            //ILocatable locator = (ILocatable)Id("search-btn");
            //Mouse().Click(locator.Coordinates);
        }
        [Test]
        public void Actions()
        {
            Method.GoToUrl("https://www.youtube.com/");

            Actions action = new Actions(Driver.driver);
            action.KeyDown(Keys.Shift);
            action.SendKeys("shift on ");
            action.KeyUp(Keys.Shift);
            action.SendKeys("shift off");
            action.KeyDown(Keys.Control);
            action.KeyDown(Keys.Shift);
            action.SendKeys(Keys.Home);
            action.KeyUp(Keys.Shift);
            action.KeyUp(Keys.Control);
            action.SendKeys(Keys.Delete);
            action.SendKeys("Music");
            action.Perform();

            action = new Actions(Driver.driver);
            action.ContextClick(Id("search-btn"));
            action.ContextClick(PartialLink("Shape of You"));
            action.ContextClick(Id("masthead-search-term")); 
            action.Click(Id("search-btn"));
            action.Perform();

            action = new Actions(Driver.driver);
            action.DragAndDrop(PartialLink("Popular Music Videos"), Id("masthead-search-term"));
            action.Perform();

            action = new Actions(Driver.driver);
            action.ClickAndHold(PartialLink("Popular Music Videos"));
            action.MoveToElement(Id("masthead-search-term"));
            action.Release(Id("masthead-search-term"));
            action.Perform();

        }

        [Test]
        public void EventDriver()
        {
            EventFiringWebDriver edriver = new EventFiringWebDriver(Driver.driver);
            edriver.ElementClicked += new EventHandler<WebElementEventArgs>(Clicked);
            edriver.NavigatedBack += new EventHandler<WebDriverNavigationEventArgs>(Navigated);
            Navigate().GoToUrl("https://www.youtube.com");
            Keyboard().SendKeys("Music");
            waitClickable("id", "search-btn");
            edriver.FindElement(By.Id("search-btn")).Click(); // Fires an ElementClicked event
            Navigate().GoToUrl("https://www.google.com");
            edriver.Navigate().Back(); // Fires a NavigatedBack event
        }
        [TearDown]
        public void Close()
        {
            Driver.driver.Close();
        }

        /// <summary>
        /// Optimization and wait functions.
        /// </summary>
        public RemoteWebElement PartialLink(string partiallink) { return (RemoteWebElement)Driver.driver.FindElementByPartialLinkText(partiallink); }
        public RemoteWebElement Id(string id) { return (RemoteWebElement)Driver.driver.FindElementById(id); }
        public RemoteWebElement Xpath(string xpath) { return (RemoteWebElement)Driver.driver.FindElementByXPath(xpath); }
        public IMouse Mouse() { return Driver.driver.Mouse; }
        public IKeyboard Keyboard() { return Driver.driver.Keyboard; }
        public IOptions Manage() { return Driver.driver.Manage(); }
        public INavigation Navigate() { return Driver.driver.Navigate(); }
        public void Write(string str) { System.Console.WriteLine(str); }
        public void Sleep(int time) { System.Threading.Thread.Sleep(time); }
        public void Clicked(object sender, WebElementEventArgs e) { Write("Element clicked"); }
        public void Navigated(object sender, WebDriverNavigationEventArgs e) { Write("Navigated back"); }

        public void Search(AmazonBuyItem amazon, string search, Boolean wait)
        {
            if(wait)
                waitVisible("id", AmazonBuyItem.checkoutId);
            amazon.searchBar.Clear();
            amazon.searchBar.EnterText(search);
            amazon.searchBar.Submit();
        }
        public void waitClickable(string how, string element)
        {
            if (how =="partial link")
                (new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10))).Until((ExpectedConditions.ElementToBeClickable(By.PartialLinkText(element))));
            else if (how == "id")
                (new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10))).Until((ExpectedConditions.ElementToBeClickable(By.Id(element))));
            else if (how == "name")
                (new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10))).Until((ExpectedConditions.ElementToBeClickable(By.Name(element))));
            else if (how == "xpath")
                (new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10))).Until((ExpectedConditions.ElementToBeClickable(By.XPath(element))));
            else if (how == "classname")
                (new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10))).Until((ExpectedConditions.ElementToBeClickable(By.ClassName(element))));
        
        }
        public void waitVisible(string how, string element)
        {
            if (how == "partial link")
                (new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10))).Until((ExpectedConditions.ElementIsVisible(By.PartialLinkText(element))));
            else if (how == "id")
                (new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10))).Until((ExpectedConditions.ElementIsVisible(By.Id(element))));
            else if (how == "name")
                (new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10))).Until((ExpectedConditions.ElementIsVisible(By.Name(element))));
            else if (how == "xpath")
                (new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10))).Until((ExpectedConditions.ElementIsVisible(By.XPath(element))));
        }
        public void waitInvisible(string element)
        {
            (new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10))).Until((ExpectedConditions.InvisibilityOfElementLocated(By.PartialLinkText(element))));
        }
        public void CheckoutButtonWaitClick(AmazonBuyItem amazon)
        {
            waitVisible("id", AmazonBuyItem.checkoutId);
            amazon.btnCheckOut.Click();
        }

    }
    
}
