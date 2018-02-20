using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WarGearCalc
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private ObservableCollection<string> careerSelection = new ObservableCollection<String>();
        private Character character;

        public MainPage()
        {
            this.InitializeComponent();
            careerSelection.Add("Archmage");
            careerSelection.Add("Black Guard");
            careerSelection.Add("Black Orc");
            careerSelection.Add("Bright Wizard");
            careerSelection.Add("Choppa");
            careerSelection.Add("Disciple of Khaine");
            careerSelection.Add("Engineer");
            careerSelection.Add("Ironbreaker");
            careerSelection.Add("Knight of the Blazing Sun");
            careerSelection.Add("Magus");
            careerSelection.Add("Marauder");
            careerSelection.Add("Runepriest");
            careerSelection.Add("Shadow Warrior");
            careerSelection.Add("Shaman");
            careerSelection.Add("Sorcerer");
            careerSelection.Add("Squig Herder");
            careerSelection.Add("Sword Master");
            careerSelection.Add("Warrior Priest");
            careerSelection.Add("White Lion");
            careerSelection.Add("Witch Elf");
            careerSelection.Add("Witch Hunter");
            careerSelection.Add("Zealot");
        }

        private async void Test_Button_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("War Gear Calculator");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }

        private void Faction_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            String selectedValue = (String)cmb.SelectedValue;
            Debug.WriteLine("Selected career: " + selectedValue);
            character = new Character(selectedValue);
        }
    }
}
