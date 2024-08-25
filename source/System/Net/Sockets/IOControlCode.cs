using System;
using Cpp2ILInjected;

namespace System.Net.Sockets
{
	[global::Cpp2ILInjected.Token(Token = "0x20002F8")]
	public enum IOControlCode : long
	{
		[global::Cpp2ILInjected.Token(Token = "0x4001003")]
		AsyncIO = 2147772029L,
		[global::Cpp2ILInjected.Token(Token = "0x4001004")]
		NonBlockingIO,
		[global::Cpp2ILInjected.Token(Token = "0x4001005")]
		DataToRead = 1074030207L,
		[global::Cpp2ILInjected.Token(Token = "0x4001006")]
		OobDataRead = 1074033415L,
		[global::Cpp2ILInjected.Token(Token = "0x4001007")]
		AssociateHandle = 2281701377L,
		[global::Cpp2ILInjected.Token(Token = "0x4001008")]
		EnableCircularQueuing = 671088642L,
		[global::Cpp2ILInjected.Token(Token = "0x4001009")]
		Flush = 671088644L,
		[global::Cpp2ILInjected.Token(Token = "0x400100A")]
		GetBroadcastAddress = 1207959557L,
		[global::Cpp2ILInjected.Token(Token = "0x400100B")]
		GetExtensionFunctionPointer = 3355443206L,
		[global::Cpp2ILInjected.Token(Token = "0x400100C")]
		GetQos,
		[global::Cpp2ILInjected.Token(Token = "0x400100D")]
		GetGroupQos,
		[global::Cpp2ILInjected.Token(Token = "0x400100E")]
		MultipointLoopback = 2281701385L,
		[global::Cpp2ILInjected.Token(Token = "0x400100F")]
		MulticastScope,
		[global::Cpp2ILInjected.Token(Token = "0x4001010")]
		SetQos,
		[global::Cpp2ILInjected.Token(Token = "0x4001011")]
		SetGroupQos,
		[global::Cpp2ILInjected.Token(Token = "0x4001012")]
		TranslateHandle = 3355443213L,
		[global::Cpp2ILInjected.Token(Token = "0x4001013")]
		RoutingInterfaceQuery = 3355443220L,
		[global::Cpp2ILInjected.Token(Token = "0x4001014")]
		RoutingInterfaceChange = 2281701397L,
		[global::Cpp2ILInjected.Token(Token = "0x4001015")]
		AddressListQuery = 1207959574L,
		[global::Cpp2ILInjected.Token(Token = "0x4001016")]
		AddressListChange = 671088663L,
		[global::Cpp2ILInjected.Token(Token = "0x4001017")]
		QueryTargetPnpHandle = 1207959576L,
		[global::Cpp2ILInjected.Token(Token = "0x4001018")]
		NamespaceChange = 2281701401L,
		[global::Cpp2ILInjected.Token(Token = "0x4001019")]
		AddressListSort = 3355443225L,
		[global::Cpp2ILInjected.Token(Token = "0x400101A")]
		ReceiveAll = 2550136833L,
		[global::Cpp2ILInjected.Token(Token = "0x400101B")]
		ReceiveAllMulticast,
		[global::Cpp2ILInjected.Token(Token = "0x400101C")]
		ReceiveAllIgmpMulticast,
		[global::Cpp2ILInjected.Token(Token = "0x400101D")]
		KeepAliveValues,
		[global::Cpp2ILInjected.Token(Token = "0x400101E")]
		AbsorbRouterAlert,
		[global::Cpp2ILInjected.Token(Token = "0x400101F")]
		UnicastInterface,
		[global::Cpp2ILInjected.Token(Token = "0x4001020")]
		LimitBroadcasts,
		[global::Cpp2ILInjected.Token(Token = "0x4001021")]
		BindToInterface,
		[global::Cpp2ILInjected.Token(Token = "0x4001022")]
		MulticastInterface,
		[global::Cpp2ILInjected.Token(Token = "0x4001023")]
		AddMulticastGroupOnInterface,
		[global::Cpp2ILInjected.Token(Token = "0x4001024")]
		DeleteMulticastGroupFromInterface
	}
}
