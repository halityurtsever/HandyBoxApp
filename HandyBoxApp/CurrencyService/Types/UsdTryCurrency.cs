﻿using System.Security.Policy;

namespace HandyBoxApp.CurrencyService.Types
{
    internal struct UsdTryCurrency : ICurrency
    {
        //################################################################################
        #region Fields

        private readonly Url m_SourceUrl;

        #endregion

        //################################################################################
        #region Constructor

        public UsdTryCurrency(string urlLink)
        {
            m_SourceUrl = new Url(urlLink);
        }

        #endregion

        //################################################################################
        #region ICurrencyService Members

        string ICurrency.Name => "USD/TRY";

        string ICurrency.Tag => "USDTRY";

        Url ICurrency.SourceUrl => m_SourceUrl;

        #endregion
    }
}