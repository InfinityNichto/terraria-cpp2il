using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000172 RID: 370
	[global::Cpp2ILInjected.Token(Token = "0x2000212")]
	[Serializable]
	public class CookieCollection : ICollection, IEnumerable
	{
		// Token: 0x06000BBC RID: 3004 RVA: 0x00004F94 File Offset: 0x00003194
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

		// Token: 0x06000BBD RID: 3005 RVA: 0x00004F97 File Offset: 0x00003197
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

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000BBE RID: 3006 RVA: 0x00004F9A File Offset: 0x0000319A
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

		// Token: 0x1700029E RID: 670
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

		// Token: 0x1700029F RID: 671
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

		// Token: 0x06000BC1 RID: 3009 RVA: 0x00004FA3 File Offset: 0x000031A3
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

		// Token: 0x06000BC2 RID: 3010 RVA: 0x00004FA6 File Offset: 0x000031A6
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

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x00004FA9 File Offset: 0x000031A9
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

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x00004FAC File Offset: 0x000031AC
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

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x00004FAF File Offset: 0x000031AF
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

		// Token: 0x06000BC6 RID: 3014 RVA: 0x00004FB2 File Offset: 0x000031B2
		[global::Cpp2ILInjected.Token(Token = "0x6000D1D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F304CC", Offset = "0x1F304CC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void CopyTo(Array array, int index)
		{
			throw null;
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x00004FB5 File Offset: 0x000031B5
		[global::Cpp2ILInjected.Token(Token = "0x6000D1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F304E0", Offset = "0x1F304E0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void CopyTo(Cookie[] array, int index)
		{
			throw null;
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x00004FB8 File Offset: 0x000031B8
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

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x00004FBB File Offset: 0x000031BB
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

		// Token: 0x06000BCA RID: 3018 RVA: 0x00004FBE File Offset: 0x000031BE
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

		// Token: 0x06000BCB RID: 3019 RVA: 0x00004FC1 File Offset: 0x000031C1
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

		// Token: 0x06000BCC RID: 3020 RVA: 0x00004FC4 File Offset: 0x000031C4
		[global::Cpp2ILInjected.Token(Token = "0x6000D23")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F30A18", Offset = "0x1F30A18", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void RemoveAt(int idx)
		{
			throw null;
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x00004FC7 File Offset: 0x000031C7
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

		// Token: 0x040008D1 RID: 2257
		[global::Cpp2ILInjected.Token(Token = "0x4000B34")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int m_version;

		// Token: 0x040008D2 RID: 2258
		[global::Cpp2ILInjected.Token(Token = "0x4000B35")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ArrayList m_list;

		// Token: 0x040008D3 RID: 2259
		[global::Cpp2ILInjected.Token(Token = "0x4000B36")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private DateTime m_TimeStamp;

		// Token: 0x040008D4 RID: 2260
		[global::Cpp2ILInjected.Token(Token = "0x4000B37")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool m_has_other_versions;

		// Token: 0x040008D5 RID: 2261
		[OptionalField]
		[global::Cpp2ILInjected.Token(Token = "0x4000B38")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		private bool m_IsReadOnly;

		// Token: 0x02000407 RID: 1031
		[global::Cpp2ILInjected.Token(Token = "0x2000213")]
		internal enum Stamp
		{
			// Token: 0x04001210 RID: 4624
			[global::Cpp2ILInjected.Token(Token = "0x4000B3A")]
			Check,
			// Token: 0x04001211 RID: 4625
			[global::Cpp2ILInjected.Token(Token = "0x4000B3B")]
			Set,
			// Token: 0x04001212 RID: 4626
			[global::Cpp2ILInjected.Token(Token = "0x4000B3C")]
			SetToUnused,
			// Token: 0x04001213 RID: 4627
			[global::Cpp2ILInjected.Token(Token = "0x4000B3D")]
			SetToMaxUsed
		}

		// Token: 0x02000408 RID: 1032
		[global::Cpp2ILInjected.Token(Token = "0x2000214")]
		private class CookieCollectionEnumerator : IEnumerator
		{
			// Token: 0x06001DFB RID: 7675 RVA: 0x000082C4 File Offset: 0x000064C4
			[global::Cpp2ILInjected.Token(Token = "0x6000D25")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F30A2C", Offset = "0x1F30A2C", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal CookieCollectionEnumerator(CookieCollection cookies)
			{
				throw null;
			}

			// Token: 0x1700073D RID: 1853
			// (get) Token: 0x06001DFC RID: 7676 RVA: 0x000082C7 File Offset: 0x000064C7
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

			// Token: 0x06001DFD RID: 7677 RVA: 0x000082CA File Offset: 0x000064CA
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

			// Token: 0x06001DFE RID: 7678 RVA: 0x000082CD File Offset: 0x000064CD
			[global::Cpp2ILInjected.Token(Token = "0x6000D28")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F30BAC", Offset = "0x1F30BAC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x04001214 RID: 4628
			[global::Cpp2ILInjected.Token(Token = "0x4000B3E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private CookieCollection m_cookies;

			// Token: 0x04001215 RID: 4629
			[global::Cpp2ILInjected.Token(Token = "0x4000B3F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private int m_count;

			// Token: 0x04001216 RID: 4630
			[global::Cpp2ILInjected.Token(Token = "0x4000B40")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private int m_index;

			// Token: 0x04001217 RID: 4631
			[global::Cpp2ILInjected.Token(Token = "0x4000B41")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int m_version;
		}
	}
}
