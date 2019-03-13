using Test.BaseFramework;
using Test.PageObjects.LoginPage;
using Test.Utilities;
using NUnit.Framework;

namespace Test.Tests
{
    [TestFixture]
    public class LoginTests:BaseTest
    {
        [Test]
        public void InvalidLoginWithEmptyUsername()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();
            loginPage.Login("", "*7jdfD%^st0");
            loginPage.Validate().FailureUserLogin();
          

        }


        [Test]
        public void ValidLogin()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();
       
            loginPage.Login("ChallengeTeacher1", "*7jdfD%^st0");
            loginPage.Validate().CheckUserloggedIn();
            loginPage.Validate().LoggedInUsername();
        }

        [Test]
        public void LoginWithInvalidUsernameAndPassword()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            loginPage.Login("Test", "test");
            var ErrorMessage= loginPage.GetError();
            Assert.AreEqual("This account has been locked out", ErrorMessage, "Invalid Error Message");
            loginPage.Validate().FailureUserLogin();
        }


        [Test]
        public void InvalidLoginWithEmptyUsernameAndValidPassword()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();
            loginPage.Login("", "*7jdfD%^st0");
            loginPage.Validate().FailureUserLogin();

        }
        [Test]
        public void InvalidLoginWithValidUsernameAndEmptyPassword()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();
            loginPage.Login("ChallengeTeacher1", "");
            loginPage.Validate().FailureUserLogin();

        }

    }
}
