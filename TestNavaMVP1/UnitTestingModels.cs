namespace TestNavaMVP1
{
    public class UnitTestingModels : IDisposable
    {
        UsersModel usermodel;
      /// <summary>
      ///  This is the constructer of the Login class
      /// </summary>
        public UnitTestingModels()
        {
            // setup the test
            usermodel = new UsersModel();

        }
        public void Dispose()
        {
            //Close down your test
            //close the databse
        }

        /// <summary>
        /// This is where we are testing our methodes declared in the class login
        /// </summary>

        [Fact]
        public void TestingEmailValidity()
        {
            //Arrange
            var UserEmail = "iradukunda@Finc.com";
            //Act
            var isemail = usermodel.IsEmail(UserEmail);
            //Assert
            Assert.True(isemail);
        }

        [Fact]
        public void TestingConfirmedEmail()
        {
            //Arrange
            var confirmedEmail = "iradukunda@Finc.com";
            //Act
            var isconfirmedemail = usermodel.IsConfirmedEmail(confirmedEmail);
            //Assert
            Assert.True(isconfirmedemail);
        }

        [Fact]
        public void TestUsername ()
        {
            //Arrange
            var username = "Irene";
            //Act
            var isusername = usermodel.IsUserName(username);
            //Assert
            Assert.True(isusername);
        }

        [Fact]
        public void TestPassword()
        {
            //Arrange
            var password = "Apples";
            //Act
            var ispassword = usermodel.IsPassword(password);
            //Assert
            Assert.True(ispassword);
        }

        [Fact]
        public void TestConfirmPassword()
        {
            //Arrange
            var confirmpassowrd = "Apples";
            //Act
            var isconfirmpassword = usermodel.IsConfirmedPassword(confirmpassowrd);
            //Assert
            Assert.True(isconfirmpassword); 
        }

        [Fact]
        public void TestIsEmailSameAsConfirmedEmail()
        {
            //Arrange
            var email = "Iradukunda@FINC.com";
            var confirmemail = "Iradukunda@FINC.com";
            //Act
            var isemailsameasconfirmedemail = usermodel.IsEmailSameAsConfirmedEmail(email, confirmemail);
            //Assert
            Assert.True(isemailsameasconfirmedemail);
        }

        [Fact]
        public void TestIsPasswordSameAsConfirmedPassword()
        {
            //Arrange
            var password = "Apples";
            var confirmpassword = "Apples";
            //Act
            var ispasswordsameasconfirmedpassword = usermodel.IsPasswordSameAsConfirmedPassowrd(password, confirmpassword);
            //Assert
            Assert.True(ispasswordsameasconfirmedpassword);
        }
    }
}