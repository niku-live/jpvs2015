#1 tema: Konsolinės aplikacijos - Mini užduotėlės - 3 užd.

##Sąlyga

Sukurkite konsolinę programėlę, kuriai pasileidus tiesiog išvedamas vienas simbolis "#", tačiau po to galima klaviatūros pagalba (paspaudus vieną iš klavišų "a", "s", "d", "w") šį simbolį judinti ekrane, t.y. paspaudus klavišą "d" simbolis pajuda per vieną simbolį į dešinę, paspaudus "s", simbolis pajuda viena eilute žemiau.

##Patarimai

- Nuskaityti paspaudam klavišui naudokite komandą `Console.ReadKey(true);` 
- Pakeisti kursoriaus poziciją naudokite komandą `Console.SetCursorPosition(x, y)`

##Eiga

- Sukurkite naują konsolinės aplikacijos projektą:
  1. *Visual Studio* lange pasirinkite **File -> New -> Project...**.
  2. Iš siūlomų projektų šablonų pasirinkite **Visual C# -> Windows Desktop -> Console Application**.
  3. Įveskite pageidaujamą projekto pavadinimą ir spauskite **OK**.  
- Pakeiskite funkcijos `Main` programinį kodą taip:
```csharp
static void Main(string[] args)
{
    Character character = new Character(0, 0, '#');
    while (true)
    {                
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        switch (keyInfo.KeyChar)
        {
            case 'a':
                character.Move(-1, 0);
                break;
            case 'w':
                character.Move(0, -1);
                break;
            case 'd':
                character.Move(1, 0);
                break;
            case 's':
                character.Move(0, 1);
                break;

        }
    }
}
```
- Pasirinkite **Project -> Add Class..**, suveskite klasės pavadinimą **CursorPosition** ir naujai atsiradusiame faile suveskite tokį kodą:
```csharp
public class CursorPosition
{
    public const int MaxX = 79;
    public const int MaxY = 25;

    public int PositionX { get; set; }
    public int PositionY { get; set; }

    public CursorPosition(int x, int y)
    {            
        PositionX = x;
        PositionY = y;
    }

    public void MoveBy(int diffX, int diffY)
    {
       if ((PositionX + diffX >= 0) && (PositionX + diffX <= MaxX))
       {
           PositionX += diffX;
       }
       if ((PositionY + diffY >= 0) && (PositionY + diffY <= MaxY))
       {
           PositionY += diffY;
       }
    }
}
```
- Pasirinkite **Project -> Add Class..**, suveskite klasės pavadinimą **Character** ir naujai atsiradusiame faile suveskite tokį kodą:
```csharp
public class Character
{
    public CursorPosition Position { get; set; }

    public char CharacterSymbol { get; set; }

    private void PrintSymbolAtPosition(char symbol)
    {
        Console.SetCursorPosition(Position.PositionX, Position.PositionY);
        Console.Write(symbol);
    }

    public Character(int x, int y, char symbol)
    {
        CharacterSymbol = symbol;
        Position = new CursorPosition(x, y);
        PrintSymbolAtPosition(CharacterSymbol);
    }

    public void Move(int diffX, int diffY)
    {
        PrintSymbolAtPosition(' ');
        Position.MoveBy(diffX, diffY);
        PrintSymbolAtPosition(CharacterSymbol);
    }
}
```
- Paleiskite programą pasirinkę **Debug -> Start Debugging**.