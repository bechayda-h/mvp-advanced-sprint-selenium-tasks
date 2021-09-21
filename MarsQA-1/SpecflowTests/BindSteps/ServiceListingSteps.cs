//using MarsQA_1.SpecflowPages.Pages;
//using System;
//using TechTalk.SpecFlow;

//namespace MarsQA_1.SpecflowTests.BindSteps
//{
//    [Binding]
//    public class ServiceListingSteps
//    {
//        [Given(@"user clicks Share Skills button")]
//        public void GivenUserClicksShareSKillsButton()
//        {
//            Profile.ClickShareSkillBUtton();
//        }

//        [Given(@"user inputs skill details: '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)'")]
//        public void GivenUserInputsSkillDetails(string title, string description, string category, string subcategory, string tag, string servicetype, string skillexchange)
//        {
//            ServiceListing.InputSkillDetails(title, description, category, subcategory, tag, servicetype, skillexchange);
//        }

//        [When(@"user clicks the Save button")]
//        public void WhenUserClicksTheSaveButton()
//        {
//            ServiceListing.ClickSaveButton();
//        }

//        [Then(@"the skill details '(.*)', '(.*)', '(.*)', '(.*)' will be listed on top in the ListingManagement page")]
//        public void ThenTheSkillDetailsWillBeListedOnTopInTheListingManagementPage(string category, string title, string description, string servicetype)
//        {
//            ListingManagement.AssertTopMostListingItem(category, title, description, servicetype);
//        }
//    }
//}
