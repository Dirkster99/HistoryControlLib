[![Build status](https://ci.appveyor.com/api/projects/status/b5aljj6ec5cn10c0/branch/master?svg=true)](https://ci.appveyor.com/project/Dirkster99/historycontrollib/branch/master)
[![Release](https://img.shields.io/github/release/Dirkster99/MRULib.svg)](https://github.com/Dirkster99/MRULib/releases/latest)
[![NuGet](https://img.shields.io/nuget/dt/Dirkster.HistoryControlLib.svg)](http://nuget.org/packages/Dirkster.HistoryControlLib)

# HistoryControlLib
Implements a themable recent locations (forward, backward, up. pop-up list) control a la Windows (7-10) Explorer.

The repository contains the sources for a Generic and a Dark and Light themed test client.

## Navigate Back Direction
<img src="https://github.com/Dirkster99/Docu/blob/master/HistoryControlLib/Screenshots/Back.png?raw=true" width="120">

## Navigate Forward Direction
<img src="https://github.com/Dirkster99/Docu/blob/master/HistoryControlLib/Screenshots/Forward.png?raw=true" width="120">

## Navigate Up
<img src="https://github.com/Dirkster99/Docu/blob/master/HistoryControlLib/Screenshots/Up.png?raw=true" width="120">

## Navigate within list of recently visited locations
<img src="https://github.com/Dirkster99/Docu/blob/master/HistoryControlLib/Screenshots/RecentList.png?raw=true" width="360">

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

