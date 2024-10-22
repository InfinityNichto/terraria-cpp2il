﻿using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameInput;
using Terraria.Localization;

namespace Terraria.GameContent
{
	[global::Cpp2ILInjected.Token(Token = "0x20007B9")]
	public class DoorOpeningHelper
	{
		[global::Cpp2ILInjected.Token(Token = "0x600406A")]
		[global::Cpp2ILInjected.Address(RVA = "0x76E404", Offset = "0x76E404", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void AllowOpeningDoorsByVelocityAloneForATime(int timeInFramesToAllow)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600406B")]
		[global::Cpp2ILInjected.Address(RVA = "0x76E40C", Offset = "0x76E40C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DoorOpeningHelper), Member = "LookForDoorsToClose", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DoorOpeningHelper), Member = "ShouldTryOpeningDoors", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DoorOpeningHelper), Member = "LookForDoorsToOpen", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		public void Update(Player player)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600406C")]
		[global::Cpp2ILInjected.Address(RVA = "0x76E5A8", Offset = "0x76E5A8", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DoorOpeningHelper), Member = "Update", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_UsingGamepad", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private bool ShouldTryOpeningDoors()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600406D")]
		[global::Cpp2ILInjected.Address(RVA = "0x76E724", Offset = "0x76E724", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void CyclePreferences()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600406E")]
		[global::Cpp2ILInjected.Address(RVA = "0x76E450", Offset = "0x76E450", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DoorOpeningHelper), Member = "Update", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Hitbox", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<DoorOpeningHelper.DoorOpenCloseTogglingInfo>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<DoorOpeningHelper.DoorOpenCloseTogglingInfo>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void LookForDoorsToClose(Player player)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600406F")]
		[global::Cpp2ILInjected.Address(RVA = "0x76E7E4", Offset = "0x76E7E4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Hitbox", ReturnType = typeof(Rectangle))]
		private DoorOpeningHelper.PlayerInfoForClosingDoors GetPlayerInfoForClosingDoor(Player player)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004070")]
		[global::Cpp2ILInjected.Address(RVA = "0x76E650", Offset = "0x76E650", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DoorOpeningHelper), Member = "Update", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DoorOpeningHelper), Member = "GetPlayerInfoForOpeningDoor", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(DoorOpeningHelper.PlayerInfoForOpeningDoors))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DoorOpeningHelper), Member = "TryAutoOpeningDoor", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(DoorOpeningHelper.PlayerInfoForOpeningDoors)
		}, ReturnType = typeof(void))]
		public void LookForDoorsToOpen(Player player)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004071")]
		[global::Cpp2ILInjected.Address(RVA = "0x76E7F0", Offset = "0x76E7F0", Length = "0x284")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DoorOpeningHelper), Member = "LookForDoorsToOpen", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToInt", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Hitbox", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Sign", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Union", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Rectangle)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "TopLeft", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "BottomRight", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private DoorOpeningHelper.PlayerInfoForOpeningDoors GetPlayerInfoForOpeningDoor(Player player)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004072")]
		[global::Cpp2ILInjected.Address(RVA = "0x76EA74", Offset = "0x76EA74", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DoorOpeningHelper), Member = "LookForDoorsToOpen", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DoorOpeningHelper), Member = "TryGetHandler", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(ref DoorOpeningHelper.DoorAutoHandler)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void TryAutoOpeningDoor(Point tileCoords, DoorOpeningHelper.PlayerInfoForOpeningDoors playerInfo)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004073")]
		[global::Cpp2ILInjected.Address(RVA = "0x76EC50", Offset = "0x76EC50", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DoorOpeningHelper), Member = "TryAutoOpeningDoor", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(DoorOpeningHelper.PlayerInfoForOpeningDoors)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "InWorld", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private bool TryGetHandler(Point tileCoords, out DoorOpeningHelper.DoorAutoHandler infoProvider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004074")]
		[global::Cpp2ILInjected.Address(RVA = "0x76ED64", Offset = "0x76ED64", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<DoorOpeningHelper.DoorOpenCloseTogglingInfo>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public DoorOpeningHelper()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6004075")]
		[global::Cpp2ILInjected.Address(RVA = "0x76EECC", Offset = "0x76EECC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static DoorOpeningHelper()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007E23")]
		public static DoorOpeningHelper.DoorAutoOpeningPreference PreferenceSettings;

		[global::Cpp2ILInjected.Token(Token = "0x4007E24")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Dictionary<int, DoorOpeningHelper.DoorAutoHandler> _handlerByTileType;

		[global::Cpp2ILInjected.Token(Token = "0x4007E25")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<DoorOpeningHelper.DoorOpenCloseTogglingInfo> _ongoingOpenDoors;

		[global::Cpp2ILInjected.Token(Token = "0x4007E26")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _timeWeCanOpenDoorsUsingVelocityAlone;

		[global::Cpp2ILInjected.Token(Token = "0x20007BA")]
		public enum DoorAutoOpeningPreference
		{
			[global::Cpp2ILInjected.Token(Token = "0x4007E28")]
			Disabled,
			[global::Cpp2ILInjected.Token(Token = "0x4007E29")]
			EnabledForGamepadOnly,
			[global::Cpp2ILInjected.Token(Token = "0x4007E2A")]
			EnabledForEverything
		}

		[global::Cpp2ILInjected.Token(Token = "0x20007BB")]
		private enum DoorCloseAttemptResult
		{
			[global::Cpp2ILInjected.Token(Token = "0x4007E2C")]
			StillInDoorArea,
			[global::Cpp2ILInjected.Token(Token = "0x4007E2D")]
			ClosedDoor,
			[global::Cpp2ILInjected.Token(Token = "0x4007E2E")]
			FailedToCloseDoor,
			[global::Cpp2ILInjected.Token(Token = "0x4007E2F")]
			DoorIsInvalidated
		}

		[global::Cpp2ILInjected.Token(Token = "0x20007BC")]
		private struct DoorOpenCloseTogglingInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x4007E30")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Point tileCoordsForToggling;

			[global::Cpp2ILInjected.Token(Token = "0x4007E31")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public DoorOpeningHelper.DoorAutoHandler handler;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20007BD")]
		private struct PlayerInfoForOpeningDoors
		{
			[global::Cpp2ILInjected.Token(Token = "0x4007E32")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Rectangle hitboxToOpenDoor;

			[global::Cpp2ILInjected.Token(Token = "0x4007E33")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int intendedOpeningDirection;

			[global::Cpp2ILInjected.Token(Token = "0x4007E34")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public int playerGravityDirection;

			[global::Cpp2ILInjected.Token(Token = "0x4007E35")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public Rectangle tileCoordSpaceForCheckingForDoors;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20007BE")]
		private struct PlayerInfoForClosingDoors
		{
			[global::Cpp2ILInjected.Token(Token = "0x4007E36")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Rectangle hitboxToNotCloseDoor;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20007BF")]
		private interface DoorAutoHandler
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004076")]
			DoorOpeningHelper.DoorOpenCloseTogglingInfo ProvideInfo(Point tileCoords);

			[global::Cpp2ILInjected.Token(Token = "0x6004077")]
			bool TryOpenDoor(DoorOpeningHelper.DoorOpenCloseTogglingInfo info, DoorOpeningHelper.PlayerInfoForOpeningDoors playerInfo);

			[global::Cpp2ILInjected.Token(Token = "0x6004078")]
			DoorOpeningHelper.DoorCloseAttemptResult TryCloseDoor(DoorOpeningHelper.DoorOpenCloseTogglingInfo info, DoorOpeningHelper.PlayerInfoForClosingDoors playerInfo);
		}

		[global::Cpp2ILInjected.Token(Token = "0x20007C0")]
		private class CommonDoorOpeningInfoProvider : DoorOpeningHelper.DoorAutoHandler
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004079")]
			[global::Cpp2ILInjected.Address(RVA = "0x76EF18", Offset = "0x76EF18", Length = "0xE8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public DoorOpeningHelper.DoorOpenCloseTogglingInfo ProvideInfo(Point tileCoords)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600407A")]
			[global::Cpp2ILInjected.Address(RVA = "0x76F000", Offset = "0x76F000", Length = "0x250")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Intersects", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "OpenDoor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(NetworkText),
				typeof(int),
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			public bool TryOpenDoor(DoorOpeningHelper.DoorOpenCloseTogglingInfo doorInfo, DoorOpeningHelper.PlayerInfoForOpeningDoors playerInfo)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600407B")]
			[global::Cpp2ILInjected.Address(RVA = "0x76F250", Offset = "0x76F250", Length = "0x2B4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Inflate", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Intersect", MemberParameters = new object[]
			{
				typeof(Rectangle),
				typeof(Rectangle)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "CloseDoor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(NetworkText),
				typeof(int),
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public DoorOpeningHelper.DoorCloseAttemptResult TryCloseDoor(DoorOpeningHelper.DoorOpenCloseTogglingInfo info, DoorOpeningHelper.PlayerInfoForClosingDoors playerInfo)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600407C")]
			[global::Cpp2ILInjected.Address(RVA = "0x76EEBC", Offset = "0x76EEBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public CommonDoorOpeningInfoProvider()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20007C1")]
		private class TallGateOpeningInfoProvider : DoorOpeningHelper.DoorAutoHandler
		{
			[global::Cpp2ILInjected.Token(Token = "0x600407D")]
			[global::Cpp2ILInjected.Address(RVA = "0x76F504", Offset = "0x76F504", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public DoorOpeningHelper.DoorOpenCloseTogglingInfo ProvideInfo(Point tileCoords)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600407E")]
			[global::Cpp2ILInjected.Address(RVA = "0x76F5F0", Offset = "0x76F5F0", Length = "0x1BC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Intersects", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "ShiftTallGate", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToInt", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(NetworkText),
				typeof(int),
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public bool TryOpenDoor(DoorOpeningHelper.DoorOpenCloseTogglingInfo doorInfo, DoorOpeningHelper.PlayerInfoForOpeningDoors playerInfo)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600407F")]
			[global::Cpp2ILInjected.Address(RVA = "0x76F7AC", Offset = "0x76F7AC", Length = "0x290")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Inflate", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Intersect", MemberParameters = new object[]
			{
				typeof(Rectangle),
				typeof(Rectangle)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "ShiftTallGate", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(NetworkText),
				typeof(int),
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToInt", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			public DoorOpeningHelper.DoorCloseAttemptResult TryCloseDoor(DoorOpeningHelper.DoorOpenCloseTogglingInfo info, DoorOpeningHelper.PlayerInfoForClosingDoors playerInfo)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004080")]
			[global::Cpp2ILInjected.Address(RVA = "0x76EEC4", Offset = "0x76EEC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public TallGateOpeningInfoProvider()
			{
				throw null;
			}
		}
	}
}
