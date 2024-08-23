using System;
using Cpp2ILInjected;

namespace System.Net.Sockets
{
	// Token: 0x02000213 RID: 531
	[global::Cpp2ILInjected.Token(Token = "0x2000302")]
	public enum SocketOptionName
	{
		// Token: 0x04000C9E RID: 3230
		[global::Cpp2ILInjected.Token(Token = "0x4001097")]
		Debug = 1,
		// Token: 0x04000C9F RID: 3231
		[global::Cpp2ILInjected.Token(Token = "0x4001098")]
		AcceptConnection,
		// Token: 0x04000CA0 RID: 3232
		[global::Cpp2ILInjected.Token(Token = "0x4001099")]
		ReuseAddress = 4,
		// Token: 0x04000CA1 RID: 3233
		[global::Cpp2ILInjected.Token(Token = "0x400109A")]
		KeepAlive = 8,
		// Token: 0x04000CA2 RID: 3234
		[global::Cpp2ILInjected.Token(Token = "0x400109B")]
		DontRoute = 16,
		// Token: 0x04000CA3 RID: 3235
		[global::Cpp2ILInjected.Token(Token = "0x400109C")]
		Broadcast = 32,
		// Token: 0x04000CA4 RID: 3236
		[global::Cpp2ILInjected.Token(Token = "0x400109D")]
		UseLoopback = 64,
		// Token: 0x04000CA5 RID: 3237
		[global::Cpp2ILInjected.Token(Token = "0x400109E")]
		Linger = 128,
		// Token: 0x04000CA6 RID: 3238
		[global::Cpp2ILInjected.Token(Token = "0x400109F")]
		OutOfBandInline = 256,
		// Token: 0x04000CA7 RID: 3239
		[global::Cpp2ILInjected.Token(Token = "0x40010A0")]
		DontLinger = -129,
		// Token: 0x04000CA8 RID: 3240
		[global::Cpp2ILInjected.Token(Token = "0x40010A1")]
		ExclusiveAddressUse = -5,
		// Token: 0x04000CA9 RID: 3241
		[global::Cpp2ILInjected.Token(Token = "0x40010A2")]
		SendBuffer = 4097,
		// Token: 0x04000CAA RID: 3242
		[global::Cpp2ILInjected.Token(Token = "0x40010A3")]
		ReceiveBuffer,
		// Token: 0x04000CAB RID: 3243
		[global::Cpp2ILInjected.Token(Token = "0x40010A4")]
		SendLowWater,
		// Token: 0x04000CAC RID: 3244
		[global::Cpp2ILInjected.Token(Token = "0x40010A5")]
		ReceiveLowWater,
		// Token: 0x04000CAD RID: 3245
		[global::Cpp2ILInjected.Token(Token = "0x40010A6")]
		SendTimeout,
		// Token: 0x04000CAE RID: 3246
		[global::Cpp2ILInjected.Token(Token = "0x40010A7")]
		ReceiveTimeout,
		// Token: 0x04000CAF RID: 3247
		[global::Cpp2ILInjected.Token(Token = "0x40010A8")]
		Error,
		// Token: 0x04000CB0 RID: 3248
		[global::Cpp2ILInjected.Token(Token = "0x40010A9")]
		Type,
		// Token: 0x04000CB1 RID: 3249
		[global::Cpp2ILInjected.Token(Token = "0x40010AA")]
		ReuseUnicastPort = 12295,
		// Token: 0x04000CB2 RID: 3250
		[global::Cpp2ILInjected.Token(Token = "0x40010AB")]
		MaxConnections = 2147483647,
		// Token: 0x04000CB3 RID: 3251
		[global::Cpp2ILInjected.Token(Token = "0x40010AC")]
		IPOptions = 1,
		// Token: 0x04000CB4 RID: 3252
		[global::Cpp2ILInjected.Token(Token = "0x40010AD")]
		HeaderIncluded,
		// Token: 0x04000CB5 RID: 3253
		[global::Cpp2ILInjected.Token(Token = "0x40010AE")]
		TypeOfService,
		// Token: 0x04000CB6 RID: 3254
		[global::Cpp2ILInjected.Token(Token = "0x40010AF")]
		IpTimeToLive,
		// Token: 0x04000CB7 RID: 3255
		[global::Cpp2ILInjected.Token(Token = "0x40010B0")]
		MulticastInterface = 9,
		// Token: 0x04000CB8 RID: 3256
		[global::Cpp2ILInjected.Token(Token = "0x40010B1")]
		MulticastTimeToLive,
		// Token: 0x04000CB9 RID: 3257
		[global::Cpp2ILInjected.Token(Token = "0x40010B2")]
		MulticastLoopback,
		// Token: 0x04000CBA RID: 3258
		[global::Cpp2ILInjected.Token(Token = "0x40010B3")]
		AddMembership,
		// Token: 0x04000CBB RID: 3259
		[global::Cpp2ILInjected.Token(Token = "0x40010B4")]
		DropMembership,
		// Token: 0x04000CBC RID: 3260
		[global::Cpp2ILInjected.Token(Token = "0x40010B5")]
		DontFragment,
		// Token: 0x04000CBD RID: 3261
		[global::Cpp2ILInjected.Token(Token = "0x40010B6")]
		AddSourceMembership,
		// Token: 0x04000CBE RID: 3262
		[global::Cpp2ILInjected.Token(Token = "0x40010B7")]
		DropSourceMembership,
		// Token: 0x04000CBF RID: 3263
		[global::Cpp2ILInjected.Token(Token = "0x40010B8")]
		BlockSource,
		// Token: 0x04000CC0 RID: 3264
		[global::Cpp2ILInjected.Token(Token = "0x40010B9")]
		UnblockSource,
		// Token: 0x04000CC1 RID: 3265
		[global::Cpp2ILInjected.Token(Token = "0x40010BA")]
		PacketInformation,
		// Token: 0x04000CC2 RID: 3266
		[global::Cpp2ILInjected.Token(Token = "0x40010BB")]
		HopLimit = 21,
		// Token: 0x04000CC3 RID: 3267
		[global::Cpp2ILInjected.Token(Token = "0x40010BC")]
		IPProtectionLevel = 23,
		// Token: 0x04000CC4 RID: 3268
		[global::Cpp2ILInjected.Token(Token = "0x40010BD")]
		IPv6Only = 27,
		// Token: 0x04000CC5 RID: 3269
		[global::Cpp2ILInjected.Token(Token = "0x40010BE")]
		NoDelay = 1,
		// Token: 0x04000CC6 RID: 3270
		[global::Cpp2ILInjected.Token(Token = "0x40010BF")]
		BsdUrgent,
		// Token: 0x04000CC7 RID: 3271
		[global::Cpp2ILInjected.Token(Token = "0x40010C0")]
		Expedited = 2,
		// Token: 0x04000CC8 RID: 3272
		[global::Cpp2ILInjected.Token(Token = "0x40010C1")]
		NoChecksum = 1,
		// Token: 0x04000CC9 RID: 3273
		[global::Cpp2ILInjected.Token(Token = "0x40010C2")]
		ChecksumCoverage = 20,
		// Token: 0x04000CCA RID: 3274
		[global::Cpp2ILInjected.Token(Token = "0x40010C3")]
		UpdateAcceptContext = 28683,
		// Token: 0x04000CCB RID: 3275
		[global::Cpp2ILInjected.Token(Token = "0x40010C4")]
		UpdateConnectContext = 28688
	}
}
