using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LootAlert.ItemFinding
{
    [Serializable]
    public class ItemFilter : Filter
    {
        public int MinLVL;
        public ItemQuality Quality;
        private List<ItemType> WhiteList;

        public ItemFilter()
        {
            Type = FilterType.Item;
            WhiteList = new List<ItemType>();
            WhiteList.AddRange(ItemFilterEditor.items);
        }

        public override bool CheckActor(ACDActor a)
        {
            if (a.ACDType == ACDType.Item)
            {
                Item item = new Item(a);
                if (Quality != ItemQuality.Undefined && item.Quality != Quality)
                    return false;
                if (Enabled && IsAllowed(item.ItemType) && item.ItemLevel >= MinLVL)
                    return true;
            }
            return false;
        }

        public bool IsAllowed(ItemType item)
        {
            return WhiteList.Contains(item) == true;
        }

        public void SetAllowed(ItemType item, bool status)
        {
            if (status)
            {
                if(IsAllowed(item) == false)
                    WhiteList.Add(item);
            }
            else
            {
                WhiteList.Remove(item);
            }
        }
    }
}
