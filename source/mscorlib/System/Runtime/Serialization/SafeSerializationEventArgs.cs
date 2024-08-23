using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	// Token: 0x0200033C RID: 828
	[global::Cpp2ILInjected.Token(Token = "0x20003E4")]
	public sealed class SafeSerializationEventArgs : global::System.EventArgs
	{
		// Token: 0x06001D43 RID: 7491 RVA: 0x000196D3 File Offset: 0x000178D3
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

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06001D44 RID: 7492 RVA: 0x000196D6 File Offset: 0x000178D6
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

		// Token: 0x04000CCE RID: 3278
		[global::Cpp2ILInjected.Token(Token = "0x4000FC0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private StreamingContext m_streamingContext;

		// Token: 0x04000CCF RID: 3279
		[global::Cpp2ILInjected.Token(Token = "0x4000FC1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.Collections.Generic.List<object> m_serializedStates;
	}
}
