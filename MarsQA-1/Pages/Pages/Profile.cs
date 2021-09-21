using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace MarsQA_1.Pages.Pages
{
    class Profile
    {
        // Search skills icon
        private static IWebElement SearchLinkIcon => Driver.driver.FindElement(By.XPath("//i[@class='search link icon']"));

        // Chat icon
        private static IWebElement Chat => Driver.driver.FindElement(By.XPath("//a[@href='/Home/Message']"));

        // Sign Out
        private static IWebElement SignOutButton => Driver.driver.FindElement(By.XPath("//button[text()='Sign Out']"));

        // Blue popup message
        private static IWebElement PopupMessage => Driver.driver.FindElement(By.XPath("/html/body/div/div[@class='ns-box-inner']"));

        // Dashboard
        private static IWebElement Dashboard => Driver.driver.FindElement(By.XPath("//a[@href='/Account/Dashboard']"));

        // Manage Listings 
        private static IWebElement ManageListings => Driver.driver.FindElement(By.XPath("//a[@href='/Home/ListingManagement']"));

        // Manage Requests
        private static IWebElement ManageRequestsDropdownLink => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/div[1]"));
        private static IWebElement ReceivedRequests => Driver.driver.FindElement(By.XPath("//a[@href='/Home/ReceivedRequest']"));
        private static IWebElement SentRequests => Driver.driver.FindElement(By.XPath("//a[@href='/Home/SentRequest']"));

        // Share Skill
        private static IWebElement ShareSkillButton => Driver.driver.FindElement(By.XPath("//a[@href='/Home/ServiceListing']"));

        // User's name
        private static IWebElement UserName => Driver.driver.FindElement(By.XPath("//div[@class='title']"));

        // Active tab
        private static IWebElement ActiveTab => Driver.driver.FindElement(By.XPath("//a[@class='item active']"));

        // Used for invoking mouse hover action
        private static readonly Actions Action = new Actions(Driver.driver);

        public static void ClickSignOut()
        {
            SignOutButton.Click();
        }

        public static string GetUserName()
        {
            return UserName.Text;
        }

        public static void SetActiveTab(string tabname)
        {
            if (ActiveTab.Text != tabname)
            {
                Driver.driver.FindElement(By.XPath($"//div[@class='ui top attached tabular menu']/a[@class='item'][text()='{tabname}']")).Click();
            }
        }

        public static string GetPopupMessage()
        {
            return PopupMessage.Text;
        }

        public static void ClickShareSkillButton()
        {
            ShareSkillButton.Click();
        }

        public static void ClickManageListings()
        {
            ManageListings.Click();
        }

        public static void ClickReceivedRequests()
        {
            Action.MoveToElement(ManageRequestsDropdownLink).Perform();
            ReceivedRequests.Click();
        }

        public static void ClickSentRequests()
        {
            Action.MoveToElement(ManageRequestsDropdownLink).Perform();
            SentRequests.Click();
        }

        public static void ClickChat()
        {
            Chat.Click();
        }

        public static void ClickDashboard()
        {
            Dashboard.Click();
        }

        public static void ClickSearchLinkIcon()
        {
            SearchLinkIcon.Click();
        }
    }
}
