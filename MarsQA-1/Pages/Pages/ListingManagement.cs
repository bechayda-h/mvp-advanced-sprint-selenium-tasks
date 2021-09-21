using MarsQA_1.Helpers;
using OpenQA.Selenium;

namespace MarsQA_1.Pages.Pages
{
    class ListingManagement
    {
        // Blue popup message
        private static IWebElement PopupMessage => Driver.driver.FindElement(By.XPath("/html/body/div/div[@class='ns-box-inner']"));

        // Manage Listings' first row elements
        private static IWebElement CategoryRow1 => Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[2]"));
        private static IWebElement TitleRow1 => Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[3]"));
        private static IWebElement DescriptionRow1 => Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[4]"));
        private static IWebElement ServiceTypeRow1 => Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[5]"));
        private static IWebElement RemoveIconRow1 => Driver.driver.FindElement(By.XPath("(//i[@class='remove icon'])[1]"));
        private static IWebElement WriteIconRow1 => Driver.driver.FindElement(By.XPath("(//i[@class='outline write icon'])[1]"));

        // Yes button when asked to delete your service
        private static IWebElement PageModalYesButton => Driver.driver.FindElement(By.XPath("//button[@class='ui icon positive right labeled button']"));

        public static void ClickWriteIconRow1()
        {
            WriteIconRow1.Click();
        }

        public static string GetCategoryRow1()
        {
            return CategoryRow1.Text;
        }

        public static string GetTitleRow1()
        { 
            return TitleRow1.Text; 
        }

        public static string GetDescriptionRow1()
        {
            return DescriptionRow1.Text;
        }

        public static string GetServiceTypeRow1()
        {
            return ServiceTypeRow1.Text;
        }

        public static void ClickRemoveIconRow1()
        {
            RemoveIconRow1.Click();
        }

        public static void ClickPageModalYesButton() 
        {
            PageModalYesButton.Click();
        }

        public static string GetPopupMessage()
        {
            return PopupMessage.Text;
        }
    }
}
