﻿using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	// Token: 0x0200052E RID: 1326
	[global::System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[global::Cpp2ILInjected.Token(Token = "0x200064B")]
	internal class LowLevelList<T>
	{
		// Token: 0x06002CA5 RID: 11429 RVA: 0x0001C151 File Offset: 0x0001A351
		[global::Cpp2ILInjected.Token(Token = "0x600312F")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C8F88", Offset = "0x17C8F88", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public LowLevelList()
		{
			throw null;
		}

		// Token: 0x06002CA6 RID: 11430 RVA: 0x0001C154 File Offset: 0x0001A354
		[global::Cpp2ILInjected.Token(Token = "0x6003130")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C8FF4", Offset = "0x17C8FF4", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public LowLevelList(int capacity)
		{
			throw null;
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06002CA7 RID: 11431 RVA: 0x0001C157 File Offset: 0x0001A357
		// (set) Token: 0x06002CA8 RID: 11432 RVA: 0x0001C15A File Offset: 0x0001A35A
		[global::Cpp2ILInjected.Token(Token = "0x170007F0")]
		public int Capacity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003131")]
			[global::Cpp2ILInjected.Address(RVA = "0x17C90D4", Offset = "0x17C90D4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "AddTaskContinuationComplex", MemberParameters = new object[]
			{
				typeof(object),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003132")]
			[global::Cpp2ILInjected.Address(RVA = "0x17C90E0", Offset = "0x17C90E0", Length = "0x118")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06002CA9 RID: 11433 RVA: 0x0001C15D File Offset: 0x0001A35D
		[global::Cpp2ILInjected.Token(Token = "0x170007F1")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003133")]
			[global::Cpp2ILInjected.Address(RVA = "0x17C91F8", Offset = "0x17C91F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006F9 RID: 1785
		[global::Cpp2ILInjected.Token(Token = "0x170007F2")]
		public T this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003134")]
			[global::Cpp2ILInjected.Address(RVA = "0x17C9200", Offset = "0x17C9200", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "FinishContinuations", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.TaskExceptionHolder), Member = "CreateExceptionObject", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(global::System.Exception)
			}, ReturnType = typeof(global::System.AggregateException))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003135")]
			[global::Cpp2ILInjected.Address(RVA = "0x17C9258", Offset = "0x17C9258", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "FinishContinuations", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "RemoveContinuation", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06002CAC RID: 11436 RVA: 0x0001C166 File Offset: 0x0001A366
		[global::Cpp2ILInjected.Token(Token = "0x6003136")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C92BC", Offset = "0x17C92BC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.CancellationTokenSource), Member = "ExecuteCallbackHandlers", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "ProcessChildCompletion", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "AddTaskContinuationComplex", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "WhenAny", MemberParameters = new object[] { typeof(IEnumerable<global::System.Threading.Tasks.Task>) }, ReturnType = typeof(global::System.Threading.Tasks.Task<global::System.Threading.Tasks.Task>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.TaskExceptionHolder), Member = "AddFaultException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		public void Add(T item)
		{
			throw null;
		}

		// Token: 0x06002CAD RID: 11437 RVA: 0x0001C169 File Offset: 0x0001A369
		[global::Cpp2ILInjected.Token(Token = "0x6003137")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C932C", Offset = "0x17C932C", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void EnsureCapacity(int min)
		{
			throw null;
		}

		// Token: 0x06002CAE RID: 11438 RVA: 0x0001C16C File Offset: 0x0001A36C
		[global::Cpp2ILInjected.Token(Token = "0x6003138")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C936C", Offset = "0x17C936C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.TaskExceptionHolder), Member = "AddFaultException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void AddRange(IEnumerable<T> collection)
		{
			throw null;
		}

		// Token: 0x06002CAF RID: 11439 RVA: 0x0001C16F File Offset: 0x0001A36F
		[global::Cpp2ILInjected.Token(Token = "0x6003139")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C938C", Offset = "0x17C938C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06002CB0 RID: 11440 RVA: 0x0001C172 File Offset: 0x0001A372
		[global::Cpp2ILInjected.Token(Token = "0x600313A")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C93C8", Offset = "0x17C93C8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Contains(T item)
		{
			throw null;
		}

		// Token: 0x06002CB1 RID: 11441 RVA: 0x0001C175 File Offset: 0x0001A375
		[global::Cpp2ILInjected.Token(Token = "0x600313B")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C9430", Offset = "0x17C9430", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void CopyTo(T[] array, int arrayIndex)
		{
			throw null;
		}

		// Token: 0x06002CB2 RID: 11442 RVA: 0x0001C178 File Offset: 0x0001A378
		[global::Cpp2ILInjected.Token(Token = "0x600313C")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C9450", Offset = "0x17C9450", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "RemoveContinuation", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public int IndexOf(T item)
		{
			throw null;
		}

		// Token: 0x06002CB3 RID: 11443 RVA: 0x0001C17B File Offset: 0x0001A37B
		[global::Cpp2ILInjected.Token(Token = "0x600313D")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C9474", Offset = "0x17C9474", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "AddTaskContinuationComplex", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void Insert(int index, T item)
		{
			throw null;
		}

		// Token: 0x06002CB4 RID: 11444 RVA: 0x0001C17E File Offset: 0x0001A37E
		[global::Cpp2ILInjected.Token(Token = "0x600313E")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C955C", Offset = "0x17C955C", Length = "0x5A4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		public void InsertRange(int index, IEnumerable<T> collection)
		{
			throw null;
		}

		// Token: 0x06002CB5 RID: 11445 RVA: 0x0001C181 File Offset: 0x0001A381
		[global::Cpp2ILInjected.Token(Token = "0x600313F")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C9B00", Offset = "0x17C9B00", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Remove(T item)
		{
			throw null;
		}

		// Token: 0x06002CB6 RID: 11446 RVA: 0x0001C184 File Offset: 0x0001A384
		[global::Cpp2ILInjected.Token(Token = "0x6003140")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C9B5C", Offset = "0x17C9B5C", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "Finish", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "AddTaskContinuationComplex", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public int RemoveAll(global::System.Predicate<T> match)
		{
			throw null;
		}

		// Token: 0x06002CB7 RID: 11447 RVA: 0x0001C187 File Offset: 0x0001A387
		[global::Cpp2ILInjected.Token(Token = "0x6003141")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C9CD4", Offset = "0x17C9CD4", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void RemoveAt(int index)
		{
			throw null;
		}

		// Token: 0x06002CB8 RID: 11448 RVA: 0x0001C18A File Offset: 0x0001A38A
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003142")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C9D7C", Offset = "0x17C9D7C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		static LowLevelList()
		{
			throw null;
		}

		// Token: 0x04001632 RID: 5682
		[global::Cpp2ILInjected.Token(Token = "0x4001A9D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		protected T[] _items;

		// Token: 0x04001633 RID: 5683
		[global::Cpp2ILInjected.Token(Token = "0x4001A9E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		protected int _size;

		// Token: 0x04001634 RID: 5684
		[global::Cpp2ILInjected.Token(Token = "0x4001A9F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		protected int _version;

		// Token: 0x04001635 RID: 5685
		[global::Cpp2ILInjected.Token(Token = "0x4001AA0")]
		private static readonly T[] s_emptyArray;
	}
}