using System;
using System.ComponentModel;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000F7 RID: 247
	[global::Cpp2ILInjected.Token(Token = "0x200017B")]
	public class OpenWriteCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060008E1 RID: 2273 RVA: 0x00004772 File Offset: 0x00002972
		[global::Cpp2ILInjected.Token(Token = "0x60009EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F00288", Offset = "0x1F00288", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		internal OpenWriteCompletedEventArgs(Stream result, Exception exception, bool cancelled, object userToken)
		{
			throw null;
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x00004775 File Offset: 0x00002975
		[global::Cpp2ILInjected.Token(Token = "0x170001F9")]
		public Stream Result
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0717C", Offset = "0x1F0717C", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = "RaiseExceptionIfNecessary", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00004778 File Offset: 0x00002978
		[global::Cpp2ILInjected.Token(Token = "0x60009EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F08740", Offset = "0x1F08740", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal OpenWriteCompletedEventArgs()
		{
			throw null;
		}

		// Token: 0x0400058D RID: 1421
		[global::Cpp2ILInjected.Token(Token = "0x400079B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly Stream _result;
	}
}
