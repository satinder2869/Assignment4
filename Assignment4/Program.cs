using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;

namespace Assignment4
{
    class Program
    {
        ArrayList Beowulf;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.ReadTextFiles();
            p.find();
            p.Word();
            p.Letters();
            Console.ReadKey();
        }
        public void Run() { this.ReadTextFiles(); }

        public void ReadTextFiles()
        {

            StreamReader reader = new StreamReader("U:/Users/730484/Beowulf.txt");
            string script = reader.ReadToEnd();

            var text = script.Trim();
            int Count = 0, index = 0;

            while (index < text.Length)
            {
                while (index < text.Length && !char.IsWhiteSpace(text[index]))
                    index++;

                Count++;

                while (index < text.Length && char.IsWhiteSpace(text[index]))
                    index++;
            }

            Console.WriteLine("Total Words are " + Count);

        }
        public void find()

        {
            int ABC = 0;
            foreach (var line in File.ReadAllLines("U:/Users/730484/Beowulf.txt"))
            {
                if (line.Contains("sea") && line.Contains("fare"))
                {
                    ABC++;
                }

            }
            Console.WriteLine("Total words of sea and fare :" + ABC);

        }
        public void Word()
        {
            int ABC = 0, DEF = 0, GHI = 0;

            foreach (var line in File.ReadAllLines("U:/Users/730484/Beowulf.txt"))
            {
                if (line.Contains("fare"))
                { ABC++; }
            }
            foreach (var line in File.ReadAllLines("U:/Users/730484/Beowulf.txt"))
            {
                if (line.Contains("war") && line.Contains("fare"))
                {
                    DEF++;
                }

            }
            GHI = ABC - DEF;


            Console.WriteLine("Total Lines which contain fare but not war: " + GHI);
        }
        public void Letters()
        {

            StreamReader reader = new StreamReader("U:/Users/730484/Beowulf.txt");
            string script = reader.ReadToEnd();
            int n = 0;
            foreach (char letter in script)
            { n++; }
            Console.WriteLine("Number of letters: " + n);

        }
        public int FindNumberOfBlankSpaces(string line)
        {

            int countletters = 0;
            int countSpaces = 0;

            foreach (char c in line)
            {
                if (char.IsLetter(c))
                {
                    countletters++;
                }

                if (char.IsWhiteSpace(c))
                {
                    countletters++;
                }
            }
            return countSpaces;

        }
    }
}
