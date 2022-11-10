using System;
using Sentry.Framework.PageObjects;
using Sentry.Framework.Utils;
using Sentry.Framework.Models;
using SeleniumExtras.WaitHelpers;

namespace Sentry.Framework.Steps
{
    public class ResidenceInformationSteps : SentryFrame
    {
        public static string? emailSaved;
        private ResidenceInformationPage residenceInformationPage = new ResidenceInformationPage();
        private DataInjection data = new DataInjection();


        public void FillResidenceInformation()
        {
            SentryClickJS(residenceInformationPage.requestUserTypeClick);
            SentryClickJS(residenceInformationPage.requestUserTypeLastElementsList);
            emailSaved = data.Email;
            if (SentryElementPresent(residenceInformationPage.otherRequestUserTypeInput))
            {
                SentryWrite(residenceInformationPage.otherRequestUserTypeInput, data.RequestorName);
                SentryWrite(residenceInformationPage.companyNameInput, data.CompanyName);
                SentryWrite(residenceInformationPage.phoneNumberInput, data.PhoneNumber);
                SentryWrite(residenceInformationPage.fullNameInput, data.FullName);
                SentryWrite(residenceInformationPage.emailInput, data.Email);
                SentryScreenshot();
                SentryScroll(residenceInformationPage.addressLineInput);
                SentryWrite(residenceInformationPage.addressLineInput, data.Address);
                SentryWrite(residenceInformationPage.zipCodeInput, data.ZipCode);
                SentryVisibleElementAssert(residenceInformationPage.correctZipCodeValidation);
                SentryHighlightVisible(residenceInformationPage.correctZipCodeValidation);
                SentryConnectDB();
                SentryClickJS(residenceInformationPage.termsAndConditionsCheckbox);
                SentryScreenshot();
                SentryClickJS(residenceInformationPage.nextButton);
                SentryClickJS(residenceInformationPage.addressValidationAssociationClick);
                SentryClickJS(residenceInformationPage.addressValidationAssociationList);
                SentryScreenshot();
                SentryClickJS(residenceInformationPage.addressValidationConfirmButton);
            }
            else
            {
                SentryWrite(residenceInformationPage.companyNameInput, data.CompanyName);
                SentryWrite(residenceInformationPage.phoneNumberInput, data.PhoneNumber);
                SentryWrite(residenceInformationPage.fullNameInput, data.FullName);
                SentryWrite(residenceInformationPage.emailInput, data.Email);
                SentryScreenshot();
                SentryScroll(residenceInformationPage.addressLineInput);
                SentryWrite(residenceInformationPage.addressLineInput, data.Address);
                SentryWrite(residenceInformationPage.zipCodeInput, data.ZipCode);
                SentryVisibleElementAssert(residenceInformationPage.correctZipCodeValidation);
                //SentryExplicitWait().Until(ExpectedConditions.ElementExists(residenceInformationPage.correctZipCodeValidation));
                SentryHighlightVisible(residenceInformationPage.correctZipCodeValidation);
                SentryConnectDB();
                SentryClickJS(residenceInformationPage.termsAndConditionsCheckbox);
                SentryScreenshot();
                SentryClickJS(residenceInformationPage.nextButton);
                SentryClickJS(residenceInformationPage.addressValidationAssociationClick);
                SentryClickJS(residenceInformationPage.addressValidationAssociationList);
                SentryVisibleElementAssert(residenceInformationPage.termsAndConditionsCheckboxActive);
                SentryScreenshot();
                SentryClickJS(residenceInformationPage.addressValidationConfirmButton);
                
            }
        }
    }
}

