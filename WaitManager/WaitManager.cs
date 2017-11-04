using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WaitManager
{
    public sealed class WaitManager
    {
        private IWebDriver Driver;
        private WebDriverWait Wait;
        private IWebElement Element;
        private int waitingTime = 0;

        public int WaitingTime
        {
            get
            {
                return waitingTime;
            }
            set
            {
                if (value >= 0)
                    waitingTime = value;
            }
        }

        public WaitManager(IWebDriver driver)
        {
            this.Driver = driver;
            this.WaitingTime = 5;
            this.Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(this.WaitingTime));
        }

        public void ElementIsVisible(By locator)
        {
            Element = Wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public void ElementIsClickable(By locator)
        {
            Element = Wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }
    }
}
