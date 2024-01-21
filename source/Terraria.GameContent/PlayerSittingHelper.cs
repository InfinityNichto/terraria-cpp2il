using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000561")]
public struct PlayerSittingHelper
{
	[Cpp2IlInjected.Token(Token = "0x4006929")]
	public const int ChairSittingMaxDistance = 40;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400692A")]
	public bool isSitting;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400692B")]
	public ExtraSeatInfo details;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400692C")]
	public Vector2 offsetForSeat;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400692D")]
	public int sittingIndex;

	[Cpp2IlInjected.Token(Token = "0x6003A52")]
	[Cpp2IlInjected.Address(RVA = "0x39D034", Offset = "0x39D034", VA = "0x39D034")]
	public void GetSittingOffsetInfo(Player player, out Vector2 posOffset, out float seatAdjustment)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A53")]
	[Cpp2IlInjected.Address(RVA = "0x39D050", Offset = "0x39D050", VA = "0x39D050")]
	public bool TryGetSittingBlock(Player player, out Tile tile)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003A54")]
	[Cpp2IlInjected.Address(RVA = "0x39D058", Offset = "0x39D058", VA = "0x39D058")]
	public void UpdateSitting(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A55")]
	[Cpp2IlInjected.Address(RVA = "0x39D060", Offset = "0x39D060", VA = "0x39D060")]
	public void SitUp(Player player, bool multiplayerBroadcast = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A56")]
	[Cpp2IlInjected.Address(RVA = "0x39D068", Offset = "0x39D068", VA = "0x39D068")]
	public void SitDown(Player player, int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A57")]
	[Cpp2IlInjected.Address(RVA = "0x119949C", Offset = "0x119949C", VA = "0x119949C")]
	public static bool GetSittingTargetInfo(Player player, int x, int y, out int targetDirection, out Vector2 playerSittingPosition, out Vector2 seatDownOffset, out ExtraSeatInfo extraInfo)
	{
		return default(bool);
	}
}
