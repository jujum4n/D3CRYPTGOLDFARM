using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LootAlert.ItemFinding
{
    [Serializable]
    class NameFilter : Filter
    {
        public string nameFilter;

        public NameFilter()
        {
            Type = FilterType.Name;
        }

        public override bool CheckActor(ACDActor a)
        {
            return Enabled && a.Name.Contains(nameFilter);
        }
    }
}
