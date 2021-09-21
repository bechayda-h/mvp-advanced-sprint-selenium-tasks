using MarsQA_1.Helpers;
using OpenQA.Selenium;

namespace MarsQA_1.Pages.Pages
{
    class ServiceListing
    {
        private static IWebElement Title => Driver.driver.FindElement(By.Name("title"));
        private static IWebElement Description => Driver.driver.FindElement(By.Name("description"));
        private static IWebElement CategoryDropDown => Driver.driver.FindElement(By.Name("categoryId"));
        private static IWebElement SubCategoryDropDown => Driver.driver.FindElement(By.Name("subcategoryId"));
        private static IWebElement Tags => Driver.driver.FindElement(By.XPath("//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]"));
        private static IWebElement ServiceTypeOptions => Driver.driver.FindElement(By.XPath("//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']"));
        private static IWebElement SkillExchange => Driver.driver.FindElement(By.XPath("//div[@class='form-wrapper']//input[@placeholder='Add new tag']"));
        private static IWebElement SaveButton => Driver.driver.FindElement(By.XPath("//input[@value='Save']"));
        
        public static void InputTitle(string title) 
        {
            Title.Clear();
            Title.SendKeys(title);
        }

        public static void InputDescription(string description)
        {
            Description.Clear();
            Description.SendKeys(description);
        }

        public static void SelectCategory(string option)
        {
            CategoryDropDown.FindElement(By.XPath($"//option[. = '{option}']")).Click();
        }

        public static void SelectSubCategory(string option)
        {
            SubCategoryDropDown.FindElement(By.XPath($"//option[. = '{option}']")).Click();
        }

        public static void EnterTag(string tag)
        {
            Tags.Click();
            Tags.SendKeys(tag);
            Tags.SendKeys(Keys.Enter);
        }

        public static void SelectServiceType(string serviceType)
        {
            string st = (serviceType != "Hourly") ? "1" : "0";
            ServiceTypeOptions.FindElement(By.XPath($"//input[@value='{st}']")).Click();
        }

        public static void EnterSkillExchangeTag(string tag)
        {
            SkillExchange.Click();
            SkillExchange.SendKeys(tag);
            SkillExchange.SendKeys(Keys.Enter);
        }

        public static void ClickSaveButton()
        {
            SaveButton.Click();
        }
    }
}
