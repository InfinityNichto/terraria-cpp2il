using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000082 RID: 130
	[global::Cpp2ILInjected.Token(Token = "0x20000A9")]
	public abstract class XmlNameTable
	{
		// Token: 0x06000708 RID: 1800
		[global::Cpp2ILInjected.Token(Token = "0x6000791")]
		public abstract string Get(string array);

		// Token: 0x06000709 RID: 1801
		[global::Cpp2ILInjected.Token(Token = "0x6000792")]
		public abstract string Add(char[] array, int offset, int length);

		// Token: 0x0600070A RID: 1802
		[global::Cpp2ILInjected.Token(Token = "0x6000793")]
		public abstract string Add(string array);

		// Token: 0x0600070B RID: 1803 RVA: 0x000043C4 File Offset: 0x000025C4
		[global::Cpp2ILInjected.Token(Token = "0x6000794")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAFB30", Offset = "0x1DAFB30", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameTable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected XmlNameTable()
		{
			throw null;
		}
	}
}
