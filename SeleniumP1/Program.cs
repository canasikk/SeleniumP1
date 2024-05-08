using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumP1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new FirefoxDriver();

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.amazon.com.tr/");

            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("zx6r");
            driver.FindElement(By.Id("nav-search-submit-button")).SendKeys(Keys.Enter);

            Thread.Sleep(2500);
            driver.FindElement(By.XPath("//*[@id=\"search\"]/div[1]/div[1]/div/span[1]/div[1]/div[6]/div/div/span/div/div/div[2]/div[1]/h2/a")).Click();

            Thread.Sleep(2500);
            driver.FindElement(By.Id("add-to-cart-button")).Click();

            Thread.Sleep(2500);
            driver.FindElement(By.XPath("//*[@id=\"sw-gtc\"]/span/a")).Click();

            Thread.Sleep(2500);
            driver.FindElement(By.XPath("//*[@id=\"sc-buy-box-ptc-button\"]")).Click();





        }
    }
}
