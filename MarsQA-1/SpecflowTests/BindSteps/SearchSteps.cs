//using MarsQA_1.Helpers;
//using MarsQA_1.SpecflowPages.Pages;
//using NUnit.Framework;
//using System;
//using System.Threading;
//using TechTalk.SpecFlow;

//namespace MarsQA_1.SpecflowTests.BindSteps
//{
//    [Binding]
//    public class SearchSteps
//    {
//        int AllCategoriesCount;

//        private readonly ScenarioContext _scenarioContext;

//        public SearchSteps(ScenarioContext scenariocontext)
//        {
//            // Using Context Injection for ScenarioContext 
//            // References:
//            // https://docs.specflow.org/projects/specflow/en/latest/Bindings/ScenarioContext.html
//            // https://docs.specflow.org/projects/specflow/en/latest/Bindings/Context-Injection.html
//            _scenarioContext = scenariocontext;
//        }

//        [Given(@"user clicks the search icon")]
//        public void GivenUserClicksTheSearchIcon()
//        {
//            Profile.ClickSearchLinkIcon();
            
//            // Wait a bit for skill cards to load
//            Thread.Sleep(2000);
//        }
        
//        [When(@"user clicks the Online filter")]
//        public void WhenUserClicksTheOnlineFilter()
//        {
//            // Get item count before filter(default is Show all count)
//            AllCategoriesCount = Search.GetAllCategoriesCount();

//            Search.ClickFilterOnline();

//            // Wait a bit for skill cards to load
//            Thread.Sleep(2000);
//        }

//        [Then(@"the total item count of All Categories will be updated")]
//        public void ThenTheTotalItemCountOfAllCategoriesWillBeUpdated()
//        {
//            // Log test result
//            CommonMethods.LogResult(AllCategoriesCount != Search.GetAllCategoriesCount(), 
//                                    $"{_scenarioContext.ScenarioInfo.Title} Passed", 
//                                    $"{_scenarioContext.ScenarioInfo.Title} Failed");

//            // Assert that the item count will be different compared to previous
//            Assert.True(AllCategoriesCount != Search.GetAllCategoriesCount());
//        }

//        [When(@"user clicks the Onsite filter")]
//        public void WhenUserClicksTheOnsiteFilter()
//        {
//            // Get item count before filter(default is Show all count)
//            AllCategoriesCount = Search.GetAllCategoriesCount();

//            Search.ClickFilterOnsite();

//            // Wait a bit for skill cards to load
//            Thread.Sleep(2000); 
//        }

//        [Given(@"user clicks the Onsite filter")]
//        public void GivenUserClicksTheOnsiteFilter()
//        {
//            // Get item count before filter(default is Show all count)
//            AllCategoriesCount = Search.GetAllCategoriesCount();

//            Search.ClickFilterOnsite();
            
//            // Wait a bit for skill cards to load
//            Thread.Sleep(2000); 
//        }

//        [When(@"user clicks the ShowAll filter")]
//        public void WhenUserClicksTheShowAllFilter()
//        {
//            Search.ClickFilterShowAll();
//        }

//        [When(@"user clicks '(.*)' category")]
//        public void WhenUserClicksCategory(string category)
//        {
//            Search.ClickCategory(category);
//        }

//        [Then(@"'(.*)' will become the active category")]
//        public void ThenWillBecomeTheActiveCategory(string category)
//        {
//            Search.AssertActiveCategory(category);
//        }

//        [Given(@"user clicks '(.*)' category")]
//        public void GivenUserClicks(string category)
//        {
//            Search.ClickCategory(category);
//        }

//        [When(@"user clicks '(.*)' subcategory")]
//        public void WhenUserClicksSubcatgory(string subcategory)
//        {
//            Search.ClickSubCategory(subcategory);
//        }

//        [Then(@"'(.*)' will become the active subcategory")]
//        public void ThenWillBecomeTheActiveSubcategory(string subcategory)
//        { 
//            Search.AssertActiveSubategory(subcategory);
//        }

//    }
//}
