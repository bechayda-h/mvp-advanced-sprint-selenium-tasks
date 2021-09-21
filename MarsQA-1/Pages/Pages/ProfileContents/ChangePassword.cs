using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace MarsQA_1.Pages.Pages.ProfileContents
{
    class ChangePassword
    {
        // Compact menu
        private static IWebElement HiUserDropdownLink => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));
        private static IWebElement ChangePasswordItem => Driver.driver.FindElement(By.XPath("//a[text()='Change Password']"));
        
        // Page modal elements
        private static IWebElement OldPassword => Driver.driver.FindElement(By.Name("oldPassword"));
        private static IWebElement NewPassword => Driver.driver.FindElement(By.Name("newPassword"));
        private static IWebElement ConfirmPassword => Driver.driver.FindElement(By.Name("confirmPassword"));
        private static IWebElement SaveButton => Driver.driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[4]/button"));

        // Used for invoking mouse hover action
        private static readonly Actions Action = new Actions(Driver.driver);

        public static void ClickChangePassword()
        {
            Action.MoveToElement(HiUserDropdownLink).Perform();
            ChangePasswordItem.Click();
        }

        public static void InputOldAndNewPassword(string oldpassword, string newpassword)
        {
            OldPassword.SendKeys(oldpassword);
            NewPassword.SendKeys(newpassword);
            ConfirmPassword.SendKeys(newpassword);
        }

        public static void ClickSaveButton()
        {
            SaveButton.Click();
        }
    }
}
