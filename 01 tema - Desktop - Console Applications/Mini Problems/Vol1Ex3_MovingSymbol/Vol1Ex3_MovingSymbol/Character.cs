using System;
namespace Vol1Ex3_MovingSymbol
{
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
}
