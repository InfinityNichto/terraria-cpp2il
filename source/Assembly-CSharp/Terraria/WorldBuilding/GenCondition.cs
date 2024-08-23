using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Biomes.CaveHouse;

namespace Terraria.WorldBuilding
{
	// Token: 0x02000357 RID: 855
	[global::Cpp2ILInjected.Token(Token = "0x20004A7")]
	public abstract class GenCondition : GenBase
	{
		// Token: 0x06002C30 RID: 11312 RVA: 0x00029EC4 File Offset: 0x000280C4
		[global::Cpp2ILInjected.Token(Token = "0x6002FCE")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F5EC4", Offset = "0x12F5EC4", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Modifiers.Conditions), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(object[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GenSearch), Member = "Check", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public bool IsValid(int x, int y)
		{
			throw null;
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x00029EC7 File Offset: 0x000280C7
		[global::Cpp2ILInjected.Token(Token = "0x6002FCF")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F602C", Offset = "0x12F602C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnchantedSwordBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "FindVerticalExit", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(bool),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "FindSideExit", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(bool),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public GenCondition Not()
		{
			throw null;
		}

		// Token: 0x06002C32 RID: 11314 RVA: 0x00029ECA File Offset: 0x000280CA
		[global::Cpp2ILInjected.Token(Token = "0x6002FD0")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F603C", Offset = "0x12F603C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnchantedSwordBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MahoganyTreeBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "FindVerticalExit", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(bool),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "FindSideExit", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(bool),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public GenCondition AreaOr(int width, int height)
		{
			throw null;
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x00029ECD File Offset: 0x000280CD
		[global::Cpp2ILInjected.Token(Token = "0x6002FD1")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F604C", Offset = "0x12F604C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CorruptionPitBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MahoganyTreeBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public GenCondition AreaAnd(int width, int height)
		{
			throw null;
		}

		// Token: 0x06002C34 RID: 11316
		[global::Cpp2ILInjected.Token(Token = "0x6002FD2")]
		protected abstract bool CheckValidity(int x, int y);

		// Token: 0x06002C35 RID: 11317 RVA: 0x00029ED0 File Offset: 0x000280D0
		[global::Cpp2ILInjected.Token(Token = "0x6002FD3")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F6058", Offset = "0x12F6058", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected GenCondition()
		{
			throw null;
		}

		// Token: 0x040030C0 RID: 12480
		[global::Cpp2ILInjected.Token(Token = "0x4003992")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool InvertResults;

		// Token: 0x040030C1 RID: 12481
		[global::Cpp2ILInjected.Token(Token = "0x4003993")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int _width;

		// Token: 0x040030C2 RID: 12482
		[global::Cpp2ILInjected.Token(Token = "0x4003994")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _height;

		// Token: 0x040030C3 RID: 12483
		[global::Cpp2ILInjected.Token(Token = "0x4003995")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private GenCondition.AreaType _areaType;

		// Token: 0x020008A3 RID: 2211
		[global::Cpp2ILInjected.Token(Token = "0x20004A8")]
		private enum AreaType
		{
			// Token: 0x0400807D RID: 32893
			[global::Cpp2ILInjected.Token(Token = "0x4003997")]
			And,
			// Token: 0x0400807E RID: 32894
			[global::Cpp2ILInjected.Token(Token = "0x4003998")]
			Or,
			// Token: 0x0400807F RID: 32895
			[global::Cpp2ILInjected.Token(Token = "0x4003999")]
			None
		}
	}
}
