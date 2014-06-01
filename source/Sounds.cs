using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Windows.Forms;
using System.IO;

namespace LootAlert
{
    class Sounds
    {
        public static SoundPlayer GetSoundFromFileName(string name)
        {
            string path = Application.StartupPath + "\\" + name;

            if (File.Exists(path) == false)
                return null;

            if (Path.GetExtension(path) != ".wav")
                return null;

            SoundPlayer sp = new SoundPlayer(path);
            sp.Load();
            return sp;
        }
    }
}
