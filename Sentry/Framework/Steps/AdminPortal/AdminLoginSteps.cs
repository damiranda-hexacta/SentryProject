using System;
using Sentry.Framework.PageObjects.AdminPortal;
using Sentry.Framework.Utils;

namespace Sentry.Framework.Steps.AdminPortal
{
	public class AdminLoginSteps : SentryFrame
    {

		AdminLoginPage adminLoginPage = new AdminLoginPage();

		public void AdminPortalLogin()
		{
			SentryWrite(adminLoginPage.usernameInput, "dmiranda");
            SentryWrite(adminLoginPage.passwordInput, "Password123!");
			SentryClickJS(adminLoginPage.loginButton);
        }
    }
}

