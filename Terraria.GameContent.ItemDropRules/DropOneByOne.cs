using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005DC")]
public class DropOneByOne : IItemDropRule
{
	[Cpp2IlInjected.Token(Token = "0x20009AD")]
	public struct Parameters
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008CC2")]
		public int ChanceNumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008CC3")]
		public int ChanceDenominator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008CC4")]
		public int MinimumItemDropsCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008CC5")]
		public int MaximumItemDropsCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008CC6")]
		public int MinimumStackPerChunkBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008CC7")]
		public int MaximumStackPerChunkBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008CC8")]
		public int BonusMinDropsPerChunkPerPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4008CC9")]
		public int BonusMaxDropsPerChunkPerPlayer;

		[Cpp2IlInjected.Token(Token = "0x6004E77")]
		[Cpp2IlInjected.Address(RVA = "0x39A20C", Offset = "0x39A20C", VA = "0x39A20C")]
		public float GetPersonalDropRate()
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006BB5")]
	public int itemId;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006BB6")]
	public Parameters parameters;

	[Cpp2IlInjected.Token(Token = "0x17000738")]
	public List<IItemDropRuleChainAttempt> ChainedRules
	{
		[Cpp2IlInjected.Token(Token = "0x6003CF9")]
		[Cpp2IlInjected.Address(RVA = "0xE789BC", Offset = "0xE789BC", VA = "0xE789BC", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6003CFA")]
		[Cpp2IlInjected.Address(RVA = "0xE789C4", Offset = "0xE789C4", VA = "0xE789C4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003CFB")]
	[Cpp2IlInjected.Address(RVA = "0xE789CC", Offset = "0xE789CC", VA = "0xE789CC")]
	public DropOneByOne(int itemId, Parameters parameters)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003CFC")]
	[Cpp2IlInjected.Address(RVA = "0xE78A9C", Offset = "0xE78A9C", VA = "0xE78A9C", Slot = "7")]
	public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
	{
		return default(ItemDropAttemptResult);
	}

	[Cpp2IlInjected.Token(Token = "0x6003CFD")]
	[Cpp2IlInjected.Address(RVA = "0xE78BA4", Offset = "0xE78BA4", VA = "0xE78BA4", Slot = "6")]
	public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003CFE")]
	[Cpp2IlInjected.Address(RVA = "0xE78CE4", Offset = "0xE78CE4", VA = "0xE78CE4", Slot = "5")]
	public bool CanDrop(DropAttemptInfo info)
	{
		return default(bool);
	}
}
