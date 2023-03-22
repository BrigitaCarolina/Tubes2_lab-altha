using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Diagnostics;
using System.ComponentModel.Design;

namespace lab_altha
{
    internal class bfs
    {
        public List<Tuple<int, int>> bfsPath;
        public List<char> bfsDirection;
        public int bfsSteps;
        public int bfsNodes;
        public long bfsSeconds;
        public bfs() {
            bfsPath = new List<Tuple<int, int>>();
            bfsDirection = new List<char>();
            bfsSteps = 0;
            bfsNodes = 0;
            bfsSeconds = 0;
        }

        public bfs(List<Tuple<int, int>> path, List<char> direction, int steps, int nodes, long second) {
            bfsPath = path;
            bfsDirection = direction;
            bfsSteps = steps;
            bfsNodes = nodes;
            bfsSeconds = second;
        } 

        // BFS Algorithm
        public static bfs BFS(char[,] map)
        {
            char[,] mapinsinde = new char[map.GetLength(0), map.GetLength(1)];
            Array.Copy(map, mapinsinde, map.Length);
            int countT = 0;
            Tuple<int, int> start = Tuple.Create(0, 0);
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == 'T')
                    {
                        countT++;
                    }
                    if (map[i, j] == 'K')
                    {
                        start = new Tuple<int, int>(i, j);
                    }
                }
            }
            // Defining direction
            Tuple<int, int>[] directions =
            {
                Tuple.Create(0, 1), // right
                Tuple.Create(1, 0), // down
                Tuple.Create(0, -1), // left
                Tuple.Create(-1, 0) // up
            };

            // Queue for BFS
            Queue<Tuple<int, int>> pathqueue = new Queue<Tuple<int, int>>();
            pathqueue.Enqueue(start);

            // Dictionary to store parrent of each point
            Dictionary<Tuple<int, int>, Tuple<int, int>> pathParent = new Dictionary<Tuple<int, int>, Tuple<int, int>>();
            pathParent[start] = null;

            int count = 0;
            int nodesCount = 0;
            int steps = 0;
            List<Tuple<int, int>> allPath = new List<Tuple<int, int>>();
            Tuple<int, int> tempCurrent = new Tuple<int, int>(0, 0);
            Tuple<int, int> tempCurrent2 = new Tuple<int, int>(0, 0);

            Stopwatch s = new Stopwatch();
            s.Start();
            Dictionary<Tuple<int, int>, Tuple<int, int>> tempPathParent = new Dictionary<Tuple<int, int>, Tuple<int, int>>();
            while (pathqueue.Count > 0)
            {
                Tuple<int, int> current = pathqueue.Dequeue();
                // Check if we've found the treasure 'T'

                if (mapinsinde[current.Item1, current.Item2] == 'T' && count < countT - 1)
                {
                    count++;
                    mapinsinde[current.Item1, current.Item2] = 'R';
                    List<Tuple<int, int>> path = new List<Tuple<int, int>>();
                    pathqueue.Clear();
                    tempCurrent = current;
                    if (count == 1)
                    {
                        while (current != null)
                        {
                            path.Add(current);
                            tempPathParent[current] = pathParent[current];
                            current = pathParent[current];
                        }
                    }
                    else
                    {
                        while (current != tempCurrent2)
                        {
                            path.Add(current);
                            tempPathParent[current] = pathParent[current];
                            current = pathParent[current];
                        }
                        tempPathParent[current] = pathParent[current];
                    }
                    path.Reverse();
                    foreach (Tuple<int, int> solution in path)
                    {
                        allPath.Add(solution);
                    }
                    current = tempCurrent;
                    tempCurrent2 = current;
                    pathParent.Clear();
                    pathParent = new Dictionary<Tuple<int, int>, Tuple<int, int>>();
                }
                else if (mapinsinde[current.Item1, current.Item2] == 'T' && count == countT - 1)
                {
                    List<Tuple<int, int>> path = new List<Tuple<int, int>>();
                    // Construct current path to treasure
                    if (count == 0)
                    {
                        while (current != null)
                        {
                            path.Add(current);
                            current = pathParent[current];
                        }
                        path.Reverse();
                    }
                    else
                    {
                        while (current != tempCurrent)
                        {
                            path.Add(current);
                            current = pathParent[current];
                        }
                        path.Reverse();
                    }
                    {
                        foreach (Tuple<int, int> solution in path)
                            allPath.Add(solution);
                    }
                    s.Stop();
                    long seconds = s.ElapsedMilliseconds;
                    steps = allPath.Count - 1;
                    return new bfs(allPath, IndexToChar(allPath), steps, nodesCount, seconds);
                }

                // Explore neighbours of the current point
                foreach (Tuple<int, int> direction in directions)
                {
                    Tuple<int, int> neighbor = Tuple.Create(
                        current.Item1 + direction.Item1,
                        current.Item2 + direction.Item2
                    );

                    if (isPointValid(map, neighbor) && !pathParent.ContainsKey(neighbor))
                    {
                        nodesCount++;
                        pathqueue.Enqueue(neighbor);
                        pathParent[neighbor] = current;
                    }
                }
            }
            s.Stop();
            long second = s.ElapsedMilliseconds;
            return new bfs(allPath, IndexToChar(allPath), steps, nodesCount, second);
        }

        public static bfs TSPWithBFS(char[,] map, Tuple<int, int> lastTreasure) {
            bfs BFSAnswer = bfs.BFS(map);
            int maxRow = map.GetLength(0);
            int maxCol = map.GetLength(1);
            char[,] mapinside = new char[maxRow, maxCol];
            Array.Copy(map, mapinside, map.Length);
            for (int i = 0; i < maxRow; i++)
            {
                for (int j = 0; j < maxCol; j++)
                {
                    if (mapinside[i, j] == 'T')
                    {
                        mapinside[i, j] = 'R';
                    }
                    if (mapinside[i, j] == 'K')
                    {
                        mapinside[i, j] = 'T';
                    }

                }
            }
            mapinside[lastTreasure.Item1, lastTreasure.Item2] = 'K';
            bfs TSP = bfs.BFS(mapinside);
            List<Tuple<int, int>> solutions = new List<Tuple<int, int>>(); 
            for (int i = 0; i < BFSAnswer.bfsPath.Count; i++) {
                solutions.Add(BFSAnswer.bfsPath[i]);
            }
            for (int i = 1; i < TSP.bfsPath.Count; i++) {
                solutions.Add(TSP.bfsPath[i]);
            }
            List<char> solutionsInChar = new List<char>();
            for (int i = 0; i < BFSAnswer.bfsDirection.Count; i++) {
                solutionsInChar.Add(BFSAnswer.bfsDirection[i]);
            }
            for (int i = 0; i < TSP.bfsDirection.Count; i++) {
                solutionsInChar.Add(TSP.bfsDirection[i]);
            }
            int steps = BFSAnswer.bfsSteps + TSP.bfsSteps;
            int nodes = BFSAnswer.bfsNodes + TSP.bfsNodes;
            return new bfs(solutions, solutionsInChar, steps, nodes, TSP.bfsSeconds);
        }

        static bool isPointValid(char[,] map, Tuple<int, int> point)
        {
            int row = point.Item1;
            int col = point.Item2;

            if (row < 0 || row >= map.GetLength(0))
            {
                return false;
            }
            if (col < 0 || col >= map.GetLength(1))
            {
                return false;
            }
            if (map[row, col] == 'X')
            {
                return false;
            }

            return true;
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
