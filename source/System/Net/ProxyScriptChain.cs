using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000163 RID: 355
	[global::Cpp2ILInjected.Token(Token = "0x20001F8")]
	internal class ProxyScriptChain : ProxyChain
	{
		// Token: 0x06000B3B RID: 2875 RVA: 0x00004E14 File Offset: 0x00003014
		[global::Cpp2ILInjected.Token(Token = "0x6000C6D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F27A1C", Offset = "0x1F27A1C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProxyChain), Member = ".ctor", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		internal ProxyScriptChain(WebProxy proxy, Uri destination)
		{
			throw null;
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x00004E17 File Offset: 0x00003017
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

		// Token: 0x06000B3D RID: 2877 RVA: 0x00004E1A File Offset: 0x0000301A
		[global::Cpp2ILInjected.Token(Token = "0x6000C6F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F27E5C", Offset = "0x1F27E5C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AutoWebProxyScriptEngine), Member = "Abort", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(void))]
		internal override void Abort()
		{
			throw null;
		}

		// Token: 0x04000861 RID: 2145
		[global::Cpp2ILInjected.Token(Token = "0x4000AAA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private WebProxy m_Proxy;

		// Token: 0x04000862 RID: 2146
		[global::Cpp2ILInjected.Token(Token = "0x4000AAB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Uri[] m_ScriptProxies;

		// Token: 0x04000863 RID: 2147
		[global::Cpp2ILInjected.Token(Token = "0x4000AAC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private int m_CurrentIndex;

		// Token: 0x04000864 RID: 2148
		[global::Cpp2ILInjected.Token(Token = "0x4000AAD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		private int m_SyncStatus;
	}
}
