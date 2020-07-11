// <copyright file="StockListControl.xaml.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresStock.Views.Chart
{
    using System.Collections.Generic;
    using Windows.UI.Xaml.Controls;

    /// <summary>
    /// Stock list control class.
    /// </summary>
    public sealed partial class StockListControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StockListControl"/> class.
        /// </summary>
        public StockListControl()
        {
            this.InitializeComponent();
            var stocks = new List<Stock>();

            for (int i = 1; i < 25; i++)
            {
                stocks.Add(new Stock { Id = i, Symbol = i.ToString() });
            }

            this.Stocks = stocks;
        }

        /// <summary>
        /// Gets list of stocks.
        /// </summary>
        public List<Stock> Stocks { get; }
    }
}