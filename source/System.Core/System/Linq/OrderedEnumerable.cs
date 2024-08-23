using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Linq
{
	// Token: 0x02000010 RID: 16
	[global::Cpp2ILInjected.Token(Token = "0x2000026")]
	internal abstract class OrderedEnumerable<TElement> : IOrderedEnumerable<TElement>, IEnumerable<TElement>, IEnumerable
	{
		// Token: 0x0600007D RID: 125 RVA: 0x00004436 File Offset: 0x00002636
		[global::Cpp2ILInjected.Token(Token = "0x6000116")]
		[global::Cpp2ILInjected.Address(RVA = "0x1818174", Offset = "0x1818174", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IEnumerator<TElement> GetEnumerator()
		{
			throw null;
		}

		// Token: 0x0600007E RID: 126
		[global::Cpp2ILInjected.Token(Token = "0x6000117")]
		internal abstract EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next);

		// Token: 0x0600007F RID: 127 RVA: 0x00004439 File Offset: 0x00002639
		[global::Cpp2ILInjected.Token(Token = "0x6000118")]
		[global::Cpp2ILInjected.Address(RVA = "0x18181DC", Offset = "0x18181DC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000443C File Offset: 0x0000263C
		[global::Cpp2ILInjected.Token(Token = "0x6000119")]
		[global::Cpp2ILInjected.Address(RVA = "0x14C3594", Offset = "0x14C3594", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IOrderedEnumerable<TElement> System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending)
		{
			throw null;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000443F File Offset: 0x0000263F
		[global::Cpp2ILInjected.Token(Token = "0x600011A")]
		[global::Cpp2ILInjected.Address(RVA = "0x18181F0", Offset = "0x18181F0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected OrderedEnumerable()
		{
			throw null;
		}

		// Token: 0x0400001E RID: 30
		[global::Cpp2ILInjected.Token(Token = "0x4000092")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal IEnumerable<TElement> source;

		// Token: 0x02000039 RID: 57
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000027")]
		private sealed class <GetEnumerator>d__1 : IEnumerator<TElement>, IDisposable, IEnumerator
		{
			// Token: 0x0600014C RID: 332 RVA: 0x0000468E File Offset: 0x0000288E
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600011B")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BA198", Offset = "0x15BA198", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <GetEnumerator>d__1(int <>1__state)
			{
				throw null;
			}

			// Token: 0x0600014D RID: 333 RVA: 0x00004691 File Offset: 0x00002891
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600011C")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BA1C0", Offset = "0x15BA1C0", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x0600014E RID: 334 RVA: 0x00004694 File Offset: 0x00002894
			[global::Cpp2ILInjected.Token(Token = "0x600011D")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BA1C4", Offset = "0x15BA1C4", Length = "0x108")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer<>), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TElement>" }, ReturnType = typeof(void))]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x0600014F RID: 335 RVA: 0x00004697 File Offset: 0x00002897
			[global::Cpp2ILInjected.Token(Token = "0x17000029")]
			private TElement System.Collections.Generic.IEnumerator<TElement>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x600011E")]
				[global::Cpp2ILInjected.Address(RVA = "0x15BA2CC", Offset = "0x15BA2CC", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000150 RID: 336 RVA: 0x0000469A File Offset: 0x0000289A
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600011F")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BA2D8", Offset = "0x15BA2D8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x06000151 RID: 337 RVA: 0x0000469D File Offset: 0x0000289D
			[global::Cpp2ILInjected.Token(Token = "0x1700002A")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6000120")]
				[global::Cpp2ILInjected.Address(RVA = "0x15BA310", Offset = "0x15BA310", Length = "0x3C")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x040000C6 RID: 198
			[global::Cpp2ILInjected.Token(Token = "0x4000093")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			// Token: 0x040000C7 RID: 199
			[global::Cpp2ILInjected.Token(Token = "0x4000094")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private TElement <>2__current;

			// Token: 0x040000C8 RID: 200
			[global::Cpp2ILInjected.Token(Token = "0x4000095")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public OrderedEnumerable<TElement> <>4__this;

			// Token: 0x040000C9 RID: 201
			[global::Cpp2ILInjected.Token(Token = "0x4000096")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private Buffer<TElement> <buffer>5__2;

			// Token: 0x040000CA RID: 202
			[global::Cpp2ILInjected.Token(Token = "0x4000097")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int[] <map>5__3;

			// Token: 0x040000CB RID: 203
			[global::Cpp2ILInjected.Token(Token = "0x4000098")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <i>5__4;
		}
	}
}
