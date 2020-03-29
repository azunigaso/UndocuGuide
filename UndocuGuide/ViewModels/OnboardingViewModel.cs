using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using PropertyChanged;
using UndocuGuide.Models;
using UndocuGuide.Views;
using Xamarin.Forms;

namespace UndocuGuide.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class OnboardingViewModel
    {
        public ObservableCollection<Boarding> Boardings { get; set; }
        public int PositionIndex { get; set; }
        public string NextButtonText 
        {
            get 
            {
                if (PositionIndex == Boardings.Count - 1)
                    return "Done";
                return "Next";
            }
        }
        public ICommand NextCommand { get; set; }
        public ICommand SkipCommand { get; set; }
        public OnboardingViewModel() {
            Boardings = new ObservableCollection<Boarding>
            {
                new Boarding(){
                    ImagePath = "onboarding1.svg",
                    Header = "Sample Header 1",
                    Content = "Sample text for first onboarding!",
                    CarouselItem = new WalkthroughItemPage()
                },
                new Boarding(){
                    ImagePath = "onboarding1.svg",
                    Header = "Sample Header 1",
                    Content = "Sample text for first onboarding!",
                    CarouselItem = new WalkthroughItemPage()
                },
                new Boarding(){
                    ImagePath = "onboarding1.svg",
                    Header = "Sample Header 1",
                    Content = "Sample text for first onboarding!",
                    CarouselItem = new WalkthroughItemPage()
                },
                new Boarding(){
                    ImagePath = "onboarding1.svg",
                    Header = "Sample Header 1",
                    Content = "Sample text for first onboarding!",
                    CarouselItem = new WalkthroughItemPage()
                },
            };

            foreach (var boarding in Boardings) {
                boarding.CarouselItem.BindingContext = boarding;
            }

            NextCommand = new Command(Next);
            SkipCommand = new Command(StartMainPage);
        }
        private void StartMainPage() 
        {
            Application.Current.MainPage = new MainPage();
        }
        private void Next(object obj) 
        {
            if (PositionIndex < Boardings.Count - 1)
            {
                PositionIndex++;
            }
            else 
            {
                StartMainPage();
            }
        }
    }
}
