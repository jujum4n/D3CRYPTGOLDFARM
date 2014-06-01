using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace LootAlert
{
    class DiabloIII : IDisposable
    {
        public const int ObjectManager = 0x186FA3C;

        public MemoryManager memory;

        public bool Valid { get { return memory.IsInvalid() == false; } }

        public DiabloIII()
        {
            memory = new MemoryManager("Diablo III");
        }

        public DiabloIII(int procID)
        {
            if (Process.GetProcessById(procID).ProcessName.Contains("Diablo III") == false)
                throw new Exception("Not a valid diablo process");
            memory = new MemoryManager(procID);
        }

        public ACDActor Player()
        {
            int index = memory.ReadInt(ObjectManager, 0x94C, 0);
            return new ACDActor(GetActorFromID(memory.ReadInt(ObjectManager, 0x83c, 0x60 + index * 0x8590)));
        }

        ~DiabloIII()
        {
            if(memory != null)
                memory.Dispose();
        }

        public List<Actor> GetActors()
        {
            List<Actor> actors = new List<Actor>();
            int container = memory.ReadInt(ObjectManager, 0x8C8);
            int count = memory.ReadInt(container + 0x108);
            int current = memory.ReadInt(container + 0x148, 0);

            for (int i = 0; i <= count; i++)
            {
                actors.Add(new Actor(memory, current));
                current += 0x42C;
            }
            return actors;
        }

        public List<ACDActor> GetACDActors()
        {
            List<ACDActor> acdActors = new List<ACDActor>();
            int container = memory.ReadInt(ObjectManager, 0x8C8);
            int count = memory.ReadInt(container + 0x108);
            int current = memory.ReadInt(container + 0x148, 0);

            for (int i = 0; i <= count; i++)
            {
                if (memory.ReadInt(current + 0x4) != -1) //quick check to make sure the actor has ACD data
                    acdActors.Add(new ACDActor(memory, current));
                current += 0x42C;
            }

            return acdActors;
        }

        public List<Item> GetItems()
        {
            List<Item> items = new List<Item>();

            foreach (ACDActor a in GetACDActors())
            {
                if (a.ACDType == ACDType.Item)
                {
                    items.Add(new Item(a));
                }
            }

            return items;
        }

        public int CurrentLevelArea()
        {
            return memory.ReadInt(0x17DA33C, 0x810);
        }

        private Actor GetActorFromID(int id)
        {
            int c = memory.ReadInt(ObjectManager, 0x8C8);

            short sid = (short)(0xFFFF & id);
            int bitShift = memory.ReadInt(c + 0x18C);
            int actor = memory.ReadInt(memory.ReadInt(c + 0x148)) + 4 * (sid >> bitShift) + 0x42C * (sid & ((1 << bitShift) - 1));

            return new Actor(memory, actor);
        }

        public void Dispose()
        {
            memory.Dispose();
        }
    }
}
