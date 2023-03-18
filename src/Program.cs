namespace lab_altha
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            Console.WriteLine("tes");
            // MAIN
            Console.WriteLine("This is Treasure Hunt Solver with BFS!");
            int rows = 4;
            int cols = 4;

            // creating matrix of characters
            char[,] matrix = new char[rows, cols];

            // assigning characters to matrix 
            matrix[0, 0] = 'K';
            matrix[0, 1] = 'R';
            matrix[0, 2] = 'R';
            matrix[0, 3] = 'R';
            matrix[1, 0] = 'X';
            matrix[1, 1] = 'R';
            matrix[1, 2] = 'X';
            matrix[1, 3] = 'T';
            matrix[2, 0] = 'X';
            matrix[2, 1] = 'T';
            matrix[2, 2] = 'R';
            matrix[2, 3] = 'R';
            matrix[3, 0] = 'X';
            matrix[3, 1] = 'R';
            matrix[3, 2] = 'X';
            matrix[3, 3] = 'X';

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            bfs Answer = bfs.BFS(matrix);
            (List<Tuple<int, int>> solutions, List<char> solutionsInChar, int steps, int nodes, long seconds) = (Answer.bfsPath, Answer.bfsDirection, Answer.bfsSteps, Answer.bfsNodes, Answer.bfsSeconds);

            if (solutions != null)
            {
                for (int i = 0; i < solutions.Count; i++)
                {
                    Console.Write(solutions[i].Item1 + "," + solutions[i].Item2);
                    if (i != solutions.Count - 1)
                    {
                        Console.Write(" - ");
                    }
                }
                Console.WriteLine();
                for (int i = 0; i < solutionsInChar.Count; i++)
                {
                    Console.Write(solutionsInChar[i]);
                    if (i != solutionsInChar.Count - 1)
                    {
                        Console.Write(" - ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Steps: " + steps);
                Console.WriteLine("Nodes: " + nodes);
                Console.WriteLine("Execution Time: " + seconds);

            }

            if (solutions == null)
            {
                Console.WriteLine("Solutions null!");
            }

            Console.WriteLine();
        }
    }
}