using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.EventSystems;
using UnityEngine.Pool;

namespace UnityEngine.UI
{
	// Token: 0x02000025 RID: 37
	[RequireComponent(typeof(RectTransform))]
	[ExecuteAlways]
	[DisallowMultipleComponent]
	[global::Cpp2ILInjected.Token(Token = "0x200004C")]
	public abstract class LayoutGroup : UIBehaviour, ILayoutElement, ILayoutGroup, ILayoutController
	{
		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600028F RID: 655 RVA: 0x000027B2 File Offset: 0x000009B2
		// (set) Token: 0x06000290 RID: 656 RVA: 0x000027B5 File Offset: 0x000009B5
		[global::Cpp2ILInjected.Token(Token = "0x170000C6")]
		public RectOffset padding
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCAD78", Offset = "0x1FCAD78", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60002D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCAD80", Offset = "0x1FCAD80", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutGroup[]), Member = "SetProperty", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
			{
				typeof(ref object),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000291 RID: 657 RVA: 0x000027B8 File Offset: 0x000009B8
		// (set) Token: 0x06000292 RID: 658 RVA: 0x000027BB File Offset: 0x000009BB
		[global::Cpp2ILInjected.Token(Token = "0x170000C7")]
		public TextAnchor childAlignment
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCADDC", Offset = "0x1FCADDC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60002D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCADE4", Offset = "0x1FCADE4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutGroup[]), Member = "SetProperty", MemberTypeParameters = new object[] { "System.Int32Enum" }, MemberParameters = new object[]
			{
				typeof(ref Int32Enum),
				"System.Int32Enum"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000293 RID: 659 RVA: 0x000027BE File Offset: 0x000009BE
		[global::Cpp2ILInjected.Token(Token = "0x170000C8")]
		protected RectTransform rectTransform
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC8CB8", Offset = "0x1FC8CB8", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GridLayoutGroup), Member = "CalculateLayoutInputVertical", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GridLayoutGroup), Member = "SetCellsAlongAxis", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "SetChildrenAlongAxis", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutGroup), Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutGroup), Member = "OnDisable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutGroup), Member = "GetStartOffset", MemberParameters = new object[]
			{
				typeof(int),
				typeof(float)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutGroup), Member = "SetDirty", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000294 RID: 660 RVA: 0x000027C1 File Offset: 0x000009C1
		[global::Cpp2ILInjected.Token(Token = "0x170000C9")]
		protected List<RectTransform> rectChildren
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCAE40", Offset = "0x1FCAE40", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x000027C4 File Offset: 0x000009C4
		[global::Cpp2ILInjected.Token(Token = "0x60002D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC8688", Offset = "0x1FC8688", Length = "0x3A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GridLayoutGroup), Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalLayoutGroup), Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VerticalLayoutGroup), Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Get", ReturnType = "TCollection")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutGroup), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponents", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(List<Component>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Release", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrivenRectTransformTracker), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public virtual void CalculateLayoutInputHorizontal()
		{
			throw null;
		}

		// Token: 0x06000296 RID: 662
		[global::Cpp2ILInjected.Token(Token = "0x60002D6")]
		public abstract void CalculateLayoutInputVertical();

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000297 RID: 663 RVA: 0x000027C7 File Offset: 0x000009C7
		[global::Cpp2ILInjected.Token(Token = "0x170000CA")]
		public virtual float minWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCAE48", Offset = "0x1FCAE48", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000298 RID: 664 RVA: 0x000027CA File Offset: 0x000009CA
		[global::Cpp2ILInjected.Token(Token = "0x170000CB")]
		public virtual float preferredWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCAE50", Offset = "0x1FCAE50", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000299 RID: 665 RVA: 0x000027CD File Offset: 0x000009CD
		[global::Cpp2ILInjected.Token(Token = "0x170000CC")]
		public virtual float flexibleWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCAE58", Offset = "0x1FCAE58", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600029A RID: 666 RVA: 0x000027D0 File Offset: 0x000009D0
		[global::Cpp2ILInjected.Token(Token = "0x170000CD")]
		public virtual float minHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCAE60", Offset = "0x1FCAE60", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600029B RID: 667 RVA: 0x000027D3 File Offset: 0x000009D3
		[global::Cpp2ILInjected.Token(Token = "0x170000CE")]
		public virtual float preferredHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCAE68", Offset = "0x1FCAE68", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600029C RID: 668 RVA: 0x000027D6 File Offset: 0x000009D6
		[global::Cpp2ILInjected.Token(Token = "0x170000CF")]
		public virtual float flexibleHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCAE70", Offset = "0x1FCAE70", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600029D RID: 669 RVA: 0x000027D9 File Offset: 0x000009D9
		[global::Cpp2ILInjected.Token(Token = "0x170000D0")]
		public virtual int layoutPriority
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCAE78", Offset = "0x1FCAE78", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600029E RID: 670
		[global::Cpp2ILInjected.Token(Token = "0x60002DE")]
		public abstract void SetLayoutHorizontal();

		// Token: 0x0600029F RID: 671
		[global::Cpp2ILInjected.Token(Token = "0x60002DF")]
		public abstract void SetLayoutVertical();

		// Token: 0x060002A0 RID: 672 RVA: 0x000027DC File Offset: 0x000009DC
		[global::Cpp2ILInjected.Token(Token = "0x60002E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC83B0", Offset = "0x1FC83B0", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalLayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VerticalLayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectOffset), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		protected LayoutGroup()
		{
			throw null;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x000027DF File Offset: 0x000009DF
		[global::Cpp2ILInjected.Token(Token = "0x60002E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCAE80", Offset = "0x1FCAE80", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnEnable", ReturnType = typeof(void))]
		protected override void OnEnable()
		{
			throw null;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x000027E2 File Offset: 0x000009E2
		[global::Cpp2ILInjected.Token(Token = "0x60002E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCAF70", Offset = "0x1FCAF70", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrivenRectTransformTracker), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutGroup), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void OnDisable()
		{
			throw null;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x000027E5 File Offset: 0x000009E5
		[global::Cpp2ILInjected.Token(Token = "0x60002E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCAFEC", Offset = "0x1FCAFEC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutGroup), Member = "SetDirty", ReturnType = typeof(void))]
		protected override void OnDidApplyAnimationProperties()
		{
			throw null;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x000027E8 File Offset: 0x000009E8
		[global::Cpp2ILInjected.Token(Token = "0x60002E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCA7F4", Offset = "0x1FCA7F4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "SetChildrenAlongAxis", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected float GetTotalMinSize(int axis)
		{
			throw null;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x000027EB File Offset: 0x000009EB
		[global::Cpp2ILInjected.Token(Token = "0x60002E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCA714", Offset = "0x1FCA714", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "SetChildrenAlongAxis", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected float GetTotalPreferredSize(int axis)
		{
			throw null;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x000027EE File Offset: 0x000009EE
		[global::Cpp2ILInjected.Token(Token = "0x60002E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCA784", Offset = "0x1FCA784", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "SetChildrenAlongAxis", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected float GetTotalFlexibleSize(int axis)
		{
			throw null;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x000027F1 File Offset: 0x000009F1
		[global::Cpp2ILInjected.Token(Token = "0x60002E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC9310", Offset = "0x1FC9310", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GridLayoutGroup), Member = "SetCellsAlongAxis", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "SetChildrenAlongAxis", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectOffset), Member = "get_vertical", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectOffset), Member = "get_horizontal", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutGroup), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_size", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding)
		{
			throw null;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x000027F4 File Offset: 0x000009F4
		[global::Cpp2ILInjected.Token(Token = "0x60002E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCA220", Offset = "0x1FCA220", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected float GetAlignmentOnAxis(int axis)
		{
			throw null;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x000027F7 File Offset: 0x000009F7
		[global::Cpp2ILInjected.Token(Token = "0x60002E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC8A28", Offset = "0x1FC8A28", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "CalcAlongAxis", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis)
		{
			throw null;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x000027FA File Offset: 0x000009FA
		[global::Cpp2ILInjected.Token(Token = "0x60002EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCAFF0", Offset = "0x1FCAFF0", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutGroup), Member = "SetChildAlongAxisWithScale", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected void SetChildAlongAxis(RectTransform rect, int axis, float pos)
		{
			throw null;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x000027FD File Offset: 0x000009FD
		[global::Cpp2ILInjected.Token(Token = "0x60002EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCA4E0", Offset = "0x1FCA4E0", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "SetChildrenAlongAxis", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutGroup), Member = "SetChildAlongAxis", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrivenRectTransformTracker), Member = "Add", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(RectTransform),
			typeof(DrivenTransformProperties)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor)
		{
			throw null;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00002800 File Offset: 0x00000A00
		[global::Cpp2ILInjected.Token(Token = "0x60002EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC9460", Offset = "0x1FC9460", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GridLayoutGroup), Member = "SetCellsAlongAxis", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutGroup), Member = "SetChildAlongAxisWithScale", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size)
		{
			throw null;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00002803 File Offset: 0x00000A03
		[global::Cpp2ILInjected.Token(Token = "0x60002ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCA26C", Offset = "0x1FCA26C", Length = "0x274")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "SetChildrenAlongAxis", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutGroup), Member = "SetChildAlongAxis", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrivenRectTransformTracker), Member = "Add", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(RectTransform),
			typeof(DrivenTransformProperties)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor)
		{
			throw null;
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002AE RID: 686 RVA: 0x00002806 File Offset: 0x00000A06
		[global::Cpp2ILInjected.Token(Token = "0x170000D1")]
		private bool isRootLayoutGroup
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCB098", Offset = "0x1FCB098", Length = "0x134")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutGroup), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_parent", ReturnType = typeof(Transform))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponent", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Component))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00002809 File Offset: 0x00000A09
		[global::Cpp2ILInjected.Token(Token = "0x60002EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCB1CC", Offset = "0x1FCB1CC", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutGroup), Member = "get_isRootLayoutGroup", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutGroup), Member = "SetDirty", ReturnType = typeof(void))]
		protected override void OnRectTransformDimensionsChange()
		{
			throw null;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000280C File Offset: 0x00000A0C
		[global::Cpp2ILInjected.Token(Token = "0x60002F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCB1FC", Offset = "0x1FCB1FC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutGroup), Member = "SetDirty", ReturnType = typeof(void))]
		protected virtual void OnTransformChildrenChanged()
		{
			throw null;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000280F File Offset: 0x00000A0F
		[global::Cpp2ILInjected.Token(Token = "0x60002F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x158FB34", Offset = "0x158FB34", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childForceExpandWidth", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childForceExpandHeight", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childControlWidth", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childControlHeight", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childScaleWidth", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childScaleHeight", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_reverseArrangement", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutGroup), Member = "SetDirty", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected void SetProperty<T>(ref T currentValue, T newValue)
		{
			throw null;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002812 File Offset: 0x00000A12
		[global::Cpp2ILInjected.Token(Token = "0x60002F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCAE9C", Offset = "0x1FCAE9C", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutGroup), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutGroup), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutGroup), Member = "OnTransformChildrenChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasUpdateRegistry), Member = "IsRebuildingLayout", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutGroup), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutGroup), Member = "DelayedSetDirty", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine", MemberParameters = new object[] { typeof(IEnumerator) }, ReturnType = typeof(Coroutine))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected void SetDirty()
		{
			throw null;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00002815 File Offset: 0x00000A15
		[global::Cpp2ILInjected.Token(Token = "0x60002F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCB200", Offset = "0x1FCB200", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutGroup), Member = "SetDirty", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator DelayedSetDirty(RectTransform rectTransform)
		{
			throw null;
		}

		// Token: 0x040000EC RID: 236
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000175")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected RectOffset m_Padding;

		// Token: 0x040000ED RID: 237
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000176")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		protected TextAnchor m_ChildAlignment;

		// Token: 0x040000EE RID: 238
		[global::Cpp2ILInjected.Token(Token = "0x4000177")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		[NonSerialized]
		private RectTransform m_Rect;

		// Token: 0x040000EF RID: 239
		[global::Cpp2ILInjected.Token(Token = "0x4000178")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		protected DrivenRectTransformTracker m_Tracker;

		// Token: 0x040000F0 RID: 240
		[global::Cpp2ILInjected.Token(Token = "0x4000179")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private Vector2 m_TotalMinSize;

		// Token: 0x040000F1 RID: 241
		[global::Cpp2ILInjected.Token(Token = "0x400017A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private Vector2 m_TotalPreferredSize;

		// Token: 0x040000F2 RID: 242
		[global::Cpp2ILInjected.Token(Token = "0x400017B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private Vector2 m_TotalFlexibleSize;

		// Token: 0x040000F3 RID: 243
		[global::Cpp2ILInjected.Token(Token = "0x400017C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		[NonSerialized]
		private List<RectTransform> m_RectChildren;

		// Token: 0x020000A6 RID: 166
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200004D")]
		private sealed class <DelayedSetDirty>d__56 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060006A4 RID: 1700 RVA: 0x0000337C File Offset: 0x0000157C
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60002F4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCB260", Offset = "0x1FCB260", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <DelayedSetDirty>d__56(int <>1__state)
			{
				throw null;
			}

			// Token: 0x060006A5 RID: 1701 RVA: 0x0000337F File Offset: 0x0000157F
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60002F5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCB288", Offset = "0x1FCB288", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x060006A6 RID: 1702 RVA: 0x00003382 File Offset: 0x00001582
			[global::Cpp2ILInjected.Token(Token = "0x60002F6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCB28C", Offset = "0x1FCB28C", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x170001C9 RID: 457
			// (get) Token: 0x060006A7 RID: 1703 RVA: 0x00003385 File Offset: 0x00001585
			[global::Cpp2ILInjected.Token(Token = "0x170000D2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60002F7")]
				[global::Cpp2ILInjected.Address(RVA = "0x1FCB314", Offset = "0x1FCB314", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060006A8 RID: 1704 RVA: 0x00003388 File Offset: 0x00001588
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60002F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCB31C", Offset = "0x1FCB31C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x170001CA RID: 458
			// (get) Token: 0x060006A9 RID: 1705 RVA: 0x0000338B File Offset: 0x0000158B
			[global::Cpp2ILInjected.Token(Token = "0x170000D3")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60002F9")]
				[global::Cpp2ILInjected.Address(RVA = "0x1FCB354", Offset = "0x1FCB354", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x040002D2 RID: 722
			[global::Cpp2ILInjected.Token(Token = "0x400017D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040002D3 RID: 723
			[global::Cpp2ILInjected.Token(Token = "0x400017E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040002D4 RID: 724
			[global::Cpp2ILInjected.Token(Token = "0x400017F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public RectTransform rectTransform;
		}
	}
}
