using Test.BaseFramework;
using OpenQA.Selenium;

namespace Test.PageObjects.LoginPage
{
    public class LoginPageElementMap:BasePageElementMap
    {
        public IWebElement UsernameTxtBx => Browser.FindElement(By.Id("UserName"));
        public IWebElement PasswordTxtBx => Browser.FindElement(By.Id("Password"));
        public IWebElement Loginbtn => Browser.FindElement(By.XPath("//*[@id=\"content\"]/form/div[3]/button"));
        public IWebElement TestErrorTooltip => Browser.FindElement(By.CssSelector(ErrorMsgCssSelector));
        public string ErrorMsgCssSelector => "span.validationMessage:not([style=\"display: none;\"])";

        public IWebElement ErrorMsg => Browser.FindElement(By.CssSelector(ErrorMsgCssSelector));
        public IWebElement WelcomeMessage => Browser.FindElement(By.CssSelector(WelcomeMessageCssSelector));
        public string WelcomeMessageCssSelector => "header.snappet-header>div>div.heading>*";
    }
}
