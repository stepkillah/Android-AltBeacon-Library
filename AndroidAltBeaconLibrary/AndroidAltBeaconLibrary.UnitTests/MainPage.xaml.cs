using Microsoft.Maui.Controls;

namespace AndroidAltBeaconLibrary.UnitTests
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnRunTestsClicked(object sender, EventArgs e)
        {
            RunTestsButton.IsEnabled = false;
            RunTestsButton.Text = "Running Tests...";
            ResultsLabel.Text = "Executing tests, please wait...";

            try
            {
                var testRunner = new XunitTestRunner();
                var results = await Task.Run(() => testRunner.RunTests());

                ResultsLabel.Text = results;
            }
            catch (Exception ex)
            {
                ResultsLabel.Text = $"Error running tests: {ex.Message}";
            }
            finally
            {
                RunTestsButton.IsEnabled = true;
                RunTestsButton.Text = "Run Tests";
            }
        }
    }
}