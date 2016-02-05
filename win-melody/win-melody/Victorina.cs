using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace win_melody
{
    static class Victorina
    {
        static public List<string> list = new List<string>();

        static public int gameDuration = 60;
        static public int musicDuration = 10;
        static public bool randomStart = false;
        static public string lastFolder = "";
        static public bool allDirectories = false;

        static public void ReadMusic()
        {
            string[] music_list = Directory.GetFiles(lastFolder, "*.mp3", allDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
            list.Clear();
            list.AddRange(music_list);
        }

        static string regKeyName = "Software\\MyCompanyName\\Victorina";


    }
}
