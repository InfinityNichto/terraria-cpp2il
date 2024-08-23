using System;
using System.ComponentModel;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000F9 RID: 249
	[global::Cpp2ILInjected.Token(Token = "0x200017D")]
	public class DownloadDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060008E7 RID: 2279 RVA: 0x00004784 File Offset: 0x00002984
		[global::Cpp2ILInjected.Token(Token = "0x60009F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F007C8", Offset = "0x1F007C8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		internal DownloadDataCompletedEventArgs(byte[] result, Exception exception, bool cancelled, object userToken)
		{
			throw null;
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x00004787 File Offset: 0x00002987
		[global::Cpp2ILInjected.Token(Token = "0x170001FB")]
		public byte[] Result
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0720C", Offset = "0x1F0720C", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = "RaiseExceptionIfNecessary", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x0000478A File Offset: 0x0000298A
		[global::Cpp2ILInjected.Token(Token = "0x60009F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F087B0", Offset = "0x1F087B0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal DownloadDataCompletedEventArgs()
		{
			throw null;
		}

		// Token: 0x0400058F RID: 1423
		[global::Cpp2ILInjected.Token(Token = "0x400079D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly byte[] _result;
	}
}
