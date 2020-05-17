﻿using Ferroviario.Common.Models;
using Ferroviario.Prism.Helpers;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Ferroviario.Prism.ViewModels
{
        public class FerroviarioMasterDetailPageViewModel : ViewModelBase
        {
            private readonly INavigationService _navigationService;

            public FerroviarioMasterDetailPageViewModel(INavigationService navigationService) : base(navigationService)
            {
                _navigationService = navigationService;
                LoadMenus();
            }

            public ObservableCollection<MenuItemViewModel> Menus { get; set; }

            private void LoadMenus()
            {
                List<Menu> menus = new List<Menu>
            {
                new Menu
                {
                    Icon = "request",
                    PageName = "RequestsPage",
                    Title = Languages.MyRequests
                },
                new Menu
                {
                    Icon = "shift",
                    PageName = "ShiftsPage",
                    Title = Languages.MyShifts
                },
                new Menu
                {
                    Icon = "user",
                    PageName = "UsersPage",
                    Title = Languages.User
                }
            };

                Menus = new ObservableCollection<MenuItemViewModel>(
                    menus.Select(m => new MenuItemViewModel(_navigationService)
                    {
                        Icon = m.Icon,
                        PageName = m.PageName,
                        Title = m.Title
                    }).ToList());
            }
        }

    }

