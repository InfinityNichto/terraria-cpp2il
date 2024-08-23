using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x02000183 RID: 387
	[global::Cpp2ILInjected.Token(Token = "0x20001DB")]
	internal class SparselyPopulatedArrayFragment<T> where T : class
	{
		// Token: 0x06000FF7 RID: 4087 RVA: 0x0001723A File Offset: 0x0001543A
		[global::Cpp2ILInjected.Token(Token = "0x6001135")]
		[global::Cpp2ILInjected.Address(RVA = "0x186ECAC", Offset = "0x186ECAC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal SparselyPopulatedArrayFragment(int size)
		{
			throw null;
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x0001723D File Offset: 0x0001543D
		[global::Cpp2ILInjected.Token(Token = "0x6001136")]
		[global::Cpp2ILInjected.Address(RVA = "0x186ECC4", Offset = "0x186ECC4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal SparselyPopulatedArrayFragment(int size, SparselyPopulatedArrayFragment<T> prev)
		{
			throw null;
		}

		// Token: 0x17000164 RID: 356
		[global::Cpp2ILInjected.Token(Token = "0x1700019A")]
		internal T this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001137")]
			[global::Cpp2ILInjected.Address(RVA = "0x186ED2C", Offset = "0x186ED2C", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "ExecuteCallbackHandlers", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000FFA RID: 4090 RVA: 0x00017243 File Offset: 0x00015443
		[global::Cpp2ILInjected.Token(Token = "0x1700019B")]
		internal int Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001138")]
			[global::Cpp2ILInjected.Address(RVA = "0x186ED4C", Offset = "0x186ED4C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "ExecuteCallbackHandlers", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000FFB RID: 4091 RVA: 0x00017246 File Offset: 0x00015446
		[global::Cpp2ILInjected.Token(Token = "0x1700019C")]
		internal SparselyPopulatedArrayFragment<T> Prev
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001139")]
			[global::Cpp2ILInjected.Address(RVA = "0x186ED58", Offset = "0x186ED58", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "ExecuteCallbackHandlers", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x00017249 File Offset: 0x00015449
		[global::Cpp2ILInjected.Token(Token = "0x600113A")]
		[global::Cpp2ILInjected.Address(RVA = "0x186ED70", Offset = "0x186ED70", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenRegistration), Member = "Unregister", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "CancellationCallbackCoreWork", MemberParameters = new object[] { typeof(CancellationCallbackCoreWorkArguments) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal T SafeAtomicRemove(int index, T expectedElement)
		{
			throw null;
		}

		// Token: 0x04000740 RID: 1856
		[global::Cpp2ILInjected.Token(Token = "0x4000947")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal readonly T[] _elements;

		// Token: 0x04000741 RID: 1857
		[global::Cpp2ILInjected.Token(Token = "0x4000948")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal int _freeCount;

		// Token: 0x04000742 RID: 1858
		[global::Cpp2ILInjected.Token(Token = "0x4000949")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal SparselyPopulatedArrayFragment<T> _next;

		// Token: 0x04000743 RID: 1859
		[global::Cpp2ILInjected.Token(Token = "0x400094A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal SparselyPopulatedArrayFragment<T> _prev;
	}
}
