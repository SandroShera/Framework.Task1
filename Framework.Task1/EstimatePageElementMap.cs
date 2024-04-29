using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Framework.Task1
{
    public class EstimatePageElementMap
    {
        private readonly WebDriverWait wait;

        public EstimatePageElementMap(WebDriverWait wait)
        {
            this.wait = wait;
        }

        public IWebElement OpenEstimateSummaryButton
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"yDmH0d\"]/div[6]/div[2]/div/div/div/div[1]/a")));
            }
        }
    }
}
