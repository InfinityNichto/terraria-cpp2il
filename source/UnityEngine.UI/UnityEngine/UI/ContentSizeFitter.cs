using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200001B RID: 27
	[RequireComponent(typeof(RectTransform))]
	[ExecuteAlways]
	[AddComponentMenu("Layout/Content Size Fitter", 141)]
	[global::Cpp2ILInjected.Token(Token = "0x200003E")]
	public class ContentSizeFitter : UIBehaviour, ILayoutSelfController, ILayoutController
	{
		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000232 RID: 562 RVA: 0x000026BF File Offset: 0x000008BF
		// (set) Token: 0x06000233 RID: 563 RVA: 0x000026C2 File Offset: 0x000008C2
		[global::Cpp2ILInjected.Token(Token = "0x170000A5")]
		public ContentSizeFitter.FitMode horizontalFit
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000272")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC7D10", Offset = "0x1FC7D10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000273")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC7D18", Offset = "0x1FC7D18", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { "System.Int32Enum" }, MemberParameters = new object[]
			{
				typeof(ref Int32Enum),
				"System.Int32Enum"
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000234 RID: 564 RVA: 0x000026C5 File Offset: 0x000008C5
		// (set) Token: 0x06000235 RID: 565 RVA: 0x000026C8 File Offset: 0x000008C8
		[global::Cpp2ILInjected.Token(Token = "0x170000A6")]
		public ContentSizeFitter.FitMode verticalFit
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000274")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC7E10", Offset = "0x1FC7E10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000275")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC7E18", Offset = "0x1FC7E18", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { "System.Int32Enum" }, MemberParameters = new object[]
			{
				typeof(ref Int32Enum),
				"System.Int32Enum"
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentSizeFitter), Member = "SetDirty", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000236 RID: 566 RVA: 0x000026CB File Offset: 0x000008CB
		[global::Cpp2ILInjected.Token(Token = "0x170000A7")]
		private RectTransform rectTransform
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000276")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC7E8C", Offset = "0x1FC7E8C", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSizeFitter), Member = "OnDisable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSizeFitter), Member = "HandleSelfFittingAlongAxis", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSizeFitter), Member = "SetDirty", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
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

		// Token: 0x06000237 RID: 567 RVA: 0x000026CE File Offset: 0x000008CE
		[global::Cpp2ILInjected.Token(Token = "0x6000277")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC7F20", Offset = "0x1FC7F20", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = ".ctor", ReturnType = typeof(void))]
		protected ContentSizeFitter()
		{
			throw null;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000026D1 File Offset: 0x000008D1
		[global::Cpp2ILInjected.Token(Token = "0x6000278")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC7F28", Offset = "0x1FC7F28", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentSizeFitter), Member = "SetDirty", ReturnType = typeof(void))]
		protected override void OnEnable()
		{
			throw null;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000026D4 File Offset: 0x000008D4
		[global::Cpp2ILInjected.Token(Token = "0x6000279")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC7F44", Offset = "0x1FC7F44", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrivenRectTransformTracker), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentSizeFitter), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000026D7 File Offset: 0x000008D7
		[global::Cpp2ILInjected.Token(Token = "0x600027A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC7FC0", Offset = "0x1FC7FC0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentSizeFitter), Member = "SetDirty", ReturnType = typeof(void))]
		protected override void OnRectTransformDimensionsChange()
		{
			throw null;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x000026DA File Offset: 0x000008DA
		[global::Cpp2ILInjected.Token(Token = "0x600027B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC7FC4", Offset = "0x1FC7FC4", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSizeFitter), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSizeFitter), Member = "SetLayoutVertical", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentSizeFitter), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrivenRectTransformTracker), Member = "Add", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(RectTransform),
			typeof(DrivenTransformProperties)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutUtility), Member = "GetMinHeight", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutUtility), Member = "GetPreferredHeight", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutUtility), Member = "GetMinWidth", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutUtility), Member = "GetPreferredWidth", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "SetSizeWithCurrentAnchors", MemberParameters = new object[]
		{
			typeof(RectTransform.Axis),
			typeof(float)
		}, ReturnType = typeof(void))]
		private void HandleSelfFittingAlongAxis(int axis)
		{
			throw null;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x000026DD File Offset: 0x000008DD
		[global::Cpp2ILInjected.Token(Token = "0x600027C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC80B0", Offset = "0x1FC80B0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrivenRectTransformTracker), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentSizeFitter), Member = "HandleSelfFittingAlongAxis", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public virtual void SetLayoutHorizontal()
		{
			throw null;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x000026E0 File Offset: 0x000008E0
		[global::Cpp2ILInjected.Token(Token = "0x600027D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC80D4", Offset = "0x1FC80D4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentSizeFitter), Member = "HandleSelfFittingAlongAxis", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public virtual void SetLayoutVertical()
		{
			throw null;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000026E3 File Offset: 0x000008E3
		[global::Cpp2ILInjected.Token(Token = "0x600027E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC7D8C", Offset = "0x1FC7D8C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSizeFitter), Member = "set_verticalFit", MemberParameters = new object[] { typeof(ContentSizeFitter.FitMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSizeFitter), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSizeFitter), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentSizeFitter), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected void SetDirty()
		{
			throw null;
		}

		// Token: 0x040000D2 RID: 210
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400014B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected ContentSizeFitter.FitMode m_HorizontalFit;

		// Token: 0x040000D3 RID: 211
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400014C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		protected ContentSizeFitter.FitMode m_VerticalFit;

		// Token: 0x040000D4 RID: 212
		[global::Cpp2ILInjected.Token(Token = "0x400014D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		[NonSerialized]
		private RectTransform m_Rect;

		// Token: 0x040000D5 RID: 213
		[global::Cpp2ILInjected.Token(Token = "0x400014E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private DrivenRectTransformTracker m_Tracker;

		// Token: 0x020000A2 RID: 162
		[global::Cpp2ILInjected.Token(Token = "0x200003F")]
		public enum FitMode
		{
			// Token: 0x040002C3 RID: 707
			[global::Cpp2ILInjected.Token(Token = "0x4000150")]
			Unconstrained,
			// Token: 0x040002C4 RID: 708
			[global::Cpp2ILInjected.Token(Token = "0x4000151")]
			MinSize,
			// Token: 0x040002C5 RID: 709
			[global::Cpp2ILInjected.Token(Token = "0x4000152")]
			PreferredSize
		}
	}
}
