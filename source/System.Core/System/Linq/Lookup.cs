using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Linq
{
	// Token: 0x0200000D RID: 13
	[DefaultMember("Item")]
	[global::Cpp2ILInjected.Token(Token = "0x200001F")]
	public class Lookup<TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
	{
		// Token: 0x0600006E RID: 110 RVA: 0x00004409 File Offset: 0x00002609
		[global::Cpp2ILInjected.Token(Token = "0x60000EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x14C2784", Offset = "0x14C2784", Length = "0x49C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		internal static Lookup<TKey, TElement> Create<TSource>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
			throw null;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000440C File Offset: 0x0000260C
		[global::Cpp2ILInjected.Token(Token = "0x60000EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C7134", Offset = "0x17C7134", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private Lookup(IEqualityComparer<TKey> comparer)
		{
			throw null;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000440F File Offset: 0x0000260F
		[global::Cpp2ILInjected.Token(Token = "0x60000EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C71A0", Offset = "0x17C71A0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00004412 File Offset: 0x00002612
		[global::Cpp2ILInjected.Token(Token = "0x60000ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C7208", Offset = "0x17C7208", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00004415 File Offset: 0x00002615
		[global::Cpp2ILInjected.Token(Token = "0x60000EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C721C", Offset = "0x17C721C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal int InternalGetHashCode(TKey key)
		{
			throw null;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00004418 File Offset: 0x00002618
		[global::Cpp2ILInjected.Token(Token = "0x60000EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C72BC", Offset = "0x17C72BC", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal Lookup<TKey, TElement>.Grouping GetGrouping(TKey key, bool create)
		{
			throw null;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000441B File Offset: 0x0000261B
		[global::Cpp2ILInjected.Token(Token = "0x60000F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C74D4", Offset = "0x17C74D4", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void Resize()
		{
			throw null;
		}

		// Token: 0x04000011 RID: 17
		[global::Cpp2ILInjected.Token(Token = "0x4000074")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private IEqualityComparer<TKey> comparer;

		// Token: 0x04000012 RID: 18
		[global::Cpp2ILInjected.Token(Token = "0x4000075")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Lookup<TKey, TElement>.Grouping[] groupings;

		// Token: 0x04000013 RID: 19
		[global::Cpp2ILInjected.Token(Token = "0x4000076")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Lookup<TKey, TElement>.Grouping lastGrouping;

		// Token: 0x04000014 RID: 20
		[global::Cpp2ILInjected.Token(Token = "0x4000077")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int count;

		// Token: 0x02000036 RID: 54
		[global::Cpp2ILInjected.Token(Token = "0x2000020")]
		internal class Grouping : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable, IList<TElement>, ICollection<TElement>
		{
			// Token: 0x06000135 RID: 309 RVA: 0x00004649 File Offset: 0x00002849
			[global::Cpp2ILInjected.Token(Token = "0x60000F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x16B0648", Offset = "0x16B0648", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal void Add(TElement element)
			{
				throw null;
			}

			// Token: 0x06000136 RID: 310 RVA: 0x0000464C File Offset: 0x0000284C
			[global::Cpp2ILInjected.Token(Token = "0x60000F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x16B06F8", Offset = "0x16B06F8", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public IEnumerator<TElement> GetEnumerator()
			{
				throw null;
			}

			// Token: 0x06000137 RID: 311 RVA: 0x0000464F File Offset: 0x0000284F
			[global::Cpp2ILInjected.Token(Token = "0x60000F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x16B0760", Offset = "0x16B0760", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x06000138 RID: 312 RVA: 0x00004652 File Offset: 0x00002852
			[global::Cpp2ILInjected.Token(Token = "0x17000021")]
			public TKey Key
			{
				[global::Cpp2ILInjected.Token(Token = "0x60000F4")]
				[global::Cpp2ILInjected.Address(RVA = "0x16B0774", Offset = "0x16B0774", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x06000139 RID: 313 RVA: 0x00004655 File Offset: 0x00002855
			[global::Cpp2ILInjected.Token(Token = "0x17000022")]
			private int System.Collections.Generic.ICollection<TElement>.Count
			{
				[global::Cpp2ILInjected.Token(Token = "0x60000F5")]
				[global::Cpp2ILInjected.Address(RVA = "0x16B077C", Offset = "0x16B077C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x0600013A RID: 314 RVA: 0x00004658 File Offset: 0x00002858
			[global::Cpp2ILInjected.Token(Token = "0x17000023")]
			private bool System.Collections.Generic.ICollection<TElement>.IsReadOnly
			{
				[global::Cpp2ILInjected.Token(Token = "0x60000F6")]
				[global::Cpp2ILInjected.Address(RVA = "0x16B0784", Offset = "0x16B0784", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600013B RID: 315 RVA: 0x0000465B File Offset: 0x0000285B
			[global::Cpp2ILInjected.Token(Token = "0x60000F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x16B078C", Offset = "0x16B078C", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "NotSupported", ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private void System.Collections.Generic.ICollection<TElement>.Add(TElement item)
			{
				throw null;
			}

			// Token: 0x0600013C RID: 316 RVA: 0x0000465E File Offset: 0x0000285E
			[global::Cpp2ILInjected.Token(Token = "0x60000F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x16B07B4", Offset = "0x16B07B4", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "NotSupported", ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private void System.Collections.Generic.ICollection<TElement>.Clear()
			{
				throw null;
			}

			// Token: 0x0600013D RID: 317 RVA: 0x00004661 File Offset: 0x00002861
			[global::Cpp2ILInjected.Token(Token = "0x60000F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x16B07DC", Offset = "0x16B07DC", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private bool System.Collections.Generic.ICollection<TElement>.Contains(TElement item)
			{
				throw null;
			}

			// Token: 0x0600013E RID: 318 RVA: 0x00004664 File Offset: 0x00002864
			[global::Cpp2ILInjected.Token(Token = "0x60000FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x16B0814", Offset = "0x16B0814", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(int),
				typeof(Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			private void System.Collections.Generic.ICollection<TElement>.CopyTo(TElement[] array, int arrayIndex)
			{
				throw null;
			}

			// Token: 0x0600013F RID: 319 RVA: 0x00004667 File Offset: 0x00002867
			[global::Cpp2ILInjected.Token(Token = "0x60000FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x16B0834", Offset = "0x16B0834", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "NotSupported", ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private bool System.Collections.Generic.ICollection<TElement>.Remove(TElement item)
			{
				throw null;
			}

			// Token: 0x06000140 RID: 320 RVA: 0x0000466A File Offset: 0x0000286A
			[global::Cpp2ILInjected.Token(Token = "0x60000FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x16B085C", Offset = "0x16B085C", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private int System.Collections.Generic.IList<TElement>.IndexOf(TElement item)
			{
				throw null;
			}

			// Token: 0x06000141 RID: 321 RVA: 0x0000466D File Offset: 0x0000286D
			[global::Cpp2ILInjected.Token(Token = "0x60000FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x16B0880", Offset = "0x16B0880", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "NotSupported", ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private void System.Collections.Generic.IList<TElement>.Insert(int index, TElement item)
			{
				throw null;
			}

			// Token: 0x06000142 RID: 322 RVA: 0x00004670 File Offset: 0x00002870
			[global::Cpp2ILInjected.Token(Token = "0x60000FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x16B08A8", Offset = "0x16B08A8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "NotSupported", ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private void System.Collections.Generic.IList<TElement>.RemoveAt(int index)
			{
				throw null;
			}

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x06000143 RID: 323 RVA: 0x00004673 File Offset: 0x00002873
			// (set) Token: 0x06000144 RID: 324 RVA: 0x00004676 File Offset: 0x00002876
			[global::Cpp2ILInjected.Token(Token = "0x17000024")]
			private TElement System.Collections.Generic.IList<TElement>.Item
			{
				[global::Cpp2ILInjected.Token(Token = "0x60000FF")]
				[global::Cpp2ILInjected.Address(RVA = "0x16B08D0", Offset = "0x16B08D0", Length = "0x58")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentOutOfRange", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6000100")]
				[global::Cpp2ILInjected.Address(RVA = "0x16B0928", Offset = "0x16B0928", Length = "0x28")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "NotSupported", ReturnType = typeof(Exception))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				set
				{
					throw null;
				}
			}

			// Token: 0x06000145 RID: 325 RVA: 0x00004679 File Offset: 0x00002879
			[global::Cpp2ILInjected.Token(Token = "0x6000101")]
			[global::Cpp2ILInjected.Address(RVA = "0x16B0950", Offset = "0x16B0950", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Grouping()
			{
				throw null;
			}

			// Token: 0x040000B9 RID: 185
			[global::Cpp2ILInjected.Token(Token = "0x4000078")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal TKey key;

			// Token: 0x040000BA RID: 186
			[global::Cpp2ILInjected.Token(Token = "0x4000079")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal int hashCode;

			// Token: 0x040000BB RID: 187
			[global::Cpp2ILInjected.Token(Token = "0x400007A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal TElement[] elements;

			// Token: 0x040000BC RID: 188
			[global::Cpp2ILInjected.Token(Token = "0x400007B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal int count;

			// Token: 0x040000BD RID: 189
			[global::Cpp2ILInjected.Token(Token = "0x400007C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal Lookup<TKey, TElement>.Grouping hashNext;

			// Token: 0x040000BE RID: 190
			[global::Cpp2ILInjected.Token(Token = "0x400007D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal Lookup<TKey, TElement>.Grouping next;

			// Token: 0x0200003F RID: 63
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000021")]
			private sealed class <GetEnumerator>d__7 : IEnumerator<TElement>, IDisposable, IEnumerator
			{
				// Token: 0x06000158 RID: 344 RVA: 0x000046B2 File Offset: 0x000028B2
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6000102")]
				[global::Cpp2ILInjected.Address(RVA = "0x15BAF00", Offset = "0x15BAF00", Length = "0x28")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <GetEnumerator>d__7(int <>1__state)
				{
					throw null;
				}

				// Token: 0x06000159 RID: 345 RVA: 0x000046B5 File Offset: 0x000028B5
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6000103")]
				[global::Cpp2ILInjected.Address(RVA = "0x15BAF28", Offset = "0x15BAF28", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				private void System.IDisposable.Dispose()
				{
					throw null;
				}

				// Token: 0x0600015A RID: 346 RVA: 0x000046B8 File Offset: 0x000028B8
				[global::Cpp2ILInjected.Token(Token = "0x6000104")]
				[global::Cpp2ILInjected.Address(RVA = "0x15BAF2C", Offset = "0x15BAF2C", Length = "0x6C")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				private bool MoveNext()
				{
					throw null;
				}

				// Token: 0x1700002E RID: 46
				// (get) Token: 0x0600015B RID: 347 RVA: 0x000046BB File Offset: 0x000028BB
				[global::Cpp2ILInjected.Token(Token = "0x17000025")]
				private TElement System.Collections.Generic.IEnumerator<TElement>.Current
				{
					[DebuggerHidden]
					[global::Cpp2ILInjected.Token(Token = "0x6000105")]
					[global::Cpp2ILInjected.Address(RVA = "0x15BAF98", Offset = "0x15BAF98", Length = "0x8")]
					[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				// Token: 0x0600015C RID: 348 RVA: 0x000046BE File Offset: 0x000028BE
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6000106")]
				[global::Cpp2ILInjected.Address(RVA = "0x15BAFA0", Offset = "0x15BAFA0", Length = "0x38")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				private void System.Collections.IEnumerator.Reset()
				{
					throw null;
				}

				// Token: 0x1700002F RID: 47
				// (get) Token: 0x0600015D RID: 349 RVA: 0x000046C1 File Offset: 0x000028C1
				[global::Cpp2ILInjected.Token(Token = "0x17000026")]
				private object System.Collections.IEnumerator.Current
				{
					[DebuggerHidden]
					[global::Cpp2ILInjected.Token(Token = "0x6000107")]
					[global::Cpp2ILInjected.Address(RVA = "0x15BAFD8", Offset = "0x15BAFD8", Length = "0x8")]
					[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				// Token: 0x040000D3 RID: 211
				[global::Cpp2ILInjected.Token(Token = "0x400007E")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				private int <>1__state;

				// Token: 0x040000D4 RID: 212
				[global::Cpp2ILInjected.Token(Token = "0x400007F")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				private TElement <>2__current;

				// Token: 0x040000D5 RID: 213
				[global::Cpp2ILInjected.Token(Token = "0x4000080")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				public Lookup<TKey, TElement>.Grouping <>4__this;

				// Token: 0x040000D6 RID: 214
				[global::Cpp2ILInjected.Token(Token = "0x4000081")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				private int <i>5__2;
			}
		}

		// Token: 0x02000037 RID: 55
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000022")]
		private sealed class <GetEnumerator>d__12 : IEnumerator<IGrouping<TKey, TElement>>, IDisposable, IEnumerator
		{
			// Token: 0x06000146 RID: 326 RVA: 0x0000467C File Offset: 0x0000287C
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000108")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BA4C8", Offset = "0x15BA4C8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <GetEnumerator>d__12(int <>1__state)
			{
				throw null;
			}

			// Token: 0x06000147 RID: 327 RVA: 0x0000467F File Offset: 0x0000287F
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000109")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BA4F0", Offset = "0x15BA4F0", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x06000148 RID: 328 RVA: 0x00004682 File Offset: 0x00002882
			[global::Cpp2ILInjected.Token(Token = "0x600010A")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BA4F4", Offset = "0x15BA4F4", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x06000149 RID: 329 RVA: 0x00004685 File Offset: 0x00002885
			[global::Cpp2ILInjected.Token(Token = "0x17000027")]
			private IGrouping<TKey, TElement> prop_IGrouping_2_0
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x600010B")]
				[global::Cpp2ILInjected.Address(RVA = "0x15BA558", Offset = "0x15BA558", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600014A RID: 330 RVA: 0x00004688 File Offset: 0x00002888
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600010C")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BA560", Offset = "0x15BA560", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x0600014B RID: 331 RVA: 0x0000468B File Offset: 0x0000288B
			[global::Cpp2ILInjected.Token(Token = "0x17000028")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x600010D")]
				[global::Cpp2ILInjected.Address(RVA = "0x15BA598", Offset = "0x15BA598", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x040000BF RID: 191
			[global::Cpp2ILInjected.Token(Token = "0x4000082")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			// Token: 0x040000C0 RID: 192
			[global::Cpp2ILInjected.Token(Token = "0x4000083")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IGrouping<TKey, TElement> <>2__current;

			// Token: 0x040000C1 RID: 193
			[global::Cpp2ILInjected.Token(Token = "0x4000084")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Lookup<TKey, TElement> <>4__this;

			// Token: 0x040000C2 RID: 194
			[global::Cpp2ILInjected.Token(Token = "0x4000085")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private Lookup<TKey, TElement>.Grouping <g>5__2;
		}
	}
}
