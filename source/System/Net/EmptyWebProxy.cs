using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200016B RID: 363
	[global::Cpp2ILInjected.Token(Token = "0x200020A")]
	[Serializable]
	internal sealed class EmptyWebProxy : IAutoWebProxy, IWebProxy
	{
		// Token: 0x06000B69 RID: 2921 RVA: 0x00004E9B File Offset: 0x0000309B
		[global::Cpp2ILInjected.Token(Token = "0x6000CBD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2BE74", Offset = "0x1F2BE74", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GlobalProxySelection), Member = "GetEmptyWebProxy", ReturnType = typeof(IWebProxy))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EmptyWebProxy()
		{
			throw null;
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00004E9E File Offset: 0x0000309E
		[global::Cpp2ILInjected.Token(Token = "0x6000CBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2BE7C", Offset = "0x1F2BE7C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Uri GetProxy(Uri uri)
		{
			throw null;
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x00004EA1 File Offset: 0x000030A1
		[global::Cpp2ILInjected.Token(Token = "0x6000CBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2BE84", Offset = "0x1F2BE84", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool IsBypassed(Uri uri)
		{
			throw null;
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000B6C RID: 2924 RVA: 0x00004EA4 File Offset: 0x000030A4
		// (set) Token: 0x06000B6D RID: 2925 RVA: 0x00004EA7 File Offset: 0x000030A7
		[global::Cpp2ILInjected.Token(Token = "0x17000298")]
		public ICredentials Credentials
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CC0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2BE8C", Offset = "0x1F2BE8C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000CC1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2BE94", Offset = "0x1F2BE94", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x00004EAA File Offset: 0x000030AA
		[global::Cpp2ILInjected.Token(Token = "0x6000CC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2BE9C", Offset = "0x1F2BE9C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProxyChain), Member = ".ctor", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private ProxyChain System.Net.IAutoWebProxy.GetProxies(Uri destination)
		{
			throw null;
		}

		// Token: 0x0400087E RID: 2174
		[global::Cpp2ILInjected.Token(Token = "0x4000ADF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		[NonSerialized]
		private ICredentials m_credentials;
	}
}
