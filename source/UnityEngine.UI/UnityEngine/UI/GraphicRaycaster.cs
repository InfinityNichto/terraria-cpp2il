using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x02000012 RID: 18
	[RequireComponent(typeof(Canvas))]
	[AddComponentMenu("Event/Graphic Raycaster")]
	[global::Cpp2ILInjected.Token(Token = "0x200001D")]
	public class GraphicRaycaster : BaseRaycaster
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00002311 File Offset: 0x00000511
		[global::Cpp2ILInjected.Token(Token = "0x17000043")]
		public override int sortOrderPriority
		{
			[global::Cpp2ILInjected.Token(Token = "0x600011E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB3764", Offset = "0x1FB3764", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicRaycaster), Member = "get_canvas", ReturnType = typeof(Canvas))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseRaycaster), Member = "get_sortOrderPriority", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_sortingOrder", ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00002314 File Offset: 0x00000514
		[global::Cpp2ILInjected.Token(Token = "0x17000044")]
		public override int renderOrderPriority
		{
			[global::Cpp2ILInjected.Token(Token = "0x600011F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB3834", Offset = "0x1FB3834", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicRaycaster), Member = "get_canvas", ReturnType = typeof(Canvas))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseRaycaster), Member = "get_renderOrderPriority", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_rootCanvas", ReturnType = typeof(Canvas))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_renderOrder", ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00002317 File Offset: 0x00000517
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x0000231A File Offset: 0x0000051A
		[global::Cpp2ILInjected.Token(Token = "0x17000045")]
		public bool ignoreReversedGraphics
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000120")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB3878", Offset = "0x1FB3878", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000121")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB3880", Offset = "0x1FB3880", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x0000231D File Offset: 0x0000051D
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00002320 File Offset: 0x00000520
		[global::Cpp2ILInjected.Token(Token = "0x17000046")]
		public GraphicRaycaster.BlockingObjects blockingObjects
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000122")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB388C", Offset = "0x1FB388C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000123")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB3894", Offset = "0x1FB3894", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00002323 File Offset: 0x00000523
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00002326 File Offset: 0x00000526
		[global::Cpp2ILInjected.Token(Token = "0x17000047")]
		public LayerMask blockingMask
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000124")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB389C", Offset = "0x1FB389C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000125")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB38A4", Offset = "0x1FB38A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002329 File Offset: 0x00000529
		[global::Cpp2ILInjected.Token(Token = "0x6000126")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB38AC", Offset = "0x1FB38AC", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayerMask), Member = "op_Implicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(LayerMask))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseRaycaster), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected GraphicRaycaster()
		{
			throw null;
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0000232C File Offset: 0x0000052C
		[global::Cpp2ILInjected.Token(Token = "0x17000048")]
		private Canvas canvas
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000127")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB37A0", Offset = "0x1FB37A0", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRaycaster), Member = "get_sortOrderPriority", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRaycaster), Member = "get_renderOrderPriority", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRaycaster), Member = "Raycast", MemberParameters = new object[]
			{
				typeof(PointerEventData),
				typeof(List<RaycastResult>)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRaycaster), Member = "get_eventCamera", ReturnType = typeof(Camera))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
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

		// Token: 0x060000FE RID: 254 RVA: 0x0000232F File Offset: 0x0000052F
		[global::Cpp2ILInjected.Token(Token = "0x6000128")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB3940", Offset = "0x1FB3940", Length = "0xBB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicRaycaster), Member = "get_canvas", ReturnType = typeof(Canvas))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicRegistry), Member = "GetRaycastableGraphicsForCanvas", MemberParameters = new object[] { typeof(Canvas) }, ReturnType = typeof(IList<Graphic>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_targetDisplay", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_targetDisplay", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MultipleDisplayUtilities), Member = "RelativeMouseAtScaled", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Display), Member = "get_systemWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Display), Member = "get_systemHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "ScreenToViewportPoint", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "ScreenPointToRay", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Ray))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ray), Member = "get_direction", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicRaycaster), Member = "Raycast", MemberParameters = new object[]
		{
			typeof(Canvas),
			typeof(Camera),
			typeof(Vector2),
			typeof(IList<Graphic>),
			typeof(List<Graphic>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Quaternion),
			typeof(Vector3)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_nearClipPlane", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ray), Member = "get_origin", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "get_absoluteDepth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_sortingLayerID", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_sortingOrder", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_farClipPlane", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionMethodsCache), Member = "get_Singleton", ReturnType = typeof(ReflectionMethodsCache))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayerMask), Member = "op_Implicit", MemberParameters = new object[] { typeof(LayerMask) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RaycastHit), Member = "get_distance", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RaycastHit2D), Member = "get_distance", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
			throw null;
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00002332 File Offset: 0x00000532
		[global::Cpp2ILInjected.Token(Token = "0x17000049")]
		public override Camera eventCamera
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000129")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB4AE8", Offset = "0x1FB4AE8", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicRaycaster), Member = "get_canvas", ReturnType = typeof(Canvas))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_worldCamera", ReturnType = typeof(Camera))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_main", ReturnType = typeof(Camera))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002335 File Offset: 0x00000535
		[global::Cpp2ILInjected.Token(Token = "0x600012A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB45A8", Offset = "0x1FB45A8", Length = "0x540")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRaycaster), Member = "Raycast", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(List<RaycastResult>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "get_cull", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "get_absoluteDepth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransformUtility), Member = "RectangleContainsScreenPoint", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(Vector2),
			typeof(Camera),
			typeof(Vector4)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "WorldToScreenPoint", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_farClipPlane", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results)
		{
			throw null;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002338 File Offset: 0x00000538
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600012B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB4BA8", Offset = "0x1FB4BA8", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static GraphicRaycaster()
		{
			throw null;
		}

		// Token: 0x04000065 RID: 101
		[global::Cpp2ILInjected.Token(Token = "0x400007F")]
		protected const int kNoEventMaskSet = -1;

		// Token: 0x04000066 RID: 102
		[SerializeField]
		[FormerlySerializedAs("ignoreReversedGraphics")]
		[global::Cpp2ILInjected.Token(Token = "0x4000080")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool m_IgnoreReversedGraphics;

		// Token: 0x04000067 RID: 103
		[SerializeField]
		[FormerlySerializedAs("blockingObjects")]
		[global::Cpp2ILInjected.Token(Token = "0x4000081")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private GraphicRaycaster.BlockingObjects m_BlockingObjects;

		// Token: 0x04000068 RID: 104
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000082")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		protected LayerMask m_BlockingMask;

		// Token: 0x04000069 RID: 105
		[global::Cpp2ILInjected.Token(Token = "0x4000083")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Canvas m_Canvas;

		// Token: 0x0400006A RID: 106
		[global::Cpp2ILInjected.Token(Token = "0x4000084")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		[NonSerialized]
		private List<Graphic> m_RaycastResults;

		// Token: 0x0400006B RID: 107
		[global::Cpp2ILInjected.Token(Token = "0x4000085")]
		[NonSerialized]
		private static readonly List<Graphic> s_SortedGraphics;

		// Token: 0x0200008A RID: 138
		[global::Cpp2ILInjected.Token(Token = "0x200001E")]
		public enum BlockingObjects
		{
			// Token: 0x04000264 RID: 612
			[global::Cpp2ILInjected.Token(Token = "0x4000087")]
			None,
			// Token: 0x04000265 RID: 613
			[global::Cpp2ILInjected.Token(Token = "0x4000088")]
			TwoD,
			// Token: 0x04000266 RID: 614
			[global::Cpp2ILInjected.Token(Token = "0x4000089")]
			ThreeD,
			// Token: 0x04000267 RID: 615
			[global::Cpp2ILInjected.Token(Token = "0x400008A")]
			All
		}

		// Token: 0x0200008B RID: 139
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200001F")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600068E RID: 1678 RVA: 0x00003346 File Offset: 0x00001546
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x600012C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB4C34", Offset = "0x1FB4C34", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x0600068F RID: 1679 RVA: 0x00003349 File Offset: 0x00001549
			[global::Cpp2ILInjected.Token(Token = "0x600012D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB4C90", Offset = "0x1FB4C90", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06000690 RID: 1680 RVA: 0x0000334C File Offset: 0x0000154C
			[global::Cpp2ILInjected.Token(Token = "0x600012E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB4C98", Offset = "0x1FB4C98", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "get_absoluteDepth", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			internal int <Raycast>b__27_0(Graphic g1, Graphic g2)
			{
				throw null;
			}

			// Token: 0x04000268 RID: 616
			[global::Cpp2ILInjected.Token(Token = "0x400008B")]
			public static readonly GraphicRaycaster.<>c <>9;

			// Token: 0x04000269 RID: 617
			[global::Cpp2ILInjected.Token(Token = "0x400008C")]
			public static Comparison<Graphic> <>9__27_0;
		}
	}
}
