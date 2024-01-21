using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000337")]
public static class Minecart
{
	[Cpp2IlInjected.Token(Token = "0x200085C")]
	private enum TrackState
	{
		[Cpp2IlInjected.Token(Token = "0x4007F0C")]
		NoTrack = -1,
		[Cpp2IlInjected.Token(Token = "0x4007F0D")]
		AboveTrack,
		[Cpp2IlInjected.Token(Token = "0x4007F0E")]
		OnTrack,
		[Cpp2IlInjected.Token(Token = "0x4007F0F")]
		BelowTrack,
		[Cpp2IlInjected.Token(Token = "0x4007F10")]
		AboveFront,
		[Cpp2IlInjected.Token(Token = "0x4007F11")]
		AboveBack,
		[Cpp2IlInjected.Token(Token = "0x4007F12")]
		OnFront,
		[Cpp2IlInjected.Token(Token = "0x4007F13")]
		OnBack
	}

	[Cpp2IlInjected.Token(Token = "0x4002E53")]
	private const int TotalFrames = 36;

	[Cpp2IlInjected.Token(Token = "0x4002E54")]
	public const int LeftDownDecoration = 36;

	[Cpp2IlInjected.Token(Token = "0x4002E55")]
	public const int RightDownDecoration = 37;

	[Cpp2IlInjected.Token(Token = "0x4002E56")]
	public const int BouncyBumperDecoration = 38;

	[Cpp2IlInjected.Token(Token = "0x4002E57")]
	public const int RegularBumperDecoration = 39;

	[Cpp2IlInjected.Token(Token = "0x4002E58")]
	public const int Flag_OnTrack = 0;

	[Cpp2IlInjected.Token(Token = "0x4002E59")]
	public const int Flag_BouncyBumper = 1;

	[Cpp2IlInjected.Token(Token = "0x4002E5A")]
	public const int Flag_UsedRamp = 2;

	[Cpp2IlInjected.Token(Token = "0x4002E5B")]
	public const int Flag_HitSwitch = 3;

	[Cpp2IlInjected.Token(Token = "0x4002E5C")]
	public const int Flag_BoostLeft = 4;

	[Cpp2IlInjected.Token(Token = "0x4002E5D")]
	public const int Flag_BoostRight = 5;

	[Cpp2IlInjected.Token(Token = "0x4002E5E")]
	private const int NoConnection = -1;

	[Cpp2IlInjected.Token(Token = "0x4002E5F")]
	private const int TopConnection = 0;

	[Cpp2IlInjected.Token(Token = "0x4002E60")]
	private const int MiddleConnection = 1;

	[Cpp2IlInjected.Token(Token = "0x4002E61")]
	private const int BottomConnection = 2;

	[Cpp2IlInjected.Token(Token = "0x4002E62")]
	private const int BumperEnd = -1;

	[Cpp2IlInjected.Token(Token = "0x4002E63")]
	private const int BouncyEnd = -2;

	[Cpp2IlInjected.Token(Token = "0x4002E64")]
	private const int RampEnd = -3;

	[Cpp2IlInjected.Token(Token = "0x4002E65")]
	private const int OpenEnd = -4;

	[Cpp2IlInjected.Token(Token = "0x4002E66")]
	public const float BoosterSpeed = 4f;

	[Cpp2IlInjected.Token(Token = "0x4002E67")]
	private const int Type_Normal = 0;

	[Cpp2IlInjected.Token(Token = "0x4002E68")]
	private const int Type_Pressure = 1;

	[Cpp2IlInjected.Token(Token = "0x4002E69")]
	private const int Type_Booster = 2;

	[Cpp2IlInjected.Token(Token = "0x4002E6A")]
	private static Vector2 _trackMagnetOffset;

	[Cpp2IlInjected.Token(Token = "0x4002E6B")]
	private const float MinecartTextureWidth = 50f;

	[Cpp2IlInjected.Token(Token = "0x4002E6C")]
	private static int[] _leftSideConnection;

	[Cpp2IlInjected.Token(Token = "0x4002E6D")]
	private static int[] _rightSideConnection;

	[Cpp2IlInjected.Token(Token = "0x4002E6E")]
	private static int[] _trackType;

	[Cpp2IlInjected.Token(Token = "0x4002E6F")]
	private static bool[] _boostLeft;

	[Cpp2IlInjected.Token(Token = "0x4002E70")]
	private static Vector2[] _texturePosition;

	[Cpp2IlInjected.Token(Token = "0x4002E71")]
	private static short _firstPressureFrame;

	[Cpp2IlInjected.Token(Token = "0x4002E72")]
	private static short _firstLeftBoostFrame;

	[Cpp2IlInjected.Token(Token = "0x4002E73")]
	private static short _firstRightBoostFrame;

	[Cpp2IlInjected.Token(Token = "0x4002E74")]
	private static int[][] _trackSwitchOptions;

	[Cpp2IlInjected.Token(Token = "0x4002E75")]
	private static int[][] _tileHeight;

	[Cpp2IlInjected.Token(Token = "0x6002689")]
	[Cpp2IlInjected.Address(RVA = "0xFD45E0", Offset = "0xFD45E0", VA = "0xFD45E0")]
	public static void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600268A")]
	[Cpp2IlInjected.Address(RVA = "0xFD70EC", Offset = "0xFD70EC", VA = "0xFD70EC")]
	public static bool CanSwitchTrack(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600268B")]
	[Cpp2IlInjected.Address(RVA = "0xFD7CAC", Offset = "0xFD7CAC", VA = "0xFD7CAC")]
	public static bool IsPressurePlate(Tile tile)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600268C")]
	[Cpp2IlInjected.Address(RVA = "0xFD7D28", Offset = "0xFD7D28", VA = "0xFD7D28")]
	public static BitsByte TrackCollision(Player Player, ref Vector2 Position, ref Vector2 Velocity, ref Vector2 lastBoost, int Width, int Height, bool followDown, bool followUp, int fallStart, bool trackOnly, Mount.MountDelegatesData delegatesData)
	{
		return default(BitsByte);
	}

	[Cpp2IlInjected.Token(Token = "0x600268D")]
	[Cpp2IlInjected.Address(RVA = "0xFD970C", Offset = "0xFD970C", VA = "0xFD970C")]
	public static bool FrameTrack(int i, int j, bool pound, bool mute = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600268E")]
	[Cpp2IlInjected.Address(RVA = "0xFDA478", Offset = "0xFDA478", VA = "0xFDA478")]
	private static int GetNearbyTilesSetLookupIndex(int i, int j)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600268F")]
	[Cpp2IlInjected.Address(RVA = "0xFDA84C", Offset = "0xFDA84C", VA = "0xFDA84C")]
	public static bool GetOnTrack(int tileX, int tileY, ref Vector2 Position, int Width, int Height)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002690")]
	[Cpp2IlInjected.Address(RVA = "0xFDAC1C", Offset = "0xFDAC1C", VA = "0xFDAC1C")]
	public static bool OnTrack(Vector2 Position, int Width, int Height)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002691")]
	[Cpp2IlInjected.Address(RVA = "0xFDAE08", Offset = "0xFDAE08", VA = "0xFDAE08")]
	public static float TrackRotation(Player player, ref float rotation, Vector2 Position, int Width, int Height, bool followDown, bool followUp, Mount.MountDelegatesData delegatesData)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6002692")]
	[Cpp2IlInjected.Address(RVA = "0xFDAF94", Offset = "0xFDAF94", VA = "0xFDAF94")]
	public static void GetWheelsPositions(Player player, Vector2 Position, int Width, int Height, bool followDown, bool followUp, Mount.MountDelegatesData delegatesData, out Vector2 leftWheel, out Vector2 rightWheel)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002693")]
	[Cpp2IlInjected.Address(RVA = "0xFDB1EC", Offset = "0xFDB1EC", VA = "0xFDB1EC")]
	public static void HitTrackSwitch(Vector2 Position, int Width, int Height)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002694")]
	[Cpp2IlInjected.Address(RVA = "0xFDB35C", Offset = "0xFDB35C", VA = "0xFDB35C")]
	public static Vector2 GetMagnetPosition(Vector2 Position, int Width, int Height)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6002695")]
	[Cpp2IlInjected.Address(RVA = "0xFDB4C0", Offset = "0xFDB4C0", VA = "0xFDB4C0")]
	public static void FlipSwitchTrack(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002696")]
	[Cpp2IlInjected.Address(RVA = "0xFDB72C", Offset = "0xFDB72C", VA = "0xFDB72C")]
	public static void TrackColors(int i, int j, Tile trackTile, out int frontColor, out int backColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002697")]
	[Cpp2IlInjected.Address(RVA = "0xFDBB30", Offset = "0xFDBB30", VA = "0xFDBB30")]
	public static bool DrawLeftDecoration(int frameID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002698")]
	[Cpp2IlInjected.Address(RVA = "0xFDBBCC", Offset = "0xFDBBCC", VA = "0xFDBBCC")]
	public static bool DrawRightDecoration(int frameID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002699")]
	[Cpp2IlInjected.Address(RVA = "0xFDBC68", Offset = "0xFDBC68", VA = "0xFDBC68")]
	public static bool DrawBumper(int frameID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600269A")]
	[Cpp2IlInjected.Address(RVA = "0xFDBD4C", Offset = "0xFDBD4C", VA = "0xFDBD4C")]
	public static bool DrawBouncyBumper(int frameID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600269B")]
	[Cpp2IlInjected.Address(RVA = "0xFDBE30", Offset = "0xFDBE30", VA = "0xFDBE30")]
	public static void PlaceTrack(Tile trackCache, int style)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600269C")]
	[Cpp2IlInjected.Address(RVA = "0xFDBFA0", Offset = "0xFDBFA0", VA = "0xFDBFA0")]
	public static int GetTrackItem(Tile trackCache)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600269D")]
	[Cpp2IlInjected.Address(RVA = "0xFDC05C", Offset = "0xFDC05C", VA = "0xFDC05C")]
	public static Rectangle GetSourceRect(int frameID, int animationFrame = 0)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x600269E")]
	[Cpp2IlInjected.Address(RVA = "0xFDC1B8", Offset = "0xFDC1B8", VA = "0xFDC1B8")]
	public static bool GetAreExpectationsForSidesMet(Point tileCoords, int? expectedYOffsetForLeft, int? expectedYOffsetForRight)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600269F")]
	[Cpp2IlInjected.Address(RVA = "0xFDC3C4", Offset = "0xFDC3C4", VA = "0xFDC3C4")]
	public static void TryFittingTileOrientation(Point tileCoords, int? expectedYOffsetForLeft, int? expectedYOffsetForRight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026A0")]
	[Cpp2IlInjected.Address(RVA = "0xFDC3A4", Offset = "0xFDC3A4", VA = "0xFDC3A4")]
	private static int ConvertOffsetYToTrackConnectionValue(int offsetY)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60026A1")]
	[Cpp2IlInjected.Address(RVA = "0xFDC73C", Offset = "0xFDC73C", VA = "0xFDC73C")]
	private static int ConvertTrackConnectionValueToOffsetY(int trackConnectionValue)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60026A2")]
	[Cpp2IlInjected.Address(RVA = "0xFD958C", Offset = "0xFD958C", VA = "0xFD958C")]
	public static void WheelSparks(Action<Vector2> DustAction, Vector2 Position, int Width, int Height, int sparkCount)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026A3")]
	[Cpp2IlInjected.Address(RVA = "0xFD7C64", Offset = "0xFD7C64", VA = "0xFD7C64")]
	private static short FrontTrack(this Tile tileTrack)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60026A4")]
	[Cpp2IlInjected.Address(RVA = "0xFDA804", Offset = "0xFDA804", VA = "0xFDA804")]
	private static void FrontTrack(this Tile tileTrack, short trackID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60026A5")]
	[Cpp2IlInjected.Address(RVA = "0xFD7C88", Offset = "0xFD7C88", VA = "0xFD7C88")]
	private static short BackTrack(this Tile tileTrack)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60026A6")]
	[Cpp2IlInjected.Address(RVA = "0xFDA828", Offset = "0xFDA828", VA = "0xFDA828")]
	private static void BackTrack(this Tile tileTrack, short trackID)
	{
	}
}
