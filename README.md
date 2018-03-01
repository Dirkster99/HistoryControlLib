[![Build status](https://ci.appveyor.com/api/projects/status/b5aljj6ec5cn10c0/branch/master?svg=true)](https://ci.appveyor.com/project/Dirkster99/historycontrollib/branch/master)

# HistoryControlLib
Implements a themable recent locations (forward, backward, up. pop-up list) control a la Windows (7-10) Explorer.

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

