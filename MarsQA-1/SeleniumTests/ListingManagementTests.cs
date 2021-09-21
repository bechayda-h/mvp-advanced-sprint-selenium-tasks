using MarsQA_1.Helpers;
using MarsQA_1.Pages.Pages;
using NUnit.Framework;
using System.Threading;

namespace MarsQA_1.SeleniumTests
{
    [TestFixture]
    class ListingManagementTests : Utils.Start
    {
        [TestCase("Sample Skill Edited", "Description Edited", "Digital Marketing", "Content Marketing", "One-off")]
        public static void TC_010_01_EditAServiceEntry(string title, string description, string category, string subCategory, string serviceType)
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click Manage Listings
            Profile.ClickManageListings();

            // Click a service entry's write icon
            ListingManagement.ClickWriteIconRow1();

            // Edit the service entry details
            ServiceListing.InputTitle(title);
            ServiceListing.InputDescription(description);
            ServiceListing.SelectCategory(category);
            ServiceListing.SelectSubCategory(subCategory);
            ServiceListing.SelectServiceType(serviceType);

            // Click Save
            ServiceListing.ClickSaveButton();

            // Wait a bit
            Thread.Sleep(500);

            // Get actual values from the first row of Manage Listings
            string actualCategory = ListingManagement.GetCategoryRow1();
            string actualTitle = ListingManagement.GetTitleRow1();
            string actualDescription = ListingManagement.GetDescriptionRow1();
            string actualServiceType = ListingManagement.GetServiceTypeRow1();

            // Log test result
            bool passCondition = category == actualCategory &&
                                  title == actualTitle &&
                                  description == actualDescription &&
                                  serviceType == actualServiceType;
            CommonMethods.LogResult(passCondition, "Edit Service Entry Passed", "Edit Service Entry Failed");

            // Assert
            Assert.Multiple(() =>
            {
                StringAssert.IsMatch(category, actualCategory);
                StringAssert.IsMatch(title, actualTitle);
                StringAssert.IsMatch(description, actualDescription);
                StringAssert.IsMatch(serviceType, actualServiceType);
            });
        }

        [Test]
        public void TC_011_01_DeleteAServiceEntry()
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click Manage Listings
            Profile.ClickManageListings();

            // Get the service entry's title
            string title = ListingManagement.GetTitleRow1();

            // Click a service entry's remove icon
            ListingManagement.ClickRemoveIconRow1();

            // Click Yes
            ListingManagement.ClickPageModalYesButton();

            // Wait a bit
            Thread.Sleep(500);

            // Get popup message
            string popupMessage = ListingManagement.GetPopupMessage();

            // Log test result
            bool passCondition = $"{title} has been deleted" == popupMessage;
            CommonMethods.LogResult(passCondition, "Delete Service Entry Passed", "Delete Service Entry Failed");

            // Assert
            StringAssert.IsMatch(popupMessage, ListingManagement.GetPopupMessage());
        }
    }
}
