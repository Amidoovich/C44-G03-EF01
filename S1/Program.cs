using S1.Context;
namespace S1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CompanyG01DBContext dbContext = new CompanyG01DBContext();
            //try
            //{
            //    //Some Code
            //}
            //finally
            //{
            //    dbContext.Dispose();
            //}

            //using(CompanyG01DBContext dbContext = new CompanyG01DBContext())
            //{
            //    // some code
            //}

            using CompanyG01DBContext dbContext = new CompanyG01DBContext();
        }
    }
}
