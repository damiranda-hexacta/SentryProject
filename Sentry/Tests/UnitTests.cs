using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Sentry.Framework.Utils;
using Sentry.Framework.Steps;
using Xunit;
using Sentry.Framework.Steps.AdminPortal;

namespace Sentry.Tests
{
    public class UnitTests
    {

        ResidenceInformationSteps residenceSteps = new ResidenceInformationSteps();
        OwnerConfirmationSteps ownerSteps = new OwnerConfirmationSteps();
        OrderDetailsSteps orderDetailsSteps = new OrderDetailsSteps();
        TransactionDetailsSteps transactionSteps = new TransactionDetailsSteps();
        PaymentSteps paymentSteps = new PaymentSteps();
        AdminLoginSteps adminLoginSteps = new AdminLoginSteps();

        [Fact]
        public void Test1()
        {
            residenceSteps.FillResidenceInformation();
            ownerSteps.ConfirmOwnerInformation();
            orderDetailsSteps.ChooseDocumentsAndDeliveryOption();
            transactionSteps.CompleteTransactionAndCompanyInformation();
            paymentSteps.OrderPayment();
            adminLoginSteps.AdminPortalLogin();
        }

        
    }

}

