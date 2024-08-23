using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000019 RID: 25
	[DisallowMultipleComponent]
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("Layout/Aspect Ratio Fitter", 142)]
	[ExecuteAlways]
	[global::Cpp2ILInjected.Token(Token = "0x2000038")]
	public class AspectRatioFitter : UIBehaviour, ILayoutSelfController, ILayoutController
	{
		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00002623 File Offset: 0x00000823
		// (set) Token: 0x060001FF RID: 511 RVA: 0x00002626 File Offset: 0x00000826
		[global::Cpp2ILInjected.Token(Token = "0x17000098")]
		public AspectRatioFitter.AspectMode aspectMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600023E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC67B8", Offset = "0x1FC67B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600023F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC67C0", Offset = "0x1FC67C0", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { "System.Int32Enum" }, MemberParameters = new object[]
			{
				typeof(ref Int32Enum),
				"System.Int32Enum"
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00002629 File Offset: 0x00000829
		// (set) Token: 0x06000201 RID: 513 RVA: 0x0000262C File Offset: 0x0000082C
		[global::Cpp2ILInjected.Token(Token = "0x17000099")]
		public float aspectRatio
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000240")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC6838", Offset = "0x1FC6838", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000241")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC6840", Offset = "0x1FC6840", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { typeof(float) }, MemberParameters = new object[]
			{
				typeof(ref float),
				typeof(float)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000202 RID: 514 RVA: 0x0000262F File Offset: 0x0000082F
		[global::Cpp2ILInjected.Token(Token = "0x1700009A")]
		private RectTransform rectTransform
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000242")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC68B4", Offset = "0x1FC68B4", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AspectRatioFitter), Member = "OnEnable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AspectRatioFitter), Member = "OnDisable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AspectRatioFitter), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AspectRatioFitter), Member = "GetSizeDeltaToProduceSize", MemberParameters = new object[]
			{
				typeof(float),
				typeof(int)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AspectRatioFitter), Member = "GetParentSize", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
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

		// Token: 0x06000203 RID: 515 RVA: 0x00002632 File Offset: 0x00000832
		[global::Cpp2ILInjected.Token(Token = "0x6000243")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC6948", Offset = "0x1FC6948", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = ".ctor", ReturnType = typeof(void))]
		protected AspectRatioFitter()
		{
			throw null;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002635 File Offset: 0x00000835
		[global::Cpp2ILInjected.Token(Token = "0x6000244")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC6958", Offset = "0x1FC6958", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AspectRatioFitter), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_parent", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void OnEnable()
		{
			throw null;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002638 File Offset: 0x00000838
		[global::Cpp2ILInjected.Token(Token = "0x6000245")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC69E4", Offset = "0x1FC69E4", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AspectRatioFitter), Member = "IsComponentValidOnObject", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		protected override void Start()
		{
			throw null;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000263B File Offset: 0x0000083B
		[global::Cpp2ILInjected.Token(Token = "0x6000246")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC6B24", Offset = "0x1FC6B24", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrivenRectTransformTracker), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AspectRatioFitter), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void OnDisable()
		{
			throw null;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000263E File Offset: 0x0000083E
		[global::Cpp2ILInjected.Token(Token = "0x6000247")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC6F7C", Offset = "0x1FC6F7C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AspectRatioFitter), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_parent", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void OnTransformParentChanged()
		{
			throw null;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002641 File Offset: 0x00000841
		[global::Cpp2ILInjected.Token(Token = "0x6000248")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC7008", Offset = "0x1FC7008", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
		protected virtual void Update()
		{
			throw null;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002644 File Offset: 0x00000844
		[global::Cpp2ILInjected.Token(Token = "0x6000249")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC701C", Offset = "0x1FC701C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void OnRectTransformDimensionsChange()
		{
			throw null;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00002647 File Offset: 0x00000847
		[global::Cpp2ILInjected.Token(Token = "0x600024A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC7020", Offset = "0x1FC7020", Length = "0x2E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AspectRatioFitter), Member = "set_aspectMode", MemberParameters = new object[] { typeof(AspectRatioFitter.AspectMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AspectRatioFitter), Member = "set_aspectRatio", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AspectRatioFitter), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AspectRatioFitter), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AspectRatioFitter), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AspectRatioFitter), Member = "SetDirty", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AspectRatioFitter), Member = "IsComponentValidOnObject", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrivenRectTransformTracker), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AspectRatioFitter), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrivenRectTransformTracker), Member = "Add", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(RectTransform),
			typeof(DrivenTransformProperties)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AspectRatioFitter), Member = "GetParentSize", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AspectRatioFitter), Member = "GetSizeDeltaToProduceSize", MemberParameters = new object[]
		{
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "SetSizeWithCurrentAnchors", MemberParameters = new object[]
		{
			typeof(RectTransform.Axis),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void UpdateRect()
		{
			throw null;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000264A File Offset: 0x0000084A
		[global::Cpp2ILInjected.Token(Token = "0x600024B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC7404", Offset = "0x1FC7404", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AspectRatioFitter), Member = "GetParentSize", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AspectRatioFitter), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_anchorMax", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_anchorMin", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private float GetSizeDeltaToProduceSize(float size, int axis)
		{
			throw null;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000264D File Offset: 0x0000084D
		[global::Cpp2ILInjected.Token(Token = "0x600024C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC7300", Offset = "0x1FC7300", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AspectRatioFitter), Member = "GetSizeDeltaToProduceSize", MemberParameters = new object[]
		{
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AspectRatioFitter), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_parent", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_size", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private Vector2 GetParentSize()
		{
			throw null;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002650 File Offset: 0x00000850
		[global::Cpp2ILInjected.Token(Token = "0x600024D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC74F4", Offset = "0x1FC74F4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void SetLayoutHorizontal()
		{
			throw null;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002653 File Offset: 0x00000853
		[global::Cpp2ILInjected.Token(Token = "0x600024E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC74F8", Offset = "0x1FC74F8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void SetLayoutVertical()
		{
			throw null;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002656 File Offset: 0x00000856
		[global::Cpp2ILInjected.Token(Token = "0x600024F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC6834", Offset = "0x1FC6834", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
		protected void SetDirty()
		{
			throw null;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002659 File Offset: 0x00000859
		[global::Cpp2ILInjected.Token(Token = "0x6000250")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC6A34", Offset = "0x1FC6A34", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AspectRatioFitter), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AspectRatioFitter), Member = "UpdateRect", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_isRootCanvas", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool IsComponentValidOnObject()
		{
			throw null;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000265C File Offset: 0x0000085C
		[global::Cpp2ILInjected.Token(Token = "0x6000251")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC6AFC", Offset = "0x1FC6AFC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool IsAspectModeValid()
		{
			throw null;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000265F File Offset: 0x0000085F
		[global::Cpp2ILInjected.Token(Token = "0x6000252")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC74FC", Offset = "0x1FC74FC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool DoesParentExists()
		{
			throw null;
		}

		// Token: 0x040000BD RID: 189
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000122")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private AspectRatioFitter.AspectMode m_AspectMode;

		// Token: 0x040000BE RID: 190
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000123")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private float m_AspectRatio;

		// Token: 0x040000BF RID: 191
		[global::Cpp2ILInjected.Token(Token = "0x4000124")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		[NonSerialized]
		private RectTransform m_Rect;

		// Token: 0x040000C0 RID: 192
		[global::Cpp2ILInjected.Token(Token = "0x4000125")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool m_DelayedSetDirty;

		// Token: 0x040000C1 RID: 193
		[global::Cpp2ILInjected.Token(Token = "0x4000126")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		private bool m_DoesParentExist;

		// Token: 0x040000C2 RID: 194
		[global::Cpp2ILInjected.Token(Token = "0x4000127")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A")]
		private DrivenRectTransformTracker m_Tracker;

		// Token: 0x0200009E RID: 158
		[global::Cpp2ILInjected.Token(Token = "0x2000039")]
		public enum AspectMode
		{
			// Token: 0x040002AF RID: 687
			[global::Cpp2ILInjected.Token(Token = "0x4000129")]
			None,
			// Token: 0x040002B0 RID: 688
			[global::Cpp2ILInjected.Token(Token = "0x400012A")]
			WidthControlsHeight,
			// Token: 0x040002B1 RID: 689
			[global::Cpp2ILInjected.Token(Token = "0x400012B")]
			HeightControlsWidth,
			// Token: 0x040002B2 RID: 690
			[global::Cpp2ILInjected.Token(Token = "0x400012C")]
			FitInParent,
			// Token: 0x040002B3 RID: 691
			[global::Cpp2ILInjected.Token(Token = "0x400012D")]
			EnvelopeParent
		}
	}
}
