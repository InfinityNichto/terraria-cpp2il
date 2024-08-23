using System;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	// Token: 0x0200052F RID: 1327
	[global::Cpp2ILInjected.Token(Token = "0x200064C")]
	internal sealed class LowLevelListWithIList<T> : LowLevelList<T>, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		// Token: 0x06002CB9 RID: 11449 RVA: 0x0001C18D File Offset: 0x0001A38D
		[global::Cpp2ILInjected.Token(Token = "0x6003143")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C8DE8", Offset = "0x17C8DE8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.CancellationTokenSource), Member = "ExecuteCallbackHandlers", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "ProcessChildCompletion", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "AddTaskContinuationComplex", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "RemoveContinuation", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task), Member = "WhenAny", MemberParameters = new object[] { typeof(IEnumerable<global::System.Threading.Tasks.Task>) }, ReturnType = typeof(global::System.Threading.Tasks.Task<global::System.Threading.Tasks.Task>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public LowLevelListWithIList()
		{
			throw null;
		}

		// Token: 0x06002CBA RID: 11450 RVA: 0x0001C190 File Offset: 0x0001A390
		[global::Cpp2ILInjected.Token(Token = "0x6003144")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C8E48", Offset = "0x17C8E48", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.TaskExceptionHolder), Member = "AddFaultException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public LowLevelListWithIList(int capacity)
		{
			throw null;
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06002CBB RID: 11451 RVA: 0x0001C193 File Offset: 0x0001A393
		[global::Cpp2ILInjected.Token(Token = "0x170007F3")]
		private bool System.Collections.Generic.ICollection<T>.IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003145")]
			[global::Cpp2ILInjected.Address(RVA = "0x17C8EB0", Offset = "0x17C8EB0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002CBC RID: 11452 RVA: 0x0001C196 File Offset: 0x0001A396
		[global::Cpp2ILInjected.Token(Token = "0x6003146")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C8EB8", Offset = "0x17C8EB8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LowLevelListWithIList<>.Enumerator), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.LowLevelListWithIList`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06002CBD RID: 11453 RVA: 0x0001C199 File Offset: 0x0001A399
		[global::Cpp2ILInjected.Token(Token = "0x6003147")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C8F20", Offset = "0x17C8F20", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LowLevelListWithIList<>.Enumerator), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.LowLevelListWithIList`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x02000663 RID: 1635
		[global::Cpp2ILInjected.Token(Token = "0x200064D")]
		private struct Enumerator : IEnumerator<T>, global::System.IDisposable, IEnumerator
		{
			// Token: 0x0600434E RID: 17230 RVA: 0x0002043E File Offset: 0x0001E63E
			[global::Cpp2ILInjected.Token(Token = "0x6003148")]
			[global::Cpp2ILInjected.Address(RVA = "0x16484F0", Offset = "0x16484F0", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LowLevelListWithIList<>), Member = "System.Collections.Generic.IEnumerable<T>.GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LowLevelListWithIList<>), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			internal Enumerator(LowLevelListWithIList<T> list)
			{
				throw null;
			}

			// Token: 0x0600434F RID: 17231 RVA: 0x00020441 File Offset: 0x0001E641
			[global::Cpp2ILInjected.Token(Token = "0x6003149")]
			[global::Cpp2ILInjected.Address(RVA = "0x1648508", Offset = "0x1648508", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Dispose()
			{
				throw null;
			}

			// Token: 0x06004350 RID: 17232 RVA: 0x00020444 File Offset: 0x0001E644
			[global::Cpp2ILInjected.Token(Token = "0x600314A")]
			[global::Cpp2ILInjected.Address(RVA = "0x164850C", Offset = "0x164850C", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LowLevelListWithIList<>.Enumerator), Member = "MoveNextRare", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public bool MoveNext()
			{
				throw null;
			}

			// Token: 0x06004351 RID: 17233 RVA: 0x00020447 File Offset: 0x0001E647
			[global::Cpp2ILInjected.Token(Token = "0x600314B")]
			[global::Cpp2ILInjected.Address(RVA = "0x164857C", Offset = "0x164857C", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LowLevelListWithIList<>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private bool MoveNextRare()
			{
				throw null;
			}

			// Token: 0x170007EF RID: 2031
			// (get) Token: 0x06004352 RID: 17234 RVA: 0x0002044A File Offset: 0x0001E64A
			[global::Cpp2ILInjected.Token(Token = "0x170007F4")]
			public T Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x600314C")]
				[global::Cpp2ILInjected.Address(RVA = "0x16485E4", Offset = "0x16485E4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007F0 RID: 2032
			// (get) Token: 0x06004353 RID: 17235 RVA: 0x0002044D File Offset: 0x0001E64D
			[global::Cpp2ILInjected.Token(Token = "0x170007F5")]
			private object System.Collections.IEnumerator.Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x600314D")]
				[global::Cpp2ILInjected.Address(RVA = "0x16485EC", Offset = "0x16485EC", Length = "0x74")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004354 RID: 17236 RVA: 0x00020450 File Offset: 0x0001E650
			[global::Cpp2ILInjected.Token(Token = "0x600314E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1648660", Offset = "0x1648660", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x04001AE2 RID: 6882
			[global::Cpp2ILInjected.Token(Token = "0x4001AA1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private LowLevelListWithIList<T> _list;

			// Token: 0x04001AE3 RID: 6883
			[global::Cpp2ILInjected.Token(Token = "0x4001AA2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _index;

			// Token: 0x04001AE4 RID: 6884
			[global::Cpp2ILInjected.Token(Token = "0x4001AA3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _version;

			// Token: 0x04001AE5 RID: 6885
			[global::Cpp2ILInjected.Token(Token = "0x4001AA4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private T _current;
		}
	}
}
