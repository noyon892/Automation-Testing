using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Usbangla
{
    class Program
    {
        static string url = "https://us-banglaairlines.com/welcome";
        static IWebDriver driver = new ChromeDriver();
        static string actualtitle = "US-Bangla Airlines";
        static void Main(string[] args)
        {
            if (TC_01_CheckLoadingofThePage())
            {
                Console.WriteLine("TC_01_CheckLoadingofThePage: Passed");
            }

            else
                Console.WriteLine("TC_01_CheckLoadingofThePage: Failed");


            if (TC_02())
            {
                Console.WriteLine("TC_02: Our_Company_link Passed");
            }

            else
                Console.WriteLine("TC_02:Our_Company_link  Failed");


            if (TC_03())
            {
                Console.WriteLine("TC_03:Contact_Us_link Passed");
            }

            else
                Console.WriteLine("TC_03:Contact_Us_link  Failed");


            if (TC_04())
            {
                Console.WriteLine("TC_04:Agent_Login_link Passed");
            }

            else
                Console.WriteLine("TC_04:Agent_Login_link  Failed");


            if (TC_05())
            {
                Console.WriteLine("TC_05:Agent_Login_button Passed");
            }

            else
                Console.WriteLine("TC_05:Agent_Login_button  Failed");



            if (TC_06())
            {
                Console.WriteLine("TC_06:Login_invalid_domain Passed");
            }

            else
                Console.WriteLine("TC_06:Login_invalid_domain Failed");



            if (TC_07())
            {
                Console.WriteLine("TC_07:Registration_link Passed");
            }

            else
                Console.WriteLine("TC_07:Registration_link Failed");


            if (TC_08())
            {
                Console.WriteLine("TC_08:login_link_inRegPage Passed");
            }

            else
                Console.WriteLine("TC_08:login_link_inRegPage Failed");
            

            //if (TC_09())
            //{
            //    Console.WriteLine("TC_09:Where we fly link Passed");
            //}

            //else
            //    Console.WriteLine("TC_09:Where we fly link Failed");

            driver.Navigate().GoToUrl(url);

            if (TC_10())
            {
                Console.WriteLine("TC_10:Flight Route Map link Passed");
            }

            else
                Console.WriteLine("TC_10:Flight ROute Map link Failed");


            driver.Navigate().GoToUrl(url);

            if (TC_11())
            {
                Console.WriteLine("TC_11:Flight Schedule link Passed");
            }

            else
                Console.WriteLine("TC_11:Flight Schedule link Failed");

            driver.Navigate().GoToUrl(url);

            if (TC_12())
            {
                Console.WriteLine("TC_12:Sales Offices link Passed");
            }

            else
                Console.WriteLine("TC_12:Sales Offices link Failed");

            driver.Navigate().GoToUrl(url);
            if (TC_13())
            {
                Console.WriteLine("TC_13:Tour Package link Passed");
            }

            else
                Console.WriteLine("TC_13:Tour Package link Failed");

            driver.Navigate().GoToUrl(url);

            if (TC_14())
            {
                Console.WriteLine("TC_14:Contact us link Passed");
            }

            else
                Console.WriteLine("TC_14:Contact us link Failed");

            driver.Navigate().GoToUrl(url);

            if (TC_15())
            {
                Console.WriteLine("TC_15:Travel Guideline link Passed");
            }

            else
                Console.WriteLine("TC_15:Travel Guideline link Failed");



            if (TC_16())
            {
                Console.WriteLine("TC_16:Ticket Outlets link Passed");
            }

            else
                Console.WriteLine("TC_16:Ticket Outlets link Failed");


            if (TC_17())
            {
                Console.WriteLine("TC_17:Sky Star link Passed");
            }

            else
                Console.WriteLine("TC_17:Sky Star link Failed");

            if (TC_18())
            {
                Console.WriteLine("TC_18:Route Map link Passed");
            }

            else
                Console.WriteLine("TC_18:Route Map link Failed");

            if (TC_19())
            {
                Console.WriteLine("TC_19:Fare Chart link Passed");
            }

            else
                Console.WriteLine("TC_19:Fare Chart link Failed");


            if (TC_20())
            {
                Console.WriteLine("TC_20:Domestic Package link Passed");
            }

            else
                Console.WriteLine("TC_20:Domestic Package link Failed");



            if (TC_21())
            {
                Console.WriteLine("TC_21:International Packages link Passed");
            }

            else
                Console.WriteLine("TC_21:International Packages link Failed");


            if (TC_22())
            {
                Console.WriteLine("TC_22:BUS Services link Passed");
            }

            else
                Console.WriteLine("TC_22:BUS Services link Failed");


            if (TC_23())
            {
                Console.WriteLine("TC_23:Air charter link Passed");
            }

            else
                Console.WriteLine("TC_23:Air charter link Failed");


            if (TC_24())
            {
                Console.WriteLine("TC_24:Prohibited Items link Passed");
            }

            else
                Console.WriteLine("TC_24:Prohibited Items link Failed");


            if (TC_25())
            {
                Console.WriteLine("TC_25:Career link Passed");
            }

            else
                Console.WriteLine("TC_25:Career link Failed");


            if (TC_26())
            {
                Console.WriteLine("TC_26:Feedback link Passed");
            }

            else
                Console.WriteLine("TC_26:Feedback link Failed");


            if (TC_27())
            {
                Console.WriteLine("TC_18:Baggage Info link Passed");
            }

            else
                Console.WriteLine("TC_18:Baggage Info link Failed");

        }

        static public bool TC_01_CheckLoadingofThePage()
        {
            driver.Navigate().GoToUrl(url);
            string windowTitle = driver.Title;
            driver.FindElement(By.Id("cboxClose")).Click();

            if (actualtitle == windowTitle)
            {
                return true;
            }

            else
                return false;

        }

        static public bool TC_02()
        {
           Thread.Sleep(5000);
            driver.FindElement(By.LinkText("Our Company")).Click();

            string pageTitle = driver.FindElement(By.XPath("//*[@class='content our_company']")).FindElement(By.CssSelector("dl")).FindElement(By.CssSelector("dt")).Text;
            

            if (pageTitle == "Our Company")
                return true;
            else
                return false;
        }

        static public bool TC_03()
        {
            Thread.Sleep(5000);
            driver.FindElement(By.LinkText("Contact Us")).Click();

            string pageTitle = driver.FindElement(By.ClassName("contact-us-title")).Text;


            if (pageTitle == "Customer Support")
                return true;
            else
                return false;
        }


        static public bool TC_04()
        {
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@class='top_menu pull-right']")).FindElement(By.CssSelector("ul")).FindElements(By.CssSelector("li")).ElementAt(0).Click();
            //driver.FindElement(By.LinkText("Agent Login | ")).Click();

            
            string pageTitle = driver.FindElement(By.ClassName("breadcrumb")).FindElements(By.CssSelector("li")).ElementAt(2).Text;


            if (pageTitle == "Agent Login")
                return true;
            else
                return false;
        }


        static public bool TC_05()
        {
            Thread.Sleep(5000); 
            driver.FindElement(By.XPath("//*[@class='btn btn-danger']")).Click();


            string pageTitle = driver.FindElement(By.ClassName("form-horizontal")).FindElement(By.CssSelector("h3")).Text;


            if (pageTitle == "Log in as travel agency")
                return true;
            else
                return false;
        }
        
        static public bool TC_06()
        {
            Thread.Sleep(5000);
            IWebElement userTextBox = driver.FindElement(By.Id("LoginLog"));
            userTextBox.Clear();
            userTextBox.SendKeys("abcd123");
            IWebElement passwordTextBox = driver.FindElement(By.Id("LoginPwd"));
            passwordTextBox.Clear();
            passwordTextBox.SendKeys("123dcba");
            Thread.Sleep(3000);
            driver.FindElement(By.Id("Submit1")).Click();

            string pageTitle = driver.FindElement(By.XPath("//*[@class='alert alert-danger alert-dismissible']")).FindElement(By.CssSelector("p")).Text;


            if (pageTitle == "Incorrect login or password")
                return true;
            else
                return false;
        }



        static public bool TC_07()
        {
            Thread.Sleep(5000);
            //driver.FindElement(By.XPath("//*[@class='row create-agency-link-block']")).Click();
            driver.FindElement(By.LinkText("Create a new profile")).Click();

            string pageTitle = driver.FindElement(By.ClassName("form-horizontal")).FindElement(By.CssSelector("h3")).Text;


            if (pageTitle == "Create a new travel agency profile")
                return true;
            else
                return false;
        }


        static public bool TC_08()
        {
            Thread.Sleep(5000);
            //driver.FindElement(By.XPath("//*[@class='row create-agency-link-block']")).Click();
            driver.FindElement(By.LinkText("Login with an existing profile")).Click();

            string pageTitle = driver.FindElement(By.ClassName("form-horizontal")).FindElement(By.CssSelector("h3")).Text;


            if (pageTitle == "Log in as travel agency")
                return true;
            else
                return false;
        }

        
        static public bool TC_09()
        {

            Thread.Sleep(5000);
            driver.FindElement(By.Id("nav")).FindElements(By.CssSelector("li")).ElementAt(0).FindElement(By.CssSelector("a")).Click();
            

            string pageTitle = driver.FindElement(By.ClassName("breadcrumb")).FindElements(By.CssSelector("li")).ElementAt(1).Text;


            if (pageTitle == "About Us")
                return true;
            else
                return false;
        }



        static public bool TC_10()
        {

            Thread.Sleep(5000);
            driver.FindElement(By.ClassName("nav")).FindElements(By.CssSelector("li")).ElementAt(0).Click();
            

            string pageTitle = driver.FindElement(By.ClassName("breadcrumb")).FindElements(By.CssSelector("li")).ElementAt(1).Text;


            if (pageTitle == "About Us")
                return true;
            else
                return false;
        }

        

        static public bool TC_11()
        {

            Thread.Sleep(5000);
            driver.FindElement(By.ClassName("nav")).FindElements(By.CssSelector("li")).ElementAt(1).Click();
            

            string pageTitle = driver.FindElement(By.ClassName("breadcrumb")).FindElements(By.CssSelector("li")).ElementAt(2).Text;


            if (pageTitle == "Flight Schedule")
                return true;
            else
                return false;
        }




        static public bool TC_12()
        {

            Thread.Sleep(5000);
            driver.FindElement(By.ClassName("nav")).FindElements(By.CssSelector("li")).ElementAt(2).Click();


            string pageTitle = driver.FindElement(By.ClassName("breadcrumb")).FindElements(By.CssSelector("li")).ElementAt(2).Text;


            if (pageTitle == "Ticket Outlets")
                return true;
            else
                return false;
        }


        static public bool TC_13()
        {

            Thread.Sleep(5000);
            driver.FindElement(By.ClassName("nav")).FindElements(By.CssSelector("li")).ElementAt(3).Click();


            string pageTitle = driver.FindElement(By.ClassName("breadcrumb")).FindElements(By.CssSelector("li")).ElementAt(2).Text;


            if (pageTitle == "Book Hotel And Tour Package")
                return true;
            else
                return false;
        }


        static public bool TC_14()
        {

            Thread.Sleep(5000);
            driver.FindElement(By.ClassName("nav")).FindElements(By.CssSelector("li")).ElementAt(4).Click();


            string pageTitle = driver.FindElement(By.ClassName("breadcrumb")).FindElements(By.CssSelector("li")).ElementAt(1).Text;


            if (pageTitle == "Contact Us")
                return true;
            else
                return false;
        }

        static public bool TC_15()
        {

            Thread.Sleep(5000);
            driver.FindElement(By.Id("nav")).FindElements(By.CssSelector("li")).ElementAt(6).FindElements(By.CssSelector("a")).ElementAt(0).Click();

            string pageTitle = driver.FindElement(By.ClassName("breadcrumb")).FindElements(By.CssSelector("li")).ElementAt(2).Text;

            if (pageTitle == "Baggage Info")
                return true;
            else
                return false;
        }


        static public bool TC_16()
        {

            Thread.Sleep(5000);
            driver.FindElement(By.Id("nav")).FindElements(By.CssSelector("li")).ElementAt(10).FindElements(By.CssSelector("a")).ElementAt(0).Click();

            string pageTitle = driver.FindElement(By.ClassName("breadcrumb")).FindElements(By.CssSelector("li")).ElementAt(2).Text;

            if (pageTitle == "Ticket Outlets")
                return true;
            else
                return false;
        }



        static public bool TC_17()
        {

            Thread.Sleep(5000);
            driver.FindElement(By.Id("nav")).FindElements(By.CssSelector("li")).ElementAt(14).FindElements(By.CssSelector("a")).ElementAt(0).Click();

            string pageTitle = driver.FindElement(By.ClassName("breadcrumb")).FindElements(By.CssSelector("li")).ElementAt(2).Text;

            if (pageTitle == "Become a Sky Star")
                return true;
            else
                return false;
        }



        static public bool TC_18()
        {

            Thread.Sleep(5000);
            driver.FindElement(By.Id("nav")).FindElements(By.CssSelector("li")).ElementAt(0).FindElements(By.CssSelector("a")).ElementAt(0).Click();

            string pageTitle = driver.FindElement(By.ClassName("breadcrumb")).FindElements(By.CssSelector("li")).ElementAt(2).Text;

            if (pageTitle == "Route Map")
                return true;
            else
                return false;
        }



        static public bool TC_19()
        {

            Thread.Sleep(5000);
            driver.FindElement(By.LinkText("Fare Chart")).Click();

            string pageTitle = driver.FindElement(By.ClassName("breadcrumb")).FindElements(By.CssSelector("li")).ElementAt(2).Text;

            if (pageTitle == "Fare Chart")
                return true;
            else
                return false;
        }



        static public bool TC_20()
        {

            Thread.Sleep(5000);
            driver.FindElement(By.LinkText("Domestic Packages")).Click();

            string pageTitle = driver.FindElement(By.ClassName("breadcrumb")).FindElements(By.CssSelector("li")).ElementAt(2).Text;

            if (pageTitle == "Domestic Package")
                return true;
            else
                return false;
        }
        

        static public bool TC_21()
        {

            Thread.Sleep(5000);
            driver.FindElement(By.LinkText("International Packages")).Click();

            string pageTitle = driver.FindElement(By.ClassName("breadcrumb")).FindElements(By.CssSelector("li")).ElementAt(2).Text;

            if (pageTitle == "International Packages")
                return true;
            else
                return false;
        }



        static public bool TC_22()
        {

            Thread.Sleep(5000);
            driver.FindElement(By.LinkText("BUS Services")).Click();

            string pageTitle = driver.FindElement(By.ClassName("breadcrumb")).FindElements(By.CssSelector("li")).ElementAt(1).Text;

            if (pageTitle == "Services & Guideline")
                return true;
            else
                return false;
        }


        static public bool TC_23()
        {

            Thread.Sleep(5000);
            driver.FindElement(By.LinkText("Air charter")).Click();

            string pageTitle = driver.FindElement(By.ClassName("breadcrumb")).FindElements(By.CssSelector("li")).ElementAt(2).Text;

            if (pageTitle == "Air Charter")
                return true;
            else
                return false;
        }



        static public bool TC_24()
        {

            Thread.Sleep(5000);
            driver.FindElement(By.LinkText("Prohibited Items")).Click();

            string pageTitle = driver.FindElement(By.ClassName("breadcrumb")).FindElements(By.CssSelector("li")).ElementAt(2).Text;

            if (pageTitle == "Prohibited Items")
                return true;
            else
                return false;
        }


        static public bool TC_25()
        {

            Thread.Sleep(5000);
            driver.FindElement(By.LinkText("Career")).Click();

            string pageTitle = driver.FindElement(By.ClassName("breadcrumb")).FindElements(By.CssSelector("li")).ElementAt(1).Text;

            if (pageTitle == "Career")
                return true;
            else
                return false;
        }



        static public bool TC_26()
        {

            Thread.Sleep(5000);
            driver.FindElement(By.LinkText("Feedback")).Click();

            string pageTitle = driver.FindElement(By.ClassName("breadcrumb")).FindElements(By.CssSelector("li")).ElementAt(1).Text;

            if (pageTitle == "Share Your Experience")
                return true;
            else
                return false;
        }



        static public bool TC_27()
        {

            Thread.Sleep(5000);
            driver.FindElement(By.LinkText("Baggage Info")).Click();

            string pageTitle = driver.FindElement(By.ClassName("breadcrumb")).FindElements(By.CssSelector("li")).ElementAt(2).Text;

            if (pageTitle == "Baggage Info")
                return true;
            else
                return false;
        }
    }
}
