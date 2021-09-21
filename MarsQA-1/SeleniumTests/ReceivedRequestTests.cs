using MarsQA_1.Helpers;
using MarsQA_1.Pages.Pages;
using NUnit.Framework;
using System.Threading;

namespace MarsQA_1.SeleniumTests
{
    [TestFixture]
    class ReceivedRequestTests : Utils.Start
    {
        [Test]
        public void TC_012_01_AcceptAReceivedRequest()
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click Received Requests
            Profile.ClickReceivedRequests();

            // Click Accept
            ReceivedRequest.ClickAcceptButtonRow1();

            // Get popup message
            string popupMessage = ReceivedRequest.GetPopupMessage();

            // Wait until popup message disappears
            Thread.Sleep(5000);

            // Get status
            string status = ReceivedRequest.GetStatusRow1();

            // Log test result
            bool passCondition = "Service has been updated" == popupMessage &&
                                 "Accepted" == status;
            CommonMethods.LogResult(passCondition, "Accept Received Request Passed", "Accept Received Request Failed");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.AreEqual("Service has been updated", popupMessage);
                Assert.AreEqual("Accepted", status);
            });
        }

        [Test]
        public void TC_012_02_DeclineAReceivedRequest()
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click Received Requests
            Profile.ClickReceivedRequests();

            // Click Decline
            ReceivedRequest.ClickDeclineButtonRow1();

            // Get popup message
            string popupMessage = ReceivedRequest.GetPopupMessage();

            // Wait a bit
            Thread.Sleep(5000);

            // Get status
            string status = ReceivedRequest.GetStatusRow1();

            // is sender rating displayed
            bool isSenderRatingDisplayed = ReceivedRequest.IsSenderRatingRow1Displayed();

            // Log test result
            bool passCondition = "Service has been updated" == popupMessage &&
                                 "Declined" == status &&
                                 isSenderRatingDisplayed ;
            CommonMethods.LogResult(passCondition, "Decline Received Request Passed", "Decline Received Request Failed");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.AreEqual("Service has been updated", popupMessage);
                Assert.AreEqual("Declined", status);
                Assert.IsTrue(isSenderRatingDisplayed);
            });
        }

        [Test]
        public void TC_012_03_CompleteAReceivedRequest()
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click Received Requests
            Profile.ClickReceivedRequests();

            // Click Complete
            ReceivedRequest.ClickCompleteButtonRow1();

            // Get popup message
            string popupMessage = ReceivedRequest.GetPopupMessage();

            // Is sender rating displayed
            bool isSenderRatingDisplayed = ReceivedRequest.IsSenderRatingRow1Displayed();

            // Log test result
            bool passCondition = "Request has been updated" == popupMessage && isSenderRatingDisplayed;
            CommonMethods.LogResult(passCondition, "Complete Received Request Passed", "Complete Received Request Failed");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.AreEqual("Request has been updated", popupMessage);
                Assert.IsTrue(isSenderRatingDisplayed);
            });
        }

        [Test]
        public void TC_012_04_AccessTheTitleLinkOfAReceivedRequest()
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click Received Requests
            Profile.ClickReceivedRequests();

            // Get ReceivedRequest page service details
            string title = ReceivedRequest.GetTitleRow1();
            string url = ReceivedRequest.GetTitleLinkRow1Url();

            // Click the title link
            ReceivedRequest.ClickTitleLinkRow1();

            // Wait a bit
            Thread.Sleep(1000);

            // Get ServiceDetail page details
            string serviceDetailTitle = ServiceDetail.GetTitle();
            string serviceDetailRecipient = ServiceDetail.GetName();
            string serviceDetailUrl = Driver.driver.Url;

            // Log test result
            bool passCondition = title == serviceDetailTitle && url == serviceDetailUrl;
            CommonMethods.LogResult(passCondition, "Received Request Title link Passed", "Received Request Title link Failed");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.AreEqual(title, serviceDetailTitle);
                Assert.AreEqual(url, serviceDetailUrl);
            });
        }

        [Test]
        public static void TC_012_05_AccessTheSenderLinkOfAReceivedRequest()
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click Received Requests
            Profile.ClickReceivedRequests();

            // Get the sender link
            string url = ReceivedRequest.GetSenderLinkRow1Url();

            // Click the sender link
            ReceivedRequest.ClickSenderLinkRow1();

            // Wait a bit
            Thread.Sleep(1000);

            // Get the actual sender link
            string serviceDetailUrl = Driver.driver.Url;

            // Log test result
            CommonMethods.LogResult(url == serviceDetailUrl, "Received Request Sender link Passed", "Received Request Sender link Failed");

            // Assert
            Assert.AreEqual(url, serviceDetailUrl);
        }
    }
}