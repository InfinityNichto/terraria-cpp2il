using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200020A")]
	[Serializable]
	internal sealed class EmptyWebProxy : IAutoWebProxy, IWebProxy
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000CBD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2BE74", Offset = "0x1F2BE74", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GlobalProxySelection), Member = "GetEmptyWebProxy", ReturnType = typeof(IWebProxy))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EmptyWebProxy()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000CBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2BE7C", Offset = "0x1F2BE7C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Uri GetProxy(Uri uri)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000CBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2BE84", Offset = "0x1F2BE84", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool IsBypassed(Uri uri)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000CC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2BE9C", Offset = "0x1F2BE9C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProxyChain), Member = ".ctor", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private ProxyChain System.Net.IAutoWebProxy.GetProxies(Uri destination)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000ADF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		[NonSerialized]
		private ICredentials m_credentials;
	}
}
