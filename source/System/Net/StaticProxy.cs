using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000165 RID: 357
	[global::Cpp2ILInjected.Token(Token = "0x20001FA")]
	internal class StaticProxy : ProxyChain
	{
		// Token: 0x06000B40 RID: 2880 RVA: 0x00004E23 File Offset: 0x00003023
		[global::Cpp2ILInjected.Token(Token = "0x6000C72")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F27EB8", Offset = "0x1F27EB8", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProxyChain), Member = ".ctor", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal StaticProxy(Uri destination, Uri proxy)
		{
			throw null;
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x00004E26 File Offset: 0x00003026
		[global::Cpp2ILInjected.Token(Token = "0x6000C73")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F27F84", Offset = "0x1F27F84", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override bool GetNextProxy(out Uri proxy)
		{
			throw null;
		}

		// Token: 0x04000866 RID: 2150
		[global::Cpp2ILInjected.Token(Token = "0x4000AAF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Uri m_Proxy;
	}
}
