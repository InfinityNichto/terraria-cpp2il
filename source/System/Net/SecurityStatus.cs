using System;
using Cpp2ILInjected;

namespace System.Net
{
	// Token: 0x0200011F RID: 287
	[global::Cpp2ILInjected.Token(Token = "0x20001A6")]
	internal enum SecurityStatus
	{
		// Token: 0x04000654 RID: 1620
		[global::Cpp2ILInjected.Token(Token = "0x400086D")]
		OK,
		// Token: 0x04000655 RID: 1621
		[global::Cpp2ILInjected.Token(Token = "0x400086E")]
		ContinueNeeded = 590610,
		// Token: 0x04000656 RID: 1622
		[global::Cpp2ILInjected.Token(Token = "0x400086F")]
		CompleteNeeded,
		// Token: 0x04000657 RID: 1623
		[global::Cpp2ILInjected.Token(Token = "0x4000870")]
		CompAndContinue,
		// Token: 0x04000658 RID: 1624
		[global::Cpp2ILInjected.Token(Token = "0x4000871")]
		ContextExpired = 590615,
		// Token: 0x04000659 RID: 1625
		[global::Cpp2ILInjected.Token(Token = "0x4000872")]
		CredentialsNeeded = 590624,
		// Token: 0x0400065A RID: 1626
		[global::Cpp2ILInjected.Token(Token = "0x4000873")]
		Renegotiate,
		// Token: 0x0400065B RID: 1627
		[global::Cpp2ILInjected.Token(Token = "0x4000874")]
		OutOfMemory = -2146893056,
		// Token: 0x0400065C RID: 1628
		[global::Cpp2ILInjected.Token(Token = "0x4000875")]
		InvalidHandle,
		// Token: 0x0400065D RID: 1629
		[global::Cpp2ILInjected.Token(Token = "0x4000876")]
		Unsupported,
		// Token: 0x0400065E RID: 1630
		[global::Cpp2ILInjected.Token(Token = "0x4000877")]
		TargetUnknown,
		// Token: 0x0400065F RID: 1631
		[global::Cpp2ILInjected.Token(Token = "0x4000878")]
		InternalError,
		// Token: 0x04000660 RID: 1632
		[global::Cpp2ILInjected.Token(Token = "0x4000879")]
		PackageNotFound,
		// Token: 0x04000661 RID: 1633
		[global::Cpp2ILInjected.Token(Token = "0x400087A")]
		NotOwner,
		// Token: 0x04000662 RID: 1634
		[global::Cpp2ILInjected.Token(Token = "0x400087B")]
		CannotInstall,
		// Token: 0x04000663 RID: 1635
		[global::Cpp2ILInjected.Token(Token = "0x400087C")]
		InvalidToken,
		// Token: 0x04000664 RID: 1636
		[global::Cpp2ILInjected.Token(Token = "0x400087D")]
		CannotPack,
		// Token: 0x04000665 RID: 1637
		[global::Cpp2ILInjected.Token(Token = "0x400087E")]
		QopNotSupported,
		// Token: 0x04000666 RID: 1638
		[global::Cpp2ILInjected.Token(Token = "0x400087F")]
		NoImpersonation,
		// Token: 0x04000667 RID: 1639
		[global::Cpp2ILInjected.Token(Token = "0x4000880")]
		LogonDenied,
		// Token: 0x04000668 RID: 1640
		[global::Cpp2ILInjected.Token(Token = "0x4000881")]
		UnknownCredentials,
		// Token: 0x04000669 RID: 1641
		[global::Cpp2ILInjected.Token(Token = "0x4000882")]
		NoCredentials,
		// Token: 0x0400066A RID: 1642
		[global::Cpp2ILInjected.Token(Token = "0x4000883")]
		MessageAltered,
		// Token: 0x0400066B RID: 1643
		[global::Cpp2ILInjected.Token(Token = "0x4000884")]
		OutOfSequence,
		// Token: 0x0400066C RID: 1644
		[global::Cpp2ILInjected.Token(Token = "0x4000885")]
		NoAuthenticatingAuthority,
		// Token: 0x0400066D RID: 1645
		[global::Cpp2ILInjected.Token(Token = "0x4000886")]
		IncompleteMessage = -2146893032,
		// Token: 0x0400066E RID: 1646
		[global::Cpp2ILInjected.Token(Token = "0x4000887")]
		IncompleteCredentials = -2146893024,
		// Token: 0x0400066F RID: 1647
		[global::Cpp2ILInjected.Token(Token = "0x4000888")]
		BufferNotEnough,
		// Token: 0x04000670 RID: 1648
		[global::Cpp2ILInjected.Token(Token = "0x4000889")]
		WrongPrincipal,
		// Token: 0x04000671 RID: 1649
		[global::Cpp2ILInjected.Token(Token = "0x400088A")]
		TimeSkew = -2146893020,
		// Token: 0x04000672 RID: 1650
		[global::Cpp2ILInjected.Token(Token = "0x400088B")]
		UntrustedRoot,
		// Token: 0x04000673 RID: 1651
		[global::Cpp2ILInjected.Token(Token = "0x400088C")]
		IllegalMessage,
		// Token: 0x04000674 RID: 1652
		[global::Cpp2ILInjected.Token(Token = "0x400088D")]
		CertUnknown,
		// Token: 0x04000675 RID: 1653
		[global::Cpp2ILInjected.Token(Token = "0x400088E")]
		CertExpired,
		// Token: 0x04000676 RID: 1654
		[global::Cpp2ILInjected.Token(Token = "0x400088F")]
		AlgorithmMismatch = -2146893007,
		// Token: 0x04000677 RID: 1655
		[global::Cpp2ILInjected.Token(Token = "0x4000890")]
		SecurityQosFailed,
		// Token: 0x04000678 RID: 1656
		[global::Cpp2ILInjected.Token(Token = "0x4000891")]
		SmartcardLogonRequired = -2146892994,
		// Token: 0x04000679 RID: 1657
		[global::Cpp2ILInjected.Token(Token = "0x4000892")]
		UnsupportedPreauth = -2146892989,
		// Token: 0x0400067A RID: 1658
		[global::Cpp2ILInjected.Token(Token = "0x4000893")]
		BadBinding = -2146892986
	}
}
