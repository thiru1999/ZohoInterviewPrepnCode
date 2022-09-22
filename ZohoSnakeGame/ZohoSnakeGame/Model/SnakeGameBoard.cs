using System.Collections.Generic;

namespace ZohoSnakeGame.Model
{
    public class SnakeGameBoard
    {
        public int Width { get; }
        public int Height { get; }
        public int SnakeLength { get; set; } = 1;
        public bool SnakeAlive;
        public int Dummy = 0;
        int currentFoodPosX = 0;
        int currentFoodPosY = 0;
        int snakePosX = 0;
        int snakePosY = 0;
        public SnakePosition pos; // declaRING explicitly in order to acces from the other function like MOVE in the same class
        public int Score { get; set; } = 0;

        public int[,] FoodPos;
        Queue<List<int>> StoringSnakePosition = new Queue<List<int>>();
        public SnakeGameBoard(int width, int height, int[,] arr)
        {
            Width = width;
            Height = height;
            FoodPos = arr;
            this.SnakeAlive = true;
            this.currentFoodPosX = arr[0,0];
            this.currentFoodPosY = arr[0, 1];

            StoringSnakePosition.Enqueue(new List<int> { 0, 0 });

        }

        public int Move(string Direction)
        {


            if (Direction == "R" || Direction == "r")
            {

                snakePosY++;
                bool alive = IsSnakeAlive();
                if (alive == true)
                {
                    MovingSnake();
                    return Score;
         
                }
                else
                {
                    return -1;
                }

            }

            if (Direction == "D" || Direction == "d")
            {

                snakePosX++;
                bool alive = IsSnakeAlive();
                if (alive == true)
                {
                    MovingSnake();
                    return Score;

                }
                else
                {
                    return -1;
                }

            }


            return 1;
        }
        public void MovingSnake()
        {
            StoringSnakePosition.Enqueue(new List<int> { snakePosX, snakePosY });
            if (snakePosX == currentFoodPosX && snakePosY == currentFoodPosY)
            {
               
                Dummy++;
                if (Dummy < FoodPos.GetLength(0))
                {
                    Score++;
                    currentFoodPosX = FoodPos[Dummy, 0];  //If food Not Preset Changing the Food Position
                    currentFoodPosY = FoodPos[Dummy, 1];

                }
                else
                {
                    return;
                }
                
               
            }
            else
            {
                StoringSnakePosition.Dequeue();

            }

        }

        public bool IsSnakeAlive()
        {
            int dummyStateForLoopVar = 0;
            if (snakePosX > Width || snakePosY > Height || snakePosX==-1 || snakePosY==-1)
            {
                return false;
            }
            foreach (List<int> l in StoringSnakePosition)
            {
                if (l[0] == snakePosX && l[1] == snakePosY)
                {
                    return false;
                }

            }
            return true;


        }
    }
}
