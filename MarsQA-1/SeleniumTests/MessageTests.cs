using MarsQA_1.Helpers;
using MarsQA_1.Pages.Pages;
using NUnit.Framework;
using System.Threading;

namespace MarsQA_1.SeleniumTests
{
    [TestFixture]
    class MessageTests : Utils.Start
    {
        [TestCase("my message")]
        public static void TC_021_01_Chat(string chat)
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click Chat
            Profile.ClickChat();

            // Input a chat
            Message.InputChat(chat);

            // Wait a bit
            Thread.Sleep(500);

            // Click Send
            Message.ClickSendButton();

            // Wait a bit
            Thread.Sleep(1000);

            // Get the latest message
            string latestMessage = Message.GetLatestMessage();

            // Log test result
            CommonMethods.LogResult(chat == latestMessage, "Chat Passed,", "Chat Failed");

            // Assert
            Assert.AreEqual(chat, latestMessage);
        }

        [Test]
        public static void TC_022_01_AccessAnotherChatroom()
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click Chat
            Profile.ClickChat();
            
            // Get the topmost chat message and time
            string messageBefore = Message.GetFirstMessageAndTime();

            // Click another Chat list
            Message.ClickChatList2();

            // Get the topmost chat message and time
            string messageAfter = Message.GetFirstMessageAndTime();
            
            // Log test result
            CommonMethods.LogResult(messageBefore != messageAfter, "Access Another Chatroom Passed", "Access Another Chatroom Failed");

            // Assert
            Assert.AreNotEqual(messageBefore, messageAfter);
        }
    }
}
