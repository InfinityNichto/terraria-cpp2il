using System;
using Cpp2ILInjected;

namespace System.Net
{
	// Token: 0x0200010A RID: 266
	[global::Cpp2ILInjected.Token(Token = "0x200018F")]
	public enum FtpStatusCode
	{
		// Token: 0x040005BB RID: 1467
		[global::Cpp2ILInjected.Token(Token = "0x40007CD")]
		Undefined,
		// Token: 0x040005BC RID: 1468
		[global::Cpp2ILInjected.Token(Token = "0x40007CE")]
		RestartMarker = 110,
		// Token: 0x040005BD RID: 1469
		[global::Cpp2ILInjected.Token(Token = "0x40007CF")]
		ServiceTemporarilyNotAvailable = 120,
		// Token: 0x040005BE RID: 1470
		[global::Cpp2ILInjected.Token(Token = "0x40007D0")]
		DataAlreadyOpen = 125,
		// Token: 0x040005BF RID: 1471
		[global::Cpp2ILInjected.Token(Token = "0x40007D1")]
		OpeningData = 150,
		// Token: 0x040005C0 RID: 1472
		[global::Cpp2ILInjected.Token(Token = "0x40007D2")]
		CommandOK = 200,
		// Token: 0x040005C1 RID: 1473
		[global::Cpp2ILInjected.Token(Token = "0x40007D3")]
		CommandExtraneous = 202,
		// Token: 0x040005C2 RID: 1474
		[global::Cpp2ILInjected.Token(Token = "0x40007D4")]
		DirectoryStatus = 212,
		// Token: 0x040005C3 RID: 1475
		[global::Cpp2ILInjected.Token(Token = "0x40007D5")]
		FileStatus,
		// Token: 0x040005C4 RID: 1476
		[global::Cpp2ILInjected.Token(Token = "0x40007D6")]
		SystemType = 215,
		// Token: 0x040005C5 RID: 1477
		[global::Cpp2ILInjected.Token(Token = "0x40007D7")]
		SendUserCommand = 220,
		// Token: 0x040005C6 RID: 1478
		[global::Cpp2ILInjected.Token(Token = "0x40007D8")]
		ClosingControl,
		// Token: 0x040005C7 RID: 1479
		[global::Cpp2ILInjected.Token(Token = "0x40007D9")]
		ClosingData = 226,
		// Token: 0x040005C8 RID: 1480
		[global::Cpp2ILInjected.Token(Token = "0x40007DA")]
		EnteringPassive,
		// Token: 0x040005C9 RID: 1481
		[global::Cpp2ILInjected.Token(Token = "0x40007DB")]
		LoggedInProceed = 230,
		// Token: 0x040005CA RID: 1482
		[global::Cpp2ILInjected.Token(Token = "0x40007DC")]
		ServerWantsSecureSession = 234,
		// Token: 0x040005CB RID: 1483
		[global::Cpp2ILInjected.Token(Token = "0x40007DD")]
		FileActionOK = 250,
		// Token: 0x040005CC RID: 1484
		[global::Cpp2ILInjected.Token(Token = "0x40007DE")]
		PathnameCreated = 257,
		// Token: 0x040005CD RID: 1485
		[global::Cpp2ILInjected.Token(Token = "0x40007DF")]
		SendPasswordCommand = 331,
		// Token: 0x040005CE RID: 1486
		[global::Cpp2ILInjected.Token(Token = "0x40007E0")]
		NeedLoginAccount,
		// Token: 0x040005CF RID: 1487
		[global::Cpp2ILInjected.Token(Token = "0x40007E1")]
		FileCommandPending = 350,
		// Token: 0x040005D0 RID: 1488
		[global::Cpp2ILInjected.Token(Token = "0x40007E2")]
		ServiceNotAvailable = 421,
		// Token: 0x040005D1 RID: 1489
		[global::Cpp2ILInjected.Token(Token = "0x40007E3")]
		CantOpenData = 425,
		// Token: 0x040005D2 RID: 1490
		[global::Cpp2ILInjected.Token(Token = "0x40007E4")]
		ConnectionClosed,
		// Token: 0x040005D3 RID: 1491
		[global::Cpp2ILInjected.Token(Token = "0x40007E5")]
		ActionNotTakenFileUnavailableOrBusy = 450,
		// Token: 0x040005D4 RID: 1492
		[global::Cpp2ILInjected.Token(Token = "0x40007E6")]
		ActionAbortedLocalProcessingError,
		// Token: 0x040005D5 RID: 1493
		[global::Cpp2ILInjected.Token(Token = "0x40007E7")]
		ActionNotTakenInsufficientSpace,
		// Token: 0x040005D6 RID: 1494
		[global::Cpp2ILInjected.Token(Token = "0x40007E8")]
		CommandSyntaxError = 500,
		// Token: 0x040005D7 RID: 1495
		[global::Cpp2ILInjected.Token(Token = "0x40007E9")]
		ArgumentSyntaxError,
		// Token: 0x040005D8 RID: 1496
		[global::Cpp2ILInjected.Token(Token = "0x40007EA")]
		CommandNotImplemented,
		// Token: 0x040005D9 RID: 1497
		[global::Cpp2ILInjected.Token(Token = "0x40007EB")]
		BadCommandSequence,
		// Token: 0x040005DA RID: 1498
		[global::Cpp2ILInjected.Token(Token = "0x40007EC")]
		NotLoggedIn = 530,
		// Token: 0x040005DB RID: 1499
		[global::Cpp2ILInjected.Token(Token = "0x40007ED")]
		AccountNeeded = 532,
		// Token: 0x040005DC RID: 1500
		[global::Cpp2ILInjected.Token(Token = "0x40007EE")]
		ActionNotTakenFileUnavailable = 550,
		// Token: 0x040005DD RID: 1501
		[global::Cpp2ILInjected.Token(Token = "0x40007EF")]
		ActionAbortedUnknownPageType,
		// Token: 0x040005DE RID: 1502
		[global::Cpp2ILInjected.Token(Token = "0x40007F0")]
		FileActionAborted,
		// Token: 0x040005DF RID: 1503
		[global::Cpp2ILInjected.Token(Token = "0x40007F1")]
		ActionNotTakenFilenameNotAllowed
	}
}
