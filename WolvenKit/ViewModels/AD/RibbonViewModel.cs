﻿using Catel;
using Catel.IoC;
using Catel.MVVM;
using Catel.Reflection;
using Catel.Services;
using MLib.Interfaces;
using Orc.Theming;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Orc.ProjectManagement;

namespace WolvenKit.ViewModels
{
    using Commands;
    using Services;
    using Common.Services;
    public class RibbonViewModel : ViewModel
    {
        #region fields
        private readonly ILoggerService _loggerService;
        private readonly IProjectManager _projectManager;
        private readonly INavigationService _navigationService;
        private readonly IUIVisualizerService _uiVisualizerService;
        private readonly ISettingsManager _settingsManager;
        #endregion

        #region constructors
        public RibbonViewModel(
            ISettingsManager settingsManager,
            IProjectManager projectManager,
            ILoggerService loggerService,
            INavigationService navigationService,
            IUIVisualizerService uiVisualizerService
            )
        {
            Argument.IsNotNull(() => loggerService);
            Argument.IsNotNull(() => navigationService);
            Argument.IsNotNull(() => uiVisualizerService);
            Argument.IsNotNull(() => projectManager);
            Argument.IsNotNull(() => settingsManager);

            _projectManager = projectManager;
            _loggerService = loggerService;
            _navigationService = navigationService;
            _uiVisualizerService = uiVisualizerService;
            _settingsManager = settingsManager;

            Command1 = new RelayCommand(RunCommand1, CanRunCommand1);
            ViewSelectedCommand = new DelegateCommand<object>(ExecuteViewSelected, CanViewSelected);


            var assembly = AssemblyHelper.GetEntryAssembly();
            Title = assembly.Title();

        }
        #endregion

        #region properties

        public enum ERibbonContextualTabGroupVisibility
        {
            Collapsed,
            Visible,
        }

        public ERibbonContextualTabGroupVisibility ProjectExplorerContextualTabGroupVisibility { get; set; }
        public string ProjectExplorerContextualTabGroupVisibilityStr =>
            ProjectExplorerContextualTabGroupVisibility.ToString();

        /// <summary>
        /// Dependency Property on RibbonView
        /// </summary>
        public List<string> ListOfThemes => new List<string>()
        {
            "Dark.Red", "Dark.Green", "Dark.Blue",
            "Dark.Purple", "Dark.Orange", "Dark.Lime",
            "Dark.Emerald", "Dark.Teal", "Dark.Cyan",
            "Dark.Cobalt", "Dark.Indigo", "Dark.Violet",
            "Dark.Pink", "Dark.Magenta", "Dark.Crimson",
            "Dark.Amber", "Dark.Yellow", "Dark.Brown",
            "Dark.Olive", "Dark.Steel", "Dark.Mauve",
            "Dark.Taupe", "Dark.Sienna"
        };

        private string _selectedTheme;
        /// <summary>
        /// Dependency Property on RibbonView
        /// </summary>
        public string SelectedTheme
        {
            get => _selectedTheme;
            set
            {
                if (_selectedTheme != value)
                {
                    var oldValue = _selectedTheme;
                    _selectedTheme = value;
                    RaisePropertyChanged(() => SelectedTheme, oldValue, value);
                }
            }
        }




        #endregion

        #region commands

        /// <summary>
        /// Is raised when a PaneView is selected: shows the contextual ribbon tab
        /// </summary>
        public ICommand ViewSelectedCommand { get; private set; }
        private bool CanViewSelected(object view) => true;
        private void ExecuteViewSelected(object viewmodel)
        {
            if (!(viewmodel is Tuple<PaneViewModel, bool> tuple)) return;

            if (tuple.Item1 is ProjectExplorerViewModel)
                ProjectExplorerContextualTabGroupVisibility = tuple.Item2
                    ? ERibbonContextualTabGroupVisibility.Visible
                    : ERibbonContextualTabGroupVisibility.Collapsed;
        }

        public ICommand Command1 { get; }
        private bool CanRunCommand1() => true;
        private void RunCommand1()
        {

        }
        #endregion

        #region methods
        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            // TODO: Write initialization code here and subscribe to events
            var commandManager = ServiceLocator.Default.ResolveType<ICommandManager>();
            commandManager.RegisterCommand(AppCommands.Application.ViewSelected, ViewSelectedCommand, this);
        }

        protected override Task CloseAsync()
        {
            // TODO: Unsubscribe from events

            return base.CloseAsync();
        }
        #endregion
    }
}