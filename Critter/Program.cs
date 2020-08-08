using System;

namespace Critter
{
    class Program
    {
        Player player1 = new Player();
        Player player2 = new Player();

        static void Main(string[] args)
        {
            Program p = new Program();
            Battle b = new Battle();
            b.player1.FillCritter();
            b.player2.FillCritter();
            b.Play();
        }
    }
}
