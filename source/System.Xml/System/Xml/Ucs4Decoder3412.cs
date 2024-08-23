using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000080 RID: 128
	[global::Cpp2ILInjected.Token(Token = "0x20000A7")]
	internal class Ucs4Decoder3412 : Ucs4Decoder
	{
		// Token: 0x060006EE RID: 1774 RVA: 0x00004376 File Offset: 0x00002576
		[global::Cpp2ILInjected.Token(Token = "0x6000777")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAEC24", Offset = "0x1DAEC24", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		internal override int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			throw null;
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00004379 File Offset: 0x00002579
		[global::Cpp2ILInjected.Token(Token = "0x6000778")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAE304", Offset = "0x1DAE304", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ucs4Decoder), Member = ".ctor", ReturnType = typeof(void))]
		public Ucs4Decoder3412()
		{
			throw null;
		}
	}
}
