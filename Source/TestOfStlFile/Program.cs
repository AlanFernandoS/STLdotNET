    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;
using QuantumConcepts;
using QuantumConcepts.Formats.StereoLithography;
namespace TestOfStlFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var Colors = new Color[] { Color.Black, Color.White };
            Console.WriteLine("Test of Stl, please give a valid route to a STL file: ",Color.Cyan);

            var RouteOfFile = Console.ReadLine();
            try
            {
                var FileStl = STLDocument.Open(RouteOfFile);
                Console.WriteLine("Name: " + FileStl.Name);
                Console.WriteLine("Reading the file...",  Color.Green);
                foreach (var v in FileStl.Facets)
                {
                    foreach(var j in v.Vertices)
                    {
                        Console.WriteLine(String.Format("Vertex-> x:{0}\t,y:{1},z{0}",j.X.ToString(),j.Y.ToString(),j.Z.ToString()));
                    }
                    Console.WriteLine(String.Format("Normal-> x:{0}\t,y:{1},z{0}", v.Normal.X, v.Normal.Y, v.Normal.Z),Color.LightBlue);
                }
            }
            catch(System.Exception Error) {
                Console.WriteLine("Error" + Error.Message.ToString(), Color.Red);
            }
            Console.WriteLine("Ended program...");
            Console.ReadLine();
        }
    }
}
