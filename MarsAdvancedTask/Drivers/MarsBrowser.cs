using MarsAdvancedTask.Driver;
using Microsoft.AspNetCore.Hosting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvancedTask.Drivers
{
    public class MarsBroswer: MarsDriver
    {
        private IWebDriver driver;

        public MarsBroswer(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string MarsBroswerGetScreenShot()
        {
            Thread.Sleep(200);
            var file = ((ITakesScreenshot)driver).GetScreenshot();
            var img = file.AsBase64EncodedString;

            return img;
        }
    }
}