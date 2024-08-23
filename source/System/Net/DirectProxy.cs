using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000164 RID: 356
	[global::Cpp2ILInjected.Token(Token = "0x20001F9")]
	internal class DirectProxy : ProxyChain
	{
		// Token: 0x06000B3E RID: 2878 RVA: 0x00004E1D File Offset: 0x0000301D
		[global::Cpp2ILInjected.Token(Token = "0x6000C70")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F27E90", Offset = "0x1F27E90", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProxyChain), Member = ".ctor", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		internal DirectProxy(Uri destination)
		{
			throw null;
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x00004E20 File Offset: 0x00003020
		[global::Cpp2ILInjected.Token(Token = "0x6000C71")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F27E94", Offset = "0x1F27E94", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override bool GetNextProxy(out Uri proxy)
		{
			throw null;
		}

		// Token: 0x04000865 RID: 2149
		[global::Cpp2ILInjected.Token(Token = "0x4000AAE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private bool m_ProxyRetrieved;
	}
}
