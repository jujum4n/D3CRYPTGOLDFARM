using System;
using System.Collections.Generic;
using System.Linq;

namespace LootAlert
{
    class StringList
    {
        private Dictionary<string, string> data;
        private MemoryManager mem;

        public StringList(MemoryManager reader, int id)
        {
            this.mem = reader;
            data = new Dictionary<string, string>();

            SNOReader sno = new SNOReader(mem, 0x0158C240);
            int address = sno.GetAddressFromID(id);
            int count = mem.ReadInt(address + 0xC);
            address += 0x28;

            for (int i = 0; i < count; i++)
            {
                string NLS = mem.ReadString(mem.ReadInt(address), 50).TrimEnd((char)0);
                string Real = mem.ReadString(mem.ReadInt(address + 0x10), 32).TrimEnd((char)0);
                data.Add(NLS, Real);
                address += 0x50;
            }
        }

        public void DisplayAll()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach(KeyValuePair<string, string> pair in data)
            {
                sb.AppendLine(pair.Key + "  |   " + pair.Value);
            }
            System.IO.File.WriteAllText("monster.txt", sb.ToString());
        }
    }
}
