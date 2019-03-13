using Test.BaseFramework;
using Test.Utilities;
using OpenQA.Selenium;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.PageObjects.LoginPage;
using System.Configuration;

namespace Test.PageObjects.LoginPage
{
    public class LoginPageValidator : BasePageValidator<LoginPageElementMap>
    {
        private readonly LoginPage _loginPage = new LoginPage();

        public void CheckUserloggedIn()
        {
          
            Driver.ImplicitWait();
            Helpers.Wait_Till_Visibility_of_Element(By.CssSelector(Map.WelcomeMessageCssSelector), 3);
            //string URL= ConfigurationManager.AppSettings["BaseURL"];

            //Assert.AreEqual(URL, Driver.Browser.Url,"Invalid Login");
            Helpers.Wait_Till_Url_Contains("/V3/131575/#period=Today", 5);
            
        }

        public void FailureUserLogin()
        {
            Driver.ImplicitWait();
            //Helpers.Wait_Till_Visibility_of_Element(By.XPath(Map.WelcomeMessageXpath), 3);
            string URL = ConfigurationManager.AppSettings["BaseURL"];
            Assert.AreEqual(URL, Driver.Browser.Url, "Invalid Login");
        }


        public void LoggedInUsername()
        {
            Driver.ImplicitWait();
            string WelcomeMessage = "ChallengeTeacher1 Teacher1Last";
            Assert.AreEqual(WelcomeMessage, _loginPage.GetWelcomeMessageText(), "Failed Login");
        }

    }
}
