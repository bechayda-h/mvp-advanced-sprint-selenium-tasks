using MarsQA_1.Helpers;
using MarsQA_1.Pages.Pages;
using NUnit.Framework;
using System.Threading;

namespace MarsQA_1.SeleniumTests
{
    [TestFixture]
    class SentRequestTests : Utils.Start
    {
        [Test]
        public static void TC_013_01_WithdrawASentRequest()
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click Sent Requests
            Profile.ClickSentRequests();

            // Click Withdraw
            SentRequest.ClickWithdrawButtonRow1();

            // Wait a bit
            Thread.Sleep(500);

            // Get the status
            string status = SentRequest.GetStatusRow1();

            // Get the popup message
            string popupMessage = SentRequest.GetPopupMessage();

            // Log test result
            bool passCondition = "Withdrawn" == status &&
                                 "Request has been withdrawn" == popupMessage;
            CommonMethods.LogResult(passCondition, "Withdraw Sent Request Passed", "Withdraw Sent Request Failed");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.AreEqual("Withdrawn", status);
                Assert.AreEqual("Request has been withdrawn", popupMessage);
            });
        }

        [Test]
        public static void TC_013_02_CompletedASentRequest()
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click Sent Requests
            Profile.ClickSentRequests();

            // Click Completed
            SentRequest.ClickCompletedButtonRow1();

            // Wait a bit
            Thread.Sleep(500);

            // Get the status
            string status = SentRequest.GetStatusRow1();

            // Get the popup message
            string popupMessage = SentRequest.GetPopupMessage();

            // Log test result
            bool passCondition = "Completed" == status &&
                                 "Request has been updated" == popupMessage;
            CommonMethods.LogResult(passCondition, "Completed Sent Request Passed", "Completed Sent Request Failed");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.AreEqual("Completed", status);
                Assert.AreEqual("Request has been updated", popupMessage);
            });
        }

        [TestCase("My Service Review", "3", "5", "2")]
        public static void TC_013_03_ReviewASentRequest(string review, string commRate, string servRate, string recoRate)
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click Sent Requests
            Profile.ClickSentRequests();

            // Click Completed
            SentRequest.ClickReviewButtonRow1();

            // Wait a bit
            Thread.Sleep(500);

            // Input review and rating
            SentRequest.InputReview(review);
            SentRequest.ClickCommunicationRating(commRate);
            SentRequest.ClickServiceRating(servRate);
            SentRequest.ClickRecommendRating(recoRate);
            
            // Click Save
            SentRequest.ClickSaveButton();

            // Wait a bit
            Thread.Sleep(500);

            // Get the popup message
            string popupMessage = SentRequest.GetPopupMessage();

            // Log test result
            CommonMethods.LogResult("Rating added, thank you!" == popupMessage, "Review Sent Request Passed", "Review Sent Request Failed");

            // Assert
            Assert.AreEqual("Rating added, thank you!", popupMessage);
        }

        [Test]
        public void TC_013_04_AccessTheTitleLinkOfASentRequest()
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click Sent Requests
            Profile.ClickSentRequests();

            // Get SentRequest page service details
            string title = SentRequest.GetTitleRow1();
            string recipient = SentRequest.GetRecipientRow1();
            string url = SentRequest.GetTitleLinkRow1Url();

            // Click the title link
            SentRequest.ClickTitleLinkRow1();

            // Wait a bit
            Thread.Sleep(1000);

            // Get ServiceDetail page details
            string serviceDetailTitle = ServiceDetail.GetTitle();
            string serviceDetailRecipient = ServiceDetail.GetName();
            string serviceDetailUrl = Driver.driver.Url;

            // Log test result
            bool passCondition = title == serviceDetailTitle &&
                                 recipient == serviceDetailRecipient &&
                                 url == serviceDetailUrl;
            CommonMethods.LogResult(passCondition, "Sent Request Title link Passed", "Sent Request Title link Failed");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.AreEqual(title, serviceDetailTitle);
                Assert.AreEqual(recipient, serviceDetailRecipient);
                Assert.AreEqual(url, serviceDetailUrl);
            });
        }

        [Test]
        public static void TC_013_05_AccessTheRecipientLinkOfASentRequest()
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click Sent Requests
            Profile.ClickSentRequests();

            // Get the recipient link
            string url = SentRequest.GetRecipientLinkRow1Url();

            // Click the recipient link
            SentRequest.ClickRecipientLinkRow1();

            // Wait a bit
            Thread.Sleep(1000);

            // Get the actual recipient link
            string serviceDetailUrl = Driver.driver.Url;

            // Log test result
            CommonMethods.LogResult(url == serviceDetailUrl, "Sent Request Recipient link Passed", "Sent Request Recipient link Failed");

            // Assert
            Assert.AreEqual(url, serviceDetailUrl);
        }      
    }
}
