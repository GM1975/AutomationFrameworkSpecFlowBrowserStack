
namespace GMAutomation
{
    public class ReaderPage
    {


        public static bool IsAt()
        {

            string url = Driver.Instance.Url.ToString();

            if (url == "https://wordpress.com/")
            {
                return true;
            }
            return false;

        }
        

    }
}
