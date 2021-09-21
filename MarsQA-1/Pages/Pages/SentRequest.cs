using MarsQA_1.Helpers;
using OpenQA.Selenium;

namespace MarsQA_1.Pages.Pages
{
    class SentRequest
    {
        private static IWebElement PopupMessage => Driver.driver.FindElement(By.XPath("/html/body/div/div[@class='ns-box-inner']"));

        // Sent Requests row 1 elements
        private static IWebElement TitleLinkRow1 => Driver.driver.FindElement(By.XPath("//*[@id='sent-request-section']/div[2]/div[1]/table/tbody/tr[1]/td[2]/a"));
        private static IWebElement RecipientLinkRow1 => Driver.driver.FindElement(By.XPath("//*[@id='sent-request-section']/div[2]/div[1]/table/tbody/tr[1]/td[4]/a"));
        private static IWebElement StatusRow1 => Driver.driver.FindElement(By.XPath("//*[@id='sent-request-section']/div[2]/div[1]/table/tbody/tr[1]/td[5]"));
        private static IWebElement WithdrawButtonRow1 => Driver.driver.FindElement(By.XPath("//*[@id='sent-request-section']/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[text()='Withdraw']"));
        private static IWebElement CompletedButtonRow1 => Driver.driver.FindElement(By.XPath("//*[@id='sent-request-section']/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[text()='Completed']"));
        private static IWebElement ReviewButtonRow1 => Driver.driver.FindElement(By.XPath("//*[@id='sent-request-section']/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[text()='Review']"));

        // Page Modal Rate this Service
        private static IWebElement Review => Driver.driver.FindElement(By.XPath("//*[@id='reviewCommentInput']"));
        private static IWebElement SaveButton => Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div[4]/div"));      
        
        public static void ClickTitleLinkRow1()
        {
            TitleLinkRow1.Click();
        }

        public static void ClickRecipientLinkRow1()
        {
            RecipientLinkRow1.Click();
        }

        public static void ClickWithdrawButtonRow1()
        {
            WithdrawButtonRow1.Click();
        }

        public static string GetTitleLinkRow1Url()
        {
            return TitleLinkRow1.GetAttribute("href");
        }

        public static string GetRecipientLinkRow1Url()
        {
            return RecipientLinkRow1.GetAttribute("href");
        }

        public static void ClickCompletedButtonRow1()
        {
            CompletedButtonRow1.Click();
        }

        public static string GetTitleRow1()
        {
            return TitleLinkRow1.Text;
        }

        public static string GetStatusRow1()
        {
            return StatusRow1.Text;
        }

        public static string GetRecipientRow1()
        {
            return RecipientLinkRow1.Text;
        }

        public static string GetPopupMessage()
        {
            return PopupMessage.Text;
        }

        public static void InputReview(string text)
        {
            Review.Clear();
            Review.SendKeys(text);
        }

        public static void ClickCommunicationRating(string rating)
        {
            Driver.driver.FindElement(By.XPath($"//div[@id='communicationRating']/i[{rating}]")).Click();
        }

        public static void ClickServiceRating(string rating)
        {
            Driver.driver.FindElement(By.XPath($"//div[@id='serviceRating']/i[{rating}]")).Click();
        }

        public static void ClickRecommendRating(string rating)
        {
            Driver.driver.FindElement(By.XPath($"//div[@id='recommendRating']/i[{rating}]")).Click();
        }

        public static void ClickReviewButtonRow1()
        {
            ReviewButtonRow1.Click();
        }

        public static void ClickSaveButton()
        {
            SaveButton.Click();
        }
    }
}
