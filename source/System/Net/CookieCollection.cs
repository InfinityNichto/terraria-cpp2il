using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000212")]
	[Serializable]
	public class CookieCollection : ICollection, IEnumerable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000D13")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2F7C8", Offset = "0x1F2F7C8", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new object[]
		{
			typeof(Cookie),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "CookieCutter", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(CookieCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "InternalGetCookies", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(CookieCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "AddHeader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "get_Cookies", ReturnType = typeof(CookieCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerResponse), Member = "get_Cookies", ReturnType = typeof(CookieCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerResponse), Member = "SetCookie", MemberParameters = new object[] { typeof(Cookie) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebResponse), Member = "get_Cookies", ReturnType = typeof(CookieCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public CookieCollection()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D14")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2F870", Offset = "0x1F2F870", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal CookieCollection(bool IsReadOnly)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002B7")]
		public bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D15")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2F918", Offset = "0x1F2F918", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002B8")]
		public Cookie this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D16")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2F920", Offset = "0x1F2F920", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieCollection.CookieCollectionEnumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "ExpireCollection", MemberParameters = new object[] { typeof(CookieCollection) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "MergeUpdateCollections", MemberParameters = new object[]
			{
				typeof(CookieCollection),
				typeof(CookieCollection),
				typeof(int),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002B9")]
		public Cookie this[string name]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D17")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2F9FC", Offset = "0x1F2F9FC", Length = "0x2E0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(StringComparison)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D18")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2FCDC", Offset = "0x1F2FCDC", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieCollection), Member = "Add", MemberParameters = new object[] { typeof(CookieCollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "AddHeader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerResponse), Member = "AppendCookie", MemberParameters = new object[] { typeof(Cookie) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerResponse), Member = "SetCookie", MemberParameters = new object[] { typeof(Cookie) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieCollection), Member = "IndexOf", MemberParameters = new object[] { typeof(Cookie) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void Add(Cookie cookie)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D19")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F30138", Offset = "0x1F30138", Length = "0x2F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebResponse), Member = "FillCookies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieCollection), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieCollection), Member = "Add", MemberParameters = new object[] { typeof(Cookie) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public void Add(CookieCollection cookies)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002BA")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D1A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F304AC", Offset = "0x1F304AC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebResponse), Member = "FillCookies", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002BB")]
		public bool IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D1B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F304C0", Offset = "0x1F304C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002BC")]
		public object SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D1C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F304C8", Offset = "0x1F304C8", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D1D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F304CC", Offset = "0x1F304CC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void CopyTo(Array array, int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F304E0", Offset = "0x1F304E0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void CopyTo(Cookie[] array, int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D1F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F304F4", Offset = "0x1F304F4", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "BuildCookieCollectionFromDomainMatches", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(bool),
			typeof(int),
			typeof(CookieCollection),
			typeof(List<string>),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal DateTime TimeStamp(CookieCollection.Stamp how)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002BD")]
		internal bool IsOtherVersionSeen
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D20")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F305B4", Offset = "0x1F305B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D21")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F305BC", Offset = "0x1F305BC", Length = "0x45C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new object[]
		{
			typeof(Cookie),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "CookieCutter", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(CookieCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "MergeUpdateCollections", MemberParameters = new object[]
		{
			typeof(CookieCollection),
			typeof(CookieCollection),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		internal int InternalAdd(Cookie cookie, bool isStrict)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D22")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2FD94", Offset = "0x1F2FD94", Length = "0x3A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieCollection), Member = "Add", MemberParameters = new object[] { typeof(Cookie) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new object[]
		{
			typeof(Cookie),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		internal int IndexOf(Cookie cookie)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D23")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F30A18", Offset = "0x1F30A18", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void RemoveAt(int idx)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D24")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F30428", Offset = "0x1F30428", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieCollection), Member = "Add", MemberParameters = new object[] { typeof(CookieCollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new object[] { typeof(CookieCollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(CookieCollection)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "CookieCutter", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(CookieCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "GetCookieHeader", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ref string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerResponse), Member = "FindCookie", MemberParameters = new object[] { typeof(Cookie) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerResponse), Member = "SendHeaders", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(MemoryStream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IEnumerator GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000B34")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int m_version;

		[global::Cpp2ILInjected.Token(Token = "0x4000B35")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ArrayList m_list;

		[global::Cpp2ILInjected.Token(Token = "0x4000B36")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private DateTime m_TimeStamp;

		[global::Cpp2ILInjected.Token(Token = "0x4000B37")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool m_has_other_versions;

		[OptionalField]
		[global::Cpp2ILInjected.Token(Token = "0x4000B38")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		private bool m_IsReadOnly;

		[global::Cpp2ILInjected.Token(Token = "0x2000213")]
		internal enum Stamp
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000B3A")]
			Check,
			[global::Cpp2ILInjected.Token(Token = "0x4000B3B")]
			Set,
			[global::Cpp2ILInjected.Token(Token = "0x4000B3C")]
			SetToUnused,
			[global::Cpp2ILInjected.Token(Token = "0x4000B3D")]
			SetToMaxUsed
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000214")]
		private class CookieCollectionEnumerator : IEnumerator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D25")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F30A2C", Offset = "0x1F30A2C", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal CookieCollectionEnumerator(CookieCollection cookies)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x170002BE")]
			private object System.Collections.IEnumerator.Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000D26")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F30A7C", Offset = "0x1F30A7C", Length = "0x9C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Cookie))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000D27")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F30B18", Offset = "0x1F30B18", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			private bool System.Collections.IEnumerator.MoveNext()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000D28")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F30BAC", Offset = "0x1F30BAC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000B3E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private CookieCollection m_cookies;

			[global::Cpp2ILInjected.Token(Token = "0x4000B3F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private int m_count;

			[global::Cpp2ILInjected.Token(Token = "0x4000B40")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private int m_index;

			[global::Cpp2ILInjected.Token(Token = "0x4000B41")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int m_version;
		}
	}
}
