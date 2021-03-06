﻿using C1.DataCollection;
using C1.Xamarin.Forms.Core;
using C1.Xamarin.Forms.Grid;
using FlexGrid101.Resources;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlexGrid101
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomSortIcon : ContentPage
    {
        public CustomSortIcon()
        {
            InitializeComponent();
            this.Title = AppResources.CustomSortIconTitle;

            sortIconPosition.Title = AppResources.SortIconPosition;
            foreach (var value in Enum.GetValues(typeof(GridSortIconPosition)))
            {
                sortIconPosition.Items.Add(value.ToString());
            }
            //sortIconPosition.SelectedIndex = sortIconPosition.Items.IndexOf(grid.SortIconPosition.ToString());

            sortIconTemplate.Title = AppResources.SortIconTemplate;
            foreach (var value in new string[] { nameof(C1IconTemplate.TriangleNorth), nameof(C1IconTemplate.ChevronUp), nameof(C1IconTemplate.ArrowUp), nameof(C1IconTemplate.TriangleUp) })
            {
                sortIconTemplate.Items.Add(value);
            }
            //sortIconTemplate.SelectedIndex = sortIconTemplate.Items.IndexOf(nameof(C1IconTemplate.ArrowUp));

            LoadData();
        }

        private async void LoadData()
        {
            var cv = new C1DataCollection<Customer>(Customer.GetCustomerList(100));
            await cv.SortAsync(new SortDescription("FirstName", SortDirection.Ascending), new SortDescription("LastName", SortDirection.Descending));
            grid.ItemsSource = cv;
        }

        private void SortIconPositionChanged(object sender, EventArgs e)
        {
            grid.SortIconPosition = (GridSortIconPosition)Enum.Parse(typeof(GridSortIconPosition), sortIconPosition.Items[sortIconPosition.SelectedIndex]);
        }

        private void SortIconTemplateChanged(object sender, EventArgs e)
        {
            switch (sortIconTemplate.SelectedIndex)
            {
                case 0:
                    grid.SortAscendingIconTemplate = C1IconTemplate.TriangleNorth;
                    break;
                case 1:
                    grid.SortAscendingIconTemplate = C1IconTemplate.ChevronUp;
                    break;
                case 2:
                    grid.SortAscendingIconTemplate = C1IconTemplate.ArrowUp;
                    break;
                case 3:
                    grid.SortAscendingIconTemplate = C1IconTemplate.TriangleUp;
                    break;
            }
        }
    }
}
