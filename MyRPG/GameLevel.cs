using System;

namespace MyRPG
{
    public class GameLevel
    {
        private Enemy[] rooms;
        private string level;

        public GameLevel(int roomNum, string level)
        {
            rooms = new Enemy[roomNum];
            this.level = level;

        }

        public string GetLevel()
        {
            return level;
        }

        public int GetroomNum()
        {
            return rooms.Length;
        }

        public int GetEnemyNum()
        {
            int enemyNum = 0;
            foreach(Enemy foe in rooms)
                enemyNum += 1;
            return enemyNum;
        }

        public void SetEnemyInRoom(int room, Enemy enemy)
        {

        } 
    }
}