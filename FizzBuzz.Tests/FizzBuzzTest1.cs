using System;
using Xunit;
using Fizz.Buzz;

namespace Fizz.Buzz.Tests
{
    public class FizzBuzzTest1
    {
        private readonly FizzBuzz _fizzBuzz;

        public FizzBuzzTest1() 
        {
            _fizzBuzz = new FizzBuzz();
        }

        [Fact]
        public void ShouldPrintNumber()
        {
            Assert.Equal("1", _fizzBuzz.GetFizzBuzz(1));
            Assert.Equal("2", _fizzBuzz.GetFizzBuzz(2));
            Assert.Equal("4", _fizzBuzz.GetFizzBuzz(4));
        }

        [Fact]
        public void ShouldPrintFizz()
        {
            Assert.Equal("fizz", _fizzBuzz.GetFizzBuzz(3));
            Assert.Equal("fizz", _fizzBuzz.GetFizzBuzz(6));
            Assert.Equal("fizz", _fizzBuzz.GetFizzBuzz(9));
        }

        [Fact]
        public void ShouldPrintBuzz()
        {
            Assert.Equal("buzz", _fizzBuzz.GetFizzBuzz(5));
            Assert.Equal("buzz", _fizzBuzz.GetFizzBuzz(10));
        }

        [Fact]
        public void ShouldPrintFizzBuzz()
        {
            Assert.Equal("fizzbuzz", _fizzBuzz.GetFizzBuzz(3 * 5));
            Assert.Equal("fizzbuzz", _fizzBuzz.GetFizzBuzz(2 * 3 * 5));
        }
    }
}
