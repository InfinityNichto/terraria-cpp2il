using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000006 RID: 6
	[global::Cpp2ILInjected.Token(Token = "0x2000006")]
	internal class XmlRawWriterBase64Encoder : Base64Encoder
	{
		// Token: 0x06000008 RID: 8 RVA: 0x00003038 File Offset: 0x00001238
		[global::Cpp2ILInjected.Token(Token = "0x6000008")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5C998", Offset = "0x1D5C998", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Base64Encoder), Member = ".ctor", ReturnType = typeof(void))]
		internal XmlRawWriterBase64Encoder(XmlRawWriter rawWriter)
		{
			throw null;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000303B File Offset: 0x0000123B
		[global::Cpp2ILInjected.Token(Token = "0x6000009")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5C9BC", Offset = "0x1D5C9BC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override void WriteChars(char[] chars, int index, int count)
		{
			throw null;
		}

		// Token: 0x04000009 RID: 9
		[global::Cpp2ILInjected.Token(Token = "0x4000009")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private XmlRawWriter rawWriter;
	}
}
