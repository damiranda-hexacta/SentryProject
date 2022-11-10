using System;
using OpenQA.Selenium;

namespace Sentry.Framework.PageObjects
{
    public class ResidenceInformationPage
    {
        public By activeSectionValidation = By.XPath("//nz-step[contains(@class,'ant-steps-item-active')]");
        public By requestUserTypeClick = By.XPath("//nz-select");
        public By requestUserTypeElementsList = By.XPath("//nz-option-item[@title]");
        public By requestUserTypeLastElementsList = By.XPath("(//nz-option-item[@title])[2]");
        public By otherRequestUserTypeInput = By.CssSelector("input[placeholder='Requestor Name']");
        public By companyNameInput = By.CssSelector("input[placeholder='Company Name']");
        public By phoneNumberInput = By.CssSelector("input[placeholder='Phone Number']");
        public By fullNameInput = By.CssSelector("input[placeholder='Full Name']");
        public By emailInput = By.CssSelector("input[placeholder='Email']");
        public By addressLineInput = By.CssSelector("input[placeholder='Address Line 1']");
        public By zipCodeInput = By.CssSelector("input[placeholder='ZIP Code']");
        public By correctZipCodeValidation = By.XPath("//nz-form-item-feedback-icon[@class='ant-form-item-feedback-icon ng-star-inserted ant-form-item-feedback-icon-success']");
        public By termsAndConditionsCheckbox = By.CssSelector("input[type='checkbox']");
        public By termsAndConditionsCheckboxActive = By.CssSelector("span[class='ant-checkbox ant-checkbox-checked']");
        public By addressValidationAssociationClick = By.XPath("//div[@name='fullWidth']//span[@ref='eContracted']");
        public By addressValidationAssociationList = By.XPath("(//input[@type='radio'])[last()]");
        public By addressValidationConfirmButton = By.XPath("//button[@class='ant-btn ant-btn-primary ng-star-inserted']//span[text()='Confirm']");
        public By nextButton = By.XPath("//button[@class='ant-btn ant-btn-primary ant-btn-lg ng-star-inserted' and not (@disabled)]");

    }
}

