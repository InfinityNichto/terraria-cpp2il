using System;
using System.Collections;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	[global::Cpp2ILInjected.Token(Token = "0x200041B")]
	internal sealed class SerObjectInfoInit
	{
		[global::Cpp2ILInjected.Token(Token = "0x60020A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B651FC", Offset = "0x1B651FC", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.Remoting.Messaging.Header[]),
			typeof(__BinaryWriter),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerStack), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public SerObjectInfoInit()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400112F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal global::System.Collections.Hashtable seenBeforeTable;

		[global::Cpp2ILInjected.Token(Token = "0x4001130")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal int objectInfoIdCount;

		[global::Cpp2ILInjected.Token(Token = "0x4001131")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal SerStack oiPool;
	}
}
