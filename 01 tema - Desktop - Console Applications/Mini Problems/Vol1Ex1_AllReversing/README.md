#1 tema: Konsolinės aplikacijos - Mini užduotėlės - 1 užd.

##Sąlyga

Sukurkite konsolinę programėlę, kuri viską, ką įveda vartotojas, išveda atvirkščiai (pvz. įvedus "Labas", išvedama "sabaL"). 

##Patarimai

- Naudokite string klasės standartinę komandą `Reverse()`, pvz.: `string s = "Labas"; s = new String(text.Reverse().ToArray());`

##Eiga

- Sukurkite naują konsolinės aplikacijos projektą:
  1. *Visual Studio* lange pasirinkite **File -> New -> Project...**.
  2. Iš siūlomų projektų šablonų pasirinkite **Visual C# -> Windows Desktop -> Console Application**.
  3. Įveskite pageidaujamą projekto pavadinimą ir spauskite **OK**.
- Pakeiskite funkcijos `Main` programinį kodą taip:
```csharp
static void Main(string[] args)
{
    while (true)
    {
        string text = Console.ReadLine();
        text = new String(text.Reverse().ToArray());
        Console.WriteLine(text);
    }
}
```
- Paleiskite programą pasirinkę **Debug -> Start Debugging**.