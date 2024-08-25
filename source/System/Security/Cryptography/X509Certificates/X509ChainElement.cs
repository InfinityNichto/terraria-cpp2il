using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography.X509Certificates
{
	[global::Cpp2ILInjected.Token(Token = "0x200010F")]
	public class X509ChainElement
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000636")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED808C", Offset = "0x1ED808C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainElementCollection), Member = "Add", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal X509ChainElement(X509Certificate2 certificate)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700014F")]
		public X509Certificate2 Certificate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000637")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED80F8", Offset = "0x1ED80F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000150")]
		public X509ChainStatus[] ChainElementStatus
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000638")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED8100", Offset = "0x1ED8100", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000151")]
		internal X509ChainStatusFlags StatusFlags
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000639")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED8108", Offset = "0x1ED8108", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600063A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED8110", Offset = "0x1ED8110", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600063B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED8118", Offset = "0x1ED8118", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int Count(X509ChainStatusFlags flags)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600063C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED813C", Offset = "0x1ED813C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainStatus), Member = "GetInformation", MemberParameters = new object[] { typeof(X509ChainStatusFlags) }, ReturnType = typeof(string))]
		private void Set(X509ChainStatus[] status, ref int position, X509ChainStatusFlags flags, X509ChainStatusFlags mask)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600063D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED8324", Offset = "0x1ED8324", Length = "0x458")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "ValidateChain", MemberParameters = new object[] { typeof(X509ChainStatusFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "WrapUp", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainStatus), Member = "GetInformation", MemberParameters = new object[] { typeof(X509ChainStatusFlags) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void UncompressFlags()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000508")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private X509Certificate2 certificate;

		[global::Cpp2ILInjected.Token(Token = "0x4000509")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private X509ChainStatus[] status;

		[global::Cpp2ILInjected.Token(Token = "0x400050A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string info;

		[global::Cpp2ILInjected.Token(Token = "0x400050B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private X509ChainStatusFlags compressed_status_flags;
	}
}
