using System;
using System.Security.Authentication;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.Interface
{
	// Token: 0x02000031 RID: 49
	[global::Cpp2ILInjected.Token(Token = "0x200004C")]
	public abstract class MonoTlsProvider
	{
		// Token: 0x060001A4 RID: 420 RVA: 0x0000341D File Offset: 0x0000161D
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

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001A5 RID: 421
		[global::Cpp2ILInjected.Token(Token = "0x17000095")]
		public abstract Guid ID
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001FB")]
			get;
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001A6 RID: 422
		[global::Cpp2ILInjected.Token(Token = "0x17000096")]
		public abstract string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001FC")]
			get;
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001A7 RID: 423
		[global::Cpp2ILInjected.Token(Token = "0x17000097")]
		public abstract bool SupportsSslStream
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001FD")]
			get;
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001A8 RID: 424
		[global::Cpp2ILInjected.Token(Token = "0x17000098")]
		public abstract bool SupportsConnectionInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001FE")]
			get;
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001A9 RID: 425
		[global::Cpp2ILInjected.Token(Token = "0x17000099")]
		public abstract bool SupportsMonoExtensions
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001FF")]
			get;
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001AA RID: 426
		[global::Cpp2ILInjected.Token(Token = "0x1700009A")]
		public abstract SslProtocols SupportedProtocols
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000200")]
			get;
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001AB RID: 427
		[global::Cpp2ILInjected.Token(Token = "0x1700009B")]
		internal abstract bool SupportsCleanShutdown
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000201")]
			get;
		}
	}
}
