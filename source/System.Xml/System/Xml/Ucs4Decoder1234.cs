using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x0200007E RID: 126
	[global::Cpp2ILInjected.Token(Token = "0x20000A5")]
	internal class Ucs4Decoder1234 : Ucs4Decoder
	{
		// Token: 0x060006EA RID: 1770 RVA: 0x0000436A File Offset: 0x0000256A
		[global::Cpp2ILInjected.Token(Token = "0x6000773")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAE8C4", Offset = "0x1DAE8C4", Length = "0x1B0")]
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

		// Token: 0x060006EB RID: 1771 RVA: 0x0000436D File Offset: 0x0000256D
		[global::Cpp2ILInjected.Token(Token = "0x6000774")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAE148", Offset = "0x1DAE148", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ucs4Decoder), Member = ".ctor", ReturnType = typeof(void))]
		public Ucs4Decoder1234()
		{
			throw null;
		}
	}
}
