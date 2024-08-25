using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x2000390")]
	[Serializable]
	public class InvalidAsynchronousStateException : ArgumentException
	{
		[global::Cpp2ILInjected.Token(Token = "0x60017C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4D790", Offset = "0x1E4D790", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public InvalidAsynchronousStateException()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4D79C", Offset = "0x1E4D79C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public InvalidAsynchronousStateException(string message)
		{
			throw null;
		}

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
