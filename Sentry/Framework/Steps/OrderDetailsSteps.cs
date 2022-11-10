using System;
using Sentry.Framework.PageObjects;
using Sentry.Framework.Utils;

namespace Sentry.Framework.Steps
{
    public class OrderDetailsSteps : SentryFrame
    {
        OrderDetailsPage orderDetailsPage = new OrderDetailsPage();

        public void ChooseDocumentsAndDeliveryOption()
        {
            SentryVisibleElementAssert(orderDetailsPage.orderDetailsValidation);
            SentryVisibleElementAssert(orderDetailsPage.chooseTheDocumentsValidation);
            SentryVisibleElementAssert(orderDetailsPage.activeSectionValidation);
            SentryClickJS(orderDetailsPage.lenderSpecificQuestionnaire);
            SentryClickJS(orderDetailsPage.regularProcessingOption);
            SentryScreenshot();
            SentryScroll(orderDetailsPage.sendEmailToGetText);
            SentryTextEqualAssert(orderDetailsPage.sendEmailToGetText, ResidenceInformationSteps.emailSaved);
            SentryHighlightVisible(orderDetailsPage.sendEmailToGetText);
            SentryScreenshot();
            SentryClickJS(orderDetailsPage.nextButton);
        }
    }

}

