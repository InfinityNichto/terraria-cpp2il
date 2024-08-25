using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Unity;

namespace System.Security.Cryptography.X509Certificates
{
	[global::Cpp2ILInjected.Token(Token = "0x2000115")]
	public struct X509ChainStatus
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000687")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED9730", Offset = "0x1ED9730", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplUnityTls), Member = "AddStatus", MemberParameters = new object[] { typeof(X509ChainStatusFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainStatus), Member = "GetInformation", MemberParameters = new object[] { typeof(X509ChainStatusFlags) }, ReturnType = typeof(string))]
		internal X509ChainStatus(X509ChainStatusFlags flag)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4000527")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private X509ChainStatusFlags status;

		[global::Cpp2ILInjected.Token(Token = "0x4000528")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private string info;
	}
}
