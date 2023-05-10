namespace TestNavaMVP1
{
    public class UnitTestingModels : IDisposable
    {
        UsersModel usermodel;
      /// <summary>
      ///  This is the constructer of the Register class
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
        /// This is where we are testing our methodes declared in the class 
        /// </summary>

       
    }
}