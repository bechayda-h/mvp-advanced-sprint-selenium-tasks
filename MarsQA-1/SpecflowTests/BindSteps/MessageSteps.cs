//using MarsQA_1.Helpers;
//using MarsQA_1.SpecflowPages.Pages;
//using NUnit.Framework;
//using System;
//using TechTalk.SpecFlow;

//namespace MarsQA_1.SpecflowTests.BindSteps
//{
//    [Binding]
//    public class MessageSteps
//    {
//        string MessageContent;

//        [When(@"user clicks Chat")]
//        public void WhenUserClicksChat()
//        {
//            Profile.ClickChat();
//        }

//        [Given(@"user clicks Chat")]
//        public void GivenUserClicksChat()
//        {
//            Profile.ClickChat();
//        }

//        [When(@"user clicks the second chatroom from the top")]
//        public void WhenUserClicksTheSecondChatroomFromTheTop()
//        {
//            // Get current first message and time before clicking another chatroom
//            MessageContent = Message.GetFirstMessageAndTime();
            
//            Message.ClickChatList2();
//        }

//        [Then(@"the chat content of that chat room will be displayed")]
//        public void ThenTheChatContentOfThatChatRoomWillBeDisplayed()
//        {
//            // Log test result
//            CommonMethods.LogResult(MessageContent != Message.GetFirstMessageAndTime(), 
//                                    "Chat content updated", 
//                                    "Chat Content not updated");
            
//            // Assert that the chat content is different
//            StringAssert.DoesNotMatch(MessageContent, Message.GetFirstMessageAndTime());
//        }
//    }
//}
