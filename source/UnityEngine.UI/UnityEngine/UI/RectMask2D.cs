using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.EventSystems;
using UnityEngine.Pool;

namespace UnityEngine.UI
{
	// Token: 0x02000031 RID: 49
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[AddComponentMenu("UI/Rect Mask 2D", 14)]
	[RequireComponent(typeof(RectTransform))]
	[global::Cpp2ILInjected.Token(Token = "0x200005D")]
	public class RectMask2D : UIBehaviour, IClipper, ICanvasRaycastFilter
	{
		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600031D RID: 797 RVA: 0x00002950 File Offset: 0x00000B50
		// (set) Token: 0x0600031E RID: 798 RVA: 0x00002953 File Offset: 0x00000B53
		[global::Cpp2ILInjected.Token(Token = "0x170000E6")]
		public Vector4 padding
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000377")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD19A0", Offset = "0x1FD19A0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000378")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD19AC", Offset = "0x1FD19AC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskUtilities), Member = "Notify2DMaskStateChanged", MemberParameters = new object[] { typeof(Component) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600031F RID: 799 RVA: 0x00002956 File Offset: 0x00000B56
		// (set) Token: 0x06000320 RID: 800 RVA: 0x00002959 File Offset: 0x00000B59
		[global::Cpp2ILInjected.Token(Token = "0x170000E7")]
		public Vector2Int softness
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000379")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD19BC", Offset = "0x1FD19BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600037A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD19C4", Offset = "0x1FD19C4", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskUtilities), Member = "Notify2DMaskStateChanged", MemberParameters = new object[] { typeof(Component) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000321 RID: 801 RVA: 0x0000295C File Offset: 0x00000B5C
		[global::Cpp2ILInjected.Token(Token = "0x170000E8")]
		internal Canvas Canvas
		{
			[global::Cpp2ILInjected.Token(Token = "0x600037B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD19E0", Offset = "0x1FD19E0", Length = "0x15C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectMask2D), Member = "get_canvasRect", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectMask2D), Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectMask2D), Member = "PerformClipping", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectMask2D), Member = "UpdateClipSoftness", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Get", ReturnType = "TCollection")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponentsInParent", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
			{
				typeof(bool),
				"System.Collections.Generic.List`1<T>"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Release", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000322 RID: 802 RVA: 0x0000295F File Offset: 0x00000B5F
		[global::Cpp2ILInjected.Token(Token = "0x170000E9")]
		public Rect canvasRect
		{
			[global::Cpp2ILInjected.Token(Token = "0x600037C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD1B3C", Offset = "0x1FD1B3C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Clipping), Member = "FindCullAndClipWorldRect", MemberParameters = new object[]
			{
				typeof(List<RectMask2D>),
				typeof(ref bool)
			}, ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectMask2D), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectMask2D), Member = "get_Canvas", ReturnType = typeof(Canvas))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectangularVertexClipper), Member = "GetCanvasRect", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(Canvas)
			}, ReturnType = typeof(Rect))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000323 RID: 803 RVA: 0x00002962 File Offset: 0x00000B62
		[global::Cpp2ILInjected.Token(Token = "0x170000EA")]
		public RectTransform rectTransform
		{
			[global::Cpp2ILInjected.Token(Token = "0x600037D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD1B78", Offset = "0x1FD1B78", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectMask2D), Member = "get_canvasRect", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectMask2D), Member = "IsRaycastLocationValid", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Camera)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectMask2D), Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00002965 File Offset: 0x00000B65
		[global::Cpp2ILInjected.Token(Token = "0x600037E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD1BD0", Offset = "0x1FD1BD0", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectangularVertexClipper), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		protected RectMask2D()
		{
			throw null;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00002968 File Offset: 0x00000B68
		[global::Cpp2ILInjected.Token(Token = "0x600037F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD1D34", Offset = "0x1FD1D34", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClipperRegistry), Member = "Register", MemberParameters = new object[] { typeof(IClipper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskUtilities), Member = "Notify2DMaskStateChanged", MemberParameters = new object[] { typeof(Component) }, ReturnType = typeof(void))]
		protected override void OnEnable()
		{
			throw null;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0000296B File Offset: 0x00000B6B
		[global::Cpp2ILInjected.Token(Token = "0x6000380")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD1D68", Offset = "0x1FD1D68", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClipperRegistry), Member = "Disable", MemberParameters = new object[] { typeof(IClipper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskUtilities), Member = "Notify2DMaskStateChanged", MemberParameters = new object[] { typeof(Component) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected override void OnDisable()
		{
			throw null;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000296E File Offset: 0x00000B6E
		[global::Cpp2ILInjected.Token(Token = "0x6000381")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD1E30", Offset = "0x1FD1E30", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClipperRegistry), Member = "Unregister", MemberParameters = new object[] { typeof(IClipper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnDestroy", ReturnType = typeof(void))]
		protected override void OnDestroy()
		{
			throw null;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00002971 File Offset: 0x00000B71
		[global::Cpp2ILInjected.Token(Token = "0x6000382")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD1E50", Offset = "0x1FD1E50", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectMask2D), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransformUtility), Member = "RectangleContainsScreenPoint", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(Vector2),
			typeof(Camera),
			typeof(Vector4)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			throw null;
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000329 RID: 809 RVA: 0x00002974 File Offset: 0x00000B74
		[global::Cpp2ILInjected.Token(Token = "0x170000EB")]
		private Rect rootCanvasRect
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000383")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD1F2C", Offset = "0x1FD1F2C", Length = "0xC8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectMask2D), Member = "PerformClipping", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectMask2D), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "GetWorldCorners", MemberParameters = new object[] { typeof(Vector3[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectMask2D), Member = "get_Canvas", ReturnType = typeof(Canvas))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_rootCanvas", ReturnType = typeof(Canvas))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "InverseTransformPoint", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00002977 File Offset: 0x00000B77
		[global::Cpp2ILInjected.Token(Token = "0x6000384")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD1FF4", Offset = "0x1FD1FF4", Length = "0x6D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectMask2D), Member = "get_Canvas", ReturnType = typeof(Canvas))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskUtilities), Member = "GetRectMasksForClip", MemberParameters = new object[]
		{
			typeof(RectMask2D),
			typeof(List<RectMask2D>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipping), Member = "FindCullAndClipWorldRect", MemberParameters = new object[]
		{
			typeof(List<RectMask2D>),
			typeof(ref bool)
		}, ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_rootCanvas", ReturnType = typeof(Canvas))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectMask2D), Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "Overlaps", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_zero", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(Rect)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "get_hasMoved", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		public virtual void PerformClipping()
		{
			throw null;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000297A File Offset: 0x00000B7A
		[global::Cpp2ILInjected.Token(Token = "0x6000385")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD26C4", Offset = "0x1FD26C4", Length = "0x2D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectMask2D), Member = "get_Canvas", ReturnType = typeof(Canvas))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public virtual void UpdateClipSoftness()
		{
			throw null;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000297D File Offset: 0x00000B7D
		[global::Cpp2ILInjected.Token(Token = "0x6000386")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD2994", Offset = "0x1FD2994", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskableGraphic), Member = "UpdateClipParent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = "Add", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void AddClippable(IClippable clippable)
		{
			throw null;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00002980 File Offset: 0x00000B80
		[global::Cpp2ILInjected.Token(Token = "0x6000387")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD2A9C", Offset = "0x1FD2A9C", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskableGraphic), Member = "UpdateClipParent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void RemoveClippable(IClippable clippable)
		{
			throw null;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00002983 File Offset: 0x00000B83
		[global::Cpp2ILInjected.Token(Token = "0x6000388")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD2C30", Offset = "0x1FD2C30", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
		protected override void OnTransformParentChanged()
		{
			throw null;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00002986 File Offset: 0x00000B86
		[global::Cpp2ILInjected.Token(Token = "0x6000389")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD2C54", Offset = "0x1FD2C54", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
		protected override void OnCanvasHierarchyChanged()
		{
			throw null;
		}

		// Token: 0x0400010E RID: 270
		[global::Cpp2ILInjected.Token(Token = "0x40001AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		[NonSerialized]
		private readonly RectangularVertexClipper m_VertexClipper;

		// Token: 0x0400010F RID: 271
		[global::Cpp2ILInjected.Token(Token = "0x40001B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		[NonSerialized]
		private RectTransform m_RectTransform;

		// Token: 0x04000110 RID: 272
		[global::Cpp2ILInjected.Token(Token = "0x40001B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		[NonSerialized]
		private HashSet<MaskableGraphic> m_MaskableTargets;

		// Token: 0x04000111 RID: 273
		[global::Cpp2ILInjected.Token(Token = "0x40001B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		[NonSerialized]
		private HashSet<IClippable> m_ClipTargets;

		// Token: 0x04000112 RID: 274
		[global::Cpp2ILInjected.Token(Token = "0x40001B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		[NonSerialized]
		private bool m_ShouldRecalculateClipRects;

		// Token: 0x04000113 RID: 275
		[global::Cpp2ILInjected.Token(Token = "0x40001B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		[NonSerialized]
		private List<RectMask2D> m_Clippers;

		// Token: 0x04000114 RID: 276
		[global::Cpp2ILInjected.Token(Token = "0x40001B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		[NonSerialized]
		private Rect m_LastClipRectCanvasSpace;

		// Token: 0x04000115 RID: 277
		[global::Cpp2ILInjected.Token(Token = "0x40001B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		[NonSerialized]
		private bool m_ForceClip;

		// Token: 0x04000116 RID: 278
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40001B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		private Vector4 m_Padding;

		// Token: 0x04000117 RID: 279
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40001B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		private Vector2Int m_Softness;

		// Token: 0x04000118 RID: 280
		[global::Cpp2ILInjected.Token(Token = "0x40001B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		[NonSerialized]
		private Canvas m_Canvas;

		// Token: 0x04000119 RID: 281
		[global::Cpp2ILInjected.Token(Token = "0x40001BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private Vector3[] m_Corners;
	}
}
