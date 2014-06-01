using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LootAlert.ItemFinding
{
    class ItemFinder : IDisposable
    {
        private DiabloIII d3;
        private List<ACDActor> IgnoreList;
        private int LastLevelArea;

        public ItemFinder()
        {
            d3 = new DiabloIII();
            IgnoreList = new List<ACDActor>();
        }

        public ItemFinder(int processID)
        {
            d3 = new DiabloIII(processID);
            IgnoreList = new List<ACDActor>();
        }

        public ACDActor FindBestItem()
        {
            if (d3.Valid == false)
                return null;
            ACDActor player = d3.Player();
            if (player == null || player.IsValid() == false)
            {
                return null;
            }

            if (LastLevelArea != d3.CurrentLevelArea())
            {
                IgnoreList.Clear();
                LastLevelArea = d3.CurrentLevelArea();
            }

            foreach (ACDActor a in d3.GetACDActors())
            {
                if (a.IsValid() == false)
                    continue;
                if (IgnoreList.Contains(a))
                    continue;

                if(Settings.ShouldPlay(a))
                {
                    IgnoreList.Add(a);
                    return a;
                }
            }
            return null;
        }

        public void Dispose()
        {
            d3.Dispose();
        }
    }
}
