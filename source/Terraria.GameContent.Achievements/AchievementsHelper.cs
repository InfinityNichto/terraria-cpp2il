using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.Achievements;

[Cpp2IlInjected.Token(Token = "0x2000652")]
public class AchievementsHelper
{
	[Cpp2IlInjected.Token(Token = "0x2000A2B")]
	public delegate void ItemPickupEvent(Player player, short itemId, int count);

	[Cpp2IlInjected.Token(Token = "0x2000A2C")]
	public delegate void ItemCraftEvent(Player player, short itemId, int count);

	[Cpp2IlInjected.Token(Token = "0x2000A2D")]
	public delegate void TileDestroyedEvent(Player player, ushort tileId);

	[Cpp2IlInjected.Token(Token = "0x2000A2E")]
	public delegate void NPCKilledEvent(Player player, short npcId);

	[Cpp2IlInjected.Token(Token = "0x2000A2F")]
	public delegate void ProgressionEventEvent(int eventID);

	[Cpp2IlInjected.Token(Token = "0x4006CA2")]
	private static bool _isMining;

	[Cpp2IlInjected.Token(Token = "0x4006CA3")]
	private static bool mayhemOK;

	[Cpp2IlInjected.Token(Token = "0x4006CA4")]
	private static bool mayhem1down;

	[Cpp2IlInjected.Token(Token = "0x4006CA5")]
	private static bool mayhem2down;

	[Cpp2IlInjected.Token(Token = "0x4006CA6")]
	private static bool mayhem3down;

	[Cpp2IlInjected.Token(Token = "0x17000777")]
	public static bool CurrentlyMining
	{
		[Cpp2IlInjected.Token(Token = "0x6003F72")]
		[Cpp2IlInjected.Address(RVA = "0x1331780", Offset = "0x1331780", VA = "0x1331780")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6003F73")]
		[Cpp2IlInjected.Address(RVA = "0x13317D8", Offset = "0x13317D8", VA = "0x13317D8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000050")]
	public static event ItemPickupEvent OnItemPickup
	{
		[Cpp2IlInjected.Token(Token = "0x6003F68")]
		[Cpp2IlInjected.Address(RVA = "0x1330FB8", Offset = "0x1330FB8", VA = "0x1330FB8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6003F69")]
		[Cpp2IlInjected.Address(RVA = "0x133107C", Offset = "0x133107C", VA = "0x133107C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000051")]
	public static event ItemCraftEvent OnItemCraft
	{
		[Cpp2IlInjected.Token(Token = "0x6003F6A")]
		[Cpp2IlInjected.Address(RVA = "0x1331140", Offset = "0x1331140", VA = "0x1331140")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6003F6B")]
		[Cpp2IlInjected.Address(RVA = "0x1331208", Offset = "0x1331208", VA = "0x1331208")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000052")]
	public static event TileDestroyedEvent OnTileDestroyed
	{
		[Cpp2IlInjected.Token(Token = "0x6003F6C")]
		[Cpp2IlInjected.Address(RVA = "0x13312D0", Offset = "0x13312D0", VA = "0x13312D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6003F6D")]
		[Cpp2IlInjected.Address(RVA = "0x1331398", Offset = "0x1331398", VA = "0x1331398")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000053")]
	public static event NPCKilledEvent OnNPCKilled
	{
		[Cpp2IlInjected.Token(Token = "0x6003F6E")]
		[Cpp2IlInjected.Address(RVA = "0x1331460", Offset = "0x1331460", VA = "0x1331460")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6003F6F")]
		[Cpp2IlInjected.Address(RVA = "0x1331528", Offset = "0x1331528", VA = "0x1331528")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000054")]
	public static event ProgressionEventEvent OnProgressionEvent
	{
		[Cpp2IlInjected.Token(Token = "0x6003F70")]
		[Cpp2IlInjected.Address(RVA = "0x13315F0", Offset = "0x13315F0", VA = "0x13315F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6003F71")]
		[Cpp2IlInjected.Address(RVA = "0x13316B8", Offset = "0x13316B8", VA = "0x13316B8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003F74")]
	[Cpp2IlInjected.Address(RVA = "0x1331834", Offset = "0x1331834", VA = "0x1331834")]
	public static void NotifyTileDestroyed(Player player, ushort tile)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F75")]
	[Cpp2IlInjected.Address(RVA = "0x13318F4", Offset = "0x13318F4", VA = "0x13318F4")]
	public static void NotifyItemPickup(Player player, Item item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F76")]
	[Cpp2IlInjected.Address(RVA = "0x13319C0", Offset = "0x13319C0", VA = "0x13319C0")]
	public static void NotifyItemPickup(Player player, Item item, int customStack)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F77")]
	[Cpp2IlInjected.Address(RVA = "0x1331A90", Offset = "0x1331A90", VA = "0x1331A90")]
	public static void NotifyItemCraft(Recipe recipe)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F78")]
	[Cpp2IlInjected.Address(RVA = "0x1331F9C", Offset = "0x1331F9C", VA = "0x1331F9C")]
	public static void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F79")]
	[Cpp2IlInjected.Address(RVA = "0x133202C", Offset = "0x133202C", VA = "0x133202C")]
	internal static void OnPlayerEnteredWorld(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F7A")]
	[Cpp2IlInjected.Address(RVA = "0x1332B0C", Offset = "0x1332B0C", VA = "0x1332B0C")]
	public static void NotifyNPCKilled(NPC npc)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F7B")]
	[Cpp2IlInjected.Address(RVA = "0x1332CA0", Offset = "0x1332CA0", VA = "0x1332CA0")]
	public static void NotifyNPCKilledDirect(Player player, int npcNetID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F7C")]
	[Cpp2IlInjected.Address(RVA = "0x1332DD4", Offset = "0x1332DD4", VA = "0x1332DD4")]
	public static void NotifyProgressionEvent(int eventID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F7D")]
	[Cpp2IlInjected.Address(RVA = "0x1333078", Offset = "0x1333078", VA = "0x1333078")]
	public static void HandleOnEquip(Player player, Item item, int context)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F7E")]
	[Cpp2IlInjected.Address(RVA = "0x1333518", Offset = "0x1333518", VA = "0x1333518")]
	public static void HandleSpecialEvent(Player player, int eventID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F7F")]
	[Cpp2IlInjected.Address(RVA = "0x1333E68", Offset = "0x1333E68", VA = "0x1333E68")]
	public static void HandleNurseService(int coinsSpent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F80")]
	[Cpp2IlInjected.Address(RVA = "0x1333F60", Offset = "0x1333F60", VA = "0x1333F60")]
	public static void HandleAnglerService()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F81")]
	[Cpp2IlInjected.Address(RVA = "0x133419C", Offset = "0x133419C", VA = "0x133419C")]
	public static void HandleRunning(Player player, float pixelsMoved)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F82")]
	[Cpp2IlInjected.Address(RVA = "0x1334368", Offset = "0x1334368", VA = "0x1334368")]
	public static void HandleMining()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F83")]
	[Cpp2IlInjected.Address(RVA = "0x1334450", Offset = "0x1334450", VA = "0x1334450")]
	public static void CheckMechaMayhem(int justKilled = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F84")]
	[Cpp2IlInjected.Address(RVA = "0x1331EA4", Offset = "0x1331EA4", VA = "0x1331EA4")]
	private static bool IsMetalBar(int itemType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003F85")]
	[Cpp2IlInjected.Address(RVA = "0x13347B8", Offset = "0x13347B8", VA = "0x13347B8")]
	public AchievementsHelper()
	{
	}
}
