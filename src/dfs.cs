using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_altha
{
    internal class dfs
    {
        public List<Tuple<int, int>> dfsPath;
        public List<char> dfsDirection;
        public int dfsSteps;
        public int dfsNodes;
        public long dfsSeconds;
        public dfs()
        {
            dfsPath = new List<Tuple<int, int>>();
            dfsDirection = new List<char>();
            dfsSteps = 0;
            dfsNodes = 0;
            dfsSeconds = 0;
        }
        public dfs(List<Tuple<int, int>> path, List<char> direction, int steps, int nodes, long second)
        {
            dfsPath = path;
            dfsDirection = direction;
            dfsSteps = steps;
            dfsNodes = nodes;
            dfsSeconds = second;
        }

        public static dfs DFS(char[,] map)
        {
            int treasureCount = getTreasureCount(map);
            var time = new System.Diagnostics.Stopwatch();

            // map max row & max column
            int maxRow = map.GetLength(0);
            int maxCol = map.GetLength(1);

            // mark visited points, get starting point and set visited to true
            Tuple<int, int> startingPoint = getStartingPoint(map);
            bool[,] visited = new bool[maxRow, maxCol];
            visited[startingPoint.Item1, startingPoint.Item2] = true;

            // create stack for DFS
            Stack<Tuple<Tuple<int, int>, Tuple<int, int>>> s = new Stack<Tuple<Tuple<int, int>, Tuple<int, int>>>();
            s.Push(new Tuple<Tuple<int, int>, Tuple<int, int>>(startingPoint, startingPoint));

            // create path
            List<Tuple<int, int>> path = new List<Tuple<int, int>>();

            // BFS movement priority = R,D,L,U
            int[] rowMovement = { 0, 1, 0, -1 };
            int[] colMovement = { 1, 0, -1, 0 };

            int nRow = 0, nCol = 0;
            bool isValid;
            Tuple<int, int> currPoint;
            currPoint = s.Pop().Item1;

            time.Start();
            // loop until all treasures found
            while (treasureCount != 0)
            {
                path.Add(currPoint);

                // iterate all neighbors of currPoint
                for (int i = 3; i >= 0; i--)
                {
                    // neighbor row & column index
                    nRow = currPoint.Item1 + rowMovement[i];
                    nCol = currPoint.Item2 + colMovement[i];

                    isValid = nRow >= 0 && nRow < maxRow && nCol >= 0 && nCol < maxCol && !visited[nRow, nCol];

                    // if neighbor valid: add to stack
                    if (isValid && IsPointValid(map[nRow, nCol]))
                    {
                        s.Push(new Tuple<Tuple<int, int>, Tuple<int, int>>(new Tuple<int, int>(nRow, nCol), currPoint));
                    }
                }

                // treasure found
                if (map[s.Peek().Item1.Item1, s.Peek().Item1.Item2] == 'T' && !visited[s.Peek().Item1.Item1, s.Peek().Item1.Item2])
                {
                    treasureCount--;
                }
                visited[currPoint.Item1, currPoint.Item2] = true;
                while (visited[s.Peek().Item1.Item1, s.Peek().Item1.Item2])
                {
                    currPoint = s.Pop().Item1;
                }

                // backtrack path's handle
                if (path.Last() != s.Peek().Item2)
                {
                    Console.WriteLine("backtrack");
                    int idx = path.Count() - 2;
                    Tuple<int, int> search;
                    while (path.Last() != s.Peek().Item2)
                    {
                        search = path[idx];
                        idx = path.FindIndex(x => x == search);
                        path.Add(path[idx]);
                        idx--;
                    }
                }

                currPoint = s.Pop().Item1;
                while (visited[currPoint.Item1, currPoint.Item2])
                {
                    currPoint = s.Pop().Item1;
                }

            }
            path.Add(currPoint);
            time.Stop();
            List<char> pathDirection = IndexToChar(path);
            return new dfs(path, pathDirection, pathDirection.Count(), path.Count(), time.ElapsedMilliseconds);
        }

        public static dfs TSPwithDFS(char[,] map, Tuple<int, int> lastTreasure)
        {
            dfs result = dfs.DFS(map);
            int maxRow = map.GetLength(0);
            int maxCol = map.GetLength(1);
            char[,] mapCopy = new char[maxRow, maxCol];
            Array.Copy(map, mapCopy, map.Length);
            for (int i = 0; i < maxRow; i++)
            {
                for (int j = 0; j < maxCol; j++)
                {
                    if (mapCopy[i, j] == 'T')
                    {
                        mapCopy[i, j] = 'R';
                    }
                    if (mapCopy[i, j] == 'K')
                    {
                        mapCopy[i, j] = 'T';
                    }

                }
            }
            mapCopy[lastTreasure.Item1, lastTreasure.Item2] = 'K';
            dfs tsp = dfs.DFS(mapCopy);

            // merge dfs and tsp
            int nodes = result.dfsNodes + tsp.dfsNodes;
            int steps = result.dfsSteps + tsp.dfsSteps;
            tsp.dfsPath.RemoveAt(0);
            return new dfs((result.dfsPath).Concat(tsp.dfsPath).ToList(), (result.dfsDirection).Concat(tsp.dfsDirection).ToList(), steps, nodes - 1, tsp.dfsSeconds);
        }

        private static bool IsPointValid(char point)
        {
            switch (point)
            {
                case 'R':
                    return true;
                case 'T':
                    return true;
                case 'K':
                    return true;
                default:
                    return false;
            }
        }

        private static Tuple<int, int> getStartingPoint(char[,] map)
        {
            int maxRow = map.GetLength(0);
            int maxCol = map.GetLength(1);
            for (int i = 0; i < maxRow; i++)
            {
                for (int j = 0; j < maxCol; j++)
                {
                    if (map[i, j] == 'K')
                    {
                        return new Tuple<int, int>(i, j);
                    }
                }
            }
            return new Tuple<int, int>(-1, -1);
        }

        private static int getTreasureCount(char[,] map)
        {
            int maxRow = map.GetLength(0);
            int maxCol = map.GetLength(1);

            int treasureCount = 0;
            for (int i = 0; i < maxRow; i++)
            {
                for (int j = 0; j < maxCol; j++)
                {
                    if (map[i, j] == 'T')
                    {
                        treasureCount++;
                    }
                }
            }
            return treasureCount;
        }
        public static void PrintPoints(List<Tuple<int, int>> points)
        {
            for (int i = 0; i < points.Count; i++)
            {
                Console.Write(points[i].Item1.ToString() + "," + points[i].Item2.ToString() + " -> ");
            }
            Console.WriteLine();
        }

        static List<char> IndexToChar(List<Tuple<int, int>> Solution)
        {
            List<char> solutionInChar = new List<char>();
            for (int i = 0; i < Solution.Count - 1; i++)
            {
                if (Solution[i + 1].Item1 - Solution[i].Item1 == 0 && Solution[i + 1].Item2 - Solution[i].Item2 == -1)
                {
                    solutionInChar.Add('L');
                }
                else if (Solution[i + 1].Item1 - Solution[i].Item1 == 0 && Solution[i + 1].Item2 - Solution[i].Item2 == 1)
                {
                    solutionInChar.Add('R');
                }
                else if (Solution[i + 1].Item1 - Solution[i].Item1 == -1 && Solution[i + 1].Item2 - Solution[i].Item2 == 0)
                {
                    solutionInChar.Add('U');
                }
                else if (Solution[i + 1].Item1 - Solution[i].Item1 == 1 && Solution[i + 1].Item2 - Solution[i].Item2 == 0)
                {
                    solutionInChar.Add('D');
                }
            }
            return solutionInChar;
        }

    }
}