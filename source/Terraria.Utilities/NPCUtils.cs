using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.Utilities;

[Cpp2IlInjected.Token(Token = "0x200037A")]
public static class NPCUtils
{
	[Cpp2IlInjected.Token(Token = "0x20008CF")]
	public delegate bool SearchFilter<T>(T entity) where T : Entity;

	[Cpp2IlInjected.Token(Token = "0x20008D0")]
	public delegate void NPCTargetingMethod(NPC searcher, bool faceTarget, Vector2? checkPosition);

	[Cpp2IlInjected.Token(Token = "0x20008D1")]
	public static class SearchFilters
	{
		[Cpp2IlInjected.Token(Token = "0x6004C04")]
		[Cpp2IlInjected.Address(RVA = "0x10DDC28", Offset = "0x10DDC28", VA = "0x10DDC28")]
		public static bool OnlyCrystal(NPC npc)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004C05")]
		[Cpp2IlInjected.Address(RVA = "0x10DDC48", Offset = "0x10DDC48", VA = "0x10DDC48")]
		public static SearchFilter<Player> OnlyPlayersInCertainDistance(Vector2 position, float maxDistance)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C06")]
		[Cpp2IlInjected.Address(RVA = "0x10DDD18", Offset = "0x10DDD18", VA = "0x10DDD18")]
		public static bool NonBeeNPCs(NPC npc)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004C07")]
		[Cpp2IlInjected.Address(RVA = "0x10DDD4C", Offset = "0x10DDD4C", VA = "0x10DDD4C")]
		public static SearchFilter<Player> DownwindFromNPC(NPC npc, float maxDistanceX)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008D2")]
	public enum TargetType
	{
		[Cpp2IlInjected.Token(Token = "0x40080D9")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40080DA")]
		NPC,
		[Cpp2IlInjected.Token(Token = "0x40080DB")]
		Player,
		[Cpp2IlInjected.Token(Token = "0x40080DC")]
		TankPet
	}

	[Cpp2IlInjected.Token(Token = "0x20008D3")]
	public struct TargetSearchResults
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40080DD")]
		private TargetType _nearestTargetType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40080DE")]
		private int _nearestNPCIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40080DF")]
		private float _nearestNPCDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40080E0")]
		private int _nearestTankIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40080E1")]
		private float _nearestTankDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40080E2")]
		private float _adjustedTankDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40080E3")]
		private TargetType _nearestTankType;

		[Cpp2IlInjected.Token(Token = "0x1700088F")]
		public int NearestTargetIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6004C08")]
			[Cpp2IlInjected.Address(RVA = "0x39C84C", Offset = "0x39C84C", VA = "0x39C84C")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000890")]
		public Rectangle NearestTargetHitbox
		{
			[Cpp2IlInjected.Token(Token = "0x6004C09")]
			[Cpp2IlInjected.Address(RVA = "0x39C854", Offset = "0x39C854", VA = "0x39C854")]
			get
			{
				return default(Rectangle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000891")]
		public TargetType NearestTargetType
		{
			[Cpp2IlInjected.Token(Token = "0x6004C0A")]
			[Cpp2IlInjected.Address(RVA = "0x39C868", Offset = "0x39C868", VA = "0x39C868")]
			get
			{
				return default(TargetType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000892")]
		public bool FoundTarget
		{
			[Cpp2IlInjected.Token(Token = "0x6004C0B")]
			[Cpp2IlInjected.Address(RVA = "0x39C870", Offset = "0x39C870", VA = "0x39C870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000893")]
		public NPC NearestNPC
		{
			[Cpp2IlInjected.Token(Token = "0x6004C0C")]
			[Cpp2IlInjected.Address(RVA = "0x39C880", Offset = "0x39C880", VA = "0x39C880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000894")]
		public bool FoundNPC
		{
			[Cpp2IlInjected.Token(Token = "0x6004C0D")]
			[Cpp2IlInjected.Address(RVA = "0x39C888", Offset = "0x39C888", VA = "0x39C888")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000895")]
		public int NearestNPCIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6004C0E")]
			[Cpp2IlInjected.Address(RVA = "0x39C89C", Offset = "0x39C89C", VA = "0x39C89C")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000896")]
		public float NearestNPCDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6004C0F")]
			[Cpp2IlInjected.Address(RVA = "0x39C8A4", Offset = "0x39C8A4", VA = "0x39C8A4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000897")]
		public Player NearestTankOwner
		{
			[Cpp2IlInjected.Token(Token = "0x6004C10")]
			[Cpp2IlInjected.Address(RVA = "0x39C8AC", Offset = "0x39C8AC", VA = "0x39C8AC")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000898")]
		public bool FoundTank
		{
			[Cpp2IlInjected.Token(Token = "0x6004C11")]
			[Cpp2IlInjected.Address(RVA = "0x39C8B4", Offset = "0x39C8B4", VA = "0x39C8B4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000899")]
		public int NearestTankOwnerIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6004C12")]
			[Cpp2IlInjected.Address(RVA = "0x39C8C8", Offset = "0x39C8C8", VA = "0x39C8C8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700089A")]
		public float NearestTankDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6004C13")]
			[Cpp2IlInjected.Address(RVA = "0x39C8D0", Offset = "0x39C8D0", VA = "0x39C8D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700089B")]
		public float AdjustedTankDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6004C14")]
			[Cpp2IlInjected.Address(RVA = "0x39C8D8", Offset = "0x39C8D8", VA = "0x39C8D8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700089C")]
		public TargetType NearestTankType
		{
			[Cpp2IlInjected.Token(Token = "0x6004C15")]
			[Cpp2IlInjected.Address(RVA = "0x39C8E0", Offset = "0x39C8E0", VA = "0x39C8E0")]
			get
			{
				return default(TargetType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004C16")]
		[Cpp2IlInjected.Address(RVA = "0x39C8E8", Offset = "0x39C8E8", VA = "0x39C8E8")]
		public TargetSearchResults(NPC searcher, int nearestNPCIndex, float nearestNPCDistance, int nearestTankIndex, float nearestTankDistance, float adjustedTankDistance, TargetType tankType)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008D4")]
	[Flags]
	public enum TargetSearchFlag
	{
		[Cpp2IlInjected.Token(Token = "0x40080E5")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40080E6")]
		NPCs = 1,
		[Cpp2IlInjected.Token(Token = "0x40080E7")]
		Players = 2,
		[Cpp2IlInjected.Token(Token = "0x40080E8")]
		All = 3
	}

	[Cpp2IlInjected.Token(Token = "0x4003194")]
	public const int NPCSearchFilter_OnlyCrystal = 1;

	[Cpp2IlInjected.Token(Token = "0x4003195")]
	public const int NPCSearchFilter_NonBeeNPCs = 2;

	[Cpp2IlInjected.Token(Token = "0x4003196")]
	public const int NPCSearchFilter_DownWind = 3;

	[Cpp2IlInjected.Token(Token = "0x6002D12")]
	[Cpp2IlInjected.Address(RVA = "0x10DC7F0", Offset = "0x10DC7F0", VA = "0x10DC7F0")]
	public static TargetSearchResults SearchForTarget(Vector2 position, TargetSearchFlag flags = TargetSearchFlag.All, float maxPlayerDistance = -1f, int npcFilter = 0)
	{
		return default(TargetSearchResults);
	}

	[Cpp2IlInjected.Token(Token = "0x6002D13")]
	[Cpp2IlInjected.Address(RVA = "0x10DCEFC", Offset = "0x10DCEFC", VA = "0x10DCEFC")]
	public static TargetSearchResults SearchForTarget(NPC searcher, TargetSearchFlag flags = TargetSearchFlag.All, float maxPlayerDistance = -1f, int npcFilter = 0)
	{
		return default(TargetSearchResults);
	}

	[Cpp2IlInjected.Token(Token = "0x6002D14")]
	[Cpp2IlInjected.Address(RVA = "0x10DC82C", Offset = "0x10DC82C", VA = "0x10DC82C")]
	public static TargetSearchResults SearchForTarget(NPC searcher, Vector2 position, TargetSearchFlag flags = TargetSearchFlag.All, float maxPlayerDistance = -1f, int npcFilter = 0)
	{
		return default(TargetSearchResults);
	}

	[Cpp2IlInjected.Token(Token = "0x6002D15")]
	[Cpp2IlInjected.Address(RVA = "0x10DCFB8", Offset = "0x10DCFB8", VA = "0x10DCFB8")]
	public static void TargetClosestOldOnesInvasion(NPC searcher, bool faceTarget = true, [Optional] Vector2? checkPosition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D16")]
	[Cpp2IlInjected.Address(RVA = "0x10DD230", Offset = "0x10DD230", VA = "0x10DD230")]
	public static void TargetClosestNonBees(NPC searcher, bool faceTarget = true, [Optional] Vector2? checkPosition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D17")]
	[Cpp2IlInjected.Address(RVA = "0x10DD2F0", Offset = "0x10DD2F0", VA = "0x10DD2F0")]
	public static void TargetClosestDownwindFromNPC(NPC searcher, float distanceMaxX, bool faceTarget = true, [Optional] Vector2? checkPosition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D18")]
	[Cpp2IlInjected.Address(RVA = "0x10DD3AC", Offset = "0x10DD3AC", VA = "0x10DD3AC")]
	public static void TargetClosestCommon(NPC searcher, bool faceTarget = true, [Optional] Vector2? checkPosition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D19")]
	[Cpp2IlInjected.Address(RVA = "0x10DD3B4", Offset = "0x10DD3B4", VA = "0x10DD3B4")]
	public static void TargetClosestBetsy(NPC searcher, bool faceTarget = true, [Optional] Vector2? checkPosition)
	{
	}
}
