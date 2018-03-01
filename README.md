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

