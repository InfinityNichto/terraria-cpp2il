using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent;
using Terraria.GameContent.ObjectInteractions;
using Terraria.GameContent.Tile_Entities;
using Terraria.Graphics.Renderers;

namespace Terraria.DataStructures
{
	// Token: 0x0200047D RID: 1149
	[global::Cpp2ILInjected.Token(Token = "0x2000680")]
	public struct TileReachCheckSettings
	{
		// Token: 0x06003264 RID: 12900 RVA: 0x0002B043 File Offset: 0x00029243
		[global::Cpp2ILInjected.Token(Token = "0x600378D")]
		[global::Cpp2ILInjected.Address(RVA = "0x14204E8", Offset = "0x14204E8", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "InInteractionRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TileReachCheckSettings)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "IsInTileInteractionRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TileReachCheckSettings)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "IsTileTypeInInteractionRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(TileReachCheckSettings)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_tileRangeX", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_tileRangeY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void GetRanges(Player player, out int x, out int y)
		{
			throw null;
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06003265 RID: 12901 RVA: 0x0002B046 File Offset: 0x00029246
		[global::Cpp2ILInjected.Token(Token = "0x170006B6")]
		public static TileReachCheckSettings Simple
		{
			[global::Cpp2ILInjected.Token(Token = "0x600378E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1420608", Offset = "0x1420608", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "IsProjectileInteractibleAndInInteractionRange", MemberParameters = new object[]
			{
				typeof(Projectile),
				typeof(ref Vector2)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "LookForTileInteractions", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TryInteractingWithMinecartTrackInNearbyArea", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReturnGatePlayerRenderer), Member = "OverReturnGateInWorld", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEDisplayDoll), Member = "OnPlayerUpdate", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEHatRack), Member = "OnPlayerUpdate", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AHoverInteractionChecker), Member = "AttemptInteraction", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(Rectangle)
			}, ReturnType = typeof(AHoverInteractionChecker.HoverStatus))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06003266 RID: 12902 RVA: 0x0002B049 File Offset: 0x00029249
		[global::Cpp2ILInjected.Token(Token = "0x170006B7")]
		public static TileReachCheckSettings Pylons
		{
			[global::Cpp2ILInjected.Token(Token = "0x600378F")]
			[global::Cpp2ILInjected.Address(RVA = "0x142067C", Offset = "0x142067C", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeleportPylonsSystem), Member = "HandleTeleportRequest", MemberParameters = new object[]
			{
				typeof(TeleportPylonInfo),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06003267 RID: 12903 RVA: 0x0002B04C File Offset: 0x0002924C
		[global::Cpp2ILInjected.Token(Token = "0x170006B8")]
		public static TileReachCheckSettings QuickStackToNearbyChests
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003790")]
			[global::Cpp2ILInjected.Address(RVA = "0x1420704", Offset = "0x1420704", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetNearbyContainerProjectilesList", ReturnType = typeof(List<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04006495 RID: 25749
		[global::Cpp2ILInjected.Token(Token = "0x4007891")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int TileRangeMultiplier;

		// Token: 0x04006496 RID: 25750
		[global::Cpp2ILInjected.Token(Token = "0x4007892")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public int? TileReachLimit;

		// Token: 0x04006497 RID: 25751
		[global::Cpp2ILInjected.Token(Token = "0x4007893")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public int? OverrideXReach;

		// Token: 0x04006498 RID: 25752
		[global::Cpp2ILInjected.Token(Token = "0x4007894")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int? OverrideYReach;
	}
}
