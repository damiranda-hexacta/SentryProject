using System;
using System.Configuration;
using System.Data.SqlClient;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Sentry.Framework.Utils
{
    public class SentryFrame
    {

        public IWebDriver driver;

        public SentryFrame()
        {
            this.driver = DriverManager.Driver;
        }

               

        public void SentryWaitFor(int milliseconds)
        {
            Thread.Sleep(milliseconds);
        }

        public void SentryVisibleElementAssert(By by)
        {
            SentryExplicitWait().Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
            Assert.True(driver.FindElement(by).Enabled);
            SentryWaitFor(500);
        }

        public void SentryTextEqualAssert(By by, string expectedString)
        {
            SentryVisibleElementAssert(by);
            Assert.True(driver.FindElement(by).Text.Equals(expectedString));
        }


        public void SentryClickJS(By by)
        {
            SentryExplicitWait().Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(by));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)this.driver;
            executor.ExecuteScript("arguments[0].click();", this.driver.FindElement(by));

        }

        public void SentryWrite(By by, string text)
        {
            SentryVisibleElementAssert(by);
            this.driver.FindElement(by).SendKeys(text);
        }

        public void SentryScreenshot()
        {
            SentryWaitFor(1000);
            Screenshot ss = ((ITakesScreenshot)this.driver).GetScreenshot();
            ss.SaveAsFile("/Users/hexacta/Projects/Sentry/Sentry/Tests/Evidences/" + DateTime.Now.ToString("M:dd:yy:HH:mm:ss")+".png", ScreenshotImageFormat.Png);
            Console.Read();
        }

        public void SentryScroll(By by)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)this.driver;
            executor.ExecuteScript("arguments[0].scrollIntoView(true);", this.driver.FindElement(by));
        }

        public WebDriverWait SentryExplicitWait() {
            return new WebDriverWait(this.driver, System.TimeSpan.FromSeconds(30));
        }

        public Boolean SentryElementPresent(By by)
        {
            this.driver.Manage().Timeouts().ImplicitWait.Add(System.TimeSpan.FromSeconds(2));
            try
            {

                if (this.driver.FindElement(by).Enabled)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (NoSuchElementException e)
            {
                return false;
            }
        }

        public void SentryHighlightVisible(By by)
        {
            SentryVisibleElementAssert(by);
            var jsDriver = (IJavaScriptExecutor)this.driver;
            string script = @"arguments[0].style.cssText = ""border-width: 4px; border-style: solid; border-color: green""; ";
            jsDriver.ExecuteScript(script, new object[] { this.driver.FindElement(by) });
            SentryWaitFor(1000);
        }

        public void SentryHighlightDatabase(By by)
        {
            SentryVisibleElementAssert(by);
            var jsDriver = (IJavaScriptExecutor)this.driver;
            string script = @"arguments[0].style.cssText = ""border-width: 4px; border-style: solid; border-color: blue""; ";
            jsDriver.ExecuteScript(script, new object[] { this.driver.FindElement(by) });
        }


        public void SentryReadFile()
        {
            var fileContent = File.ReadAllText(@"../../../" + "file.txt");
        }

        public void SentryConnectDB()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder()
                {
                    DataSource = "sql-retail-devserver.database.windows.net",
                    InitialCatalog = "RetailStore",
                    UserID = "sentryadmin",
                    Password = "C0mMunit!Pr0202!**"
                };
                string connectionString = builder.ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command;
                SqlDataReader dataReader;
                string query, output;
                query = "select * FROM ViewUnitDetails where ZIPCODE='37215' AND STREET1='51 OLD CLUB CT';";
                command = new SqlCommand(query, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Console.WriteLine("Esta entrando al ciclo");
                    Console.WriteLine("databaseeeeeeeee: " + dataReader.GetValue(0));
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
           
        }


        public void SentryTearDown()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }

        
    }
}

