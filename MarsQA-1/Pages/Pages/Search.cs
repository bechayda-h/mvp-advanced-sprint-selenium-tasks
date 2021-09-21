using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;

namespace MarsQA_1.Pages.Pages
{
    class Search
    {
        private static IWebElement AllCategoriesCount => Driver.driver.FindElement(By.XPath("//a[@role='listitem'][1]/span"));

        private static IWebElement ActiveCategory => Driver.driver.FindElement(By.XPath($"//a[@class='active item category']/b"));
        private static IWebElement ActiveSubcategory => Driver.driver.FindElement(By.XPath($"//a[@class='active item subcategory']/b"));

        // Filter
        private static IWebElement FilterOnline => Driver.driver.FindElement(By.XPath("//button[text()='Online']"));
        private static IWebElement FilterOnsite => Driver.driver.FindElement(By.XPath("//button[text()='Onsite']"));
        private static IWebElement FilterShowAll => Driver.driver.FindElement(By.XPath("//button[text()='ShowAll']"));

        public static void ClickFilterOnline()
        {
            FilterOnline.Click();
        }

        public static void ClickFilterOnsite()
        {
            FilterOnsite.Click();
        }

        public static void ClickFilterShowAll()
        {
            FilterShowAll.Click();
        }

        public static int GetAllCategoriesCount()
        {
            // Convert numeric text to int then return the int value
            return Int32.Parse(AllCategoriesCount.Text);
        }

        public static void ClickCategory(string category)
        {
            Driver.driver.FindElement(By.XPath($"//a[@class='item category'][text()='{category}']")).Click();
        }

        public static string GetActiveCategory()
        {
            return ActiveCategory.Text;
        }

        public static void ClickSubCategory(string subcategory)
        {
            Driver.driver.FindElement(By.XPath($"//a[@class='item subcategory'][text()='{subcategory}']")).Click();
        }

        public static string GetActiveSubCategory()
        {
            return ActiveSubcategory.Text;
        }
    }
}
