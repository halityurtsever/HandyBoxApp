﻿using HandyBoxApp.CurrencyService;
using HandyBoxApp.CurrencyService.Types;
using HandyBoxApp.CustomComponents;
using HandyBoxApp.CustomComponents.Panels;
using HandyBoxApp.Properties;
using HandyBoxApp.Utilities;

using System.Drawing;
using System.Windows.Forms;

namespace HandyBoxApp
{
    public partial class MainForm : Form
    {
        //################################################################################
        #region Constructor

        public MainForm()
        {
            Paint += PaintBorder;
            Closing += OnFormClosed;
            ControlAdded += OnControlAdd;

            InitializeComponent();
            InitializePanels();

            //todo: this call title panel specific, make more generic
            TitlePanel.UpdatePanelContent(LargestContent);
        }

        #endregion

        //################################################################################
        #region Properties

        private TitlePanel TitlePanel { get; set; }

        private CurrencyPanel EurTryCurrencyPanel { get; set; }

        private CurrencyPanel EurUsdCurrencyPanel { get; set; }

        private CurrencyPanel UsdTryCurrencyPanel { get; set; }

        private int LargestContent { get; set; }

        #endregion

        //################################################################################
        #region Event Handlers

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            SetFormPosition();
            Opacity = Settings.Default.Transparency;
        }

        private void PaintBorder(object sender, PaintEventArgs e)
        {
            var point = new Point(0, 0);
            var size = new Size(Width - Style.FormBorder, Height - Style.FormBorder);
            Rectangle borderRectangle = new Rectangle(point, size);
            CreateGraphics().DrawRectangle(new Pen(Color.Black, Style.FormBorder), borderRectangle);
        }

        private void OnControlAdd(object sender, ControlEventArgs e)
        {
            if (e.Control.Width > LargestContent)
            {
                LargestContent = e.Control.Width;
            }

            CustomControlHelper.BoundsForVertical(e.Control, this);
        }

        private void OnFormClosed(object sender, System.EventArgs e)
        {
            Settings.Default.LastLocation = Location;
            Settings.Default.Save();
        }

        #endregion

        //################################################################################
        #region Private Members

        private void InitializePanels()
        {
            TitlePanel = new TitlePanel(this, false);
            Controls.Add(TitlePanel);

            EurTryCurrencyPanel = new CurrencyPanel(new EurTryCurrency(CurrencyUrls.YahooEurTry), this, false);
            Controls.Add(EurTryCurrencyPanel);

            UsdTryCurrencyPanel = new CurrencyPanel(new UsdTryCurrency(CurrencyUrls.YahooUsdTry), this, false);
            Controls.Add(UsdTryCurrencyPanel);

            EurUsdCurrencyPanel = new CurrencyPanel(new EurUsdCurrency(CurrencyUrls.YahooEurUsd), this, false);
            Controls.Add(EurUsdCurrencyPanel);
        }

        private void SetFormPosition()
        {
            var lastLocation = Settings.Default.LastLocation;

            if (lastLocation.X == 0 && lastLocation.Y == 0)
            {
                //set default location
                var marginRight = 30;
                var marginBottom = 60;
                var screenW = Screen.PrimaryScreen.Bounds.Width;
                var screenH = Screen.PrimaryScreen.Bounds.Height;

                Top = screenH - Height - marginBottom;
                Left = screenW - Width - marginRight;

                lastLocation = new Point(Left, Top);
                Settings.Default.LastLocation = lastLocation;
                Settings.Default.Save();
            }

            Location = lastLocation;
        }

        #endregion
    }
}
