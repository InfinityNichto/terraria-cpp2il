using System;
using Cpp2ILInjected;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200018F")]
	public enum FtpStatusCode
	{
		[global::Cpp2ILInjected.Token(Token = "0x40007CD")]
		Undefined,
		[global::Cpp2ILInjected.Token(Token = "0x40007CE")]
		RestartMarker = 110,
		[global::Cpp2ILInjected.Token(Token = "0x40007CF")]
		ServiceTemporarilyNotAvailable = 120,
		[global::Cpp2ILInjected.Token(Token = "0x40007D0")]
		DataAlreadyOpen = 125,
		[global::Cpp2ILInjected.Token(Token = "0x40007D1")]
		OpeningData = 150,
		[global::Cpp2ILInjected.Token(Token = "0x40007D2")]
		CommandOK = 200,
		[global::Cpp2ILInjected.Token(Token = "0x40007D3")]
		CommandExtraneous = 202,
		[global::Cpp2ILInjected.Token(Token = "0x40007D4")]
		DirectoryStatus = 212,
		[global::Cpp2ILInjected.Token(Token = "0x40007D5")]
		FileStatus,
		[global::Cpp2ILInjected.Token(Token = "0x40007D6")]
		SystemType = 215,
		[global::Cpp2ILInjected.Token(Token = "0x40007D7")]
		SendUserCommand = 220,
		[global::Cpp2ILInjected.Token(Token = "0x40007D8")]
		ClosingControl,
		[global::Cpp2ILInjected.Token(Token = "0x40007D9")]
		ClosingData = 226,
		[global::Cpp2ILInjected.Token(Token = "0x40007DA")]
		EnteringPassive,
		[global::Cpp2ILInjected.Token(Token = "0x40007DB")]
		LoggedInProceed = 230,
		[global::Cpp2ILInjected.Token(Token = "0x40007DC")]
		ServerWantsSecureSession = 234,
		[global::Cpp2ILInjected.Token(Token = "0x40007DD")]
		FileActionOK = 250,
		[global::Cpp2ILInjected.Token(Token = "0x40007DE")]
		PathnameCreated = 257,
		[global::Cpp2ILInjected.Token(Token = "0x40007DF")]
		SendPasswordCommand = 331,
		[global::Cpp2ILInjected.Token(Token = "0x40007E0")]
		NeedLoginAccount,
		[global::Cpp2ILInjected.Token(Token = "0x40007E1")]
		FileCommandPending = 350,
		[global::Cpp2ILInjected.Token(Token = "0x40007E2")]
		ServiceNotAvailable = 421,
		[global::Cpp2ILInjected.Token(Token = "0x40007E3")]
		CantOpenData = 425,
		[global::Cpp2ILInjected.Token(Token = "0x40007E4")]
		ConnectionClosed,
		[global::Cpp2ILInjected.Token(Token = "0x40007E5")]
		ActionNotTakenFileUnavailableOrBusy = 450,
		[global::Cpp2ILInjected.Token(Token = "0x40007E6")]
		ActionAbortedLocalProcessingError,
		[global::Cpp2ILInjected.Token(Token = "0x40007E7")]
		ActionNotTakenInsufficientSpace,
		[global::Cpp2ILInjected.Token(Token = "0x40007E8")]
		CommandSyntaxError = 500,
		[global::Cpp2ILInjected.Token(Token = "0x40007E9")]
		ArgumentSyntaxError,
		[global::Cpp2ILInjected.Token(Token = "0x40007EA")]
		CommandNotImplemented,
		[global::Cpp2ILInjected.Token(Token = "0x40007EB")]
		BadCommandSequence,
		[global::Cpp2ILInjected.Token(Token = "0x40007EC")]
		NotLoggedIn = 530,
		[global::Cpp2ILInjected.Token(Token = "0x40007ED")]
		AccountNeeded = 532,
		[global::Cpp2ILInjected.Token(Token = "0x40007EE")]
		ActionNotTakenFileUnavailable = 550,
		[global::Cpp2ILInjected.Token(Token = "0x40007EF")]
		ActionAbortedUnknownPageType,
		[global::Cpp2ILInjected.Token(Token = "0x40007F0")]
		FileActionAborted,
		[global::Cpp2ILInjected.Token(Token = "0x40007F1")]
		ActionNotTakenFilenameNotAllowed
	}
}
