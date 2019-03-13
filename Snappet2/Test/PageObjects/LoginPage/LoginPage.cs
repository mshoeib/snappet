using Test.PageObjects.LoginPage;
using Test.BaseFramework;
using System.Threading;
using Test.Utilities;
using OpenQA.Selenium;

namespace Test.PageObjects.LoginPage
{
    public class LoginPage : BasePage<Test.PageObjects.LoginPage.LoginPageElementMap, LoginPageValidator>
    {
    
        public void Login(string userName, string password)
        {
            Driver.ImplicitWait();
            Map.UsernameTxtBx.SendKeys(userName);
            Map.PasswordTxtBx.SendKeys(password);
            Map.Loginbtn.SendKeys(Keys.Tab);
            Map.Loginbtn.Click();
        }

        public string GetLoginErrorText()
        {
            return Map.ErrorMsg.Text;
        }

        public string GetError()
        {
            Helpers.Wait_Till_Visibility_of_Element(By.CssSelector(Map.ErrorMsgCssSelector),3);
            var text = Map.TestErrorTooltip.Text ;
            return text;
        }


        public string GetWelcomeMessageText()
        {
           return Map.WelcomeMessage.Text;
       }
     
    }

}
