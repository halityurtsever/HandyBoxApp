﻿using HandyBoxApp.CustomComponents.Buttons;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace HandyBoxApp.CustomComponents.Panels.Base
{
    internal abstract class DynamicPanel : CustomBasePanel
    {
        //################################################################################
        #region Fields

        private readonly List<ClickImageButton> m_FunctionButtonList;

        #endregion

        //################################################################################
        #region Constructor

        protected DynamicPanel(Control parentControl) : base(parentControl)
        {
            m_FunctionButtonList = new List<ClickImageButton>();

            BackgroundWorker = new BackgroundWorker();
            InitializeBackgroundWorker();
        }

        #endregion

        //################################################################################
        #region Properties

        protected BackgroundWorker BackgroundWorker { get; }

        protected bool IsStopped { get; set; }

        #endregion

        //################################################################################
        #region Abstract Methods

        protected abstract void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e);

        protected abstract void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e);

        #endregion

        //################################################################################
        #region Protected Members

        protected void AddFunction(Control containerPanel, Action action, string functionName)
        {
            m_FunctionButtonList.Add(new ClickImageButton(containerPanel, action, functionName));
        }

        #endregion

        //################################################################################
        #region Private Members

        private void InitializeBackgroundWorker()
        {
            BackgroundWorker.WorkerReportsProgress = false;
            BackgroundWorker.WorkerSupportsCancellation = false;

            BackgroundWorker.DoWork += BackgroundWorker_DoWork;
            BackgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
        }

        #endregion
    }
}