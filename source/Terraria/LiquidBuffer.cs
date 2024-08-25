using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria
{
	[global::Cpp2ILInjected.Token(Token = "0x20003F1")]
	public class LiquidBuffer
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001BB8")]
		[global::Cpp2ILInjected.Address(RVA = "0xCEDC88", Offset = "0xCEDC88", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "AddWater", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "checkingLiquid", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "checkingLiquid", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void AddBuffer(int x, int y)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001BB9")]
		[global::Cpp2ILInjected.Address(RVA = "0xCEDBDC", Offset = "0xCEDBDC", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "UpdateLiquid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void DelBuffer(int l)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001BBA")]
		[global::Cpp2ILInjected.Address(RVA = "0xCFA740", Offset = "0xCFA740", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public LiquidBuffer()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40028E6")]
		public static int numLiquidBuffer;

		[global::Cpp2ILInjected.Token(Token = "0x40028E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int x;

		[global::Cpp2ILInjected.Token(Token = "0x40028E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int y;
	}
}
