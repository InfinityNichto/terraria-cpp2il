using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x200054A")]
public class DoorOpeningHelper
{
	[Cpp2IlInjected.Token(Token = "0x2000974")]
	public enum DoorAutoOpeningPreference
	{
		[Cpp2IlInjected.Token(Token = "0x4008BF4")]
		Disabled,
		[Cpp2IlInjected.Token(Token = "0x4008BF5")]
		EnabledForGamepadOnly,
		[Cpp2IlInjected.Token(Token = "0x4008BF6")]
		EnabledForEverything
	}

	[Cpp2IlInjected.Token(Token = "0x2000975")]
	private enum DoorCloseAttemptResult
	{
		[Cpp2IlInjected.Token(Token = "0x4008BF8")]
		StillInDoorArea,
		[Cpp2IlInjected.Token(Token = "0x4008BF9")]
		ClosedDoor,
		[Cpp2IlInjected.Token(Token = "0x4008BFA")]
		FailedToCloseDoor,
		[Cpp2IlInjected.Token(Token = "0x4008BFB")]
		DoorIsInvalidated
	}

	[Cpp2IlInjected.Token(Token = "0x2000976")]
	private struct DoorOpenCloseTogglingInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008BFC")]
		public Point tileCoordsForToggling;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008BFD")]
		public DoorAutoHandler handler;
	}

	[Cpp2IlInjected.Token(Token = "0x2000977")]
	private struct PlayerInfoForOpeningDoors
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008BFE")]
		public Rectangle hitboxToOpenDoor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008BFF")]
		public int intendedOpeningDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008C00")]
		public int playerGravityDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008C01")]
		public Rectangle tileCoordSpaceForCheckingForDoors;
	}

	[Cpp2IlInjected.Token(Token = "0x2000978")]
	private struct PlayerInfoForClosingDoors
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008C02")]
		public Rectangle hitboxToNotCloseDoor;
	}

	[Cpp2IlInjected.Token(Token = "0x2000979")]
	private interface DoorAutoHandler
	{
		[Cpp2IlInjected.Token(Token = "0x6004DD3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		DoorOpenCloseTogglingInfo ProvideInfo(Point tileCoords);

		[Cpp2IlInjected.Token(Token = "0x6004DD4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool TryOpenDoor(DoorOpenCloseTogglingInfo info, PlayerInfoForOpeningDoors playerInfo);

		[Cpp2IlInjected.Token(Token = "0x6004DD5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		DoorCloseAttemptResult TryCloseDoor(DoorOpenCloseTogglingInfo info, PlayerInfoForClosingDoors playerInfo);
	}

	[Cpp2IlInjected.Token(Token = "0x200097A")]
	private class CommonDoorOpeningInfoProvider : DoorAutoHandler
	{
		[Cpp2IlInjected.Token(Token = "0x6004DD6")]
		[Cpp2IlInjected.Address(RVA = "0xD78F50", Offset = "0xD78F50", VA = "0xD78F50", Slot = "4")]
		public DoorOpenCloseTogglingInfo ProvideInfo(Point tileCoords)
		{
			return default(DoorOpenCloseTogglingInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DD7")]
		[Cpp2IlInjected.Address(RVA = "0xD79044", Offset = "0xD79044", VA = "0xD79044", Slot = "5")]
		public bool TryOpenDoor(DoorOpenCloseTogglingInfo doorInfo, PlayerInfoForOpeningDoors playerInfo)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DD8")]
		[Cpp2IlInjected.Address(RVA = "0xD79350", Offset = "0xD79350", VA = "0xD79350", Slot = "6")]
		public DoorCloseAttemptResult TryCloseDoor(DoorOpenCloseTogglingInfo info, PlayerInfoForClosingDoors playerInfo)
		{
			return default(DoorCloseAttemptResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DD9")]
		[Cpp2IlInjected.Address(RVA = "0xD78EE4", Offset = "0xD78EE4", VA = "0xD78EE4")]
		public CommonDoorOpeningInfoProvider()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200097B")]
	private class TallGateOpeningInfoProvider : DoorAutoHandler
	{
		[Cpp2IlInjected.Token(Token = "0x6004DDA")]
		[Cpp2IlInjected.Address(RVA = "0xD79680", Offset = "0xD79680", VA = "0xD79680", Slot = "4")]
		public DoorOpenCloseTogglingInfo ProvideInfo(Point tileCoords)
		{
			return default(DoorOpenCloseTogglingInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DDB")]
		[Cpp2IlInjected.Address(RVA = "0xD79774", Offset = "0xD79774", VA = "0xD79774", Slot = "5")]
		public bool TryOpenDoor(DoorOpenCloseTogglingInfo doorInfo, PlayerInfoForOpeningDoors playerInfo)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DDC")]
		[Cpp2IlInjected.Address(RVA = "0xD799D0", Offset = "0xD799D0", VA = "0xD799D0", Slot = "6")]
		public DoorCloseAttemptResult TryCloseDoor(DoorOpenCloseTogglingInfo info, PlayerInfoForClosingDoors playerInfo)
		{
			return default(DoorCloseAttemptResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DDD")]
		[Cpp2IlInjected.Address(RVA = "0xD78EEC", Offset = "0xD78EEC", VA = "0xD78EEC")]
		public TallGateOpeningInfoProvider()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40068D3")]
	public static DoorAutoOpeningPreference PreferenceSettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40068D4")]
	private Dictionary<int, DoorAutoHandler> _handlerByTileType;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40068D5")]
	private List<DoorOpenCloseTogglingInfo> _ongoingOpenDoors;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40068D6")]
	private int _timeWeCanOpenDoorsUsingVelocityAlone;

	[Cpp2IlInjected.Token(Token = "0x60039DF")]
	[Cpp2IlInjected.Address(RVA = "0xD781D0", Offset = "0xD781D0", VA = "0xD781D0")]
	public void AllowOpeningDoorsByVelocityAloneForATime(int timeInFramesToAllow)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039E0")]
	[Cpp2IlInjected.Address(RVA = "0xD781D8", Offset = "0xD781D8", VA = "0xD781D8")]
	public void Update(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039E1")]
	[Cpp2IlInjected.Address(RVA = "0xD783B8", Offset = "0xD783B8", VA = "0xD783B8")]
	private bool ShouldTryOpeningDoors()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60039E2")]
	[Cpp2IlInjected.Address(RVA = "0xD78598", Offset = "0xD78598", VA = "0xD78598")]
	public static void CyclePreferences()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039E3")]
	[Cpp2IlInjected.Address(RVA = "0xD78218", Offset = "0xD78218", VA = "0xD78218")]
	public void LookForDoorsToClose(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039E4")]
	[Cpp2IlInjected.Address(RVA = "0xD786AC", Offset = "0xD786AC", VA = "0xD786AC")]
	private PlayerInfoForClosingDoors GetPlayerInfoForClosingDoor(Player player)
	{
		return default(PlayerInfoForClosingDoors);
	}

	[Cpp2IlInjected.Token(Token = "0x60039E5")]
	[Cpp2IlInjected.Address(RVA = "0xD7847C", Offset = "0xD7847C", VA = "0xD7847C")]
	public void LookForDoorsToOpen(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039E6")]
	[Cpp2IlInjected.Address(RVA = "0xD786E4", Offset = "0xD786E4", VA = "0xD786E4")]
	private PlayerInfoForOpeningDoors GetPlayerInfoForOpeningDoor(Player player)
	{
		return default(PlayerInfoForOpeningDoors);
	}

	[Cpp2IlInjected.Token(Token = "0x60039E7")]
	[Cpp2IlInjected.Address(RVA = "0xD78A60", Offset = "0xD78A60", VA = "0xD78A60")]
	private void TryAutoOpeningDoor(Point tileCoords, PlayerInfoForOpeningDoors playerInfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039E8")]
	[Cpp2IlInjected.Address(RVA = "0xD78C88", Offset = "0xD78C88", VA = "0xD78C88")]
	private bool TryGetHandler(Point tileCoords, out DoorAutoHandler infoProvider)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60039E9")]
	[Cpp2IlInjected.Address(RVA = "0xD78DB8", Offset = "0xD78DB8", VA = "0xD78DB8")]
	public DoorOpeningHelper()
	{
	}
}
