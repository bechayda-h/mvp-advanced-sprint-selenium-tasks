//using MarsQA_1.Helpers;
//using MarsQA_1.SpecflowPages.Pages;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using RelevantCodes.ExtentReports;
//using System;
//using System.IO;
//using System.Threading;
//using TechTalk.SpecFlow;

//namespace MarsQA_1.SpecflowTests.BindSteps
//{
//    [Binding]
//    public class DashboardSteps
//    {
//        int _initialNotificationCount;

//        [Given(@"user clicks Dashboard")]
//        public void GivenUserClicksDashboard()
//        {
//            // Go to Dashboard page
//            Profile.ClickDashboard();

//            // Wait for notifications to become visible
//            Dashboard.WaitForElementToBeVisible("//div[@class='item link'][1]", 5);
//        }

//        [When(@"user clicks Load More\.\.\. button")]
//        public void WhenUserClicksLoadMore_Button()
//        {
//            // Count the no. of notifications before clicking 'Load More...' button
//            _initialNotificationCount = Dashboard.GetNotificationsCount();

//            Dashboard.ClickLoadMoreButton();

//            // Wait for more notifications to become visible
//            Dashboard.WaitForElementToBeVisible("//div[@class='item link'][6]", 5);
//        }

//        [Then(@"more notifications will be displayed")]
//        public void ThenNotificationsWillBeDisplayed()
//        {
//            // Log test result
//            CommonMethods.LogResult(Dashboard.GetNotificationsCount() > _initialNotificationCount, "Notification Load More Passed", "Notification Load More Failed");

//            // Assert that more notifications are displayed
//            Assert.That(Dashboard.GetNotificationsCount() > _initialNotificationCount);
//        }

//        [Given(@"user clicks Load More\.\.\. button")]
//        public void GivenUserClicksLoadMore_Button()
//        {
//            Dashboard.ClickLoadMoreButton();

//            // Wait for more notifications to become visible
//            Dashboard.WaitForElementToBeVisible("//div[@class='item link'][6]", 5);
//        }

//        [When(@"user clicks \.\.\.Show Less button")]
//        public void WhenUserClicks_ShowLessButton()
//        {
//            // Count the no. of notifications before clicking '...Show Less' button
//            _initialNotificationCount = Dashboard.GetNotificationsCount();

//            Dashboard.ClickShowLessButton();

//            // Wait for notifications to show less
//            Dashboard.WaitForElementToBeNotVisible("//div[@class='item link'][6]", 5);
//        }

//        [Then(@"less notifications will be displayed")]
//        public void ThenLessNotificationsWillBeDisplayed()
//        {
//            // Log test result
//            CommonMethods.LogResult(Dashboard.GetNotificationsCount() < _initialNotificationCount, "Notification Show Less Passed", "Notification Show Less Failed");

//            //assert that less notifications are displayed
//            Assert.That(Dashboard.GetNotificationsCount() < _initialNotificationCount);

//        }

//        [Given(@"user clicks Select All")]
//        public void GivenUserClicksSelectAll()
//        {
//            Dashboard.ClickSelectAll();
//        }

//        [When(@"user clicks Select All")]
//        public void WhenUserClicksSelectAll()
//        {
//            Dashboard.ClickSelectAll();
//        }

//        [Then(@"notification items will be selected")]
//        public void ThenNotificationItemsWillBeSelected()
//        {
//            Dashboard.AssertThatNotificationItemsAreSelected();
//        }

//        [When(@"user clicks Unselect All")]
//        public void WhenUserClicksUnselectAll()
//        {
//            Dashboard.ClickUnselectAll();
//        }

//        [Then(@"notification items will be unselected")]
//        public void ThenNotificationItemsWillBeUnselected()
//        {
//            Dashboard.AssertThatNotificationItemsAreUnselected();
//        }

//        [Given(@"user clicks a checkbox")]
//        public void GivenUserClicksACheckbox()
//        {
//            Dashboard.ClickACheckbox();
//        }

//        [When(@"user clicks Mark selection as read")]
//        public void WhenUserClicksMarkSelectionAsRead()
//        {
//            Dashboard.ClickMarkSelectionAsRead();
//        }

//        [When(@"user clicks Delete selection")]
//        public void WhenUserClicksDeleteSelection()
//        {
//            Dashboard.ClickDeleteSelection();
//        }
//    }
//}
