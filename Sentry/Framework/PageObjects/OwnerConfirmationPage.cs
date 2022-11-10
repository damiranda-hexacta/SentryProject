using System;
using OpenQA.Selenium;

namespace Sentry.Framework.PageObjects
{
    public class OwnerConfirmationPage
    {
        public By pleaseConfirmTheOwnerNameValidation = By.XPath("//h3[contains(text(),'Address & Owner Information')]");
        public By activeSectionValidation = By.XPath("//nz-step[contains(@class,'ant-steps-item-active')]");
        public By addressWebGetText = By.XPath("//div[@nzjustify='start']//label[contains(text(),'OLD CLUB')]");
        public By associationNameWebGetText = By.XPath("//label[contains(text(), 'THE FAIRWAYS')]");
        public By ownerNameWebGetText = By.XPath("(//label[not(@class) and text()])[last()]");
        public By isThisCurrentOwnerYesButton = By.XPath("//label[@nz-radio]//span[text()='Yes']");
        public By isThisCurrentOwnerNoButton = By.XPath("//label[@nz-radio]//span[text()='No']");
        public By nextButton = By.XPath("//button[@class='ant-btn ant-btn-primary ant-btn-lg ng-star-inserted' and not (@disabled)]");
        public By previousButton = By.XPath("//button[@class='button-step ant-btn ng-star-inserted' and not (@disabled) ]//span[text()='Previous']");
    }
}

