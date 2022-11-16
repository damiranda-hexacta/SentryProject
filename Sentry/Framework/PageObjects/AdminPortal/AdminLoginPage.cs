using System;
using OpenQA.Selenium;

namespace Sentry.Framework.PageObjects.AdminPortal
{
	public class AdminLoginPage
	{
        public By usernameInput = By.Id("Input_Username");
        public By passwordInput = By.Id("Input_Password");
        public By loginButton = By.Name("Input.Button");
    }
}

