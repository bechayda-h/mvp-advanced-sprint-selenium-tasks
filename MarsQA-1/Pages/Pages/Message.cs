using MarsQA_1.Helpers;
using OpenQA.Selenium;

namespace MarsQA_1.Pages.Pages
{
    class Message
    {
        // Chat room list
        public static IWebElement ChatList1 => Driver.driver.FindElement(By.XPath("//*[@id='chatList']/div[1]/div[2]/div[1]"));     
        public static IWebElement ChatList2 => Driver.driver.FindElement(By.XPath("//*[@id='chatList']/div[2]/div[2]/div[1]"));

        // Top-most message
        public static IWebElement ChatContentMessage1 => Driver.driver.FindElement(By.XPath("//*[@id='left']/div/span"));
        public static IWebElement ChatContentTime1 => Driver.driver.FindElement(By.XPath("//*[@id='left']/span"));

        // Latest message
        public static IWebElement LatestMessage => Driver.driver.FindElement(By.XPath("//*[@id='chatBox']/div[last()]/div/div"));

        public static IWebElement ChatTextBox => Driver.driver.FindElement(By.XPath("//*[@id='chatTextBox']"));
        
        public static IWebElement SendButton => Driver.driver.FindElement(By.XPath("//*[@id='btnSend']"));

        public static void ClickChatList2()
        {         
            ChatList2.Click();
        }

        public static string GetFirstMessageAndTime()
        {
            return ($"{ChatContentMessage1.Text} {ChatContentTime1.Text}");
        }

        public static void InputChat(string chat)
        {
            ChatTextBox.Click();
            ChatTextBox.SendKeys(chat);
        }

        public static void ClickSendButton()
        {
            SendButton.Click();
        }

        public static string GetLatestMessage()
        {
            return LatestMessage.Text;
        }
    }
}
