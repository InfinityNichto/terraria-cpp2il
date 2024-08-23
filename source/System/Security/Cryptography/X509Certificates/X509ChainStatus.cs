using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Unity;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000B7 RID: 183
	[global::Cpp2ILInjected.Token(Token = "0x2000115")]
	public struct X509ChainStatus
	{
		// Token: 0x060005DC RID: 1500 RVA: 0x00003EE7 File Offset: 0x000020E7
		[global::Cpp2ILInjected.Token(Token = "0x6000687")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED9730", Offset = "0x1ED9730", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplUnityTls), Member = "AddStatus", MemberParameters = new object[] { typeof(X509ChainStatusFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainStatus), Member = "GetInformation", MemberParameters = new object[] { typeof(X509ChainStatusFlags) }, ReturnType = typeof(string))]
		internal X509ChainStatus(X509ChainStatusFlags flag)
		{
			throw null;
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x00003EEA File Offset: 0x000020EA
		// (set) Token: 0x060005DE RID: 1502 RVA: 0x00003EED File Offset: 0x000020ED
		[global::Cpp2ILInjected.Token(Token = "0x1700016A")]
		public X509ChainStatusFlags Status
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000688")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EDBDC0", Offset = "0x1EDBDC0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000689")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EDBDC8", Offset = "0x1EDBDC8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000163 RID: 355
		// (set) Token: 0x060005DF RID: 1503 RVA: 0x00003EF0 File Offset: 0x000020F0
		[global::Cpp2ILInjected.Token(Token = "0x1700016B")]
		public string StatusInformation
		{
			[global::Cpp2ILInjected.Token(Token = "0x600068A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EDBDD0", Offset = "0x1EDBDD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00003EF3 File Offset: 0x000020F3
		[global::Cpp2ILInjected.Token(Token = "0x600068B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED818C", Offset = "0x1ED818C", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainElement), Member = "Set", MemberParameters = new object[]
		{
			typeof(X509ChainStatus[]),
			typeof(ref int),
			typeof(X509ChainStatusFlags),
			typeof(X509ChainStatusFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainElement), Member = "UncompressFlags", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "Build", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainStatus), Member = ".ctor", MemberParameters = new object[] { typeof(X509ChainStatusFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Locale", Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static string GetInformation(X509ChainStatusFlags flags)
		{
			throw null;
		}

		// Token: 0x040003BD RID: 957
		[global::Cpp2ILInjected.Token(Token = "0x4000527")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private X509ChainStatusFlags status;

		// Token: 0x040003BE RID: 958
		[global::Cpp2ILInjected.Token(Token = "0x4000528")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private string info;
	}
}
