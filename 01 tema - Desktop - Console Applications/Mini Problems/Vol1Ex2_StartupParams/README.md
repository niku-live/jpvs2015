#1 tema: Konsolinės aplikacijos - Mini užduotėlės - 2 užd.

##Sąlyga

Sukurkite konsolinę programėlę, kuri išspausdintų į ekraną viską, kas pateikiama kaip programos paleidimo parametrai (t.y. jei programa vadinasi programele.exe ir ji paleidžiama iš komandinės eilutės surinkus "programele.exe test1 test2 test3", tai atskirose eilutėse turėtų būti išspausdinamas tekstas "test1", "test2", "test3").

##Patarimai

- Naudokite masyvą **args**, kuris yra standartinio metodo **Main** vienintelis parametras.

##Eiga

- Sukurkite naują konsolinės aplikacijos projektą:
  1. *Visual Studio* lange pasirinkite **File -> New -> Project...**.
  2. Iš siūlomų projektų šablonų pasirinkite **Visual C# -> Windows Desktop -> Console Application**.
  3. Įveskite pageidaujamą projekto pavadinimą ir spauskite **OK**.
- Pakeiskite funkcijos `Main` programinį kodą taip:
```csharp
static void Main(string[] args)
{
    foreach (string arg in args)
    {
        Console.WriteLine(arg);
    }
    Console.ReadLine();
}
```
- Paleiskite programą pasirinkę **Debug -> Start Debugging**.