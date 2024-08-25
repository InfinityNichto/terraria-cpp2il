using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Biomes.CaveHouse;

namespace Terraria.WorldBuilding
{
	[global::Cpp2ILInjected.Token(Token = "0x20004A7")]
	public abstract class GenCondition : GenBase
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6002FD2")]
		protected abstract bool CheckValidity(int x, int y);

		[global::Cpp2ILInjected.Token(Token = "0x6002FD3")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F6058", Offset = "0x12F6058", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected GenCondition()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003992")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool InvertResults;

		[global::Cpp2ILInjected.Token(Token = "0x4003993")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int _width;

		[global::Cpp2ILInjected.Token(Token = "0x4003994")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _height;

		[global::Cpp2ILInjected.Token(Token = "0x4003995")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private GenCondition.AreaType _areaType;

		[global::Cpp2ILInjected.Token(Token = "0x20004A8")]
		private enum AreaType
		{
			[global::Cpp2ILInjected.Token(Token = "0x4003997")]
			And,
			[global::Cpp2ILInjected.Token(Token = "0x4003998")]
			Or,
			[global::Cpp2ILInjected.Token(Token = "0x4003999")]
			None
		}
	}
}
