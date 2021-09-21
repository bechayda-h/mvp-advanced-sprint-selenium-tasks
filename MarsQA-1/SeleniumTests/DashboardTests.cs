using MarsQA_1.Helpers;
using MarsQA_1.Pages.Pages;
using NUnit.Framework;
using System.Threading;

namespace MarsQA_1.SeleniumTests
{
    [TestFixture]
    class DashboardTests : Utils.Start
    {
        [Test]
        public void TC_016_01_ShowLess()
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click Dashboard
            Profile.ClickDashboard();

            // Click Load More...
            Dashboard.ClickLoadMoreButton();

            // Count notification before Show Less
            int notificationCountBefore = Dashboard.GetNotificationsCount();

            // Click ...Show Less
            Dashboard.ClickShowLessButton();
            
            // Count notification after Show Less
            int notificationCountAfter = Dashboard.GetNotificationsCount();

            // Log test result
            CommonMethods.LogResult(notificationCountAfter < notificationCountBefore, "Load More Passed", "Load More Failed");

            // Assert
            Assert.Less(notificationCountAfter, notificationCountBefore);
        }

        [Test]
        public void TC_017_01_LoadMore()
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click Dashboard
            Profile.ClickDashboard();

            // Count notification before Load More
            int notificationCountBefore = Dashboard.GetNotificationsCount();

            // Click Load More...
            Dashboard.ClickLoadMoreButton();

            // Count notification after Load More
            int notificationCountAfter = Dashboard.GetNotificationsCount();

            // Log test result
            CommonMethods.LogResult(notificationCountAfter > notificationCountBefore, "Load More Passed", "Load More Failed");

            // Assert
            Assert.Greater(notificationCountAfter, notificationCountBefore);
        }

        [Test]
        public void TC_018_01_DeleteSelection()
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click Dashboard
            Profile.ClickDashboard();

            // Get notification date
            string notificationDateBefore = Dashboard.GetNotificationDate1();

            // Click a checkbox
            Dashboard.ClickCheckbox1();

            // Click Delete selection
            Dashboard.ClickDeleteSelection();

            // Wait a bit
            Thread.Sleep(1000);

            // Get popup message
            string popupMessage = Dashboard.GetPopupMessage();

            // Get notification date
            string notificationDateAfter = Dashboard.GetNotificationDate1();

            // Log test results
            bool passCondition = notificationDateBefore != notificationDateAfter &&
                                 "Notification updated" == popupMessage;
            CommonMethods.LogResult(passCondition, "Delete selection Passed", "Delete selection Failed");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.AreNotEqual(notificationDateBefore, notificationDateAfter);
                Assert.AreEqual("Notification updated", popupMessage);
            });
        }

        [Test]
        public void TC_019_01_MarkSelectionAsRead()
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click Dashboard
            Profile.ClickDashboard();

            // Click Select all
            Dashboard.ClickSelectAll();

            // Click Mark selection as read
            Dashboard.ClickMarkSelectionAsRead();

            // Get popup message
            string popupMessage = Dashboard.GetPopupMessage();

            // Log the test result
            CommonMethods.LogResult("Notification updated" == popupMessage, "Mark selection as read Passed", "Mark selection as read Failed");

            // Assert
            Assert.AreEqual("Notification updated", popupMessage);
        }

        [Test]
        public void TC_020_01_SelectAll()
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click Dashboard
            Profile.ClickDashboard();

            // Click Select all
            Dashboard.ClickSelectAll();

            // Log the test result
            bool passCondition = Dashboard.IsCheckboxSelected(1) &&
                                 Dashboard.IsCheckboxSelected(2) &&
                                 Dashboard.IsCheckboxSelected(3) &&
                                 Dashboard.IsCheckboxSelected(4) &&
                                 Dashboard.IsCheckboxSelected(5);
            CommonMethods.LogResult(passCondition, "Select All Passed", "Select All Failed");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.True(Dashboard.IsCheckboxSelected(1));
                Assert.True(Dashboard.IsCheckboxSelected(2));
                Assert.True(Dashboard.IsCheckboxSelected(3));
                Assert.True(Dashboard.IsCheckboxSelected(4));
                Assert.True(Dashboard.IsCheckboxSelected(5));
            });
        }

        [Test]
        public void TC_020_02_UnselectAll()
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click Dashboard
            Profile.ClickDashboard();

            // Click Select all
            Dashboard.ClickSelectAll();

            // Click Unselect all
            Dashboard.ClickUnselectAll();

            // Log the test result
            bool passCondition = Dashboard.IsCheckboxSelected(1) == false &&
                                 Dashboard.IsCheckboxSelected(2) == false &&
                                 Dashboard.IsCheckboxSelected(3) == false &&
                                 Dashboard.IsCheckboxSelected(4) == false &&
                                 Dashboard.IsCheckboxSelected(5) == false;
            CommonMethods.LogResult(passCondition, "Unselect All Passed", "Unselect All Failed");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.False(Dashboard.IsCheckboxSelected(1));
                Assert.False(Dashboard.IsCheckboxSelected(2));
                Assert.False(Dashboard.IsCheckboxSelected(3));
                Assert.False(Dashboard.IsCheckboxSelected(4));
                Assert.False(Dashboard.IsCheckboxSelected(5));
            });
        }
    }
}