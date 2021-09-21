//using MarsQA_1.SpecflowPages.Pages;
//using System;
//using TechTalk.SpecFlow;

//namespace MarsQA_1.Feature
//{
//    [Binding]
//    public class ListingManagementSteps
//    {
//        private string _category;
//        private string _title;
//        private string _description;

//        [Given(@"user clicks Manage Listings")]
//        public void GivenUserClicksManageListings()
//        {
//            Profile.ClickManageListings();
//        }
        
//        [When(@"user clicks the write icon")]
//        public void WhenUserClicksTheWriteIcon()
//        {
//            // Get row data to be asserted in ServiceListing page
//            _category = ListingManagement.GetCategoryRow1();
//            _title = ListingManagement.GetTitleRow1();
//            _description = ListingManagement.GetDescriptionRow1();

//            ListingManagement.ClickWriteIconOnFirstRow();
//        }
        
//        [Then(@"user will be able to navigate the ServiceListing page of the item")]
//        public void ThenUserWillBeAbleToNavigateTheServiceListingPageOfTheItem()
//        {
//            ServiceListing.AssertPageTitleDescriptionCategory(_title, _description, _category);
//        }

//        [When(@"user clicks the remove icon")]
//        public void WhenUserClicksTheRemoveIcon()
//        {
//            ListingManagement.ClickRemoveIcon();
//        }

//        [Then(@"a Delete Your Service page modal will appear")]
//        public void ThenADeleteYourServicePageModalWillAppear()
//        {
//            ListingManagement.AssertPageModalIsDisplayed();
//        }

//        [Then(@"the title of the skill to be deleted will be mentioned in the content")]
//        public void ThenTheTitleOfTheSkillToBeDeletedWillBeMentionedInTheContent()
//        {
//            ListingManagement.AssertSkillTitleInPageModalIsDisplayed();
//        }

//    }
//}
