using System;
using System.ComponentModel;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000FA RID: 250
	[global::Cpp2ILInjected.Token(Token = "0x200017E")]
	public class UploadStringCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060008EA RID: 2282 RVA: 0x0000478D File Offset: 0x0000298D
		[global::Cpp2ILInjected.Token(Token = "0x60009F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F010A4", Offset = "0x1F010A4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		internal UploadStringCompletedEventArgs(string result, Exception exception, bool cancelled, object userToken)
		{
			throw null;
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x00004790 File Offset: 0x00002990
		[global::Cpp2ILInjected.Token(Token = "0x170001FC")]
		public string Result
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009F6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F071C4", Offset = "0x1F071C4", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = "RaiseExceptionIfNecessary", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00004793 File Offset: 0x00002993
		[global::Cpp2ILInjected.Token(Token = "0x60009F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F087E8", Offset = "0x1F087E8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal UploadStringCompletedEventArgs()
		{
			throw null;
		}

		// Token: 0x04000590 RID: 1424
		[global::Cpp2ILInjected.Token(Token = "0x400079E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly string _result;
	}
}
