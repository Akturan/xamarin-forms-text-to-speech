using System;
using AVFoundation;
using TextToSpeech.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(TextToSpeech_iOS))]
namespace TextToSpeech.iOS
{
    public class TextToSpeech_iOS : ITextToSpeech
    {
        public void Speak(string text)
        {
            var speechSynthesizer = new AVSpeechSynthesizer();

            var speechUtterance = new AVSpeechUtterance(text)
            {
                Rate = AVSpeechUtterance.MaximumSpeechRate / 2,
                Voice = AVSpeechSynthesisVoice.FromLanguage("en-US"),
                Volume = 1f,
                PitchMultiplier = 1.0f
            };

            speechSynthesizer.SpeakUtterance(speechUtterance);

        }
    }
}
