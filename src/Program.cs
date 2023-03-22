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
            Console.WriteLine("tes");
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            Console.WriteLine("tes");
            // MAIN
            Console.WriteLine("This is Treasure Hunt Solver with BFS!");

            char[,] matrix = {{'K', 'R', 'R', 'T', 'R', 'R'},
                              {'X', 'X', 'R', 'X', 'R', 'X'},
                              {'R', 'R', 'R', 'X', 'X', 'T'},
                              {'x', 'X', 'R', 'R', 'R', 'R'},
                              {'X', 'R', 'X', 'X', 'X', 'R'},
                              {'T', 'R', 'R', 'R', 'R', 'R'}};

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            bfs Answer = bfs.BFS(matrix);
            (List<Tuple<int, int>> solutions, List<char> solutionsInChar, int steps, int nodes, long seconds) = (Answer.bfsPath, Answer.bfsDirection, Answer.bfsSteps, Answer.bfsNodes, Answer.bfsSeconds);

            bfs Answer2 = bfs.TSPWithBFS(matrix, solutions[solutions.Count-1]);
            (List<Tuple<int, int>> solutions2, List<char> solutionsInChar2, int steps2, int nodes2, long seconds2) = (Answer2.bfsPath, Answer2.bfsDirection, Answer2.bfsSteps, Answer2.bfsNodes, Answer2.bfsSeconds);
 

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

            Console.WriteLine("This is TSP with BFS!");
            if (solutions2 != null)
            {
                for (int i = 0; i < solutions2.Count; i++)
                {
                    Console.Write(solutions2[i].Item1 + "," + solutions2[i].Item2);
                    if (i != solutions2.Count - 1)
                    {
                        Console.Write(" - ");
                    }
                }
                Console.WriteLine();
                for (int i = 0; i < solutionsInChar2.Count; i++)
                {
                    Console.Write(solutionsInChar2[i]);
                    if (i != solutionsInChar2.Count - 1)
                    {
                        Console.Write(" - ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Steps: " + steps2);
                Console.WriteLine("Nodes: " + nodes2);
                long secondsAnswer = seconds + seconds2; 
                Console.WriteLine("Execution Time: " + secondsAnswer);

            }

            if (solutions2 == null)
            {
                Console.WriteLine("Solutions null!");
            }

            Console.WriteLine();
            

            Console.WriteLine();

            Console.WriteLine("BFSS");
            char[,] map = { {'X','X','T','X','X','T'},
                             {'X','X','R','X','X','R'},
                             {'K','R','R','R','R','R'},
                             {'X','R','X','X','R','X'},
                             {'X','T','X','X','R','X' } };
            dfs result = dfs.DFS(map);
            Console.WriteLine("DFS Solution: ");
            dfs.PrintPoints(result.dfsPath);
            Console.WriteLine();
            Console.WriteLine("direction: ");
            foreach (var item in result.dfsDirection)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Steps: " + result.dfsSteps);
            Console.WriteLine("Nodes: " + result.dfsNodes);
            Console.WriteLine("Execution time: " + result.dfsSeconds + " ms");

            dfs tsp = dfs.TSPwithDFS(map, result.dfsPath[result.dfsPath.Count()-1]);
            Console.WriteLine("TSP : ");
            foreach(var item in tsp.dfsPath)
            {
                Console.WriteLine(item);
            }

        }
    }
}