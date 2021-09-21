using MarsQA_1.Helpers;
using MarsQA_1.Pages.Models;
using MarsQA_1.Pages.Pages;
using NUnit.Framework;
using System;
using System.Collections;
using System.Threading;

namespace MarsQA_1.SeleniumTests
{
    [TestFixture]
    class SearchTests : Utils.Start
    {
        [TestCaseSource("ExcelCategoryData")]
        public void TC_014_01_SetACategory(CategoryData data)
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click Search skills icon
            Profile.ClickSearchLinkIcon();

            // Click Category
            Search.ClickCategory(data.Category);

            // Get ActiveCategory
            string activeCategory = Search.GetActiveCategory();

            // Log test result
            CommonMethods.LogResult(data.Category == activeCategory, $"{data.Category} Passed", $"{data.Category} Failed");

            // Assert
            StringAssert.IsMatch(data.Category, activeCategory);
        }

        public static IEnumerable ExcelCategoryData()
        {
            // Get excel data
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Data.xlsx", "Category");
            
            // Go through each row until an empty cell is found
            int row = 2;
            while (String.IsNullOrEmpty(ExcelLibHelper.ReadData(row, "category")) == false)
            {
                CategoryData data = new CategoryData(ExcelLibHelper.ReadData(row, "category"));
                row++;
                yield return new TestCaseData(data);
            }
        }

        [TestCaseSource("ExcelSubCategoryData")]
        public void TC_014_02_SetASubCategory(SubCategoryData data)
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click Search skills icon
            Profile.ClickSearchLinkIcon();

            // Click Category
            Search.ClickCategory(data.Category);

            // Click SubCategory
            Search.ClickSubCategory(data.SubCategory);

            // Get ActiveCategory
            string activeSubCategory = Search.GetActiveSubCategory();

            // Log test result
            CommonMethods.LogResult(data.SubCategory == activeSubCategory, $"{data.SubCategory} Passed", $"{data.SubCategory} Failed");

            // Assert
            StringAssert.IsMatch(data.SubCategory, activeSubCategory);
        }

        public static IEnumerable ExcelSubCategoryData()
        {
            // Get excel data
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Data.xlsx", "Subcategory");

            // Go through each row until an empty cell is found
            int row = 2;
            while (String.IsNullOrEmpty(ExcelLibHelper.ReadData(row, "category")) == false)
            {
                SubCategoryData data = new SubCategoryData(ExcelLibHelper.ReadData(row, "category"), ExcelLibHelper.ReadData(row, "subcategory"));
                row++;
                yield return new TestCaseData(data);
            }
        }

        [Test]
        public static void TC_015_01_SetFilterAsOnline()
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click Search skills icon
            Profile.ClickSearchLinkIcon();

            // Wait a bit
            Thread.Sleep(2000);

            // Get All Categories count
            int beforeFilterAllCategoriesCount = Search.GetAllCategoriesCount();

            // Click Online
            Search.ClickFilterOnline();

            // Wait a bit
            Thread.Sleep(2000);

            // Get All Categories count
            int afterFilterAllCategoriesCount = Search.GetAllCategoriesCount();

            // Log test results
            CommonMethods.LogResult(beforeFilterAllCategoriesCount == afterFilterAllCategoriesCount, "Online filter Passed", "Online filter Failed");

            // Assert
            Assert.AreNotEqual(beforeFilterAllCategoriesCount, afterFilterAllCategoriesCount);
        }

        [Test]
        public static void TC_015_02_SetFilterAsOnsite()
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click Search skills icon
            Profile.ClickSearchLinkIcon();

            // Wait a bit
            Thread.Sleep(2000);

            // Get All Categories count
            int beforeFilterAllCategoriesCount = Search.GetAllCategoriesCount();

            // Click Onsite
            Search.ClickFilterOnsite();

            // Wait a bit
            Thread.Sleep(2000);

            // Get All Categories count
            int afterFilterAllCategoriesCount = Search.GetAllCategoriesCount();

            // Log test results
            CommonMethods.LogResult(beforeFilterAllCategoriesCount == afterFilterAllCategoriesCount, "Onsite filter Passed", "Onsite filter Failed");

            // Assert
            Assert.AreNotEqual(beforeFilterAllCategoriesCount, afterFilterAllCategoriesCount);
        }

        [Test]
        public static void TC_015_03_SetFilterAsShowAll()
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click Search skills icon
            Profile.ClickSearchLinkIcon();

            // Wait a bit
            Thread.Sleep(2000);

            // Click Onsite
            Search.ClickFilterOnsite();

            // Wait a bit
            Thread.Sleep(2000);

            // Get All Categories count
            int beforeFilterAllCategoriesCount = Search.GetAllCategoriesCount();

            // Click ShowAll
            Search.ClickFilterShowAll();

            // Wait a bit
            Thread.Sleep(2000);

            // Get All Categories count
            int afterFilterAllCategoriesCount = Search.GetAllCategoriesCount();

            // Log test results
            CommonMethods.LogResult(beforeFilterAllCategoriesCount == afterFilterAllCategoriesCount, "ShowAll filter Passed", "ShowAll filter Failed");

            // Assert
            Assert.AreNotEqual(beforeFilterAllCategoriesCount, afterFilterAllCategoriesCount);
        }
    }
}
