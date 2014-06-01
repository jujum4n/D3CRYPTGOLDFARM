using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LootAlert
{
    public class Item : ACDActor
    {
        private static Dictionary<int, int> GBData;

        public int ItemLevel { get; private set; }
        private string ItemName;
        public ItemType ItemType { get; private set; }
        private int GBID { get { return reader.ReadInt(ACDAddress + 0xB4); } }

        public ItemQuality Quality
        {
            get
            {
                int QLevel = GetInt(Attrib.Item_Quality_Level);
                if (QLevel >= 9)
                    return ItemQuality.Legendary;
                else if (QLevel >= 6)
                    return ItemQuality.Rare;
                else if (QLevel >= 3)
                    return ItemQuality.Magic;

                return ItemQuality.Undefined;
            }
        }

        public Item(MemoryManager reader, int address)
            : base(reader, address)
        {
            GetItemData();
        }

        public Item(Actor other)
            : base(other)
        {
            GetItemData();
        }

        private void GetItemData()
        {
            if (GBData == null)
            {
                LoadItemData();
            }

            if (GBData.ContainsKey(GBID))
            {
                int data = GBData[GBID];
                if (reader.ReadInt(data) != GBID)
                    LoadItemData();
                ItemLevel = reader.ReadInt(data + 0x114);
                ItemName = reader.ReadString(data + 0x4, 100);
                ItemType = (ItemType)reader.ReadInt(data + 0x108);
            }
        }

        private void ReadItemData(int GBFile)
        {
            int address = GBFile + 0x218;
            while (reader.ReadInt(address) == 0)
                address += 0x4;

            int size = reader.ReadInt(address + 0x4);
            address = GBFile + reader.ReadInt(address);

            for (int i = 0; i < size; i += 0x5F0)
            {
                GBData.Add(reader.ReadInt(address + i), address + i);
            }
        }

        private void LoadItemData()
        {
            SNOReader snoReader = new SNOReader(reader, 0x18817C8); //GameBalance SNOGroup
            GBData = new Dictionary<int, int>();

            ReadItemData(snoReader.GetAddressFromID(19750)); //Items_Armor
            ReadItemData(snoReader.GetAddressFromID(19753)); //Items_Other
            ReadItemData(snoReader.GetAddressFromID(19754)); //Items_Weapon
            ReadItemData(snoReader.GetAddressFromID(1189)); //Items_Legendary_Other
            ReadItemData(snoReader.GetAddressFromID(19752)); //Items_Legendary_Weapons
            ReadItemData(snoReader.GetAddressFromID(170627)); //Items_Legendary
        }
    }

    public enum ItemQuality
    {
        Undefined = 0,
        Magic = 1,
        Rare = 2,
        Legendary = 3,
    }
}
