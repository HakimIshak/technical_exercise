using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TechnicalExercise
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver("C:/Driver/");
        }

        [Test]
        public void VerifyPrice()
        {
            // Arrange
            driver.Navigate().GoToUrl("https://www.amazon.com/");

            // Waiting Strategy
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Act
            IWebElement searchBox = driver.FindElement(By.Id("twotabsearchtextbox"));
            wait.Until(d => searchBox.Displayed);
            searchBox.SendKeys("Laptop");


            IWebElement searchButton = driver.FindElement(By.Id("nav-search-submit-button"));
            searchButton.Click();

            IWebElement containerResult = driver.FindElement(By.CssSelector("[data-index='2']"));
            IWebElement results = containerResult.FindElement(By.CssSelector("a.a-link-normal.s-no-outline"));
            wait.Until(d => results.Displayed);
            results.Click();

            IWebElement priceElement = driver.FindElement(By.CssSelector(".a-price-whole"));
            wait.Until(d => priceElement.Displayed);

            string priceText = priceElement.Text;
            decimal priceValue = decimal.Parse(priceText.Replace("$", "").Trim());

            // Assert
            Assert.That(priceValue, Is.GreaterThan(MaximumAllowedPrice));

            driver.Quit();
        }
        private const decimal MaximumAllowedPrice = 100.0M;

    }
}
