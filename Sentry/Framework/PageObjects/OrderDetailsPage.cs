using System;
using OpenQA.Selenium;

namespace Sentry.Framework.PageObjects
{
    public class OrderDetailsPage
    {
        public By chooseTheDocumentsValidation = By.XPath("//h2[contains(text(),'Choose the Documents and Delivery Option')]");
        public By orderDetailsValidation = By.XPath("//nz-step[@class='ant-steps-item ant-steps-item-process ant-steps-item-active']//div[contains(text(),'Order Details')]");
        public By activeSectionValidation = By.XPath("//nz-step[contains(@class,'ant-steps-item-active')]");
        public By sendEmailToGetText = By.XPath("//label[contains(text(),'@')]");
        public By resaleDemandCertificateInputRadio = By.XPath("(//input[@type='radio'])[2]");
        public By lenderSpecificQuestionnaire = By.XPath("(//input[@type='radio'])[6]");
        public By regularProcessingOption = By.XPath("//div[@class='price-title' and contains(text(),'REGULAR')]");
        public By nextButton = By.XPath("//button[@class='ant-btn ant-btn-primary ant-btn-lg ng-star-inserted' and not (@disabled)]");
        public By continueEmergentButton = By.XPath("//button//span[contains(text(),'Continue')]");
    }
}

