using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace Framework.Task1
{
    public class EstimatePage
    {
        private readonly IWebDriver browser;
        private readonly WebDriverWait wait;
        private readonly Actions actions;

        public EstimatePage(IWebDriver browser, WebDriverWait wait)
        {
            this.browser = browser;
            this.wait = wait;
            actions = new(this.browser);
        }

        public EstimatePageElementMap Map
        {
            get
            {
                return new EstimatePageElementMap(wait);
            }
        }

        public void ClickOpenEstimateSummaryButton()
        {
            Map.OpenEstimateSummaryButton.Click();
        }
    }
}
