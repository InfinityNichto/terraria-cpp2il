using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000299 RID: 665
	[global::Cpp2ILInjected.Token(Token = "0x2000390")]
	[Serializable]
	public class InvalidAsynchronousStateException : ArgumentException
	{
		// Token: 0x06001575 RID: 5493 RVA: 0x00006AA0 File Offset: 0x00004CA0
		[global::Cpp2ILInjected.Token(Token = "0x60017C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4D790", Offset = "0x1E4D790", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public InvalidAsynchronousStateException()
		{
			throw null;
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x00006AA3 File Offset: 0x00004CA3
		[global::Cpp2ILInjected.Token(Token = "0x60017C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4D79C", Offset = "0x1E4D79C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public InvalidAsynchronousStateException(string message)
		{
			throw null;
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x00006AA6 File Offset: 0x00004CA6
		[global::Cpp2ILInjected.Token(Token = "0x60017C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4D7A4", Offset = "0x1E4D7A4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		public InvalidAsynchronousStateException(string message, Exception innerException)
		{
			throw null;
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x00006AA9 File Offset: 0x00004CA9
		[global::Cpp2ILInjected.Token(Token = "0x60017C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4D7AC", Offset = "0x1E4D7AC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		protected InvalidAsynchronousStateException(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}
	}
}
