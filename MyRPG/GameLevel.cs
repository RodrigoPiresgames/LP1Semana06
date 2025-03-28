using System;
using System.Security.Cryptography.X509Certificates;
using Humanizer;

namespace MyRPG
{
    public class GameLevel
    {
        private Enemy[] rooms;
        private Hardness level;

        public GameLevel(int roomNum, Hardness level)
        {
            rooms = new Enemy[roomNum];
            this.level = level;

        }

        public Hardness GetHardness()
        {
            return level;
        }

        public int GetNumRooms()
        {
            return rooms.Length;
        }

        public int GetNumEnemies()
        {
            int enemyNum = 0;
            foreach(Enemy foe in rooms)
                enemyNum += 1;
            return enemyNum;
        }

        public void SetEnemyInRoom(int room, Enemy enemy)
        {
            rooms[room] = enemy;
        }

        public void PrintEnemies()
        {
            for(int x = 0; x < GetNumEnemies(); x++)
            {
                if (rooms[x] != null )
                Console.WriteLine($"Room {x.ToRoman()}: {rooms[x].GetName()}");
            }
        }
    }
}