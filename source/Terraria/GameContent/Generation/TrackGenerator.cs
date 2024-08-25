using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.IO;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation
{
	[global::Cpp2ILInjected.Token(Token = "0x20008DC")]
	public class TrackGenerator
	{
		[global::Cpp2ILInjected.Token(Token = "0x60045B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C0410", Offset = "0x7C0410", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_100", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TrackGenerator), Member = "FindSuitableOrigin", MemberParameters = new object[] { typeof(ref Point) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TrackGenerator), Member = "CreateTrackStart", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TrackGenerator), Member = "FindPath", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TrackGenerator), Member = "PlacePath", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Place(Point origin, int minLength, int maxLength)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60045B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C0800", Offset = "0x7C0800", Length = "0x610")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackGenerator), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "get_genRand", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_wall", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_wall", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "KillTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SmoothSlope", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "wire", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "ClearEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "PlaceTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "ResetToType", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "wire", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUtils), Member = "TileFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private void PlacePath()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60045B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C057C", Offset = "0x7C057C", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackGenerator), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void CreateTrackStart(Point origin)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60045B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C0684", Offset = "0x7C0684", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackGenerator), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TrackGenerator), Member = "TryRewriteHistoryToAvoidTiles", ReturnType = typeof(TrackGenerator.TrackPlacementState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TrackGenerator), Member = "CreateTunnel", ReturnType = typeof(TrackGenerator.TrackPlacementState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TrackGenerator), Member = "SmoothTrack", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TrackGenerator), Member = "GetHistorySegmentPlacementState", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(TrackGenerator.TrackPlacementState))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool FindPath(int minLength, int maxLength)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60045B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C1180", Offset = "0x7C1180", Length = "0x268")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackGenerator), Member = "FindPath", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TrackGenerator), Member = "CalculateStateForLocation", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(TrackGenerator.TrackPlacementState))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private TrackGenerator.TrackPlacementState CreateTunnel()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60045B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C0E24", Offset = "0x7C0E24", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void AppendToHistory(TrackGenerator.TrackSlope slope, TrackGenerator.TrackMode mode = TrackGenerator.TrackMode.Normal)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60045BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C0E84", Offset = "0x7C0E84", Length = "0x2FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackGenerator), Member = "FindPath", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TrackGenerator), Member = "GetHistorySegmentPlacementState", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(TrackGenerator.TrackPlacementState))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private TrackGenerator.TrackPlacementState TryRewriteHistoryToAvoidTiles()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60045BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C1780", Offset = "0x7C1780", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void RewriteSlopeDirection(int index, TrackGenerator.TrackSlope slope)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60045BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C1538", Offset = "0x7C1538", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackGenerator), Member = "FindPath", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackGenerator), Member = "TryRewriteHistoryToAvoidTiles", ReturnType = typeof(TrackGenerator.TrackPlacementState))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TrackGenerator), Member = "CalculateStateForLocation", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(TrackGenerator.TrackPlacementState))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private TrackGenerator.TrackPlacementState GetHistorySegmentPlacementState(int startIndex, int length)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60045BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C13E8", Offset = "0x7C13E8", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackGenerator), Member = "FindPath", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void SmoothTrack()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60045BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C1754", Offset = "0x7C1754", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool CanSlopesTouch(TrackGenerator.TrackSlope leftSlope, TrackGenerator.TrackSlope rightSlope)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60045BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C04BC", Offset = "0x7C04BC", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackGenerator), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TrackGenerator), Member = "CalculateStateForLocation", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(TrackGenerator.TrackPlacementState))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool FindSuitableOrigin(ref Point origin)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60045C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C1628", Offset = "0x7C1628", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackGenerator), Member = "CreateTunnel", ReturnType = typeof(TrackGenerator.TrackPlacementState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackGenerator), Member = "GetHistorySegmentPlacementState", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(TrackGenerator.TrackPlacementState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackGenerator), Member = "FindSuitableOrigin", MemberParameters = new object[] { typeof(ref Point) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TrackGenerator), Member = "IsLocationInvalid", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TrackGenerator), Member = "IsMinecartTrack", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "IsTileNearby", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static TrackGenerator.TrackPlacementState CalculateStateForLocation(int x, int y)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60045C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C1D14", Offset = "0x7C1D14", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackGenerator), Member = "CalculateStateForLocation", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(TrackGenerator.TrackPlacementState))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool IsMinecartTrack(int x, int y)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60045C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C17D4", Offset = "0x7C17D4", Length = "0x540")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TrackGenerator), Member = "CalculateStateForLocation", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(TrackGenerator.TrackPlacementState))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_UnderworldLayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "oceanDepths", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_wall", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		private static bool IsLocationInvalid(int x, int y)
		{
			throw null;
		}

		[Conditional("ENABLE_DEBUG")]
		[Conditional("UNITY_EDITOR")]
		[global::Cpp2ILInjected.Token(Token = "0x60045C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C1DF4", Offset = "0x7C1DF4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void DrawPause()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60045C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C1DF8", Offset = "0x7C1DF8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_100", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public TrackGenerator()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60045C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x7C1E68", Offset = "0x7C1E68", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static TrackGenerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400821A")]
		private static readonly ushort[] InvalidWalls;

		[global::Cpp2ILInjected.Token(Token = "0x400821B")]
		private static readonly ushort[] InvalidTiles;

		[global::Cpp2ILInjected.Token(Token = "0x400821C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly TrackGenerator.TrackHistory[] _history;

		[global::Cpp2ILInjected.Token(Token = "0x400821D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly TrackGenerator.TrackHistory[] _rewriteHistory;

		[global::Cpp2ILInjected.Token(Token = "0x400821E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _xDirection;

		[global::Cpp2ILInjected.Token(Token = "0x400821F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int _length;

		[global::Cpp2ILInjected.Token(Token = "0x4008220")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int playerHeight;

		[global::Cpp2ILInjected.Token(Token = "0x20008DD")]
		private enum TrackPlacementState
		{
			[global::Cpp2ILInjected.Token(Token = "0x4008222")]
			Available,
			[global::Cpp2ILInjected.Token(Token = "0x4008223")]
			Obstructed,
			[global::Cpp2ILInjected.Token(Token = "0x4008224")]
			Invalid
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008DE")]
		private enum TrackSlope : sbyte
		{
			[global::Cpp2ILInjected.Token(Token = "0x4008226")]
			Up = -1,
			[global::Cpp2ILInjected.Token(Token = "0x4008227")]
			Straight,
			[global::Cpp2ILInjected.Token(Token = "0x4008228")]
			Down
		}

		[global::Cpp2ILInjected.Token(Token = "0x20008DF")]
		private enum TrackMode : byte
		{
			[global::Cpp2ILInjected.Token(Token = "0x400822A")]
			Normal,
			[global::Cpp2ILInjected.Token(Token = "0x400822B")]
			Tunnel
		}

		[DebuggerDisplay("X = {X}, Y = {Y}, Slope = {Slope}")]
		[global::Cpp2ILInjected.Token(Token = "0x20008E0")]
		private struct TrackHistory
		{
			[global::Cpp2ILInjected.Token(Token = "0x60045C6")]
			[global::Cpp2ILInjected.Address(RVA = "0x7C0E10", Offset = "0x7C0E10", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public TrackHistory(int x, int y, TrackGenerator.TrackSlope slope)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400822C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public short X;

			[global::Cpp2ILInjected.Token(Token = "0x400822D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
			public short Y;

			[global::Cpp2ILInjected.Token(Token = "0x400822E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public TrackGenerator.TrackSlope Slope;

			[global::Cpp2ILInjected.Token(Token = "0x400822F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x5")]
			public TrackGenerator.TrackMode Mode;
		}
	}
}
