using CoreFramework.Config;
using OpenQA.Selenium;
using System;
using System.Diagnostics;
using System.Threading;
using static CoreFramework.Enumerations.Enums;

namespace CoreFramework.BrowserConfig
{
    internal class BrowserSession
    {
        private static ThreadLocal<IWebDriver> _threadDriver = new ThreadLocal<IWebDriver>();

        private static readonly object _lock = new object();

        private static string browserType = Browser.chrome.ToString();

        static BrowserSession()
        {
        }

        public static IWebDriver OpenBrowser()
        {
            lock (_lock)
            {
                _threadDriver.Value = InitBrowser.InitializeDriver(browserType);
                return _threadDriver.Value;
            }
        }

        public static IWebDriver driver
        {
            get { return _threadDriver.Value; }
        }
        
        public static void GoToDesiredUrl()
        {
            string Url = JsonConfig.GetJsonValue("BaseUrl");
            try
            {
                var driver = _threadDriver.Value;
                driver.Navigate().GoToUrl(Url);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public static void KillBrowser()
        {
            Process[] AllProcesses = Process.GetProcesses();
            foreach (var process in AllProcesses)
            {
                if (process.MainWindowTitle != "")
                {
                    string s = process.ProcessName.ToLower();
                    if (s == "iexplore" || s == "iexplorer" || s == "" || s == "firefox")
                        process.Kill();
                }
            }
        }
       
        public static void QuitBrowser()
        {

            if (_threadDriver.Value != null)
            {
                _threadDriver.Value.Close();
                _threadDriver.Value.Quit();
            }
        }
    }
}
