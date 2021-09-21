using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System.Linq;

namespace MarsQA_1.Pages.Pages.ProfileContents
{
    public class Skills
    {
        // Skills tab add new entry input fields
        private static IWebElement AddNewButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private static IWebElement NewName => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
        private static IWebElement NewLevel => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
        private static IWebElement AddButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));

        // Skill list first row fields
        private static IWebElement Name => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
        private static IWebElement Level => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));
        private static IWebElement WriteIcon => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
        private static IWebElement RemoveIcon => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));

        // Skill edit entry fields
        private static IWebElement EditName => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
        private static IWebElement EditLevel => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
        private static IWebElement UpdateButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));

        public static void ClickAddNewButton()
        {
            AddNewButton.Click();
        }

        public static void InputNewName(string name)
        {
            NewName.SendKeys(name);
        }

        public static void SelectNewLevel(string option)
        {
            NewLevel.FindElement(By.XPath($"//option[. = '{option}']")).Click();
        }

        public static void ClickAddButton()
        {
            AddButton.Click();
        }
        
        public static string GetName()
        {
            return Name.Text;
        }
       
        public static string GetLevel()
        {
            return Level.Text;
        }

        public static void ClickWriteIcon()
        {
            WriteIcon.Click();
        }

        public static void UpdateName(string name)
        {
            // Delete the current name then enter a new name
            EditName.Clear();
            EditName.SendKeys(name);
        }

        public static void UpdateLevel(string option)
        {
            EditLevel.FindElement(By.XPath($"//option[. = '{option}']")).Click();
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
            int counter = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]")).Count();
            return (counter == 0);
        }
    }
}
