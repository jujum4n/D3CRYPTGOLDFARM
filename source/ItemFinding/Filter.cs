using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;

namespace LootAlert.ItemFinding
{
    [Serializable]
    public abstract class Filter
    {
        public bool Enabled;
        public string Name = string.Empty;
        public FilterType Type { get; protected set; }
        public string soundName = string.Empty;

        [NonSerialized]
        public SoundPlayer sound;

        public abstract bool CheckActor(ACDActor a);

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            if (obj.ToString() == Name)
                return true;
            return false;
        }
    }

    public enum FilterType
    {
        Item,
        Name
    }
}
