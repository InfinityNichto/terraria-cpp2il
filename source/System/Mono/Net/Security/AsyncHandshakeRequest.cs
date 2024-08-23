using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Net.Security
{
	// Token: 0x02000016 RID: 22
	[global::Cpp2ILInjected.Token(Token = "0x2000051")]
	internal class AsyncHandshakeRequest : AsyncProtocolRequest
	{
		// Token: 0x06000075 RID: 117 RVA: 0x00002F8A File Offset: 0x0000118A
		[global::Cpp2ILInjected.Token(Token = "0x60000DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D48FA8", Offset = "0x1D48FA8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncProtocolRequest), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MobileAuthenticatedStream),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public AsyncHandshakeRequest(MobileAuthenticatedStream parent, bool sync)
		{
			throw null;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002F8D File Offset: 0x0000118D
		[global::Cpp2ILInjected.Token(Token = "0x60000DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D48FB0", Offset = "0x1D48FB0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override AsyncOperationStatus Run(AsyncOperationStatus status)
		{
			throw null;
		}
	}
}
