using MarsQA_1.Helpers;
using OpenQA.Selenium;

namespace MarsQA_1.Pages.Pages
{
    class ServiceDetail
    {
        private static IWebElement Name => Driver.driver.FindElement(By.XPath("//*[@id='service-detail-section']/div[2]/div/div[2]/div[2]/div[1]/div/div[1]/a/h3"));
        private static IWebElement Title => Driver.driver.FindElement(By.XPath("//*[@id='service-detail-section']/div[2]/div/div[2]/div[1]/div[1]/div[2]/h1/span"));

        public static string GetName()
        {
            return Name.Text;
        }

        public static string GetTitle()
        {
            return Title.Text;
        }
    }
}
