using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class AmazonBuyItem
    {
        public AmazonBuyItem()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        public const string deleteItemName1 = "submit.delete.C3OKBU8RUKAMCM";
        public const string deleteItemName2 = "submit.delete.CZ9EUMM6RT520";
        public const string deleteItemName3 = "submit.delete.C36VDZ2SKTOSV1";
        public const string checkoutId = "hlb-ptc-btn-native";

        [FindsBy(How = How.Id, Using = "nav-link-accountList")]
        public IWebElement signIn { get; set; }

        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement email { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement pass { get; set; }

        [FindsBy(How = How.Id, Using = "signInSubmit")]
        public IWebElement btnSignIn { get; set; }

        [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
        public IWebElement searchBar { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Laptop Backpack, Sosoon Business Anti-Theft")]
        public IWebElement item { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "HZ BIGTREE iPhone 7 Case")]
        public IWebElement item2 { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "NaNTECK 13 Inch Laptop Bag Case Cover")]
        public IWebElement item3 { get; set; }

        [FindsBy(How = How.Id, Using = "add-to-cart-button")]
        public IWebElement btnAddToCart { get; set; }

        [FindsBy(How = How.Id, Using = AmazonBuyItem.checkoutId)]
        public IWebElement btnCheckOut { get; set; }

        //Shipping Address

        [FindsBy(How = How.PartialLinkText, Using = "Delete")]
        public IWebElement deleteAddr { get; set; }

        [FindsBy(How = How.Name, Using = "enterAddressFullName")]
        public IWebElement fullName { get; set; }

        [FindsBy(How = How.Name, Using = "enterAddressAddressLine1")]
        public IWebElement addressLine { get; set; }

        [FindsBy(How = How.Name, Using = "enterAddressAddressLine2")]
        public IWebElement addressLine2 { get; set; }

        [FindsBy(How = How.Name, Using = "enterAddressCity")]
        public IWebElement city { get; set; }

        [FindsBy(How = How.Name, Using = "enterAddressStateOrRegion")]
        public IWebElement state { get; set; }

        [FindsBy(How = How.Name, Using = "enterAddressPostalCode")]
        public IWebElement zip { get; set; }

        [FindsBy(How = How.Name, Using = "enterAddressCountryCode")]
        public IWebElement country { get; set; }

        [FindsBy(How = How.Name, Using = "enterAddressPhoneNumber")]
        public IWebElement phone { get; set; }

        [FindsBy(How = How.Name, Using = "shipToThisAddress")]
        public IWebElement btnContinue { get; set; }

        //Empty Cart
        [FindsBy(How = How.Id, Using = "nav-cart")]
        public IWebElement cart { get; set; }

        [FindsBy(How = How.Name, Using = AmazonBuyItem.deleteItemName1)]
        public IWebElement deleteItem { get; set; }

        [FindsBy(How = How.Name, Using = AmazonBuyItem.deleteItemName2)]
        public IWebElement deleteItem2 { get; set; }

        [FindsBy(How = How.Name, Using = AmazonBuyItem.deleteItemName3)]
        public IWebElement deleteItem3 { get; set; }   
        
        
    }
}
