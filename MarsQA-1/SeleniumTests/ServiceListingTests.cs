using MarsQA_1.Helpers;
using MarsQA_1.Pages.Pages;
using NUnit.Framework;
using System.Threading;

namespace MarsQA_1.SeleniumTests
{
    [TestFixture]
    class ServiceListingTests : Utils.Start
    {
        [TestCase("Sample Skill", "Description", "Graphics & Design", "Book & Album covers", "tag", "Hourly", "tag" )]
        public void TC_009_01_AddAServiceEntry(string title, string description, string category, string subCategory, string tag, string serviceType, string skillExchangeTag)
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click Share Skill
            Profile.ClickShareSkillButton();

            // Input service entry details
            ServiceListing.InputTitle(title);
            ServiceListing.InputDescription(description);
            ServiceListing.SelectCategory(category);
            ServiceListing.SelectSubCategory(subCategory);
            ServiceListing.EnterTag(tag);
            ServiceListing.SelectServiceType(serviceType);
            ServiceListing.EnterSkillExchangeTag(skillExchangeTag);

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
            CommonMethods.LogResult(passCondition, "Add Service Entry Passed", "Add Service Entry Failed");

            // Assert
            Assert.Multiple(() =>
            {
                StringAssert.IsMatch(category, actualCategory);
                StringAssert.IsMatch(title, actualTitle);
                StringAssert.IsMatch(description, actualDescription);
                StringAssert.IsMatch(serviceType, actualServiceType);
            });
        }
    }
}
