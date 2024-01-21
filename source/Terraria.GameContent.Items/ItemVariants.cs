using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.GameContent.Items;

[Cpp2IlInjected.Token(Token = "0x20005C2")]
public static class ItemVariants
{
	[Cpp2IlInjected.Token(Token = "0x20009AA")]
	public class VariantEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008CBE")]
		public readonly ItemVariant Variant;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008CBF")]
		private readonly List<ItemVariantCondition> _conditions;

		[Cpp2IlInjected.Token(Token = "0x170008C6")]
		public IEnumerable<ItemVariantCondition> Conditions
		{
			[Cpp2IlInjected.Token(Token = "0x6004E6C")]
			[Cpp2IlInjected.Address(RVA = "0x105025C", Offset = "0x105025C", VA = "0x105025C")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E6D")]
		[Cpp2IlInjected.Address(RVA = "0x104E8B8", Offset = "0x104E8B8", VA = "0x104E8B8")]
		public VariantEntry(ItemVariant variant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004E6E")]
		[Cpp2IlInjected.Address(RVA = "0x104E944", Offset = "0x104E944", VA = "0x104E944")]
		internal void AddConditions(IEnumerable<ItemVariantCondition> conditions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004E6F")]
		[Cpp2IlInjected.Address(RVA = "0x104EC1C", Offset = "0x104EC1C", VA = "0x104EC1C")]
		public bool AnyConditionMet()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4006B7F")]
	private static List<VariantEntry>[] _variants;

	[Cpp2IlInjected.Token(Token = "0x4006B80")]
	public static ItemVariant StrongerVariant;

	[Cpp2IlInjected.Token(Token = "0x4006B81")]
	public static ItemVariant WeakerVariant;

	[Cpp2IlInjected.Token(Token = "0x4006B82")]
	public static ItemVariant RebalancedVariant;

	[Cpp2IlInjected.Token(Token = "0x4006B83")]
	public static ItemVariant EnabledVariant;

	[Cpp2IlInjected.Token(Token = "0x4006B84")]
	public static ItemVariant DisabledBossSummonVariant;

	[Cpp2IlInjected.Token(Token = "0x4006B85")]
	public static ItemVariantCondition RemixWorld;

	[Cpp2IlInjected.Token(Token = "0x4006B86")]
	public static ItemVariantCondition GetGoodWorld;

	[Cpp2IlInjected.Token(Token = "0x4006B87")]
	public static ItemVariantCondition EverythingWorld;

	[Cpp2IlInjected.Token(Token = "0x6003C88")]
	[Cpp2IlInjected.Address(RVA = "0x104E454", Offset = "0x104E454", VA = "0x104E454")]
	public static IEnumerable<VariantEntry> GetVariants(int itemId)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003C89")]
	[Cpp2IlInjected.Address(RVA = "0x104E60C", Offset = "0x104E60C", VA = "0x104E60C")]
	private static VariantEntry GetEntry(int itemId, ItemVariant variant)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003C8A")]
	[Cpp2IlInjected.Address(RVA = "0x104E718", Offset = "0x104E718", VA = "0x104E718")]
	public static void AddVariant(int itemId, ItemVariant variant, params ItemVariantCondition[] conditions)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C8B")]
	[Cpp2IlInjected.Address(RVA = "0x104E9A8", Offset = "0x104E9A8", VA = "0x104E9A8")]
	public static bool HasVariant(int itemId, ItemVariant variant)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003C8C")]
	[Cpp2IlInjected.Address(RVA = "0x104EA30", Offset = "0x104EA30", VA = "0x104EA30")]
	public static ItemVariant SelectVariant(int itemId)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003C8D")]
	[Cpp2IlInjected.Address(RVA = "0x104ED38", Offset = "0x104ED38", VA = "0x104ED38")]
	static ItemVariants()
	{
	}
}
