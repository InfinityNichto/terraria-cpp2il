using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000094 RID: 148
	[global::Cpp2ILInjected.Token(Token = "0x20000F1")]
	public sealed class OidCollection : ICollection, IEnumerable
	{
		// Token: 0x060004D6 RID: 1238 RVA: 0x00003C0B File Offset: 0x00001E0B
		[global::Cpp2ILInjected.Token(Token = "0x600057B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECED78", Offset = "0x1ECED78", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainPolicy), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(OidCollection),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(AsnDecodeStatus))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public OidCollection()
		{
			throw null;
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00003C0E File Offset: 0x00001E0E
		[global::Cpp2ILInjected.Token(Token = "0x600057C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECEDF8", Offset = "0x1ECEDF8", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(OidCollection),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(AsnDecodeStatus))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public int Add(Oid oid)
		{
			throw null;
		}

		// Token: 0x17000104 RID: 260
		[global::Cpp2ILInjected.Token(Token = "0x1700010A")]
		public Oid this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x600057D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECEEA8", Offset = "0x1ECEEA8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OidCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OidEnumerator), Member = "get_Current", ReturnType = typeof(Oid))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OidEnumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00003C14 File Offset: 0x00001E14
		[global::Cpp2ILInjected.Token(Token = "0x1700010B")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x600057E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECEF00", Offset = "0x1ECEF00", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00003C17 File Offset: 0x00001E17
		[global::Cpp2ILInjected.Token(Token = "0x600057F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECEF40", Offset = "0x1ECEF40", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OidCollection), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(OidCollection),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = "Encode", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public OidEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00003C1A File Offset: 0x00001E1A
		[global::Cpp2ILInjected.Token(Token = "0x6000580")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECEFD4", Offset = "0x1ECEFD4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OidCollection), Member = "GetEnumerator", ReturnType = typeof(OidEnumerator))]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00003C1D File Offset: 0x00001E1D
		[global::Cpp2ILInjected.Token(Token = "0x6000581")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECEFD8", Offset = "0x1ECEFD8", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "get_Rank", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OidCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Oid))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private void System.Collections.ICollection.CopyTo(Array array, int index)
		{
			throw null;
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x00003C20 File Offset: 0x00001E20
		[global::Cpp2ILInjected.Token(Token = "0x1700010C")]
		public bool IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000582")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECF1C4", Offset = "0x1ECF1C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x00003C23 File Offset: 0x00001E23
		[global::Cpp2ILInjected.Token(Token = "0x1700010D")]
		public object SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000583")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECF1CC", Offset = "0x1ECF1CC", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040002F3 RID: 755
		[global::Cpp2ILInjected.Token(Token = "0x400045C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly List<Oid> _list;
	}
}
