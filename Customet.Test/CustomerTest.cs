using CSharpPractice;
namespace CSharpPractice
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameValidTest()
        {
            // arrange
            Customer customer = new Customer()
            {
                firstName = "Parthiv",
                LastName = "Hirani"
            };
            string expected = "Parthiv Hirani";

            // act
            string actual = "Parthiv Hirani";

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Validatevalid()
        {
            // arrange
            var Customer = new Customer()
            {
                LastName = "Hirani",
                email = "parthivhirani@gmail.com"
            };
            var expected = true;

            // act
            var actual = Customer.Validate();

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]

        public void ValidateMissingLastName()
        {
            // arrange
            var customer = new Customer()
            {
                email = "parthivhirani@gmail.com"
            };
            var expected = false;

            // act
            var actual = customer.Validate();

            // assert
            Assert.Equal(expected, actual);
        }
        // act
        // assert

    }
}

    