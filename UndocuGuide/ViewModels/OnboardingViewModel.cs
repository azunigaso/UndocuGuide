using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using PropertyChanged;
using UndocuGuide.Models;
using UndocuGuide.Views;

namespace UndocuGuide.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class OnboardingViewModel
    {
        public ObservableCollection<Boarding> Boardings { get; set; }
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
        }
    }
}
