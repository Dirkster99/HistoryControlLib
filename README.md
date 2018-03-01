[![Build status](https://ci.appveyor.com/api/projects/status/b5aljj6ec5cn10c0/branch/master?svg=true)](https://ci.appveyor.com/project/Dirkster99/historycontrollib/branch/master)
[![Release](https://img.shields.io/github/release/Dirkster99/MRULib.svg)](https://github.com/Dirkster99/MRULib/releases/latest)

# HistoryControlLib
Implements a themable recent locations (forward, backward, up. pop-up list) control a la Windows (7-10) Explorer.

<img src="https://github.com/Dirkster99/Docu/blob/master/HistoryControlLib/Screenshots/Back.png?raw=true" width="120">

<img src="https://github.com/Dirkster99/Docu/blob/master/HistoryControlLib/Screenshots/Forward.png?raw=true" width="120">

<img src="https://github.com/Dirkster99/Docu/blob/master/HistoryControlLib/Screenshots/Up.png?raw=true" width="120">

<img src="https://github.com/Dirkster99/Docu/blob/master/HistoryControlLib/Screenshots/RecentList.png?raw=true" width="120">

## Theming

Load *Light* or *Dark* brush resources in you resource dictionary to take advantage of existing definitions.

```XAML
    <ResourceDictionary.MergedDictionaries>
        <ResourceDictionary Source="/HistoryControlLib;component/Themes/DarkTheme.xaml" />
    </ResourceDictionary.MergedDictionaries>
```

```XAML
    <ResourceDictionary.MergedDictionaries>
        <ResourceDictionary Source="/HistoryControlLib;component/Themes/LightTheme.xaml" />
    </ResourceDictionary.MergedDictionaries>
```

