using System;
using System.ComponentModel;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000F8 RID: 248
	[global::Cpp2ILInjected.Token(Token = "0x200017C")]
	public class DownloadStringCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060008E4 RID: 2276 RVA: 0x0000477B File Offset: 0x0000297B
		[global::Cpp2ILInjected.Token(Token = "0x60009EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F00480", Offset = "0x1F00480", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		internal DownloadStringCompletedEventArgs(string result, Exception exception, bool cancelled, object userToken)
		{
			throw null;
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x0000477E File Offset: 0x0000297E
		[global::Cpp2ILInjected.Token(Token = "0x170001FA")]
		public string Result
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F070EC", Offset = "0x1F070EC", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = "RaiseExceptionIfNecessary", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00004781 File Offset: 0x00002981
		[global::Cpp2ILInjected.Token(Token = "0x60009F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F08778", Offset = "0x1F08778", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal DownloadStringCompletedEventArgs()
		{
			throw null;
		}

		// Token: 0x0400058E RID: 1422
		[global::Cpp2ILInjected.Token(Token = "0x400079C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly string _result;
	}
}
