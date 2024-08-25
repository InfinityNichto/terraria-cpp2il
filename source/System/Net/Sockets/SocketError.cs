using System;
using Cpp2ILInjected;

namespace System.Net.Sockets
{
	[global::Cpp2ILInjected.Token(Token = "0x20002FF")]
	public enum SocketError
	{
		[global::Cpp2ILInjected.Token(Token = "0x4001056")]
		Success,
		[global::Cpp2ILInjected.Token(Token = "0x4001057")]
		SocketError = -1,
		[global::Cpp2ILInjected.Token(Token = "0x4001058")]
		Interrupted = 10004,
		[global::Cpp2ILInjected.Token(Token = "0x4001059")]
		AccessDenied = 10013,
		[global::Cpp2ILInjected.Token(Token = "0x400105A")]
		Fault,
		[global::Cpp2ILInjected.Token(Token = "0x400105B")]
		InvalidArgument = 10022,
		[global::Cpp2ILInjected.Token(Token = "0x400105C")]
		TooManyOpenSockets = 10024,
		[global::Cpp2ILInjected.Token(Token = "0x400105D")]
		WouldBlock = 10035,
		[global::Cpp2ILInjected.Token(Token = "0x400105E")]
		InProgress,
		[global::Cpp2ILInjected.Token(Token = "0x400105F")]
		AlreadyInProgress,
		[global::Cpp2ILInjected.Token(Token = "0x4001060")]
		NotSocket,
		[global::Cpp2ILInjected.Token(Token = "0x4001061")]
		DestinationAddressRequired,
		[global::Cpp2ILInjected.Token(Token = "0x4001062")]
		MessageSize,
		[global::Cpp2ILInjected.Token(Token = "0x4001063")]
		ProtocolType,
		[global::Cpp2ILInjected.Token(Token = "0x4001064")]
		ProtocolOption,
		[global::Cpp2ILInjected.Token(Token = "0x4001065")]
		ProtocolNotSupported,
		[global::Cpp2ILInjected.Token(Token = "0x4001066")]
		SocketNotSupported,
		[global::Cpp2ILInjected.Token(Token = "0x4001067")]
		OperationNotSupported,
		[global::Cpp2ILInjected.Token(Token = "0x4001068")]
		ProtocolFamilyNotSupported,
		[global::Cpp2ILInjected.Token(Token = "0x4001069")]
		AddressFamilyNotSupported,
		[global::Cpp2ILInjected.Token(Token = "0x400106A")]
		AddressAlreadyInUse,
		[global::Cpp2ILInjected.Token(Token = "0x400106B")]
		AddressNotAvailable,
		[global::Cpp2ILInjected.Token(Token = "0x400106C")]
		NetworkDown,
		[global::Cpp2ILInjected.Token(Token = "0x400106D")]
		NetworkUnreachable,
		[global::Cpp2ILInjected.Token(Token = "0x400106E")]
		NetworkReset,
		[global::Cpp2ILInjected.Token(Token = "0x400106F")]
		ConnectionAborted,
		[global::Cpp2ILInjected.Token(Token = "0x4001070")]
		ConnectionReset,
		[global::Cpp2ILInjected.Token(Token = "0x4001071")]
		NoBufferSpaceAvailable,
		[global::Cpp2ILInjected.Token(Token = "0x4001072")]
		IsConnected,
		[global::Cpp2ILInjected.Token(Token = "0x4001073")]
		NotConnected,
		[global::Cpp2ILInjected.Token(Token = "0x4001074")]
		Shutdown,
		[global::Cpp2ILInjected.Token(Token = "0x4001075")]
		TimedOut = 10060,
		[global::Cpp2ILInjected.Token(Token = "0x4001076")]
		ConnectionRefused,
		[global::Cpp2ILInjected.Token(Token = "0x4001077")]
		HostDown = 10064,
		[global::Cpp2ILInjected.Token(Token = "0x4001078")]
		HostUnreachable,
		[global::Cpp2ILInjected.Token(Token = "0x4001079")]
		ProcessLimit = 10067,
		[global::Cpp2ILInjected.Token(Token = "0x400107A")]
		SystemNotReady = 10091,
		[global::Cpp2ILInjected.Token(Token = "0x400107B")]
		VersionNotSupported,
		[global::Cpp2ILInjected.Token(Token = "0x400107C")]
		NotInitialized,
		[global::Cpp2ILInjected.Token(Token = "0x400107D")]
		Disconnecting = 10101,
		[global::Cpp2ILInjected.Token(Token = "0x400107E")]
		TypeNotFound = 10109,
		[global::Cpp2ILInjected.Token(Token = "0x400107F")]
		HostNotFound = 11001,
		[global::Cpp2ILInjected.Token(Token = "0x4001080")]
		TryAgain,
		[global::Cpp2ILInjected.Token(Token = "0x4001081")]
		NoRecovery,
		[global::Cpp2ILInjected.Token(Token = "0x4001082")]
		NoData,
		[global::Cpp2ILInjected.Token(Token = "0x4001083")]
		IOPending = 997,
		[global::Cpp2ILInjected.Token(Token = "0x4001084")]
		OperationAborted = 995
	}
}
