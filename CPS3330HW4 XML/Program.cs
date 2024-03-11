// Michael Banko - CPS3330 HW4
using System;
using System.IO;
using System.Xml;
using static System.Console;
using static System.IO.Path;
using static System.Environment;

namespace XML {
    class Program {
        static void Main(string[] args) {
            string[] days = new string[] {"Sunday", "Monday", "Tuesday", "Wednesday","Thursday", "Friday", "Saturday"};

            // find current directory
            string path = Directory.GetCurrentDirectory();
            // string target = @"c:\temp";
            Console.WriteLine("The current directory is {0}", path);

            string xmlFile = Combine(CurrentDirectory, "streams.xml");// define a file to write to
            FileStream xmlFileStream = File.Create(xmlFile);// create a file stream

            // wrap the file stream in an XML writer helper and automatically indent nested elements 
            XmlWriter xml = XmlWriter.Create(xmlFileStream, new XmlWriterSettings { Indent = true });

            xml.WriteStartDocument(); // write the XML declaration 
            xml.WriteStartElement("week");// write a root element 

            // enumerate the strings writing each one to the stream 
            foreach (string item in days) {
                xml.WriteElementString("days", item);
            }

            xml.WriteEndElement();  // write the close root element 
            xml.Close();// close helper 
            xmlFileStream.Close();// close  stream 

            // output all the contents of the file 
            WriteLine("{0} contains {1:N0} bytes.",
              arg0: xmlFile,
              arg1: new FileInfo(xmlFile).Length);

            WriteLine(File.ReadAllText(xmlFile));
        }
    }
}
