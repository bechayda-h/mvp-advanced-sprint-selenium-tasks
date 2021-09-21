using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace MarsQA_1.Pages.Pages
{
    class Dashboard
    {
        private static IWebElement PopupMessage => Driver.driver.FindElement(By.XPath("/html/body/div/div[@class='ns-box-inner']"));

        private static IWebElement LoadMoreButton => Driver.driver.FindElement(By.LinkText("Load More..."));
        
        private static IWebElement ShowLessButton => Driver.driver.FindElement(By.LinkText("...Show Less"));

        private static IWebElement SelectAll => Driver.driver.FindElement(By.XPath("//div[@data-tooltip='Select all']"));
        
        private static IWebElement UnselectAll => Driver.driver.FindElement(By.XPath("//div[@data-tooltip='Unselect all']"));
        
        private static IWebElement MarkAsRead => Driver.driver.FindElement(By.XPath("//div[@data-tooltip='Mark selection as read']"));
        
        private static IWebElement Delete => Driver.driver.FindElement(By.XPath("//div[@data-tooltip='Delete selection']"));

        // First row notification elements
        private static IWebElement Checkbox1 => Driver.driver.FindElement(By.XPath("//div[1]/div/div/div[3]/input"));
        private static IWebElement NotificationDate1 => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[2]/div[1]/a/div[2]/div"));

        public static void ClickLoadMoreButton()
        {
            LoadMoreButton.Click();

            // Wait for the 6th notification to become visible
            CommonMethods.WaitForElementToBeVisible("//div[@class='item link'][6]", 5);
        }

        public static int GetNotificationsCount()
        {
            // Count the number of notifications
            return Driver.driver.FindElements(By.XPath("//div[@class='item link']")).Count;
        }

        public static void ClickShowLessButton()
        {
            // Script to scroll down until '...Show Less' button is visible
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", ShowLessButton);
            
            ShowLessButton.Click();

            // Wait for the 6th notification to become not visible
            CommonMethods.WaitForElementToBeNotVisible("//div[@class='item link'][6]", 5);
        }
        
        public static void ClickSelectAll()
        {
            //Wait for the 1st notification to become visible
            CommonMethods.WaitForElementToBeVisible("//div[@class='item link'][1]", 5);

            SelectAll.Click();
        }

        public static void ClickUnselectAll()
        {
            UnselectAll.Click();
        }

        public static bool IsCheckboxSelected(int checkboxNumber)
        {
            return Driver.driver.FindElement(By.XPath($"//div[{checkboxNumber}]/div/div/div[3]/input")).Selected;
        }
        
        public static void ClickCheckbox1()
        {
            Checkbox1.Click();
        }

        public static void ClickMarkSelectionAsRead()
        {
            MarkAsRead.Click();
        }

        public static void ClickDeleteSelection()
        {
            Delete.Click();
        }

        public static string GetNotificationDate1()
        {
            //Wait for the 1st notification to become visible
            CommonMethods.WaitForElementToBeVisible("//div[@class='item link'][1]", 5);

            return NotificationDate1.Text;
        }

        public static string GetPopupMessage()
        {
            return PopupMessage.Text;
        }
    }
}
