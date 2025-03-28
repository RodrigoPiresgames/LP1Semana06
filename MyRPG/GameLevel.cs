using System;

namespace MyRPG
{
    public class GameLevel
    {
        private int roomNum;
        private string level;

        public GameLevel(int roomNum, string level)
        {
            this.roomNum = roomNum;
            this.level = level;

        }

        public string GetLevel()
        {
            return level;
        }

        public int GetroomNum()
        {
            return roomNum;
        }
    }
}