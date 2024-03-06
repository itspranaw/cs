using System;
namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename1 = @"E:\\2023-2024\\C#TextFile.txt";
            string text = "Develop a C# program to read a text file and copy the file contents to another  text file.";
        File.WriteAllText(filename1, text);
            // To display current contents of the file
            Console.WriteLine(File.ReadAllText(filename1));
            //Multiline
            string[] textLines1 = { "C#", "Programming", "Lab 7" };
            File.WriteAllLines(filename1, textLines1);
            // To display current contents of the file
            Console.WriteLine(File.ReadAllText(filename1));
            string[] textLines2 = { "V Semester", "SIT CSE" };
            using (StreamWriter writer = new StreamWriter(filename1))

            {
                foreach (string ln in textLines2)
                {
                    writer.WriteLine(ln);
                }
            }
            // To display current contents
            Console.WriteLine(File.ReadAllText(filename1));
            string fileName2 = @"E:\\2023-2024\\C#Textfile2.txt";
            File.Copy(filename1, fileName2, true);
            string file = File.ReadAllText(fileName2);
            Console.WriteLine("After copy :\n" + file + "\n\n\n");
        }
    }
}