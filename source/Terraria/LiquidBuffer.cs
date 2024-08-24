using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria
{
	// Token: 0x02000317 RID: 791
	[global::Cpp2ILInjected.Token(Token = "0x20003F1")]
	public class LiquidBuffer
	{
		// Token: 0x06001A27 RID: 6695 RVA: 0x000268D3 File Offset: 0x00024AD3
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

		// Token: 0x06001A28 RID: 6696 RVA: 0x000268D6 File Offset: 0x00024AD6
		[global::Cpp2ILInjected.Token(Token = "0x6001BB9")]
		[global::Cpp2ILInjected.Address(RVA = "0xCEDBDC", Offset = "0xCEDBDC", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Liquid), Member = "UpdateLiquid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void DelBuffer(int l)
		{
			throw null;
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x000268D9 File Offset: 0x00024AD9
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

		// Token: 0x04002274 RID: 8820
		[global::Cpp2ILInjected.Token(Token = "0x40028E6")]
		public static int numLiquidBuffer;

		// Token: 0x04002275 RID: 8821
		[global::Cpp2ILInjected.Token(Token = "0x40028E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int x;

		// Token: 0x04002276 RID: 8822
		[global::Cpp2ILInjected.Token(Token = "0x40028E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int y;
	}
}
