using System;
using Cpp2ILInjected;

namespace Mono
{
	[global::Cpp2ILInjected.Token(Token = "0x2000011")]
	internal interface ISystemDependencyProvider
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000004")]
		ISystemCertificateProvider CertificateProvider
		{
			[global::Cpp2ILInjected.Token(Token = "0x600003F")]
			get;
		}
	}
}
