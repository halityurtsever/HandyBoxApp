﻿using HandyBoxApp.ColorScheme;
using HandyBoxApp.ColorScheme.Colors;

using System;
using System.Drawing;
using System.Windows.Forms;

namespace HandyBoxApp.CustomComponents.Buttons
{
    internal class ClickImageButton : Label
    {
        //################################################################################
        #region Fields

        private readonly ToolTip m_ToolTip = new ToolTip();

        #endregion

        //################################################################################
        #region Constructor

        public ClickImageButton(Control parentControl, Action<ClickImageButton> action, string label)
        {
            ParentControl = parentControl;
            Label = label;

            InitializeComponent();

            action?.Invoke(this);
        }

        #endregion

        //################################################################################
        #region Properties

        private Control ParentControl { get; set; }

        private string Label { get; }

        #endregion

        //################################################################################
        #region Internal Members

        internal void SetToolTip(string toolTipText)
        {
            m_ToolTip.SetToolTip(this, toolTipText);
        }

        internal void SetColor<T>(PaintMode paintMode) where T : ColorBase, new()
        {
            Painter<T>.Paint(this, paintMode);
        }

        #endregion

        //################################################################################
        #region Private Members

        private void InitializeComponent()
        {
            Text = Label;
            Width = Height; //must be square
            Visible = true;
            AutoSize = true;
            Padding = new Padding(Style.PanelPadding);
            Painter<Green>.Paint(this, PaintMode.Light);
            Font = new Font(new FontFamily(Style.FontName), Style.PanelFontSize, FontStyle.Bold);
        }

        #endregion
    }
}
