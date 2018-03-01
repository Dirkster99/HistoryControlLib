namespace BrowserHistoryDemoLib.ViewModels
{
    using BrowserHistoryDemoLib.ViewModels.Base;
    using HistoryControlLib.Interfaces;
    using System.Windows.Input;

    public class AppViewModel : Base.BaseViewModel
    {
        #region fields
        private ICommand _SelectionChanged;
        private ICommand _ForwardCommand;
        private ICommand _BackwardCommand;
        private ICommand _UpCommand;
        private RelayCommand<object> _ForwardLocationCommand;
        #endregion fields

        #region ctors
        /// <summary>
        /// Class constructor.
        /// </summary>
        public AppViewModel()
        {
            NaviHistory = HistoryControlLib.Factory<LocationItem>.CreateBrowseNavigator();
        }
        #endregion ctors

        #region properties
        /// <summary>
        /// Gets an object that can manage recently visited locations and supports:
        /// 
        /// - adding more recently visited locations
        /// - forward and backward navigation, and
        /// - selection of any position within the given set of locations.
        /// </summary>
        public IBrowseHistory<LocationItem> NaviHistory{ get; }

        /// <summary>
        /// Command executes when the user has selected
        /// a different item in the displayed list of items.
        /// </summary>
        public ICommand SelectionChanged
        {
            get
            {
                if (_SelectionChanged == null)
                {
                    _SelectionChanged = new RelayCommand<object>((p) =>
                    {
                        object[] paramets = p as object[];

                        if (paramets.Length == 0)
                            return;

                        if (paramets != null)
                        {
                            var item = paramets[0] as LocationItem;

                            if (item == null)  // Item does not appear to be what we need
                                return;

                            int idx = 0;       // Search the selected item in ViewModel and select it
                            foreach (var histItem in NaviHistory.Locations)
                            {
                                if(object.Equals(histItem, item) == true)
                                {
                                    idx *= -1;
                                    break;
                                }

                                idx--;
                            }

                            if (idx > 0)
                                NaviHistory.SetSelectedIndex(idx);
                        }
                    });
                }
                return _SelectionChanged;
            }
        }

        /// <summary>
        /// Gets a command to browse forward in the available collection of items.
        /// </summary>
        public ICommand ForwardCommand
        {
            get
            {
                if (_ForwardCommand == null)
                {
                    _ForwardCommand = new RelayCommand<object>((p) =>
                    {
                        if (NaviHistory.CanForward == true)
                            NaviHistory.Forward();
                    },
                    (p) => NaviHistory.CanForward);
                }

                return _ForwardCommand;
            }
        }

        /// <summary>
        /// Gets a command that simulates browsing to a new loaction. The command expects
        /// a string (e.g. 'C:\Program Files') that points to a path that is visited at this
        /// point in time.
        /// </summary>
        public ICommand ForwardLocationCommand
        {
            get
            {
                if (_ForwardLocationCommand == null)
                {
                    _ForwardLocationCommand = new RelayCommand<object>((p) =>
                    {
                        var param = p as string;

                        NaviHistory.Forward(new LocationItem(param));
                    });
                }

                return _ForwardLocationCommand;
            }
        }

        /// <summary>
        /// Gets a command to browse backward in the available collection of items.
        /// </summary>
        public ICommand BackwardCommand
        {
            get
            {
                if (_BackwardCommand == null)
                {
                    _BackwardCommand = new RelayCommand<object>((p) =>
                    {
                        if (NaviHistory.CanBackward == true)
                            NaviHistory.Backward();
                    },
                    (p) => NaviHistory.CanBackward);
                }

                return _BackwardCommand;
            }
        }

        /// <summary>
        /// Gets a command to browse to the parent (if any) of the current location.
        /// </summary>
        public ICommand UpCommand
        {
            get
            {
                if (_UpCommand == null)
                {
                    _UpCommand = new RelayCommand<object>((p) =>
                    {
                        var item = NaviHistory.SelectedItem.Path;
                        try
                        {
                            var dirItem = System.IO.Directory.GetParent(item);

                            if (dirItem != null)
                                NaviHistory.Forward(new LocationItem(dirItem.FullName));
                        }
                        catch
                        {
                        }

                    },
                    (p) =>
                    {
                        if (NaviHistory.SelectedItem == null)
                            return false;

                        var item = NaviHistory.SelectedItem.Path;
                        try
                        {
                            var dirItem = System.IO.Directory.GetParent(item);

                            if (dirItem != null)
                                return true;
                        }
                        catch
                        {
                        }

                        return false;
                    });
                }

                return _UpCommand;
            }
        }
        #endregion properties

        #region methods
        /// <summary>
        /// Initializes the Navigational History with sample items.
        /// </summary>
        public void Init()
        {
            NaviHistory.Forward(new LocationItem(@"C:\"));
            NaviHistory.Forward(new LocationItem(@"F:\Program Files\My Program\My  Dir 1\My  Dir 2"));
            NaviHistory.Forward(new LocationItem(@"F:\"));
            NaviHistory.Forward(new LocationItem(@"F:\Temp"));
            NaviHistory.Forward(new LocationItem(@"F:\Temp\More Files"));
            NaviHistory.Forward(new LocationItem(@"G:\"));
            NaviHistory.Forward(new LocationItem(@"H:\"));
        }
        #endregion methods
    }
}
