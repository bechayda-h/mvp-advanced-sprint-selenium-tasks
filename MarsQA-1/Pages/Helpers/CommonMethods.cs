using OpenQA.Selenium;
using System;
using System.Text;
using RelevantCodes.ExtentReports;
using OpenQA.Selenium.Support.UI;

namespace MarsQA_1.Helpers
{
    public class CommonMethods
    {
        //Screenshots
        //Screenshot

        public class SaveScreenShotClass
        {
            
            public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName) // Definition
            {
                var folderLocation = (ConstantHelpers.ScreenshotPath);

                if (!System.IO.Directory.Exists(folderLocation))
                {
                    System.IO.Directory.CreateDirectory(folderLocation);
                }

                var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
                var fileName = new StringBuilder(folderLocation);

                fileName.Append(ScreenShotFileName);
                fileName.Append(DateTime.Now.ToString("_dd-MM-yyyy_mss"));

                fileName.Append(".jpeg");
                screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Jpeg);
                return fileName.ToString();
            }
        }

        //ExtentReports
        #region reports
        public static ExtentTest test;
        public static ExtentReports Extent;

        public static void ExtentReports()
        {
            Extent = new ExtentReports(ConstantHelpers.ReportsPath, false, DisplayOrder.NewestFirst);
            Extent.LoadConfig(ConstantHelpers.ReportXMLPath);

            // Start taking test report
            test = Extent.StartTest("Sample Report");
        }


        // Log test result whether it is Passed or Failed
        public static void LogResult(bool truecondition, string passmessage, string failmessage)
        {
            if (truecondition)
            {
                CommonMethods.test.Log(LogStatus.Pass, passmessage);
            }
            else
            {
                CommonMethods.test.Log(LogStatus.Fail, failmessage);
            }
        }
        #endregion

        // Wait Helpers
        public static void WaitForElementToBeVisible(string xpath, int seconds)
        {
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(seconds));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
        }

        public static void WaitForElementToBeNotVisible(string xpath, int seconds)
        {
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(seconds));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.XPath(xpath)));
        }
    }


}


