using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel.Design
{
	// Token: 0x020002F6 RID: 758
	[global::Cpp2ILInjected.Token(Token = "0x2000409")]
	[Serializable]
	public class CheckoutException : ExternalException
	{
		// Token: 0x06001920 RID: 6432 RVA: 0x000074EA File Offset: 0x000056EA
		[global::Cpp2ILInjected.Token(Token = "0x6001BFE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8B4F0", Offset = "0x1E8B4F0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExternalException), Member = ".ctor", ReturnType = typeof(void))]
		public CheckoutException()
		{
			throw null;
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x000074ED File Offset: 0x000056ED
		[global::Cpp2ILInjected.Token(Token = "0x6001BFF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8B4F8", Offset = "0x1E8B4F8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExternalException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		public CheckoutException(string message, int errorCode)
		{
			throw null;
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x000074F0 File Offset: 0x000056F0
		[global::Cpp2ILInjected.Token(Token = "0x6001C00")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8B500", Offset = "0x1E8B500", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExternalException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		protected CheckoutException(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x000074F3 File Offset: 0x000056F3
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001C01")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8B508", Offset = "0x1E8B508", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExternalException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static CheckoutException()
		{
			throw null;
		}

		// Token: 0x04000F4A RID: 3914
		[global::Cpp2ILInjected.Token(Token = "0x400138B")]
		public static readonly CheckoutException Canceled;
	}
}
