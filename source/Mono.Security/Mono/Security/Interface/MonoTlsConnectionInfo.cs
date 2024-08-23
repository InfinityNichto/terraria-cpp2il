using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.Interface
{
	// Token: 0x0200002D RID: 45
	[global::Cpp2ILInjected.Token(Token = "0x2000048")]
	public class MonoTlsConnectionInfo
	{
		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00003408 File Offset: 0x00001608
		// (set) Token: 0x0600019A RID: 410 RVA: 0x0000340B File Offset: 0x0000160B
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x17000092")]
		public CipherSuiteCode CipherSuiteCode
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60001EF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B3CC", Offset = "0x1A9B3CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60001F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B3D4", Offset = "0x1A9B3D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600019B RID: 411 RVA: 0x0000340E File Offset: 0x0000160E
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00003411 File Offset: 0x00001611
		[global::Cpp2ILInjected.Token(Token = "0x17000093")]
		public TlsProtocols ProtocolVersion
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60001F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B3DC", Offset = "0x1A9B3DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60001F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B3E4", Offset = "0x1A9B3E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000079 RID: 121
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00003414 File Offset: 0x00001614
		[global::Cpp2ILInjected.Token(Token = "0x17000094")]
		public string PeerDomainName
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60001F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B3EC", Offset = "0x1A9B3EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00003417 File Offset: 0x00001617
		[global::Cpp2ILInjected.Token(Token = "0x60001F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9B3F4", Offset = "0x1A9B3F4", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000341A File Offset: 0x0000161A
		[global::Cpp2ILInjected.Token(Token = "0x60001F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9B4B0", Offset = "0x1A9B4B0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Unity.UnityTlsContext", Member = "FinishHandshake", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MonoTlsConnectionInfo()
		{
			throw null;
		}

		// Token: 0x040001F8 RID: 504
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000225")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private CipherSuiteCode <CipherSuiteCode>k__BackingField;

		// Token: 0x040001F9 RID: 505
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000226")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private TlsProtocols <ProtocolVersion>k__BackingField;

		// Token: 0x040001FA RID: 506
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000227")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string <PeerDomainName>k__BackingField;
	}
}
