using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Protractor;

namespace Way2Automation
{
    [TestFixture]
    public class AddUser
    {
     
      
       [Test]
        public static void Main()
        {
            IWebDriver driver = new ChromeDriver("C:\\Users\\DELL\\RiderProjects\\Way2Automation\\Way2Automation\\chromedriver.exe");
            NgWebDriver ngDriver = new NgWebDriver(driver);
            driver.Manage().Window.Maximize();;
            ngDriver.Url = "https://www.way2automation.com/angularjs-protractor/webtables/";
            NgWebElement addUser = ngDriver.FindElement(By.XPath("//html/body/table/thead/tr[2]/td/button"));
            addUser.Click();
            ngDriver.FindElement(By.Name("FirstName")).SendKeys("FName1");
           
            ngDriver.FindElement(By.Name("LastName")).SendKeys("LName1");
            ngDriver.FindElement(By.Name("UserName")).SendKeys("User1");
           
            ngDriver.FindElement(By.Name("Password")).SendKeys("Pass1"); 
            ngDriver.FindElement(By.Name("optionsRadios")).Click();
            SelectElement drpRollId = new SelectElement(driver.FindElement(By.Name("RoleId")));
            drpRollId.SelectByValue("2");
            ngDriver.FindElement(By.Name("Email")).SendKeys("admin@mail.com");
            ngDriver.FindElement(By.Name("Mobilephone")).SendKeys("082555");
            Thread.Sleep(2000);
            NgWebElement saveButton = ngDriver.FindElement(By.XPath("/html/body/div[2]/div[3]/button[2]"));
            saveButton.Click();
            
            //clear user
            NgWebElement addUser2 = ngDriver.FindElement(By.XPath("//html/body/table/thead/tr[2]/td/button"));
            addUser2.Click();
            ngDriver.FindElement(By.Name("FirstName")).Clear();
           
            ngDriver.FindElement(By.Name("LastName")).Clear();
            ngDriver.FindElement(By.Name("UserName")).Clear();
          
            ngDriver.FindElement(By.Name("Password")).Clear();
            ngDriver.FindElement(By.Name("Email")).Clear();
            ngDriver.FindElement(By.Name("Mobilephone")).Clear();
            
            //user2
            ngDriver.FindElement(By.Name("FirstName")).SendKeys("FName2");
        
            ngDriver.FindElement(By.Name("LastName")).SendKeys("LName2");
            ngDriver.FindElement(By.Name("UserName")).SendKeys("User2");
           
            ngDriver.FindElement(By.Name("Password")).SendKeys("Pass2"); 
            ngDriver.FindElement(By.XPath("/html/body/div[2]/div[2]/form/table/tbody/tr[5]/td[2]/label[2]/input")).Click();
            SelectElement drpRollId2 = new SelectElement(driver.FindElement(By.Name("RoleId")));
            drpRollId2.SelectByValue("1");
            ngDriver.FindElement(By.Name("Email")).SendKeys("customer@mail.com");
            ngDriver.FindElement(By.Name("Mobilephone")).SendKeys("083444");
            NgWebElement saveButton2 = ngDriver.FindElement(By.XPath("/html/body/div[2]/div[3]/button[2]"));
            saveButton2.Click();
        }

   
    }
}