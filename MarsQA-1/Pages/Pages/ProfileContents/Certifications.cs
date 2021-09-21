using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System.Linq;

namespace MarsQA_1.Pages.Pages.ProfileContents
{
    class Certifications
    {
        // Certifications tab add new entry input fields
        private static IWebElement AddNewButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
        private static IWebElement NewCertificate => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
        private static IWebElement NewFrom => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
        private static IWebElement NewYear => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
        private static IWebElement AddButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));

        // Certifications list first row fields                                       
        private static IWebElement Certificate => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
        private static IWebElement From => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[2]"));
        private static IWebElement Year => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[3]"));
        private static IWebElement WriteIcon => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i"));
        private static IWebElement RemoveIcon => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i"));

        // Certifications edit entry fields
        private static IWebElement EditCertificate => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[1]/input"));
        private static IWebElement EditFrom => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[2]/input"));
        private static IWebElement EditYear => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[3]/select"));
        private static IWebElement UpdateButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]"));

        public static void ClickAddNewButton()
        {
            AddNewButton.Click();
        }

        public static void InputNewCertificate(string name)
        {
            NewCertificate.SendKeys(name);
        }

        public static void InputNewFrom(string name)
        {
            NewFrom.SendKeys(name);
        }

        public static void SelectNewYear(string option)
        {
            NewYear.FindElement(By.XPath($"//option[. = '{option}']")).Click();
        }

        public static void ClickAddButton()
        {
            AddButton.Click();
        }

        public static string GetCertificate()
        {
            return Certificate.Text;
        }

        public static string GetFrom()
        {
            return From.Text;
        }

        public static string GetYear()
        {
            return Year.Text;
        }

        public static void ClickWriteIcon()
        {
            WriteIcon.Click();
        }

        public static void UpdateCertificate(string name)
        {
            // Delete the current name then enter a new name
            EditCertificate.Clear();
            EditCertificate.SendKeys(name);
        }

        public static void UpdateFrom(string name)
        {
            // Delete the current name then enter a new name
            EditFrom.Clear();
            EditFrom.SendKeys(name);
        }

        public static void UpdateYear(string option)
        {
            EditYear.FindElement(By.XPath($"//option[. = '{option}']")).Click();
        }

        public static void ClickUpdateButton()
        {
            UpdateButton.Click();
        }

        public static void ClickRemoveIcon()
        {
            RemoveIcon.Click();
        }

        public static bool IsEntryDeleted()
        {
            // Check if the entry is deleted
            int counter = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]")).Count();
            return (counter == 0);
        }
    }
}
