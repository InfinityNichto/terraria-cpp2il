using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Net.Security
{
	// Token: 0x02000018 RID: 24
	[global::Cpp2ILInjected.Token(Token = "0x2000053")]
	internal class AsyncReadRequest : AsyncReadOrWriteRequest
	{
		// Token: 0x0600007C RID: 124 RVA: 0x00002F9F File Offset: 0x0000119F
		[global::Cpp2ILInjected.Token(Token = "0x60000E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D49478", Offset = "0x1D49478", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncReadOrWriteRequest), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MobileAuthenticatedStream),
			typeof(bool),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public AsyncReadRequest(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size)
		{
			throw null;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002FA2 File Offset: 0x000011A2
		[global::Cpp2ILInjected.Token(Token = "0x60000E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D49480", Offset = "0x1D49480", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "ProcessRead", MemberParameters = new object[] { typeof(BufferOffsetSize) }, ReturnType = typeof(ValueTuple<int, bool>))]
		protected override AsyncOperationStatus Run(AsyncOperationStatus status)
		{
			throw null;
		}
	}
}
