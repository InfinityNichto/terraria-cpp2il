using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.Utilities;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x200054B")]
public class FlexibleTileWand
{
	[Cpp2IlInjected.Token(Token = "0x200097C")]
	public class OptionBucket
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008C03")]
		public int ItemTypeToConsume;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008C04")]
		public List<PlacementOption> Options;

		[Cpp2IlInjected.Token(Token = "0x6004DDE")]
		[Cpp2IlInjected.Address(RVA = "0xE63EC0", Offset = "0xE63EC0", VA = "0xE63EC0")]
		public OptionBucket(int itemTypeToConsume)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004DDF")]
		[Cpp2IlInjected.Address(RVA = "0xE63F4C", Offset = "0xE63F4C", VA = "0xE63F4C")]
		public PlacementOption GetRandomOption(UnifiedRandom random)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004DE0")]
		[Cpp2IlInjected.Address(RVA = "0xE63FCC", Offset = "0xE63FCC", VA = "0xE63FCC")]
		public PlacementOption GetOptionWithCycling(int cycleOffset)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200097D")]
	public class PlacementOption
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008C05")]
		public int TileIdToPlace;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008C06")]
		public int TileStyleToPlace;

		[Cpp2IlInjected.Token(Token = "0x6004DE1")]
		[Cpp2IlInjected.Address(RVA = "0xE64054", Offset = "0xE64054", VA = "0xE64054")]
		public PlacementOption()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40068D7")]
	public static FlexibleTileWand RubblePlacementSmall;

	[Cpp2IlInjected.Token(Token = "0x40068D8")]
	public static FlexibleTileWand RubblePlacementMedium;

	[Cpp2IlInjected.Token(Token = "0x40068D9")]
	public static FlexibleTileWand RubblePlacementLarge;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40068DA")]
	private UnifiedRandom _random;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40068DB")]
	public Dictionary<int, OptionBucket> _options;

	[Cpp2IlInjected.Token(Token = "0x40068DC")]
	private static int maxVariations;

	[Cpp2IlInjected.Token(Token = "0x60039EB")]
	[Cpp2IlInjected.Address(RVA = "0xF651C4", Offset = "0xF651C4", VA = "0xF651C4")]
	public void AddVariation(int itemType, int tileIdToPlace, int tileStyleToPlace)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039EC")]
	[Cpp2IlInjected.Address(RVA = "0xF65370", Offset = "0xF65370", VA = "0xF65370")]
	public void AddVariations(int itemType, int tileIdToPlace, params int[] stylesToPlace)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039ED")]
	[Cpp2IlInjected.Address(RVA = "0xF653CC", Offset = "0xF653CC", VA = "0xF653CC")]
	public void AddVariations_ByRow(int itemType, int tileIdToPlace, int variationsPerRow, params int[] rows)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039EE")]
	[Cpp2IlInjected.Address(RVA = "0xF65450", Offset = "0xF65450", VA = "0xF65450")]
	public bool TryGetPlacementOption(Player player, int randomSeed, int selectCycleOffset, out PlacementOption option, out Item itemToConsume)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60039EF")]
	[Cpp2IlInjected.Address(RVA = "0xF6555C", Offset = "0xF6555C", VA = "0xF6555C")]
	private static void EnsureAllMaterialOptions(FlexibleTileWand wand)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039F0")]
	[Cpp2IlInjected.Address(RVA = "0xF657A0", Offset = "0xF657A0", VA = "0xF657A0")]
	public static FlexibleTileWand CreateRubblePlacerLarge()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60039F1")]
	[Cpp2IlInjected.Address(RVA = "0xF6627C", Offset = "0xF6627C", VA = "0xF6627C")]
	public static FlexibleTileWand CreateRubblePlacerMedium()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60039F2")]
	[Cpp2IlInjected.Address(RVA = "0xF66BB8", Offset = "0xF66BB8", VA = "0xF66BB8")]
	public static FlexibleTileWand CreateRubblePlacerSmall()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60039F3")]
	[Cpp2IlInjected.Address(RVA = "0xF671B8", Offset = "0xF671B8", VA = "0xF671B8")]
	public static void ForModders_AddPotsToWand(FlexibleTileWand wand, ref int echoPileStyle, ref ushort tileType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039F4")]
	[Cpp2IlInjected.Address(RVA = "0xF661D4", Offset = "0xF661D4", VA = "0xF661D4")]
	public FlexibleTileWand()
	{
	}
}
