using FizzBuzz;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzGameTest
    {
        [Fact]
        public void Should_return_original_number_given_normal_case_number_when_CountOff()
        {
            //given
            int number = 1;
            //when
            string result = FizzBuzzGame.CountOff(number);
            //then
            Assert.Equal(result, number.ToString());
        }

        [Fact]
        public void Should_return_Fizz_given_3_multiple_number_when_CountOff()
        {
            //given
            int number = 3;
            //when
            string result = FizzBuzzGame.CountOff(number);
            //then
            Assert.Equal(result, "Fizz");
        }

    }
}