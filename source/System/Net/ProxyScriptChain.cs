using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20001F8")]
	internal class ProxyScriptChain : ProxyChain
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C6D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F27A1C", Offset = "0x1F27A1C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProxyChain), Member = ".ctor", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		internal ProxyScriptChain(WebProxy proxy, Uri destination)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C6E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F27A44", Offset = "0x1F27A44", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "GetProxiesAuto", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ref int)
		}, ReturnType = typeof(Uri[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "GetProxyAutoFailover", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
		protected override bool GetNextProxy(out Uri proxy)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C6F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F27E5C", Offset = "0x1F27E5C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AutoWebProxyScriptEngine), Member = "Abort", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(void))]
		internal override void Abort()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000AAA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private WebProxy m_Proxy;

		[global::Cpp2ILInjected.Token(Token = "0x4000AAB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Uri[] m_ScriptProxies;

		[global::Cpp2ILInjected.Token(Token = "0x4000AAC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private int m_CurrentIndex;

		[global::Cpp2ILInjected.Token(Token = "0x4000AAD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		private int m_SyncStatus;
	}
}
