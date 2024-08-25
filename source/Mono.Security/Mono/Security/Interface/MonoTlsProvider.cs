using System;
using System.Security.Authentication;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.Interface
{
	[global::Cpp2ILInjected.Token(Token = "0x200004C")]
	public abstract class MonoTlsProvider
	{
		[global::Cpp2ILInjected.Token(Token = "0x60001FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9B690", Offset = "0x1A9B690", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Unity.UnityTlsProvider", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileTlsProvider", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MonoTlsProviderFactory", Member = "CreateDefaultProviderImpl", ReturnType = "Mono.Net.Security.MobileTlsProvider")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal MonoTlsProvider()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000095")]
		public abstract Guid ID
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001FB")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000096")]
		public abstract string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001FC")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000097")]
		public abstract bool SupportsSslStream
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001FD")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000098")]
		public abstract bool SupportsConnectionInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001FE")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000099")]
		public abstract bool SupportsMonoExtensions
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001FF")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700009A")]
		public abstract SslProtocols SupportedProtocols
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000200")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700009B")]
		internal abstract bool SupportsCleanShutdown
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000201")]
			get;
		}
	}
}
