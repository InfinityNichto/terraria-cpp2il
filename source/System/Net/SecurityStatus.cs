using System;
using Cpp2ILInjected;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20001A6")]
	internal enum SecurityStatus
	{
		[global::Cpp2ILInjected.Token(Token = "0x400086D")]
		OK,
		[global::Cpp2ILInjected.Token(Token = "0x400086E")]
		ContinueNeeded = 590610,
		[global::Cpp2ILInjected.Token(Token = "0x400086F")]
		CompleteNeeded,
		[global::Cpp2ILInjected.Token(Token = "0x4000870")]
		CompAndContinue,
		[global::Cpp2ILInjected.Token(Token = "0x4000871")]
		ContextExpired = 590615,
		[global::Cpp2ILInjected.Token(Token = "0x4000872")]
		CredentialsNeeded = 590624,
		[global::Cpp2ILInjected.Token(Token = "0x4000873")]
		Renegotiate,
		[global::Cpp2ILInjected.Token(Token = "0x4000874")]
		OutOfMemory = -2146893056,
		[global::Cpp2ILInjected.Token(Token = "0x4000875")]
		InvalidHandle,
		[global::Cpp2ILInjected.Token(Token = "0x4000876")]
		Unsupported,
		[global::Cpp2ILInjected.Token(Token = "0x4000877")]
		TargetUnknown,
		[global::Cpp2ILInjected.Token(Token = "0x4000878")]
		InternalError,
		[global::Cpp2ILInjected.Token(Token = "0x4000879")]
		PackageNotFound,
		[global::Cpp2ILInjected.Token(Token = "0x400087A")]
		NotOwner,
		[global::Cpp2ILInjected.Token(Token = "0x400087B")]
		CannotInstall,
		[global::Cpp2ILInjected.Token(Token = "0x400087C")]
		InvalidToken,
		[global::Cpp2ILInjected.Token(Token = "0x400087D")]
		CannotPack,
		[global::Cpp2ILInjected.Token(Token = "0x400087E")]
		QopNotSupported,
		[global::Cpp2ILInjected.Token(Token = "0x400087F")]
		NoImpersonation,
		[global::Cpp2ILInjected.Token(Token = "0x4000880")]
		LogonDenied,
		[global::Cpp2ILInjected.Token(Token = "0x4000881")]
		UnknownCredentials,
		[global::Cpp2ILInjected.Token(Token = "0x4000882")]
		NoCredentials,
		[global::Cpp2ILInjected.Token(Token = "0x4000883")]
		MessageAltered,
		[global::Cpp2ILInjected.Token(Token = "0x4000884")]
		OutOfSequence,
		[global::Cpp2ILInjected.Token(Token = "0x4000885")]
		NoAuthenticatingAuthority,
		[global::Cpp2ILInjected.Token(Token = "0x4000886")]
		IncompleteMessage = -2146893032,
		[global::Cpp2ILInjected.Token(Token = "0x4000887")]
		IncompleteCredentials = -2146893024,
		[global::Cpp2ILInjected.Token(Token = "0x4000888")]
		BufferNotEnough,
		[global::Cpp2ILInjected.Token(Token = "0x4000889")]
		WrongPrincipal,
		[global::Cpp2ILInjected.Token(Token = "0x400088A")]
		TimeSkew = -2146893020,
		[global::Cpp2ILInjected.Token(Token = "0x400088B")]
		UntrustedRoot,
		[global::Cpp2ILInjected.Token(Token = "0x400088C")]
		IllegalMessage,
		[global::Cpp2ILInjected.Token(Token = "0x400088D")]
		CertUnknown,
		[global::Cpp2ILInjected.Token(Token = "0x400088E")]
		CertExpired,
		[global::Cpp2ILInjected.Token(Token = "0x400088F")]
		AlgorithmMismatch = -2146893007,
		[global::Cpp2ILInjected.Token(Token = "0x4000890")]
		SecurityQosFailed,
		[global::Cpp2ILInjected.Token(Token = "0x4000891")]
		SmartcardLogonRequired = -2146892994,
		[global::Cpp2ILInjected.Token(Token = "0x4000892")]
		UnsupportedPreauth = -2146892989,
		[global::Cpp2ILInjected.Token(Token = "0x4000893")]
		BadBinding = -2146892986
	}
}
