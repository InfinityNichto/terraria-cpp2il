using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Biomes.Desert
{
	// Token: 0x02000606 RID: 1542
	[global::Cpp2ILInjected.Token(Token = "0x200090A")]
	public class SurfaceMap
	{
		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06003DDC RID: 15836 RVA: 0x0002D0C8 File Offset: 0x0002B2C8
		[global::Cpp2ILInjected.Token(Token = "0x170007FB")]
		public int Width
		{
			[global::Cpp2ILInjected.Token(Token = "0x600467E")]
			[global::Cpp2ILInjected.Address(RVA = "0x7D53A4", Offset = "0x7D53A4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06003DDD RID: 15837 RVA: 0x0002D0CB File Offset: 0x0002B2CB
		[global::Cpp2ILInjected.Token(Token = "0x600467F")]
		[global::Cpp2ILInjected.Address(RVA = "0x7DB164", Offset = "0x7DB164", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SurfaceMap), Member = "FromArea", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(SurfaceMap))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private SurfaceMap(short[] heights, int x)
		{
			throw null;
		}

		// Token: 0x1700074C RID: 1868
		[global::Cpp2ILInjected.Token(Token = "0x170007FC")]
		public short this[int absoluteX]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004680")]
			[global::Cpp2ILInjected.Address(RVA = "0x7D53B0", Offset = "0x7D53B0", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DunesBiome), Member = "PlaceHill", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(double),
				"Terraria.GameContent.Biomes.DunesBiome.DunesDescription"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DunesBiome), Member = "PlaceCurvedLine", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(Point),
				typeof(Point),
				"Terraria.GameContent.Biomes.DunesBiome.DunesDescription"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06003DDF RID: 15839 RVA: 0x0002D0D1 File Offset: 0x0002B2D1
		[global::Cpp2ILInjected.Token(Token = "0x6004681")]
		[global::Cpp2ILInjected.Address(RVA = "0x7D6E78", Offset = "0x7D6E78", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Biomes.DunesBiome.DunesDescription", Member = "CreateFromPlacement", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int)
		}, ReturnType = "Terraria.GameContent.Biomes.DunesBiome.DunesDescription")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertDescription), Member = "UpdateSurfaceMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertDescription), Member = "CreateFromPlacement", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(DesertDescription))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SurfaceMap), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(short[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static SurfaceMap FromArea(int startX, int width)
		{
			throw null;
		}

		// Token: 0x04006C10 RID: 27664
		[global::Cpp2ILInjected.Token(Token = "0x400828D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly double Average;

		// Token: 0x04006C11 RID: 27665
		[global::Cpp2ILInjected.Token(Token = "0x400828E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly int Bottom;

		// Token: 0x04006C12 RID: 27666
		[global::Cpp2ILInjected.Token(Token = "0x400828F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public readonly int Top;

		// Token: 0x04006C13 RID: 27667
		[global::Cpp2ILInjected.Token(Token = "0x4008290")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public readonly int X;

		// Token: 0x04006C14 RID: 27668
		[global::Cpp2ILInjected.Token(Token = "0x4008291")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly short[] _heights;
	}
}
