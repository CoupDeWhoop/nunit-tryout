using FizzBuzz;

namespace FizzBuzz.Test;

public class FizzBuzzTests
{
        [Test]
        public void Generate_ReturnsFizz_WhenNumberIsDivisibleBy3()
        {
            var generator = new FizzBuzzGenerator();
            var actual = generator.Generate(3);
            Assert.That(actual, Is.EqualTo("Fizz"));
        }

        [Test]
        public void Generate_ReturnsBuzz_WhenNumberIsDivisibleBy5()
        {
            var generator = new FizzBuzzGenerator();
            var result = generator.Generate(5);
            Assert.AreEqual("Buzz", result);
        }

        [Test]
        public void Generate_ReturnsFizzBuzz_WhenNumberIsDivisibleBy15()
        {
            var generator = new FizzBuzzGenerator();
            var result = generator.Generate(15);
            Assert.AreEqual("FizzBuzz", result);
        }
}