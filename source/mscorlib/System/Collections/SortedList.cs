using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections
{
	// Token: 0x02000500 RID: 1280
	[global::System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[global::System.Diagnostics.DebuggerTypeProxy(typeof(SortedList.SortedListDebugView))]
	[global::Cpp2ILInjected.Token(Token = "0x20005FA")]
	[global::System.Serializable]
	public class SortedList : IDictionary, ICollection, IEnumerable, global::System.ICloneable
	{
		// Token: 0x06002AB7 RID: 10935 RVA: 0x0001BBEA File Offset: 0x00019DEA
		[global::Cpp2ILInjected.Token(Token = "0x6002E32")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0A3D0", Offset = "0x1C0A3D0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlSchemaSet", Member = ".ctor", MemberParameters = new object[] { "System.Xml.XmlNameTable" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SortedList()
		{
			throw null;
		}

		// Token: 0x06002AB8 RID: 10936 RVA: 0x0001BBED File Offset: 0x00019DED
		[global::Cpp2ILInjected.Token(Token = "0x6002E33")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0A3EC", Offset = "0x1C0A3EC", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SortedList.SyncSortedList), Member = ".ctor", MemberParameters = new object[] { typeof(SortedList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SortedList), Member = ".ctor", MemberParameters = new object[] { typeof(IComparer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparer), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Globalization.CultureInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private void Init()
		{
			throw null;
		}

		// Token: 0x06002AB9 RID: 10937 RVA: 0x0001BBF0 File Offset: 0x00019DF0
		[global::Cpp2ILInjected.Token(Token = "0x6002E34")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0A518", Offset = "0x1C0A518", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SortedList), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparer), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Globalization.CultureInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public SortedList(int initialCapacity)
		{
			throw null;
		}

		// Token: 0x06002ABA RID: 10938 RVA: 0x0001BBF3 File Offset: 0x00019DF3
		[global::Cpp2ILInjected.Token(Token = "0x6002E35")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0A650", Offset = "0x1C0A650", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.PathList", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortedList), Member = "Init", ReturnType = typeof(void))]
		public SortedList(IComparer comparer)
		{
			throw null;
		}

		// Token: 0x06002ABB RID: 10939 RVA: 0x0001BBF6 File Offset: 0x00019DF6
		[global::Cpp2ILInjected.Token(Token = "0x6002E36")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0A684", Offset = "0x1C0A684", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "BinarySearch", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int),
			typeof(object),
			typeof(IComparer)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public virtual void Add(object key, object value)
		{
			throw null;
		}

		// Token: 0x17000689 RID: 1673
		// (set) Token: 0x06002ABC RID: 10940 RVA: 0x0001BBF9 File Offset: 0x00019DF9
		[global::Cpp2ILInjected.Token(Token = "0x17000729")]
		public virtual int Capacity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002E37")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0A8D4", Offset = "0x1C0A8D4", Length = "0x1DC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
			{
				typeof(global::System.Array),
				typeof(int),
				typeof(global::System.Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06002ABD RID: 10941 RVA: 0x0001BBFC File Offset: 0x00019DFC
		[global::Cpp2ILInjected.Token(Token = "0x1700072A")]
		public virtual int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002E38")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0AAB0", Offset = "0x1C0AAB0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06002ABE RID: 10942 RVA: 0x0001BBFF File Offset: 0x00019DFF
		[global::Cpp2ILInjected.Token(Token = "0x1700072B")]
		public virtual ICollection Keys
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002E39")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0AAB8", Offset = "0x1C0AAB8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06002ABF RID: 10943 RVA: 0x0001BC02 File Offset: 0x00019E02
		[global::Cpp2ILInjected.Token(Token = "0x1700072C")]
		public virtual ICollection Values
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002E3A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0AAC8", Offset = "0x1C0AAC8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06002AC0 RID: 10944 RVA: 0x0001BC05 File Offset: 0x00019E05
		[global::Cpp2ILInjected.Token(Token = "0x1700072D")]
		public virtual bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002E3B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0AAD8", Offset = "0x1C0AAD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06002AC1 RID: 10945 RVA: 0x0001BC08 File Offset: 0x00019E08
		[global::Cpp2ILInjected.Token(Token = "0x1700072E")]
		public virtual bool IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002E3C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0AAE0", Offset = "0x1C0AAE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06002AC2 RID: 10946 RVA: 0x0001BC0B File Offset: 0x00019E0B
		[global::Cpp2ILInjected.Token(Token = "0x1700072F")]
		public virtual bool IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002E3D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0AAE8", Offset = "0x1C0AAE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06002AC3 RID: 10947 RVA: 0x0001BC0E File Offset: 0x00019E0E
		[global::Cpp2ILInjected.Token(Token = "0x17000730")]
		public virtual object SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002E3E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0AAF0", Offset = "0x1C0AAF0", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002AC4 RID: 10948 RVA: 0x0001BC11 File Offset: 0x00019E11
		[global::Cpp2ILInjected.Token(Token = "0x6002E3F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0AB60", Offset = "0x1C0AB60", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public virtual void Clear()
		{
			throw null;
		}

		// Token: 0x06002AC5 RID: 10949 RVA: 0x0001BC14 File Offset: 0x00019E14
		[global::Cpp2ILInjected.Token(Token = "0x6002E40")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0ABA4", Offset = "0x1C0ABA4", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortedList), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual object Clone()
		{
			throw null;
		}

		// Token: 0x06002AC6 RID: 10950 RVA: 0x0001BC17 File Offset: 0x00019E17
		[global::Cpp2ILInjected.Token(Token = "0x6002E41")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0AC48", Offset = "0x1C0AC48", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual bool Contains(object key)
		{
			throw null;
		}

		// Token: 0x06002AC7 RID: 10951 RVA: 0x0001BC1A File Offset: 0x00019E1A
		[global::Cpp2ILInjected.Token(Token = "0x6002E42")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0AC6C", Offset = "0x1C0AC6C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual bool ContainsValue(object value)
		{
			throw null;
		}

		// Token: 0x06002AC8 RID: 10952 RVA: 0x0001BC1D File Offset: 0x00019E1D
		[global::Cpp2ILInjected.Token(Token = "0x6002E43")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0AC90", Offset = "0x1C0AC90", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Rank", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public virtual void CopyTo(global::System.Array array, int arrayIndex)
		{
			throw null;
		}

		// Token: 0x06002AC9 RID: 10953 RVA: 0x0001BC20 File Offset: 0x00019E20
		[global::Cpp2ILInjected.Token(Token = "0x6002E44")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0AED0", Offset = "0x1C0AED0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void EnsureCapacity(int min)
		{
			throw null;
		}

		// Token: 0x06002ACA RID: 10954 RVA: 0x0001BC23 File Offset: 0x00019E23
		[global::Cpp2ILInjected.Token(Token = "0x6002E45")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0AF0C", Offset = "0x1C0AF0C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual object GetByIndex(int index)
		{
			throw null;
		}

		// Token: 0x06002ACB RID: 10955 RVA: 0x0001BC26 File Offset: 0x00019E26
		[global::Cpp2ILInjected.Token(Token = "0x6002E46")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0AFAC", Offset = "0x1C0AFAC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06002ACC RID: 10956 RVA: 0x0001BC29 File Offset: 0x00019E29
		[global::Cpp2ILInjected.Token(Token = "0x6002E47")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0B080", Offset = "0x1C0B080", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual IDictionaryEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06002ACD RID: 10957 RVA: 0x0001BC2C File Offset: 0x00019E2C
		[global::Cpp2ILInjected.Token(Token = "0x6002E48")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0B0FC", Offset = "0x1C0B0FC", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual object GetKey(int index)
		{
			throw null;
		}

		// Token: 0x06002ACE RID: 10958 RVA: 0x0001BC2F File Offset: 0x00019E2F
		[global::Cpp2ILInjected.Token(Token = "0x6002E49")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0B19C", Offset = "0x1C0B19C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual IList GetKeyList()
		{
			throw null;
		}

		// Token: 0x06002ACF RID: 10959 RVA: 0x0001BC32 File Offset: 0x00019E32
		[global::Cpp2ILInjected.Token(Token = "0x6002E4A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0B22C", Offset = "0x1C0B22C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual IList GetValueList()
		{
			throw null;
		}

		// Token: 0x17000691 RID: 1681
		[global::Cpp2ILInjected.Token(Token = "0x17000731")]
		public virtual object this[object key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002E4B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0B2BC", Offset = "0x1C0B2BC", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002E4C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0B2F4", Offset = "0x1C0B2F4", Length = "0x108")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "BinarySearch", MemberParameters = new object[]
			{
				typeof(global::System.Array),
				typeof(int),
				typeof(int),
				typeof(object),
				typeof(IComparer)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortedList), Member = "Insert", MemberParameters = new object[]
			{
				typeof(int),
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06002AD2 RID: 10962 RVA: 0x0001BC3B File Offset: 0x00019E3B
		[global::Cpp2ILInjected.Token(Token = "0x6002E4D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0B3FC", Offset = "0x1C0B3FC", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "BinarySearch", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int),
			typeof(object),
			typeof(IComparer)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual int IndexOfKey(object key)
		{
			throw null;
		}

		// Token: 0x06002AD3 RID: 10963 RVA: 0x0001BC3E File Offset: 0x00019E3E
		[global::Cpp2ILInjected.Token(Token = "0x6002E4E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0B498", Offset = "0x1C0B498", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array[]), Member = "IndexOf", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(object),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual int IndexOfValue(object value)
		{
			throw null;
		}

		// Token: 0x06002AD4 RID: 10964 RVA: 0x0001BC41 File Offset: 0x00019E41
		[global::Cpp2ILInjected.Token(Token = "0x6002E4F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0A7A8", Offset = "0x1C0A7A8", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SortedList), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void Insert(int index, object key, object value)
		{
			throw null;
		}

		// Token: 0x06002AD5 RID: 10965 RVA: 0x0001BC44 File Offset: 0x00019E44
		[global::Cpp2ILInjected.Token(Token = "0x6002E50")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0B4F8", Offset = "0x1C0B4F8", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual void RemoveAt(int index)
		{
			throw null;
		}

		// Token: 0x06002AD6 RID: 10966 RVA: 0x0001BC47 File Offset: 0x00019E47
		[global::Cpp2ILInjected.Token(Token = "0x6002E51")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0B604", Offset = "0x1C0B604", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Remove(object key)
		{
			throw null;
		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x0001BC4A File Offset: 0x00019E4A
		[global::Cpp2ILInjected.Token(Token = "0x6002E52")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0B644", Offset = "0x1C0B644", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.PathList", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortedList.SyncSortedList), Member = ".ctor", MemberParameters = new object[] { typeof(SortedList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static SortedList Synchronized(SortedList list)
		{
			throw null;
		}

		// Token: 0x040015C4 RID: 5572
		[global::Cpp2ILInjected.Token(Token = "0x40019C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object[] keys;

		// Token: 0x040015C5 RID: 5573
		[global::Cpp2ILInjected.Token(Token = "0x40019C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object[] values;

		// Token: 0x040015C6 RID: 5574
		[global::Cpp2ILInjected.Token(Token = "0x40019C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _size;

		// Token: 0x040015C7 RID: 5575
		[global::Cpp2ILInjected.Token(Token = "0x40019C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int version;

		// Token: 0x040015C8 RID: 5576
		[global::Cpp2ILInjected.Token(Token = "0x40019CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private IComparer comparer;

		// Token: 0x040015C9 RID: 5577
		[global::Cpp2ILInjected.Token(Token = "0x40019CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private SortedList.KeyList keyList;

		// Token: 0x040015CA RID: 5578
		[global::Cpp2ILInjected.Token(Token = "0x40019CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private SortedList.ValueList valueList;

		// Token: 0x040015CB RID: 5579
		[global::Cpp2ILInjected.Token(Token = "0x40019CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		[global::System.NonSerialized]
		private object _syncRoot;

		// Token: 0x02000643 RID: 1603
		[global::Cpp2ILInjected.Token(Token = "0x20005FB")]
		[global::System.Serializable]
		private class SyncSortedList : SortedList
		{
			// Token: 0x0600424B RID: 16971 RVA: 0x00020135 File Offset: 0x0001E335
			[global::Cpp2ILInjected.Token(Token = "0x6002E53")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0B6E8", Offset = "0x1C0B6E8", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SortedList), Member = "Synchronized", MemberParameters = new object[] { typeof(SortedList) }, ReturnType = typeof(SortedList))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortedList), Member = "Init", ReturnType = typeof(void))]
			internal SyncSortedList(SortedList list)
			{
				throw null;
			}

			// Token: 0x1700079A RID: 1946
			// (get) Token: 0x0600424C RID: 16972 RVA: 0x00020138 File Offset: 0x0001E338
			[global::Cpp2ILInjected.Token(Token = "0x17000732")]
			public override int Count
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002E54")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0B730", Offset = "0x1C0B730", Length = "0xD8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
				{
					typeof(object),
					typeof(ref bool)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700079B RID: 1947
			// (get) Token: 0x0600424D RID: 16973 RVA: 0x0002013B File Offset: 0x0001E33B
			[global::Cpp2ILInjected.Token(Token = "0x17000733")]
			public override object SyncRoot
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002E55")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0B808", Offset = "0x1C0B808", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700079C RID: 1948
			// (get) Token: 0x0600424E RID: 16974 RVA: 0x0002013E File Offset: 0x0001E33E
			[global::Cpp2ILInjected.Token(Token = "0x17000734")]
			public override bool IsReadOnly
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002E56")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0B810", Offset = "0x1C0B810", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700079D RID: 1949
			// (get) Token: 0x0600424F RID: 16975 RVA: 0x00020141 File Offset: 0x0001E341
			[global::Cpp2ILInjected.Token(Token = "0x17000735")]
			public override bool IsFixedSize
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002E57")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0B824", Offset = "0x1C0B824", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700079E RID: 1950
			// (get) Token: 0x06004250 RID: 16976 RVA: 0x00020144 File Offset: 0x0001E344
			[global::Cpp2ILInjected.Token(Token = "0x17000736")]
			public override bool IsSynchronized
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002E58")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0B838", Offset = "0x1C0B838", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700079F RID: 1951
			[global::Cpp2ILInjected.Token(Token = "0x17000737")]
			public override object this[object key]
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002E59")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0B840", Offset = "0x1C0B840", Length = "0xE0")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
				{
					typeof(object),
					typeof(ref bool)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6002E5A")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0B920", Offset = "0x1C0B920", Length = "0xDC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
				{
					typeof(object),
					typeof(ref bool)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
				set
				{
					throw null;
				}
			}

			// Token: 0x06004253 RID: 16979 RVA: 0x0002014D File Offset: 0x0001E34D
			[global::Cpp2ILInjected.Token(Token = "0x6002E5B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0B9FC", Offset = "0x1C0B9FC", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override void Add(object key, object value)
			{
				throw null;
			}

			// Token: 0x06004254 RID: 16980 RVA: 0x00020150 File Offset: 0x0001E350
			[global::Cpp2ILInjected.Token(Token = "0x6002E5C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0BAD8", Offset = "0x1C0BAD8", Length = "0xCC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override void Clear()
			{
				throw null;
			}

			// Token: 0x06004255 RID: 16981 RVA: 0x00020153 File Offset: 0x0001E353
			[global::Cpp2ILInjected.Token(Token = "0x6002E5D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0BBA4", Offset = "0x1C0BBA4", Length = "0xD8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override object Clone()
			{
				throw null;
			}

			// Token: 0x06004256 RID: 16982 RVA: 0x00020156 File Offset: 0x0001E356
			[global::Cpp2ILInjected.Token(Token = "0x6002E5E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0BC7C", Offset = "0x1C0BC7C", Length = "0xE0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override bool Contains(object key)
			{
				throw null;
			}

			// Token: 0x06004257 RID: 16983 RVA: 0x00020159 File Offset: 0x0001E359
			[global::Cpp2ILInjected.Token(Token = "0x6002E5F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0BD5C", Offset = "0x1C0BD5C", Length = "0xE0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override bool ContainsValue(object key)
			{
				throw null;
			}

			// Token: 0x06004258 RID: 16984 RVA: 0x0002015C File Offset: 0x0001E35C
			[global::Cpp2ILInjected.Token(Token = "0x6002E60")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0BE3C", Offset = "0x1C0BE3C", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override void CopyTo(global::System.Array array, int index)
			{
				throw null;
			}

			// Token: 0x06004259 RID: 16985 RVA: 0x0002015F File Offset: 0x0001E35F
			[global::Cpp2ILInjected.Token(Token = "0x6002E61")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0BF18", Offset = "0x1C0BF18", Length = "0xE0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override object GetByIndex(int index)
			{
				throw null;
			}

			// Token: 0x0600425A RID: 16986 RVA: 0x00020162 File Offset: 0x0001E362
			[global::Cpp2ILInjected.Token(Token = "0x6002E62")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0BFF8", Offset = "0x1C0BFF8", Length = "0xD8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override IDictionaryEnumerator GetEnumerator()
			{
				throw null;
			}

			// Token: 0x0600425B RID: 16987 RVA: 0x00020165 File Offset: 0x0001E365
			[global::Cpp2ILInjected.Token(Token = "0x6002E63")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0C0D0", Offset = "0x1C0C0D0", Length = "0xE0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override object GetKey(int index)
			{
				throw null;
			}

			// Token: 0x0600425C RID: 16988 RVA: 0x00020168 File Offset: 0x0001E368
			[global::Cpp2ILInjected.Token(Token = "0x6002E64")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0C1B0", Offset = "0x1C0C1B0", Length = "0xD8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override IList GetKeyList()
			{
				throw null;
			}

			// Token: 0x0600425D RID: 16989 RVA: 0x0002016B File Offset: 0x0001E36B
			[global::Cpp2ILInjected.Token(Token = "0x6002E65")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0C288", Offset = "0x1C0C288", Length = "0xD8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override IList GetValueList()
			{
				throw null;
			}

			// Token: 0x0600425E RID: 16990 RVA: 0x0002016E File Offset: 0x0001E36E
			[global::Cpp2ILInjected.Token(Token = "0x6002E66")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0C360", Offset = "0x1C0C360", Length = "0x144")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			public override int IndexOfKey(object key)
			{
				throw null;
			}

			// Token: 0x0600425F RID: 16991 RVA: 0x00020171 File Offset: 0x0001E371
			[global::Cpp2ILInjected.Token(Token = "0x6002E67")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0C4A4", Offset = "0x1C0C4A4", Length = "0xE0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override int IndexOfValue(object value)
			{
				throw null;
			}

			// Token: 0x06004260 RID: 16992 RVA: 0x00020174 File Offset: 0x0001E374
			[global::Cpp2ILInjected.Token(Token = "0x6002E68")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0C584", Offset = "0x1C0C584", Length = "0xD4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override void RemoveAt(int index)
			{
				throw null;
			}

			// Token: 0x06004261 RID: 16993 RVA: 0x00020177 File Offset: 0x0001E377
			[global::Cpp2ILInjected.Token(Token = "0x6002E69")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0C658", Offset = "0x1C0C658", Length = "0xD4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override void Remove(object key)
			{
				throw null;
			}

			// Token: 0x04001A83 RID: 6787
			[global::Cpp2ILInjected.Token(Token = "0x40019CE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private SortedList _list;

			// Token: 0x04001A84 RID: 6788
			[global::Cpp2ILInjected.Token(Token = "0x40019CF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private object _root;
		}

		// Token: 0x02000644 RID: 1604
		[global::Cpp2ILInjected.Token(Token = "0x20005FC")]
		[global::System.Serializable]
		private class SortedListEnumerator : IDictionaryEnumerator, IEnumerator, global::System.ICloneable
		{
			// Token: 0x06004262 RID: 16994 RVA: 0x0002017A File Offset: 0x0001E37A
			[global::Cpp2ILInjected.Token(Token = "0x6002E6A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0B028", Offset = "0x1C0B028", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal SortedListEnumerator(SortedList sortedList, int index, int count, int getObjRetType)
			{
				throw null;
			}

			// Token: 0x06004263 RID: 16995 RVA: 0x0002017D File Offset: 0x0001E37D
			[global::Cpp2ILInjected.Token(Token = "0x6002E6B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0C72C", Offset = "0x1C0C72C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "MemberwiseClone", ReturnType = typeof(object))]
			public object Clone()
			{
				throw null;
			}

			// Token: 0x170007A0 RID: 1952
			// (get) Token: 0x06004264 RID: 16996 RVA: 0x00020180 File Offset: 0x0001E380
			[global::Cpp2ILInjected.Token(Token = "0x17000738")]
			public virtual object Key
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002E6C")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0C734", Offset = "0x1C0C734", Length = "0x94")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004265 RID: 16997 RVA: 0x00020183 File Offset: 0x0001E383
			[global::Cpp2ILInjected.Token(Token = "0x6002E6D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0C7C8", Offset = "0x1C0C7C8", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public virtual bool MoveNext()
			{
				throw null;
			}

			// Token: 0x170007A1 RID: 1953
			// (get) Token: 0x06004266 RID: 16998 RVA: 0x00020186 File Offset: 0x0001E386
			[global::Cpp2ILInjected.Token(Token = "0x17000739")]
			public virtual DictionaryEntry Entry
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002E6E")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0C880", Offset = "0x1C0C880", Length = "0x98")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007A2 RID: 1954
			// (get) Token: 0x06004267 RID: 16999 RVA: 0x00020189 File Offset: 0x0001E389
			[global::Cpp2ILInjected.Token(Token = "0x1700073A")]
			public virtual object Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002E6F")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0C918", Offset = "0x1C0C918", Length = "0xD0")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007A3 RID: 1955
			// (get) Token: 0x06004268 RID: 17000 RVA: 0x0002018C File Offset: 0x0001E38C
			[global::Cpp2ILInjected.Token(Token = "0x1700073B")]
			public virtual object Value
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002E70")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0C9E8", Offset = "0x1C0C9E8", Length = "0x94")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004269 RID: 17001 RVA: 0x0002018F File Offset: 0x0001E38F
			[global::Cpp2ILInjected.Token(Token = "0x6002E71")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0CA7C", Offset = "0x1C0CA7C", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public virtual void Reset()
			{
				throw null;
			}

			// Token: 0x04001A85 RID: 6789
			[global::Cpp2ILInjected.Token(Token = "0x40019D0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private SortedList _sortedList;

			// Token: 0x04001A86 RID: 6790
			[global::Cpp2ILInjected.Token(Token = "0x40019D1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private object _key;

			// Token: 0x04001A87 RID: 6791
			[global::Cpp2ILInjected.Token(Token = "0x40019D2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private object _value;

			// Token: 0x04001A88 RID: 6792
			[global::Cpp2ILInjected.Token(Token = "0x40019D3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private int _index;

			// Token: 0x04001A89 RID: 6793
			[global::Cpp2ILInjected.Token(Token = "0x40019D4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
			private int _startIndex;

			// Token: 0x04001A8A RID: 6794
			[global::Cpp2ILInjected.Token(Token = "0x40019D5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private int _endIndex;

			// Token: 0x04001A8B RID: 6795
			[global::Cpp2ILInjected.Token(Token = "0x40019D6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
			private int _version;

			// Token: 0x04001A8C RID: 6796
			[global::Cpp2ILInjected.Token(Token = "0x40019D7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private bool _current;

			// Token: 0x04001A8D RID: 6797
			[global::Cpp2ILInjected.Token(Token = "0x40019D8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
			private int _getObjectRetType;
		}

		// Token: 0x02000645 RID: 1605
		[global::System.Runtime.CompilerServices.TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
		[global::Cpp2ILInjected.Token(Token = "0x20005FD")]
		[global::System.Serializable]
		private class KeyList : IList, ICollection, IEnumerable
		{
			// Token: 0x0600426A RID: 17002 RVA: 0x00020192 File Offset: 0x0001E392
			[global::Cpp2ILInjected.Token(Token = "0x6002E72")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0B204", Offset = "0x1C0B204", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal KeyList(SortedList sortedList)
			{
				throw null;
			}

			// Token: 0x170007A4 RID: 1956
			// (get) Token: 0x0600426B RID: 17003 RVA: 0x00020195 File Offset: 0x0001E395
			[global::Cpp2ILInjected.Token(Token = "0x1700073C")]
			public virtual int Count
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002E73")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0CAF4", Offset = "0x1C0CAF4", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007A5 RID: 1957
			// (get) Token: 0x0600426C RID: 17004 RVA: 0x00020198 File Offset: 0x0001E398
			[global::Cpp2ILInjected.Token(Token = "0x1700073D")]
			public virtual bool IsReadOnly
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002E74")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0CB00", Offset = "0x1C0CB00", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007A6 RID: 1958
			// (get) Token: 0x0600426D RID: 17005 RVA: 0x0002019B File Offset: 0x0001E39B
			[global::Cpp2ILInjected.Token(Token = "0x1700073E")]
			public virtual bool IsFixedSize
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002E75")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0CB08", Offset = "0x1C0CB08", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007A7 RID: 1959
			// (get) Token: 0x0600426E RID: 17006 RVA: 0x0002019E File Offset: 0x0001E39E
			[global::Cpp2ILInjected.Token(Token = "0x1700073F")]
			public virtual bool IsSynchronized
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002E76")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0CB10", Offset = "0x1C0CB10", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007A8 RID: 1960
			// (get) Token: 0x0600426F RID: 17007 RVA: 0x000201A1 File Offset: 0x0001E3A1
			[global::Cpp2ILInjected.Token(Token = "0x17000740")]
			public virtual object SyncRoot
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002E77")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0CB24", Offset = "0x1C0CB24", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004270 RID: 17008 RVA: 0x000201A4 File Offset: 0x0001E3A4
			[global::Cpp2ILInjected.Token(Token = "0x6002E78")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0CB38", Offset = "0x1C0CB38", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public virtual int Add(object key)
			{
				throw null;
			}

			// Token: 0x06004271 RID: 17009 RVA: 0x000201A7 File Offset: 0x0001E3A7
			[global::Cpp2ILInjected.Token(Token = "0x6002E79")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0CB84", Offset = "0x1C0CB84", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public virtual void Clear()
			{
				throw null;
			}

			// Token: 0x06004272 RID: 17010 RVA: 0x000201AA File Offset: 0x0001E3AA
			[global::Cpp2ILInjected.Token(Token = "0x6002E7A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0CBD0", Offset = "0x1C0CBD0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public virtual bool Contains(object key)
			{
				throw null;
			}

			// Token: 0x06004273 RID: 17011 RVA: 0x000201AD File Offset: 0x0001E3AD
			[global::Cpp2ILInjected.Token(Token = "0x6002E7B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0CBE4", Offset = "0x1C0CBE4", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Rank", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
			{
				typeof(global::System.Array),
				typeof(int),
				typeof(global::System.Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public virtual void CopyTo(global::System.Array array, int arrayIndex)
			{
				throw null;
			}

			// Token: 0x06004274 RID: 17012 RVA: 0x000201B0 File Offset: 0x0001E3B0
			[global::Cpp2ILInjected.Token(Token = "0x6002E7C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0CCA8", Offset = "0x1C0CCA8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public virtual void Insert(int index, object value)
			{
				throw null;
			}

			// Token: 0x170007A9 RID: 1961
			[global::Cpp2ILInjected.Token(Token = "0x17000741")]
			public virtual object this[int index]
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002E7D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0CCF4", Offset = "0x1C0CCF4", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6002E7E")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0CD08", Offset = "0x1C0CD08", Length = "0x4C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				set
				{
					throw null;
				}
			}

			// Token: 0x06004277 RID: 17015 RVA: 0x000201B9 File Offset: 0x0001E3B9
			[global::Cpp2ILInjected.Token(Token = "0x6002E7F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0CD54", Offset = "0x1C0CD54", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public virtual IEnumerator GetEnumerator()
			{
				throw null;
			}

			// Token: 0x06004278 RID: 17016 RVA: 0x000201BC File Offset: 0x0001E3BC
			[global::Cpp2ILInjected.Token(Token = "0x6002E80")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0CDEC", Offset = "0x1C0CDEC", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "BinarySearch", MemberParameters = new object[]
			{
				typeof(global::System.Array),
				typeof(int),
				typeof(int),
				typeof(object),
				typeof(IComparer)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public virtual int IndexOf(object key)
			{
				throw null;
			}

			// Token: 0x06004279 RID: 17017 RVA: 0x000201BF File Offset: 0x0001E3BF
			[global::Cpp2ILInjected.Token(Token = "0x6002E81")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0CEA8", Offset = "0x1C0CEA8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public virtual void Remove(object key)
			{
				throw null;
			}

			// Token: 0x0600427A RID: 17018 RVA: 0x000201C2 File Offset: 0x0001E3C2
			[global::Cpp2ILInjected.Token(Token = "0x6002E82")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0CEF4", Offset = "0x1C0CEF4", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public virtual void RemoveAt(int index)
			{
				throw null;
			}

			// Token: 0x04001A8E RID: 6798
			[global::Cpp2ILInjected.Token(Token = "0x40019D9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private SortedList sortedList;
		}

		// Token: 0x02000646 RID: 1606
		[global::System.Runtime.CompilerServices.TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
		[global::Cpp2ILInjected.Token(Token = "0x20005FE")]
		[global::System.Serializable]
		private class ValueList : IList, ICollection, IEnumerable
		{
			// Token: 0x0600427B RID: 17019 RVA: 0x000201C5 File Offset: 0x0001E3C5
			[global::Cpp2ILInjected.Token(Token = "0x6002E83")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0B294", Offset = "0x1C0B294", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal ValueList(SortedList sortedList)
			{
				throw null;
			}

			// Token: 0x170007AA RID: 1962
			// (get) Token: 0x0600427C RID: 17020 RVA: 0x000201C8 File Offset: 0x0001E3C8
			[global::Cpp2ILInjected.Token(Token = "0x17000742")]
			public virtual int Count
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002E84")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0CF40", Offset = "0x1C0CF40", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007AB RID: 1963
			// (get) Token: 0x0600427D RID: 17021 RVA: 0x000201CB File Offset: 0x0001E3CB
			[global::Cpp2ILInjected.Token(Token = "0x17000743")]
			public virtual bool IsReadOnly
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002E85")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0CF4C", Offset = "0x1C0CF4C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007AC RID: 1964
			// (get) Token: 0x0600427E RID: 17022 RVA: 0x000201CE File Offset: 0x0001E3CE
			[global::Cpp2ILInjected.Token(Token = "0x17000744")]
			public virtual bool IsFixedSize
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002E86")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0CF54", Offset = "0x1C0CF54", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007AD RID: 1965
			// (get) Token: 0x0600427F RID: 17023 RVA: 0x000201D1 File Offset: 0x0001E3D1
			[global::Cpp2ILInjected.Token(Token = "0x17000745")]
			public virtual bool IsSynchronized
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002E87")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0CF5C", Offset = "0x1C0CF5C", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007AE RID: 1966
			// (get) Token: 0x06004280 RID: 17024 RVA: 0x000201D4 File Offset: 0x0001E3D4
			[global::Cpp2ILInjected.Token(Token = "0x17000746")]
			public virtual object SyncRoot
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002E88")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0CF70", Offset = "0x1C0CF70", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004281 RID: 17025 RVA: 0x000201D7 File Offset: 0x0001E3D7
			[global::Cpp2ILInjected.Token(Token = "0x6002E89")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0CF84", Offset = "0x1C0CF84", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public virtual int Add(object key)
			{
				throw null;
			}

			// Token: 0x06004282 RID: 17026 RVA: 0x000201DA File Offset: 0x0001E3DA
			[global::Cpp2ILInjected.Token(Token = "0x6002E8A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0CFD0", Offset = "0x1C0CFD0", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public virtual void Clear()
			{
				throw null;
			}

			// Token: 0x06004283 RID: 17027 RVA: 0x000201DD File Offset: 0x0001E3DD
			[global::Cpp2ILInjected.Token(Token = "0x6002E8B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0D01C", Offset = "0x1C0D01C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public virtual bool Contains(object value)
			{
				throw null;
			}

			// Token: 0x06004284 RID: 17028 RVA: 0x000201E0 File Offset: 0x0001E3E0
			[global::Cpp2ILInjected.Token(Token = "0x6002E8C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0D030", Offset = "0x1C0D030", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Rank", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
			{
				typeof(global::System.Array),
				typeof(int),
				typeof(global::System.Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public virtual void CopyTo(global::System.Array array, int arrayIndex)
			{
				throw null;
			}

			// Token: 0x06004285 RID: 17029 RVA: 0x000201E3 File Offset: 0x0001E3E3
			[global::Cpp2ILInjected.Token(Token = "0x6002E8D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0D0F4", Offset = "0x1C0D0F4", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public virtual void Insert(int index, object value)
			{
				throw null;
			}

			// Token: 0x170007AF RID: 1967
			[global::Cpp2ILInjected.Token(Token = "0x17000747")]
			public virtual object this[int index]
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002E8E")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0D140", Offset = "0x1C0D140", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6002E8F")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0D154", Offset = "0x1C0D154", Length = "0x4C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				set
				{
					throw null;
				}
			}

			// Token: 0x06004288 RID: 17032 RVA: 0x000201EC File Offset: 0x0001E3EC
			[global::Cpp2ILInjected.Token(Token = "0x6002E90")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0D1A0", Offset = "0x1C0D1A0", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public virtual IEnumerator GetEnumerator()
			{
				throw null;
			}

			// Token: 0x06004289 RID: 17033 RVA: 0x000201EF File Offset: 0x0001E3EF
			[global::Cpp2ILInjected.Token(Token = "0x6002E91")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0D238", Offset = "0x1C0D238", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array[]), Member = "IndexOf", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
			{
				typeof(object[]),
				typeof(object),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public virtual int IndexOf(object value)
			{
				throw null;
			}

			// Token: 0x0600428A RID: 17034 RVA: 0x000201F2 File Offset: 0x0001E3F2
			[global::Cpp2ILInjected.Token(Token = "0x6002E92")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0D2B0", Offset = "0x1C0D2B0", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public virtual void Remove(object value)
			{
				throw null;
			}

			// Token: 0x0600428B RID: 17035 RVA: 0x000201F5 File Offset: 0x0001E3F5
			[global::Cpp2ILInjected.Token(Token = "0x6002E93")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0D2FC", Offset = "0x1C0D2FC", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public virtual void RemoveAt(int index)
			{
				throw null;
			}

			// Token: 0x04001A8F RID: 6799
			[global::Cpp2ILInjected.Token(Token = "0x40019DA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private SortedList sortedList;
		}

		// Token: 0x02000647 RID: 1607
		[global::Cpp2ILInjected.Token(Token = "0x20005FF")]
		internal class SortedListDebugView
		{
		}
	}
}
