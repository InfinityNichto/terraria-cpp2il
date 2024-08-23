using System;
using System.Xml.Schema;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x0200000A RID: 10
	[global::Cpp2ILInjected.Token(Token = "0x200000A")]
	internal static class Bits
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00003065 File Offset: 0x00001265
		[global::Cpp2ILInjected.Token(Token = "0x6000017")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5D3BC", Offset = "0x1D5D3BC", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Bits), Member = "LeastPosition", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int Count(uint num)
		{
			throw null;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003068 File Offset: 0x00001268
		[global::Cpp2ILInjected.Token(Token = "0x6000018")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5D458", Offset = "0x1D5D458", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DateTimeOffset),
			typeof(XsdDateTimeFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bits), Member = "Count", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int LeastPosition(uint num)
		{
			throw null;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000306B File Offset: 0x0000126B
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000019")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5D4C4", Offset = "0x1D5D4C4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static Bits()
		{
			throw null;
		}

		// Token: 0x04000012 RID: 18
		[global::Cpp2ILInjected.Token(Token = "0x4000012")]
		private static readonly uint MASK_0101010101010101;

		// Token: 0x04000013 RID: 19
		[global::Cpp2ILInjected.Token(Token = "0x4000013")]
		private static readonly uint MASK_0011001100110011;

		// Token: 0x04000014 RID: 20
		[global::Cpp2ILInjected.Token(Token = "0x4000014")]
		private static readonly uint MASK_0000111100001111;

		// Token: 0x04000015 RID: 21
		[global::Cpp2ILInjected.Token(Token = "0x4000015")]
		private static readonly uint MASK_0000000011111111;

		// Token: 0x04000016 RID: 22
		[global::Cpp2ILInjected.Token(Token = "0x4000016")]
		private static readonly uint MASK_1111111111111111;
	}
}
