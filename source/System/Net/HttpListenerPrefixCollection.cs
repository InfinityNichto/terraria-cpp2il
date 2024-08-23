using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000198 RID: 408
	[global::Cpp2ILInjected.Token(Token = "0x200024D")]
	public class HttpListenerPrefixCollection : ICollection<string>, IEnumerable<string>, IEnumerable
	{
		// Token: 0x06000D84 RID: 3460 RVA: 0x000054CB File Offset: 0x000036CB
		[global::Cpp2ILInjected.Token(Token = "0x6000F08")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4C44C", Offset = "0x1F4C44C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal HttpListenerPrefixCollection(HttpListener listener)
		{
			throw null;
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000D85 RID: 3461 RVA: 0x000054CE File Offset: 0x000036CE
		[global::Cpp2ILInjected.Token(Token = "0x17000324")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F09")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4DB2C", Offset = "0x1F4DB2C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000D86 RID: 3462 RVA: 0x000054D1 File Offset: 0x000036D1
		[global::Cpp2ILInjected.Token(Token = "0x17000325")]
		public bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F0A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4E3DC", Offset = "0x1F4E3DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000D87 RID: 3463 RVA: 0x000054D4 File Offset: 0x000036D4
		[global::Cpp2ILInjected.Token(Token = "0x17000326")]
		public bool IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F0B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4E3E4", Offset = "0x1F4E3E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x000054D7 File Offset: 0x000036D7
		[global::Cpp2ILInjected.Token(Token = "0x6000F0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4E3EC", Offset = "0x1F4E3EC", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListenerPrefix), Member = "CheckUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndPointManager), Member = "AddPrefix", MemberParameters = new object[]
		{
			typeof(string),
			typeof(HttpListener)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Add(string uriPrefix)
		{
			throw null;
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x000054DA File Offset: 0x000036DA
		[global::Cpp2ILInjected.Token(Token = "0x6000F0D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4E510", Offset = "0x1F4E510", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndPointManager), Member = "RemoveListener", MemberParameters = new object[] { typeof(HttpListener) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x000054DD File Offset: 0x000036DD
		[global::Cpp2ILInjected.Token(Token = "0x6000F0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4E5B8", Offset = "0x1F4E5B8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool Contains(string uriPrefix)
		{
			throw null;
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x000054E0 File Offset: 0x000036E0
		[global::Cpp2ILInjected.Token(Token = "0x6000F0F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4E618", Offset = "0x1F4E618", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void CopyTo(string[] array, int offset)
		{
			throw null;
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x000054E3 File Offset: 0x000036E3
		[global::Cpp2ILInjected.Token(Token = "0x6000F10")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4E680", Offset = "0x1F4E680", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void CopyTo(Array array, int offset)
		{
			throw null;
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x000054E6 File Offset: 0x000036E6
		[global::Cpp2ILInjected.Token(Token = "0x6000F11")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F476EC", Offset = "0x1F476EC", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointManager), Member = "AddListener", MemberParameters = new object[] { typeof(HttpListener) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointManager), Member = "RemoveListener", MemberParameters = new object[] { typeof(HttpListener) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public IEnumerator<string> GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x000054E9 File Offset: 0x000036E9
		[global::Cpp2ILInjected.Token(Token = "0x6000F12")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4E738", Offset = "0x1F4E738", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x000054EC File Offset: 0x000036EC
		[global::Cpp2ILInjected.Token(Token = "0x6000F13")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4E7C8", Offset = "0x1F4E7C8", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndPointManager), Member = "RemovePrefix", MemberParameters = new object[]
		{
			typeof(string),
			typeof(HttpListener)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public bool Remove(string uriPrefix)
		{
			throw null;
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x000054EF File Offset: 0x000036EF
		[global::Cpp2ILInjected.Token(Token = "0x6000F14")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4E8BC", Offset = "0x1F4E8BC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal HttpListenerPrefixCollection()
		{
			throw null;
		}

		// Token: 0x04000979 RID: 2425
		[global::Cpp2ILInjected.Token(Token = "0x4000C30")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<string> prefixes;

		// Token: 0x0400097A RID: 2426
		[global::Cpp2ILInjected.Token(Token = "0x4000C31")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private HttpListener listener;
	}
}
