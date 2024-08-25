using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000188")]
	public class CredentialCache : ICredentials, ICredentialsByHost, IEnumerable
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x40007B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Hashtable cache;

		[global::Cpp2ILInjected.Token(Token = "0x40007B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Hashtable cacheForHosts;

		[global::Cpp2ILInjected.Token(Token = "0x40007B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int m_version;

		[global::Cpp2ILInjected.Token(Token = "0x40007B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int m_NumbDefaultCredInCache;

		[global::Cpp2ILInjected.Token(Token = "0x2000189")]
		private class CredentialEnumerator : IEnumerator
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x6000A2B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0A084", Offset = "0x1F0A084", Length = "0x100C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40007BA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private CredentialCache m_cache;

			[global::Cpp2ILInjected.Token(Token = "0x40007BB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private ICredentials[] m_array;

			[global::Cpp2ILInjected.Token(Token = "0x40007BC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int m_index;

			[global::Cpp2ILInjected.Token(Token = "0x40007BD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private int m_version;
		}
	}
}
