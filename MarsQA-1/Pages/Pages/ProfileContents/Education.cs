using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System.Linq;

namespace MarsQA_1.Pages.Pages.ProfileContents
{
    class Education
    {
        // Education tab add new entry input fields
        private static IWebElement AddNewButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
        private static IWebElement NewUniversity => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
        private static IWebElement NewCountry => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
        private static IWebElement NewTitle => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
        private static IWebElement NewDegree => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
        private static IWebElement NewYear => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
        private static IWebElement AddButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));

        // Education list first row fields   
        private static IWebElement Country => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]"));
        private static IWebElement University => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
        private static IWebElement Title => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[3]"));
        private static IWebElement Degree => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]"));
        private static IWebElement Year => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[5]"));
        private static IWebElement WriteIcon => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i"));
        private static IWebElement RemoveIcon => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i"));

        // Education edit entry fields
        private static IWebElement EditUniversity => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input"));
        private static IWebElement EditCountry => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[2]/select"));
        private static IWebElement EditTitle => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[1]/select"));
        private static IWebElement EditDegree => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[2]/input"));
        private static IWebElement EditYear => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[3]/select"));
        private static IWebElement UpdateButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]"));

        public static void ClickAddNewButton()
        {
            AddNewButton.Click();
        }

        public static void InputNewUniversity(string name)
        {
            NewUniversity.SendKeys(name);
        }

        public static void SelectNewCountry(string option)
        {
            NewCountry.FindElement(By.XPath($"//option[. = '{option}']")).Click();
        }

        public static void SelectNewTitle(string option)
        {
            NewTitle.FindElement(By.XPath($"//option[. = '{option}']")).Click();
        }

        public static void InputNewDegree(string name)
        {
            NewDegree.SendKeys(name);
        }

        public static void SelectNewYear(string option)
        {
            NewYear.FindElement(By.XPath($"//option[. = '{option}']")).Click();
        }

        public static void ClickAddButton()
        {
            AddButton.Click();
        }

        public static string GetCountry()
        {
            return Country.Text;
        }

        public static string GetUniversity()
        {
            return University.Text;
        }

        public static string GetTitle()
        {
            return Title.Text;
        }

        public static string GetDegree()
        {
            return Degree.Text;
        }

        public static string GetYear()
        {
            return Year.Text;
        }

        public static void ClickWriteIcon()
        {
            WriteIcon.Click();
        }

        public static void UpdateUniversity(string name)
        {
            // Delete the current name then enter a new name
            EditUniversity.Clear();
            EditUniversity.SendKeys(name);
        }

        public static void UpdateCountry(string option)
        {
            EditCountry.FindElement(By.XPath($"//option[. = '{option}']")).Click();
        }

        public static void UpdateTitle(string option)
        {
            EditTitle.FindElement(By.XPath($"//option[. = '{option}']")).Click();
        }

        public static void UpdateDegree(string name)
        {
            // Delete the current name then enter a new name
            EditDegree.Clear();
            EditDegree.SendKeys(name);
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
            int counter = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]")).Count();
            return (counter == 0);
        }
    }
}
