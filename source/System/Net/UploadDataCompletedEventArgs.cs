using System;
using System.ComponentModel;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000FB RID: 251
	[global::Cpp2ILInjected.Token(Token = "0x200017F")]
	public class UploadDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060008ED RID: 2285 RVA: 0x00004796 File Offset: 0x00002996
		[global::Cpp2ILInjected.Token(Token = "0x60009F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F01448", Offset = "0x1F01448", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		internal UploadDataCompletedEventArgs(byte[] result, Exception exception, bool cancelled, object userToken)
		{
			throw null;
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x00004799 File Offset: 0x00002999
		[global::Cpp2ILInjected.Token(Token = "0x170001FD")]
		public byte[] Result
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F07268", Offset = "0x1F07268", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = "RaiseExceptionIfNecessary", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x0000479C File Offset: 0x0000299C
		[global::Cpp2ILInjected.Token(Token = "0x60009FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F08820", Offset = "0x1F08820", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal UploadDataCompletedEventArgs()
		{
			throw null;
		}

		// Token: 0x04000591 RID: 1425
		[global::Cpp2ILInjected.Token(Token = "0x400079F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly byte[] _result;
	}
}
