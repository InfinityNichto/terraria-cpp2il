using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002A6 RID: 678
	[global::Cpp2ILInjected.Token(Token = "0x200039E")]
	public class ListSortDescriptionCollection : IList, ICollection, IEnumerable
	{
		// Token: 0x060015BB RID: 5563 RVA: 0x00006B5D File Offset: 0x00004D5D
		[global::Cpp2ILInjected.Token(Token = "0x6001809")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4FB9C", Offset = "0x1E4FB9C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ListSortDescriptionCollection()
		{
			throw null;
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x00006B60 File Offset: 0x00004D60
		[global::Cpp2ILInjected.Token(Token = "0x600180A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4FBFC", Offset = "0x1E4FBFC", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ListSortDescriptionCollection(ListSortDescription[] sorts)
		{
			throw null;
		}

		// Token: 0x1700054F RID: 1359
		[global::Cpp2ILInjected.Token(Token = "0x1700057A")]
		public ListSortDescription this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x600180B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4FCAC", Offset = "0x1E4FCAC", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ListSortDescriptionCollection), Member = "System.Collections.IList.get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600180C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4FD3C", Offset = "0x1E4FD3C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x060015BF RID: 5567 RVA: 0x00006B69 File Offset: 0x00004D69
		[global::Cpp2ILInjected.Token(Token = "0x1700057B")]
		private bool System.Collections.IList.IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x600180D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4FD88", Offset = "0x1E4FD88", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x060015C0 RID: 5568 RVA: 0x00006B6C File Offset: 0x00004D6C
		[global::Cpp2ILInjected.Token(Token = "0x1700057C")]
		private bool System.Collections.IList.IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x600180E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4FD90", Offset = "0x1E4FD90", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x060015C1 RID: 5569 RVA: 0x00006B6F File Offset: 0x00004D6F
		// (set) Token: 0x060015C2 RID: 5570 RVA: 0x00006B72 File Offset: 0x00004D72
		[global::Cpp2ILInjected.Token(Token = "0x1700057D")]
		private object System.Collections.IList.Item
		{
			[global::Cpp2ILInjected.Token(Token = "0x600180F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4FD98", Offset = "0x1E4FD98", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListSortDescriptionCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ListSortDescription))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001810")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4FD9C", Offset = "0x1E4FD9C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x00006B75 File Offset: 0x00004D75
		[global::Cpp2ILInjected.Token(Token = "0x6001811")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4FDE8", Offset = "0x1E4FDE8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private int System.Collections.IList.Add(object value)
		{
			throw null;
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x00006B78 File Offset: 0x00004D78
		[global::Cpp2ILInjected.Token(Token = "0x6001812")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4FE34", Offset = "0x1E4FE34", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void System.Collections.IList.Clear()
		{
			throw null;
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x00006B7B File Offset: 0x00004D7B
		[global::Cpp2ILInjected.Token(Token = "0x6001813")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4FE80", Offset = "0x1E4FE80", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool Contains(object value)
		{
			throw null;
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x00006B7E File Offset: 0x00004D7E
		[global::Cpp2ILInjected.Token(Token = "0x6001814")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4FF2C", Offset = "0x1E4FF2C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public int IndexOf(object value)
		{
			throw null;
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x00006B81 File Offset: 0x00004D81
		[global::Cpp2ILInjected.Token(Token = "0x6001815")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4FFD8", Offset = "0x1E4FFD8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void System.Collections.IList.Insert(int index, object value)
		{
			throw null;
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x00006B84 File Offset: 0x00004D84
		[global::Cpp2ILInjected.Token(Token = "0x6001816")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E50024", Offset = "0x1E50024", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void System.Collections.IList.Remove(object value)
		{
			throw null;
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x00006B87 File Offset: 0x00004D87
		[global::Cpp2ILInjected.Token(Token = "0x6001817")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E50070", Offset = "0x1E50070", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void System.Collections.IList.RemoveAt(int index)
		{
			throw null;
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x060015CA RID: 5578 RVA: 0x00006B8A File Offset: 0x00004D8A
		[global::Cpp2ILInjected.Token(Token = "0x1700057E")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001818")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E500BC", Offset = "0x1E500BC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x060015CB RID: 5579 RVA: 0x00006B8D File Offset: 0x00004D8D
		[global::Cpp2ILInjected.Token(Token = "0x1700057F")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001819")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E500D0", Offset = "0x1E500D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x060015CC RID: 5580 RVA: 0x00006B90 File Offset: 0x00004D90
		[global::Cpp2ILInjected.Token(Token = "0x17000580")]
		private object System.Collections.ICollection.SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x600181A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E500D8", Offset = "0x1E500D8", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x00006B93 File Offset: 0x00004D93
		[global::Cpp2ILInjected.Token(Token = "0x600181B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E500DC", Offset = "0x1E500DC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void CopyTo(Array array, int index)
		{
			throw null;
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x00006B96 File Offset: 0x00004D96
		[global::Cpp2ILInjected.Token(Token = "0x600181C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E500F0", Offset = "0x1E500F0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x04000E45 RID: 3653
		[global::Cpp2ILInjected.Token(Token = "0x400124F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ArrayList _sorts;
	}
}
