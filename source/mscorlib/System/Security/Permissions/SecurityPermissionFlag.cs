using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Security.Permissions
{
	[global::System.Flags]
	[global::System.Obsolete("CAS support is not available with Silverlight applications.")]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002B1")]
	[global::System.Serializable]
	public enum SecurityPermissionFlag
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000BFF")]
		NoFlags = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4000C00")]
		Assertion = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4000C01")]
		UnmanagedCode = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4000C02")]
		SkipVerification = 4,
		[global::Cpp2ILInjected.Token(Token = "0x4000C03")]
		Execution = 8,
		[global::Cpp2ILInjected.Token(Token = "0x4000C04")]
		ControlThread = 16,
		[global::Cpp2ILInjected.Token(Token = "0x4000C05")]
		ControlEvidence = 32,
		[global::Cpp2ILInjected.Token(Token = "0x4000C06")]
		ControlPolicy = 64,
		[global::Cpp2ILInjected.Token(Token = "0x4000C07")]
		SerializationFormatter = 128,
		[global::Cpp2ILInjected.Token(Token = "0x4000C08")]
		ControlDomainPolicy = 256,
		[global::Cpp2ILInjected.Token(Token = "0x4000C09")]
		ControlPrincipal = 512,
		[global::Cpp2ILInjected.Token(Token = "0x4000C0A")]
		ControlAppDomain = 1024,
		[global::Cpp2ILInjected.Token(Token = "0x4000C0B")]
		RemotingConfiguration = 2048,
		[global::Cpp2ILInjected.Token(Token = "0x4000C0C")]
		Infrastructure = 4096,
		[global::Cpp2ILInjected.Token(Token = "0x4000C0D")]
		BindingRedirects = 8192,
		[global::Cpp2ILInjected.Token(Token = "0x4000C0E")]
		AllFlags = 16383
	}
}
