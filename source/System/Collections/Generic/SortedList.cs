using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	// Token: 0x02000316 RID: 790
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(IDictionaryDebugView<, >))]
	[global::Cpp2ILInjected.Token(Token = "0x2000433")]
	[Serializable]
	public class SortedList<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>
	{
		// Token: 0x06001A15 RID: 6677 RVA: 0x0000779C File Offset: 0x0000599C
		[global::Cpp2ILInjected.Token(Token = "0x6001D27")]
		[global::Cpp2ILInjected.Address(RVA = "0x186933C", Offset = "0x186933C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SortedList()
		{
			throw null;
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x0000779F File Offset: 0x0000599F
		[global::Cpp2ILInjected.Token(Token = "0x6001D28")]
		[global::Cpp2ILInjected.Address(RVA = "0x18693AC", Offset = "0x18693AC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ComponentResourceManager), Member = "FillResources", MemberParameters = new object[]
		{
			typeof(CultureInfo),
			typeof(ref ResourceSet)
		}, ReturnType = typeof(SortedList<string, object>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public SortedList(IComparer<TKey> comparer)
		{
			throw null;
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x000077A2 File Offset: 0x000059A2
		[global::Cpp2ILInjected.Token(Token = "0x6001D29")]
		[global::Cpp2ILInjected.Address(RVA = "0x18693E4", Offset = "0x18693E4", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public void Add(TKey key, TValue value)
		{
			throw null;
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x000077A5 File Offset: 0x000059A5
		[global::Cpp2ILInjected.Token(Token = "0x6001D2A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1869510", Offset = "0x1869510", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Method_Private_Virtual_Final_New_Void_KeyValuePair_2_0(KeyValuePair<TKey, TValue> keyValuePair)
		{
			throw null;
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x000077A8 File Offset: 0x000059A8
		[global::Cpp2ILInjected.Token(Token = "0x6001D2B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1869524", Offset = "0x1869524", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_0(KeyValuePair<TKey, TValue> keyValuePair)
		{
			throw null;
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x000077AB File Offset: 0x000059AB
		[global::Cpp2ILInjected.Token(Token = "0x6001D2C")]
		[global::Cpp2ILInjected.Address(RVA = "0x18695A8", Offset = "0x18695A8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_1(KeyValuePair<TKey, TValue> keyValuePair)
		{
			throw null;
		}

		// Token: 0x17000634 RID: 1588
		// (set) Token: 0x06001A1B RID: 6683 RVA: 0x000077AE File Offset: 0x000059AE
		[global::Cpp2ILInjected.Token(Token = "0x1700068B")]
		public int Capacity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D2D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1869648", Offset = "0x1869648", Length = "0x18C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(int),
				typeof(Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001A1C RID: 6684 RVA: 0x000077B1 File Offset: 0x000059B1
		[global::Cpp2ILInjected.Token(Token = "0x1700068C")]
		public IComparer<TKey> Comparer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D2E")]
			[global::Cpp2ILInjected.Address(RVA = "0x18697D4", Offset = "0x18697D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x000077B4 File Offset: 0x000059B4
		[global::Cpp2ILInjected.Token(Token = "0x6001D2F")]
		[global::Cpp2ILInjected.Address(RVA = "0x18697DC", Offset = "0x18697DC", Length = "0x27C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		private void System.Collections.IDictionary.Add(object key, object value)
		{
			throw null;
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001A1E RID: 6686 RVA: 0x000077B7 File Offset: 0x000059B7
		[global::Cpp2ILInjected.Token(Token = "0x1700068D")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D30")]
			[global::Cpp2ILInjected.Address(RVA = "0x1869A58", Offset = "0x1869A58", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001A1F RID: 6687 RVA: 0x000077BA File Offset: 0x000059BA
		[global::Cpp2ILInjected.Token(Token = "0x1700068E")]
		private ICollection<TKey> prop_ICollection_1_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D31")]
			[global::Cpp2ILInjected.Address(RVA = "0x1869A60", Offset = "0x1869A60", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06001A20 RID: 6688 RVA: 0x000077BD File Offset: 0x000059BD
		[global::Cpp2ILInjected.Token(Token = "0x1700068F")]
		private ICollection System.Collections.IDictionary.Keys
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D32")]
			[global::Cpp2ILInjected.Address(RVA = "0x1869A74", Offset = "0x1869A74", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001A21 RID: 6689 RVA: 0x000077C0 File Offset: 0x000059C0
		[global::Cpp2ILInjected.Token(Token = "0x17000690")]
		private ICollection<TValue> prop_ICollection_1_1
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D33")]
			[global::Cpp2ILInjected.Address(RVA = "0x1869A88", Offset = "0x1869A88", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06001A22 RID: 6690 RVA: 0x000077C3 File Offset: 0x000059C3
		[global::Cpp2ILInjected.Token(Token = "0x17000691")]
		private ICollection System.Collections.IDictionary.Values
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D34")]
			[global::Cpp2ILInjected.Address(RVA = "0x1869A9C", Offset = "0x1869A9C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x000077C6 File Offset: 0x000059C6
		[global::Cpp2ILInjected.Token(Token = "0x6001D35")]
		[global::Cpp2ILInjected.Address(RVA = "0x1869AB0", Offset = "0x1869AB0", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private SortedList<TKey, TValue>.KeyList GetKeyListHelper()
		{
			throw null;
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x000077C9 File Offset: 0x000059C9
		[global::Cpp2ILInjected.Token(Token = "0x6001D36")]
		[global::Cpp2ILInjected.Address(RVA = "0x1869B14", Offset = "0x1869B14", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private SortedList<TKey, TValue>.ValueList GetValueListHelper()
		{
			throw null;
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06001A25 RID: 6693 RVA: 0x000077CC File Offset: 0x000059CC
		[global::Cpp2ILInjected.Token(Token = "0x17000692")]
		private bool prop_Boolean_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D37")]
			[global::Cpp2ILInjected.Address(RVA = "0x1869B78", Offset = "0x1869B78", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06001A26 RID: 6694 RVA: 0x000077CF File Offset: 0x000059CF
		[global::Cpp2ILInjected.Token(Token = "0x17000693")]
		private bool System.Collections.IDictionary.IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D38")]
			[global::Cpp2ILInjected.Address(RVA = "0x1869B80", Offset = "0x1869B80", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001A27 RID: 6695 RVA: 0x000077D2 File Offset: 0x000059D2
		[global::Cpp2ILInjected.Token(Token = "0x17000694")]
		private bool System.Collections.IDictionary.IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D39")]
			[global::Cpp2ILInjected.Address(RVA = "0x1869B88", Offset = "0x1869B88", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06001A28 RID: 6696 RVA: 0x000077D5 File Offset: 0x000059D5
		[global::Cpp2ILInjected.Token(Token = "0x17000695")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D3A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1869B90", Offset = "0x1869B90", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06001A29 RID: 6697 RVA: 0x000077D8 File Offset: 0x000059D8
		[global::Cpp2ILInjected.Token(Token = "0x17000696")]
		private object System.Collections.ICollection.SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D3B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1869B98", Offset = "0x1869B98", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
			{
				typeof(ref object),
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x000077DB File Offset: 0x000059DB
		[global::Cpp2ILInjected.Token(Token = "0x6001D3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1869C0C", Offset = "0x1869C0C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x000077DE File Offset: 0x000059DE
		[global::Cpp2ILInjected.Token(Token = "0x6001D3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1869C50", Offset = "0x1869C50", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private bool System.Collections.IDictionary.Contains(object key)
		{
			throw null;
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x000077E1 File Offset: 0x000059E1
		[global::Cpp2ILInjected.Token(Token = "0x6001D3E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1869D10", Offset = "0x1869D10", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool ContainsKey(TKey key)
		{
			throw null;
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x000077E4 File Offset: 0x000059E4
		[global::Cpp2ILInjected.Token(Token = "0x6001D3F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1869D38", Offset = "0x1869D38", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool ContainsValue(TValue value)
		{
			throw null;
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x000077E7 File Offset: 0x000059E7
		[global::Cpp2ILInjected.Token(Token = "0x6001D40")]
		[global::Cpp2ILInjected.Address(RVA = "0x1869D60", Offset = "0x1869D60", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyValuePair<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private void Method_Private_Virtual_Final_New_Void_KeyValuePair_2_Int32_0(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			throw null;
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x000077EA File Offset: 0x000059EA
		[global::Cpp2ILInjected.Token(Token = "0x6001D41")]
		[global::Cpp2ILInjected.Address(RVA = "0x1869F4C", Offset = "0x1869F4C", Length = "0x460")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "get_Rank", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetLowerBound", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyValuePair<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 42)]
		private void System.Collections.ICollection.CopyTo(Array array, int index)
		{
			throw null;
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x000077ED File Offset: 0x000059ED
		[global::Cpp2ILInjected.Token(Token = "0x6001D42")]
		[global::Cpp2ILInjected.Address(RVA = "0x186A3AC", Offset = "0x186A3AC", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void EnsureCapacity(int min)
		{
			throw null;
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x000077F0 File Offset: 0x000059F0
		[global::Cpp2ILInjected.Token(Token = "0x6001D43")]
		[global::Cpp2ILInjected.Address(RVA = "0x186A3EC", Offset = "0x186A3EC", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private TValue GetByIndex(int index)
		{
			throw null;
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x000077F3 File Offset: 0x000059F3
		[global::Cpp2ILInjected.Token(Token = "0x6001D44")]
		[global::Cpp2ILInjected.Address(RVA = "0x186A4A0", Offset = "0x186A4A0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ComponentResourceManager), Member = "ApplyResources", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string),
			typeof(CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortedList<, >.Enumerator), Member = ".ctor", MemberParameters = new object[]
		{
			"System.Collections.Generic.SortedList`2<TKey, TValue>",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x000077F6 File Offset: 0x000059F6
		[global::Cpp2ILInjected.Token(Token = "0x6001D45")]
		[global::Cpp2ILInjected.Address(RVA = "0x186A510", Offset = "0x186A510", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortedList<, >.Enumerator), Member = ".ctor", MemberParameters = new object[]
		{
			"System.Collections.Generic.SortedList`2<TKey, TValue>",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator<KeyValuePair<TKey, TValue>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_0()
		{
			throw null;
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x000077F9 File Offset: 0x000059F9
		[global::Cpp2ILInjected.Token(Token = "0x6001D46")]
		[global::Cpp2ILInjected.Address(RVA = "0x186A580", Offset = "0x186A580", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortedList<, >.Enumerator), Member = ".ctor", MemberParameters = new object[]
		{
			"System.Collections.Generic.SortedList`2<TKey, TValue>",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x000077FC File Offset: 0x000059FC
		[global::Cpp2ILInjected.Token(Token = "0x6001D47")]
		[global::Cpp2ILInjected.Address(RVA = "0x186A5F0", Offset = "0x186A5F0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortedList<, >.Enumerator), Member = ".ctor", MemberParameters = new object[]
		{
			"System.Collections.Generic.SortedList`2<TKey, TValue>",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x000077FF File Offset: 0x000059FF
		[global::Cpp2ILInjected.Token(Token = "0x6001D48")]
		[global::Cpp2ILInjected.Address(RVA = "0x186A660", Offset = "0x186A660", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private TKey GetKey(int index)
		{
			throw null;
		}

		// Token: 0x17000640 RID: 1600
		[global::Cpp2ILInjected.Token(Token = "0x17000697")]
		public TValue this[TKey key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D49")]
			[global::Cpp2ILInjected.Address(RVA = "0x186A714", Offset = "0x186A714", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001D4A")]
			[global::Cpp2ILInjected.Address(RVA = "0x186A7BC", Offset = "0x186A7BC", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ComponentResourceManager), Member = "FillResources", MemberParameters = new object[]
			{
				typeof(CultureInfo),
				typeof(ref ResourceSet)
			}, ReturnType = typeof(SortedList<string, object>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001A39 RID: 6713 RVA: 0x00007808 File Offset: 0x00005A08
		// (set) Token: 0x06001A3A RID: 6714 RVA: 0x0000780B File Offset: 0x00005A0B
		[global::Cpp2ILInjected.Token(Token = "0x17000698")]
		private object System.Collections.IDictionary.Item
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D4B")]
			[global::Cpp2ILInjected.Address(RVA = "0x186A8A8", Offset = "0x186A8A8", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001D4C")]
			[global::Cpp2ILInjected.Address(RVA = "0x186A968", Offset = "0x186A968", Length = "0x24C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x0000780E File Offset: 0x00005A0E
		[global::Cpp2ILInjected.Token(Token = "0x6001D4D")]
		[global::Cpp2ILInjected.Address(RVA = "0x186ABB4", Offset = "0x186ABB4", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public int IndexOfKey(TKey key)
		{
			throw null;
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x00007811 File Offset: 0x00005A11
		[global::Cpp2ILInjected.Token(Token = "0x6001D4E")]
		[global::Cpp2ILInjected.Address(RVA = "0x186AC40", Offset = "0x186AC40", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public int IndexOfValue(TValue value)
		{
			throw null;
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x00007814 File Offset: 0x00005A14
		[global::Cpp2ILInjected.Token(Token = "0x6001D4F")]
		[global::Cpp2ILInjected.Address(RVA = "0x186AC64", Offset = "0x186AC64", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		private void Insert(int index, TKey key, TValue value)
		{
			throw null;
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x00007817 File Offset: 0x00005A17
		[global::Cpp2ILInjected.Token(Token = "0x6001D50")]
		[global::Cpp2ILInjected.Address(RVA = "0x186AD38", Offset = "0x186AD38", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool TryGetValue(TKey key, out TValue value)
		{
			throw null;
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x0000781A File Offset: 0x00005A1A
		[global::Cpp2ILInjected.Token(Token = "0x6001D51")]
		[global::Cpp2ILInjected.Address(RVA = "0x186AD8C", Offset = "0x186AD8C", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void RemoveAt(int index)
		{
			throw null;
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x0000781D File Offset: 0x00005A1D
		[global::Cpp2ILInjected.Token(Token = "0x6001D52")]
		[global::Cpp2ILInjected.Address(RVA = "0x186AEB0", Offset = "0x186AEB0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Remove(TKey key)
		{
			throw null;
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x00007820 File Offset: 0x00005A20
		[global::Cpp2ILInjected.Token(Token = "0x6001D53")]
		[global::Cpp2ILInjected.Address(RVA = "0x186AF0C", Offset = "0x186AF0C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void System.Collections.IDictionary.Remove(object key)
		{
			throw null;
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x00007823 File Offset: 0x00005A23
		[global::Cpp2ILInjected.Token(Token = "0x6001D54")]
		[global::Cpp2ILInjected.Address(RVA = "0x186AFC8", Offset = "0x186AFC8", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static bool IsCompatibleKey(object key)
		{
			throw null;
		}

		// Token: 0x04000F8A RID: 3978
		[global::Cpp2ILInjected.Token(Token = "0x40013E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private TKey[] keys;

		// Token: 0x04000F8B RID: 3979
		[global::Cpp2ILInjected.Token(Token = "0x40013E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private TValue[] values;

		// Token: 0x04000F8C RID: 3980
		[global::Cpp2ILInjected.Token(Token = "0x40013EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _size;

		// Token: 0x04000F8D RID: 3981
		[global::Cpp2ILInjected.Token(Token = "0x40013EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int version;

		// Token: 0x04000F8E RID: 3982
		[global::Cpp2ILInjected.Token(Token = "0x40013EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private IComparer<TKey> comparer;

		// Token: 0x04000F8F RID: 3983
		[global::Cpp2ILInjected.Token(Token = "0x40013ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private SortedList<TKey, TValue>.KeyList keyList;

		// Token: 0x04000F90 RID: 3984
		[global::Cpp2ILInjected.Token(Token = "0x40013EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private SortedList<TKey, TValue>.ValueList valueList;

		// Token: 0x04000F91 RID: 3985
		[global::Cpp2ILInjected.Token(Token = "0x40013EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private object _syncRoot;

		// Token: 0x0200047A RID: 1146
		[global::Cpp2ILInjected.Token(Token = "0x2000434")]
		[Serializable]
		private struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator
		{
			// Token: 0x06001F7B RID: 8059 RVA: 0x000086F0 File Offset: 0x000068F0
			[global::Cpp2ILInjected.Token(Token = "0x6001D55")]
			[global::Cpp2ILInjected.Address(RVA = "0x165B098", Offset = "0x165B098", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SortedList<, >), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<KeyValuePair`2<TKey, TValue>>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SortedList<, >), Member = "System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<KeyValuePair`2<TKey, TValue>>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SortedList<, >), Member = "System.Collections.IDictionary.GetEnumerator", ReturnType = typeof(IDictionaryEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SortedList<, >), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			internal Enumerator(SortedList<TKey, TValue> sortedList, int getEnumeratorRetType)
			{
				throw null;
			}

			// Token: 0x06001F7C RID: 8060 RVA: 0x000086F3 File Offset: 0x000068F3
			[global::Cpp2ILInjected.Token(Token = "0x6001D56")]
			[global::Cpp2ILInjected.Address(RVA = "0x165B0B0", Offset = "0x165B0B0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Dispose()
			{
				throw null;
			}

			// Token: 0x17000779 RID: 1913
			// (get) Token: 0x06001F7D RID: 8061 RVA: 0x000086F6 File Offset: 0x000068F6
			[global::Cpp2ILInjected.Token(Token = "0x17000699")]
			private object System.Collections.IDictionaryEnumerator.Key
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001D57")]
				[global::Cpp2ILInjected.Address(RVA = "0x165B0BC", Offset = "0x165B0BC", Length = "0xD8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06001F7E RID: 8062 RVA: 0x000086F9 File Offset: 0x000068F9
			[global::Cpp2ILInjected.Token(Token = "0x6001D58")]
			[global::Cpp2ILInjected.Address(RVA = "0x165B194", Offset = "0x165B194", Length = "0x178")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public bool MoveNext()
			{
				throw null;
			}

			// Token: 0x1700077A RID: 1914
			// (get) Token: 0x06001F7F RID: 8063 RVA: 0x000086FC File Offset: 0x000068FC
			[global::Cpp2ILInjected.Token(Token = "0x1700069A")]
			private DictionaryEntry System.Collections.IDictionaryEnumerator.Entry
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001D59")]
				[global::Cpp2ILInjected.Address(RVA = "0x165B30C", Offset = "0x165B30C", Length = "0xF4")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DictionaryEntry), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(object)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700077B RID: 1915
			// (get) Token: 0x06001F80 RID: 8064 RVA: 0x000086FF File Offset: 0x000068FF
			[global::Cpp2ILInjected.Token(Token = "0x1700069B")]
			public KeyValuePair<TKey, TValue> Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001D5A")]
				[global::Cpp2ILInjected.Address(RVA = "0x165B400", Offset = "0x165B400", Length = "0x50")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyValuePair<object, object>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(object)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700077C RID: 1916
			// (get) Token: 0x06001F81 RID: 8065 RVA: 0x00008702 File Offset: 0x00006902
			[global::Cpp2ILInjected.Token(Token = "0x1700069C")]
			private object System.Collections.IEnumerator.Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001D5B")]
				[global::Cpp2ILInjected.Address(RVA = "0x165B450", Offset = "0x165B450", Length = "0x19C")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DictionaryEntry), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(object)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyValuePair<object, object>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(object)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700077D RID: 1917
			// (get) Token: 0x06001F82 RID: 8066 RVA: 0x00008705 File Offset: 0x00006905
			[global::Cpp2ILInjected.Token(Token = "0x1700069D")]
			private object System.Collections.IDictionaryEnumerator.Value
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001D5C")]
				[global::Cpp2ILInjected.Address(RVA = "0x165B5EC", Offset = "0x165B5EC", Length = "0xD8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06001F83 RID: 8067 RVA: 0x00008708 File Offset: 0x00006908
			[global::Cpp2ILInjected.Token(Token = "0x6001D5D")]
			[global::Cpp2ILInjected.Address(RVA = "0x165B6C4", Offset = "0x165B6C4", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x040013D5 RID: 5077
			[global::Cpp2ILInjected.Token(Token = "0x40013F0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private SortedList<TKey, TValue> _sortedList;

			// Token: 0x040013D6 RID: 5078
			[global::Cpp2ILInjected.Token(Token = "0x40013F1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private TKey _key;

			// Token: 0x040013D7 RID: 5079
			[global::Cpp2ILInjected.Token(Token = "0x40013F2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private TValue _value;

			// Token: 0x040013D8 RID: 5080
			[global::Cpp2ILInjected.Token(Token = "0x40013F3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _index;

			// Token: 0x040013D9 RID: 5081
			[global::Cpp2ILInjected.Token(Token = "0x40013F4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _version;

			// Token: 0x040013DA RID: 5082
			[global::Cpp2ILInjected.Token(Token = "0x40013F5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _getEnumeratorRetType;
		}

		// Token: 0x0200047B RID: 1147
		[global::Cpp2ILInjected.Token(Token = "0x2000435")]
		[Serializable]
		private sealed class SortedListKeyEnumerator : IEnumerator<TKey>, IDisposable, IEnumerator
		{
			// Token: 0x06001F84 RID: 8068 RVA: 0x0000870B File Offset: 0x0000690B
			[global::Cpp2ILInjected.Token(Token = "0x6001D5E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1868EDC", Offset = "0x1868EDC", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal SortedListKeyEnumerator(SortedList<TKey, TValue> sortedList)
			{
				throw null;
			}

			// Token: 0x06001F85 RID: 8069 RVA: 0x0000870E File Offset: 0x0000690E
			[global::Cpp2ILInjected.Token(Token = "0x6001D5F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1868F0C", Offset = "0x1868F0C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Dispose()
			{
				throw null;
			}

			// Token: 0x06001F86 RID: 8070 RVA: 0x00008711 File Offset: 0x00006911
			[global::Cpp2ILInjected.Token(Token = "0x6001D60")]
			[global::Cpp2ILInjected.Address(RVA = "0x1868F18", Offset = "0x1868F18", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public bool MoveNext()
			{
				throw null;
			}

			// Token: 0x1700077E RID: 1918
			// (get) Token: 0x06001F87 RID: 8071 RVA: 0x00008714 File Offset: 0x00006914
			[global::Cpp2ILInjected.Token(Token = "0x1700069E")]
			public TKey Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001D61")]
				[global::Cpp2ILInjected.Address(RVA = "0x1869004", Offset = "0x1869004", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700077F RID: 1919
			// (get) Token: 0x06001F88 RID: 8072 RVA: 0x00008717 File Offset: 0x00006917
			[global::Cpp2ILInjected.Token(Token = "0x1700069F")]
			private object System.Collections.IEnumerator.Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001D62")]
				[global::Cpp2ILInjected.Address(RVA = "0x186900C", Offset = "0x186900C", Length = "0x90")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06001F89 RID: 8073 RVA: 0x0000871A File Offset: 0x0000691A
			[global::Cpp2ILInjected.Token(Token = "0x6001D63")]
			[global::Cpp2ILInjected.Address(RVA = "0x186909C", Offset = "0x186909C", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x040013DB RID: 5083
			[global::Cpp2ILInjected.Token(Token = "0x40013F6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private SortedList<TKey, TValue> _sortedList;

			// Token: 0x040013DC RID: 5084
			[global::Cpp2ILInjected.Token(Token = "0x40013F7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _index;

			// Token: 0x040013DD RID: 5085
			[global::Cpp2ILInjected.Token(Token = "0x40013F8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _version;

			// Token: 0x040013DE RID: 5086
			[global::Cpp2ILInjected.Token(Token = "0x40013F9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private TKey _currentKey;
		}

		// Token: 0x0200047C RID: 1148
		[global::Cpp2ILInjected.Token(Token = "0x2000436")]
		[Serializable]
		private sealed class SortedListValueEnumerator : IEnumerator<TValue>, IDisposable, IEnumerator
		{
			// Token: 0x06001F8A RID: 8074 RVA: 0x0000871D File Offset: 0x0000691D
			[global::Cpp2ILInjected.Token(Token = "0x6001D64")]
			[global::Cpp2ILInjected.Address(RVA = "0x186910C", Offset = "0x186910C", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal SortedListValueEnumerator(SortedList<TKey, TValue> sortedList)
			{
				throw null;
			}

			// Token: 0x06001F8B RID: 8075 RVA: 0x00008720 File Offset: 0x00006920
			[global::Cpp2ILInjected.Token(Token = "0x6001D65")]
			[global::Cpp2ILInjected.Address(RVA = "0x186913C", Offset = "0x186913C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Dispose()
			{
				throw null;
			}

			// Token: 0x06001F8C RID: 8076 RVA: 0x00008723 File Offset: 0x00006923
			[global::Cpp2ILInjected.Token(Token = "0x6001D66")]
			[global::Cpp2ILInjected.Address(RVA = "0x1869148", Offset = "0x1869148", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public bool MoveNext()
			{
				throw null;
			}

			// Token: 0x17000780 RID: 1920
			// (get) Token: 0x06001F8D RID: 8077 RVA: 0x00008726 File Offset: 0x00006926
			[global::Cpp2ILInjected.Token(Token = "0x170006A0")]
			public TValue Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001D67")]
				[global::Cpp2ILInjected.Address(RVA = "0x1869234", Offset = "0x1869234", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000781 RID: 1921
			// (get) Token: 0x06001F8E RID: 8078 RVA: 0x00008729 File Offset: 0x00006929
			[global::Cpp2ILInjected.Token(Token = "0x170006A1")]
			private object System.Collections.IEnumerator.Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001D68")]
				[global::Cpp2ILInjected.Address(RVA = "0x186923C", Offset = "0x186923C", Length = "0x90")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06001F8F RID: 8079 RVA: 0x0000872C File Offset: 0x0000692C
			[global::Cpp2ILInjected.Token(Token = "0x6001D69")]
			[global::Cpp2ILInjected.Address(RVA = "0x18692CC", Offset = "0x18692CC", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x040013DF RID: 5087
			[global::Cpp2ILInjected.Token(Token = "0x40013FA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private SortedList<TKey, TValue> _sortedList;

			// Token: 0x040013E0 RID: 5088
			[global::Cpp2ILInjected.Token(Token = "0x40013FB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _index;

			// Token: 0x040013E1 RID: 5089
			[global::Cpp2ILInjected.Token(Token = "0x40013FC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _version;

			// Token: 0x040013E2 RID: 5090
			[global::Cpp2ILInjected.Token(Token = "0x40013FD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private TValue _currentValue;
		}

		// Token: 0x0200047D RID: 1149
		[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView<, >))]
		[DebuggerDisplay("Count = {Count}")]
		[global::Cpp2ILInjected.Token(Token = "0x2000437")]
		[Serializable]
		private sealed class KeyList : IList<TKey>, ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection
		{
			// Token: 0x06001F90 RID: 8080 RVA: 0x0000872F File Offset: 0x0000692F
			[global::Cpp2ILInjected.Token(Token = "0x6001D6A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1723754", Offset = "0x1723754", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal KeyList(SortedList<TKey, TValue> dictionary)
			{
				throw null;
			}

			// Token: 0x17000782 RID: 1922
			// (get) Token: 0x06001F91 RID: 8081 RVA: 0x00008732 File Offset: 0x00006932
			[global::Cpp2ILInjected.Token(Token = "0x170006A2")]
			public int Count
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001D6B")]
				[global::Cpp2ILInjected.Address(RVA = "0x172377C", Offset = "0x172377C", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000783 RID: 1923
			// (get) Token: 0x06001F92 RID: 8082 RVA: 0x00008735 File Offset: 0x00006935
			[global::Cpp2ILInjected.Token(Token = "0x170006A3")]
			public bool IsReadOnly
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001D6C")]
				[global::Cpp2ILInjected.Address(RVA = "0x1723788", Offset = "0x1723788", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000784 RID: 1924
			// (get) Token: 0x06001F93 RID: 8083 RVA: 0x00008738 File Offset: 0x00006938
			[global::Cpp2ILInjected.Token(Token = "0x170006A4")]
			private bool System.Collections.ICollection.IsSynchronized
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001D6D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1723790", Offset = "0x1723790", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000785 RID: 1925
			// (get) Token: 0x06001F94 RID: 8084 RVA: 0x0000873B File Offset: 0x0000693B
			[global::Cpp2ILInjected.Token(Token = "0x170006A5")]
			private object System.Collections.ICollection.SyncRoot
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001D6E")]
				[global::Cpp2ILInjected.Address(RVA = "0x1723798", Offset = "0x1723798", Length = "0x9C")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06001F95 RID: 8085 RVA: 0x0000873E File Offset: 0x0000693E
			[global::Cpp2ILInjected.Token(Token = "0x6001D6F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1723834", Offset = "0x1723834", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public void Add(TKey key)
			{
				throw null;
			}

			// Token: 0x06001F96 RID: 8086 RVA: 0x00008741 File Offset: 0x00006941
			[global::Cpp2ILInjected.Token(Token = "0x6001D70")]
			[global::Cpp2ILInjected.Address(RVA = "0x1723880", Offset = "0x1723880", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public void Clear()
			{
				throw null;
			}

			// Token: 0x06001F97 RID: 8087 RVA: 0x00008744 File Offset: 0x00006944
			[global::Cpp2ILInjected.Token(Token = "0x6001D71")]
			[global::Cpp2ILInjected.Address(RVA = "0x17238CC", Offset = "0x17238CC", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public bool Contains(TKey key)
			{
				throw null;
			}

			// Token: 0x06001F98 RID: 8088 RVA: 0x00008747 File Offset: 0x00006947
			[global::Cpp2ILInjected.Token(Token = "0x6001D72")]
			[global::Cpp2ILInjected.Address(RVA = "0x17238E4", Offset = "0x17238E4", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(int),
				typeof(Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			public void CopyTo(TKey[] array, int arrayIndex)
			{
				throw null;
			}

			// Token: 0x06001F99 RID: 8089 RVA: 0x0000874A File Offset: 0x0000694A
			[global::Cpp2ILInjected.Token(Token = "0x6001D73")]
			[global::Cpp2ILInjected.Address(RVA = "0x1723938", Offset = "0x1723938", Length = "0x164")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "get_Rank", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(int),
				typeof(Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex)
			{
				throw null;
			}

			// Token: 0x06001F9A RID: 8090 RVA: 0x0000874D File Offset: 0x0000694D
			[global::Cpp2ILInjected.Token(Token = "0x6001D74")]
			[global::Cpp2ILInjected.Address(RVA = "0x1723A9C", Offset = "0x1723A9C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public void Insert(int index, TKey value)
			{
				throw null;
			}

			// Token: 0x17000786 RID: 1926
			[global::Cpp2ILInjected.Token(Token = "0x170006A6")]
			public TKey this[int index]
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001D75")]
				[global::Cpp2ILInjected.Address(RVA = "0x1723AE8", Offset = "0x1723AE8", Length = "0x18")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6001D76")]
				[global::Cpp2ILInjected.Address(RVA = "0x1723B00", Offset = "0x1723B00", Length = "0x4C")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				set
				{
					throw null;
				}
			}

			// Token: 0x06001F9D RID: 8093 RVA: 0x00008756 File Offset: 0x00006956
			[global::Cpp2ILInjected.Token(Token = "0x6001D77")]
			[global::Cpp2ILInjected.Address(RVA = "0x1723B4C", Offset = "0x1723B4C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public IEnumerator<TKey> GetEnumerator()
			{
				throw null;
			}

			// Token: 0x06001F9E RID: 8094 RVA: 0x00008759 File Offset: 0x00006959
			[global::Cpp2ILInjected.Token(Token = "0x6001D78")]
			[global::Cpp2ILInjected.Address(RVA = "0x1723BA8", Offset = "0x1723BA8", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x06001F9F RID: 8095 RVA: 0x0000875C File Offset: 0x0000695C
			[global::Cpp2ILInjected.Token(Token = "0x6001D79")]
			[global::Cpp2ILInjected.Address(RVA = "0x1723C04", Offset = "0x1723C04", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public int IndexOf(TKey key)
			{
				throw null;
			}

			// Token: 0x06001FA0 RID: 8096 RVA: 0x0000875F File Offset: 0x0000695F
			[global::Cpp2ILInjected.Token(Token = "0x6001D7A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1723CC8", Offset = "0x1723CC8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public bool Remove(TKey key)
			{
				throw null;
			}

			// Token: 0x06001FA1 RID: 8097 RVA: 0x00008762 File Offset: 0x00006962
			[global::Cpp2ILInjected.Token(Token = "0x6001D7B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1723D14", Offset = "0x1723D14", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public void RemoveAt(int index)
			{
				throw null;
			}

			// Token: 0x040013E3 RID: 5091
			[global::Cpp2ILInjected.Token(Token = "0x40013FE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private SortedList<TKey, TValue> _dict;
		}

		// Token: 0x0200047E RID: 1150
		[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView<, >))]
		[DebuggerDisplay("Count = {Count}")]
		[global::Cpp2ILInjected.Token(Token = "0x2000438")]
		[Serializable]
		private sealed class ValueList : IList<TValue>, ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection
		{
			// Token: 0x06001FA2 RID: 8098 RVA: 0x00008765 File Offset: 0x00006965
			[global::Cpp2ILInjected.Token(Token = "0x6001D7C")]
			[global::Cpp2ILInjected.Address(RVA = "0x18AA87C", Offset = "0x18AA87C", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal ValueList(SortedList<TKey, TValue> dictionary)
			{
				throw null;
			}

			// Token: 0x17000787 RID: 1927
			// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x00008768 File Offset: 0x00006968
			[global::Cpp2ILInjected.Token(Token = "0x170006A7")]
			public int Count
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001D7D")]
				[global::Cpp2ILInjected.Address(RVA = "0x18AA8A4", Offset = "0x18AA8A4", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000788 RID: 1928
			// (get) Token: 0x06001FA4 RID: 8100 RVA: 0x0000876B File Offset: 0x0000696B
			[global::Cpp2ILInjected.Token(Token = "0x170006A8")]
			public bool IsReadOnly
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001D7E")]
				[global::Cpp2ILInjected.Address(RVA = "0x18AA8B0", Offset = "0x18AA8B0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000789 RID: 1929
			// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x0000876E File Offset: 0x0000696E
			[global::Cpp2ILInjected.Token(Token = "0x170006A9")]
			private bool System.Collections.ICollection.IsSynchronized
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001D7F")]
				[global::Cpp2ILInjected.Address(RVA = "0x18AA8B8", Offset = "0x18AA8B8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700078A RID: 1930
			// (get) Token: 0x06001FA6 RID: 8102 RVA: 0x00008771 File Offset: 0x00006971
			[global::Cpp2ILInjected.Token(Token = "0x170006AA")]
			private object System.Collections.ICollection.SyncRoot
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001D80")]
				[global::Cpp2ILInjected.Address(RVA = "0x18AA8C0", Offset = "0x18AA8C0", Length = "0x9C")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06001FA7 RID: 8103 RVA: 0x00008774 File Offset: 0x00006974
			[global::Cpp2ILInjected.Token(Token = "0x6001D81")]
			[global::Cpp2ILInjected.Address(RVA = "0x18AA95C", Offset = "0x18AA95C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public void Add(TValue key)
			{
				throw null;
			}

			// Token: 0x06001FA8 RID: 8104 RVA: 0x00008777 File Offset: 0x00006977
			[global::Cpp2ILInjected.Token(Token = "0x6001D82")]
			[global::Cpp2ILInjected.Address(RVA = "0x18AA9A8", Offset = "0x18AA9A8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public void Clear()
			{
				throw null;
			}

			// Token: 0x06001FA9 RID: 8105 RVA: 0x0000877A File Offset: 0x0000697A
			[global::Cpp2ILInjected.Token(Token = "0x6001D83")]
			[global::Cpp2ILInjected.Address(RVA = "0x18AA9F4", Offset = "0x18AA9F4", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public bool Contains(TValue value)
			{
				throw null;
			}

			// Token: 0x06001FAA RID: 8106 RVA: 0x0000877D File Offset: 0x0000697D
			[global::Cpp2ILInjected.Token(Token = "0x6001D84")]
			[global::Cpp2ILInjected.Address(RVA = "0x18AAA0C", Offset = "0x18AAA0C", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(int),
				typeof(Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			public void CopyTo(TValue[] array, int arrayIndex)
			{
				throw null;
			}

			// Token: 0x06001FAB RID: 8107 RVA: 0x00008780 File Offset: 0x00006980
			[global::Cpp2ILInjected.Token(Token = "0x6001D85")]
			[global::Cpp2ILInjected.Address(RVA = "0x18AAA60", Offset = "0x18AAA60", Length = "0x164")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "get_Rank", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(int),
				typeof(Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			private void System.Collections.ICollection.CopyTo(Array array, int index)
			{
				throw null;
			}

			// Token: 0x06001FAC RID: 8108 RVA: 0x00008783 File Offset: 0x00006983
			[global::Cpp2ILInjected.Token(Token = "0x6001D86")]
			[global::Cpp2ILInjected.Address(RVA = "0x18AABC4", Offset = "0x18AABC4", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public void Insert(int index, TValue value)
			{
				throw null;
			}

			// Token: 0x1700078B RID: 1931
			[global::Cpp2ILInjected.Token(Token = "0x170006AB")]
			public TValue this[int index]
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001D87")]
				[global::Cpp2ILInjected.Address(RVA = "0x18AAC10", Offset = "0x18AAC10", Length = "0x18")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6001D88")]
				[global::Cpp2ILInjected.Address(RVA = "0x18AAC28", Offset = "0x18AAC28", Length = "0x4C")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				set
				{
					throw null;
				}
			}

			// Token: 0x06001FAF RID: 8111 RVA: 0x0000878C File Offset: 0x0000698C
			[global::Cpp2ILInjected.Token(Token = "0x6001D89")]
			[global::Cpp2ILInjected.Address(RVA = "0x18AAC74", Offset = "0x18AAC74", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public IEnumerator<TValue> GetEnumerator()
			{
				throw null;
			}

			// Token: 0x06001FB0 RID: 8112 RVA: 0x0000878F File Offset: 0x0000698F
			[global::Cpp2ILInjected.Token(Token = "0x6001D8A")]
			[global::Cpp2ILInjected.Address(RVA = "0x18AACD0", Offset = "0x18AACD0", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x06001FB1 RID: 8113 RVA: 0x00008792 File Offset: 0x00006992
			[global::Cpp2ILInjected.Token(Token = "0x6001D8B")]
			[global::Cpp2ILInjected.Address(RVA = "0x18AAD2C", Offset = "0x18AAD2C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public int IndexOf(TValue value)
			{
				throw null;
			}

			// Token: 0x06001FB2 RID: 8114 RVA: 0x00008795 File Offset: 0x00006995
			[global::Cpp2ILInjected.Token(Token = "0x6001D8C")]
			[global::Cpp2ILInjected.Address(RVA = "0x18AAD88", Offset = "0x18AAD88", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public bool Remove(TValue value)
			{
				throw null;
			}

			// Token: 0x06001FB3 RID: 8115 RVA: 0x00008798 File Offset: 0x00006998
			[global::Cpp2ILInjected.Token(Token = "0x6001D8D")]
			[global::Cpp2ILInjected.Address(RVA = "0x18AADD4", Offset = "0x18AADD4", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public void RemoveAt(int index)
			{
				throw null;
			}

			// Token: 0x040013E4 RID: 5092
			[global::Cpp2ILInjected.Token(Token = "0x40013FF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private SortedList<TKey, TValue> _dict;
		}
	}
}
