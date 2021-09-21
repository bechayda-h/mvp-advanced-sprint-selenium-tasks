using MarsQA_1.Helpers;
using OpenQA.Selenium;

namespace MarsQA_1.Pages.Pages.ProfileContents
{
    class EarnTarget
    {
        private static IWebElement Value => Driver.driver.FindElement(By.XPath("//div[4]/div[@class='right floated content']/span"));
        private static IWebElement WriteIcon => Driver.driver.FindElement(By.XPath("//div[4]/div/span/i[@class='right floated outline small write icon']"));
        private static IWebElement DropDownList => Driver.driver.FindElement(By.XPath("//div[4]/div/span/select"));

        public static void ClickWriteIcon()
        {
            WriteIcon.Click();
        }

        public static void SelectOption(string option)
        {
            DropDownList.FindElement(By.XPath($"//option[. = '{option}']")).Click();
        }

        public static string GetValue()
        {
            return Value.Text;
        }
    }
}
