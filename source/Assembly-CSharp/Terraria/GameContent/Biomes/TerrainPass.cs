using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.IO;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x020005FD RID: 1533
	[global::Cpp2ILInjected.Token(Token = "0x20008F9")]
	public class TerrainPass : GenPass
	{
		// Token: 0x06003DAF RID: 15791 RVA: 0x0002D041 File Offset: 0x0002B241
		[global::Cpp2ILInjected.Token(Token = "0x6004645")]
		[global::Cpp2ILInjected.Address(RVA = "0x7D3444", Offset = "0x7D3444", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GenerateWorld", MemberParameters = new object[]
		{
			typeof(int),
			typeof(GenerationProgress)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenPass), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public TerrainPass()
		{
			throw null;
		}

		// Token: 0x06003DB0 RID: 15792 RVA: 0x0002D044 File Offset: 0x0002B244
		[global::Cpp2ILInjected.Token(Token = "0x6004646")]
		[global::Cpp2ILInjected.Address(RVA = "0x7D3498", Offset = "0x7D3498", Length = "0xBC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameConfiguration[]), Member = "Get", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenerationProgress), Member = "set_Message", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenBase), Member = "get__random", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TerrainPass.SurfaceHistory), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "GetTileDefinition", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(short),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenerationProgress), Member = "Set", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TerrainPass), Member = "GenerateWorldSurfaceOffset", MemberParameters = new object[] { typeof(TerrainPass.TerrainFeatureType) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Clamp", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T", "T", "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TerrainPass), Member = "FillColumn", MemberParameters = new object[]
		{
			typeof(int),
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TerrainPass), Member = "RetargetSurfaceHistory", MemberParameters = new object[]
		{
			typeof(TerrainPass.SurfaceHistory),
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 45)]
		protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
		{
			throw null;
		}

		// Token: 0x06003DB1 RID: 15793 RVA: 0x0002D047 File Offset: 0x0002B247
		[global::Cpp2ILInjected.Token(Token = "0x6004647")]
		[global::Cpp2ILInjected.Address(RVA = "0x7D471C", Offset = "0x7D471C", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TerrainPass), Member = "ApplyPass", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void FillColumn(int x, double worldSurface, double rockLayer)
		{
			throw null;
		}

		// Token: 0x06003DB2 RID: 15794 RVA: 0x0002D04A File Offset: 0x0002B24A
		[global::Cpp2ILInjected.Token(Token = "0x6004648")]
		[global::Cpp2ILInjected.Address(RVA = "0x7D49E0", Offset = "0x7D49E0", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TerrainPass), Member = "RetargetSurfaceHistory", MemberParameters = new object[]
		{
			typeof(TerrainPass.SurfaceHistory),
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_frameX", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_frameY", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_type", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void RetargetColumn(int x, double worldSurface)
		{
			throw null;
		}

		// Token: 0x06003DB3 RID: 15795 RVA: 0x0002D04D File Offset: 0x0002B24D
		[global::Cpp2ILInjected.Token(Token = "0x6004649")]
		[global::Cpp2ILInjected.Address(RVA = "0x7D40C8", Offset = "0x7D40C8", Length = "0x62C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TerrainPass), Member = "ApplyPass", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "get_genRand", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenBase), Member = "get__random", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static double GenerateWorldSurfaceOffset(TerrainPass.TerrainFeatureType featureType)
		{
			throw null;
		}

		// Token: 0x06003DB4 RID: 15796 RVA: 0x0002D050 File Offset: 0x0002B250
		[global::Cpp2ILInjected.Token(Token = "0x600464A")]
		[global::Cpp2ILInjected.Address(RVA = "0x7D48D0", Offset = "0x7D48D0", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TerrainPass), Member = "ApplyPass", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TerrainPass), Member = "RetargetColumn", MemberParameters = new object[]
		{
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		private static void RetargetSurfaceHistory(TerrainPass.SurfaceHistory history, int targetX, double targetHeight)
		{
			throw null;
		}

		// Token: 0x04006C02 RID: 27650
		[global::Cpp2ILInjected.Token(Token = "0x4008267")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private uint skyDefinition;

		// Token: 0x04006C03 RID: 27651
		[global::Cpp2ILInjected.Token(Token = "0x4008268")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private uint dirtDefinition;

		// Token: 0x04006C04 RID: 27652
		[global::Cpp2ILInjected.Token(Token = "0x4008269")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private uint rockDefinition;

		// Token: 0x02000A06 RID: 2566
		[global::Cpp2ILInjected.Token(Token = "0x20008FA")]
		private enum TerrainFeatureType
		{
			// Token: 0x04008D19 RID: 36121
			[global::Cpp2ILInjected.Token(Token = "0x400826B")]
			Plateau,
			// Token: 0x04008D1A RID: 36122
			[global::Cpp2ILInjected.Token(Token = "0x400826C")]
			Hill,
			// Token: 0x04008D1B RID: 36123
			[global::Cpp2ILInjected.Token(Token = "0x400826D")]
			Dale,
			// Token: 0x04008D1C RID: 36124
			[global::Cpp2ILInjected.Token(Token = "0x400826E")]
			Mountain,
			// Token: 0x04008D1D RID: 36125
			[global::Cpp2ILInjected.Token(Token = "0x400826F")]
			Valley
		}

		// Token: 0x02000A07 RID: 2567
		[global::Cpp2ILInjected.Token(Token = "0x20008FB")]
		private class SurfaceHistory
		{
			// Token: 0x170008CD RID: 2253
			[global::Cpp2ILInjected.Token(Token = "0x170007F1")]
			public double this[int index]
			{
				[global::Cpp2ILInjected.Token(Token = "0x600464B")]
				[global::Cpp2ILInjected.Address(RVA = "0x7D4B9C", Offset = "0x7D4B9C", Length = "0x24")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x600464C")]
				[global::Cpp2ILInjected.Address(RVA = "0x7D4BC0", Offset = "0x7D4BC0", Length = "0x24")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x170008CE RID: 2254
			// (get) Token: 0x06004F6A RID: 20330 RVA: 0x00030062 File Offset: 0x0002E262
			[global::Cpp2ILInjected.Token(Token = "0x170007F2")]
			public int Length
			{
				[global::Cpp2ILInjected.Token(Token = "0x600464D")]
				[global::Cpp2ILInjected.Address(RVA = "0x7D4B90", Offset = "0x7D4B90", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004F6B RID: 20331 RVA: 0x00030065 File Offset: 0x0002E265
			[global::Cpp2ILInjected.Token(Token = "0x600464E")]
			[global::Cpp2ILInjected.Address(RVA = "0x7D4060", Offset = "0x7D4060", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TerrainPass), Member = "ApplyPass", MemberParameters = new object[]
			{
				typeof(GenerationProgress),
				typeof(GameConfiguration)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public SurfaceHistory(int size)
			{
				throw null;
			}

			// Token: 0x06004F6C RID: 20332 RVA: 0x00030068 File Offset: 0x0002E268
			[global::Cpp2ILInjected.Token(Token = "0x600464F")]
			[global::Cpp2ILInjected.Address(RVA = "0x7D46F4", Offset = "0x7D46F4", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Record(double height)
			{
				throw null;
			}

			// Token: 0x04008D1E RID: 36126
			[global::Cpp2ILInjected.Token(Token = "0x4008270")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private readonly double[] _heights;

			// Token: 0x04008D1F RID: 36127
			[global::Cpp2ILInjected.Token(Token = "0x4008271")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private int _index;
		}
	}
}
