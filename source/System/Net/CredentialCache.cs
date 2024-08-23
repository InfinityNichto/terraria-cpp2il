using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000104 RID: 260
	[global::Cpp2ILInjected.Token(Token = "0x2000188")]
	public class CredentialCache : ICredentials, ICredentialsByHost, IEnumerable
	{
		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x000047F9 File Offset: 0x000029F9
		[global::Cpp2ILInjected.Token(Token = "0x1700020C")]
		internal bool IsDefaultInCache
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A1D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F08D64", Offset = "0x1F08D64", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x000047FC File Offset: 0x000029FC
		[global::Cpp2ILInjected.Token(Token = "0x6000A1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F08D74", Offset = "0x1F08D74", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public CredentialCache()
		{
			throw null;
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x000047FF File Offset: 0x000029FF
		[global::Cpp2ILInjected.Token(Token = "0x6000A1F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F08DEC", Offset = "0x1F08DEC", Length = "0x250")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CredentialKey), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public void Add(Uri uriPrefix, string authType, NetworkCredential cred)
		{
			throw null;
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00004802 File Offset: 0x00002A02
		[global::Cpp2ILInjected.Token(Token = "0x6000A20")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0903C", Offset = "0x1F0903C", Length = "0x2E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CredentialHostKey), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		public void Add(string host, int port, string authenticationType, NetworkCredential credential)
		{
			throw null;
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00004805 File Offset: 0x00002A05
		[global::Cpp2ILInjected.Token(Token = "0x6000A21")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F09320", Offset = "0x1F09320", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CredentialKey), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Remove(Uri uriPrefix, string authType)
		{
			throw null;
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00004808 File Offset: 0x00002A08
		[global::Cpp2ILInjected.Token(Token = "0x6000A22")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F09460", Offset = "0x1F09460", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CredentialHostKey), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Remove(string host, int port, string authenticationType)
		{
			throw null;
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x0000480B File Offset: 0x00002A0B
		[global::Cpp2ILInjected.Token(Token = "0x6000A23")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F09578", Offset = "0x1F09578", Length = "0x320")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CredentialKey), Member = "Match", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public NetworkCredential GetCredential(Uri uriPrefix, string authType)
		{
			throw null;
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x0000480E File Offset: 0x00002A0E
		[global::Cpp2ILInjected.Token(Token = "0x6000A24")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F09898", Offset = "0x1F09898", Length = "0x39C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CredentialHostKey), Member = "Match", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public NetworkCredential GetCredential(string host, int port, string authenticationType)
		{
			throw null;
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00004811 File Offset: 0x00002A11
		[global::Cpp2ILInjected.Token(Token = "0x6000A25")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F09C34", Offset = "0x1F09C34", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CredentialCache.CredentialEnumerator), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(CredentialCache),
			typeof(Hashtable),
			typeof(Hashtable),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x00004814 File Offset: 0x00002A14
		[global::Cpp2ILInjected.Token(Token = "0x1700020D")]
		public static ICredentials DefaultCredentials
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A26")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F09E90", Offset = "0x1F09E90", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x00004817 File Offset: 0x00002A17
		[global::Cpp2ILInjected.Token(Token = "0x1700020E")]
		public static NetworkCredential DefaultNetworkCredentials
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A27")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F09EE8", Offset = "0x1F09EE8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040005A8 RID: 1448
		[global::Cpp2ILInjected.Token(Token = "0x40007B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Hashtable cache;

		// Token: 0x040005A9 RID: 1449
		[global::Cpp2ILInjected.Token(Token = "0x40007B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Hashtable cacheForHosts;

		// Token: 0x040005AA RID: 1450
		[global::Cpp2ILInjected.Token(Token = "0x40007B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int m_version;

		// Token: 0x040005AB RID: 1451
		[global::Cpp2ILInjected.Token(Token = "0x40007B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int m_NumbDefaultCredInCache;

		// Token: 0x020003EC RID: 1004
		[global::Cpp2ILInjected.Token(Token = "0x2000189")]
		private class CredentialEnumerator : IEnumerator
		{
			// Token: 0x06001DAF RID: 7599 RVA: 0x000081F5 File Offset: 0x000063F5
			[global::Cpp2ILInjected.Token(Token = "0x6000A28")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F09CA8", Offset = "0x1F09CA8", Length = "0x1E8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CredentialCache), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			internal CredentialEnumerator(CredentialCache cache, Hashtable table, Hashtable hostTable, int version)
			{
				throw null;
			}

			// Token: 0x1700072D RID: 1837
			// (get) Token: 0x06001DB0 RID: 7600 RVA: 0x000081F8 File Offset: 0x000063F8
			[global::Cpp2ILInjected.Token(Token = "0x1700020F")]
			private object System.Collections.IEnumerator.Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000A29")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F09F40", Offset = "0x1F09F40", Length = "0xA4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06001DB1 RID: 7601 RVA: 0x000081FB File Offset: 0x000063FB
			[global::Cpp2ILInjected.Token(Token = "0x6000A2A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F09FE4", Offset = "0x1F09FE4", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			private bool System.Collections.IEnumerator.MoveNext()
			{
				throw null;
			}

			// Token: 0x06001DB2 RID: 7602 RVA: 0x000081FE File Offset: 0x000063FE
			[global::Cpp2ILInjected.Token(Token = "0x6000A2B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0A084", Offset = "0x1F0A084", Length = "0x100C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x040011BF RID: 4543
			[global::Cpp2ILInjected.Token(Token = "0x40007BA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private CredentialCache m_cache;

			// Token: 0x040011C0 RID: 4544
			[global::Cpp2ILInjected.Token(Token = "0x40007BB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private ICredentials[] m_array;

			// Token: 0x040011C1 RID: 4545
			[global::Cpp2ILInjected.Token(Token = "0x40007BC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int m_index;

			// Token: 0x040011C2 RID: 4546
			[global::Cpp2ILInjected.Token(Token = "0x40007BD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private int m_version;
		}
	}
}
