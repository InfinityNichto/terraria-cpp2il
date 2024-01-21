using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000480")]
public struct TileReachCheckSettings
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006496")]
	public int TileRangeMultiplier;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4006497")]
	public int? TileReachLimit;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006498")]
	public int? OverrideXReach;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006499")]
	public int? OverrideYReach;

	[Cpp2IlInjected.Token(Token = "0x17000636")]
	public static TileReachCheckSettings Simple
	{
		[Cpp2IlInjected.Token(Token = "0x60032A1")]
		[Cpp2IlInjected.Address(RVA = "0x1231934", Offset = "0x1231934", VA = "0x1231934")]
		get
		{
			return default(TileReachCheckSettings);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000637")]
	public static TileReachCheckSettings Pylons
	{
		[Cpp2IlInjected.Token(Token = "0x60032A2")]
		[Cpp2IlInjected.Address(RVA = "0x12319C4", Offset = "0x12319C4", VA = "0x12319C4")]
		get
		{
			return default(TileReachCheckSettings);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000638")]
	public static TileReachCheckSettings QuickStackToNearbyChests
	{
		[Cpp2IlInjected.Token(Token = "0x60032A3")]
		[Cpp2IlInjected.Address(RVA = "0x1231A78", Offset = "0x1231A78", VA = "0x1231A78")]
		get
		{
			return default(TileReachCheckSettings);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60032A0")]
	[Cpp2IlInjected.Address(RVA = "0x39DBFC", Offset = "0x39DBFC", VA = "0x39DBFC")]
	public void GetRanges(Player player, out int x, out int y)
	{
	}
}
