using System;
using System.IO;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	[global::Cpp2ILInjected.Token(Token = "0x2000429")]
	internal sealed class InternalFE
	{
		[global::Cpp2ILInjected.Token(Token = "0x600213C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6F3F4", Offset = "0x1B6F3F4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryFormatter), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(global::System.Runtime.Remoting.Messaging.HeaderHandler),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryFormatter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(object),
			typeof(global::System.Runtime.Remoting.Messaging.Header[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public InternalFE()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40011BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal FormatterTypeStyle FEtypeFormat;

		[global::Cpp2ILInjected.Token(Token = "0x40011BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal FormatterAssemblyStyle FEassemblyFormat;

		[global::Cpp2ILInjected.Token(Token = "0x40011C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal TypeFilterLevel FEsecurityLevel;

		[global::Cpp2ILInjected.Token(Token = "0x40011C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		internal InternalSerializerTypeE FEserializerTypeEnum;
	}
}
