using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Game
    {
        public Nobody[,] Playground { get; private set; }
        private List<Blocks> blocks;
        private List<Coins> coins;
        private List<Monsters> monsters;
        private Player player;
        public Game(SizeOfPlayground size, List<Blocks> blocks, List<Coins> coins, List<Monsters> monsters, Player player)
        {
            Playground = new Nobody[size.Width, size.Height];
            this.blocks = blocks;
            this.coins = coins;
            this.monsters = monsters;
            this.player = player;
            for (int i = 0; i < blocks.Count; i++)
            {
                //заполнение блоками
            }
            for (int i = 0; i < coins.Count; i++)
            {
                //заполнение бонусами
            }
            for (int i = 0; i < monsters.Count; i++)
            {
                //заполнение монстрами
            }
               //размещение игрока
        }

        public void Step()
        {
            player.Move();
            foreach (var item in monsters)
            {
                item.Move();
            }
            switch (Playground[player.X, player.Y])
            {
                //исходя из того что лежит в ячейке куда передвигается игрок, предпринимать действие
                default:
                    break;
            }
        }

    }
}
