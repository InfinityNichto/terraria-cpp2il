using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes.Desert
{
	// Token: 0x02000605 RID: 1541
	[global::Cpp2ILInjected.Token(Token = "0x2000908")]
	public static class SandMound
	{
		// Token: 0x06003DDA RID: 15834 RVA: 0x0002D0C2 File Offset: 0x0002B2C2
		[global::Cpp2ILInjected.Token(Token = "0x600467C")]
		[global::Cpp2ILInjected.Address(RVA = "0x7DAAF4", Offset = "0x7DAAF4", Length = "0x534")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Clamp", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T", "T", "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "get_genRand", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "UnclampedSmoothStep", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetSHeader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SandMound), Member = "<Place>g__PlaceSandColumn|0_0", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref SandMound.<>c__DisplayClass0_0)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public static void Place(DesertDescription description)
		{
			throw null;
		}

		// Token: 0x06003DDB RID: 15835 RVA: 0x0002D0C5 File Offset: 0x0002B2C5
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x600467D")]
		[global::Cpp2ILInjected.Address(RVA = "0x7DB028", Offset = "0x7DB028", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SandMound), Member = "Place", MemberParameters = new object[] { typeof(DesertDescription) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetType", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ushort)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "SetSHeader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SquareWallFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static void Method_Internal_Static_Void_Int32_Int32_Int32_<>c__DisplayClass0_0_0(int startX, int startY, int height, ref SandMound.<>c__DisplayClass0_0 A_3)
		{
			throw null;
		}

		// Token: 0x02000A0D RID: 2573
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000909")]
		[StructLayout(3)]
		private struct <>c__DisplayClass0_0
		{
			// Token: 0x04008D2C RID: 36140
			[global::Cpp2ILInjected.Token(Token = "0x4008289")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int Main_maxTilesX;

			// Token: 0x04008D2D RID: 36141
			[global::Cpp2ILInjected.Token(Token = "0x400828A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public unsafe byte* TileData_TileLiquid;

			// Token: 0x04008D2E RID: 36142
			[global::Cpp2ILInjected.Token(Token = "0x400828B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public unsafe uint* TileData_TileLookup;

			// Token: 0x04008D2F RID: 36143
			[global::Cpp2ILInjected.Token(Token = "0x400828C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public unsafe short* TileData_TileSHeader;
		}
	}
}
