using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameInput;
using Terraria.Localization;

namespace Terraria.GameContent
{
	// Token: 0x02000547 RID: 1351
	[global::Cpp2ILInjected.Token(Token = "0x20007B9")]
	public class DoorOpeningHelper
	{
		// Token: 0x060039A3 RID: 14755 RVA: 0x0002C4B9 File Offset: 0x0002A6B9
		[global::Cpp2ILInjected.Token(Token = "0x600406A")]
		[global::Cpp2ILInjected.Address(RVA = "0x76E404", Offset = "0x76E404", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void AllowOpeningDoorsByVelocityAloneForATime(int timeInFramesToAllow)
		{
			throw null;
		}

		// Token: 0x060039A4 RID: 14756 RVA: 0x0002C4BC File Offset: 0x0002A6BC
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

		// Token: 0x060039A5 RID: 14757 RVA: 0x0002C4BF File Offset: 0x0002A6BF
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

		// Token: 0x060039A6 RID: 14758 RVA: 0x0002C4C2 File Offset: 0x0002A6C2
		[global::Cpp2ILInjected.Token(Token = "0x600406D")]
		[global::Cpp2ILInjected.Address(RVA = "0x76E724", Offset = "0x76E724", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void CyclePreferences()
		{
			throw null;
		}

		// Token: 0x060039A7 RID: 14759 RVA: 0x0002C4C5 File Offset: 0x0002A6C5
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

		// Token: 0x060039A8 RID: 14760 RVA: 0x0002C4C8 File Offset: 0x0002A6C8
		[global::Cpp2ILInjected.Token(Token = "0x600406F")]
		[global::Cpp2ILInjected.Address(RVA = "0x76E7E4", Offset = "0x76E7E4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Hitbox", ReturnType = typeof(Rectangle))]
		private DoorOpeningHelper.PlayerInfoForClosingDoors GetPlayerInfoForClosingDoor(Player player)
		{
			throw null;
		}

		// Token: 0x060039A9 RID: 14761 RVA: 0x0002C4CB File Offset: 0x0002A6CB
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

		// Token: 0x060039AA RID: 14762 RVA: 0x0002C4CE File Offset: 0x0002A6CE
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

		// Token: 0x060039AB RID: 14763 RVA: 0x0002C4D1 File Offset: 0x0002A6D1
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

		// Token: 0x060039AC RID: 14764 RVA: 0x0002C4D4 File Offset: 0x0002A6D4
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

		// Token: 0x060039AD RID: 14765 RVA: 0x0002C4D7 File Offset: 0x0002A6D7
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

		// Token: 0x060039AE RID: 14766 RVA: 0x0002C4DA File Offset: 0x0002A6DA
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6004075")]
		[global::Cpp2ILInjected.Address(RVA = "0x76EECC", Offset = "0x76EECC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static DoorOpeningHelper()
		{
			throw null;
		}

		// Token: 0x040068D2 RID: 26834
		[global::Cpp2ILInjected.Token(Token = "0x4007E23")]
		public static DoorOpeningHelper.DoorAutoOpeningPreference PreferenceSettings;

		// Token: 0x040068D3 RID: 26835
		[global::Cpp2ILInjected.Token(Token = "0x4007E24")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Dictionary<int, DoorOpeningHelper.DoorAutoHandler> _handlerByTileType;

		// Token: 0x040068D4 RID: 26836
		[global::Cpp2ILInjected.Token(Token = "0x4007E25")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<DoorOpeningHelper.DoorOpenCloseTogglingInfo> _ongoingOpenDoors;

		// Token: 0x040068D5 RID: 26837
		[global::Cpp2ILInjected.Token(Token = "0x4007E26")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _timeWeCanOpenDoorsUsingVelocityAlone;

		// Token: 0x0200097D RID: 2429
		[global::Cpp2ILInjected.Token(Token = "0x20007BA")]
		public enum DoorAutoOpeningPreference
		{
			// Token: 0x04008C07 RID: 35847
			[global::Cpp2ILInjected.Token(Token = "0x4007E28")]
			Disabled,
			// Token: 0x04008C08 RID: 35848
			[global::Cpp2ILInjected.Token(Token = "0x4007E29")]
			EnabledForGamepadOnly,
			// Token: 0x04008C09 RID: 35849
			[global::Cpp2ILInjected.Token(Token = "0x4007E2A")]
			EnabledForEverything
		}

		// Token: 0x0200097E RID: 2430
		[global::Cpp2ILInjected.Token(Token = "0x20007BB")]
		private enum DoorCloseAttemptResult
		{
			// Token: 0x04008C0B RID: 35851
			[global::Cpp2ILInjected.Token(Token = "0x4007E2C")]
			StillInDoorArea,
			// Token: 0x04008C0C RID: 35852
			[global::Cpp2ILInjected.Token(Token = "0x4007E2D")]
			ClosedDoor,
			// Token: 0x04008C0D RID: 35853
			[global::Cpp2ILInjected.Token(Token = "0x4007E2E")]
			FailedToCloseDoor,
			// Token: 0x04008C0E RID: 35854
			[global::Cpp2ILInjected.Token(Token = "0x4007E2F")]
			DoorIsInvalidated
		}

		// Token: 0x0200097F RID: 2431
		[global::Cpp2ILInjected.Token(Token = "0x20007BC")]
		private struct DoorOpenCloseTogglingInfo
		{
			// Token: 0x04008C0F RID: 35855
			[global::Cpp2ILInjected.Token(Token = "0x4007E30")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Point tileCoordsForToggling;

			// Token: 0x04008C10 RID: 35856
			[global::Cpp2ILInjected.Token(Token = "0x4007E31")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public DoorOpeningHelper.DoorAutoHandler handler;
		}

		// Token: 0x02000980 RID: 2432
		[global::Cpp2ILInjected.Token(Token = "0x20007BD")]
		private struct PlayerInfoForOpeningDoors
		{
			// Token: 0x04008C11 RID: 35857
			[global::Cpp2ILInjected.Token(Token = "0x4007E32")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Rectangle hitboxToOpenDoor;

			// Token: 0x04008C12 RID: 35858
			[global::Cpp2ILInjected.Token(Token = "0x4007E33")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int intendedOpeningDirection;

			// Token: 0x04008C13 RID: 35859
			[global::Cpp2ILInjected.Token(Token = "0x4007E34")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public int playerGravityDirection;

			// Token: 0x04008C14 RID: 35860
			[global::Cpp2ILInjected.Token(Token = "0x4007E35")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public Rectangle tileCoordSpaceForCheckingForDoors;
		}

		// Token: 0x02000981 RID: 2433
		[global::Cpp2ILInjected.Token(Token = "0x20007BE")]
		private struct PlayerInfoForClosingDoors
		{
			// Token: 0x04008C15 RID: 35861
			[global::Cpp2ILInjected.Token(Token = "0x4007E36")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Rectangle hitboxToNotCloseDoor;
		}

		// Token: 0x02000982 RID: 2434
		[global::Cpp2ILInjected.Token(Token = "0x20007BF")]
		private interface DoorAutoHandler
		{
			// Token: 0x06004D9C RID: 19868
			[global::Cpp2ILInjected.Token(Token = "0x6004076")]
			DoorOpeningHelper.DoorOpenCloseTogglingInfo ProvideInfo(Point tileCoords);

			// Token: 0x06004D9D RID: 19869
			[global::Cpp2ILInjected.Token(Token = "0x6004077")]
			bool TryOpenDoor(DoorOpeningHelper.DoorOpenCloseTogglingInfo info, DoorOpeningHelper.PlayerInfoForOpeningDoors playerInfo);

			// Token: 0x06004D9E RID: 19870
			[global::Cpp2ILInjected.Token(Token = "0x6004078")]
			DoorOpeningHelper.DoorCloseAttemptResult TryCloseDoor(DoorOpeningHelper.DoorOpenCloseTogglingInfo info, DoorOpeningHelper.PlayerInfoForClosingDoors playerInfo);
		}

		// Token: 0x02000983 RID: 2435
		[global::Cpp2ILInjected.Token(Token = "0x20007C0")]
		private class CommonDoorOpeningInfoProvider : DoorOpeningHelper.DoorAutoHandler
		{
			// Token: 0x06004D9F RID: 19871 RVA: 0x0002FB25 File Offset: 0x0002DD25
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

			// Token: 0x06004DA0 RID: 19872 RVA: 0x0002FB28 File Offset: 0x0002DD28
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

			// Token: 0x06004DA1 RID: 19873 RVA: 0x0002FB2B File Offset: 0x0002DD2B
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

			// Token: 0x06004DA2 RID: 19874 RVA: 0x0002FB2E File Offset: 0x0002DD2E
			[global::Cpp2ILInjected.Token(Token = "0x600407C")]
			[global::Cpp2ILInjected.Address(RVA = "0x76EEBC", Offset = "0x76EEBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public CommonDoorOpeningInfoProvider()
			{
				throw null;
			}
		}

		// Token: 0x02000984 RID: 2436
		[global::Cpp2ILInjected.Token(Token = "0x20007C1")]
		private class TallGateOpeningInfoProvider : DoorOpeningHelper.DoorAutoHandler
		{
			// Token: 0x06004DA3 RID: 19875 RVA: 0x0002FB31 File Offset: 0x0002DD31
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

			// Token: 0x06004DA4 RID: 19876 RVA: 0x0002FB34 File Offset: 0x0002DD34
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

			// Token: 0x06004DA5 RID: 19877 RVA: 0x0002FB37 File Offset: 0x0002DD37
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

			// Token: 0x06004DA6 RID: 19878 RVA: 0x0002FB3A File Offset: 0x0002DD3A
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
