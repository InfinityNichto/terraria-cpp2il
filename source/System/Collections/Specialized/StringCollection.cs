using System;
using System.Net;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Specialized
{
	[global::Cpp2ILInjected.Token(Token = "0x2000421")]
	[Serializable]
	public class StringCollection : IList, ICollection, IEnumerable
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6001C90")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90B24", Offset = "0x1E90B24", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HeaderInfoTable), Member = "ParseMultiValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public int Add(string value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C91")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90B38", Offset = "0x1E90B38", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Clear()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C92")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90B4C", Offset = "0x1E90B4C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool Contains(string value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C93")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90B60", Offset = "0x1E90B60", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HeaderInfoTable), Member = "ParseMultiValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void CopyTo(string[] array, int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C94")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90B74", Offset = "0x1E90B74", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public int IndexOf(string value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C95")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90B88", Offset = "0x1E90B88", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Insert(int index, string value)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6001C97")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90BA4", Offset = "0x1E90BA4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Remove(string value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C98")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90BB8", Offset = "0x1E90BB8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void RemoveAt(int index)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6001C9C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90C68", Offset = "0x1E90C68", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private int System.Collections.IList.Add(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90CDC", Offset = "0x1E90CDC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private bool System.Collections.IList.Contains(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90D50", Offset = "0x1E90D50", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private int System.Collections.IList.IndexOf(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90DC4", Offset = "0x1E90DC4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void System.Collections.IList.Insert(int index, object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90E48", Offset = "0x1E90E48", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void System.Collections.IList.Remove(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90EBC", Offset = "0x1E90EBC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Collections.ICollection.CopyTo(Array array, int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CA2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E90ED0", Offset = "0x1E90ED0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x40013B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly ArrayList data;
	}
}
