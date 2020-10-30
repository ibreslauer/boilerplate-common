using Boilerplate.Common.Base;
using Boilerplate.Common.Constants;
using System;

namespace Boilerplate.Common.Models
{
    public class AppRootMenuItem : BindableBase
    {
        private string _menuText;
        private MenuItemType _menuItemType;
        private PageNavigationMode _navigationMode;
        private Type _viewModelToLoad;
        private bool _hasSeparator;

        public string MenuText
        {
            get => _menuText;
            set
            {
                _menuText = value;
                OnPropertyChanged();
            }
        }

        public PageNavigationMode NavigationMode
        {
            get => _navigationMode;
            set
            {
                _navigationMode = value;
                OnPropertyChanged();
            }
        }

        public MenuItemType MenuItemType
        {
            get => _menuItemType;
            set
            {
                _menuItemType = value;
                OnPropertyChanged();
            }
        }

        public Type ViewModelToLoad
        {
            get => _viewModelToLoad;
            set
            {
                _viewModelToLoad = value;
                OnPropertyChanged();
            }
        }

        public bool HasSeparator {
            get => _hasSeparator;
            set
            {
                _hasSeparator = value;
                OnPropertyChanged();
            }
        }
    }
}
