using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Telepathy;

namespace Terraria
{
	[global::Cpp2ILInjected.Token(Token = "0x200044B")]
	public class RemoteServer
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002965")]
		[global::Cpp2ILInjected.Address(RVA = "0x115ADB0", Offset = "0x115ADB0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Server), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public RemoteServer()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003678")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Server Client;

		[global::Cpp2ILInjected.Token(Token = "0x4003679")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public bool IsActive;

		[global::Cpp2ILInjected.Token(Token = "0x400367A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int State;

		[global::Cpp2ILInjected.Token(Token = "0x400367B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int TimeOutTimer;

		[global::Cpp2ILInjected.Token(Token = "0x400367C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public string StatusText;

		[global::Cpp2ILInjected.Token(Token = "0x400367D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public int StatusCount;

		[global::Cpp2ILInjected.Token(Token = "0x400367E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public int StatusMax;
	}
}
