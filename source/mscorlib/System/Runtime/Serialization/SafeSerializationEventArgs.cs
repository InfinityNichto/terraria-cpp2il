using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	[global::Cpp2ILInjected.Token(Token = "0x20003E4")]
	public sealed class SafeSerializationEventArgs : global::System.EventArgs
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001F81")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B58A30", Offset = "0x1B58A30", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeSerializationManager), Member = "CompleteSerialization", MemberParameters = new object[]
		{
			typeof(object),
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal SafeSerializationEventArgs(StreamingContext streamingContext)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000432")]
		internal global::System.Collections.Generic.IList<object> SerializedStates
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F82")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B58AE8", Offset = "0x1B58AE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000FC0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private StreamingContext m_streamingContext;

		[global::Cpp2ILInjected.Token(Token = "0x4000FC1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.Collections.Generic.List<object> m_serializedStates;
	}
}
