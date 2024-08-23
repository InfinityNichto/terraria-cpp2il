using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Pool
{
	// Token: 0x02000130 RID: 304
	[global::Cpp2ILInjected.Token(Token = "0x2000158")]
	public class ObjectPool<T> : IDisposable where T : class
	{
		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x00002E27 File Offset: 0x00001027
		// (set) Token: 0x06000634 RID: 1588 RVA: 0x00002E2A File Offset: 0x0000102A
		[global::Cpp2ILInjected.Token(Token = "0x17000153")]
		public int CountAll
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600066F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1817CCC", Offset = "0x1817CCC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000670")]
			[global::Cpp2ILInjected.Address(RVA = "0x1817CD4", Offset = "0x1817CD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x00002E2D File Offset: 0x0000102D
		[global::Cpp2ILInjected.Token(Token = "0x17000154")]
		public int CountInactive
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000671")]
			[global::Cpp2ILInjected.Address(RVA = "0x1817CDC", Offset = "0x1817CDC", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00002E30 File Offset: 0x00001030
		[global::Cpp2ILInjected.Token(Token = "0x6000672")]
		[global::Cpp2ILInjected.Address(RVA = "0x1817CF4", Offset = "0x1817CF4", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutRebuilder", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public ObjectPool(Func<T> createFunc, Action<T> actionOnGet = null, Action<T> actionOnRelease = null, Action<T> actionOnDestroy = null, bool collectionCheck = true, int defaultCapacity = 10, int maxSize = 10000)
		{
			throw null;
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00002E33 File Offset: 0x00001033
		[global::Cpp2ILInjected.Token(Token = "0x6000673")]
		[global::Cpp2ILInjected.Address(RVA = "0x1817E40", Offset = "0x1817E40", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutRebuilder", Member = "ForceRebuildLayoutImmediate", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutRebuilder", Member = "MarkLayoutRootForRebuild", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public T Get()
		{
			throw null;
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00002E36 File Offset: 0x00001036
		[global::Cpp2ILInjected.Token(Token = "0x6000674")]
		[global::Cpp2ILInjected.Address(RVA = "0x1817F58", Offset = "0x1817F58", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutRebuilder", Member = "ForceRebuildLayoutImmediate", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutRebuilder", Member = "MarkLayoutRootForRebuild", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutRebuilder", Member = "LayoutComplete", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Release(T element)
		{
			throw null;
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00002E39 File Offset: 0x00001039
		[global::Cpp2ILInjected.Token(Token = "0x6000675")]
		[global::Cpp2ILInjected.Address(RVA = "0x1817FF8", Offset = "0x1817FF8", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00002E3C File Offset: 0x0000103C
		[global::Cpp2ILInjected.Token(Token = "0x6000676")]
		[global::Cpp2ILInjected.Address(RVA = "0x1818160", Offset = "0x1818160", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x040005E1 RID: 1505
		[global::Cpp2ILInjected.Token(Token = "0x4000638")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal readonly List<T> m_List;

		// Token: 0x040005E2 RID: 1506
		[global::Cpp2ILInjected.Token(Token = "0x4000639")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly Func<T> m_CreateFunc;

		// Token: 0x040005E3 RID: 1507
		[global::Cpp2ILInjected.Token(Token = "0x400063A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly Action<T> m_ActionOnGet;

		// Token: 0x040005E4 RID: 1508
		[global::Cpp2ILInjected.Token(Token = "0x400063B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly Action<T> m_ActionOnRelease;

		// Token: 0x040005E5 RID: 1509
		[global::Cpp2ILInjected.Token(Token = "0x400063C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly Action<T> m_ActionOnDestroy;

		// Token: 0x040005E6 RID: 1510
		[global::Cpp2ILInjected.Token(Token = "0x400063D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly int m_MaxSize;

		// Token: 0x040005E7 RID: 1511
		[global::Cpp2ILInjected.Token(Token = "0x400063E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal bool m_CollectionCheck;

		// Token: 0x040005E8 RID: 1512
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400063F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int <CountAll>k__BackingField;
	}
}
