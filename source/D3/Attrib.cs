﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LootAlert
{
    public enum Attrib : uint
    {
        Axe_Bad_Data = 0xFFFFF000,
        Attribute_Timer = 0xFFFFF001,
        Attribute_Pool = 0xFFFFF002,
        Death_Count = 0xFFFFF003,
        DualWield_Hand = 0xFFFFF004,
        DualWield_Hand_Next = 0xFFFFF005,
        DualWield_Hands_Swapped = 0xFFFFF006,
        Respawn_Game_Time = 0xFFFFF007,
        Backpack_Slots = 0xFFFFF008,
        Shared_Stash_Slots = 0xFFFFF009,
        Strength = 0xFFFFF00A,
        Dexterity = 0xFFFFF00B,
        Intelligence = 0xFFFFF00C,
        Vitality = 0xFFFFF00D,
        Strength_Total = 0xFFFFF00E,
        Dexterity_Total = 0xFFFFF00F,
        Intelligence_Total = 0xFFFFF010,
        Vitality_Total = 0xFFFFF011,
        Strength_Bonus = 0xFFFFF012,
        Dexterity_Bonus = 0xFFFFF013,
        Intelligence_Bonus = 0xFFFFF014,
        Vitality_Bonus = 0xFFFFF015,
        Strength_Bonus_Percent = 0xFFFFF016,
        Dexterity_Bonus_Percent = 0xFFFFF017,
        Intelligence_Bonus_Percent = 0xFFFFF018,
        Vitality_Bonus_Percent = 0xFFFFF019,
        Strength_Reduction_Percent = 0xFFFFF01A,
        Dexterity_Reduction_Percent = 0xFFFFF01B,
        Intelligence_Reduction_Percent = 0xFFFFF01C,
        Vitality_Reduction_Percent = 0xFFFFF01D,
        Primary_Damage_Attribute = 0xFFFFF01E,
        Attack = 0xFFFFF01F,
        Precision = 0xFFFFF020,
        Defense = 0xFFFFF021,
        Attack_Total = 0xFFFFF022,
        Precision_Total = 0xFFFFF023,
        Defense_Total = 0xFFFFF024,
        Attack_Bonus = 0xFFFFF025,
        Precision_Bonus = 0xFFFFF026,
        Defense_Bonus = 0xFFFFF027,
        Attack_Bonus_Percent = 0xFFFFF028,
        Precision_Bonus_Percent = 0xFFFFF029,
        Defense_Bonus_Percent = 0xFFFFF02A,
        Attack_Reduction_Percent = 0xFFFFF02B,
        Precision_Reduction_Percent = 0xFFFFF02C,
        Defense_Reduction_Percent = 0xFFFFF02D,
        Armor = 0xFFFFF02E,
        Armor_Bonus_Percent = 0xFFFFF02F,
        Armor_Item = 0xFFFFF030,
        Armor_Bonus_Item = 0xFFFFF031,
        Armor_Item_Percent = 0xFFFFF032,
        Armor_Item_Sub = 0xFFFFF033,
        Armor_Item_Total = 0xFFFFF034,
        Armor_Total = 0xFFFFF035,
        Experience_Granted = 0xFFFFF036,
        Experience_Next = 0xFFFFF037,
        Alt_Experience_Next = 0xFFFFF038,
        Gold_Granted = 0xFFFFF039,
        Gold = 0xFFFFF03A,
        Gold_Find = 0xFFFFF03B,
        Gold_Find_Uncapped = 0xFFFFF03C,
        Gold_Find_Handicap = 0xFFFFF03D,
        Gold_Find_Alt_Levels_Total = 0xFFFFF03E,
        Gold_Find_Capped_Subtotal = 0xFFFFF03F,
        Gold_Find_Total = 0xFFFFF040,
        Level = 0xFFFFF041,
        Level_Cap = 0xFFFFF042,
        Alt_Level = 0xFFFFF043,
        Magic_Find = 0xFFFFF044,
        Magic_Find_Uncapped = 0xFFFFF045,
        Magic_Find_Handicap = 0xFFFFF046,
        Magic_Find_Alt_Levels_Total = 0xFFFFF047,
        Magic_Find_Capped_Subtotal = 0xFFFFF048,
        Magic_Find_Total = 0xFFFFF049,
        Magic_And_Gold_Find_Suppressed = 0xFFFFF04A,
        Treasure_Find = 0xFFFFF04B,
        Resource_Cost_Reduction_Amount = 0xFFFFF04C,
        Resource_Cost_Reduction_Total = 0xFFFFF04D,
        Resource_Set_Point_Bonus = 0xFFFFF04E,
        Faster_Healing_Percent = 0xFFFFF04F,
        Spending_Resource_Heals_Percent = 0xFFFFF050,
        Bonus_Healing_Received_Percent = 0xFFFFF051,
        Reduced_Healing_Received_Percent = 0xFFFFF052,
        Experience_Bonus = 0xFFFFF053,
        Experience_Bonus_Percent = 0xFFFFF054,
        Experience_Bonus_Percent_Handicap = 0xFFFFF055,
        Experience_Bonus_Percent_Total = 0xFFFFF056,
        Health_Globe_Bonus_Chance = 0xFFFFF057,
        Health_Globe_Bonus_Mult_Chance = 0xFFFFF058,
        Health_Globe_Bonus_Health = 0xFFFFF059,
        Increased_Health_From_Globes_Percent = 0xFFFFF05A,
        Increased_Health_From_Globes_Percent_Total = 0xFFFFF05B,
        Bonus_Health_Percent_Per_Second_From_Globes = 0xFFFFF05C,
        Bonus_Health_Percent_Per_Second_From_Globes_Total = 0xFFFFF05D,
        Mana_Gained_From_Globes_Percent = 0xFFFFF05E,
        Mana_Gained_From_Globes = 0xFFFFF05F,
        Resistance = 0xFFFFF060,
        Resistance_Percent = 0xFFFFF061,
        Resistance_Total = 0xFFFFF062,
        Resistance_All = 0xFFFFF063,
        Resistance_Percent_All = 0xFFFFF064,
        Resistance_From_Intelligence = 0xFFFFF065,
        Class_Damage_Reduction_Percent = 0xFFFFF066,
        Skill = 0xFFFFF067,
        Skill_Total = 0xFFFFF068,
        Team = 0xFFFFF069,
        Team_Override = 0xFFFFF06A,
        Invulnerable = 0xFFFFF06B,
        Loading = 0xFFFFF06C,
        Loading_Player_ACDLoading = 0xFFFFF06D,
        Loading_Power_SNOLoading_Player_ACDLoading = 0xFFFFF06E,
        Loading_Anim_Tag = 0xFFFFF06F,
        Loading_New = 0xFFFFF070,
        Auto_Porting_To_Save_Point = 0xFFFFF071,
        No_Damage = 0xFFFFF072,
        No_Auto = 0xFFFFF073,
        Light_Radius_Percent_Bonus = 0xFFFFF074,
        Hitpoints_Cur = 0xFFFFF075,
        Hitpoints_Factor_Level = 0xFFFFF076,
        Hitpoints_Factor_Vitality = 0xFFFFF077,
        Hitpoints_Total_From_Vitality = 0xFFFFF078,
        Hitpoints_Total_From_Level = 0xFFFFF079,
        Hitpoints_Granted = 0xFFFFF07A,
        Hitpoints_Granted_Duration = 0xFFFFF07B,
        Hitpoints_Max = 0xFFFFF07C,
        Hitpoints_Max_Bonus = 0xFFFFF07D,
        Hitpoints_Max_Total = 0xFFFFF07E,
        Hitpoints_Percent = 0xFFFFF07F,
        Hitpoints_Regen_Per_Second = 0xFFFFF080,
        Hitpoints_Max_Percent_Bonus = 0xFFFFF081,
        Hitpoints_Max_Percent_Bonus_Item = 0xFFFFF082,
        Hitpoints_Healed_Target = 0xFFFFF083,
        Resource_Type_Primary = 0xFFFFF084,
        Resource_Type_Secondary = 0xFFFFF085,
        Resource_Cur = 0xFFFFF086,
        Resource_Max = 0xFFFFF087,
        Resource_Max_Bonus = 0xFFFFF088,
        Resource_Max_Total = 0xFFFFF089,
        Resource_Factor_Level = 0xFFFFF08A,
        Resource_Granted = 0xFFFFF08B,
        Resource_Granted_Duration = 0xFFFFF08C,
        Resource_Percent = 0xFFFFF08D,
        Resource_Regen_Per_Second = 0xFFFFF08E,
        Resource_Regen_Bonus_Percent = 0xFFFFF08F,
        Resource_Regen_Total = 0xFFFFF090,
        Resource_Max_Percent_Bonus = 0xFFFFF091,
        Resource_Capacity_Used = 0xFFFFF092,
        Resource_Effective_Max = 0xFFFFF093,
        Resource_Regen_Percent_Per_Second = 0xFFFFF094,
        Resource_Degeneration_Stop_Point = 0xFFFFF095,
        Movement_Scalar = 0xFFFFF096,
        Walking_Rate = 0xFFFFF097,
        Running_Rate = 0xFFFFF098,
        Sprinting_Rate = 0xFFFFF099,
        Strafing_Rate = 0xFFFFF09A,
        Walking_Rate_Total = 0xFFFFF09B,
        Running_Rate_Total = 0xFFFFF09C,
        Last_Running_Rate = 0xFFFFF09D,
        Sprinting_Rate_Total = 0xFFFFF09E,
        Strafing_Rate_Total = 0xFFFFF09F,
        Movement_Bonus_Total = 0xFFFFF0A0,
        Movement_Scalar_Subtotal = 0xFFFFF0A1,
        Movement_Scalar_Capped_Total = 0xFFFFF0A2,
        Movement_Scalar_Uncapped_Bonus = 0xFFFFF0A3,
        Movement_Scalar_Total = 0xFFFFF0A4,
        Movement_Bonus_Run_Speed = 0xFFFFF0A5,
        Casting_Speed = 0xFFFFF0A6,
        Casting_Speed_Bonus = 0xFFFFF0A7,
        Casting_Speed_Total = 0xFFFFF0A8,
        Always_Hits = 0xFFFFF0A9,
        Hit_Chance = 0xFFFFF0AA,
        Attacks_Per_Second_Item = 0xFFFFF0AB,
        Attacks_Per_Second_Item_Percent = 0xFFFFF0AC,
        Attacks_Per_Second_Item_Subtotal = 0xFFFFF0AD,
        Attacks_Per_Second_Item_Bonus = 0xFFFFF0AE,
        Attacks_Per_Second_Item_Total = 0xFFFFF0AF,
        Attacks_Per_Second = 0xFFFFF0B0,
        Attacks_Per_Second_Bonus = 0xFFFFF0B1,
        Attacks_Per_Second_Total = 0xFFFFF0B2,
        Attacks_Per_Second_Percent = 0xFFFFF0B3,
        AI_Cooldown_Reduction_Percent = 0xFFFFF0B4,
        Power_Cooldown_Reduction_Percent = 0xFFFFF0B5,
        Damage_Delta = 0xFFFFF0B6,
        Damage_Delta_Total = 0xFFFFF0B7,
        Damage_Min = 0xFFFFF0B8,
        Damage_Bonus_Min = 0xFFFFF0B9,
        Damage_Min_Total = 0xFFFFF0BA,
        Damage_Delta_Total_All = 0xFFFFF0BB,
        Damage_Min_Total_All = 0xFFFFF0BC,
        Damage_Average_Total_All = 0xFFFFF0BD,
        Damage_Min_Subtotal = 0xFFFFF0BE,
        Damage_Percent_All_From_Skills = 0xFFFFF0BF,
        Damage_Weapon_Delta = 0xFFFFF0C0,
        Damage_Weapon_Delta_Sub = 0xFFFFF0C1,
        Damage_Weapon_Max = 0xFFFFF0C2,
        Damage_Weapon_Max_Total = 0xFFFFF0C3,
        Damage_Weapon_Max_Total_All = 0xFFFFF0C4,
        Damage_Weapon_Delta_Total = 0xFFFFF0C5,
        Damage_Weapon_Delta_Total_All = 0xFFFFF0C6,
        Damage_Weapon_Bonus_Delta = 0xFFFFF0C7,
        Damage_Weapon_Min = 0xFFFFF0C8,
        Damage_Weapon_Min_Total = 0xFFFFF0C9,
        Damage_Weapon_Min_Total_All = 0xFFFFF0CA,
        Damage_Weapon_Average = 0xFFFFF0CB,
        Damage_Weapon_Average_Total = 0xFFFFF0CC,
        Damage_Weapon_Average_Total_All = 0xFFFFF0CD,
        Damage_Weapon_Bonus_Min = 0xFFFFF0CE,
        Damage_Weapon_Percent_Bonus = 0xFFFFF0CF,
        Damage_Weapon_Percent_All = 0xFFFFF0D0,
        Damage_Weapon_Percent_Total = 0xFFFFF0D1,
        Damage_Type_Percent_Bonus = 0xFFFFF0D2,
        Damage_Dealt_Percent_Bonus = 0xFFFFF0D3,
        Damage_Percent_Bonus_Witchdoctor = 0xFFFFF0D4,
        Damage_Percent_Bonus_Wizard = 0xFFFFF0D5,
        Crit_Percent_Base = 0xFFFFF0D6,
        Crit_Percent_Bonus_Capped = 0xFFFFF0D7,
        Crit_Percent_Bonus_Uncapped = 0xFFFFF0D8,
        Crit_Percent_Cap = 0xFFFFF0D9,
        Crit_Damage_Percent = 0xFFFFF0DA,
        Crit_Effect_Time = 0xFFFFF0DB,
        Pierce_Chance = 0xFFFFF0DC,
        Damage_Absorb_Percent = 0xFFFFF0DD,
        Damage_Reduction_Total = 0xFFFFF0DE,
        Damage_Reduction_Current = 0xFFFFF0DF,
        Damage_Reduction_Last_Tick = 0xFFFFF0E0,
        Block_Chance = 0xFFFFF0E1,
        Block_Chance_Total = 0xFFFFF0E2,
        Block_Chance_Bonus_Item = 0xFFFFF0E3,
        Block_Chance_Item = 0xFFFFF0E4,
        Block_Chance_Item_Total = 0xFFFFF0E5,
        Block_Amount = 0xFFFFF0E6,
        Block_Amount_Bonus_Percent = 0xFFFFF0E7,
        Block_Amount_Total_Min = 0xFFFFF0E8,
        Block_Amount_Total_Max = 0xFFFFF0E9,
        Block_Amount_Item_Min = 0xFFFFF0EA,
        Block_Amount_Item_Delta = 0xFFFFF0EB,
        Block_Amount_Item_Bonus = 0xFFFFF0EC,
        Dodge_Chance_Bonus = 0xFFFFF0ED,
        Dodge_Chance_Bonus_Melee = 0xFFFFF0EE,
        Dodge_Chance_Bonus_Ranged = 0xFFFFF0EF,
        Get_Hit_Current = 0xFFFFF0F0,
        Get_Hit_Max_Base = 0xFFFFF0F1,
        Get_Hit_Max_Per_Level = 0xFFFFF0F2,
        Get_Hit_Max = 0xFFFFF0F3,
        Get_Hit_Recovery_Base = 0xFFFFF0F4,
        Get_Hit_Recovery_Per_Level = 0xFFFFF0F5,
        Get_Hit_Recovery = 0xFFFFF0F6,
        Get_Hit_Damage = 0xFFFFF0F7,
        Get_Hit_Damage_Scalar = 0xFFFFF0F8,
        Last_Damage_Main = 0xFFFFF0F9,
        Last_ACD_Attacked = 0xFFFFF0FA,
        Ignores_Critical_Hits = 0xFFFFF0FB,
        Immunity = 0xFFFFF0FC,
        Untargetable = 0xFFFFF0FD,
        Immobolize = 0xFFFFF0FE,
        Immune_To_Knockback = 0xFFFFF0FF,
        Power_Immobilize = 0xFFFFF100,
        Stun_Chance = 0xFFFFF101,
        Stun_Length = 0xFFFFF102,
        Stun_Recovery = 0xFFFFF103,
        Stun_Recovery_Speed = 0xFFFFF104,
        Stunned = 0xFFFFF105,
        Stun_Immune = 0xFFFFF106,
        Poison_Length_Reduction = 0xFFFFF107,
        Poisoned = 0xFFFFF108,
        Bleeding = 0xFFFFF109,
        Bleed_Duration = 0xFFFFF10A,
        Chilled = 0xFFFFF10B,
        Freeze_Length_Reduction = 0xFFFFF10C,
        Freeze_Immune = 0xFFFFF10D,
        Webbed = 0xFFFFF10E,
        Slow = 0xFFFFF10F,
        Fire = 0xFFFFF110,
        Lightning = 0xFFFFF111,
        Cold = 0xFFFFF112,
        Poison = 0xFFFFF113,
        Blind = 0xFFFFF114,
        Enraged = 0xFFFFF115,
        Slowdown_Immune = 0xFFFFF116,
        Gethit_Immune = 0xFFFFF117,
        Suffocation_Per_Second = 0xFFFFF118,
        Suffocation_Unit_Value = 0xFFFFF119,
        Thorns_Percent = 0xFFFFF11A,
        Thorns_Percent_All = 0xFFFFF11B,
        Thorns_Percent_Total = 0xFFFFF11C,
        Thorns_Fixed = 0xFFFFF11D,
        Steal_Health_Percent = 0xFFFFF11E,
        Steal_Mana_Percent = 0xFFFFF11F,
        Resource_On_Hit = 0xFFFFF120,
        Resource_On_Kill = 0xFFFFF121,
        Resource_On_Crit = 0xFFFFF122,
        Hitpoints_On_Hit = 0xFFFFF123,
        Hitpoints_On_Kill = 0xFFFFF124,
        Damage_To_Mana = 0xFFFFF125,
        Last_Proc_Time = 0xFFFFF126,
        Damage_Power_Delta = 0xFFFFF127,
        Damage_Power_Min = 0xFFFFF128,
        Rope_Overlay = 0xFFFFF129,
        General_Cooldown = 0xFFFFF12A,
        Power_Cooldown = 0xFFFFF12B,
        Power_Cooldown_Start = 0xFFFFF12C,
        Proc_Cooldown = 0xFFFFF12D,
        Emote_Cooldown = 0xFFFFF12E,
        Projectile_Speed = 0xFFFFF12F,
        Projectile_Speed_Increase_Percent = 0xFFFFF130,
        Destroy = 0xFFFFF131,
        Skill_Toggled_State = 0xFFFFF132,
        Act = 0xFFFFF133,
        Difficulty = 0xFFFFF134,
        Last_Damage_Amount = 0xFFFFF135,
        In_Knockback = 0xFFFFF136,
        Amplify_Damage_Type_Percent = 0xFFFFF137,
        Amplify_Damage_Percent = 0xFFFFF138,
        Durability_Cur = 0xFFFFF139,
        Durability_Max = 0xFFFFF13A,
        Durability_Last_Damage = 0xFFFFF13B,
        Item_Quality_Level = 0xFFFFF13C,
        Item_Quality_Level_Identified = 0xFFFFF13D,
        Item_Cost_Percent_Bonus = 0xFFFFF13E,
        Item_Equipped = 0xFFFFF13F,
        Item_Ping_ACDItem_Equipped = 0xFFFFF140,
        Requirement = 0xFFFFF141,
        Requirements_Ease_Percent = 0xFFFFF142,
        Requirement_When_Equipped = 0xFFFFF143,
        Sockets = 0xFFFFF144,
        Sockets_Filled = 0xFFFFF145,
        Stats_All_Bonus = 0xFFFFF146,
        Item_Bound_To_ACDSockets_Filled = 0xFFFFF147,
        Item_Locked_To_ACDItem_Bound_To_ACDSockets_Filled = 0xFFFFF148,
        Item_Binding_Level_Override = 0xFFFFF149,
        ItemStackQuantityHi = 0xFFFFF14A,
        ItemStackQuantityLo = 0xFFFFF14B,
        Run_Speed_Granted = 0xFFFFF14C,
        Run_Speed_Duration = 0xFFFFF14D,
        Identify = 0xFFFFF14E,
        Seed = 0xFFFFF14F,
        Is = 0xFFFFF150,
        Dye = 0xFFFFF151,
        Enchant = 0xFFFFF152,
        EnchantRange = 0xFFFFF153,
        Highly = 0xFFFFF154,
        ItemUnlockTimeHi = 0xFFFFF155,
        ItemUnlockTimeLo = 0xFFFFF156,
        Always_Plays_Get = 0xFFFFF157,
        Hidden = 0xFFFFF158,
        Alpha = 0xFFFFF159,
        RActor_Fade_Group = 0xFFFFF15A,
        Quest = 0xFFFFF15B,
        Attack_Cooldown_Min = 0xFFFFF15C,
        Attack_Cooldown_Delta = 0xFFFFF15D,
        InitialCooldownMinTotal = 0xFFFFF15E,
        InitialCooldownDeltaTotal = 0xFFFFF15F,
        Attack_Cooldown_Min_Total = 0xFFFFF160,
        Attack_Cooldown_Delta_Total = 0xFFFFF161,
        Closing_Cooldown_Min_Total = 0xFFFFF162,
        Closing_Cooldown_Delta_Total = 0xFFFFF163,
        Quest_Monster = 0xFFFFF164,
        //Quest_Monster = 0xFFFFF165,
        Treasure_Class = 0xFFFFF166,
        Removes_Body_On_Death = 0xFFFFF167,
        InitialCooldownMin = 0xFFFFF168,
        InitialCooldownDelta = 0xFFFFF169,
        Knockback_Weight = 0xFFFFF16A,
        UntargetableByPets = 0xFFFFF16B,
        Damage_State_Current = 0xFFFFF16C,
        Damage_State_Max = 0xFFFFF16D,
        Is_Player_Decoy = 0xFFFFF16E,
        Custom_Target_Weight = 0xFFFFF16F,
        Gizmo_State = 0xFFFFF170,
        Gizmo_Charges = 0xFFFFF171,
        Chest_Open = 0xFFFFF172,
        Door_Locked = 0xFFFFF173,
        Door_Timer = 0xFFFFF174,
        Gizmo_Disabled_By_Script = 0xFFFFF175,
        Gizmo_Operator_ACDIDGizmo_Disabled_By_Script = 0xFFFFF176,
        Triggering_Count = 0xFFFFF177,
        Gate_Position = 0xFFFFF178,
        Gate_Velocity = 0xFFFFF179,
        Gizmo_Has_Been_Operated = 0xFFFFF17A,
        Pet_Owner = 0xFFFFF17B,
        Pet_Creator = 0xFFFFF17C,
        Pet_Type = 0xFFFFF17D,
        Drops = 0xFFFFF17E,
        Grants = 0xFFFFF17F,
        Hireling_Class = 0xFFFFF180,
        Summoned_By_SNOHireling_Class = 0xFFFFF181,
        Is_NPCSummoned_By_SNOHireling_Class = 0xFFFFF182,
        NPC_Is_Operatable = 0xFFFFF183,
        NPC_Is_Escorting = 0xFFFFF184,
        NPC_Has_Interact_Options = 0xFFFFF185,
        Conversation_Icon = 0xFFFFF186,
        Callout_Cooldown = 0xFFFFF187,
        Banter_Cooldown = 0xFFFFF188,
        Conversation_Heard_Count = 0xFFFFF189,
        Last_Tick_Shop_Entered = 0xFFFFF18A,
        Is_Helper = 0xFFFFF18B,
        Axe = 0xFFFFF18C,
        Axe2H = 0xFFFFF18D,
        Throwing = 0xFFFFF18E,
        AxeAnyPin = 0xFFFFF18F,
        Bow = 0xFFFFF190,
        Crossbow = 0xFFFFF191,
        BowAnyPin = 0xFFFFF192,
        Club = 0xFFFFF193,
        Club2H = 0xFFFFF194,
        ClubAnyPin = 0xFFFFF195,
        Dagger = 0xFFFFF196,
        Mace = 0xFFFFF197,
        Mace2H = 0xFFFFF198,
        MaceAnyPin = 0xFFFFF199,
        Sword = 0xFFFFF19A,
        Sword2H = 0xFFFFF19B,
        SwordAnyPin = 0xFFFFF19C,
        Polearm = 0xFFFFF19D,
        Spear = 0xFFFFF19E,
        Wand = 0xFFFFF19F,
        ColdStaff = 0xFFFFF1A0,
        FireStaff = 0xFFFFF1A1,
        LightningStaff = 0xFFFFF1A2,
        PoisonStaff = 0xFFFFF1A3,
        StaffAnyPin = 0xFFFFF1A4,
        Weapon1HPin = 0xFFFFF1A5,
        Weapon2HPin = 0xFFFFF1A6,
        WeaponMeleePin = 0xFFFFF1A7,
        WeaponRangedPin = 0xFFFFF1A8,
        Quiver = 0xFFFFF1A9,
        Reincarnation_Buff = 0xFFFFF1AA,
        Dead_Body_Anim = 0xFFFFF1AB,
        Spawned_by_ACDIDDead_Body_Anim = 0xFFFFF1AC,
        Summoned_By_ACDIDSpawned_by_ACDIDDead_Body_Anim = 0xFFFFF1AD,
        Summoner_IDSummoned_By_ACDIDSpawned_by_ACDIDDead_Body_An = 0xFFFFF1AE,
        Banner_ACDIDSummoner_IDSummoned_By_ACDIDSpawned_by_ACDID = 0xFFFFF1AF,
        Breakable_Shield_HPBanner_ACDIDSummoner_IDSummoned_By_ACDI = 0xFFFFF1B0,
        Current_Weapon = 0xFFFFF1B1,
        Weapons_Sheathed = 0xFFFFF1B2,
        Held_In_Off = 0xFFFFF1B3,
        Attacks_Per_Second_Item_Main = 0xFFFFF1B4,
        Attacks_Per_Second_Item_Off = 0xFFFFF1B5,
        Attacks_Per_Second_Item_Total_Main = 0xFFFFF1B6,
        Attacks_Per_Second_Item_Total_Off = 0xFFFFF1B7,
        Damage_Weapon_Min_Total_Main = 0xFFFFF1B8,
        Damage_Weapon_Min_Total_Off = 0xFFFFF1B9,
        Damage_Weapon_Delta_Total_Main = 0xFFFFF1BA,
        Damage_Weapon_Delta_Total_Off = 0xFFFFF1BB,
        Attacks_Per_Second_Item_Current = 0xFFFFF1BC,
        Damage_Weapon_Min_Total_Current = 0xFFFFF1BD,
        Damage_Weapon_Delta_Total_Current = 0xFFFFF1BE,
        Has_Special_Death_Anim = 0xFFFFF1BF,
        Death_Type_Override = 0xFFFFF1C0,
        In_Combat = 0xFFFFF1C1,
        In_Conversation = 0xFFFFF1C2,
        Last_Tick_Potion_Used = 0xFFFFF1C3,
        Potion_Dilution_Percent = 0xFFFFF1C4,
        Out_Of_Combat_Health_Regen_Percent = 0xFFFFF1C5,
        Out_Of_Combat_Mana_Regen_Percent = 0xFFFFF1C6,
        Potion_Dilution_Duration = 0xFFFFF1C7,
        Potion_Dilution_Scalar = 0xFFFFF1C8,
        Feared = 0xFFFFF1C9,
        Fear_Immune = 0xFFFFF1CA,
        Last_Damage_ACDFear_Immune = 0xFFFFF1CB,
        Attached_To_ACDLast_Damage_ACDFear_Immune = 0xFFFFF1CC,
        Attachment_ACDAttached_To_ACDLast_Damage_ACDFear_Immune = 0xFFFFF1CD,
        Normal_Attack_Replacement_Power_SNOAttachment_ACDAttached_To_ = 0xFFFFF1CE,
        Damage_Type_Override = 0xFFFFF1CF,
        Minion_Count_Bonus_Percent = 0xFFFFF1D0,
        Champion_Teleport_Next_Tick = 0xFFFFF1D1,
        Champion_Teleport_Time_Min_In_Seconds = 0xFFFFF1D2,
        Champion_Teleport_Time_Delta_In_Seconds = 0xFFFFF1D3,
        Champion_Clone_Next_Tick = 0xFFFFF1D4,
        Champion_Clone_Time_Min_In_Seconds = 0xFFFFF1D5,
        Champion_Clone_Time_Delta_In_Seconds = 0xFFFFF1D6,
        Champion_Clone_Hitpoint_Bonus_Percent = 0xFFFFF1D7,
        Champion_Clone_Damage_Bonus_Percent = 0xFFFFF1D8,
        Champion_Ghostly_Next_Tick = 0xFFFFF1D9,
        Champion_Ghostly_Inactive_Time_Min_In_Seconds = 0xFFFFF1DA,
        Champion_Ghostly_Inactive_Time_Delta_In_Seconds = 0xFFFFF1DB,
        Champion_Ghostly_Active_Time_Min_In_Seconds = 0xFFFFF1DC,
        Champion_Ghostly_Active_Time_Delta_In_Seconds = 0xFFFFF1DD,
        Champion_Ghostly_Saved_Dodge_Chance = 0xFFFFF1DE,
        Champion_Ghostly = 0xFFFFF1DF,
        Base_Element = 0xFFFFF1E0,
        Projectile_Amount_Bonus_Percent = 0xFFFFF1E1,
        Projectile_Reflect_Chance = 0xFFFFF1E2,
        Attack_Fear_Chance = 0xFFFFF1E3,
        Attack_Fear_Time_Min = 0xFFFFF1E4,
        Attack_Fear_Time_Delta = 0xFFFFF1E5,
        Buff_Visual_Effect = 0xFFFFF1E6,
        Buff_Icon_Start_Tick0 = 0xFFFFF1E7,
        Buff_Icon_Start_Tick1 = 0xFFFFF1E8,
        Buff_Icon_Start_Tick2 = 0xFFFFF1E9,
        Buff_Icon_Start_Tick3 = 0xFFFFF1EA,
        Buff_Icon_Start_Tick4 = 0xFFFFF1EB,
        Buff_Icon_Start_Tick5 = 0xFFFFF1EC,
        Buff_Icon_Start_Tick6 = 0xFFFFF1ED,
        Buff_Icon_Start_Tick7 = 0xFFFFF1EE,
        Buff_Icon_End_Tick0 = 0xFFFFF1EF,
        Buff_Icon_End_Tick1 = 0xFFFFF1F0,
        Buff_Icon_End_Tick2 = 0xFFFFF1F1,
        Buff_Icon_End_Tick3 = 0xFFFFF1F2,
        Buff_Icon_End_Tick4 = 0xFFFFF1F3,
        Buff_Icon_End_Tick5 = 0xFFFFF1F4,
        Buff_Icon_End_Tick6 = 0xFFFFF1F5,
        Buff_Icon_End_Tick7 = 0xFFFFF1F6,
        Could_Have_Ragdolled = 0xFFFFF1F7,
        Ambient_Damage_Effect_Last_Time = 0xFFFFF1F8,
        Scale_Bonus = 0xFFFFF1F9,
        Deleted_On_Server = 0xFFFFF1FA,
        Scripted_Fade_Time = 0xFFFFF1FB,
        Does_No_Damage = 0xFFFFF1FC,
        Does_Fake_Damage = 0xFFFFF1FD,
        SlowTime_Debuff = 0xFFFFF1FE,
        Blocks_Projectiles = 0xFFFFF1FF,
        Frozen = 0xFFFFF200,
        Freeze_Damage_Percent_Bonus = 0xFFFFF201,
        Buff_Active = 0xFFFFF202,
        Dual = 0xFFFFF203,
        Summon_Expiration_Tick = 0xFFFFF204,
        Summon_Count = 0xFFFFF205,
        Uninterruptible = 0xFFFFF206,
        Queue = 0xFFFFF207,
        Cant = 0xFFFFF208,
        Wizard_Slowtime_Proxy_ACDCant = 0xFFFFF209,
        DPSWizard_Slowtime_Proxy_ACDCant = 0xFFFFF20A,
        Resurrection_Power = 0xFFFFF20B,
        Freeze_Damage = 0xFFFFF20C,
        Freeze_Capacity = 0xFFFFF20D,
        Thaw_Rate = 0xFFFFF20E,
        Chilled_Dur_Bonus_Percent = 0xFFFFF20F,
        DOT_DPSChilled_Dur_Bonus_Percent = 0xFFFFF210,
        Damage = 0xFFFFF211,
        Item_Time_Sold = 0xFFFFF212,
        Forced_Hireling_Power = 0xFFFFF213,
        IsRooted = 0xFFFFF214,
        RootTargetACD = 0xFFFFF215,
        RootAutoDecayPerSecond = 0xFFFFF216,
        RootUnitValue = 0xFFFFF217,
        RootTotalTicks = 0xFFFFF218,
        Hide_Affixes = 0xFFFFF219,
        Rune_A = 0xFFFFF21A,
        Rune_B = 0xFFFFF21B,
        Rune_C = 0xFFFFF21C,
        Rune_D = 0xFFFFF21D,
        Rune_E = 0xFFFFF21E,
        Resistance_Stun = 0xFFFFF21F,
        Resistance_Stun_Total = 0xFFFFF220,
        Resistance_Root = 0xFFFFF221,
        Resistance_Root_Total = 0xFFFFF222,
        Resistance_Freeze = 0xFFFFF223,
        Resistance_Freeze_Total = 0xFFFFF224,
        Resistance_StunRootFreeze = 0xFFFFF225,
        Crowd = 0xFFFFF226,
        Displays_Team_Effect = 0xFFFFF227,
        Cannot_Be_Added_To_AI_Target_List = 0xFFFFF228,
        SkillKit = 0xFFFFF229,
        Immune_To_Charm = 0xFFFFF22A,
        Immune_To_Blind = 0xFFFFF22B,
        Damage_Shield = 0xFFFFF22C,
        Silenced = 0xFFFFF22D,
        Diseased = 0xFFFFF22E,
        Guard_Object_ACDIDDiseased = 0xFFFFF22F,
        Follow_Target_ACDIDGuard_Object_ACDIDDiseased = 0xFFFFF230,
        Follow_Target_Type = 0xFFFFF231,
        Forced_Enemy_ACDIDFollow_Target_Type = 0xFFFFF232,
        NPC_Talk_Target_ANNForced_Enemy_ACDIDFollow_Target_Type = 0xFFFFF233,
        NPC_Conv_Target_ANNNPC_Talk_Target_ANNForced_Enemy_ACDIDFoll = 0xFFFFF234,
        Script_Target_ACDIDNPC_Conv_Target_ANNNPC_Talk_Target_ANNForc = 0xFFFFF235,
        Look_Target_Server_ANNScript_Target_ACDIDNPC_Conv_Target_ANN = 0xFFFFF236,
        Look_Target_Broadcast_Intensity = 0xFFFFF237,
        Look_Target_Broadcast_Radius = 0xFFFFF238,
        Stealthed = 0xFFFFF239,
        Gem = 0xFFFFF23A,
        Item = 0xFFFFF23B,
        Scroll = 0xFFFFF23C,
        Gizmo_Actor_SNO_To_Spawn = 0xFFFFF23D,
        Gizmo_Actor_To_Spawn_Scale = 0xFFFFF23E,
        Death_Replacement_Power_SNOGizmo_Actor_To_Spawn_Scale = 0xFFFFF23F,
        Attachment_Handled_By_Client = 0xFFFFF240,
        AI_In_Special_State = 0xFFFFF241,
        AI_Used_Scripted_Spawn_Anim = 0xFFFFF242,
        AI_Spawned_By_Inactive_Marker = 0xFFFFF243,
        Headstone_Player_ANNAI_Spawned_By_Inactive_Marker = 0xFFFFF244,
        Resource_Cost_Reduction_Percent = 0xFFFFF245,
        Resistance_Penetration = 0xFFFFF246,
        Resistance_Penetration_Total = 0xFFFFF247,
        Resistance_Penetration_All = 0xFFFFF248,
        Resistance_Penetration_Percent_All = 0xFFFFF249,
        Fury_Effect_Level = 0xFFFFF24A,
        Health_Potion_Bonus_Heal_Percent = 0xFFFFF24B,
        Free_Cast = 0xFFFFF24C,
        Free_Cast_All = 0xFFFFF24D,
        Movement_Scalar_Reduction_Percent = 0xFFFFF24E,
        Movement_Scalar_Reduction_Resistance = 0xFFFFF24F,
        Damage_Absorb_Percent_All = 0xFFFFF250,
        World_Seed = 0xFFFFF251,
        Kill_Count_Record = 0xFFFFF252,
        Object_Destruction_Record = 0xFFFFF253,
        Single_Attack_Record = 0xFFFFF254,
        Environment_Attack_Record = 0xFFFFF255,
        Root_Immune = 0xFFFFF256,
        Monster_Play_Get_Hit_Bonus = 0xFFFFF257,
        Stored_Contact_Frame = 0xFFFFF258,
        Buff_Icon_Count0 = 0xFFFFF259,
        Buff_Icon_Count1 = 0xFFFFF25A,
        Buff_Icon_Count2 = 0xFFFFF25B,
        Buff_Icon_Count3 = 0xFFFFF25C,
        Buff_Icon_Count4 = 0xFFFFF25D,
        Buff_Icon_Count5 = 0xFFFFF25E,
        Buff_Icon_Count6 = 0xFFFFF25F,
        Buff_Icon_Count7 = 0xFFFFF260,
        Observer = 0xFFFFF261,
        Resurrect_As_Observer = 0xFFFFF262,
        Combo_Level = 0xFFFFF263,
        Combo_Time_Last_Move = 0xFFFFF264,
        Burrowed = 0xFFFFF265,
        Death_Replacement_Effect_Group_SNOBurrowed = 0xFFFFF266,
        Checkpoint_Resurrection_Allowed_Game_Time = 0xFFFFF267,
        Checkpoint_Resurrection_Forced_Game_Time = 0xFFFFF268,
        Controlling_Timed = 0xFFFFF269,
        Casting_Speed_Percent = 0xFFFFF26A,
        Using_Bossbar = 0xFFFFF26B,
        Power_Buff_0_Visual_Effect = 0xFFFFF26C,
        Power_Buff_1_Visual_Effect = 0xFFFFF26D,
        Power_Buff_2_Visual_Effect = 0xFFFFF26E,
        Power_Buff_3_Visual_Effect = 0xFFFFF26F,
        Power_Buff_4_Visual_Effect = 0xFFFFF270,
        Power_Buff_5_Visual_Effect = 0xFFFFF271,
        Power_Buff_6_Visual_Effect = 0xFFFFF272,
        Power_Buff_7_Visual_Effect = 0xFFFFF273,
        Store = 0xFFFFF274,
        Busy = 0xFFFFF275,
        Afk = 0xFFFFF276,
        Last = 0xFFFFF277,
        Portal = 0xFFFFF278,
        Repair_Discount_Percent = 0xFFFFF279,
        Resource_Degeneration_Prevented = 0xFFFFF27A,
        Operatable = 0xFFFFF27B,
        Look_Override = 0xFFFFF27C,
        Spawner_Concurrent_Count_IDLook_Override = 0xFFFFF27D,
        Disabled = 0xFFFFF27E,
        Skill_Override = 0xFFFFF27F,
        Skill_Override_Active = 0xFFFFF280,
        Skill_Override_Ended = 0xFFFFF281,
        Skill_Override_Ended_Active = 0xFFFFF282,
        Is_Power_Proxy = 0xFFFFF283,
        Force_No_Death_Animation = 0xFFFFF284,
        Player_Weapon = 0xFFFFF285,
        Operatable_Story_Gizmo = 0xFFFFF286,
        Power_Buff_0_Visual_Effect_None = 0xFFFFF287,
        Power_Buff_0_Visual_Effect_A = 0xFFFFF288,
        Power_Buff_0_Visual_Effect_B = 0xFFFFF289,
        Power_Buff_0_Visual_Effect_C = 0xFFFFF28A,
        Power_Buff_0_Visual_Effect_D = 0xFFFFF28B,
        Power_Buff_0_Visual_Effect_E = 0xFFFFF28C,
        Power_Buff_1_Visual_Effect_None = 0xFFFFF28D,
        Power_Buff_1_Visual_Effect_A = 0xFFFFF28E,
        Power_Buff_1_Visual_Effect_B = 0xFFFFF28F,
        Power_Buff_1_Visual_Effect_C = 0xFFFFF290,
        Power_Buff_1_Visual_Effect_D = 0xFFFFF291,
        Power_Buff_1_Visual_Effect_E = 0xFFFFF292,
        Power_Buff_2_Visual_Effect_None = 0xFFFFF293,
        Power_Buff_2_Visual_Effect_A = 0xFFFFF294,
        Power_Buff_2_Visual_Effect_B = 0xFFFFF295,
        Power_Buff_2_Visual_Effect_C = 0xFFFFF296,
        Power_Buff_2_Visual_Effect_D = 0xFFFFF297,
        Power_Buff_2_Visual_Effect_E = 0xFFFFF298,
        Power_Buff_3_Visual_Effect_None = 0xFFFFF299,
        Power_Buff_3_Visual_Effect_A = 0xFFFFF29A,
        Power_Buff_3_Visual_Effect_B = 0xFFFFF29B,
        Power_Buff_3_Visual_Effect_C = 0xFFFFF29C,
        Power_Buff_3_Visual_Effect_D = 0xFFFFF29D,
        Power_Buff_3_Visual_Effect_E = 0xFFFFF29E,
        Power_Buff_4_Visual_Effect_None = 0xFFFFF29F,
        Power_Buff_4_Visual_Effect_A = 0xFFFFF2A0,
        Power_Buff_4_Visual_Effect_B = 0xFFFFF2A1,
        Power_Buff_4_Visual_Effect_C = 0xFFFFF2A2,
        Power_Buff_4_Visual_Effect_D = 0xFFFFF2A3,
        Power_Buff_4_Visual_Effect_E = 0xFFFFF2A4,
        Power_Buff_5_Visual_Effect_None = 0xFFFFF2A5,
        Power_Buff_5_Visual_Effect_A = 0xFFFFF2A6,
        Power_Buff_5_Visual_Effect_B = 0xFFFFF2A7,
        Power_Buff_5_Visual_Effect_C = 0xFFFFF2A8,
        Power_Buff_5_Visual_Effect_D = 0xFFFFF2A9,
        Power_Buff_5_Visual_Effect_E = 0xFFFFF2AA,
        Power_Buff_6_Visual_Effect_None = 0xFFFFF2AB,
        Power_Buff_6_Visual_Effect_A = 0xFFFFF2AC,
        Power_Buff_6_Visual_Effect_B = 0xFFFFF2AD,
        Power_Buff_6_Visual_Effect_C = 0xFFFFF2AE,
        Power_Buff_6_Visual_Effect_D = 0xFFFFF2AF,
        Power_Buff_6_Visual_Effect_E = 0xFFFFF2B0,
        Power_Buff_7_Visual_Effect_None = 0xFFFFF2B1,
        Power_Buff_7_Visual_Effect_A = 0xFFFFF2B2,
        Power_Buff_7_Visual_Effect_B = 0xFFFFF2B3,
        Power_Buff_7_Visual_Effect_C = 0xFFFFF2B4,
        Power_Buff_7_Visual_Effect_D = 0xFFFFF2B5,
        Power_Buff_7_Visual_Effect_E = 0xFFFFF2B6,
        Walk_Passability_Power_SNOPower_Buff_7_Visual_Effect_EPowe = 0xFFFFF2B7,
        Passability_Power_SNOWalk_Passability_Power_SNOPower_Buff_7 = 0xFFFFF2B8,
        Flippy_IDPassability_Power_SNOWalk_Passability_Power_SNO = 0xFFFFF2B9,
        Summoning_Machine_Num_Casters = 0xFFFFF2BA,
        Summoning_Machine_Spawn_Count = 0xFFFFF2BB,
        Summoning_Machine_Next_Spawn_Ticks = 0xFFFFF2BC,
        Summoning_Machine_Spawn_Team = 0xFFFFF2BD,
        Screen_Attack_Radius_Constant = 0xFFFFF2BE,
        Damage_Done_Reduction_Percent = 0xFFFFF2BF,
        Set_Item_Count = 0xFFFFF2C0,
        Spawner_Countdown_Percent = 0xFFFFF2C1,
        Attack_Slow = 0xFFFFF2C2,
        Power_Disabled = 0xFFFFF2C3,
        Weapon_Effect_Override = 0xFFFFF2C4,
        Debuff_Duration_Reduction_Percent = 0xFFFFF2C5,
        Uses_Pv = 0xFFFFF2C6,
        Trait = 0xFFFFF2C7,
        Last_ACD_Attacked_By = 0xFFFFF2C8,
        Gold_Pick = 0xFFFFF2C9,
        Client = 0xFFFFF2CA,
        Has_Doppelganger_Cloned = 0xFFFFF2CB,
        Resource_Gain_Bonus_Percent = 0xFFFFF2CC,
        Looping_Animation_Start_Time = 0xFFFFF2CD,
        Looping_Animation_End_Time = 0xFFFFF2CE,
        Looping_Animation_Suppress_Item_Tooltips = 0xFFFFF2CF,
        Heal_Effect_Last_Played_Tick = 0xFFFFF2D0,
        Resource_Effect_Last_Played_tick = 0xFFFFF2D1,
        Thorns_Effect_Last_Played_tick = 0xFFFFF2D2,
        PVP_Kills = 0xFFFFF2D3,
        PVP_Deaths = 0xFFFFF2D4,
        PVP_Assists = 0xFFFFF2D5,
        PVP_Progression_Points_Gained = 0xFFFFF2D6,
        PVP_Current_Kill_Streak = 0xFFFFF2D7,
        PVP_Current_Death_Streak = 0xFFFFF2D8,
        PVP_Longest_Kill_Streak = 0xFFFFF2D9,
        PVP_Longest_Death_Streak = 0xFFFFF2DA,
        Turn_Rate_Scalar = 0xFFFFF2DB,
        Turn_Accel_Scalar = 0xFFFFF2DC,
        Turn_Deccel_Scalar = 0xFFFFF2DD,
        No_Health_Drop = 0xFFFFF2DE,
        Leader = 0xFFFFF2DF,
        IsContentRestrictedActor = 0xFFFFF2E0,
        InBossEncounter = 0xFFFFF2E1,
        God = 0xFFFFF2E2,
        MinimapActive = 0xFFFFF2E3,
        MinimapIconOverride = 0xFFFFF2E4,
        MinimapDisableArrow = 0xFFFFF2E5,
        Last_Blocked_ACDMinimap = 0xFFFFF2E6,
        Last_Blocked_Time = 0xFFFFF2E7,
        Deactivate = 0xFFFFF2E8,
        Weapons_Hidden = 0xFFFFF2E9,
        Actor_Updates_Attributes_From_Owner = 0xFFFFF2EA,
        Taunt_Target_ACDActor_Updates_Attributes_From_Owner = 0xFFFFF2EB,
        UI_Only_Percent_Damage_Increase = 0xFFFFF2EC,
        Projectile_Effect_SNOUI_Only_Percent_Damage_Increase = 0xFFFFF2ED,
        On_Hit_Fear_Proc_Chance = 0xFFFFF2EE,
        On_Hit_Stun_Proc_Chance = 0xFFFFF2EF,
        On_Hit_Blind_Proc_Chance = 0xFFFFF2F0,
        On_Hit_Freeze_Proc_Chance = 0xFFFFF2F1,
        On_Hit_Chill_Proc_Chance = 0xFFFFF2F2,
        On_Hit_Slow_Proc_Chance = 0xFFFFF2F3,
        On_Hit_Immobilize_Proc_Chance = 0xFFFFF2F4,
        On_Hit_Knockback_Proc_Chance = 0xFFFFF2F5,
        On_Hit_Bleed_Proc_Chance = 0xFFFFF2F6,
        On_Hit_Bleed_Proc_Damage_Base = 0xFFFFF2F7,
        On_Hit_Bleed_Proc_Damage_Delta = 0xFFFFF2F8,
        Damage_Percent_Reduction_From_Ranged = 0xFFFFF2F9,
        Damage_Percent_Reduction_From_Melee = 0xFFFFF2FA,
        Damage_Percent_Reduction_Turns_Into_Heal = 0xFFFFF2FB,
        Damage_Percent_Reduction_From_Elites = 0xFFFFF2FC,
        Damage_Percent_Reduction_From_Type = 0xFFFFF2FD,
        Damage_Percent_Bonus_Vs_Monster_Type = 0xFFFFF2FE,
        Damage_Percent_Bonus_Vs_Elites = 0xFFFFF2FF,
        Item_Manipulation_Timeout = 0xFFFFF300,
        Picked_Up_Time = 0xFFFFF301,
        Unequipped = 0xFFFFF302,
        Last_ACD_Killed_Time = 0xFFFFF303,
        Cannot = 0xFFFFF304,
        Weapon_On_Hit_Fear_Proc_Chance = 0xFFFFF305,
        Weapon_On_Hit_Stun_Proc_Chance = 0xFFFFF306,
        Weapon_On_Hit_Blind_Proc_Chance = 0xFFFFF307,
        Weapon_On_Hit_Freeze_Proc_Chance = 0xFFFFF308,
        Weapon_On_Hit_Chill_Proc_Chance = 0xFFFFF309,
        Weapon_On_Hit_Slow_Proc_Chance = 0xFFFFF30A,
        Weapon_On_Hit_Immobilize_Proc_Chance = 0xFFFFF30B,
        Weapon_On_Hit_Knockback_Proc_Chance = 0xFFFFF30C,
        Weapon_On_Hit_Bleed_Proc_Chance = 0xFFFFF30D,
        Weapon_On_Hit_Bleed_Proc_Damage_Base = 0xFFFFF30E,
        Weapon_On_Hit_Bleed_Proc_Damage_Delta = 0xFFFFF30F,
        Weapon_On_Hit_Fear_Proc_Chance_Main = 0xFFFFF310,
        Weapon_On_Hit_Fear_Proc_Chance_Off = 0xFFFFF311,
        Weapon_On_Hit_Fear_Proc_Chance_Current = 0xFFFFF312,
        Weapon_On_Hit_Stun_Proc_Chance_Main = 0xFFFFF313,
        Weapon_On_Hit_Stun_Proc_Chance_Off = 0xFFFFF314,
        Weapon_On_Hit_Stun_Proc_Chance_Current = 0xFFFFF315,
        Weapon_On_Hit_Blind_Proc_Chance_Main = 0xFFFFF316,
        Weapon_On_Hit_Blind_Proc_Chance_Off = 0xFFFFF317,
        Weapon_On_Hit_Blind_Proc_Chance_Current = 0xFFFFF318,
        Weapon_On_Hit_Freeze_Proc_Chance_Main = 0xFFFFF319,
        Weapon_On_Hit_Freeze_Proc_Chance_Off = 0xFFFFF31A,
        Weapon_On_Hit_Freeze_Proc_Chance_Current = 0xFFFFF31B,
        Weapon_On_Hit_Chill_Proc_Chance_Main = 0xFFFFF31C,
        Weapon_On_Hit_Chill_Proc_Chance_Off = 0xFFFFF31D,
        Weapon_On_Hit_Chill_Proc_Chance_Current = 0xFFFFF31E,
        Weapon_On_Hit_Slow_Proc_Chance_Main = 0xFFFFF31F,
        Weapon_On_Hit_Slow_Proc_Chance_Off = 0xFFFFF320,
        Weapon_On_Hit_Slow_Proc_Chance_Current = 0xFFFFF321,
        Weapon_On_Hit_Immobilize_Proc_Chance_Main = 0xFFFFF322,
        Weapon_On_Hit_Immobilize_Proc_Chance_Off = 0xFFFFF323,
        Weapon_On_Hit_Immobilize_Proc_Chance_Current = 0xFFFFF324,
        Weapon_On_Hit_Knockback_Proc_Chance_Main = 0xFFFFF325,
        Weapon_On_Hit_Knockback_Proc_Chance_Off = 0xFFFFF326,
        Weapon_On_Hit_Knockback_Proc_Chance_Current = 0xFFFFF327,
        Weapon_On_Hit_Bleed_Proc_Chance_Main = 0xFFFFF328,
        Weapon_On_Hit_Bleed_Proc_Chance_Off = 0xFFFFF329,
        Weapon_On_Hit_Bleed_Proc_Chance_Current = 0xFFFFF32A,
        Weapon_On_Hit_Bleed_Proc_Damage_Base_Main = 0xFFFFF32B,
        Weapon_On_Hit_Bleed_Proc_Damage_Base_Off = 0xFFFFF32C,
        Weapon_On_Hit_Bleed_Proc_Damage_Base_Current = 0xFFFFF32D,
        Weapon_On_Hit_Bleed_Proc_Damage_Delta_Main = 0xFFFFF32E,
        Weapon_On_Hit_Bleed_Proc_Damage_Delta_Off = 0xFFFFF32F,
        Weapon_On_Hit_Bleed_Proc_Damage_Delta_Current = 0xFFFFF330,
        Power_Damage_Percent_Bonus = 0xFFFFF331,
        Power_Resource_Reduction = 0xFFFFF332,
        Power_Cooldown_Reduction = 0xFFFFF333,
        Power_Duration_Increase = 0xFFFFF334,
        Power_Crit_Percent_Bonus = 0xFFFFF335,
        Weapon_Crit_Chance = 0xFFFFF336,
        Weapon_Crit_Chance_Main = 0xFFFFF337,
        Weapon_Crit_Chance_Off = 0xFFFFF338,
        Weapon_Crit_Chance_Current = 0xFFFFF339,
        Strength_Item = 0xFFFFF33A,
        Dexterity_Item = 0xFFFFF33B,
        Intelligence_Item = 0xFFFFF33C,
        Vitality_Item = 0xFFFFF33D,
        Item_Level_Requirement_Reduction = 0xFFFFF33E,
        Item_Durability_Percent_Bonus = 0xFFFFF33F,
        Item_Indestructible = 0xFFFFF340,
        Core_Attributes_From_Item_Bonus_Multiplier = 0xFFFFF341,
        Waiting_To_Accept_Resurrection = 0xFFFFF342,
        Ghosted = 0xFFFFF343,
        Special_Inventory_Has_Sold = 0xFFFFF344,
        IGR_Buff_Poll_Next_Time = 0xFFFFF345,
        Power_Channel_Lockout_Time = 0xFFFFF346,
        Power_Buff_0_Lockout_Time = 0xFFFFF347,
        Power_Buff_1_Lockout_Time = 0xFFFFF348,
        Power_Buff_2_Lockout_Time = 0xFFFFF349,
        Power_Buff_3_Lockout_Time = 0xFFFFF34A,
        Power_Buff_4_Lockout_Time = 0xFFFFF34B,
        Power_Buff_5_Lockout_Time = 0xFFFFF34C,
        Power_Buff_6_Lockout_Time = 0xFFFFF34D,
        Power_Buff_7_Lockout_Time = 0xFFFFF34E,
        Known_By_Owner = 0xFFFFF34F,
        Never_Deactivates = 0xFFFFF350,
        Account_Under_Review = 0xFFFFF351,
        Projectile_Detonate_Time = 0xFFFFF352,
        Accolade_0 = 0xFFFFF353,
        Accolade_1 = 0xFFFFF354,
        Accolade_2 = 0xFFFFF355,
        Accolade_3 = 0xFFFFF356,
        Accolade_4 = 0xFFFFF357,
        Accolade_0_Value = 0xFFFFF358,
        Accolade_1_Value = 0xFFFFF359,
        Accolade_2_Value = 0xFFFFF35A,
        Accolade_3_Value = 0xFFFFF35B,
        Accolade_4_Value = 0xFFFFF35C,
        PVP_Rank = 0xFFFFF35D,
        PVP_Tokens = 0xFFFFF35E,
        PVP_Experience_Next = 0xFFFFF35F,
        PVP_Gold_Gained_This_Game = 0xFFFFF360,
        PVP_PVP_Experience_Gained_This_Game = 0xFFFFF361,
        PVP_Normal_Experience_Gained_This_Game = 0xFFFFF362,
        PVP_Tokens_Gained_This_Game = 0xFFFFF363,
        PVP_Level_Equalizer_Level = 0xFFFFF364,
        On_Death_Accolade_0 = 0xFFFFF365,
        On_Death_Accolade_0_Value = 0xFFFFF366,
        Item_Power_Passive = 0xFFFFF367,
        PVP_Team = 0xFFFFF368,
        Last_Health_Drop_Interval = 0xFFFFF369,
        CrowdControl_Resistance = 0xFFFFF36A,
        CrowdControl_Projected_End_Time = 0xFFFFF36B,
        Charmed = 0xFFFFF36C,
        Taunted = 0xFFFFF36D,

    }
}
