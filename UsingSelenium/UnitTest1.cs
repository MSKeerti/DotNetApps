using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace UsingSelenium
{
    public class HomePage
    {
        private IWebDriver _driver;

        [FindsBy(How = How.Name, Using = "q")]
        private IWebElement _searchtxtbox;

        [FindsBy(How = How.Name, Using = "btnK")]
        private IWebElement _searchbtn;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div/img")]
        public IWebElement _logo;

        [FindsBy(How = How.XPath, Using = "//*[@id='gbwa']/div/a")]
        public IWebElement _apps;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Search(string searchText)
        {
            _searchtxtbox.SendKeys(searchText);
            _searchtxtbox.Submit();
            //_searchbtn.Click();
            Thread.Sleep(2000);
        }
        public void Test2()
        {
            _driver = new ChromeDriver();
            HomePage hp = new HomePage(_driver);
            _driver.Navigate().GoToUrl("https://google.com");
            Thread.Sleep(2000);

            Assert.NotNull(hp._logo);
            hp.Search("Selenium");
            Thread.Sleep(2000);
            Assert.True(_driver.Title.Contains("Selenium"));
        }


    }

    public class UnitTest1
    {
        [Fact]
        public void Simple_Site_Test()
        {
            //Open Google Chrome: Install Google Chrome Driver for Selenium
            //Browse to https://google.com 
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://google.com");
            Thread.Sleep(2000);
            IWebElement element = driver.FindElement(By.Name("q"));
            Assert.NotNull(element); //test case

            element.SendKeys("Selenium");
            driver.FindElement(By.XPath("//body")).Click();
            Thread.Sleep(1000);

            IWebElement btnSearch = driver.FindElement(By.Name("btnK"));
            Assert.NotNull(btnSearch);
            btnSearch.Click(); //similar to clicking button
            Thread.Sleep(2000);

            IWebElement link = driver.FindElement(By.XPath("//*[@id='rso']/div[1]/div/div/div/div/div/div/div/div[1]/div/span/a/h3"));
            Assert.Contains(link.Text, "Selenium");
            link.Click();

            //IWebElement linkText = driver.FindElement(By.LinkText("Selenium"));
            //Assert.NotNull(linkText);

            //type the word "selenium' in the search textbox:: Find() [Locators]
            //click search : Find() & Click Search
            //In the result-set, find the first link and click it
            //browse to clicked link 
        }
        
    }
}