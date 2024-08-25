using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20001F9")]
	internal class DirectProxy : ProxyChain
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C70")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F27E90", Offset = "0x1F27E90", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProxyChain), Member = ".ctor", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		internal DirectProxy(Uri destination)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C71")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F27E94", Offset = "0x1F27E94", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override bool GetNextProxy(out Uri proxy)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000AAE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private bool m_ProxyRetrieved;
	}
}
