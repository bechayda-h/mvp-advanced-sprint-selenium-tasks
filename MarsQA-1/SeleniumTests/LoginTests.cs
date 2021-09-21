using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.Pages.Pages;
using NUnit.Framework;
using System.Threading;

namespace MarsQA_1.SeleniumTests
{
    [TestFixture]
    class LoginTests : Utils.Start
    {
        [TestCase("Aldwin", "Bechayda", "email15@somedomain.com", "password1", "password1", "Registration successful")]
        public void TC_001_01_RegisterANewAccount(string firstname, string lastname, string email, string password, string confirmpassword, string message)
        {
            // Click Join
            SignIn.ClickTopRightJoinButton();

            // Input user name, email, password
            SignIn.RegistrationFormInputs(firstname, lastname, email, password, confirmpassword);

            // Check to agree to the terms and conditions
            SignIn.ClickCheckbox();

            // Click Join button
            SignIn.ClickFormJoinButton();

            // Log test result
            CommonMethods.LogResult(message == SignIn.GetPopupMessage(), "Passed", "Failed");

            // Assert
            StringAssert.IsMatch(message, SignIn.GetPopupMessage());
        }

        [TestCase("bechayda_h@yahoo.com", "password", "Aldwin Bechayda")]
        public void TC_001_02_Login(string username, string password, string name)
        {
            // Click Sign in
            SignIn.ClickSignIn();

            // Login with username and password
            SignIn.Login(username, password);
            
            // Wait a bit for the login process to complete
            Thread.Sleep(4000);

            // Log test result
            bool passCondition = "Profile" == Driver.driver.Title && name == Profile.GetUserName();
            CommonMethods.LogResult(passCondition, "SignIn Passed", "SignIn Failed");

            // Assert
            Assert.Multiple(() =>
            {
                StringAssert.IsMatch("Profile", Driver.driver.Title);
                StringAssert.IsMatch(name, Profile.GetUserName());
            });
        }
    }
}
