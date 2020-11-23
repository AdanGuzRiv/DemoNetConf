using DemoNetConf.Core.Model;
using DemoNetConf.Core.Mvvm;
using DemoNetConf.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoNetConf.Core.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        
        public MainViewModel()
        {
            
        }

        string nombrePanel;
        public string NombrePanel { get => nombrePanel; set => Set(ref nombrePanel, value); }

        bool showModal;
        public bool ShowModal { get => showModal; set => Set(ref showModal, value); }

        bool stateButton;
        public bool StateButton { get => stateButton; set => Set(ref stateButton, value); }

        string textoModal;
        public string TextoModal { get => textoModal; set => Set(ref textoModal, value); }

        RelayCommand showErrorCommand;
        public RelayCommand ShowErrorCommand
        {
            get => showErrorCommand ?? (showErrorCommand = new RelayCommand(() =>
            {
                TextoModal = "Esto es un modal animado.";
                ShowModal = true;
            }));
        }

        RelayCommand hiddenErrorCommand;
        public RelayCommand HiddenErrorCommand
        {
            get => hiddenErrorCommand ?? (hiddenErrorCommand = new RelayCommand(() =>
            {
                TextoModal = string.Empty;
                ShowModal = false;
            }));
        }
        RelayCommand<string> showPanelsCommand;
        public RelayCommand<string> ShowPanelsCommand
        {
            get => showPanelsCommand ?? (showPanelsCommand = new RelayCommand<string>((obj) =>
            {
                switch (obj)
                {
                    case "Login":
                        NombrePanel = ExtensionMethods.EnumToString(Panels.Login);
                        break;
                    case "Email":
                        NombrePanel = ExtensionMethods.EnumToString(Panels.Email);
                        break;
                    case "CodigoSeguridad":
                        NombrePanel = ExtensionMethods.EnumToString(Panels.Registrar);
                        break;                    
                }
            }));
        }
    }
}
