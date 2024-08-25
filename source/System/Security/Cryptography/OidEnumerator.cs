using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	[global::Cpp2ILInjected.Token(Token = "0x20000F2")]
	public sealed class OidEnumerator : IEnumerator
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000584")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECEFA4", Offset = "0x1ECEFA4", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal OidEnumerator(OidCollection oids)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700010E")]
		public Oid Current
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000585")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECF1D0", Offset = "0x1ECF1D0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(OidCollection),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = "Encode", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OidCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Oid))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700010F")]
		private object System.Collections.IEnumerator.Current
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000586")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECF1E0", Offset = "0x1ECF1E0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OidCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Oid))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000587")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECF1F0", Offset = "0x1ECF1F0", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(OidCollection),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = "Encode", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool MoveNext()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000588")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECF264", Offset = "0x1ECF264", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400045D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly OidCollection _oids;

		[global::Cpp2ILInjected.Token(Token = "0x400045E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _current;
	}
}
