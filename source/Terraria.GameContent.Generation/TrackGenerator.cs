using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Generation;

[Cpp2IlInjected.Token(Token = "0x20005F1")]
public class TrackGenerator
{
	[Cpp2IlInjected.Token(Token = "0x20009EF")]
	private enum TrackPlacementState
	{
		[Cpp2IlInjected.Token(Token = "0x4008CDC")]
		Available,
		[Cpp2IlInjected.Token(Token = "0x4008CDD")]
		Obstructed,
		[Cpp2IlInjected.Token(Token = "0x4008CDE")]
		Invalid
	}

	[Cpp2IlInjected.Token(Token = "0x20009F0")]
	private enum TrackSlope : sbyte
	{
		[Cpp2IlInjected.Token(Token = "0x4008CE0")]
		Up = -1,
		[Cpp2IlInjected.Token(Token = "0x4008CE1")]
		Straight,
		[Cpp2IlInjected.Token(Token = "0x4008CE2")]
		Down
	}

	[Cpp2IlInjected.Token(Token = "0x20009F1")]
	private enum TrackMode : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4008CE4")]
		Normal,
		[Cpp2IlInjected.Token(Token = "0x4008CE5")]
		Tunnel
	}

	[Cpp2IlInjected.Token(Token = "0x20009F2")]
	[Cpp2IlInjected.Attribute(Name = "DebuggerDisplayAttribute", RVA = "0x385BC0", Offset = "0x385BC0")]
	private struct TrackHistory
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008CE6")]
		public short X;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4008CE7")]
		public short Y;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008CE8")]
		public TrackSlope Slope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4008CE9")]
		public TrackMode Mode;

		[Cpp2IlInjected.Token(Token = "0x6004F7D")]
		[Cpp2IlInjected.Address(RVA = "0x39A17C", Offset = "0x39A17C", VA = "0x39A17C")]
		public TrackHistory(int x, int y, TrackSlope slope)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4006BE0")]
	private static readonly ushort[] InvalidWalls;

	[Cpp2IlInjected.Token(Token = "0x4006BE1")]
	private static readonly ushort[] InvalidTiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006BE2")]
	private readonly TrackHistory[] _history;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006BE3")]
	private readonly TrackHistory[] _rewriteHistory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006BE4")]
	private int _xDirection;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006BE5")]
	private int _length;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006BE6")]
	private int playerHeight;

	[Cpp2IlInjected.Token(Token = "0x6003D7C")]
	[Cpp2IlInjected.Address(RVA = "0xE68E1C", Offset = "0xE68E1C", VA = "0xE68E1C")]
	public bool Place(Point origin, int minLength, int maxLength)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003D7D")]
	[Cpp2IlInjected.Address(RVA = "0xE69238", Offset = "0xE69238", VA = "0xE69238")]
	private void PlacePath()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D7E")]
	[Cpp2IlInjected.Address(RVA = "0xE68FD4", Offset = "0xE68FD4", VA = "0xE68FD4")]
	private void CreateTrackStart(Point origin)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D7F")]
	[Cpp2IlInjected.Address(RVA = "0xE690EC", Offset = "0xE690EC", VA = "0xE690EC")]
	private bool FindPath(int minLength, int maxLength)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003D80")]
	[Cpp2IlInjected.Address(RVA = "0xE69C54", Offset = "0xE69C54", VA = "0xE69C54")]
	private TrackPlacementState CreateTunnel()
	{
		return default(TrackPlacementState);
	}

	[Cpp2IlInjected.Token(Token = "0x6003D81")]
	[Cpp2IlInjected.Address(RVA = "0xE69988", Offset = "0xE69988", VA = "0xE69988")]
	private void AppendToHistory(TrackSlope slope, TrackMode mode = TrackMode.Normal)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D82")]
	[Cpp2IlInjected.Address(RVA = "0xE699E8", Offset = "0xE699E8", VA = "0xE699E8")]
	private TrackPlacementState TryRewriteHistoryToAvoidTiles()
	{
		return default(TrackPlacementState);
	}

	[Cpp2IlInjected.Token(Token = "0x6003D83")]
	[Cpp2IlInjected.Address(RVA = "0xE6A2EC", Offset = "0xE6A2EC", VA = "0xE6A2EC")]
	private void RewriteSlopeDirection(int index, TrackSlope slope)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D84")]
	[Cpp2IlInjected.Address(RVA = "0xE6A00C", Offset = "0xE6A00C", VA = "0xE6A00C")]
	private TrackPlacementState GetHistorySegmentPlacementState(int startIndex, int length)
	{
		return default(TrackPlacementState);
	}

	[Cpp2IlInjected.Token(Token = "0x6003D85")]
	[Cpp2IlInjected.Address(RVA = "0xE69E60", Offset = "0xE69E60", VA = "0xE69E60")]
	private void SmoothTrack()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D86")]
	[Cpp2IlInjected.Address(RVA = "0xE6A2C8", Offset = "0xE6A2C8", VA = "0xE6A2C8")]
	private static bool CanSlopesTouch(TrackSlope leftSlope, TrackSlope rightSlope)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003D87")]
	[Cpp2IlInjected.Address(RVA = "0xE68EEC", Offset = "0xE68EEC", VA = "0xE68EEC")]
	private static bool FindSuitableOrigin(ref Point origin)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003D88")]
	[Cpp2IlInjected.Address(RVA = "0xE6A108", Offset = "0xE6A108", VA = "0xE6A108")]
	private static TrackPlacementState CalculateStateForLocation(int x, int y)
	{
		return default(TrackPlacementState);
	}

	[Cpp2IlInjected.Token(Token = "0x6003D89")]
	[Cpp2IlInjected.Address(RVA = "0xE6AABC", Offset = "0xE6AABC", VA = "0xE6AABC")]
	private static bool IsMinecartTrack(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003D8A")]
	[Cpp2IlInjected.Address(RVA = "0xE6A350", Offset = "0xE6A350", VA = "0xE6A350")]
	private static bool IsLocationInvalid(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003D8B")]
	[Cpp2IlInjected.Address(RVA = "0xE6ABD4", Offset = "0xE6ABD4", VA = "0xE6ABD4")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x3956F4", Offset = "0x3956F4")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x3956F4", Offset = "0x3956F4")]
	private void DrawPause()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D8C")]
	[Cpp2IlInjected.Address(RVA = "0xE6ABD8", Offset = "0xE6ABD8", VA = "0xE6ABD8")]
	public TrackGenerator()
	{
	}
}
