using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Utilities;

namespace Terraria.GameContent.ItemDropRules
{
	[global::Cpp2ILInjected.Token(Token = "0x2000885")]
	public class DropOneByOne : IItemDropRule
	{
		[global::Cpp2ILInjected.Token(Token = "0x170007DC")]
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600442B")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AA0E4", Offset = "0x7AA0E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600442C")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AA0EC", Offset = "0x7AA0EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600442D")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AA0F4", Offset = "0x7AA0F4", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemDropDatabase), Member = "RegisterBoss_LunarTowers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public DropOneByOne(int itemId, DropOneByOne.Parameters parameters)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600442E")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AA194", Offset = "0x7AA194", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "RollLuck", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonCode), Member = "DropItemFromNPC", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600442F")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AA2A0", Offset = "0x7AA2A0", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DropRateInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(List<IItemDropRuleCondition>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chains), Member = "ReportDroprates", MemberParameters = new object[]
		{
			typeof(List<IItemDropRuleChainAttempt>),
			typeof(float),
			typeof(List<DropRateInfo>),
			typeof(DropRateInfoChainFeed)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004430")]
		[global::Cpp2ILInjected.Address(RVA = "0x7AA410", Offset = "0x7AA410", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool CanDrop(DropAttemptInfo info)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40081D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int itemId;

		[global::Cpp2ILInjected.Token(Token = "0x40081D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public DropOneByOne.Parameters parameters;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40081D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x2000886")]
		public struct Parameters
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004431")]
			[global::Cpp2ILInjected.Address(RVA = "0x7AA3FC", Offset = "0x7AA3FC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public float GetPersonalDropRate()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40081D9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int ChanceNumerator;

			[global::Cpp2ILInjected.Token(Token = "0x40081DA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public int ChanceDenominator;

			[global::Cpp2ILInjected.Token(Token = "0x40081DB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public int MinimumItemDropsCount;

			[global::Cpp2ILInjected.Token(Token = "0x40081DC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public int MaximumItemDropsCount;

			[global::Cpp2ILInjected.Token(Token = "0x40081DD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int MinimumStackPerChunkBase;

			[global::Cpp2ILInjected.Token(Token = "0x40081DE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public int MaximumStackPerChunkBase;

			[global::Cpp2ILInjected.Token(Token = "0x40081DF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public int BonusMinDropsPerChunkPerPlayer;

			[global::Cpp2ILInjected.Token(Token = "0x40081E0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			public int BonusMaxDropsPerChunkPerPlayer;
		}
	}
}
