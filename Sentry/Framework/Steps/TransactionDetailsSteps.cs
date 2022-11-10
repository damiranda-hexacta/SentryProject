using System;
using OpenQA.Selenium;
using Sentry.Framework.PageObjects;
using Sentry.Framework.Utils;

namespace Sentry.Framework.Steps
{
    public class TransactionDetailsSteps : SentryFrame
    {

       private TransactionDetailsPage transactionPage = new TransactionDetailsPage();

       public void CompleteTransactionAndCompanyInformation()
        {
            SentryHighlightDatabase(transactionPage.phoneNumberGetTextValidationInput);
            SentryHighlightDatabase(transactionPage.emailGetTextValidationInput);
            SentryWrite(transactionPage.dateSelect, "11/27/2022");
            SentryWrite(transactionPage.dateSelect, Keys.Enter);
            SentryScreenshot();
            SentryClickJS(transactionPage.nextButton);
        }
    }
}

