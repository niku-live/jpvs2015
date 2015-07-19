#2 tema: darbalaukio (desktop'inės, Windows) aplikacijos - Mini užduotėlės - 2 užd.

##Sąlyga

Sukurkite WindowsForms aplikaciją, kurios lango apačioje būtų būsenos juosta, o joje progreso indikatorius. Taip pat formoje būtų mygtukas, kurį paspaudus, progreso indikatorius padidėtų vienetu.

##Patarimai

- Naudokite komponentus *StatusStrip* ir *ToolStripProgressBar*.

##Eiga

- Sukurkite naują darbalaukio aplikacijos projektą:
  1. *Visual Studio* lange pasirinkite **File -> New -> Project...**.
  2. Iš siūlomų projektų šablonų pasirinkite **Visual C# -> Windows Desktop -> Windows Forms Application**.
  3. Įveskite pageidaujamą projekto pavadinimą ir spauskite **OK**.
- Atidarykite formos redaktorių ir įkeltite į formą elementą "**StatusStrip**.
- Į elementą **StatusStrip** įkelkite elementą **ToolStripStatusLabel** ir pakeiskite įkelto elemento tekstą į "Pajudėjo".
- Į elementą **StatusStrip** įkelkite elementą **ToolStripProgressBar***.
- Įkelkite į formą vieną mygtuką, pakeiskite mygtuko tekstą į "Padidink".
- Priskirkite mygtuko įvykiui `Click` naują funkciją.
- Pakoreguokite priskirtos funkcijos kodą taip:
```csharp
private void button1_Click(object sender, EventArgs e)
{
    int value = toolStripProgressBar1.Value + 1;
    toolStripProgressBar1.Value = value;
}
```
- Paleiskite programą pasirinkę **Debug -> Start Debugging**.