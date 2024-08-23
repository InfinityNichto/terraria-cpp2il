using System;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200013E RID: 318
	[global::Cpp2ILInjected.Token(Token = "0x20001C5")]
	public abstract class TransportContext
	{
		// Token: 0x060009D3 RID: 2515
		[global::Cpp2ILInjected.Token(Token = "0x6000AE2")]
		public abstract ChannelBinding GetChannelBinding(ChannelBindingKind kind);

		// Token: 0x060009D4 RID: 2516 RVA: 0x000049F4 File Offset: 0x00002BF4
		[global::Cpp2ILInjected.Token(Token = "0x6000AE3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F116A0", Offset = "0x1F116A0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual IEnumerable<TokenBinding> GetTlsTokenBindings()
		{
			throw null;
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x000049F7 File Offset: 0x00002BF7
		[global::Cpp2ILInjected.Token(Token = "0x6000AE4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F116D8", Offset = "0x1F116D8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerRequest.Context", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "get_TransportContext", ReturnType = typeof(TransportContext))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected TransportContext()
		{
			throw null;
		}
	}
}
