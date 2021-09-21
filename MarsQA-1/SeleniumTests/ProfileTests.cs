using MarsQA_1.Helpers;
using MarsQA_1.Pages.Pages;
using MarsQA_1.Pages.Pages.ProfileContents;
using NUnit.Framework;
using System.Threading;

namespace MarsQA_1.SeleniumTests
{
    [TestFixture]
    class ProfileTests : Utils.Start
    {
        [TestCase("Part Time")]
        [TestCase("Full Time")]
        public void TC_002_01_EditAvailability(string option)
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            Availability.ClickWriteIcon();

            Availability.SelectOption(option);

            // Wait a bit
            Thread.Sleep(500);

            // Get the popup message
            string popupMessage = Profile.GetPopupMessage();
            
            // Get the actual value
            string actualOption = Availability.GetValue();

            // Log test result
            bool passCondition = option == actualOption && 
                                 "Availability updated" == popupMessage;
            CommonMethods.LogResult(passCondition, "Availability Passed", "Availability Failed");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.AreEqual(option, actualOption);
                Assert.AreEqual("Availability updated", popupMessage);
            });
        }

        [TestCase("Less than 30hours a week")]
        [TestCase("More than 30hours a week")]
        [TestCase("As needed")]
        public void TC_002_02_EditHours(string option)
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            Hours.ClickWriteIcon();

            Hours.SelectOption(option);

            // Wait a bit
            Thread.Sleep(500);

            // Get the popup message
            string popupMessage = Profile.GetPopupMessage();

            // Get the actual value
            string actualOption = Hours.GetValue();

            // Log test result
            bool passCondition = option == actualOption &&
                                 "Availability updated" == popupMessage;
            CommonMethods.LogResult(passCondition, "Hours Passed", "Hours Failed");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.AreEqual(option, actualOption);
                Assert.AreEqual("Availability updated", popupMessage);
            });
        }

        [TestCase("Less than $500 per month")]
        [TestCase("Between $500 and $1000 per month")]
        [TestCase("More than $1000 per month")]
        public void TC_002_03_EditEarnTarget(string option)
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            EarnTarget.ClickWriteIcon();

            EarnTarget.SelectOption(option);

            // Wait a bit
            Thread.Sleep(500);

            // Get the popup message
            string popupMessage = Profile.GetPopupMessage();

            // Get the actual value
            string actualOption = EarnTarget.GetValue();

            // Log test result
            bool passCondition = option == actualOption &&
                                 "Availability updated" == popupMessage;
            CommonMethods.LogResult(passCondition, "Earn Target Passed", "Earn Target Failed");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.AreEqual(option, actualOption);
                Assert.AreEqual("Availability updated", popupMessage);
            });
        }

        [TestCase("English", "Basic")]
        public void TC_003_01_AddALanguageEntry(string name, string level)
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click Add New
            Languages.ClickAddNewButton();

            // Input a language
            Languages.InputNewName(name);

            // Select a language level
            Languages.SelectNewLevel(level);

            // Click Add
            Languages.ClickAddButton();

            // Get popup message
            string popupMessage = Profile.GetPopupMessage();

            // Get the actual values
            string actualName = Languages.GetName();
            string actualLevel = Languages.GetLevel();

            // Log test result
            bool passCondition = name == actualName && 
                                 level == actualLevel &&
                                 $"{name} has been added to your languages" == popupMessage;
            CommonMethods.LogResult(passCondition, "Add Language Passed", "Add Language Failed");

            // Assert
            Assert.Multiple(() =>
            {
                StringAssert.IsMatch(name, actualName);
                StringAssert.IsMatch(level, actualLevel);
                StringAssert.IsMatch($"{name} has been added to your languages", popupMessage);
            });
        }

        [TestCase("Chinese", "Fluent")]
        public void TC_003_02_EditALanguageEntry(string name, string level)
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click the entry's write icon
            Languages.ClickWriteIcon();

            // Edit the language name
            Languages.UpdateName(name);

            // Edit the language level
            Languages.UpdateLevel(level);

            // Click Update
            Languages.ClickUpdateButton();

            // Wait a bit
            Thread.Sleep(500);

            // Get the popup message
            string popupMessage = Profile.GetPopupMessage();

            // Get the actual values
            string actualName = Languages.GetName();
            string actualLevel = Languages.GetLevel();

            // Log test result
            bool passCondition = name == actualName && 
                                 level == actualLevel &&
                                 $"{name} has been updated to your languages" == popupMessage;
            CommonMethods.LogResult(passCondition, "Edit Language Passed", "Edit Language Failed");

            // Assert
            Assert.Multiple(() =>
            {
                StringAssert.IsMatch(name, actualName);
                StringAssert.IsMatch(level, actualLevel);
                StringAssert.IsMatch($"{name} has been updated to your languages", popupMessage);
            });
        }

        [Test]
        public void TC_003_03_DeleteALanguageEntry()
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Get the name before deleting
            string name = Languages.GetName();

            // Click the entry's remove icon
            Languages.ClickRemoveIcon();

            // Wait a bit
            Thread.Sleep(500);

            // Get the popup message
            string popupMessage = Profile.GetPopupMessage();

            // True if deleted
            bool isDeleted = Languages.IsEntryDeleted();

            // Log test result
            bool passCondition = isDeleted && $"{name} has been deleted" == popupMessage;
            CommonMethods.LogResult(passCondition, "Delete Language Passed", "Delete Language Failed");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.IsTrue(isDeleted);
                StringAssert.IsMatch($"{name} has been deleted from your languages", popupMessage);
            });
        }

        [TestCase("Postman", "Intermediate")]
        public static void TC_004_01_AddASkillEntry(string name, string level)
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click the tab
            Profile.SetActiveTab("Skills");

            // Click Add New
            Skills.ClickAddNewButton();

            // Input a name
            Skills.InputNewName(name);

            // Select a level
            Skills.SelectNewLevel(level);

            // Click Add
            Skills.ClickAddButton();

            // Get the popup Message
            string popupMessage = Profile.GetPopupMessage();

            // Get the actual values
            string actualName = Skills.GetName();
            string actualLevel = Skills.GetLevel();

            // Log test result
            bool passCondition = name == actualName && 
                                 level == actualLevel &&
                                 $"{name} has been added to your skills" == popupMessage;
            CommonMethods.LogResult(passCondition, "Add Skill Passed", "Add Skill Failed");

            // Assert
            Assert.Multiple(() =>
            {
                StringAssert.IsMatch(name, actualName);
                StringAssert.IsMatch(level, actualLevel);
                StringAssert.IsMatch($"{name} has been added to your skills", popupMessage);
            });
        }

        [TestCase("Python", "Expert")]
        public static void TC_004_02_EditASkillEntry(string name, string level)
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click the tab
            Profile.SetActiveTab("Skills");

            // Click the entry's write icon
            Skills.ClickWriteIcon();

            // Edit the name
            Skills.UpdateName(name);

            // Edit the level
            Skills.UpdateLevel(level);

            // Click Update
            Skills.ClickUpdateButton();

            // Wait a bit
            Thread.Sleep(500);

            // Get the popup message
            string popupMessage = Profile.GetPopupMessage();

            // Get the actual values
            string actualName = Skills.GetName();
            string actualLevel = Skills.GetLevel();

            // Log test result
            bool passCondition = name == actualName && 
                                 level == actualLevel &&
                                 $"{name} has been updated to your skills" == popupMessage;
            CommonMethods.LogResult(passCondition, "Edit Skill Passed", "Edit Skill Failed");

            // Assert
            Assert.Multiple(() =>
            {
                StringAssert.IsMatch(name, actualName);
                StringAssert.IsMatch(level, actualLevel);
                StringAssert.IsMatch($"{name} has been updated to your skills", popupMessage);
            });
         }

        [Test]
        public static void TC_004_03_DeleteASkillEntry()
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click the tab
            Profile.SetActiveTab("Skills");

            // Get the name before deleting
            string name = Skills.GetName();

            // Click the entry's remove icon
            Skills.ClickRemoveIcon();

            // Wait a bit
            Thread.Sleep(500);

            // Get the popup message
            string popupMessage = Profile.GetPopupMessage();
            
            // True if deleted
            bool isDeleted = Skills.IsEntryDeleted();
            
            // Log test result
            bool passCondition = isDeleted && $"{name} has been deleted" == popupMessage;
            CommonMethods.LogResult(passCondition, "Delete Skill Passed", "Delete Skill Failed");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.IsTrue(isDeleted);
                StringAssert.IsMatch($"{name} has been deleted", popupMessage);
            });
        }

        [TestCase("College1", "United States", "B.A", "Degree1", "2020")]
        public static void TC_005_01_AddAnEducationEntry(string university, string country, string title, string degree, string year)
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click the tab
            Profile.SetActiveTab("Education");

            // Click Add New
            Education.ClickAddNewButton();

            // Input new entry's details
            Education.InputNewUniversity(university);
            Education.SelectNewCountry(country);
            Education.SelectNewTitle(title);
            Education.InputNewDegree(degree);
            Education.SelectNewYear(year);

            // Click Add
            Education.ClickAddButton();

            // Wait a bit
            Thread.Sleep(500);

            // Get the popup Message
            string popupMessage = Profile.GetPopupMessage();

            // Get the actual values
            string actualCountry = Education.GetCountry();
            string actualUniversity = Education.GetUniversity();
            string actualTitle = Education.GetTitle();
            string actualDegree = Education.GetDegree();
            string actualYear = Education.GetYear();

            // Log test result
            bool passCondition = country == actualCountry &&
                                 university == actualUniversity &&
                                 title == actualTitle &&
                                 degree == actualDegree &&
                                 year == actualYear &&
                                 "Education has been added" == popupMessage;
            CommonMethods.LogResult(passCondition, "Add Education Passed", "Add Education Failed");

            // Assert
            Assert.Multiple(() =>
            {
                StringAssert.IsMatch(university, actualUniversity);
                StringAssert.IsMatch(country, actualCountry);
                StringAssert.IsMatch(title, actualTitle);
                StringAssert.IsMatch(degree, actualDegree);
                StringAssert.IsMatch(year, actualYear);
                StringAssert.IsMatch("Education has been added", popupMessage);
            });
        }

        [TestCase("College2", "Canada", "Associate", "Degree2", "2019")]
        public static void TC_005_02_EditAnEducationEntry(string university, string country, string title, string degree, string year)
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click the tab
            Profile.SetActiveTab("Education");

            // Click Add New
            Education.ClickWriteIcon();

            // Edit the entry's details
            Education.UpdateUniversity(university);
            Education.UpdateCountry(country);
            Education.UpdateTitle(title);
            Education.UpdateDegree(degree);
            Education.UpdateYear(year);

            // Click Update
            Education.ClickUpdateButton();

            // Wait a bit
            Thread.Sleep(500);

            // Get the popup Message
            string popupMessage = Profile.GetPopupMessage();

            // Get the actual values
            string actualCountry = Education.GetCountry();
            string actualUniversity = Education.GetUniversity();
            string actualTitle = Education.GetTitle();
            string actualDegree = Education.GetDegree();
            string actualYear = Education.GetYear();

            // Log test result
            bool passCondition = country == actualCountry &&
                                 university == actualUniversity &&
                                 title == actualTitle &&
                                 degree == actualDegree &&
                                 year == actualYear &&
                                 "Education as been updated" == popupMessage;
            CommonMethods.LogResult(passCondition, "Edit Education Passed", "Edit Education Failed");

            // Assert
            Assert.Multiple(() =>
            {
                StringAssert.IsMatch(university, actualUniversity);
                StringAssert.IsMatch(country, actualCountry);
                StringAssert.IsMatch(title, actualTitle);
                StringAssert.IsMatch(degree, actualDegree);
                StringAssert.IsMatch(year, actualYear);
                StringAssert.IsMatch("Education as been updated", popupMessage);
            });
        }

        [Test]
        public static void TC_005_03_DeleteAnEducationEntry()
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click the tab
            Profile.SetActiveTab("Education");

            // Get the name before deleting
            string name = Education.GetUniversity();

            // Click the entry's remove icon
            Education.ClickRemoveIcon();

            // Wait a bit
            Thread.Sleep(500);

            // Get the popup message
            string popupMessage = Profile.GetPopupMessage();

            // True if deleted
            bool isDeleted = Education.IsEntryDeleted();

            // Log test result
            bool passCondition = isDeleted && "Education entry successfully removed" == popupMessage;
            CommonMethods.LogResult(passCondition, "Delete Education Passed", "Delete Education Failed");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.IsTrue(isDeleted);
                StringAssert.IsMatch("Education entry successfully removed", popupMessage);
            });
        }

        [TestCase("Certificate1", "CertFrom", "2020")]
        public static void TC_006_01_AddACertificationEntry(string certificate, string from, string year)
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click the tab
            Profile.SetActiveTab("Certifications");

            // Click Add New
            Certifications.ClickAddNewButton();

            // Input new entry's details
            Certifications.InputNewCertificate(certificate);
            Certifications.InputNewFrom(from);
            Certifications.SelectNewYear(year);

            // Click Add
            Certifications.ClickAddButton();

            // Wait a bit
            Thread.Sleep(500);

            // Get the popup Message
            string popupMessage = Profile.GetPopupMessage();

            // Get the actual values
            string actualCertificate = Certifications.GetCertificate();
            string actualFrom = Certifications.GetFrom();
            string actualYear = Certifications.GetYear();

            // Log test result
            bool passCondition = certificate == actualCertificate &&
                                 from == actualFrom &&
                                 year == actualYear &&
                                 $"{certificate} has been added to your certification" == popupMessage;
            CommonMethods.LogResult(passCondition, "Add Certification Passed", "Add Certification Failed");

            // Assert
            Assert.Multiple(() =>
            {
                StringAssert.IsMatch(certificate, actualCertificate);
                StringAssert.IsMatch(from, actualFrom);
                StringAssert.IsMatch(year, actualYear);
                StringAssert.IsMatch($"{certificate} has been added to your certification", popupMessage);
            });
        }

        [TestCase("Certificate2", "CertificateFrom2", "2018")]
        public static void TC_006_02_EditACertificationEntry(string certificate, string from, string year)
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click the tab
            Profile.SetActiveTab("Certifications");

            // Click Add New
            Certifications.ClickWriteIcon();

            // Update entry's details
            Certifications.UpdateCertificate(certificate);
            Certifications.UpdateFrom(from);
            Certifications.UpdateYear(year);

            // Click Update
            Certifications.ClickUpdateButton();

            // Wait a bit
            Thread.Sleep(500);

            // Get the popup Message
            string popupMessage = Profile.GetPopupMessage();

            // Get the actual values
            string actualCertificate = Certifications.GetCertificate();
            string actualFrom = Certifications.GetFrom();
            string actualYear = Certifications.GetYear();

            // Log test result
            bool passCondition = certificate == actualCertificate &&
                                 from == actualFrom &&
                                 year == actualYear &&
                                 $"{certificate} has been updated to your certification" == popupMessage;
            CommonMethods.LogResult(passCondition, "Edit Certification Passed", "Edit Certification Failed");

            // Assert
            Assert.Multiple(() =>
            {
                StringAssert.IsMatch(certificate, actualCertificate);
                StringAssert.IsMatch(from, actualFrom);
                StringAssert.IsMatch(year, actualYear);
                StringAssert.IsMatch($"{certificate} has been updated to your certification", popupMessage);
            });
        }

        [Test]
        public void TC_006_03_DeleteACertificationEntry()
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click the tab
            Profile.SetActiveTab("Certifications");

            // Get the name before deleting
            string name = Certifications.GetCertificate();

            // Click the entry's remove icon
            Certifications.ClickRemoveIcon();

            // Wait a bit
            Thread.Sleep(750);

            // Get the popup message
            string popupMessage = Profile.GetPopupMessage();

            // True if deleted
            bool isDeleted = Certifications.IsEntryDeleted();

            // Log test result
            bool passCondition = isDeleted && $"{name} has been deleted from your certification" == popupMessage;
            CommonMethods.LogResult(passCondition, "Delete Certification Passed", "Delete Certification Failed");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.IsTrue(isDeleted);
                StringAssert.IsMatch($"{name} has been deleted from your certification", popupMessage);
            });
        }

        [TestCase("Description Detail")]
        public void TC_007_01_EditDescription(string description)
        {
            // Login with valid credentials
            SignIn.SigninSteps();

            // Click description's write icon
            Description.ClickWriteIcon();

            // Wait a bit
            Thread.Sleep(100);

            // Edit the description
            Description.InputDescription(description);

            // Click Save
            Description.ClickSaveButton();

            // Wait a bit
            Thread.Sleep(500);

            // Get popup message
            string popupMessage = Profile.GetPopupMessage();

            // Get actual value
            string actualDescription = Description.GetDescription();

            // Log test result
            bool passCondition = description == actualDescription && 
                                 "Description has been saved successfully" == popupMessage;
            CommonMethods.LogResult(passCondition, "Edit Description Passed", "Edit Description Failed");

            // Assert
            Assert.Multiple(() =>
            {
                StringAssert.IsMatch(description, actualDescription);
                StringAssert.IsMatch("Description has been saved successfully", popupMessage);
            });
        }
        
        [TestCase("bechayda_h@yahoo.com","password","password1")]
        public void TC_008_01_ChangePassword(string username, string currentPassword, string newPassword)
        {
            // Click Sign in
            SignIn.ClickSignIn();

            // Login with username and password
            SignIn.Login(username, currentPassword);
            
            // Wait a bit for the login process to complete
            Thread.Sleep(5000);

            // Get the user's name
            string name = Profile.GetUserName();

            // Click Change Password
            ChangePassword.ClickChangePassword();

            // Input current and new password
            ChangePassword.InputOldAndNewPassword(currentPassword, newPassword);

            // Click Save
            ChangePassword.ClickSaveButton();

            // Wait a bit
            Thread.Sleep(500);

            // Get the popup message
            string popupMessage = Profile.GetPopupMessage();

            // Click Sign Out
            Profile.ClickSignOut();

            // Click Sign in
            SignIn.ClickSignIn();

            // Login with username and password
            SignIn.Login(username, newPassword);

            // Wait a bit for the login process to complete
            Thread.Sleep(4000);

            // Log test result
            bool passCondition = "Password Changed Successfully" == popupMessage &&
                                 "Profile" == Driver.driver.Title && 
                                 name == Profile.GetUserName();
            CommonMethods.LogResult(passCondition, "Change Password Passed", "Change Password Failed");

            // Assert
            Assert.Multiple(() =>
            {
                StringAssert.IsMatch("Password Changed Successfully", popupMessage);
                StringAssert.IsMatch("Profile", Driver.driver.Title);
                StringAssert.IsMatch(name, Profile.GetUserName());
            });
        }
    }
}
