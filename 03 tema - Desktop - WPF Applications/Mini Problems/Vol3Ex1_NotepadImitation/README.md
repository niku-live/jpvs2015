#3 tema: darbalaukio aplikacijos II (aplikacijos paremtos WPF) - Mini užduotys - 1 užd.

##Sąlyga

Sukurkite WPF programėlę, kuri atrodytų kaip *Notepad* programa. Programa nieko neturi daryti, tačiau turėti visiškai tokį pat vaizdą kaip ir *Notepad*.

##Patarimai

1. Programėlei turėtų užtekti šių elementų: **Grid**, **TextBox**, **Menu**, **ScrollViewer**, dėl grožio dar galima panaudoti **Border** elementą.
2. Norint, kad **TextBox** elementas leistų suvesti kelių eilučių tekstą, reikėtų nurodyti savybes `TextWrapping="Wrap"` ir `AcceptsReturn="True"`.

##Eiga

- Sukurkite naują WPF aplikacijos projektą:
  1. *Visual Studio* lange pasirinkite **File -> New -> Project...**.
  2. Iš siūlomų projektų šablonų pasirinkite **Visual C# -> Windows Desktop -> WPF Application**.
  3. Įveskite pageidaujamą projekto pavadinimą ir spauskite **OK**.
- Atidarykite puslapio redaktorių ir į puslapį įkelkite **Grid** elementą.
- **Grid** elementui pridėkite 2 eilutes ir 3 stulpelius, **Grid** elementas turėtų atrodyti taip:
```xml
<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="20"></RowDefinition>
        <RowDefinition Height="*"></RowDefinition>
    </Grid.RowDefinitions>
    <Grid.ColumnDefinitions>
        <ColumnDefinition Width="63*"/>
        <ColumnDefinition Width="47*"/>
        <ColumnDefinition Width="407*"/>
    </Grid.ColumnDefinitions>
</Grid>
```
- Į anksčiau sukurtą **Grid** elementą įkelkite dar vieną **Grid** elementą bei nurodykite šias savybes:
  1. `Grid.Row="0"`
  2. `Grid.ColumnSpan="3"`
  3. `Background="{DynamicResource {x:Static SystemColors.MenuBrushKey}}"`
- Į šį **Grid** elementą įkelkite **Menu** elementą bei nustatykite savybę `HorizontalAlignment="Left"`.
- **Menu** elementą papildykite atitinkamais menu punktais. Galutinis **Menu** elemento vaizdas turėtų būti:
```xml
<Menu HorizontalAlignment="Left">
    <MenuItem Header="File" >
        <MenuItem Header="New" InputGestureText="Ctrl+N"/>
        <MenuItem Header="Open..." InputGestureText="Ctrl+O"/>
        <MenuItem Header="Save" InputGestureText="Ctrl+S"/>
        <MenuItem Header="Save As..." HorizontalAlignment="Left" Width="140"/>
        <Separator/>
        <MenuItem Header="Page Setup..."/>
        <MenuItem Header="Print..." InputGestureText="Ctrl+P"/>
        <Separator/>
        <MenuItem Header="Exit"/>

    </MenuItem>
    <MenuItem Header="Edit">
        <MenuItem Header="Undo" InputGestureText="Ctrl+Z"/>
        <Separator/>
        <MenuItem Header="Cut" InputGestureText="Ctrl+X"/>
        <MenuItem Header="Copy" InputGestureText="Ctrl+C"/>
        <MenuItem Header="Paste" InputGestureText="Ctrl+V"/>
        <MenuItem Header="Delete" InputGestureText="Del"/>
        <Separator/>
        <MenuItem Header="Find..." InputGestureText="Ctrl+F"/>
        <MenuItem Header="Find Next" InputGestureText="F3"/>
        <MenuItem Header="Replace..." InputGestureText="Ctrl+H"/>
        <MenuItem Header="Go To..." InputGestureText="Ctrl+G"/>
        <Separator/>
        <MenuItem Header="Select All" InputGestureText="Ctrl+A"/>
        <MenuItem Header="Time/Date" InputGestureText="F5"/>

    </MenuItem>
    <MenuItem Header="Format">
        <MenuItem Header="Word Wrap"/>
        <MenuItem Header="Font..."/>
    </MenuItem>
    <MenuItem Header="View">
        <MenuItem Header="Status Bar"/>
    </MenuItem>
    <MenuItem Header="Help">
        <MenuItem Header="View Help"/>
        <Separator/>
        <MenuItem Header="About Notepad"/>
    </MenuItem>
</Menu>
```
- Į pirmąjį **Grid** elementą įkelkite **Border** elementą ir nustatykite savybes taip:
  1. `Grid.Row="1"`.
  2. `Grid.ColumnSpan="3"`.
  3. `BorderThickness="1"`.
  4. `BorderBrush="{DynamicResource {x:Static SystemColors.ActiveBorderBrushKey}}"`.
- Į **Border** elementą įkelkite **ScrollViewer** elementą ir pakeiskite savybes taip:
  1. `Height="Auto"`.
  2. `Width="Auto"`.
  3. `HorizontalScrollBarVisibility="Visible"`.
- Į **ScrollViewer** elementą įkelkite **TextBox** elementą ir pakeiskite savybes taip:
  1. `TextWrapping="Wrap"`.
  2. `AcceptsReturn="True"`.
  3. `Height="Auto"`.
  4, `BorderBrush="{x:Null}"`.
  5. `BorderThickness="0"`.
  6. `Text=""`.      
- Paleiskite programą pasirinkę **Debug -> Start Debugging**.