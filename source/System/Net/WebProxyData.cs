using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200021F")]
	internal class WebProxyData
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000D9C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2B2D0", Offset = "0x1F2B2D0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public WebProxyData()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000B6F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal bool bypassOnLocal;

		[global::Cpp2ILInjected.Token(Token = "0x4000B70")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
		internal bool automaticallyDetectSettings;

		[global::Cpp2ILInjected.Token(Token = "0x4000B71")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal Uri proxyAddress;

		[global::Cpp2ILInjected.Token(Token = "0x4000B72")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal Hashtable proxyHostAddresses;

		[global::Cpp2ILInjected.Token(Token = "0x4000B73")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal Uri scriptLocation;

		[global::Cpp2ILInjected.Token(Token = "0x4000B74")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal ArrayList bypassList;
	}
}
