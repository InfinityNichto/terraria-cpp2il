using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Telepathy;
using Terraria.Net;

namespace Terraria
{
	[global::Cpp2ILInjected.Token(Token = "0x200044A")]
	public class RemoteConnection
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002964")]
		[global::Cpp2ILInjected.Address(RVA = "0x115AD50", Offset = "0x115AD50", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "ClientLoopSetup", MemberParameters = new object[] { typeof(RemoteAddress) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Client), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public RemoteConnection()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003671")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Client Client;

		[global::Cpp2ILInjected.Token(Token = "0x4003672")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public bool IsActive;

		[global::Cpp2ILInjected.Token(Token = "0x4003673")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int State;

		[global::Cpp2ILInjected.Token(Token = "0x4003674")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int TimeOutTimer;

		[global::Cpp2ILInjected.Token(Token = "0x4003675")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public string StatusText;

		[global::Cpp2ILInjected.Token(Token = "0x4003676")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public int StatusCount;

		[global::Cpp2ILInjected.Token(Token = "0x4003677")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public int StatusMax;
	}
}
