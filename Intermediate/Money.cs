using System;
using Xunit;

namespace CSharpDrill.Intermediate
{
    public class MoneyTests
    {
        // Task: Implement implicit conversion from decimal to Money.
        [Fact]
        public void ImplicitConversionFromDecimal_ShouldReturnExpected()
        {
            throw new NotImplementedException();
            //Money money = 42.12m;
            //Assert.Equal(42.12m, money.Amount);
        }

        // Task: Implement explicit conversion from Money to integer.
        [Fact]
        public void ExplicitConversionToInteger_ShouldReturnExpected()
        {
            throw new NotImplementedException();
            //Money money = new Money(42.12m);
            //int amount = (int)money;
            //Assert.Equal(42, amount);
        }

        // Task: Implement implicit conversion from Money to decimal.
        [Fact]
        public void ImplicitConversionToDecimal_ShouldReturnExpected()
        {
            throw new NotImplementedException();
            //Money money = new Money(42.12m);
            //decimal amount = money;
            //Assert.Equal(42.12m, amount);
        }
    }

    public class Money
    {
        public decimal Amount { get; }

        public Money(decimal amount)
        {
            Amount = amount;
        }
    }
}