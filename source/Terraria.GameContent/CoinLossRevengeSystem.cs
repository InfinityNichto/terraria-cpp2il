using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000540")]
public class CoinLossRevengeSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000970")]
	public class RevengeMarker
	{
		[Cpp2IlInjected.Token(Token = "0x4008BD7")]
		private static int _uniqueIDCounter;

		[Cpp2IlInjected.Token(Token = "0x4008BD8")]
		private static readonly int _expirationCompCopper;

		[Cpp2IlInjected.Token(Token = "0x4008BD9")]
		private static readonly int _expirationCompSilver;

		[Cpp2IlInjected.Token(Token = "0x4008BDA")]
		private static readonly int _expirationCompGold;

		[Cpp2IlInjected.Token(Token = "0x4008BDB")]
		private static readonly int _expirationCompPlat;

		[Cpp2IlInjected.Token(Token = "0x4008BDC")]
		private const int ONE_MINUTE = 3600;

		[Cpp2IlInjected.Token(Token = "0x4008BDD")]
		private const int ENEMY_BOX_WIDTH = 2160;

		[Cpp2IlInjected.Token(Token = "0x4008BDE")]
		private const int ENEMY_BOX_HEIGHT = 1440;

		[Cpp2IlInjected.Token(Token = "0x4008BDF")]
		public static readonly Vector2 EnemyBoxSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008BE0")]
		private readonly Vector2 _location;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008BE1")]
		private readonly Rectangle _hitbox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4008BE2")]
		private readonly int _npcNetID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4008BE3")]
		private readonly float _npcHPPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4008BE4")]
		private readonly float _baseValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4008BE5")]
		private readonly int _coinsValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4008BE6")]
		private readonly int _npcTypeAgainstDiscouragement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4008BE7")]
		private readonly int _npcAIStyleAgainstDiscouragement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4008BE8")]
		private readonly int _expirationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4008BE9")]
		private readonly bool _spawnedFromStatue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4008BEA")]
		private readonly int _uniqueID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4008BEB")]
		private bool _forceExpire;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x4008BEC")]
		private bool _attemptedRespawn;

		[Cpp2IlInjected.Token(Token = "0x170008BF")]
		public bool RespawnAttemptLocked
		{
			[Cpp2IlInjected.Token(Token = "0x6004DBD")]
			[Cpp2IlInjected.Address(RVA = "0x1080FB8", Offset = "0x1080FB8", VA = "0x1080FB8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008C0")]
		public int UniqueID
		{
			[Cpp2IlInjected.Token(Token = "0x6004DC8")]
			[Cpp2IlInjected.Address(RVA = "0x10814DC", Offset = "0x10814DC", VA = "0x10814DC")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004DBC")]
		[Cpp2IlInjected.Address(RVA = "0x107FD14", Offset = "0x107FD14", VA = "0x107FD14")]
		public void SetToExpire()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004DBE")]
		[Cpp2IlInjected.Address(RVA = "0x1080FC0", Offset = "0x1080FC0", VA = "0x1080FC0")]
		public void SetRespawnAttemptLock(bool state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004DBF")]
		[Cpp2IlInjected.Address(RVA = "0x107DF24", Offset = "0x107DF24", VA = "0x107DF24")]
		public RevengeMarker(Vector2 coords, int npcNetId, float npcHPPercent, int npcType, int npcAiStyle, int coinValue, float baseValue, bool spawnedFromStatue, int gameTime, int uniqueID = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004DC0")]
		[Cpp2IlInjected.Address(RVA = "0x1080CC8", Offset = "0x1080CC8", VA = "0x1080CC8")]
		public bool IsInvalid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DC1")]
		[Cpp2IlInjected.Address(RVA = "0x1080BF8", Offset = "0x1080BF8", VA = "0x1080BF8")]
		public bool IsExpired(int gameTime)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DC2")]
		[Cpp2IlInjected.Address(RVA = "0x1080FC8", Offset = "0x1080FC8", VA = "0x1080FC8")]
		private int CalculateExpirationTime(int gameCacheTime, int coinValue)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DC3")]
		[Cpp2IlInjected.Address(RVA = "0x107FA48", Offset = "0x107FA48", VA = "0x107FA48")]
		public bool Intersects(Rectangle rectInner, Rectangle rectOuter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DC4")]
		[Cpp2IlInjected.Address(RVA = "0x107FD20", Offset = "0x107FD20", VA = "0x107FD20")]
		public void SpawnEnemy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004DC5")]
		[Cpp2IlInjected.Address(RVA = "0x107FA90", Offset = "0x107FA90", VA = "0x107FA90")]
		public bool WouldNPCBeDiscouraged(Player playerTarget)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DC6")]
		[Cpp2IlInjected.Address(RVA = "0x108037C", Offset = "0x108037C", VA = "0x108037C")]
		public bool DrawMapIcon(SpriteBatch spriteBatch, Vector2 mapTopLeft, Vector2 mapX2Y2AndOff, Rectangle? mapRect, float mapScale, float drawScale, int gameTime)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DC7")]
		[Cpp2IlInjected.Address(RVA = "0x10812DC", Offset = "0x10812DC", VA = "0x10812DC")]
		public void UseMouseOver(SpriteBatch spriteBatch, ref string mouseTextString, float drawScale = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004DC9")]
		[Cpp2IlInjected.Address(RVA = "0x10814E4", Offset = "0x10814E4", VA = "0x10814E4")]
		public void WriteSelfTo(BinaryWriter writer)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40068A6")]
	public static bool DisplayCaching;

	[Cpp2IlInjected.Token(Token = "0x40068A7")]
	public static int MinimumCoinsForCaching;

	[Cpp2IlInjected.Token(Token = "0x40068A8")]
	private const int PLAYER_BOX_WIDTH_INNER = 1968;

	[Cpp2IlInjected.Token(Token = "0x40068A9")]
	private const int PLAYER_BOX_HEIGHT_INNER = 1200;

	[Cpp2IlInjected.Token(Token = "0x40068AA")]
	private const int PLAYER_BOX_WIDTH_OUTER = 2608;

	[Cpp2IlInjected.Token(Token = "0x40068AB")]
	private const int PLAYER_BOX_HEIGHT_OUTER = 1840;

	[Cpp2IlInjected.Token(Token = "0x40068AC")]
	private static readonly Vector2 _playerBoxSizeInner;

	[Cpp2IlInjected.Token(Token = "0x40068AD")]
	private static readonly Vector2 _playerBoxSizeOuter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40068AE")]
	private List<RevengeMarker> _markers;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40068AF")]
	private readonly object _markersLock;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40068B0")]
	private int _gameTime;

	[Cpp2IlInjected.Token(Token = "0x6003978")]
	[Cpp2IlInjected.Address(RVA = "0x107DD7C", Offset = "0x107DD7C", VA = "0x107DD7C")]
	public void AddMarkerFromReader(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003979")]
	[Cpp2IlInjected.Address(RVA = "0x107E0D4", Offset = "0x107E0D4", VA = "0x107E0D4")]
	private void AddMarker(RevengeMarker marker)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600397A")]
	[Cpp2IlInjected.Address(RVA = "0x107E1A8", Offset = "0x107E1A8", VA = "0x107E1A8")]
	public void DestroyMarker(int markerUniqueID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600397B")]
	[Cpp2IlInjected.Address(RVA = "0x107E2F4", Offset = "0x107E2F4", VA = "0x107E2F4")]
	public CoinLossRevengeSystem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600397C")]
	[Cpp2IlInjected.Address(RVA = "0x107E39C", Offset = "0x107E39C", VA = "0x107E39C")]
	public void CacheEnemy(NPC npc)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600397D")]
	[Cpp2IlInjected.Address(RVA = "0x107E7E4", Offset = "0x107E7E4", VA = "0x107E7E4")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600397E")]
	[Cpp2IlInjected.Address(RVA = "0x107E8B8", Offset = "0x107E8B8", VA = "0x107E8B8")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600397F")]
	[Cpp2IlInjected.Address(RVA = "0x107F2E0", Offset = "0x107F2E0", VA = "0x107F2E0")]
	public void CheckRespawns()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003980")]
	[Cpp2IlInjected.Address(RVA = "0x107E978", Offset = "0x107E978", VA = "0x107E978")]
	private void RemoveExpiredOrInvalidMarkers()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003981")]
	[Cpp2IlInjected.Address(RVA = "0x1080184", Offset = "0x1080184", VA = "0x1080184")]
	public RevengeMarker DrawMapIcons(SpriteBatch spriteBatch, Vector2 mapTopLeft, Vector2 mapX2Y2AndOff, Rectangle? mapRect, float mapScale, float drawScale, ref string unused)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003982")]
	[Cpp2IlInjected.Address(RVA = "0x10808F0", Offset = "0x10808F0", VA = "0x10808F0")]
	public void SendAllMarkersToPlayer(int plr)
	{
	}
}
