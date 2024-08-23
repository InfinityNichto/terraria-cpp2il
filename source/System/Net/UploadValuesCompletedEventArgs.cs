using System;
using System.ComponentModel;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000FD RID: 253
	[global::Cpp2ILInjected.Token(Token = "0x2000181")]
	public class UploadValuesCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060008F3 RID: 2291 RVA: 0x000047A8 File Offset: 0x000029A8
		[global::Cpp2ILInjected.Token(Token = "0x60009FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F01BDC", Offset = "0x1F01BDC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		internal UploadValuesCompletedEventArgs(byte[] result, Exception exception, bool cancelled, object userToken)
		{
			throw null;
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x000047AB File Offset: 0x000029AB
		[global::Cpp2ILInjected.Token(Token = "0x170001FF")]
		public byte[] Result
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F072F8", Offset = "0x1F072F8", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = "RaiseExceptionIfNecessary", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x000047AE File Offset: 0x000029AE
		[global::Cpp2ILInjected.Token(Token = "0x6000A00")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F08890", Offset = "0x1F08890", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal UploadValuesCompletedEventArgs()
		{
			throw null;
		}

		// Token: 0x04000593 RID: 1427
		[global::Cpp2ILInjected.Token(Token = "0x40007A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly byte[] _result;
	}
}
