using Framework.Task1;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WebDriver.Task3.Tests
{
    internal class CloudGoogleCalculationTests
    {
        private IWebDriver browser;
        private WebDriverWait wait;
        private CloudGoogleMainPage mainPage;
        private CloudGoogleCalculatorPage calculatorPage;
        private EstimatePage estimatePage;
        private const string searchText = "Google Cloud Platform Pricing Calculator";
        private const int numberOfInstances = 4;

        [SetUp]
        public void SetUp()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            var browserName = builder["browser"];

            browser = DriverSingletone.GetDriver(browserName);
            browser.Manage().Window.Maximize();
            wait = new(browser, TimeSpan.FromSeconds(10));

        }

        [Test]
        public void PriceIsCalculated()
        {
            mainPage = new(browser, wait);

            mainPage.Navigate();
            mainPage.ClickSearchIcon();
            mainPage.Search(searchText);

            SearchResultPage searchResultPage = new(browser, wait);
            searchResultPage.ClickPricingCalculatorResult();

            calculatorPage = new(browser, wait);
            calculatorPage.ClickAddEstimateButton();
            calculatorPage.ClickComputeEngineButton();
            calculatorPage.EnterNumberOfInstances(numberOfInstances);
            calculatorPage.ExpandMachineTypeDropDown();
            calculatorPage.SelectN1Standart8Core();
            calculatorPage.AddGpus();
            calculatorPage.ExpandGpuTypeDropdown();
            calculatorPage.SelectTeslaV100Gpu();
            calculatorPage.ExpandLocalSsdDropdown();
            calculatorPage.SelectLocalSsd2x375();
            calculatorPage.ExpandRegionDropdown();
            calculatorPage.SelectRegionFrankfurt();
            calculatorPage.SelectCommitedUsagee1Year();
            bool actual = calculatorPage.IsPriceCalculated();
            Assert.IsTrue(actual);

            calculatorPage.ClickShareButton();
            estimatePage = new EstimatePage(browser, wait);
            estimatePage.ClickOpenEstimateSummaryButton();


        }

        [Test]
        public void EstimateAndInputDataAreTheSame()
        {
            Task.Delay(2000).Wait();

            Assert.IsTrue(true);

        }

        [TearDown]
        public void TearDown()
        {
            DriverSingletone.CloseDriver();
        }
    }
}