using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using LootAlert.ItemFinding;

namespace LootAlert
{
    class Settings
    {
        public static List<Filter> filters;
        private const string SettingsFile = "Settings.bin";

        public static void load()
        {
            try
            {
                using (Stream stream = File.Open(SettingsFile, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    filters = (List<Filter>)bin.Deserialize(stream);
                }
            }
            catch (Exception)
            {
                filters = new List<Filter>();
            }

            foreach (Filter f in filters)
            {
                f.sound = Sounds.GetSoundFromFileName(f.soundName);
            }
        }

        public static void save()
        {
            using (Stream stream = File.Open(SettingsFile, FileMode.Create))
            {
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, filters);
            }
        }

        public static bool ShouldPlay(ACDActor a)
        {
            foreach (Filter t in filters)
            {
                if (t.CheckActor(a) == true)
                    return true;
            }
            return false;
        }

        public static void PlaySoundForActor(ACDActor a)
        {
            foreach (Filter t in filters)
            {
                if (t.CheckActor(a) == true)
                {
                    t.sound.Play();
                    return;
                }
            }
        }
    }
}
