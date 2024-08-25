using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Biomes.CaveHouse;

namespace Terraria.WorldBuilding
{
	[global::Cpp2ILInjected.Token(Token = "0x20004D1")]
	public abstract class GenSearch : GenBase
	{
		[global::Cpp2ILInjected.Token(Token = "0x600302C")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F93BC", Offset = "0x12F93BC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public GenSearch Conditions(params GenCondition[] conditions)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600302D")]
		public abstract Point Find(Point origin);

		[global::Cpp2ILInjected.Token(Token = "0x600302E")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F93C4", Offset = "0x12F93C4", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Searches.Left), Member = "Find", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Searches.Right), Member = "Find", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Searches.Down), Member = "Find", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Searches.Up), Member = "Find", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Searches.Rectangle), Member = "Find", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenCondition), Member = "IsValid", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		protected bool Check(int x, int y)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600302F")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F9454", Offset = "0x12F9454", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseUtils), Member = "AreRoomsValid", MemberParameters = new object[]
		{
			typeof(IEnumerable<Rectangle>),
			typeof(StructureMap),
			typeof(HouseType)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public GenSearch RequireAll(bool mode)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003030")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F9460", Offset = "0x12F9460", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected GenSearch()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003031")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F9470", Offset = "0x12F9470", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static GenSearch()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40039CE")]
		public static Point NOT_FOUND;

		[global::Cpp2ILInjected.Token(Token = "0x40039CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool _requireAll;

		[global::Cpp2ILInjected.Token(Token = "0x40039D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private GenCondition[] _conditions;
	}
}
