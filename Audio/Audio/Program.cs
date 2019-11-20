using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace Audio
{
    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                TimeSpan totalTime = DateTime.Now-DateTime.Now;
                foreach (var file in GetFileInfo())
                {
                    Mp3FileReader reader = new Mp3FileReader(file.FullName);
                    TimeSpan duration = reader.TotalTime;
                    totalTime += duration;
                    
                }
                Console.WriteLine(totalTime);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }

        public static IList<FileInfo> GetFileInfo()
        {
            DirectoryInfo directories = new DirectoryInfo("C:\\TestAudio");
            var extensions = new string[] { "*.mp3" };
            var files = extensions.SelectMany(ext => directories.GetFiles(ext, SearchOption.AllDirectories));

            return files.ToList();
        }
    }

}
