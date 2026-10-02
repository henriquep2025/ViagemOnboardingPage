using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViagemOnboardingPage.Models;

namespace ViagemOnboardingPage.ViewModels
{
    public partial class ViagemOnboardingViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<OnboardingItem> _itens;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsLastPosicao))]
        [NotifyPropertyChangedFor(nameof(ExibirBotao))]
        private int _posicao;

        public bool IsLastPosicao => Posicao == Itens.Count - 1;

        public bool ExibirBotao => !IsLastPosicao;

        public ViagemOnboardingViewModel()
        {
            Itens = new List<OnboardingItem>
            {
                new OnboardingItem
                {
                    Titulo = "Explore Exotic Destinations",
                    Descricao = "Embark on a virtual journey through stunning destinations worldwide.",
                    ImagemUrl = "imagem1.png"
                },
                new OnboardingItem
                {
                    Titulo = "Discover Local Gems",
                    Descricao = "Uncover hidden gems and local favorites recommended by fellow travelers.",
                    ImagemUrl = "imagem2.png"
                },
                new OnboardingItem
                {
                    Titulo = "Plan Your Perfect Trip",
                    Descricao = "Create personalized itineraries tailored to your preferences and interests.",
                    ImagemUrl = "imagem3.png"
                },
                 new OnboardingItem
                {
                    Titulo = "Capture and Share Memories",
                    Descricao = "Preserve your travel memories with our in-app photo and journaling features.",
                    ImagemUrl = "imagem4.png"
                }
            };
        }

        [RelayCommand]
        private void Proximo()
        {
            if (Posicao < Itens.Count - 1)
            {
                Posicao++;
            }
        }
    }
}