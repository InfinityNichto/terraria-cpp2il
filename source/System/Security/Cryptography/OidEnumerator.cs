using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000095 RID: 149
	[global::Cpp2ILInjected.Token(Token = "0x20000F2")]
	public sealed class OidEnumerator : IEnumerator
	{
		// Token: 0x060004DF RID: 1247 RVA: 0x00003C26 File Offset: 0x00001E26
		[global::Cpp2ILInjected.Token(Token = "0x6000584")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECEFA4", Offset = "0x1ECEFA4", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal OidEnumerator(OidCollection oids)
		{
			throw null;
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x00003C29 File Offset: 0x00001E29
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

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00003C2C File Offset: 0x00001E2C
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

		// Token: 0x060004E2 RID: 1250 RVA: 0x00003C2F File Offset: 0x00001E2F
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

		// Token: 0x060004E3 RID: 1251 RVA: 0x00003C32 File Offset: 0x00001E32
		[global::Cpp2ILInjected.Token(Token = "0x6000588")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECF264", Offset = "0x1ECF264", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x040002F4 RID: 756
		[global::Cpp2ILInjected.Token(Token = "0x400045D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly OidCollection _oids;

		// Token: 0x040002F5 RID: 757
		[global::Cpp2ILInjected.Token(Token = "0x400045E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _current;
	}
}
