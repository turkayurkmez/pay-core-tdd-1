using FizzBuzz.Game;

namespace FizzBuzz.Tests
{
    public class UnitTest1
    {
        /* Behavior Driven Development (BDD)
         *  
         * Ben bir [Rol] olarak,
         * Bir [Talep - İşlev] yapmak istiyorum
         * Böylelikle [SONUÇ] elde ediyorum
         * 
         * 
         * User Story:
         * 
         * Ben bir oyuncu olarak
         * 3 Sayısı verdiğimde Fizz sonucunu elde etmek istiyorum
         * Böylelikle oyun sırası tamamlanır.
         */

        //1. İhtiyaç duyduğunuz obje ya da metotlar var mı?

        //[Fact]
        //public void ItExists()
        //{
        //    var gameBoard = new FizzBuzz.Game.GameBoard();
        //    int number = 0;
        //    string response = gameBoard.GetWordOrNumber(number);

        //}


        [Fact]
        public void Given_3_Then_Fizz()
        {
            //AAA pattern
            /*
             *  Arrange: bu test için gereken nesneler ve değerler. 
             *  Act: Test edeceğiniz işlev
             *  Assert: Beklediğiniz sonuç(lar)
             */
            //Arrange:
            GameBoard gameBoard = new GameBoard();
            //Act:
            string result = gameBoard.GetWordOrNumber(3);
            //Assert:
            Assert.Equal("Fizz", result);


        }

        [Fact]
        public void Given_5_Then_Buzz()
        {
            //AAA pattern
            /*
             *  Arrange: bu test için gereken nesneler ve değerler. 
             *  Act: Test edeceğiniz işlev
             *  Assert: Beklediğiniz sonuç(lar)
             */
            //Arrange:
            GameBoard gameBoard = new GameBoard();
            //Act:
            string result = gameBoard.GetWordOrNumber(5);
            //Assert:
            Assert.Equal("Buzz", result);


        }


        [Fact]
        public void Given_15_Then_FizzBuzz()
        {
            //AAA pattern
            /*
             *  Arrange: bu test için gereken nesneler ve değerler. 
             *  Act: Test edeceğiniz işlev
             *  Assert: Beklediğiniz sonuç(lar)
             */
            //Arrange:
            GameBoard gameBoard = new GameBoard();
            //Act:
            string result = gameBoard.GetWordOrNumber(15);
            //Assert:
            Assert.Equal("FizzBuzz", result);


        }

        [Theory]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        public void Given_Multiply_3_Then_Fizz(int value)
        {
            //AAA pattern
            /*
             *  Arrange: bu test için gereken nesneler ve değerler. 
             *  Act: Test edeceğiniz işlev
             *  Assert: Beklediğiniz sonuç(lar)
             */
            //Arrange:
            GameBoard gameBoard = new GameBoard();
            //Act:
            string result = gameBoard.GetWordOrNumber(value);
            //Assert:
            Assert.Equal("Fizz", result);



        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        public void Given_Number_Then_NumberString(int value)
        {
            //AAA pattern
            /*
             *  Arrange: bu test için gereken nesneler ve değerler. 
             *  Act: Test edeceğiniz işlev
             *  Assert: Beklediğiniz sonuç(lar)
             */
            //Arrange:
            GameBoard gameBoard = new GameBoard();
            //Act:
            string result = gameBoard.GetWordOrNumber(value);
            //Assert:
            Assert.Equal(value.ToString(), result);


        }

        [Theory]
        [InlineData(30)]
        [InlineData(45)]
        [InlineData(60)]
        public void Given_Muliply_15_Then_NumberString(int value)
        {
            //AAA pattern
            /*
             *  Arrange: bu test için gereken nesneler ve değerler. 
             *  Act: Test edeceğiniz işlev
             *  Assert: Beklediğiniz sonuç(lar)
             */
            //Arrange:
            GameBoard gameBoard = new GameBoard();
            //Act:
            string result = gameBoard.GetWordOrNumber(value);
            //Assert:
            Assert.Equal("FizzBuzz", result);


        }
    }


}