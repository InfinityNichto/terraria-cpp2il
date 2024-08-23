using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	// Token: 0x020001E9 RID: 489
	[global::Cpp2ILInjected.Token(Token = "0x200026E")]
	[global::System.Serializable]
	public sealed class EncoderFallbackException : global::System.ArgumentException
	{
		// Token: 0x06001337 RID: 4919 RVA: 0x00017AEF File Offset: 0x00015CEF
		[global::Cpp2ILInjected.Token(Token = "0x60014F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB4F54", Offset = "0x1CB4F54", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public EncoderFallbackException()
		{
			throw null;
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x00017AF2 File Offset: 0x00015CF2
		[global::Cpp2ILInjected.Token(Token = "0x60014F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB4ACC", Offset = "0x1CB4ACC", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EncoderExceptionFallbackBuffer), Member = "Fallback", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		internal EncoderFallbackException(string message, char charUnknown, int index)
		{
			throw null;
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x00017AF5 File Offset: 0x00015CF5
		[global::Cpp2ILInjected.Token(Token = "0x60014F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB4D4C", Offset = "0x1CB4D4C", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EncoderExceptionFallbackBuffer), Member = "Fallback", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsHighSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsLowSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		internal EncoderFallbackException(string message, char charUnknownHigh, char charUnknownLow, int index)
		{
			throw null;
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x00017AF8 File Offset: 0x00015CF8
		[global::Cpp2ILInjected.Token(Token = "0x60014F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB4FB0", Offset = "0x1CB4FB0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		private EncoderFallbackException(global::System.Runtime.Serialization.SerializationInfo serializationInfo, global::System.Runtime.Serialization.StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x04000899 RID: 2201
		[global::Cpp2ILInjected.Token(Token = "0x4000B05")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private char _charUnknown;

		// Token: 0x0400089A RID: 2202
		[global::Cpp2ILInjected.Token(Token = "0x4000B06")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9A")]
		private char _charUnknownHigh;

		// Token: 0x0400089B RID: 2203
		[global::Cpp2ILInjected.Token(Token = "0x4000B07")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		private char _charUnknownLow;

		// Token: 0x0400089C RID: 2204
		[global::Cpp2ILInjected.Token(Token = "0x4000B08")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private int _index;
	}
}
