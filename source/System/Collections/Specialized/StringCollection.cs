using System;
using System.Net;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Specialized
{
	// Token: 0x02000308 RID: 776
	[global::Cpp2ILInjected.Token(Token = "0x2000421")]
	[Serializable]
	public class StringCollection : IList, ICollection, IEnumerable
	{
		// Token: 0x17000614 RID: 1556
		[global::Cpp2ILInjected.Token(Token = "0x17000665")]
		public string this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C8B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E90A78", Offset = "0x1E90A78", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringCollection), Member = "System.Collections.IList.get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001C8C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E90AEC", Offset = "0x1E90AEC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001990 RID: 6544 RVA: 0x0000760D File Offset: 0x0000580D
		[global::Cpp2ILInjected.Token(Token = "0x17000666")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C8D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E90B00", Offset = "0x1E90B00", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HeaderInfoTable), Member = "ParseMultiValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001991 RID: 6545 RVA: 0x00007610 File Offset: 0x00005810
		[global::Cpp2ILInjected.Token(Token = "0x17000667")]
		private bool System.Collections.IList.IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C8E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E90B14", Offset = "0x1E90B14", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001992 RID: 6546 RVA: 0x00007613 File Offset: 0x00005813
		[global::Cpp2ILInjected.Token(Token = "0x17000668")]
		private bool System.Collections.IList.IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C8F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E90B1C", Offset = "0x1E90B1C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x00007616 File Offset: 0x00005816
		[global::Cpp2ILInjected.Token(Token = "0x6001C90")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90B24", Offset = "0x1E90B24", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HeaderInfoTable), Member = "ParseMultiValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public int Add(string value)
		{
			throw null;
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x00007619 File Offset: 0x00005819
		[global::Cpp2ILInjected.Token(Token = "0x6001C91")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90B38", Offset = "0x1E90B38", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x0000761C File Offset: 0x0000581C
		[global::Cpp2ILInjected.Token(Token = "0x6001C92")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90B4C", Offset = "0x1E90B4C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool Contains(string value)
		{
			throw null;
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x0000761F File Offset: 0x0000581F
		[global::Cpp2ILInjected.Token(Token = "0x6001C93")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90B60", Offset = "0x1E90B60", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HeaderInfoTable), Member = "ParseMultiValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void CopyTo(string[] array, int index)
		{
			throw null;
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x00007622 File Offset: 0x00005822
		[global::Cpp2ILInjected.Token(Token = "0x6001C94")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90B74", Offset = "0x1E90B74", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public int IndexOf(string value)
		{
			throw null;
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x00007625 File Offset: 0x00005825
		[global::Cpp2ILInjected.Token(Token = "0x6001C95")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90B88", Offset = "0x1E90B88", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Insert(int index, string value)
		{
			throw null;
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001999 RID: 6553 RVA: 0x00007628 File Offset: 0x00005828
		[global::Cpp2ILInjected.Token(Token = "0x17000669")]
		public bool IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C96")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E90B9C", Offset = "0x1E90B9C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x0000762B File Offset: 0x0000582B
		[global::Cpp2ILInjected.Token(Token = "0x6001C97")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90BA4", Offset = "0x1E90BA4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Remove(string value)
		{
			throw null;
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x0000762E File Offset: 0x0000582E
		[global::Cpp2ILInjected.Token(Token = "0x6001C98")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90BB8", Offset = "0x1E90BB8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void RemoveAt(int index)
		{
			throw null;
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x0600199C RID: 6556 RVA: 0x00007631 File Offset: 0x00005831
		[global::Cpp2ILInjected.Token(Token = "0x1700066A")]
		public object SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C99")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E90BCC", Offset = "0x1E90BCC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x0600199D RID: 6557 RVA: 0x00007634 File Offset: 0x00005834
		// (set) Token: 0x0600199E RID: 6558 RVA: 0x00007637 File Offset: 0x00005837
		[global::Cpp2ILInjected.Token(Token = "0x1700066B")]
		private object System.Collections.IList.Item
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C9A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E90BE0", Offset = "0x1E90BE0", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001C9B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E90BE4", Offset = "0x1E90BE4", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x0000763A File Offset: 0x0000583A
		[global::Cpp2ILInjected.Token(Token = "0x6001C9C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90C68", Offset = "0x1E90C68", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private int System.Collections.IList.Add(object value)
		{
			throw null;
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x0000763D File Offset: 0x0000583D
		[global::Cpp2ILInjected.Token(Token = "0x6001C9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90CDC", Offset = "0x1E90CDC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private bool System.Collections.IList.Contains(object value)
		{
			throw null;
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x00007640 File Offset: 0x00005840
		[global::Cpp2ILInjected.Token(Token = "0x6001C9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90D50", Offset = "0x1E90D50", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private int System.Collections.IList.IndexOf(object value)
		{
			throw null;
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x00007643 File Offset: 0x00005843
		[global::Cpp2ILInjected.Token(Token = "0x6001C9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90DC4", Offset = "0x1E90DC4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void System.Collections.IList.Insert(int index, object value)
		{
			throw null;
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x00007646 File Offset: 0x00005846
		[global::Cpp2ILInjected.Token(Token = "0x6001CA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90E48", Offset = "0x1E90E48", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void System.Collections.IList.Remove(object value)
		{
			throw null;
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x00007649 File Offset: 0x00005849
		[global::Cpp2ILInjected.Token(Token = "0x6001CA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90EBC", Offset = "0x1E90EBC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Collections.ICollection.CopyTo(Array array, int index)
		{
			throw null;
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x0000764C File Offset: 0x0000584C
		[global::Cpp2ILInjected.Token(Token = "0x6001CA2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90ED0", Offset = "0x1E90ED0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x0000764F File Offset: 0x0000584F
		[global::Cpp2ILInjected.Token(Token = "0x6001CA3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90EE4", Offset = "0x1E90EE4", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HeaderInfoTable), Member = "ParseMultiValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public StringCollection()
		{
			throw null;
		}

		// Token: 0x04000F63 RID: 3939
		[global::Cpp2ILInjected.Token(Token = "0x40013B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly ArrayList data;
	}
}
