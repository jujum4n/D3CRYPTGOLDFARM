using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LootAlert
{
    //Names were read from memory, probably lots of unused types I saved them all since I don't know which ones are used
    //Many of these are also only used as abstract types, no item will have the type Weapon for example, it will be more specific like Axe or Dagger
    [Serializable]
    public enum ItemType : uint
    {
        None = 0,

        //Weapon = 0x1CF0A9AA,
        //Melee = 0x7EDAA08,
        //Swing = 0x8641048,
        //GenericSwingWeapon = 0x6E15F58F,
        Axe = 0x1AC7E,
        Axe2H = 0x71ECAD8,
        Sword = 0x8642A4F,
        Sword2H = 0xB21800E9,
        Mace = 0x3D6F16,
        Mace2H = 0x5559370,
        FistWeapon = 0x8326FEC0,
        Daibo = 0x9F68572A, //CombatStaff
        MightyWeapon1H = 0xA7449335,
        MightyWeapon2H = 0xA7449356,
        Staff = 0x8624814,
        //Thrust = 0x1630E18A,
        //GenericThrustWeapon = 0x3B83E3F1,
        CeremonialDagger = 0xF4171CE9,
        Dagger = 0xF059666A,
        Polearm = 0xB84296B0,
        Spear = 0x86026FB,
        //Ranged = 0x110575D1,
        //BowClass = 0xEE86175E,
        //GenericBowWeapon = 0x179591AF,
        Bow = 0x1AFA8,
        Crossbow = 0xB032BFF2,
        HandXbow = 0x2D7C053B,
        //GenericRangedWeapon = 0x9DE5178,
        Wand = 0x42EC4A,
        Armor = 0x71BAA81,
        Helm = 0x3AC366,
        GenericHelm = 0xC780AFA3,
        SpiritStone = 0x225EEF78, //SpiritStone_Monk
        WizardHat = 0xA6A5B76E,
        VoodooMask = 0xEC219C82,
        Gloves = 0xF82490B0,
        Boots = 0x72C2707,
        Shoulders = 0xC7EC1139,
        ChestArmor = 0xC2B86318, //Used by legendaries and set items
        GenericChestArmor = 0x315FC915, //Used by rare quality and lower
        Cloak = 0x73C97EA,
        Belt = 0x377927, //Used by legendaries and set items
        GenericBelt = 0xC77D6564, //Used by rare and lower
        MightyBelt = 0xE3675008, //Belt_Barbarian
        Legs = 0x3CF44B,
        Bracers = 0x88CAA8C2,
        //Offhand = 0x55DEFDD6,
        //GenericOffHand = 0x148EDCF3,
        //OffhandOther = 0xD50F1758,
        Shield = 0x13D68479,
        Orb = 0x1E743,
        Mojo = 0x3DAB95,
        Quiver = 0x1017B93C,
        //Jewelry = 0xD3D8D042,
        Ring = 0x405070,
        Amulet = 0xEA3AD528,
        //FollowerSpecial = 0x619E5F4B,
        TemplarSpecial = 0x7BA9436,
        ScoundrelSpecial = 0xC72A8DB0,
        EnchantressSpecial = 0xE45339DF,
        //Socketable = 0xD0C3EADD,
        Gem = 0x1C399,
        //CraftingReagent = 0x879D5C74,
        //Utility = 0x449D4114,
        ChaosShard = 0xDCB2FE80,
        //GeneralUtility = 0xADBA1412,
        //Scroll = 0x138123EF,
        //ScrollIdentify = 0xB482A5CB,
        //CraftingPlan = 0xEB91CC59,
        //CraftingPlanGeneric = 0xB1322D6,
        CraftingPlanLegendary = 0xB1206A94,
        CraftingPlan_Smith = 0xA5B2941D,
        CraftingPlan_Jeweler = 0x1627E366,
        CraftingPlanLegendary_Smith = 0x9C81BBF8,
        //ScrollCalling = 0x38DAC149,
        //ScrollGreed = 0x45B80B76,
        //ScrollCompanion = 0x1BE80E53,
        //ScrollAngelWings = 0x5E58429E,
        //ScrollReforgeA = 0x52337E1A,
        //ScrollReforgeB = 0x52337E1B,
        //ScrollReforgeC = 0x52337E1C,
        Potion = 0xD5BCFB9,
        HealthPotion = 0x8DCB100F,
        PowerPotion = 0xC9C09BA6,
        Dye = 0x1B962,
        //Glyph = 0x7852664,
        //HealthGlyph = 0x7042B3FA,
        //Quest = 0x83EB632,
        //QuestUsable = 0xC812872E,
        Gold = 0x3A6186,
        //Junk = 0x3C2078,
        Book = 0x37A40B,
        //Ornament = 0xBFAA9B24,
        //KnowledgeUtility = 0x9F5B374,
        PageOfTraining_Smith = 0xBF7270F2,
        PageOfTraining_Jeweler = 0x9F52497B,
        //TrainingTome = 0xFFA79551,
        //NephalemCube = 0xAF5C1289,
        //TalismanUnlock = 0x60F0BE25,
        //StoneOfWealth = 0x93FD3963,
        //StoneOfRecall = 0x88545731,
        //Calldown = 0x8C0E9054,
        //LegendaryOnly = 0xA14D315D
    }
}
