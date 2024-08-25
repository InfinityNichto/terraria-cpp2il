using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20001B1")]
	[StructLayout(0)]
	internal class SecChannelBindings
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000A9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0F7B0", Offset = "0x1F0F7B0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SecChannelBindings()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000903")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int dwInitiatorAddrType;

		[global::Cpp2ILInjected.Token(Token = "0x4000904")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int cbInitiatorLength;

		[global::Cpp2ILInjected.Token(Token = "0x4000905")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal int dwInitiatorOffset;

		[global::Cpp2ILInjected.Token(Token = "0x4000906")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		internal int dwAcceptorAddrType;

		[global::Cpp2ILInjected.Token(Token = "0x4000907")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int cbAcceptorLength;

		[global::Cpp2ILInjected.Token(Token = "0x4000908")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		internal int dwAcceptorOffset;

		[global::Cpp2ILInjected.Token(Token = "0x4000909")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal int cbApplicationDataLength;

		[global::Cpp2ILInjected.Token(Token = "0x400090A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		internal int dwApplicationDataOffset;
	}
}
