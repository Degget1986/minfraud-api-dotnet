﻿using MaxMind.MinFraud.Response;
using Newtonsoft.Json.Linq;
using Xunit;

namespace MaxMind.MinFraud.UnitTest.Response
{
    public class CreditCardTest
    {
        [Fact]
        public void TestCreditCard()
        {
            var cc = new JObject
            {
                {
                    "issuer",
                    new JObject
                    {
                        {"name", "Bank"}
                    }
                },
                {
                    "brand", "Visa"
                },
                {
                    "country",
                    "US"
                },
                {
                    "is_business",
                    true
                },
                {
                    "is_issued_in_billing_address_country",
                    true
                },
                {
                    "is_prepaid",
                    true
                },
                {
                    "is_virtual",
                    true
                },
                {
                    "type", "credit"
                }
            }.ToObject<CreditCard>()!;

            Assert.Equal("Bank", cc.Issuer.Name);
            Assert.Equal("US", cc.Country);
            Assert.True(cc.IsBusiness);
            Assert.True(cc.IsPrepaid);
            Assert.True(cc.IsIssuedInBillingAddressCountry);
            Assert.True(cc.IsVirtual);
            Assert.Equal("Visa", cc.Brand);
            Assert.Equal("credit", cc.Type);
        }
    }
}
