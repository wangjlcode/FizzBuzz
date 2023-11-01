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
    }
}