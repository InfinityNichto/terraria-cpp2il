using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Net.Security
{
	// Token: 0x02000019 RID: 25
	[global::Cpp2ILInjected.Token(Token = "0x2000054")]
	internal class AsyncWriteRequest : AsyncReadOrWriteRequest
	{
		// Token: 0x0600007E RID: 126 RVA: 0x00002FA5 File Offset: 0x000011A5
		[global::Cpp2ILInjected.Token(Token = "0x60000E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D49624", Offset = "0x1D49624", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncReadOrWriteRequest), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MobileAuthenticatedStream),
			typeof(bool),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public AsyncWriteRequest(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size)
		{
			throw null;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002FA8 File Offset: 0x000011A8
		[global::Cpp2ILInjected.Token(Token = "0x60000E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4962C", Offset = "0x1D4962C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "ProcessWrite", MemberParameters = new object[] { typeof(BufferOffsetSize) }, ReturnType = typeof(ValueTuple<int, bool>))]
		protected override AsyncOperationStatus Run(AsyncOperationStatus status)
		{
			throw null;
		}
	}
}
