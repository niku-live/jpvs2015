#1 tema: Konsolinės aplikacijos - Mini užduotėlės - 4 užd.

##Sąlyga

Sukurkite konsolinę programėlę, kuri lauktų paspaudžiamo klavišo ir paspaudus tam tikrą klavišą išvestų garsinį signalą

##Patarimai

- Nuskaityti paspaudam klavišui naudokite komandą `Console.ReadKey(true);`
- Išvesti garsiniam signalui naudokite komandą `Console.Beep(frequency, duration)`

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
        ConsoleKeyInfo info = Console.ReadKey(true);
        switch (info.KeyChar)
        {
            case 'a':
                Console.Beep(440, 200);
                break;
            case 's':
                Console.Beep(500, 200);
                break;
            case 'd':
                Console.Beep(580, 200);
                break;
            case 'f':
                Console.Beep(660, 200);
                break;
            case 'g':
                Console.Beep(740, 200);
                break;
            case 'h':
                Console.Beep(820, 200);
                break;
            case 'j':
                Console.Beep(900, 200);
                break;
            case 'k':
                Console.Beep(980, 200);
                break;
            case 'l':
                Console.Beep(1060, 200);
                break;

        }
    }
}
```
- Paleiskite programą pasirinkę **Debug -> Start Debugging**.