using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000024 RID: 36
	[AddComponentMenu("Layout/Layout Element", 140)]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	[global::Cpp2ILInjected.Token(Token = "0x200004B")]
	public class LayoutElement : UIBehaviour, ILayoutElement, ILayoutIgnorer
	{
		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000276 RID: 630 RVA: 0x00002767 File Offset: 0x00000967
		// (set) Token: 0x06000277 RID: 631 RVA: 0x0000276A File Offset: 0x0000096A
		[global::Cpp2ILInjected.Token(Token = "0x170000BE")]
		public virtual bool ignoreLayout
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCA870", Offset = "0x1FCA870", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60002B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCA878", Offset = "0x1FCA878", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "T" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000276D File Offset: 0x0000096D
		[global::Cpp2ILInjected.Token(Token = "0x60002B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCA9A4", Offset = "0x1FCA9A4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void CalculateLayoutInputHorizontal()
		{
			throw null;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002770 File Offset: 0x00000970
		[global::Cpp2ILInjected.Token(Token = "0x60002B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCA9A8", Offset = "0x1FCA9A8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void CalculateLayoutInputVertical()
		{
			throw null;
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600027A RID: 634 RVA: 0x00002773 File Offset: 0x00000973
		// (set) Token: 0x0600027B RID: 635 RVA: 0x00002776 File Offset: 0x00000976
		[global::Cpp2ILInjected.Token(Token = "0x170000BF")]
		public virtual float minWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCA9AC", Offset = "0x1FCA9AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60002BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCA9B4", Offset = "0x1FCA9B4", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { typeof(float) }, MemberParameters = new object[]
			{
				typeof(ref float),
				typeof(float)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600027C RID: 636 RVA: 0x00002779 File Offset: 0x00000979
		// (set) Token: 0x0600027D RID: 637 RVA: 0x0000277C File Offset: 0x0000097C
		[global::Cpp2ILInjected.Token(Token = "0x170000C0")]
		public virtual float minHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCAA28", Offset = "0x1FCAA28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60002BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCAA30", Offset = "0x1FCAA30", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { typeof(float) }, MemberParameters = new object[]
			{
				typeof(ref float),
				typeof(float)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0000277F File Offset: 0x0000097F
		// (set) Token: 0x0600027F RID: 639 RVA: 0x00002782 File Offset: 0x00000982
		[global::Cpp2ILInjected.Token(Token = "0x170000C1")]
		public virtual float preferredWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCAAA4", Offset = "0x1FCAAA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60002BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCAAAC", Offset = "0x1FCAAAC", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { typeof(float) }, MemberParameters = new object[]
			{
				typeof(ref float),
				typeof(float)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000280 RID: 640 RVA: 0x00002785 File Offset: 0x00000985
		// (set) Token: 0x06000281 RID: 641 RVA: 0x00002788 File Offset: 0x00000988
		[global::Cpp2ILInjected.Token(Token = "0x170000C2")]
		public virtual float preferredHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCAB20", Offset = "0x1FCAB20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60002C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCAB28", Offset = "0x1FCAB28", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { typeof(float) }, MemberParameters = new object[]
			{
				typeof(ref float),
				typeof(float)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0000278B File Offset: 0x0000098B
		// (set) Token: 0x06000283 RID: 643 RVA: 0x0000278E File Offset: 0x0000098E
		[global::Cpp2ILInjected.Token(Token = "0x170000C3")]
		public virtual float flexibleWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002C2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCAB9C", Offset = "0x1FCAB9C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60002C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCABA4", Offset = "0x1FCABA4", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { typeof(float) }, MemberParameters = new object[]
			{
				typeof(ref float),
				typeof(float)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000284 RID: 644 RVA: 0x00002791 File Offset: 0x00000991
		// (set) Token: 0x06000285 RID: 645 RVA: 0x00002794 File Offset: 0x00000994
		[global::Cpp2ILInjected.Token(Token = "0x170000C4")]
		public virtual float flexibleHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCAC18", Offset = "0x1FCAC18", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60002C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCAC20", Offset = "0x1FCAC20", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { typeof(float) }, MemberParameters = new object[]
			{
				typeof(ref float),
				typeof(float)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000286 RID: 646 RVA: 0x00002797 File Offset: 0x00000997
		// (set) Token: 0x06000287 RID: 647 RVA: 0x0000279A File Offset: 0x0000099A
		[global::Cpp2ILInjected.Token(Token = "0x170000C5")]
		public virtual int layoutPriority
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002C6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCAC94", Offset = "0x1FCAC94", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60002C7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCAC9C", Offset = "0x1FCAC9C", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000279D File Offset: 0x0000099D
		[global::Cpp2ILInjected.Token(Token = "0x60002C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCAD10", Offset = "0x1FCAD10", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = ".ctor", ReturnType = typeof(void))]
		protected LayoutElement()
		{
			throw null;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x000027A0 File Offset: 0x000009A0
		[global::Cpp2ILInjected.Token(Token = "0x60002C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCAD34", Offset = "0x1FCAD34", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
		protected override void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x000027A3 File Offset: 0x000009A3
		[global::Cpp2ILInjected.Token(Token = "0x60002CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCAD50", Offset = "0x1FCAD50", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
		protected override void OnTransformParentChanged()
		{
			throw null;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x000027A6 File Offset: 0x000009A6
		[global::Cpp2ILInjected.Token(Token = "0x60002CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCAD54", Offset = "0x1FCAD54", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnDisable", ReturnType = typeof(void))]
		protected override void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x000027A9 File Offset: 0x000009A9
		[global::Cpp2ILInjected.Token(Token = "0x60002CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCAD70", Offset = "0x1FCAD70", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
		protected override void OnDidApplyAnimationProperties()
		{
			throw null;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x000027AC File Offset: 0x000009AC
		[global::Cpp2ILInjected.Token(Token = "0x60002CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCAD74", Offset = "0x1FCAD74", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
		protected override void OnBeforeTransformParentChanged()
		{
			throw null;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x000027AF File Offset: 0x000009AF
		[global::Cpp2ILInjected.Token(Token = "0x60002CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCA8EC", Offset = "0x1FCA8EC", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutElement), Member = "set_minWidth", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutElement), Member = "set_minHeight", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutElement), Member = "set_preferredWidth", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutElement), Member = "set_preferredHeight", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutElement), Member = "set_flexibleWidth", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutElement), Member = "set_flexibleHeight", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutElement), Member = "set_layoutPriority", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutElement), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutElement), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutElement), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutElement), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutElement), Member = "OnBeforeTransformParentChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected void SetDirty()
		{
			throw null;
		}

		// Token: 0x040000E4 RID: 228
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400016D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool m_IgnoreLayout;

		// Token: 0x040000E5 RID: 229
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400016E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private float m_MinWidth;

		// Token: 0x040000E6 RID: 230
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400016F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private float m_MinHeight;

		// Token: 0x040000E7 RID: 231
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000170")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private float m_PreferredWidth;

		// Token: 0x040000E8 RID: 232
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000171")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private float m_PreferredHeight;

		// Token: 0x040000E9 RID: 233
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000172")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private float m_FlexibleWidth;

		// Token: 0x040000EA RID: 234
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000173")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private float m_FlexibleHeight;

		// Token: 0x040000EB RID: 235
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000174")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private int m_LayoutPriority;
	}
}
