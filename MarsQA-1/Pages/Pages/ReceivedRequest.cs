using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Pages.Pages
{
    class ReceivedRequest
    {
        private static IWebElement PopupMessage => Driver.driver.FindElement(By.XPath("/html/body/div/div[@class='ns-box-inner']"));

        // Sent Requests row 1 elements
        private static IWebElement TitleLinkRow1 => Driver.driver.FindElement(By.XPath("//*[@id='received-request-section']/div[2]/div[1]/table/tbody/tr[1]/td[2]/a"));
        private static IWebElement SenderLinkRow1 => Driver.driver.FindElement(By.XPath("//*[@id='received-request-section']/div[2]/div[1]/table/tbody/tr[1]/td[4]/a"));
        private static IWebElement StatusRow1 => Driver.driver.FindElement(By.XPath("//*[@id='received-request-section']/div[2]/div[1]/table/tbody/tr[1]/td[5]"));
        private static IWebElement AcceptButtonRow1 => Driver.driver.FindElement(By.XPath("//*[@id='received-request-section']/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[text()='Accept']"));
        private static IWebElement DeclineButtonRow1 => Driver.driver.FindElement(By.XPath("//*[@id='received-request-section']/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[text()='Decline']"));
        private static IWebElement CompleteButtonRow1 => Driver.driver.FindElement(By.XPath("//*[@id='received-request-section']/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[text()='Complete']"));

        // Send Requests hidden row 1 elements    
        private static IWebElement SenderRatingRow1 => Driver.driver.FindElement(By.XPath("//*[@id='received-request-section']/div[2]/div[1]/table/tbody/tr[2]/td[3]/div"));

        public static void ClickTitleLinkRow1()
        {
            TitleLinkRow1.Click();
        }

        public static void ClickSenderLinkRow1()
        {
            SenderLinkRow1.Click();
        }

        public static string GetTitleLinkRow1Url()
        {
            return TitleLinkRow1.GetAttribute("href");
        }

        public static string GetSenderLinkRow1Url()
        {
            return SenderLinkRow1.GetAttribute("href");
        }

        public static string GetTitleRow1()
        {
            return TitleLinkRow1.Text;
        }

        public static string GetStatusRow1()
        {
            return StatusRow1.Text;
        }

        public static string GetSenderRow1()
        {
            return SenderLinkRow1.Text;
        }

        public static string GetPopupMessage()
        {
            return PopupMessage.Text;
        }

        public static void ClickAcceptButtonRow1()
        {
            AcceptButtonRow1.Click();
        }

        public static void ClickDeclineButtonRow1()
        {
            DeclineButtonRow1.Click();
        }

        public static void ClickCompleteButtonRow1()
        {
            CompleteButtonRow1.Click();
        }

        public static bool IsSenderRatingRow1Displayed()
        {
            return SenderRatingRow1.Displayed;
        }
    }
}
