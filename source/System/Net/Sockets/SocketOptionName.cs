using System;
using Cpp2ILInjected;

namespace System.Net.Sockets
{
	[global::Cpp2ILInjected.Token(Token = "0x2000302")]
	public enum SocketOptionName
	{
		[global::Cpp2ILInjected.Token(Token = "0x4001097")]
		Debug = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4001098")]
		AcceptConnection,
		[global::Cpp2ILInjected.Token(Token = "0x4001099")]
		ReuseAddress = 4,
		[global::Cpp2ILInjected.Token(Token = "0x400109A")]
		KeepAlive = 8,
		[global::Cpp2ILInjected.Token(Token = "0x400109B")]
		DontRoute = 16,
		[global::Cpp2ILInjected.Token(Token = "0x400109C")]
		Broadcast = 32,
		[global::Cpp2ILInjected.Token(Token = "0x400109D")]
		UseLoopback = 64,
		[global::Cpp2ILInjected.Token(Token = "0x400109E")]
		Linger = 128,
		[global::Cpp2ILInjected.Token(Token = "0x400109F")]
		OutOfBandInline = 256,
		[global::Cpp2ILInjected.Token(Token = "0x40010A0")]
		DontLinger = -129,
		[global::Cpp2ILInjected.Token(Token = "0x40010A1")]
		ExclusiveAddressUse = -5,
		[global::Cpp2ILInjected.Token(Token = "0x40010A2")]
		SendBuffer = 4097,
		[global::Cpp2ILInjected.Token(Token = "0x40010A3")]
		ReceiveBuffer,
		[global::Cpp2ILInjected.Token(Token = "0x40010A4")]
		SendLowWater,
		[global::Cpp2ILInjected.Token(Token = "0x40010A5")]
		ReceiveLowWater,
		[global::Cpp2ILInjected.Token(Token = "0x40010A6")]
		SendTimeout,
		[global::Cpp2ILInjected.Token(Token = "0x40010A7")]
		ReceiveTimeout,
		[global::Cpp2ILInjected.Token(Token = "0x40010A8")]
		Error,
		[global::Cpp2ILInjected.Token(Token = "0x40010A9")]
		Type,
		[global::Cpp2ILInjected.Token(Token = "0x40010AA")]
		ReuseUnicastPort = 12295,
		[global::Cpp2ILInjected.Token(Token = "0x40010AB")]
		MaxConnections = 2147483647,
		[global::Cpp2ILInjected.Token(Token = "0x40010AC")]
		IPOptions = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40010AD")]
		HeaderIncluded,
		[global::Cpp2ILInjected.Token(Token = "0x40010AE")]
		TypeOfService,
		[global::Cpp2ILInjected.Token(Token = "0x40010AF")]
		IpTimeToLive,
		[global::Cpp2ILInjected.Token(Token = "0x40010B0")]
		MulticastInterface = 9,
		[global::Cpp2ILInjected.Token(Token = "0x40010B1")]
		MulticastTimeToLive,
		[global::Cpp2ILInjected.Token(Token = "0x40010B2")]
		MulticastLoopback,
		[global::Cpp2ILInjected.Token(Token = "0x40010B3")]
		AddMembership,
		[global::Cpp2ILInjected.Token(Token = "0x40010B4")]
		DropMembership,
		[global::Cpp2ILInjected.Token(Token = "0x40010B5")]
		DontFragment,
		[global::Cpp2ILInjected.Token(Token = "0x40010B6")]
		AddSourceMembership,
		[global::Cpp2ILInjected.Token(Token = "0x40010B7")]
		DropSourceMembership,
		[global::Cpp2ILInjected.Token(Token = "0x40010B8")]
		BlockSource,
		[global::Cpp2ILInjected.Token(Token = "0x40010B9")]
		UnblockSource,
		[global::Cpp2ILInjected.Token(Token = "0x40010BA")]
		PacketInformation,
		[global::Cpp2ILInjected.Token(Token = "0x40010BB")]
		HopLimit = 21,
		[global::Cpp2ILInjected.Token(Token = "0x40010BC")]
		IPProtectionLevel = 23,
		[global::Cpp2ILInjected.Token(Token = "0x40010BD")]
		IPv6Only = 27,
		[global::Cpp2ILInjected.Token(Token = "0x40010BE")]
		NoDelay = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40010BF")]
		BsdUrgent,
		[global::Cpp2ILInjected.Token(Token = "0x40010C0")]
		Expedited = 2,
		[global::Cpp2ILInjected.Token(Token = "0x40010C1")]
		NoChecksum = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40010C2")]
		ChecksumCoverage = 20,
		[global::Cpp2ILInjected.Token(Token = "0x40010C3")]
		UpdateAcceptContext = 28683,
		[global::Cpp2ILInjected.Token(Token = "0x40010C4")]
		UpdateConnectContext = 28688
	}
}
