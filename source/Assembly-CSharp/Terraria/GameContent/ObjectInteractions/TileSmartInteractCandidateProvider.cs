using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.ObjectInteractions
{
	// Token: 0x020005AB RID: 1451
	[global::Cpp2ILInjected.Token(Token = "0x200084A")]
	public class TileSmartInteractCandidateProvider : ISmartInteractCandidateProvider
	{
		// Token: 0x06003BFC RID: 15356 RVA: 0x0002CB6A File Offset: 0x0002AD6A
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

		// Token: 0x06003BFD RID: 15357 RVA: 0x0002CB6D File Offset: 0x0002AD6D
		[global::Cpp2ILInjected.Token(Token = "0x6004320")]
		[global::Cpp2ILInjected.Address(RVA = "0x79F620", Offset = "0x79F620", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int JoinValue(int x, int y)
		{
			throw null;
		}

		// Token: 0x06003BFE RID: 15358 RVA: 0x0002CB70 File Offset: 0x0002AD70
		[global::Cpp2ILInjected.Token(Token = "0x6004321")]
		[global::Cpp2ILInjected.Address(RVA = "0x79F628", Offset = "0x79F628", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void SplitValue(int value, out int x, out int y)
		{
			throw null;
		}

		// Token: 0x06003BFF RID: 15359 RVA: 0x0002CB73 File Offset: 0x0002AD73
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

		// Token: 0x06003C00 RID: 15360 RVA: 0x0002CB76 File Offset: 0x0002AD76
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

		// Token: 0x06003C01 RID: 15361 RVA: 0x0002CB79 File Offset: 0x0002AD79
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

		// Token: 0x04006B4D RID: 27469
		[global::Cpp2ILInjected.Token(Token = "0x400814E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<int> targets;

		// Token: 0x04006B4E RID: 27470
		[global::Cpp2ILInjected.Token(Token = "0x400814F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private TileSmartInteractCandidateProvider.ReusableCandidate _candidate;

		// Token: 0x020009AA RID: 2474
		[global::Cpp2ILInjected.Token(Token = "0x200084B")]
		private class ReusableCandidate : ISmartInteractCandidate
		{
			// Token: 0x06004DF8 RID: 19960 RVA: 0x0002FC24 File Offset: 0x0002DE24
			[global::Cpp2ILInjected.Token(Token = "0x6004325")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A057C", Offset = "0x7A057C", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Reuse(bool strictSettings, float distanceFromCursor, int AimedX, int AimedY, int LX, int LY, int HX, int HY)
			{
				throw null;
			}

			// Token: 0x170008C0 RID: 2240
			// (get) Token: 0x06004DF9 RID: 19961 RVA: 0x0002FC27 File Offset: 0x0002DE27
			// (set) Token: 0x06004DFA RID: 19962 RVA: 0x0002FC2A File Offset: 0x0002DE2A
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

			// Token: 0x06004DFB RID: 19963 RVA: 0x0002FC2D File Offset: 0x0002DE2D
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

			// Token: 0x06004DFC RID: 19964 RVA: 0x0002FC30 File Offset: 0x0002DE30
			[global::Cpp2ILInjected.Token(Token = "0x6004329")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A0598", Offset = "0x7A0598", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ReusableCandidate()
			{
				throw null;
			}

			// Token: 0x04008CB6 RID: 36022
			[global::Cpp2ILInjected.Token(Token = "0x4008150")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private bool _strictSettings;

			// Token: 0x04008CB7 RID: 36023
			[global::Cpp2ILInjected.Token(Token = "0x4008151")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			private int _aimedX;

			// Token: 0x04008CB8 RID: 36024
			[global::Cpp2ILInjected.Token(Token = "0x4008152")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private int _aimedY;

			// Token: 0x04008CB9 RID: 36025
			[global::Cpp2ILInjected.Token(Token = "0x4008153")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private int _hx;

			// Token: 0x04008CBA RID: 36026
			[global::Cpp2ILInjected.Token(Token = "0x4008154")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int _hy;

			// Token: 0x04008CBB RID: 36027
			[global::Cpp2ILInjected.Token(Token = "0x4008155")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private int _lx;

			// Token: 0x04008CBC RID: 36028
			[global::Cpp2ILInjected.Token(Token = "0x4008156")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private int _ly;

			// Token: 0x04008CBD RID: 36029
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008157")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
			private float <DistanceFromCursor>k__BackingField;
		}
	}
}
