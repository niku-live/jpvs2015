#2 tema: darbalaukio (desktop'inės, Windows) aplikacijos - Mini užduotėlės - 4 užd.

##Sąlyga

Sukurkite programėlę - tekstų redaktorių, kuriame pažymėjus tekstą ir paspaudus dešinį pelės klavišą pasirodytų kontekstinis meniu su punktai "Nuspalvinti raudonai" ir "Nuspalvinti mėlynai", pasirinkus vieną iš punktų tik pažymėtas tekstas būtų nuspalvinamas pasirinkta spalva.

##Patarimai

- Kontekstiniam meniu rodyti naudokite komponentą **"ContextMenuStrip"** ir elemente, ties kuriuo turėtų pasirodyti šis kontekstinis meniu pakeiskite savybę **"Context Menu Strip"**.
- Kaip teksto redagavimo elementą naudokite komponentą **"RichTextBox"**, nes tik šiame elemente galima keisti spalvą daliai teksto.
- Pažymėto teksto spalvą galima pakeisti su komandą `richTextBox1.SelectionColor = Color.Red;`.

#Eiga

- Sukurkite naują darbalaukio aplikacijos projektą:
  1. *Visual Studio* lange pasirinkite **File -> New -> Project...**.
  2. Iš siūlomų projektų šablonų pasirinkite **Visual C# -> Windows Desktop -> Windows Forms Application**.
  3. Įveskite pageidaujamą projekto pavadinimą ir spauskite **OK**.
- Atidarykite formos redaktorių ir įkelkite į formą **RichTextBox** elementą, pakeiskite elemento savybę **Dock** į **Fill**.
- Įkelkite į formą **ContextMenuStrip** elementą.
- Pasirinkite įkeltą **ContextMenuStrip** elementą ir meniu redaktoriaus pagalba sukurkite naują meniu punktą "Nudažyti raudonai", šio elemento įvykiui `Click` priskirkite naują funkciją
```csharp
private void colorRedToolStripMenuItem_Click(object sender, EventArgs e)
{
    richTextBox1.SelectionColor = Color.Red;
}
```
- Pasirinkite įkeltą **ContextMenuStrip** elementą ir meniu redaktoriaus pagalba sukurkite naują meniu punktą "Nudažyti mėlynai", šio elemento įvykiui `Click` priskirkite naują funkciją
```csharp
private void colorBlueToolStripMenuItem_Click(object sender, EventArgs e)
{
    richTextBox1.SelectionColor = Color.Blue;
}
```
- Pasirinkite įkeltą **ContextMenuStrip** elementą ir meniu redaktoriaus pagalba sukurkite naują meniu punktą "Pažymėti viską", šio elemento įvykiui `Click` priskirkite naują funkciją
```csharp
private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
{
    richTextBox1.SelectAll();
}
```
- Pasirinkite formos elementą **RichTextBox** ir jo savybei **ContextMenuStrip** priskirkite įkeltą *ContextMenuStrip** elementą.
- Paleiskite programą pasirinkę **Debug -> Start Debugging**.
