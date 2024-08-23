using System;
using Cpp2ILInjected;

namespace System.Net.Sockets
{
	// Token: 0x02000210 RID: 528
	[global::Cpp2ILInjected.Token(Token = "0x20002FF")]
	public enum SocketError
	{
		// Token: 0x04000C5D RID: 3165
		[global::Cpp2ILInjected.Token(Token = "0x4001056")]
		Success,
		// Token: 0x04000C5E RID: 3166
		[global::Cpp2ILInjected.Token(Token = "0x4001057")]
		SocketError = -1,
		// Token: 0x04000C5F RID: 3167
		[global::Cpp2ILInjected.Token(Token = "0x4001058")]
		Interrupted = 10004,
		// Token: 0x04000C60 RID: 3168
		[global::Cpp2ILInjected.Token(Token = "0x4001059")]
		AccessDenied = 10013,
		// Token: 0x04000C61 RID: 3169
		[global::Cpp2ILInjected.Token(Token = "0x400105A")]
		Fault,
		// Token: 0x04000C62 RID: 3170
		[global::Cpp2ILInjected.Token(Token = "0x400105B")]
		InvalidArgument = 10022,
		// Token: 0x04000C63 RID: 3171
		[global::Cpp2ILInjected.Token(Token = "0x400105C")]
		TooManyOpenSockets = 10024,
		// Token: 0x04000C64 RID: 3172
		[global::Cpp2ILInjected.Token(Token = "0x400105D")]
		WouldBlock = 10035,
		// Token: 0x04000C65 RID: 3173
		[global::Cpp2ILInjected.Token(Token = "0x400105E")]
		InProgress,
		// Token: 0x04000C66 RID: 3174
		[global::Cpp2ILInjected.Token(Token = "0x400105F")]
		AlreadyInProgress,
		// Token: 0x04000C67 RID: 3175
		[global::Cpp2ILInjected.Token(Token = "0x4001060")]
		NotSocket,
		// Token: 0x04000C68 RID: 3176
		[global::Cpp2ILInjected.Token(Token = "0x4001061")]
		DestinationAddressRequired,
		// Token: 0x04000C69 RID: 3177
		[global::Cpp2ILInjected.Token(Token = "0x4001062")]
		MessageSize,
		// Token: 0x04000C6A RID: 3178
		[global::Cpp2ILInjected.Token(Token = "0x4001063")]
		ProtocolType,
		// Token: 0x04000C6B RID: 3179
		[global::Cpp2ILInjected.Token(Token = "0x4001064")]
		ProtocolOption,
		// Token: 0x04000C6C RID: 3180
		[global::Cpp2ILInjected.Token(Token = "0x4001065")]
		ProtocolNotSupported,
		// Token: 0x04000C6D RID: 3181
		[global::Cpp2ILInjected.Token(Token = "0x4001066")]
		SocketNotSupported,
		// Token: 0x04000C6E RID: 3182
		[global::Cpp2ILInjected.Token(Token = "0x4001067")]
		OperationNotSupported,
		// Token: 0x04000C6F RID: 3183
		[global::Cpp2ILInjected.Token(Token = "0x4001068")]
		ProtocolFamilyNotSupported,
		// Token: 0x04000C70 RID: 3184
		[global::Cpp2ILInjected.Token(Token = "0x4001069")]
		AddressFamilyNotSupported,
		// Token: 0x04000C71 RID: 3185
		[global::Cpp2ILInjected.Token(Token = "0x400106A")]
		AddressAlreadyInUse,
		// Token: 0x04000C72 RID: 3186
		[global::Cpp2ILInjected.Token(Token = "0x400106B")]
		AddressNotAvailable,
		// Token: 0x04000C73 RID: 3187
		[global::Cpp2ILInjected.Token(Token = "0x400106C")]
		NetworkDown,
		// Token: 0x04000C74 RID: 3188
		[global::Cpp2ILInjected.Token(Token = "0x400106D")]
		NetworkUnreachable,
		// Token: 0x04000C75 RID: 3189
		[global::Cpp2ILInjected.Token(Token = "0x400106E")]
		NetworkReset,
		// Token: 0x04000C76 RID: 3190
		[global::Cpp2ILInjected.Token(Token = "0x400106F")]
		ConnectionAborted,
		// Token: 0x04000C77 RID: 3191
		[global::Cpp2ILInjected.Token(Token = "0x4001070")]
		ConnectionReset,
		// Token: 0x04000C78 RID: 3192
		[global::Cpp2ILInjected.Token(Token = "0x4001071")]
		NoBufferSpaceAvailable,
		// Token: 0x04000C79 RID: 3193
		[global::Cpp2ILInjected.Token(Token = "0x4001072")]
		IsConnected,
		// Token: 0x04000C7A RID: 3194
		[global::Cpp2ILInjected.Token(Token = "0x4001073")]
		NotConnected,
		// Token: 0x04000C7B RID: 3195
		[global::Cpp2ILInjected.Token(Token = "0x4001074")]
		Shutdown,
		// Token: 0x04000C7C RID: 3196
		[global::Cpp2ILInjected.Token(Token = "0x4001075")]
		TimedOut = 10060,
		// Token: 0x04000C7D RID: 3197
		[global::Cpp2ILInjected.Token(Token = "0x4001076")]
		ConnectionRefused,
		// Token: 0x04000C7E RID: 3198
		[global::Cpp2ILInjected.Token(Token = "0x4001077")]
		HostDown = 10064,
		// Token: 0x04000C7F RID: 3199
		[global::Cpp2ILInjected.Token(Token = "0x4001078")]
		HostUnreachable,
		// Token: 0x04000C80 RID: 3200
		[global::Cpp2ILInjected.Token(Token = "0x4001079")]
		ProcessLimit = 10067,
		// Token: 0x04000C81 RID: 3201
		[global::Cpp2ILInjected.Token(Token = "0x400107A")]
		SystemNotReady = 10091,
		// Token: 0x04000C82 RID: 3202
		[global::Cpp2ILInjected.Token(Token = "0x400107B")]
		VersionNotSupported,
		// Token: 0x04000C83 RID: 3203
		[global::Cpp2ILInjected.Token(Token = "0x400107C")]
		NotInitialized,
		// Token: 0x04000C84 RID: 3204
		[global::Cpp2ILInjected.Token(Token = "0x400107D")]
		Disconnecting = 10101,
		// Token: 0x04000C85 RID: 3205
		[global::Cpp2ILInjected.Token(Token = "0x400107E")]
		TypeNotFound = 10109,
		// Token: 0x04000C86 RID: 3206
		[global::Cpp2ILInjected.Token(Token = "0x400107F")]
		HostNotFound = 11001,
		// Token: 0x04000C87 RID: 3207
		[global::Cpp2ILInjected.Token(Token = "0x4001080")]
		TryAgain,
		// Token: 0x04000C88 RID: 3208
		[global::Cpp2ILInjected.Token(Token = "0x4001081")]
		NoRecovery,
		// Token: 0x04000C89 RID: 3209
		[global::Cpp2ILInjected.Token(Token = "0x4001082")]
		NoData,
		// Token: 0x04000C8A RID: 3210
		[global::Cpp2ILInjected.Token(Token = "0x4001083")]
		IOPending = 997,
		// Token: 0x04000C8B RID: 3211
		[global::Cpp2ILInjected.Token(Token = "0x4001084")]
		OperationAborted = 995
	}
}
