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
	[global::Cpp2ILInjected.Token(Token = "0x2000680")]
	public struct TileReachCheckSettings
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x4007891")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int TileRangeMultiplier;

		[global::Cpp2ILInjected.Token(Token = "0x4007892")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public int? TileReachLimit;

		[global::Cpp2ILInjected.Token(Token = "0x4007893")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public int? OverrideXReach;

		[global::Cpp2ILInjected.Token(Token = "0x4007894")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int? OverrideYReach;
	}
}
