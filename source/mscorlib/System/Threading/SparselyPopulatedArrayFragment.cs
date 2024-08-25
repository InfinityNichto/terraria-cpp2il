using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	[global::Cpp2ILInjected.Token(Token = "0x20001DB")]
	internal class SparselyPopulatedArrayFragment<T> where T : class
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001135")]
		[global::Cpp2ILInjected.Address(RVA = "0x186ECAC", Offset = "0x186ECAC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal SparselyPopulatedArrayFragment(int size)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4000947")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal readonly T[] _elements;

		[global::Cpp2ILInjected.Token(Token = "0x4000948")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal int _freeCount;

		[global::Cpp2ILInjected.Token(Token = "0x4000949")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal SparselyPopulatedArrayFragment<T> _next;

		[global::Cpp2ILInjected.Token(Token = "0x400094A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal SparselyPopulatedArrayFragment<T> _prev;
	}
}
