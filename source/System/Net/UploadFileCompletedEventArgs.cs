using System;
using System.ComponentModel;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000FC RID: 252
	[global::Cpp2ILInjected.Token(Token = "0x2000180")]
	public class UploadFileCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060008F0 RID: 2288 RVA: 0x0000479F File Offset: 0x0000299F
		[global::Cpp2ILInjected.Token(Token = "0x60009FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0182C", Offset = "0x1F0182C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		internal UploadFileCompletedEventArgs(byte[] result, Exception exception, bool cancelled, object userToken)
		{
			throw null;
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x000047A2 File Offset: 0x000029A2
		[global::Cpp2ILInjected.Token(Token = "0x170001FE")]
		public byte[] Result
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F072B0", Offset = "0x1F072B0", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = "RaiseExceptionIfNecessary", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x000047A5 File Offset: 0x000029A5
		[global::Cpp2ILInjected.Token(Token = "0x60009FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F08858", Offset = "0x1F08858", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal UploadFileCompletedEventArgs()
		{
			throw null;
		}

		// Token: 0x04000592 RID: 1426
		[global::Cpp2ILInjected.Token(Token = "0x40007A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly byte[] _result;
	}
}
