using System;
using System.IO;
using System.Text;
using BankAccountKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankAccountKataTest
{
    [TestClass]
    public class PrinterTest
    {
        string path = @"C:\Users\lenovo_3\source\repos\BankAccountKata\GoldenMaster.txt";

        [TestMethod]
        [Ignore]
        public void GenerateGoldenMaster()
        {
            StringBuilder fakeOutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeOutput));

            Program.RunExample();

            string output = fakeOutput.ToString();
            File.WriteAllText(path, output);
        }

        [TestMethod]
        public void VerifyGoldenMaster()
        {
            string fileContent = File.ReadAllText(path);
            string[] fileLines = fileContent.Split('\n');
            StringBuilder fakeOutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeOutput));

            Program.RunExample();

            string output = fakeOutput.ToString();
            string[] outputLines = output.Split('\n');
            for (int i = 0; i < Math.Min(fileLines.Length, outputLines.Length); i++)
            {
                Assert.AreEqual(fileLines[i], outputLines[i]);
            }
        }

    }
}
