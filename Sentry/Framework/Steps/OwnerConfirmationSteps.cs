using System;
using Sentry.Framework.PageObjects;
using Sentry.Framework.Utils;

namespace Sentry.Framework.Steps
{
    public class OwnerConfirmationSteps : SentryFrame
    {

        OwnerConfirmationPage ownerPage = new OwnerConfirmationPage();
        
        public void ConfirmOwnerInformation()
        {
            SentryVisibleElementAssert(ownerPage.pleaseConfirmTheOwnerNameValidation);
            SentryHighlightDatabase(ownerPage.addressWebGetText);
            SentryHighlightDatabase(ownerPage.associationNameWebGetText);
            SentryHighlightDatabase(ownerPage.ownerNameWebGetText);
            SentryScreenshot();
            SentryClickJS(ownerPage.nextButton);
        }
    }

}

