using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	// Token: 0x020001DE RID: 478
	[global::Cpp2ILInjected.Token(Token = "0x2000263")]
	[global::System.Serializable]
	public sealed class DecoderFallbackException : global::System.ArgumentException
	{
		// Token: 0x060012E5 RID: 4837 RVA: 0x00017A0E File Offset: 0x00015C0E
		[global::Cpp2ILInjected.Token(Token = "0x600149F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB2434", Offset = "0x1CB2434", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public DecoderFallbackException()
		{
			throw null;
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x00017A11 File Offset: 0x00015C11
		[global::Cpp2ILInjected.Token(Token = "0x60014A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB2404", Offset = "0x1CB2404", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DecoderExceptionFallbackBuffer), Member = "Throw", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public DecoderFallbackException(string message, byte[] bytesUnknown, int index)
		{
			throw null;
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00017A14 File Offset: 0x00015C14
		[global::Cpp2ILInjected.Token(Token = "0x60014A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB2490", Offset = "0x1CB2490", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		private DecoderFallbackException(global::System.Runtime.Serialization.SerializationInfo serializationInfo, global::System.Runtime.Serialization.StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x04000882 RID: 2178
		[global::Cpp2ILInjected.Token(Token = "0x4000AEE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private byte[] _bytesUnknown;

		// Token: 0x04000883 RID: 2179
		[global::Cpp2ILInjected.Token(Token = "0x4000AEF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private int _index;
	}
}
