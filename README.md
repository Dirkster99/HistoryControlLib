[![Build status](https://ci.appveyor.com/api/projects/status/b5aljj6ec5cn10c0/branch/master?svg=true)](https://ci.appveyor.com/project/Dirkster99/historycontrollib/branch/master)
[![Release](https://img.shields.io/github/release/Dirkster99/MRULib.svg)](https://github.com/Dirkster99/MRULib/releases/latest)
[![NuGet](https://img.shields.io/nuget/dt/Dirkster.HistoryControlLib.svg)](http://nuget.org/packages/Dirkster.HistoryControlLib)

![Net4](https://badgen.net/badge/Framework/.Net&nbsp;4/blue) ![NetCore3](https://badgen.net/badge/Framework/NetCore&nbsp;3/blue)

<table border="0" width="100%">
<tr>
    <td><img src="https://github.com/Dirkster99/Docu/blob/master/HistoryControlLib/Branch_32x.png?raw=true" width="24"/></td> <td><h1>HistoryControlLib</h1></td>
</tr>
</table>

Implements a themable recent locations (forward, backward, up. pop-up list) control a la <a href="https://github.com/Dirkster99/fsc/wiki/FSC-Windows-Explorer-(Cloned)">Windows (7-10) Explorer</a>.
These controls and viewmodels are re-used in the <a href="https://github.com/Dirkster99/fsc">File System Controls</a> project which in turn is integrated in <a href="https://github.com/Dirkster99/Edi">Edi</a>.

The repository contains the sources for a Generic and a Dark and Light themed test client.

The <a href="https://github.com/Dirkster99/HistoryControlLib/blob/master/source/HistoryControlLib/Controls/LocationsDropDown.xaml">Locations Drop-Down button</a> makes use of the **Segoe UI Symbol** font, which may not
always be available on Windows 7. The font can either be installed via update from Microsoft of the drop down
button definition for the down chevron can be replaced with a path definition.

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

