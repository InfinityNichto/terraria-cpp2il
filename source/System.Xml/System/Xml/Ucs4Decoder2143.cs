using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x0200007F RID: 127
	[global::Cpp2ILInjected.Token(Token = "0x20000A6")]
	internal class Ucs4Decoder2143 : Ucs4Decoder
	{
		// Token: 0x060006EC RID: 1772 RVA: 0x00004370 File Offset: 0x00002570
		[global::Cpp2ILInjected.Token(Token = "0x6000775")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAEA74", Offset = "0x1DAEA74", Length = "0x1B0")]
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

		// Token: 0x060006ED RID: 1773 RVA: 0x00004373 File Offset: 0x00002573
		[global::Cpp2ILInjected.Token(Token = "0x6000776")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAE270", Offset = "0x1DAE270", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ucs4Decoder), Member = ".ctor", ReturnType = typeof(void))]
		public Ucs4Decoder2143()
		{
			throw null;
		}
	}
}
