#2 tema: darbalaukio (desktop'inės, Windows) aplikacijos - Mini užduotėlės - 1 užd.

##Sąlyga

Bėgiojantis mygtukas - sukurkite WindowsForms aplikaciją, kurioje būtų vienas mygtukas, tačiau virš jo užvedus pele, mygtukas pabėgtų.

##Patarimai

- Naudokite mygtuko įvykį `MouseMove` bei mygtuko savybes `button1.Location.X` ir `button1.Location.Y`;

##Eiga

- Sukurkite naują darbalaukio aplikacijos projektą:
  1. *Visual Studio* lange pasirinkite **File -> New -> Project...**.
  2. Iš siūlomų projektų šablonų pasirinkite **Visual C# -> Windows Desktop -> Windows Forms Application**.
  3. Įveskite pageidaujamą projekto pavadinimą ir spauskite **OK**.
- Atidarykite formos redaktorių ir įkelkite į formą vieną mygtuką, pakeiskite mygtuko tekstą į "Paspausk mane!!!".
- Priskirkite mygtuko įvykiui `MoveMove` naują funkciją.
- Pakoreguokite priskirtos funkcijos kodą taip:
```csharp
private void button1_MouseMove(object sender, MouseEventArgs e)
{
    Point location = button1.Location;
    location.X += 10;
    location.Y += 10;
    button1.Location = location;
}
```
- Paleiskite programą pasirinkę **Debug -> Start Debugging**.