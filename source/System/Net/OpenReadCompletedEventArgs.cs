using System;
using System.ComponentModel;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000F6 RID: 246
	[global::Cpp2ILInjected.Token(Token = "0x200017A")]
	public class OpenReadCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060008DE RID: 2270 RVA: 0x00004769 File Offset: 0x00002969
		[global::Cpp2ILInjected.Token(Token = "0x60009E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EFFF84", Offset = "0x1EFFF84", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		internal OpenReadCompletedEventArgs(Stream result, Exception exception, bool cancelled, object userToken)
		{
			throw null;
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x0000476C File Offset: 0x0000296C
		[global::Cpp2ILInjected.Token(Token = "0x170001F8")]
		public Stream Result
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F07134", Offset = "0x1F07134", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCompletedEventArgs), Member = "RaiseExceptionIfNecessary", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0000476F File Offset: 0x0000296F
		[global::Cpp2ILInjected.Token(Token = "0x60009EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F08708", Offset = "0x1F08708", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal OpenReadCompletedEventArgs()
		{
			throw null;
		}

		// Token: 0x0400058C RID: 1420
		[global::Cpp2ILInjected.Token(Token = "0x400079A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly Stream _result;
	}
}
