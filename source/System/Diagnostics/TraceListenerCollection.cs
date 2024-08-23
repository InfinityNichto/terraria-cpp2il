using System;
using System.Collections;
using System.Reflection;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics
{
	// Token: 0x0200007A RID: 122
	[DefaultMember("Item")]
	[global::Cpp2ILInjected.Token(Token = "0x20000D2")]
	public class TraceListenerCollection : IList, ICollection, IEnumerable
	{
		// Token: 0x06000424 RID: 1060 RVA: 0x00003A07 File Offset: 0x00001C07
		[global::Cpp2ILInjected.Token(Token = "0x60004C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC5CD4", Offset = "0x1EC5CD4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceInternal), Member = "get_Listeners", ReturnType = typeof(TraceListenerCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal TraceListenerCollection()
		{
			throw null;
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x00003A0A File Offset: 0x00001C0A
		[global::Cpp2ILInjected.Token(Token = "0x170000DB")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC69CC", Offset = "0x1EC69CC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00003A0D File Offset: 0x00001C0D
		[global::Cpp2ILInjected.Token(Token = "0x60004C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC5E54", Offset = "0x1EC5E54", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceInternal), Member = "get_Listeners", ReturnType = typeof(TraceListenerCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TraceListenerCollection), Member = "InitializeListener", MemberParameters = new object[] { typeof(TraceListener) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public int Add(TraceListener listener)
		{
			throw null;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00003A10 File Offset: 0x00001C10
		[global::Cpp2ILInjected.Token(Token = "0x60004C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC6AD0", Offset = "0x1EC6AD0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00003A13 File Offset: 0x00001C13
		[global::Cpp2ILInjected.Token(Token = "0x60004C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC6B28", Offset = "0x1EC6B28", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.DiagnosticsTraceWriter", Member = "Trace", MemberParameters = new object[]
		{
			typeof(TraceLevel),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public IEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00003A16 File Offset: 0x00001C16
		[global::Cpp2ILInjected.Token(Token = "0x60004C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC69E0", Offset = "0x1EC69E0", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceListenerCollection), Member = "Add", MemberParameters = new object[] { typeof(TraceListener) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceListenerCollection), Member = "System.Collections.IList.set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceListenerCollection), Member = "System.Collections.IList.Add", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceListenerCollection), Member = "System.Collections.IList.Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TraceInternal), Member = "get_IndentSize", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TraceListener), Member = "set_IndentSize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal void InitializeListener(TraceListener listener)
		{
			throw null;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00003A19 File Offset: 0x00001C19
		[global::Cpp2ILInjected.Token(Token = "0x60004CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC6B3C", Offset = "0x1EC6B3C", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void RemoveAt(int index)
		{
			throw null;
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x00003A1C File Offset: 0x00001C1C
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x00003A1F File Offset: 0x00001C1F
		[global::Cpp2ILInjected.Token(Token = "0x170000DC")]
		private object System.Collections.IList.Item
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC6C54", Offset = "0x1EC6C54", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC6C68", Offset = "0x1EC6C68", Length = "0x104")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TraceListenerCollection), Member = "InitializeListener", MemberParameters = new object[] { typeof(TraceListener) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x00003A22 File Offset: 0x00001C22
		[global::Cpp2ILInjected.Token(Token = "0x170000DD")]
		private bool System.Collections.IList.IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC6D6C", Offset = "0x1EC6D6C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x00003A25 File Offset: 0x00001C25
		[global::Cpp2ILInjected.Token(Token = "0x170000DE")]
		private bool System.Collections.IList.IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC6D74", Offset = "0x1EC6D74", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00003A28 File Offset: 0x00001C28
		[global::Cpp2ILInjected.Token(Token = "0x60004CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC6D7C", Offset = "0x1EC6D7C", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TraceListenerCollection), Member = "InitializeListener", MemberParameters = new object[] { typeof(TraceListener) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private int System.Collections.IList.Add(object value)
		{
			throw null;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00003A2B File Offset: 0x00001C2B
		[global::Cpp2ILInjected.Token(Token = "0x60004D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC6F50", Offset = "0x1EC6F50", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool System.Collections.IList.Contains(object value)
		{
			throw null;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00003A2E File Offset: 0x00001C2E
		[global::Cpp2ILInjected.Token(Token = "0x60004D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC6F64", Offset = "0x1EC6F64", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private int System.Collections.IList.IndexOf(object value)
		{
			throw null;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00003A31 File Offset: 0x00001C31
		[global::Cpp2ILInjected.Token(Token = "0x60004D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC6F78", Offset = "0x1EC6F78", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TraceListenerCollection), Member = "InitializeListener", MemberParameters = new object[] { typeof(TraceListener) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private void System.Collections.IList.Insert(int index, object value)
		{
			throw null;
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00003A34 File Offset: 0x00001C34
		[global::Cpp2ILInjected.Token(Token = "0x60004D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC7148", Offset = "0x1EC7148", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void System.Collections.IList.Remove(object value)
		{
			throw null;
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x00003A37 File Offset: 0x00001C37
		[global::Cpp2ILInjected.Token(Token = "0x170000DF")]
		private object System.Collections.ICollection.SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC7260", Offset = "0x1EC7260", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x00003A3A File Offset: 0x00001C3A
		[global::Cpp2ILInjected.Token(Token = "0x170000E0")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC7264", Offset = "0x1EC7264", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00003A3D File Offset: 0x00001C3D
		[global::Cpp2ILInjected.Token(Token = "0x60004D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC726C", Offset = "0x1EC726C", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void System.Collections.ICollection.CopyTo(Array array, int index)
		{
			throw null;
		}

		// Token: 0x04000276 RID: 630
		[global::Cpp2ILInjected.Token(Token = "0x40003B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ArrayList list;
	}
}
