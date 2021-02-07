﻿using Catel.IoC;
using Catel.Logging;
using Catel.Reflection;
using Catel.Windows;
using Orc.Squirrel;
using Orchestra.Services;
using Orchestra.Views;
using System.Windows;
using WolvenKit.Views;
using Catel.MVVM;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using WolvenKit.ViewModels;
using WolvenKit.Views.Dialogs;
using NodeNetwork;
using System.Windows.Media;
using MLib.Interfaces;
using HandyControl.Controls.SplashWindow;

namespace WolvenKit
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region fields
        #endregion fields

        #region constructors
        static App()
        {


         



        }

        /// <summary>
        /// Class constructor
        /// </summary>
        public App()
        {

        }
        #endregion constructors



        private static readonly ILog Log = LogManager.GetCurrentClassLogger();

        protected override async void OnStartup(StartupEventArgs e)
        {
#if DEBUG
            LogManager.AddDebugListener();
#endif
            Log.Info("Starting application");

            var uri = new Uri("pack://application:,,,/WolvenKit.Resources;component/Resources/Images/git.png");

            await SquirrelHelper.HandleSquirrelAutomaticallyAsync();


            var serviceLocator = ServiceLocator.Default;


            // Register Viewmodels
            var viewModelLocator = ServiceLocator.Default.ResolveType<IViewModelLocator>();
            viewModelLocator.NamingConventions.Add("WolvenKit.ViewModels");

            //TODO: rename later to MainViewModel



            // ---- HeadCategory : ProjectView
            //-- Category : ProjectView
            viewModelLocator.Register(typeof(Views.MainView), typeof(ViewModels.WorkSpaceViewModel));

            //-- Category : AssetBrowser
            viewModelLocator.Register(typeof(Views.AssetBrowser.AssetBrowserView), typeof(ViewModels.AssetBrowser.AssetBrowserViewModel));

            //-- Category : CodeEditor
            viewModelLocator.Register(typeof(Views.CodeEditor.CodeEditorView), typeof(ViewModels.CodeEditor.CodeEditorViewModel));

            //-- Category : PluginManager
            viewModelLocator.Register(typeof(Views.PluginManager.PluginManagerView), typeof(ViewModels.PluginManager.PluginManagerViewModel));

            //-- Category : VisualEditor
            viewModelLocator.Register(typeof(Views.VisualEditor.VisualEditorView), typeof(ViewModels.VisualEditor.VisualEditorViewModel));



            // ---- HeadCategory : FluentBackstage
            //-- Category : Backstage
            viewModelLocator.Register(typeof(Views.OpenFileView), typeof(ViewModels.OpenFileViewModel));
            viewModelLocator.Register(typeof(Views.RecentlyUsedItemsView), typeof(ViewModels.RecentlyUsedItemsViewModel));

            //-- Category : Homepage 
            viewModelLocator.Register(typeof(Views.HomePage.HomePageView), typeof(ViewModels.HomePage.HomePageViewModel));
            viewModelLocator.Register(typeof(Views.HomePage.TopicView), typeof(ViewModels.HomePage.TopicViewModel));
            viewModelLocator.Register(typeof(Views.HomePage.Pages.AboutPageView), typeof(ViewModels.HomePage.Pages.AboutPageViewModel));
            viewModelLocator.Register(typeof(Views.HomePage.Pages.GithubPageView), typeof(ViewModels.HomePage.Pages.GithubPageViewModel));
            viewModelLocator.Register(typeof(Views.HomePage.Pages.RecentProjectView), typeof(ViewModels.HomePage.Pages.RecentProjectViewModel));           
            viewModelLocator.Register(typeof(Views.HomePage.Pages.WikiPageView), typeof(ViewModels.HomePage.Pages.WikiPageViewModel));
            viewModelLocator.Register(typeof(Views.HomePage.Pages.WelcomePageView), typeof(ViewModels.HomePage.Pages.WelcomePageViewModel));
            viewModelLocator.Register(typeof(Views.HomePage.Pages.WebsitePageView), typeof(ViewModels.HomePage.Pages.WebsitePageViewModel));
            viewModelLocator.Register(typeof(Views.HomePage.Pages.SettingsPageView), typeof(ViewModels.HomePage.Pages.SettingsPageViewModel));
            viewModelLocator.Register(typeof(Views.HomePage.Pages.UserPageView), typeof(ViewModels.HomePage.Pages.UserPageViewModel));


            //-- Category : Integrated Tools
            viewModelLocator.Register(typeof(Views.HomePage.Pages.IntegratedToolsPageView), typeof(ViewModels.HomePage.Pages.IntegratedToolsPageViewModel));
            viewModelLocator.Register(typeof(Views.IntegratedToolsPages.CyberCAT.CyberCATPageView), typeof(ViewModels.IntegratedToolsPages.CyberCAT.CyberCATPageViewModel));



            //-- Category : Settings Pages 
            viewModelLocator.Register(typeof(Views.SettingsPages.GeneralSettingsView), typeof(ViewModels.SettingsPages.GeneralSettingsViewModel));
            viewModelLocator.Register(typeof(Views.SettingsPages.SubPages.General.GlobalSubSettingsView), typeof(ViewModels.SettingsPages.SubPages.General.GlobalSubSettingsViewModel));
            viewModelLocator.Register(typeof(Views.SettingsPages.SubPages.General.AccountSubSettingsView), typeof(ViewModels.SettingsPages.SubPages.General.AccountSubSettingsViewModel));
            viewModelLocator.Register(typeof(Views.SettingsPages.SubPages.General.UpdatesSubSettingsView), typeof(ViewModels.SettingsPages.SubPages.General.UpdatesSubSettingsViewModel));
            viewModelLocator.Register(typeof(Views.SettingsPages.SubPages.General.ThemeSubSettingsView), typeof(ViewModels.SettingsPages.SubPages.General.ThemeSubSettingsViewModel));
            viewModelLocator.Register(typeof(Views.SettingsPages.SubPages.General.LoggingSubSettingsView), typeof(ViewModels.SettingsPages.SubPages.General.LoggingSubSettingsViewModel));
            // - Tools
            viewModelLocator.Register(typeof(Views.SettingsPages.ToolSettingsView), typeof(ViewModels.SettingsPages.ToolSettingsViewModel));
            viewModelLocator.Register(typeof(Views.SettingsPages.SubPages.Tool.AssetBrowserSubSettingsView), typeof(ViewModels.SettingsPages.SubPages.Tool.AssetBrowserSubSettingsViewModel));
            viewModelLocator.Register(typeof(Views.SettingsPages.SubPages.Tool.CodeEditorSubSettingsView), typeof(ViewModels.SettingsPages.SubPages.Tool.CodeEditorSubSettingsViewModel));
            viewModelLocator.Register(typeof(Views.SettingsPages.SubPages.Tool.PluginManagerSubSettingsView), typeof(ViewModels.SettingsPages.SubPages.Tool.PluginManagerSubSettingsViewModel));
            viewModelLocator.Register(typeof(Views.SettingsPages.SubPages.Tool.VisualEditorSubSettingsView), typeof(ViewModels.SettingsPages.SubPages.Tool.VisualEditorSubSettingsViewModel));
            // - Editor
            viewModelLocator.Register(typeof(Views.SettingsPages.EditorSettingsView), typeof(ViewModels.SettingsPages.EditorSettingsViewModel));
            viewModelLocator.Register(typeof(Views.SettingsPages.SubPages.Editor.GeneralSubSettingsView), typeof(ViewModels.SettingsPages.SubPages.Editor.GeneralSubSettingsViewModel));
            viewModelLocator.Register(typeof(Views.SettingsPages.SubPages.Editor.CompatibilitySubSettingsView), typeof(ViewModels.SettingsPages.SubPages.Editor.CompatibilitySubSettingsViewModel));
            // - Packaging
            viewModelLocator.Register(typeof(Views.SettingsPages.PackagingSettingsView), typeof(ViewModels.SettingsPages.PackagingSettingsViewModel));
            // - Integrations
            viewModelLocator.Register(typeof(Views.SettingsPages.IntegrationsSettingsView), typeof(ViewModels.SettingsPages.IntegrationsSettingsViewModel));


            // ---- HeadCategory : Wizards
            //-- Category : UserWizard
            viewModelLocator.Register(typeof(Views.Wizards.UserWizardView), typeof(ViewModels.Wizards.UserWizardViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.UserWizard.UserWizardPageView), typeof(ViewModels.Wizards.WizardPages.UserWizard.UserWizardPageViewModel));

            //-- Category : ThemeWizard
            viewModelLocator.Register(typeof(Views.Wizards.ThemeWizardView), typeof(ViewModels.Wizards.ThemeWizardViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.ThemeWizard.ThemeWizardPageView), typeof(ViewModels.Wizards.WizardPages.ThemeWizard.ThemeWizardPageViewModel));

            //-- Category : ProjectWizard
            viewModelLocator.Register(typeof(Views.Wizards.ProjectWizardView), typeof(ViewModels.Wizards.ProjectWizardViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.ProjectWizard.SelectProjectTypeView), typeof(ViewModels.Wizards.WizardPages.ProjectWizard.SelectProjectTypeViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.ProjectWizard.ProjectConfigurationView), typeof(ViewModels.Wizards.WizardPages.ProjectWizard.ProjectConfigurationViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.ProjectWizard.FinalizeSetupView), typeof(ViewModels.Wizards.WizardPages.ProjectWizard.FinalizeSetupViewModel));

            //-- Category : PublishWizard
            viewModelLocator.Register(typeof(Views.Wizards.PublishWizardView), typeof(ViewModels.Wizards.PublishWizardViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.PublishWizard.RequiredSettingsView), typeof(ViewModels.Wizards.WizardPages.PublishWizard.RequiredSettingsViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.PublishWizard.OptionalSettingsView), typeof(ViewModels.Wizards.WizardPages.PublishWizard.OptionalSettingsViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.PublishWizard.FinalizeSetupView), typeof(ViewModels.Wizards.WizardPages.PublishWizard.FinalizeSetupViewModel));

            //-- Category : FirstSetupWizard 
            viewModelLocator.Register(typeof(Views.Wizards.FirstSetupWizardView), typeof(ViewModels.Wizards.FirstSetupWizardViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.FirstSetupWizard.CreateUserView), typeof(ViewModels.Wizards.WizardPages.FirstSetupWizard.CreateUserViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.FirstSetupWizard.SelectThemeView), typeof(ViewModels.Wizards.WizardPages.FirstSetupWizard.SelectThemeViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.FirstSetupWizard.SetInitialPreferencesView), typeof(ViewModels.Wizards.WizardPages.FirstSetupWizard.SetInitialPreferencesViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.FirstSetupWizard.LocateGameDateView), typeof(ViewModels.Wizards.WizardPages.FirstSetupWizard.LocateGameDataViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.FirstSetupWizard.FinalizeSetupView), typeof(ViewModels.Wizards.WizardPages.FirstSetupWizard.FinalizeSetupViewModel));

            //-- Category : FeedBackWizard 
            viewModelLocator.Register(typeof(Views.Wizards.FeedbackWizardView), typeof(ViewModels.Wizards.FeedbackWizardViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.FeedbackWizard.RateView), typeof(ViewModels.Wizards.WizardPages.FeedbackWizard.RateViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.FeedbackWizard.SendView), typeof(ViewModels.Wizards.WizardPages.FeedbackWizard.SendViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.FeedbackWizard.ReviewView), typeof(ViewModels.Wizards.WizardPages.FeedbackWizard.ReviewViewModel));


            //-- Category : InstallerWizard 
            viewModelLocator.Register(typeof(Views.Wizards.InstallerWizardView), typeof(ViewModels.Wizards.InstallerWizardViewModel));

            //-- Category : BugReportWizard 
            viewModelLocator.Register(typeof(Views.Wizards.BugReportWizard), typeof(ViewModels.Wizards.BugReportWizardViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.BugReportWizard.AttachBugView), typeof(ViewModels.Wizards.WizardPages.BugReportWizard.AttachBugViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.BugReportWizard.DescribeBugView), typeof(ViewModels.Wizards.WizardPages.BugReportWizard.DescribeBugViewModel));
            viewModelLocator.Register(typeof(Views.Wizards.WizardPages.BugReportWizard.SendBugView), typeof(ViewModels.Wizards.WizardPages.BugReportWizard.SendBugViewModel));


            var viewLocator = ServiceLocator.Default.ResolveType<IViewLocator>();
            viewLocator.Register(typeof(ViewModels.SettingsViewModel), typeof(Views.SettingsWindow));
            viewLocator.Register(typeof(ViewModels.InputDialogViewModel), typeof(Views.Dialogs.InputDialog));



            var shellService = serviceLocator.ResolveType<IShellService>();
            await shellService.CreateAsync<ShellWindow>();


            ControlzEx.Theming.ThemeManager.Current.ChangeTheme(Application.Current, "Dark.Red");
            HandyControl.Tools.ThemeManager.Current.SetCurrentValue(HandyControl.Tools.ThemeManager.ApplicationThemeProperty, HandyControl.Tools.ApplicationTheme.Dark);
 
            Log.Info("Calling base.OnStartup");



      
            base.OnStartup(e); 
            NNViewRegistrar.RegisterSplat();



        }


        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
        }
    }
}