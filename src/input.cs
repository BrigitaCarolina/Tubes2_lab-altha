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
        public static string[] result;
        
        public static string fileInputName { get { return fileName; } set { fileName = value; } }

        public static string readFile(string fileName)
        {
            List<List<char>> readMatrix;
            readMatrix = new List<List<char>>();

            string dir = Directory.GetCurrentDirectory();
            string proj = "bin";
            string dirFix = dir.Substring(0, dir.IndexOf(proj) - 1);
            string inputText = dirFix + fileName;

           
            
            string[] lines = File.ReadAllLines(inputText).split(' ');
            string[] column = lines[0].Split(lines[0], ' ');
          
            int row = lines.Length;
            int col = column.Length;
            string[] separate = new string[row*col];
            string tes;
            
            foreach(string line in lines)
            {
                separate = line.Split(line, ' ');
            }
            tes = separate[0] + separate[1] + separate[2] + separate[3];

           
      









            return tes;
        }
    }

}
