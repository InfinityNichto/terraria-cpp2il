using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200017C RID: 380
	[global::Cpp2ILInjected.Token(Token = "0x200021F")]
	internal class WebProxyData
	{
		// Token: 0x06000C3E RID: 3134 RVA: 0x0000510E File Offset: 0x0000330E
		[global::Cpp2ILInjected.Token(Token = "0x6000D9C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2B2D0", Offset = "0x1F2B2D0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public WebProxyData()
		{
			throw null;
		}

		// Token: 0x04000902 RID: 2306
		[global::Cpp2ILInjected.Token(Token = "0x4000B6F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal bool bypassOnLocal;

		// Token: 0x04000903 RID: 2307
		[global::Cpp2ILInjected.Token(Token = "0x4000B70")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
		internal bool automaticallyDetectSettings;

		// Token: 0x04000904 RID: 2308
		[global::Cpp2ILInjected.Token(Token = "0x4000B71")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal Uri proxyAddress;

		// Token: 0x04000905 RID: 2309
		[global::Cpp2ILInjected.Token(Token = "0x4000B72")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal Hashtable proxyHostAddresses;

		// Token: 0x04000906 RID: 2310
		[global::Cpp2ILInjected.Token(Token = "0x4000B73")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal Uri scriptLocation;

		// Token: 0x04000907 RID: 2311
		[global::Cpp2ILInjected.Token(Token = "0x4000B74")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal ArrayList bypassList;
	}
}
