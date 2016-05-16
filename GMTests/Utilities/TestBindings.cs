using GMAutomation;
using TechTalk.SpecFlow;

namespace GMTests
{
    [Binding]
    public sealed class TestBindings
    {

        [BeforeTestRun]
        public static void TestInitialise()
        {

        }


        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver.Initialise();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Close();
        }
    }
}
