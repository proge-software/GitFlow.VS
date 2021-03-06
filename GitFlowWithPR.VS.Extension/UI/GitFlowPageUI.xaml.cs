﻿using System.Windows.Controls;
using GitFlowWithPRVS.Extension.ViewModels;

namespace GitFlowWithPRVS.Extension.UI
{
    /// <summary>
    /// Interaction logic for GitFlowPageUI.xaml
    /// </summary>
    public partial class GitFlowPageUI : UserControl
    {
        private readonly GitFlowPageModel model;

        public GitFlowPageUI()
        {
            InitializeComponent();

            model = new GitFlowPageModel();
            DataContext = model;
        }

        public void Refresh()
        {
            this.model.Update();
        }
    }
}
