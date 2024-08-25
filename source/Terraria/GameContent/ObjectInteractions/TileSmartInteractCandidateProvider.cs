using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.ObjectInteractions
{
	[global::Cpp2ILInjected.Token(Token = "0x200084A")]
	public class TileSmartInteractCandidateProvider : ISmartInteractCandidateProvider
	{
		[global::Cpp2ILInjected.Token(Token = "0x600431F")]
		[global::Cpp2ILInjected.Address(RVA = "0x79F538", Offset = "0x79F538", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_SmartInteractX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_SmartInteractY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_TileInteractionLX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_TileInteractionHX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_TileInteractionLY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_TileInteractionHY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SmartInteractTileCoords", ReturnType = typeof(Dictionary<int, bool>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, bool>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SmartInteractTileCoordsSelected", ReturnType = typeof(Dictionary<int, bool>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void ClearSelfAndPrepareForCheck()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004320")]
		[global::Cpp2ILInjected.Address(RVA = "0x79F620", Offset = "0x79F620", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int JoinValue(int x, int y)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004321")]
		[global::Cpp2ILInjected.Address(RVA = "0x79F628", Offset = "0x79F628", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void SplitValue(int value, out int x, out int y)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004322")]
		[global::Cpp2ILInjected.Address(RVA = "0x79F63C", Offset = "0x79F63C", Length = "0xA3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileSmartInteractCandidateProvider), Member = "FillPotentialTargetTiles", MemberParameters = new object[] { typeof(SmartInteractScanSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "InTileBounds", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SmartInteractTileCoords", ReturnType = typeof(Dictionary<int, bool>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, bool>), Member = "ContainsKey", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SmartInteractTileCoordsSelected", ReturnType = typeof(Dictionary<int, bool>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, bool>), Member = "Add", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ClosestPointInRect", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public bool ProvideCandidate(SmartInteractScanSettings settings, out ISmartInteractCandidate candidate)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004323")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A0078", Offset = "0x7A0078", Length = "0x504")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileSmartInteractCandidateProvider), Member = "ProvideCandidate", MemberParameters = new object[]
		{
			typeof(SmartInteractScanSettings),
			typeof(ref ISmartInteractCandidate)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "IsWithinSnappngRangeToTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClient", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "HasItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private void FillPotentialTargetTiles(SmartInteractScanSettings settings)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004324")]
		[global::Cpp2ILInjected.Address(RVA = "0x79EA40", Offset = "0x79EA40", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartInteractSystem), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public TileSmartInteractCandidateProvider()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400814E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<int> targets;

		[global::Cpp2ILInjected.Token(Token = "0x400814F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private TileSmartInteractCandidateProvider.ReusableCandidate _candidate;

		[global::Cpp2ILInjected.Token(Token = "0x200084B")]
		private class ReusableCandidate : ISmartInteractCandidate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004325")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A057C", Offset = "0x7A057C", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Reuse(bool strictSettings, float distanceFromCursor, int AimedX, int AimedY, int LX, int LY, int HX, int HY)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x170007C7")]
			public float DistanceFromCursor
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004326")]
				[global::Cpp2ILInjected.Address(RVA = "0x7A05A0", Offset = "0x7A05A0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6004327")]
				[global::Cpp2ILInjected.Address(RVA = "0x7A05A8", Offset = "0x7A05A8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				private set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004328")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A05B0", Offset = "0x7A05B0", Length = "0x118")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_SmartInteractX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_SmartInteractY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SmartInteractTileCoords", ReturnType = typeof(Dictionary<int, bool>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, bool>), Member = "get_Count", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_SmartInteractShowingFake", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_SmartInteractShowingGenuine", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_TileInteractionLX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_TileInteractionLY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_TileInteractionHX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_TileInteractionHY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public void WinCandidacy()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004329")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A0598", Offset = "0x7A0598", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ReusableCandidate()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4008150")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private bool _strictSettings;

			[global::Cpp2ILInjected.Token(Token = "0x4008151")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			private int _aimedX;

			[global::Cpp2ILInjected.Token(Token = "0x4008152")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private int _aimedY;

			[global::Cpp2ILInjected.Token(Token = "0x4008153")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private int _hx;

			[global::Cpp2ILInjected.Token(Token = "0x4008154")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int _hy;

			[global::Cpp2ILInjected.Token(Token = "0x4008155")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private int _lx;

			[global::Cpp2ILInjected.Token(Token = "0x4008156")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private int _ly;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008157")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
			private float <DistanceFromCursor>k__BackingField;
		}
	}
}
