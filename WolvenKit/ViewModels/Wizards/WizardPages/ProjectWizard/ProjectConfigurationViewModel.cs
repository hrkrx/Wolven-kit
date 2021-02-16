﻿using Catel;
using Catel.Data;
using Catel.Fody;
using Catel.IoC;
using Catel.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Model.Wizards;

namespace WolvenKit.ViewModels.Wizards.WizardPages.ProjectWizard
{
    /// <summary>
	/// The ProjectConfigurationViewModel implements project wizard configuration window's viewmodel.
	/// </summary>
    class ProjectConfigurationViewModel : ViewModelBase
    {
        #region constructors
        public ProjectConfigurationViewModel(IServiceLocator serviceLocator)
        {
            Argument.IsNotNull(() => serviceLocator);

            ProjectWizardModel = serviceLocator.ResolveType<ProjectWizardModel>();
        }
        #endregion

        #region properties
        /// <summary>
        /// Gets or sets the projectWizardModel.
        /// </summary>
        [Model]
        [Expose("ProjectName")]
        [Expose("ProjectPath")]
        public ProjectWizardModel ProjectWizardModel
        {
            get { return GetValue<ProjectWizardModel>(ProjectWizardModelProperty); }
            set { SetValue(ProjectWizardModelProperty, value); }
        }


        /// <summary>
        /// Register the ProjectWizardModel property so it is known in the class.
        /// </summary>
        public static readonly PropertyData ProjectWizardModelProperty = RegisterProperty("ProjectWizardModel", typeof(ProjectWizardModel));
        #endregion properties
    }
}
