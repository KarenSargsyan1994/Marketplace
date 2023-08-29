using Marketplace.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Marketplace.Tests
{
    public class MoneyTest
    {
        private static readonly ICurrencyLookup CurrencyLookup = new FakeCurrencyLookup();

        [Fact]
        public void Money_objects_with_the_same_amount_should_be_equal()
        {
            var firstAmount = Money.FromDecimal(5, "EUR", CurrencyLookup); 
            var secondAmount = Money.FromDecimal(5, "EUR", CurrencyLookup);
            Assert.Equal(firstAmount, secondAmount);
        }

        [Fact]
        public void Sum_of_money_gives_full_amount()
        {
            var coin1 = Money.FromDecimal(1,"USD",CurrencyLookup);
            var coin2 =  Money.FromDecimal(1, "USD", CurrencyLookup); 
            var coin3 = Money.FromDecimal(1, "USD", CurrencyLookup); 
            var banknote = Money.FromDecimal(3, "USD", CurrencyLookup);
            Assert.Equal(banknote, coin1 + coin2 + coin3);
        }

    }
}
