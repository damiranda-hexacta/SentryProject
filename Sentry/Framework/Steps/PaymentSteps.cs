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
			SentryTextEqualAssert(paymentPage.totalValueZeroValidation, "$ 0.00");
			SentryClickJS(paymentPage.submitButton);
        }
	}
}

