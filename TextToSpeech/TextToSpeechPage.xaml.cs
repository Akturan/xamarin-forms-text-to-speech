using Xamarin.Forms;

namespace TextToSpeech
{
    public partial class TextToSpeechPage : ContentPage
    {
        public TextToSpeechPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DependencyService.Get<ITextToSpeech>().Speak("Hello from Xamarin Forms");
        }
    }
}
