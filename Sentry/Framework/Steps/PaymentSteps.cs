using System;
using Sentry.Framework.PageObjects;
using Sentry.Framework.Utils;

namespace Sentry.Framework.Steps
{
	public class PaymentSteps : SentryFrame
	{
		PaymentPage paymentPage = new PaymentPage();

		public void OrderPayment()
        {
			SentryWrite(paymentPage.addCouponInput, "sentry100");
			SentryClickJS(paymentPage.addCouponButton);
			Console.WriteLine(driver.FindElement(paymentPage.totalValueZeroValidation).Text);
			SentryTextEqualAssert(paymentPage.emailValidation, ResidenceInformationSteps.emailSaved);
			SentryHighlightVisible(paymentPage.emailValidation);
            SentryTextEqualAssert(paymentPage.totalValueZeroValidation, "$ 0.00");
            SentryClickJS(paymentPage.submitButton);
			Console.WriteLine(paymentPage.orderCodeCreatedValidation);
			SentryVisibleElementAssert(paymentPage.iconCreatedOrderValidation);
            SentryTextEqualAssert(paymentPage.emailEnteredValidation, ResidenceInformationSteps.emailSaved);
            //driver.Url = "https://storefront-admin.qa.cpcentral.com/order";
            //SentryTearDown();
        }
    }
}

