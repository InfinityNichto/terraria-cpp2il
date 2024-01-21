using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.Achievements;

namespace Terraria.GameContent.Achievements;

[Cpp2IlInjected.Token(Token = "0x200065A")]
public class TileDestroyedCondition : AchievementCondition
{
	[Cpp2IlInjected.Token(Token = "0x4006CBE")]
	public const string Identifier = "TILE_DESTROYED";

	[Cpp2IlInjected.Token(Token = "0x4006CBF")]
	private static Dictionary<ushort, List<TileDestroyedCondition>> _listeners;

	[Cpp2IlInjected.Token(Token = "0x4006CC0")]
	private static bool _isListenerHooked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006CC1")]
	private readonly LocalUser _user;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006CC2")]
	private ushort[] _tileIds;

	[Cpp2IlInjected.Token(Token = "0x6003FBC")]
	[Cpp2IlInjected.Address(RVA = "0xFAC8E0", Offset = "0xFAC8E0", VA = "0xFAC8E0")]
	private TileDestroyedCondition(LocalUser user, ushort[] tileIds)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FBD")]
	[Cpp2IlInjected.Address(RVA = "0xFACC50", Offset = "0xFACC50", VA = "0xFACC50", Slot = "5")]
	public override void Shutdown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FBE")]
	[Cpp2IlInjected.Address(RVA = "0xFAC9BC", Offset = "0xFAC9BC", VA = "0xFAC9BC")]
	private static void ListenForDestruction(TileDestroyedCondition condition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FBF")]
	[Cpp2IlInjected.Address(RVA = "0xFACD34", Offset = "0xFACD34", VA = "0xFACD34")]
	private static void TileDestroyedListener(Player player, ushort tileId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FC0")]
	[Cpp2IlInjected.Address(RVA = "0xFACEC8", Offset = "0xFACEC8", VA = "0xFACEC8")]
	public static AchievementCondition Create(LocalUser user, params ushort[] tileIds)
	{
		return null;
	}
}
