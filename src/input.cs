using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_altha
{
    /*    internal class input
        {

        }*/

    class InputFile {
        public static string fileName = "";
        //public static List<char> setFirst;
        //public static string[] result;
        //public static char[,] fixMatrix;

        public static string fileInputName { get { return fileName; } set { fileName = value; } }
       // public static List<char> getFromButton { get { return setFirst; } set { setFirst = value; } }

        //public static char[,] toProcess { get { return fixMatrix; } set { fixMatrix = value; } }

        public static string readFile(string fileName)
        {
            List<List<char>> readMatrix;
            readMatrix = new List<List<char>>();

            string dir = Directory.GetCurrentDirectory();
            string proj = "bin";
            string dirFix = dir.Substring(0, dir.IndexOf(proj) - 1);
            string inputText = dirFix + fileName;

            string tes = "input";
            return tes;
        }

        public static char[,] toMatrix(string fileName)
        {
            string dir = Directory.GetCurrentDirectory();
            string proj = "src";
            string dirFix = dir.Substring(0, dir.IndexOf(proj) - 1);
            string textFile = dirFix + @"\test\" + fileName;
            string[] lines = File.ReadAllLines(textFile);
            int row = lines.Length;
            int count = 0;
            List<int> countEach = new List<int>();
            int countEachLine = 0;
            List<String> readMat = new List<String>();
            string firstText = lines[0];

            string[] text = firstText.Split(" ");
            int col = text.Length;


            foreach (string line in lines)
            {
                string[] words = line.Split(" ");
                countEachLine = words.Length;
                countEach.Add(countEachLine);
                readMat.AddRange(words);
                count++;
            }

            char[,] fixMatrix = new char[row, col];
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    fixMatrix[i, j] = char.Parse(readMat[(col * i) + j]);
                }
            }
            return fixMatrix;

        }
        


    }

}
