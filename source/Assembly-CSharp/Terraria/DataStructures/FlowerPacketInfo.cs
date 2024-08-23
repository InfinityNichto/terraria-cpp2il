using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.ID;

namespace Terraria.DataStructures
{
	// Token: 0x0200042F RID: 1071
	[global::Cpp2ILInjected.Token(Token = "0x200062A")]
	public class FlowerPacketInfo
	{
		// Token: 0x060030E7 RID: 12519 RVA: 0x0002ABED File Offset: 0x00028DED
		[global::Cpp2ILInjected.Token(Token = "0x6003604")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DC5E8", Offset = "0x13DC5E8", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemID.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public FlowerPacketInfo()
		{
			throw null;
		}

		// Token: 0x040062E6 RID: 25318
		[global::Cpp2ILInjected.Token(Token = "0x40076D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public List<int> stylesOnPurity;

		// Token: 0x040062E7 RID: 25319
		[global::Cpp2ILInjected.Token(Token = "0x40076D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public List<int> stylesOnCorruption;

		// Token: 0x040062E8 RID: 25320
		[global::Cpp2ILInjected.Token(Token = "0x40076D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public List<int> stylesOnCrimson;

		// Token: 0x040062E9 RID: 25321
		[global::Cpp2ILInjected.Token(Token = "0x40076D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public List<int> stylesOnHallow;
	}
}
