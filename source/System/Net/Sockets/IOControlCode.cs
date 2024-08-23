using System;
using Cpp2ILInjected;

namespace System.Net.Sockets
{
	// Token: 0x02000209 RID: 521
	[global::Cpp2ILInjected.Token(Token = "0x20002F8")]
	public enum IOControlCode : long
	{
		// Token: 0x04000C0A RID: 3082
		[global::Cpp2ILInjected.Token(Token = "0x4001003")]
		AsyncIO = 2147772029L,
		// Token: 0x04000C0B RID: 3083
		[global::Cpp2ILInjected.Token(Token = "0x4001004")]
		NonBlockingIO,
		// Token: 0x04000C0C RID: 3084
		[global::Cpp2ILInjected.Token(Token = "0x4001005")]
		DataToRead = 1074030207L,
		// Token: 0x04000C0D RID: 3085
		[global::Cpp2ILInjected.Token(Token = "0x4001006")]
		OobDataRead = 1074033415L,
		// Token: 0x04000C0E RID: 3086
		[global::Cpp2ILInjected.Token(Token = "0x4001007")]
		AssociateHandle = 2281701377L,
		// Token: 0x04000C0F RID: 3087
		[global::Cpp2ILInjected.Token(Token = "0x4001008")]
		EnableCircularQueuing = 671088642L,
		// Token: 0x04000C10 RID: 3088
		[global::Cpp2ILInjected.Token(Token = "0x4001009")]
		Flush = 671088644L,
		// Token: 0x04000C11 RID: 3089
		[global::Cpp2ILInjected.Token(Token = "0x400100A")]
		GetBroadcastAddress = 1207959557L,
		// Token: 0x04000C12 RID: 3090
		[global::Cpp2ILInjected.Token(Token = "0x400100B")]
		GetExtensionFunctionPointer = 3355443206L,
		// Token: 0x04000C13 RID: 3091
		[global::Cpp2ILInjected.Token(Token = "0x400100C")]
		GetQos,
		// Token: 0x04000C14 RID: 3092
		[global::Cpp2ILInjected.Token(Token = "0x400100D")]
		GetGroupQos,
		// Token: 0x04000C15 RID: 3093
		[global::Cpp2ILInjected.Token(Token = "0x400100E")]
		MultipointLoopback = 2281701385L,
		// Token: 0x04000C16 RID: 3094
		[global::Cpp2ILInjected.Token(Token = "0x400100F")]
		MulticastScope,
		// Token: 0x04000C17 RID: 3095
		[global::Cpp2ILInjected.Token(Token = "0x4001010")]
		SetQos,
		// Token: 0x04000C18 RID: 3096
		[global::Cpp2ILInjected.Token(Token = "0x4001011")]
		SetGroupQos,
		// Token: 0x04000C19 RID: 3097
		[global::Cpp2ILInjected.Token(Token = "0x4001012")]
		TranslateHandle = 3355443213L,
		// Token: 0x04000C1A RID: 3098
		[global::Cpp2ILInjected.Token(Token = "0x4001013")]
		RoutingInterfaceQuery = 3355443220L,
		// Token: 0x04000C1B RID: 3099
		[global::Cpp2ILInjected.Token(Token = "0x4001014")]
		RoutingInterfaceChange = 2281701397L,
		// Token: 0x04000C1C RID: 3100
		[global::Cpp2ILInjected.Token(Token = "0x4001015")]
		AddressListQuery = 1207959574L,
		// Token: 0x04000C1D RID: 3101
		[global::Cpp2ILInjected.Token(Token = "0x4001016")]
		AddressListChange = 671088663L,
		// Token: 0x04000C1E RID: 3102
		[global::Cpp2ILInjected.Token(Token = "0x4001017")]
		QueryTargetPnpHandle = 1207959576L,
		// Token: 0x04000C1F RID: 3103
		[global::Cpp2ILInjected.Token(Token = "0x4001018")]
		NamespaceChange = 2281701401L,
		// Token: 0x04000C20 RID: 3104
		[global::Cpp2ILInjected.Token(Token = "0x4001019")]
		AddressListSort = 3355443225L,
		// Token: 0x04000C21 RID: 3105
		[global::Cpp2ILInjected.Token(Token = "0x400101A")]
		ReceiveAll = 2550136833L,
		// Token: 0x04000C22 RID: 3106
		[global::Cpp2ILInjected.Token(Token = "0x400101B")]
		ReceiveAllMulticast,
		// Token: 0x04000C23 RID: 3107
		[global::Cpp2ILInjected.Token(Token = "0x400101C")]
		ReceiveAllIgmpMulticast,
		// Token: 0x04000C24 RID: 3108
		[global::Cpp2ILInjected.Token(Token = "0x400101D")]
		KeepAliveValues,
		// Token: 0x04000C25 RID: 3109
		[global::Cpp2ILInjected.Token(Token = "0x400101E")]
		AbsorbRouterAlert,
		// Token: 0x04000C26 RID: 3110
		[global::Cpp2ILInjected.Token(Token = "0x400101F")]
		UnicastInterface,
		// Token: 0x04000C27 RID: 3111
		[global::Cpp2ILInjected.Token(Token = "0x4001020")]
		LimitBroadcasts,
		// Token: 0x04000C28 RID: 3112
		[global::Cpp2ILInjected.Token(Token = "0x4001021")]
		BindToInterface,
		// Token: 0x04000C29 RID: 3113
		[global::Cpp2ILInjected.Token(Token = "0x4001022")]
		MulticastInterface,
		// Token: 0x04000C2A RID: 3114
		[global::Cpp2ILInjected.Token(Token = "0x4001023")]
		AddMulticastGroupOnInterface,
		// Token: 0x04000C2B RID: 3115
		[global::Cpp2ILInjected.Token(Token = "0x4001024")]
		DeleteMulticastGroupFromInterface
	}
}
