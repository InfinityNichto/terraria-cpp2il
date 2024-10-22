﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.ItemDropRules
{
	[global::Cpp2ILInjected.Token(Token = "0x200086C")]
	public class ItemDropRule
	{
		[global::Cpp2ILInjected.Token(Token = "0x60043C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A62E8", Offset = "0x7A62E8", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "NormalvsExpert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBloodMoonFishing", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterEclipse", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterMimic", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterHardmodeDungeonDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_QueenSlime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_HallowBoss", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_PumpkinMoon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_FrostMoon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_KingSlime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Plantera", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Twins", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_EOW", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Skeletron", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_AncientCultist", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Golem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterGlobalRules", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterTownNPCDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterDD2EventDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterHardmodeFeathers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterPirateDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBossTrophies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterMartianDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterMiscDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 345)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonDrop), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static IItemDropRule Common(int itemId, int chanceDenominator = 1, int minimumDropped = 1, int maximumDropped = 1)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A641C", Offset = "0x7A641C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_QueenSlime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_HallowBoss", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_KingSlime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Plantera", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_SkeletronPrime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_TheDestroyer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Twins", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_EOC", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_BOC", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Deerclops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_QueenBee", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Skeletron", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_WOF", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_MoonLord", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Betsy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Golem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_DukeFishron", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "DropNothing", ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonDrop), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropBasedOnExpertMode), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static IItemDropRule BossBag(int itemId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A65D4", Offset = "0x7A65D4", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_EOW", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "DropNothing", ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonDrop), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropBasedOnExpertMode), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static IItemDropRule BossBagByCondition(IItemDropRuleCondition condition, int itemId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A6684", Offset = "0x7A6684", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "StatusImmunityItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterEclipse", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterHardmodeDungeonDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 35)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "WithRerolls", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropBasedOnExpertMode), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static IItemDropRule ExpertGetsRerolls(int itemId, int chanceDenominator, int expertRerolls)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A67BC", Offset = "0x7A67BC", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_QueenSlime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_HallowBoss", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_PumpkinMoon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_FrostMoon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_KingSlime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Plantera", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_SkeletronPrime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_TheDestroyer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Twins", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_EOC", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_BOC", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_EOW", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Deerclops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_QueenBee", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Skeletron", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_WOF", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_AncientCultist", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_MoonLord", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Betsy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Golem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_DukeFishron", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterDD2EventDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterPirateDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterMartianDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 29)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Conditions.IsMasterMode), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static IItemDropRule MasterModeCommonDrop(int itemId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A68C4", Offset = "0x7A68C4", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_QueenSlime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_HallowBoss", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_PumpkinMoon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_FrostMoon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_KingSlime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Plantera", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_SkeletronPrime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_TheDestroyer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Twins", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_EOC", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_BOC", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_EOW", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Deerclops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_QueenBee", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Skeletron", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_WOF", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_AncientCultist", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_MoonLord", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Betsy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Golem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_DukeFishron", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterDD2EventDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterPirateDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterMartianDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 29)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "DropNothing", ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Conditions.IsMasterMode), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonDrop), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropBasedOnMasterMode), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static IItemDropRule MasterModeDropOnAllPlayers(int itemId, int chanceDenominator = 1)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A672C", Offset = "0x7A672C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "ExpertGetsRerolls", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterEclipse", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterMiscDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonDrop), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static IItemDropRule WithRerolls(int itemId, int rerolls, int chanceDenominator = 1, int minimumDropped = 1, int maximumDropped = 1)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A6828", Offset = "0x7A6828", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBloodMoonFishing", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_PumpkinMoon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_FrostMoon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_SkeletronPrime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_TheDestroyer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Twins", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_EOC", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_BOC", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_EOW", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Deerclops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_QueenBee", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Skeletron", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_WOF", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_MoonLord", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Betsy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Golem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_DukeFishron", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterGlobalRules", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterTownNPCDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBossTrophies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterMiscDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 96)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropWithConditionRule), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(IItemDropRuleCondition),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static IItemDropRule ByCondition(IItemDropRuleCondition condition, int itemId, int chanceDenominator = 1, int minimumDropped = 1, int maximumDropped = 1, int chanceNumerator = 1)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A6A8C", Offset = "0x7A6A8C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "NormalvsExpertNotScalingWithLuck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_QueenSlime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_KingSlime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterDD2EventDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterMiscDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonDrop), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static IItemDropRule NotScalingWithLuck(int itemId, int chanceDenominator = 1, int minimumDropped = 1, int maximumDropped = 1)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A6B18", Offset = "0x7A6B18", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "NormalvsExpertOneFromOptionsNotScalingWithLuck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Deerclops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_QueenBee", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_WOF", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_Betsy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterDD2EventDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterMartianDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneFromOptionsNotScaledWithLuckDropRule), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static IItemDropRule OneFromOptionsNotScalingWithLuck(int chanceDenominator, params int[] options)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A6B88", Offset = "0x7A6B88", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneFromOptionsNotScaledWithLuckDropRule), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static IItemDropRule OneFromOptionsNotScalingWithLuckWithX(int chanceDenominator, int chanceNumerator, params int[] options)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A6BFC", Offset = "0x7A6BFC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "NormalvsExpertOneFromOptions", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBloodMoonFishing", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterMimic", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_QueenSlime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_HallowBoss", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_PumpkinMoon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_FrostMoon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_KingSlime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_DukeFishron", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterPirateDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterMiscDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 35)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneFromOptionsDropRule), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static IItemDropRule OneFromOptions(int chanceDenominator, params int[] options)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A6C6C", Offset = "0x7A6C6C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneFromOptionsDropRule), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static IItemDropRule OneFromOptionsWithNumerator(int chanceDenominator, int chanceNumerator, params int[] options)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A64C8", Offset = "0x7A64C8", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "BossBag", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "BossBagByCondition", MemberParameters = new object[]
		{
			typeof(IItemDropRuleCondition),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropRule), Member = "MasterModeDropOnAllPlayers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_QueenBee", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropNothing), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static IItemDropRule DropNothing()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A6D60", Offset = "0x7A6D60", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBloodMoonFishing", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterWeirdRules", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterMiscDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropBasedOnExpertMode), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static IItemDropRule NormalvsExpert(int itemId, int chanceDenominatorInNormal, int chanceDenominatorInExpert)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A6E00", Offset = "0x7A6E00", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterDD2EventDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "NotScalingWithLuck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropBasedOnExpertMode), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static IItemDropRule NormalvsExpertNotScalingWithLuck(int itemId, int chanceDenominatorInNormal, int chanceDenominatorInExpert)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A6EA0", Offset = "0x7A6EA0", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterDD2EventDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "OneFromOptionsNotScalingWithLuck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropBasedOnExpertMode), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static IItemDropRule NormalvsExpertOneFromOptionsNotScalingWithLuck(int chanceDenominatorInNormal, int chanceDenominatorInExpert, params int[] options)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A6F30", Offset = "0x7A6F30", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterMiscDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "OneFromOptions", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(IItemDropRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropBasedOnExpertMode), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IItemDropRule),
			typeof(IItemDropRule)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static IItemDropRule NormalvsExpertOneFromOptions(int chanceDenominatorInNormal, int chanceDenominatorInExpert, params int[] options)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A6FC0", Offset = "0x7A6FC0", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterFoodDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 26)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Conditions.NotFromStatue), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropWithConditionRule), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(IItemDropRuleCondition),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static IItemDropRule Food(int itemId, int chanceDenominator, int minimumDropped = 1, int maximumDropped = 1)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A7074", Offset = "0x7A7074", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterStatusImmunityItems", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropRule), Member = "ExpertGetsRerolls", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IItemDropRule))]
		public static IItemDropRule StatusImmunityItem(int itemId, int dropsOutOfX)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A707C", Offset = "0x7A707C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ItemDropRule()
		{
			throw null;
		}
	}
}
