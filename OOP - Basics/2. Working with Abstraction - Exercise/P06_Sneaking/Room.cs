using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace P06_Sneaking
{
    class Room
    {
        private char[][] matrix;
        private bool finishProcess;

        public Room(int rows)
        {
            this.Matrix = new char[rows][];
            this.FinishProcess = false;
        }

        public char[][] Matrix
        {
            get => matrix;
            set => matrix = value;
        }

        public bool FinishProcess
        {
            get => finishProcess;
            set => finishProcess = value;
        }

        public void InitializeMatrix(int row, char[] coordinate)
        {
            this.Matrix[row] = new char[coordinate.Length];
            for (int col = 0; col < coordinate.Length; col++)
            {
                this.Matrix[row][col] = coordinate[col];
            }
        }

        public int[] SamPosition()
        {
            int[] position = new int[2];
            bool findPosition = false;
            for (int row = 0; row < this.Matrix.Length; row++)
            {
                for (int col = 0; col < this.Matrix[row].Length; col++)
                {
                    if (this.Matrix[row][col] == 'S')
                    {
                        position[0] = row;
                        position[1] = col;
                        findPosition = true;
                        break;
                    }
                }

                if (findPosition) break;
            }

            return position;
        }

        public void MoveEnemies()
        {
            for (int row = 0; row < this.Matrix.Length; row++)
            {
                for (int col = 0; col < this.Matrix[row].Length; col++)
                {
                    char pos = this.Matrix[row][col];
                    if(pos == 'b')
                    {
                       if(col == this.Matrix[row].Length - 1)
                        {
                            this.Matrix[row][col] = 'd';
                        }
                        else
                        {
                            this.Matrix[row][col] = '.';
                            this.Matrix[row][++col] = 'b';
                        }
                    }
                    else if(pos == 'd')
                    {
                        if(col == 0)
                        {
                            this.Matrix[row][col] = 'b';
                        }
                        else
                        {
                            this.Matrix[row][col] = '.';
                            this.Matrix[row][--col] = 'd';
                        }
                    }
                }
            }
        }

        private void SamDied(int row, int sam)
        {
            this.Matrix[row][sam] = 'X';
            Console.WriteLine($"Sam died at {row}, {sam}");
            this.FinishProcess = true;
        }

        public void CheckForEnemy()
        {
            for (int row = 0; row < this.Matrix.Length; row++)
            {
                string checkRow = new string(this.Matrix[row]); 
                int sam = checkRow.IndexOf('S');
                int b = checkRow.IndexOf('b');
                int d = checkRow.IndexOf('d');
                if(sam > b && sam != -1 && b != -1)
                {
                    this.SamDied(row, sam);
                    return;
                }
                else if(d > sam && d != -1 && sam != -1)
                {
                    this.SamDied(row, sam);
                    return;
                }
            }
        }

        public void MoveSam(char move)
        {
            int[] position = this.SamPosition();
            switch (move)
            {
                case 'U':
                    this.Matrix[position[0]][position[1]] = '.';
                    this.Matrix[--position[0]][position[1]] = 'S';
                    break;
                case 'D':
                    this.Matrix[position[0]][position[1]] = '.';
                    this.Matrix[++position[0]][position[1]] = 'S';
                    break;
                case 'L':
                    this.Matrix[position[0]][position[1]] = '.';
                    this.Matrix[position[0]][--position[1]] = 'S';
                    break;
                case 'R':
                    this.Matrix[position[0]][position[1]] = '.';
                    this.Matrix[position[0]][++position[1]] = 'S';
                    break;
                default: break;
            }
        }

        public void CheckForNikoladze()
        {
            for (int row = 0; row < this.Matrix.Length; row++)
            {
                if (this.Matrix[row].Contains('N') && this.Matrix[row].Contains('S'))
                {
                    this.Matrix[row][Array.IndexOf(this.Matrix[row], 'N')] = 'X';
                    Console.WriteLine($"Nikoladze killed!");
                    this.FinishProcess = true;
                    return;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int row = 0; row < this.Matrix.Length; row++)
            {               
                for (int col = 0; col < this.Matrix[row].Length; col++)
                {
                    builder.Append(this.Matrix[row][col]);
                }
                builder.AppendLine();
            }

            return builder.ToString().TrimEnd();
        }
    }
}
