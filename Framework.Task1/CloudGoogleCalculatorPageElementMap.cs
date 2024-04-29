using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace WebDriver.Task3
{
    public class CloudGoogleCalculatorPageElementMap
    {
        private readonly WebDriverWait wait;

        public CloudGoogleCalculatorPageElementMap(WebDriverWait wait)
        {
            this.wait = wait;
        }

        public IWebElement AddEstimateButton
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"ucj-1\"]/div/div/div/div/div/div/div/div[1]/div/div[1]/div/div/div/button")));
            }
        }

        public IWebElement ComputeEngineButton
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#yDmH0d > div.bwApif-Sx9Kwc.bwApif-Sx9Kwc-OWXEXe-vOE8Lb.bwApif-Sx9Kwc-OWXEXe-di8rgd-bN97Pc-QFlW2.mDH3Wc.bwApif-Sx9Kwc-OWXEXe-FNFY6c > div.bwApif-wzTsW > div > div > div > div.wrzENe > div > div > div:nth-child(1) > div > div > div")));
            }
        }

        public IWebElement NumberOfInstancesInput
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"c11\"]")));
            }
        }

        public IWebElement MachineTypeDropdownExpandButton
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"ow4\"]/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[11]/div/div/div[2]/div/div[1]/div[3]/div/div/div/div[1]/div")));
            }
        }

        public IWebElement N1Standart8Core
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"ow4\"]/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[11]/div/div/div[2]/div/div[1]/div[3]/div/div/div/div[2]/ul/li[7]")));
            }
        }

        public IWebElement AddGpusSwitch
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"ow4\"]/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[21]/div/div/div[1]/div/div/span/div/button/div/span[1]")));
            }
        }

        public IWebElement GpuModelDropdown
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"ow4\"]/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[23]/div/div[1]/div/div/div/div[1]/div")));
            }
        }

        public IWebElement TeslaV100
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"ow4\"]/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[23]/div/div[1]/div/div/div/div[2]/ul/li[3]")));
            }
        }

        public IWebElement LocalSsdDropdown
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"ow4\"]/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[27]/div/div[1]/div/div/div/div[1]/div")));
            }
        }

        public IWebElement Ssd2x375
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"ow4\"]/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[27]/div/div[1]/div/div/div/div[2]/ul/li[3]")));
            }
        }

        public IWebElement RegionDropdown
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"ucj-1\"]/div/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[29]/div/div[1]/div/div/div/div[1]/div")));
            }
        }

        public IWebElement CommitedUsage1Year
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"ow4\"]/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[31]/div/div/div[2]/div/div/div[2]")));
            }
        }

        public IWebElement CalculatedPrice
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[text()=\"Compute\"]/following-sibling::label[contains(@text, \"\")]")));
            }
        }

        public IWebElement RegionFrankfurt
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#ucj-1 > div > div > div > div > div > div > div > div.kyx3Tb.AlLELb > div > div.vHartc > div.U4lDT > div:nth-child(29) > div > div.YgByBe > div > div > div > div.VfPpkd-xl07Ob-XxIAqe.VfPpkd-xl07Ob-XxIAqe-OWXEXe-tsQazb.VfPpkd-xl07Ob.VfPpkd-YPmvEd.IWDrLe.VfPpkd-xl07Ob-XxIAqe-OWXEXe-FNFY6c > ul > li.MCs1Pd.UbEQCe.VfPpkd-OkbHre.VfPpkd-OkbHre-SfQLQb-M1Soyc-bN97Pc.VfPpkd-aJasdd-RWgCYc-wQNmvb.UdwDKc.VfPpkd-rymPhb-ibnC6b.VfPpkd-rymPhb-ibnC6b-OWXEXe-SfQLQb-M1Soyc-Bz112c.VfPpkd-rymPhb-ibnC6b-OWXEXe-SfQLQb-Woal0c-RWgCYc.VfPpkd-rymPhb-ibnC6b-OWXEXe-gk6SMd")));
            }
        }

        public IWebElement ShareButton
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"ow4\"]/div/div/div/div/div/div/div[2]/div[1]/div/div[4]/div[2]/div[2]/div/button")));
            }
        }
    }
}