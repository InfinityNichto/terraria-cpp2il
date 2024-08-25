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
	[DefaultMember("Item")]
	[global::Cpp2ILInjected.Token(Token = "0x200001F")]
	public class Lookup<TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x60000ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C7208", Offset = "0x17C7208", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4000074")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private IEqualityComparer<TKey> comparer;

		[global::Cpp2ILInjected.Token(Token = "0x4000075")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Lookup<TKey, TElement>.Grouping[] groupings;

		[global::Cpp2ILInjected.Token(Token = "0x4000076")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Lookup<TKey, TElement>.Grouping lastGrouping;

		[global::Cpp2ILInjected.Token(Token = "0x4000077")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int count;

		[global::Cpp2ILInjected.Token(Token = "0x2000020")]
		internal class Grouping : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable, IList<TElement>, ICollection<TElement>
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x60000F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x16B0760", Offset = "0x16B0760", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x60000F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x16B07DC", Offset = "0x16B07DC", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private bool System.Collections.Generic.ICollection<TElement>.Contains(TElement item)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x60000FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x16B085C", Offset = "0x16B085C", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private int System.Collections.Generic.IList<TElement>.IndexOf(TElement item)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x6000101")]
			[global::Cpp2ILInjected.Address(RVA = "0x16B0950", Offset = "0x16B0950", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Grouping()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000078")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal TKey key;

			[global::Cpp2ILInjected.Token(Token = "0x4000079")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal int hashCode;

			[global::Cpp2ILInjected.Token(Token = "0x400007A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal TElement[] elements;

			[global::Cpp2ILInjected.Token(Token = "0x400007B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal int count;

			[global::Cpp2ILInjected.Token(Token = "0x400007C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal Lookup<TKey, TElement>.Grouping hashNext;

			[global::Cpp2ILInjected.Token(Token = "0x400007D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal Lookup<TKey, TElement>.Grouping next;

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000021")]
			private sealed class <GetEnumerator>d__7 : IEnumerator<TElement>, IDisposable, IEnumerator
			{
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

				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6000103")]
				[global::Cpp2ILInjected.Address(RVA = "0x15BAF28", Offset = "0x15BAF28", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				private void System.IDisposable.Dispose()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6000104")]
				[global::Cpp2ILInjected.Address(RVA = "0x15BAF2C", Offset = "0x15BAF2C", Length = "0x6C")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				private bool MoveNext()
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x400007E")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				private int <>1__state;

				[global::Cpp2ILInjected.Token(Token = "0x400007F")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				private TElement <>2__current;

				[global::Cpp2ILInjected.Token(Token = "0x4000080")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				public Lookup<TKey, TElement>.Grouping <>4__this;

				[global::Cpp2ILInjected.Token(Token = "0x4000081")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				private int <i>5__2;
			}
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000022")]
		private sealed class <GetEnumerator>d__12 : IEnumerator<IGrouping<TKey, TElement>>, IDisposable, IEnumerator
		{
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

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000109")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BA4F0", Offset = "0x15BA4F0", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600010A")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BA4F4", Offset = "0x15BA4F4", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private bool MoveNext()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x4000082")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[global::Cpp2ILInjected.Token(Token = "0x4000083")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IGrouping<TKey, TElement> <>2__current;

			[global::Cpp2ILInjected.Token(Token = "0x4000084")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Lookup<TKey, TElement> <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000085")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private Lookup<TKey, TElement>.Grouping <g>5__2;
		}
	}
}
