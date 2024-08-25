using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel.Design
{
	[global::Cpp2ILInjected.Token(Token = "0x2000409")]
	[Serializable]
	public class CheckoutException : ExternalException
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001BFE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8B4F0", Offset = "0x1E8B4F0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExternalException), Member = ".ctor", ReturnType = typeof(void))]
		public CheckoutException()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x400138B")]
		public static readonly CheckoutException Canceled;
	}
}
