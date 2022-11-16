using System;
using OpenQA.Selenium;

namespace Sentry.Framework.PageObjects
{
    public class PaymentPage
    {
        public By addCouponInput = By.CssSelector("input[type='text']");
        public By addCouponButton = By.XPath("//button//span[text()='Add Coupon']");
        public By totalValueZeroValidation = By.XPath("//nz-list-item[@class='total ant-list-item']//span[@class='value ng-star-inserted']");
        public By emailValidation = By.XPath("//label[@class='mail text-wrap']");
        public By submitButton = By.XPath("//button[@class='ant-btn ant-btn-primary ant-btn-lg ng-star-inserted' and not (@disabled)]");
        public By iconCreatedOrderValidation = By.XPath("//i[@class='anticon ng-star-inserted']");
        public By emailEnteredValidation = By.XPath("//span[@class='ng-star-inserted']//a");
        public By orderCodeCreatedValidation = By.XPath("//div[@class='ant-result-title ng-star-inserted']");
    }
}

