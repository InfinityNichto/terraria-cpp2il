using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.UI.Collections
{
	// Token: 0x02000045 RID: 69
	[global::Cpp2ILInjected.Token(Token = "0x2000087")]
	internal class IndexedSet<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		// Token: 0x060004BB RID: 1211 RVA: 0x00002E1B File Offset: 0x0000101B
		[global::Cpp2ILInjected.Token(Token = "0x600053C")]
		[global::Cpp2ILInjected.Address(RVA = "0x16BC650", Offset = "0x16BC650", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRegistry), Member = "RegisterGraphicForCanvas", MemberParameters = new object[]
		{
			typeof(Canvas),
			typeof(Graphic)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRegistry), Member = "RegisterRaycastGraphicForCanvas", MemberParameters = new object[]
		{
			typeof(Canvas),
			typeof(Graphic)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Add(T item)
		{
			throw null;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00002E1E File Offset: 0x0000101E
		[global::Cpp2ILInjected.Token(Token = "0x600053D")]
		[global::Cpp2ILInjected.Address(RVA = "0x16BC668", Offset = "0x16BC668", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Add(T item, bool isActive)
		{
			throw null;
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00002E21 File Offset: 0x00001021
		[global::Cpp2ILInjected.Token(Token = "0x600053E")]
		[global::Cpp2ILInjected.Address(RVA = "0x16BC710", Offset = "0x16BC710", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "InternalRegisterCanvasElementForLayoutRebuild", MemberParameters = new object[] { typeof(ICanvasElement) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "InternalRegisterCanvasElementForGraphicRebuild", MemberParameters = new object[] { typeof(ICanvasElement) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClipperRegistry), Member = "Register", MemberParameters = new object[] { typeof(IClipper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRegistry), Member = "RegisterGraphicForCanvas", MemberParameters = new object[]
		{
			typeof(Canvas),
			typeof(Graphic)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRegistry), Member = "RegisterRaycastGraphicForCanvas", MemberParameters = new object[]
		{
			typeof(Canvas),
			typeof(Graphic)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public bool AddUnique(T item, bool isActive = true)
		{
			throw null;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00002E24 File Offset: 0x00001024
		[global::Cpp2ILInjected.Token(Token = "0x600053F")]
		[global::Cpp2ILInjected.Address(RVA = "0x16BC7A8", Offset = "0x16BC7A8", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool EnableItem(T item)
		{
			throw null;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00002E27 File Offset: 0x00001027
		[global::Cpp2ILInjected.Token(Token = "0x6000540")]
		[global::Cpp2ILInjected.Address(RVA = "0x16BC82C", Offset = "0x16BC82C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "InternalDisableCanvasElementForLayoutRebuild", MemberParameters = new object[] { typeof(ICanvasElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "InternalDisableCanvasElementForGraphicRebuild", MemberParameters = new object[] { typeof(ICanvasElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClipperRegistry), Member = "Disable", MemberParameters = new object[] { typeof(IClipper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRegistry), Member = "DisableGraphicForCanvas", MemberParameters = new object[]
		{
			typeof(Canvas),
			typeof(Graphic)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRegistry), Member = "DisableRaycastGraphicForCanvas", MemberParameters = new object[]
		{
			typeof(Canvas),
			typeof(Graphic)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public bool DisableItem(T item)
		{
			throw null;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00002E2A File Offset: 0x0000102A
		[global::Cpp2ILInjected.Token(Token = "0x6000541")]
		[global::Cpp2ILInjected.Address(RVA = "0x16BC8B8", Offset = "0x16BC8B8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "InternalUnRegisterCanvasElementForLayoutRebuild", MemberParameters = new object[] { typeof(ICanvasElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "InternalUnRegisterCanvasElementForGraphicRebuild", MemberParameters = new object[] { typeof(ICanvasElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClipperRegistry), Member = "Unregister", MemberParameters = new object[] { typeof(IClipper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRegistry), Member = "UnregisterGraphicForCanvas", MemberParameters = new object[]
		{
			typeof(Canvas),
			typeof(Graphic)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRegistry), Member = "UnregisterRaycastGraphicForCanvas", MemberParameters = new object[]
		{
			typeof(Canvas),
			typeof(Graphic)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public bool Remove(T item)
		{
			throw null;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00002E2D File Offset: 0x0000102D
		[global::Cpp2ILInjected.Token(Token = "0x6000542")]
		[global::Cpp2ILInjected.Address(RVA = "0x16BC924", Offset = "0x16BC924", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public IEnumerator<T> GetEnumerator()
		{
			throw null;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00002E30 File Offset: 0x00001030
		[global::Cpp2ILInjected.Token(Token = "0x6000543")]
		[global::Cpp2ILInjected.Address(RVA = "0x16BC95C", Offset = "0x16BC95C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00002E33 File Offset: 0x00001033
		[global::Cpp2ILInjected.Token(Token = "0x6000544")]
		[global::Cpp2ILInjected.Address(RVA = "0x16BC970", Offset = "0x16BC970", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "PerformUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00002E36 File Offset: 0x00001036
		[global::Cpp2ILInjected.Token(Token = "0x6000545")]
		[global::Cpp2ILInjected.Address(RVA = "0x16BC9C0", Offset = "0x16BC9C0", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "InternalRegisterCanvasElementForLayoutRebuild", MemberParameters = new object[] { typeof(ICanvasElement) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool Contains(T item)
		{
			throw null;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00002E39 File Offset: 0x00001039
		[global::Cpp2ILInjected.Token(Token = "0x6000546")]
		[global::Cpp2ILInjected.Address(RVA = "0x16BC9D8", Offset = "0x16BC9D8", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void CopyTo(T[] array, int arrayIndex)
		{
			throw null;
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x00002E3C File Offset: 0x0000103C
		[global::Cpp2ILInjected.Token(Token = "0x17000158")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000547")]
			[global::Cpp2ILInjected.Address(RVA = "0x16BC9F0", Offset = "0x16BC9F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00002E3F File Offset: 0x0000103F
		[global::Cpp2ILInjected.Token(Token = "0x17000159")]
		public int Capacity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000548")]
			[global::Cpp2ILInjected.Address(RVA = "0x16BC9F8", Offset = "0x16BC9F8", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRegistry), Member = "UnregisterGraphicForCanvas", MemberParameters = new object[]
			{
				typeof(Canvas),
				typeof(Graphic)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRegistry), Member = "DisableGraphicForCanvas", MemberParameters = new object[]
			{
				typeof(Canvas),
				typeof(Graphic)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRegistry), Member = "DisableRaycastGraphicForCanvas", MemberParameters = new object[]
			{
				typeof(Canvas),
				typeof(Graphic)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x00002E42 File Offset: 0x00001042
		[global::Cpp2ILInjected.Token(Token = "0x1700015A")]
		public bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000549")]
			[global::Cpp2ILInjected.Address(RVA = "0x16BCA10", Offset = "0x16BCA10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00002E45 File Offset: 0x00001045
		[global::Cpp2ILInjected.Token(Token = "0x600054A")]
		[global::Cpp2ILInjected.Address(RVA = "0x16BCA18", Offset = "0x16BCA18", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int IndexOf(T item)
		{
			throw null;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00002E48 File Offset: 0x00001048
		[global::Cpp2ILInjected.Token(Token = "0x600054B")]
		[global::Cpp2ILInjected.Address(RVA = "0x16BCA54", Offset = "0x16BCA54", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void Insert(int index, T item)
		{
			throw null;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00002E4B File Offset: 0x0000104B
		[global::Cpp2ILInjected.Token(Token = "0x600054C")]
		[global::Cpp2ILInjected.Address(RVA = "0x16BCAA0", Offset = "0x16BCAA0", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "CleanInvalidItems", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void RemoveAt(int index)
		{
			throw null;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00002E4E File Offset: 0x0000104E
		[global::Cpp2ILInjected.Token(Token = "0x600054D")]
		[global::Cpp2ILInjected.Address(RVA = "0x16BCBFC", Offset = "0x16BCBFC", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Swap(int index1, int index2)
		{
			throw null;
		}

		// Token: 0x17000148 RID: 328
		[global::Cpp2ILInjected.Token(Token = "0x1700015B")]
		public T this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x600054E")]
			[global::Cpp2ILInjected.Address(RVA = "0x16BCCFC", Offset = "0x16BCCFC", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "CleanInvalidItems", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "PerformUpdate", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClipperRegistry), Member = "Cull", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600054F")]
			[global::Cpp2ILInjected.Address(RVA = "0x16BCD5C", Offset = "0x16BCD5C", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00002E57 File Offset: 0x00001057
		[global::Cpp2ILInjected.Token(Token = "0x6000550")]
		[global::Cpp2ILInjected.Address(RVA = "0x16BCDFC", Offset = "0x16BCDFC", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void RemoveAll(Predicate<T> match)
		{
			throw null;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00002E5A File Offset: 0x0000105A
		[global::Cpp2ILInjected.Token(Token = "0x6000551")]
		[global::Cpp2ILInjected.Address(RVA = "0x16BCEDC", Offset = "0x16BCEDC", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "PerformUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Sort(Comparison<T> sortLayoutFunction)
		{
			throw null;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00002E5D File Offset: 0x0000105D
		[global::Cpp2ILInjected.Token(Token = "0x6000552")]
		[global::Cpp2ILInjected.Address(RVA = "0x16BCF98", Offset = "0x16BCF98", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CanvasUpdateRegistry), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClipperRegistry), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRegistry), Member = "RegisterGraphicForCanvas", MemberParameters = new object[]
		{
			typeof(Canvas),
			typeof(Graphic)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRegistry), Member = "RegisterRaycastGraphicForCanvas", MemberParameters = new object[]
		{
			typeof(Canvas),
			typeof(Graphic)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public IndexedSet()
		{
			throw null;
		}

		// Token: 0x04000196 RID: 406
		[global::Cpp2ILInjected.Token(Token = "0x400026F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly List<T> m_List;

		// Token: 0x04000197 RID: 407
		[global::Cpp2ILInjected.Token(Token = "0x4000270")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Dictionary<T, int> m_Dictionary;

		// Token: 0x04000198 RID: 408
		[global::Cpp2ILInjected.Token(Token = "0x4000271")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int m_EnabledObjectCount;
	}
}
