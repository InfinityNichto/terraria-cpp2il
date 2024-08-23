using System;
using Cpp2ILInjected;

namespace System.Net
{
	// Token: 0x020000CE RID: 206
	[global::Cpp2ILInjected.Token(Token = "0x2000130")]
	internal enum SecurityStatusPalErrorCode
	{
		// Token: 0x04000422 RID: 1058
		[global::Cpp2ILInjected.Token(Token = "0x400059A")]
		NotSet,
		// Token: 0x04000423 RID: 1059
		[global::Cpp2ILInjected.Token(Token = "0x400059B")]
		OK,
		// Token: 0x04000424 RID: 1060
		[global::Cpp2ILInjected.Token(Token = "0x400059C")]
		ContinueNeeded,
		// Token: 0x04000425 RID: 1061
		[global::Cpp2ILInjected.Token(Token = "0x400059D")]
		CompleteNeeded,
		// Token: 0x04000426 RID: 1062
		[global::Cpp2ILInjected.Token(Token = "0x400059E")]
		CompAndContinue,
		// Token: 0x04000427 RID: 1063
		[global::Cpp2ILInjected.Token(Token = "0x400059F")]
		ContextExpired,
		// Token: 0x04000428 RID: 1064
		[global::Cpp2ILInjected.Token(Token = "0x40005A0")]
		CredentialsNeeded,
		// Token: 0x04000429 RID: 1065
		[global::Cpp2ILInjected.Token(Token = "0x40005A1")]
		Renegotiate,
		// Token: 0x0400042A RID: 1066
		[global::Cpp2ILInjected.Token(Token = "0x40005A2")]
		OutOfMemory,
		// Token: 0x0400042B RID: 1067
		[global::Cpp2ILInjected.Token(Token = "0x40005A3")]
		InvalidHandle,
		// Token: 0x0400042C RID: 1068
		[global::Cpp2ILInjected.Token(Token = "0x40005A4")]
		Unsupported,
		// Token: 0x0400042D RID: 1069
		[global::Cpp2ILInjected.Token(Token = "0x40005A5")]
		TargetUnknown,
		// Token: 0x0400042E RID: 1070
		[global::Cpp2ILInjected.Token(Token = "0x40005A6")]
		InternalError,
		// Token: 0x0400042F RID: 1071
		[global::Cpp2ILInjected.Token(Token = "0x40005A7")]
		PackageNotFound,
		// Token: 0x04000430 RID: 1072
		[global::Cpp2ILInjected.Token(Token = "0x40005A8")]
		NotOwner,
		// Token: 0x04000431 RID: 1073
		[global::Cpp2ILInjected.Token(Token = "0x40005A9")]
		CannotInstall,
		// Token: 0x04000432 RID: 1074
		[global::Cpp2ILInjected.Token(Token = "0x40005AA")]
		InvalidToken,
		// Token: 0x04000433 RID: 1075
		[global::Cpp2ILInjected.Token(Token = "0x40005AB")]
		CannotPack,
		// Token: 0x04000434 RID: 1076
		[global::Cpp2ILInjected.Token(Token = "0x40005AC")]
		QopNotSupported,
		// Token: 0x04000435 RID: 1077
		[global::Cpp2ILInjected.Token(Token = "0x40005AD")]
		NoImpersonation,
		// Token: 0x04000436 RID: 1078
		[global::Cpp2ILInjected.Token(Token = "0x40005AE")]
		LogonDenied,
		// Token: 0x04000437 RID: 1079
		[global::Cpp2ILInjected.Token(Token = "0x40005AF")]
		UnknownCredentials,
		// Token: 0x04000438 RID: 1080
		[global::Cpp2ILInjected.Token(Token = "0x40005B0")]
		NoCredentials,
		// Token: 0x04000439 RID: 1081
		[global::Cpp2ILInjected.Token(Token = "0x40005B1")]
		MessageAltered,
		// Token: 0x0400043A RID: 1082
		[global::Cpp2ILInjected.Token(Token = "0x40005B2")]
		OutOfSequence,
		// Token: 0x0400043B RID: 1083
		[global::Cpp2ILInjected.Token(Token = "0x40005B3")]
		NoAuthenticatingAuthority,
		// Token: 0x0400043C RID: 1084
		[global::Cpp2ILInjected.Token(Token = "0x40005B4")]
		IncompleteMessage,
		// Token: 0x0400043D RID: 1085
		[global::Cpp2ILInjected.Token(Token = "0x40005B5")]
		IncompleteCredentials,
		// Token: 0x0400043E RID: 1086
		[global::Cpp2ILInjected.Token(Token = "0x40005B6")]
		BufferNotEnough,
		// Token: 0x0400043F RID: 1087
		[global::Cpp2ILInjected.Token(Token = "0x40005B7")]
		WrongPrincipal,
		// Token: 0x04000440 RID: 1088
		[global::Cpp2ILInjected.Token(Token = "0x40005B8")]
		TimeSkew,
		// Token: 0x04000441 RID: 1089
		[global::Cpp2ILInjected.Token(Token = "0x40005B9")]
		UntrustedRoot,
		// Token: 0x04000442 RID: 1090
		[global::Cpp2ILInjected.Token(Token = "0x40005BA")]
		IllegalMessage,
		// Token: 0x04000443 RID: 1091
		[global::Cpp2ILInjected.Token(Token = "0x40005BB")]
		CertUnknown,
		// Token: 0x04000444 RID: 1092
		[global::Cpp2ILInjected.Token(Token = "0x40005BC")]
		CertExpired,
		// Token: 0x04000445 RID: 1093
		[global::Cpp2ILInjected.Token(Token = "0x40005BD")]
		AlgorithmMismatch,
		// Token: 0x04000446 RID: 1094
		[global::Cpp2ILInjected.Token(Token = "0x40005BE")]
		SecurityQosFailed,
		// Token: 0x04000447 RID: 1095
		[global::Cpp2ILInjected.Token(Token = "0x40005BF")]
		SmartcardLogonRequired,
		// Token: 0x04000448 RID: 1096
		[global::Cpp2ILInjected.Token(Token = "0x40005C0")]
		UnsupportedPreauth,
		// Token: 0x04000449 RID: 1097
		[global::Cpp2ILInjected.Token(Token = "0x40005C1")]
		BadBinding,
		// Token: 0x0400044A RID: 1098
		[global::Cpp2ILInjected.Token(Token = "0x40005C2")]
		DowngradeDetected,
		// Token: 0x0400044B RID: 1099
		[global::Cpp2ILInjected.Token(Token = "0x40005C3")]
		ApplicationProtocolMismatch
	}
}
