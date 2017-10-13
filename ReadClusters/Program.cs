using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadClusters
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            var clusterDic = new Dictionary<string, List<string>>();
            try
            {
                var filename1 = "s:\\RJFAF628.FSC";
                var filename2 = "s:\\RJFAF628.FFL";

                // read the clusters file:
                foreach (var line in System.IO.File.ReadLines(filename1))
                {
                    if (line.Length > 8)
                    {
                        var cluster = line.Substring(1, 4);
                        var member = line.Substring(5, 4);
                        DictUtils.AddEntry(clusterDic, cluster, member);
                    }
                }

                // read the flow file:
                var nlcCodes = new HashSet<string>();
                foreach (var line in System.IO.File.ReadLines(filename2))
                {
                    if (line.Length > 2 & line[0] == 'R' && line[1] == 'F')
                    {
                        nlcCodes.Add(line.Substring(2, 4));
                        nlcCodes.Add(line.Substring(6, 4));
                    }
                }

                var finalCodes = new HashSet<string>();

                foreach (var code in nlcCodes)
                {
                    if (nlcCodes.Contains())
                    {

                    }
                }

                    Console.WriteLine();
            }
            catch (Exception ex)
            {
                var codeBase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
                var progname = Path.GetFileNameWithoutExtension(codeBase);
                Console.Error.WriteLine(progname + ": Error: " + ex.Message);
            }

        }
    }
}
