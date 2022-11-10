using System;
using OpenQA.Selenium;

namespace Sentry.Framework.PageObjects
{
    public class TransactionDetailsPage
    {
        public By referenceEscrowLoanInput = By.XPath("(//input[@type='text'])[1]");
        public By phoneNumberGetTextValidationInput = By.XPath("(//input[@type='text'])[2]");
        public By emailGetTextValidationInput = By.XPath("(//input[@type='text'])[3]");
        public By purchasePriceInput = By.XPath("//input[@autocomplete and @placeholder]");
        public By dateSelect = By.XPath("//input[@placeholder='Select date']");
        public By nextButton = By.XPath("//button[@class='ant-btn ant-btn-primary ant-btn-lg ng-star-inserted' and not (@disabled)]");

    }
}

