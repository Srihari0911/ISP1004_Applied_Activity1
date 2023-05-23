using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using System;
using System.Collections.Generic;

namespace PasswordApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        private const string CorrectPassword = "Cambrian1400";
        private const int MaxAttempts = 5;
        private int remainingAttempts;

        public MainPage()
        {
            InitializeComponent();
            remainingAttempts = MaxAttempts;
            UpdateAttemptsLabel();
            GeneratePasswordHint();
        }

        private void SubmitButton_Clicked(object sender, EventArgs e)
        {
            string enteredPassword = PasswordEntry.Text;

            if (enteredPassword == CorrectPassword)
            {
                DisplayAlert("Success", "Welcome!", "OK");
            }
            else
            {
                remainingAttempts--;
                UpdateAttemptsLabel();

                if (remainingAttempts > 0)
                {
                    DisplayAlert("Incorrect Password", "Please try again.", "OK");
                }
                else
                {
                    DisplayAlert("Incorrect Password", "You have been locked out.", "OK");
                    SubmitButton.IsEnabled = false;
                }
            }
        }

        private void UpdateAttemptsLabel()
        {
            AttemptsLabel.Text = $"Attempts Remaining: {remainingAttempts}";
        }

        private void GeneratePasswordHint()
        {
            List<string> words = new List<string>()
            {
                "college", "address", "1400", "School"
            };

            Random random = new Random();
            int index1 = random.Next(0, words.Count);
            int index2 = random.Next(0, words.Count);

            string passwordHint = $"{words[index1]} + {words[index2]}";
            PasswordHintLabel.Text = $"Password Hint: {passwordHint}";
        }
    }
}
