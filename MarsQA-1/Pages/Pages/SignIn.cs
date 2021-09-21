using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System.Threading;

namespace MarsQA_1.Pages.Pages
{
    public static class SignIn
    {
        private static IWebElement SignInBtn =>  Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']"));
        private static IWebElement Email => Driver.driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]"));
        private static IWebElement Password => Driver.driver.FindElement(By.XPath("//INPUT[@type='password']"));
        private static IWebElement LoginBtn => Driver.driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']"));
        private static IWebElement JoinButton => Driver.driver.FindElement(By.XPath("//button[@class='ui green basic button']"));

        private static IWebElement FormFirstName => Driver.driver.FindElement(By.XPath("//input[@name='firstName']"));
        private static IWebElement FormLastName => Driver.driver.FindElement(By.XPath("//input[@name='lastName']"));
        private static IWebElement FormEmail => Driver.driver.FindElement(By.XPath("//input[@name='email']"));
        private static IWebElement FormPassword => Driver.driver.FindElement(By.XPath("//input[@name='password']"));
        private static IWebElement FormConfirmPassword => Driver.driver.FindElement(By.XPath("//input[@name='confirmPassword']"));
        private static IWebElement FormCheckBox => Driver.driver.FindElement(By.XPath("//input[@name='terms']"));
        private static IWebElement FormJoinButton => Driver.driver.FindElement(By.XPath("//div[@id='submit-btn']"));

        private static IWebElement PopupMessage => Driver.driver.FindElement(By.XPath("/html/body/div/div[@class='ns-box-inner']"));

        // Login step used for the rest of the test scenarios
        public static void SigninSteps()
        {
            // Get credentials data from excel file
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Credentials");
            
            SignInBtn.Click();
            
            Email.SendKeys(ExcelLibHelper.ReadData(2,"username"));
            
            Password.SendKeys(ExcelLibHelper.ReadData(2, "password"));
            
            LoginBtn.Click();
        }

        public static void ClickSignIn()
        {
            SignInBtn.Click();
        }

        // Login step used only for Scenario: SignIn 
        public static void Login(string username, string password)
        {
            Email.SendKeys(username);
            Password.SendKeys(password);
            LoginBtn.Click();
        }

        public static void ClickTopRightJoinButton()
        {
            JoinButton.Click();
        }

        public static void RegistrationFormInputs(string firstname, string lastname, string email, string password, string confirmpassword)
        {
            FormFirstName.SendKeys(firstname);
            FormLastName.SendKeys(lastname);
            FormEmail.SendKeys(email);
            FormPassword.SendKeys(password);
            FormConfirmPassword.SendKeys(confirmpassword);
        }

        public static void ClickCheckbox()
        {
            FormCheckBox.Click();
        }

        public static void ClickFormJoinButton()
        {
            FormJoinButton.Click();
        }

        public static string GetPopupMessage()
        {
            // Wait a bit for registration process to complete
            Thread.Sleep(2000); 
            
            return PopupMessage.Text;   
        }
    }
}