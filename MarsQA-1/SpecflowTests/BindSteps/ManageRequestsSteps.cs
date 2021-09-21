//using MarsQA_1.Helpers;
//using MarsQA_1.SpecflowPages.Pages;
//using NUnit.Framework;
//using System;
//using TechTalk.SpecFlow;

//namespace MarsQA_1.SpecflowTests.BindSteps
//{
//    [Binding]
//    public class ManageRequestsSteps
//    {
//        [When(@"user clicks Received Requests")]
//        public void WhenUserClicksReceivedRequests()
//        {
//            Profile.ClickReceivedRequests();
//        }

//        [When(@"user clicks Sent Requests")]
//        public void WhenUserClicksSentRequests()
//        {
//            Profile.ClickSentRequests();
//        }

//        [Then(@"user will be able to navigate to ""(.*)"" page")]
//        public void ThenUserWillBeAbleToNavigateToPage(string page)
//        {
//            // Log test result
//            CommonMethods.LogResult(page == Driver.driver.Title, 
//                                    $"Manage Request --> {page} Passed", 
//                                    $"Manage Request --> {page} Failed");

//            StringAssert.IsMatch(page, Driver.driver.Title);
//        }

//    }
//}
