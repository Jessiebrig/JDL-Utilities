using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace JDL_Utilities
{
    public class WebDriver
    {
        //Chrome Driver_____
        IWebDriver Chrome;
        public void Load_WebDriver(string Profile_path)
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            //chromeOptions.AddArguments($"--user-data-dir={Profile_path}");
            chromeOptions.AddArguments(new List<string>() {
            $"--user-data-dir={Profile_path}",
            "--silent-launch",
            "--no-startup-window",
            "--no-sandbox",
            "--headless",});

            //

            //ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
            //chromeDriverService.HideCommandPromptWindow = true;    // This is to hidden the console.
            //ChromeDriver driver = new ChromeDriver(chromeDriverService, chromeOptions);
            //driver.Navigate().GoToUrl(url);

            //
            try
            {
                //ChromeOptions options = new ChromeOptions();
                //options.AddArguments("user-data-dir=" + Profile_path);
                //options.AddArguments("--headless");
                //Chrome = new ChromeDriver(options);
                Chrome = new ChromeDriver(chromeOptions);
                Main.LOG("Profile Path: " + Profile_path);
            }
            catch (Exception ex)
            {
                Main.LOG(ex.ToString());
            }
        }
        //

        public string URL;
        public string Myurl;
        public static string value;
        public static string FindElementType;
        public static string ElementMethod;
        public static string Input_T_M_V(string Type, string Method, string value1)
        {
            FindElementType = Type;
            ElementMethod = Method;
            value = value1;
            return FindElementType + ElementMethod + value;
        }
        public string Type_Method_value()
        {
            string Type_Method_value = "FindElement By." + FindElementType + "_" + ElementMethod + "  Value: " + value;
            return Type_Method_value;
        }
        //
        //Navigate_____
        Thread Navig;
        bool loading = true;
        public void Navi(string url)
        {
            loading = true;
            Navig = new Thread(() => {

                Main.LOG("Loading.....");
                Myurl = url; Navigate();
                try { URL = Chrome.Url; } catch (Exception ex) { Main.LOG(ex.ToString()); }
            wait:
                if (loading) { goto wait; }
                Main.LOG("Current URL: " + URL);
            });
            Navig.Start();
            loading = false;
            Main.LOG(Chrome.PageSource);
        }
        public void Navigate()
        {
        Again:
            try { Chrome.Navigate().GoToUrl(Myurl); }
            catch (WebDriverTimeoutException)
            {
                Main.LOG("WebDriver Timeout Exception in Navi()");
                //Thread.Sleep(Rtime());
                goto Again;
            }
            catch (Exception ex)
            {
                Main.LOG(ex.ToString());
            }
        }
        //
        //Find_Button_____
        //public void Find_Start() { Input_T_M_V("XPath", "Find", StartXPath); Find_element("Find_Start"); }

        //public void Find_Expired() { Input_T_M_V("XPath", "Find", ExpiredXPath); Find_element("Find_Expired"); }
        //public void Click_Start() { Input_T_M_V("XPath", "Click", StartXPath); Find_element(null); }
        //
        //Find_element_____
        public void Find_element(string Find)
        {
        Again:
            try
            {
                if (FindElementType == "XPath")
                {
                    Finder(Chrome, Chrome.FindElement(By.XPath(value)));
                    //if (Find == "Find_Start") { Webtext = "Startfound"; }
                    //else if (Find == "Find_Expired") { Webtext = "Expired"; }
                    //if (Find != null) { Main.LOG(Webtext); }
                }
                else if (FindElementType == "Id") { Finder(Chrome, Chrome.FindElement(By.Id(value))); }
                else if (FindElementType == "Name") { Finder(Chrome, Chrome.FindElement(By.Name(value))); }
                else { }
            }
            catch (NoSuchElementException)
            {
                //if (Find == "Find_Start") { Webtext = "Startnotfound"; }
                //else if (Find == "Find_Expired") { Webtext = "NotExpired"; }
                //if (Find != null) { Main.LOG(Webtext); }
            }
            catch (WebDriverTimeoutException)
            {
                Main.LOG("WebDriver Timeout Exception under Find_element()");
                //Thread.Sleep(Rtime());
                goto Again;
            }
            catch (ElementNotInteractableException)
            {
                Main.LOG("Element Not Interactable Exception under Find_element| Will try again after 10 Seconds..");
                //Thread.Sleep(Rtime());
                goto Again;
            }
            catch (UnhandledAlertException)
            {
                Main.LOG("Unhandled Alert Exception Occur_in Find_element");
                //Thread.Sleep(Rtime());
            }
            catch (Exception ex)
            {
                Main.LOG("General Exception under Find_element()");
                Main.LOG(ex.ToString());
            }
        }
        //Finder_____
        public void Finder(IWebDriver chrome, IWebElement element)  //IWebDriver chrome is just reserve
        {
            Main.LOG(Type_Method_value());
            string X = element.Location.X.ToString();
            string Y = element.Location.Y.ToString();
            Main.LOG("Element X Coordinates: " + X + "  |  Element X Coordinates: " + Y);
            try
            {
                if (ElementMethod == "Click") { element.Click(); Main.LOG("Click Successful"); } else { }
            }
            catch (Exception ex)
            {
                Main.LOG("General Exception under Finder()");
                Main.LOG(ex.ToString());
            }
            //Value.Text = value;
        }
    }


}
