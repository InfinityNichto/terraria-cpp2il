using System;
using System.Runtime.Remoting.Proxies;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono
{
	// Token: 0x0200000C RID: 12
	[global::Cpp2ILInjected.Token(Token = "0x2000014")]
	internal struct RuntimeRemoteClassHandle
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00014639 File Offset: 0x00012839
		[global::Cpp2ILInjected.Token(Token = "0x17000006")]
		internal RuntimeClassHandle ProxyClass
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000048")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AAAF74", Offset = "0x1AAAF74", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.TransparentProxy), Member = "GetProxyType", ReturnType = typeof(global::System.RuntimeType))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000009 RID: 9
		[global::Cpp2ILInjected.Token(Token = "0x400008C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private unsafe RuntimeStructs.RemoteClass* value;
	}
}
