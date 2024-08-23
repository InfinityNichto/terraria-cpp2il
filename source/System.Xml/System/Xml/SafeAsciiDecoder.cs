using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000076 RID: 118
	[global::Cpp2ILInjected.Token(Token = "0x200009D")]
	internal class SafeAsciiDecoder : Decoder
	{
		// Token: 0x060006C2 RID: 1730 RVA: 0x000042F5 File Offset: 0x000024F5
		[global::Cpp2ILInjected.Token(Token = "0x600074B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DADD08", Offset = "0x1DADD08", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SetupEncoding", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Decoder), Member = ".ctor", ReturnType = typeof(void))]
		public SafeAsciiDecoder()
		{
			throw null;
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x000042F8 File Offset: 0x000024F8
		[global::Cpp2ILInjected.Token(Token = "0x600074C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DADD10", Offset = "0x1DADD10", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			throw null;
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x000042FB File Offset: 0x000024FB
		[global::Cpp2ILInjected.Token(Token = "0x600074D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DADD18", Offset = "0x1DADD18", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			throw null;
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x000042FE File Offset: 0x000024FE
		[global::Cpp2ILInjected.Token(Token = "0x600074E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DADD54", Offset = "0x1DADD54", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
			throw null;
		}
	}
}
