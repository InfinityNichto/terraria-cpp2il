using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Pool;
using UnityEngine.Serialization;
using UnityEngine.UI.CoroutineTween;

namespace UnityEngine.UI
{
	// Token: 0x02000011 RID: 17
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	[DisallowMultipleComponent]
	[global::Cpp2ILInjected.Token(Token = "0x200001C")]
	public abstract class Graphic : UIBehaviour, ICanvasElement
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000225A File Offset: 0x0000045A
		[global::Cpp2ILInjected.Token(Token = "0x17000035")]
		public static Material defaultGraphicMaterial
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FAFF08", Offset = "0x1FAFF08", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "get_defaultMaterial", ReturnType = typeof(Material))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnEnable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "UpdateCaretMaterial", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "UpdateGeometry", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "GetDefaultCanvasMaterial", ReturnType = typeof(Material))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x0000225D File Offset: 0x0000045D
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00002260 File Offset: 0x00000460
		[global::Cpp2ILInjected.Token(Token = "0x17000036")]
		public virtual Color color
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FAFFE4", Offset = "0x1FAFFE4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FAFFF0", Offset = "0x1FAFFF0", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility), Member = "SetColor", MemberParameters = new object[]
			{
				typeof(ref Color),
				typeof(Color)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00002263 File Offset: 0x00000463
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00002266 File Offset: 0x00000466
		[global::Cpp2ILInjected.Token(Token = "0x17000037")]
		public virtual bool raycastTarget
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB0028", Offset = "0x1FB0028", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB0030", Offset = "0x1FB0030", Length = "0xD4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicRegistry), Member = "UnregisterRaycastGraphicForCanvas", MemberParameters = new object[]
			{
				typeof(Canvas),
				typeof(Graphic)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicRegistry), Member = "RegisterRaycastGraphicForCanvas", MemberParameters = new object[]
			{
				typeof(Canvas),
				typeof(Graphic)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00002269 File Offset: 0x00000469
		// (set) Token: 0x060000BD RID: 189 RVA: 0x0000226C File Offset: 0x0000046C
		[global::Cpp2ILInjected.Token(Token = "0x17000038")]
		public Vector4 raycastPadding
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB04B0", Offset = "0x1FB04B0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB04BC", Offset = "0x1FB04BC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0000226F File Offset: 0x0000046F
		// (set) Token: 0x060000BF RID: 191 RVA: 0x00002272 File Offset: 0x00000472
		[global::Cpp2ILInjected.Token(Token = "0x17000039")]
		protected bool useLegacyMeshGeneration
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB04C8", Offset = "0x1FB04C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB04D0", Offset = "0x1FB04D0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002275 File Offset: 0x00000475
		[global::Cpp2ILInjected.Token(Token = "0x60000EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB04DC", Offset = "0x1FB04DC", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskableGraphic), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TweenRunner<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected Graphic()
		{
			throw null;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002278 File Offset: 0x00000478
		[global::Cpp2ILInjected.Token(Token = "0x60000EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB0584", Offset = "0x1FB0584", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void SetAllDirty()
		{
			throw null;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000227B File Offset: 0x0000047B
		[global::Cpp2ILInjected.Token(Token = "0x60000EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB06C4", Offset = "0x1FB06C4", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual void SetLayoutDirty()
		{
			throw null;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000227E File Offset: 0x0000047E
		[global::Cpp2ILInjected.Token(Token = "0x60000ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB07BC", Offset = "0x1FB07BC", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new object[] { typeof(ICanvasElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual void SetVerticesDirty()
		{
			throw null;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002281 File Offset: 0x00000481
		[global::Cpp2ILInjected.Token(Token = "0x60000EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB0850", Offset = "0x1FB0850", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new object[] { typeof(ICanvasElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual void SetMaterialDirty()
		{
			throw null;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002284 File Offset: 0x00000484
		[global::Cpp2ILInjected.Token(Token = "0x60000EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB05F4", Offset = "0x1FB05F4", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RawImage), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicRegistry), Member = "RegisterRaycastGraphicForCanvas", MemberParameters = new object[]
		{
			typeof(Canvas),
			typeof(Graphic)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicRegistry), Member = "UnregisterRaycastGraphicForCanvas", MemberParameters = new object[]
		{
			typeof(Canvas),
			typeof(Graphic)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void SetRaycastDirty()
		{
			throw null;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002287 File Offset: 0x00000487
		[global::Cpp2ILInjected.Token(Token = "0x60000F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB08E4", Offset = "0x1FB08E4", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasUpdateRegistry), Member = "IsRebuildingLayout", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected override void OnRectTransformDimensionsChange()
		{
			throw null;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000228A File Offset: 0x0000048A
		[global::Cpp2ILInjected.Token(Token = "0x60000F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB0988", Offset = "0x1FB0988", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicRegistry), Member = "DisableGraphicForCanvas", MemberParameters = new object[]
		{
			typeof(Canvas),
			typeof(Graphic)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected override void OnBeforeTransformParentChanged()
		{
			throw null;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000228D File Offset: 0x0000048D
		[global::Cpp2ILInjected.Token(Token = "0x60000F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB0B94", Offset = "0x1FB0B94", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskableGraphic), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "CacheCanvas", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicRegistry), Member = "RegisterGraphicForCanvas", MemberParameters = new object[]
		{
			typeof(Canvas),
			typeof(Graphic)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected override void OnTransformParentChanged()
		{
			throw null;
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00002290 File Offset: 0x00000490
		[global::Cpp2ILInjected.Token(Token = "0x1700003A")]
		public int depth
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB0F84", Offset = "0x1FB0F84", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "get_absoluteDepth", ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00002293 File Offset: 0x00000493
		[global::Cpp2ILInjected.Token(Token = "0x1700003B")]
		public RectTransform rectTransform
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000F4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB0764", Offset = "0x1FB0764", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 57)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00002296 File Offset: 0x00000496
		[global::Cpp2ILInjected.Token(Token = "0x1700003C")]
		public Canvas canvas
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000F5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB0104", Offset = "0x1FB0104", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "set_raycastTarget", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "SetRaycastDirty", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "OnBeforeTransformParentChanged", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "OnEnable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "OnDisable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "OnDestroy", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "PixelAdjustPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "ScreenToLocal", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "GenerateCaret", MemberParameters = new object[]
			{
				typeof(VertexHelper),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskableGraphic), Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 32)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "CacheCanvas", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002299 File Offset: 0x00000499
		[global::Cpp2ILInjected.Token(Token = "0x60000F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB0C48", Offset = "0x1FB0C48", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Get", ReturnType = "TCollection")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponentsInParent", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(bool),
			"System.Collections.Generic.List`1<T>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Release", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void CacheCanvas()
		{
			throw null;
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000CD RID: 205 RVA: 0x0000229C File Offset: 0x0000049C
		[global::Cpp2ILInjected.Token(Token = "0x1700003D")]
		public CanvasRenderer canvasRenderer
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB0F98", Offset = "0x1FB0F98", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 34)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0000229F File Offset: 0x0000049F
		[global::Cpp2ILInjected.Token(Token = "0x1700003E")]
		public virtual Material defaultMaterial
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB1020", Offset = "0x1FB1020", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_defaultGraphicMaterial", ReturnType = typeof(Material))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000CF RID: 207 RVA: 0x000022A2 File Offset: 0x000004A2
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x000022A5 File Offset: 0x000004A5
		[global::Cpp2ILInjected.Token(Token = "0x1700003F")]
		public virtual Material material
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB106C", Offset = "0x1FB106C", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB10F4", Offset = "0x1FB10F4", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "set_material", MemberParameters = new object[] { typeof(Material) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x000022A8 File Offset: 0x000004A8
		[global::Cpp2ILInjected.Token(Token = "0x17000040")]
		public virtual Material materialForRendering
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB118C", Offset = "0x1FB118C", Length = "0x218")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Get", ReturnType = "TCollection")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponents", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(List<Component>)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Release", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x000022AB File Offset: 0x000004AB
		[global::Cpp2ILInjected.Token(Token = "0x17000041")]
		public virtual Texture mainTexture
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB13A4", Offset = "0x1FB13A4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000022AE File Offset: 0x000004AE
		[global::Cpp2ILInjected.Token(Token = "0x60000FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB13FC", Offset = "0x1FB13FC", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskableGraphic), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "CacheCanvas", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicRegistry), Member = "RegisterGraphicForCanvas", MemberParameters = new object[]
		{
			typeof(Canvas),
			typeof(Graphic)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = "get_whiteTexture", ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		protected override void OnEnable()
		{
			throw null;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000022B1 File Offset: 0x000004B1
		[global::Cpp2ILInjected.Token(Token = "0x60000FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB152C", Offset = "0x1FB152C", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskableGraphic), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicRegistry), Member = "DisableGraphicForCanvas", MemberParameters = new object[]
		{
			typeof(Canvas),
			typeof(Graphic)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasUpdateRegistry), Member = "DisableCanvasElementForRebuild", MemberParameters = new object[] { typeof(ICanvasElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		protected override void OnDisable()
		{
			throw null;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000022B4 File Offset: 0x000004B4
		[global::Cpp2ILInjected.Token(Token = "0x60000FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB166C", Offset = "0x1FB166C", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicRegistry), Member = "UnregisterGraphicForCanvas", MemberParameters = new object[]
		{
			typeof(Canvas),
			typeof(Graphic)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasUpdateRegistry), Member = "UnRegisterCanvasElementForRebuild", MemberParameters = new object[] { typeof(ICanvasElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnDestroy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		protected override void OnDestroy()
		{
			throw null;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000022B7 File Offset: 0x000004B7
		[global::Cpp2ILInjected.Token(Token = "0x6000100")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB18F8", Offset = "0x1FB18F8", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskableGraphic), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "CacheCanvas", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicRegistry), Member = "UnregisterGraphicForCanvas", MemberParameters = new object[]
		{
			typeof(Canvas),
			typeof(Graphic)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicRegistry), Member = "RegisterGraphicForCanvas", MemberParameters = new object[]
		{
			typeof(Canvas),
			typeof(Graphic)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void OnCanvasHierarchyChanged()
		{
			throw null;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000022BA File Offset: 0x000004BA
		[global::Cpp2ILInjected.Token(Token = "0x6000101")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB1A30", Offset = "0x1FB1A30", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "get_cull", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new object[] { typeof(ICanvasElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual void OnCullingChanged()
		{
			throw null;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000022BD File Offset: 0x000004BD
		[global::Cpp2ILInjected.Token(Token = "0x6000102")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB1AB4", Offset = "0x1FB1AB4", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "get_cull", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual void Rebuild(CanvasUpdate update)
		{
			throw null;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000022C0 File Offset: 0x000004C0
		[global::Cpp2ILInjected.Token(Token = "0x6000103")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB1B90", Offset = "0x1FB1B90", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void LayoutComplete()
		{
			throw null;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000022C3 File Offset: 0x000004C3
		[global::Cpp2ILInjected.Token(Token = "0x6000104")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB1B94", Offset = "0x1FB1B94", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void GraphicUpdateComplete()
		{
			throw null;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000022C6 File Offset: 0x000004C6
		[global::Cpp2ILInjected.Token(Token = "0x6000105")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB1B98", Offset = "0x1FB1B98", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "UpdateMaterial", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "set_materialCount", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "SetMaterial", MemberParameters = new object[]
		{
			typeof(Material),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "SetTexture", MemberParameters = new object[] { typeof(Texture) }, ReturnType = typeof(void))]
		protected virtual void UpdateMaterial()
		{
			throw null;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000022C9 File Offset: 0x000004C9
		[global::Cpp2ILInjected.Token(Token = "0x6000106")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB1C40", Offset = "0x1FB1C40", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Text), Member = "UpdateGeometry", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "DoMeshGeneration", ReturnType = typeof(void))]
		protected virtual void UpdateGeometry()
		{
			throw null;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000022CC File Offset: 0x000004CC
		[global::Cpp2ILInjected.Token(Token = "0x6000107")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB1FD4", Offset = "0x1FB1FD4", Length = "0x3B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "UpdateGeometry", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Get", ReturnType = "TCollection")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponents", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(List<Component>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Release", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_workerMesh", ReturnType = typeof(Mesh))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "FillMesh", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "SetMesh", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		private void DoMeshGeneration()
		{
			throw null;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000022CF File Offset: 0x000004CF
		[global::Cpp2ILInjected.Token(Token = "0x6000108")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB1C50", Offset = "0x1FB1C50", Length = "0x384")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_workerMesh", ReturnType = typeof(Mesh))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Get", ReturnType = "TCollection")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponents", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(List<Component>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Release", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "SetMesh", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private void DoLegacyMeshGeneration()
		{
			throw null;
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000DF RID: 223 RVA: 0x000022D2 File Offset: 0x000004D2
		[global::Cpp2ILInjected.Token(Token = "0x17000042")]
		protected static Mesh workerMesh
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000109")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB2388", Offset = "0x1FB2388", Length = "0x130")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "DoMeshGeneration", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "DoLegacyMeshGeneration", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new object[] { typeof(HideFlags) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000022D5 File Offset: 0x000004D5
		[Obsolete("Use OnPopulateMesh instead.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x600010A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB24B8", Offset = "0x1FB24B8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void OnFillVBO(List<UIVertex> vbo)
		{
			throw null;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000022D8 File Offset: 0x000004D8
		[Obsolete("Use OnPopulateMesh(VertexHelper vh) instead.", false)]
		[global::Cpp2ILInjected.Token(Token = "0x600010B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB24BC", Offset = "0x1FB24BC", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "FillMesh", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual void OnPopulateMesh(Mesh m)
		{
			throw null;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000022DB File Offset: 0x000004DB
		[global::Cpp2ILInjected.Token(Token = "0x600010C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB254C", Offset = "0x1FB254C", Length = "0x480")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "OnPopulateMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_x", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_y", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Color32),
			typeof(Vector4)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "AddTriangle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected virtual void OnPopulateMesh(VertexHelper vh)
		{
			throw null;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000022DE File Offset: 0x000004DE
		[global::Cpp2ILInjected.Token(Token = "0x600010D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB2AE4", Offset = "0x1FB2AE4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override void OnDidApplyAnimationProperties()
		{
			throw null;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000022E1 File Offset: 0x000004E1
		[global::Cpp2ILInjected.Token(Token = "0x600010E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB2AF4", Offset = "0x1FB2AF4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void SetNativeSize()
		{
			throw null;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000022E4 File Offset: 0x000004E4
		[global::Cpp2ILInjected.Token(Token = "0x600010F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB2AF8", Offset = "0x1FB2AF8", Length = "0x474")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Get", ReturnType = "TCollection")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.List`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_overrideSorting", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasGroup), Member = "get_ignoreParentGroups", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_parent", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Release", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public virtual bool Raycast(Vector2 sp, Camera eventCamera)
		{
			throw null;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000022E7 File Offset: 0x000004E7
		[global::Cpp2ILInjected.Token(Token = "0x6000110")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB2F6C", Offset = "0x1FB2F6C", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnFillVBO", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Text), Member = "OnPopulateMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_scaleFactor", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_pixelPerfect", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransformUtility), Member = "PixelAdjustPoint", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Transform),
			typeof(Canvas)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public Vector2 PixelAdjustPoint(Vector2 point)
		{
			throw null;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000022EA File Offset: 0x000004EA
		[global::Cpp2ILInjected.Token(Token = "0x6000111")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB29CC", Offset = "0x1FB29CC", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "OnPopulateMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GetDrawingDimensions", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateSprite", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateSlicedSprite", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateTiledSprite", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "IsRaycastLocationValid", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Camera)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RawImage), Member = "OnPopulateMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Text), Member = "get_preferredHeight", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_scaleFactor", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_pixelPerfect", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransformUtility), Member = "PixelAdjustRect", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(Canvas)
		}, ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public Rect GetPixelAdjustedRect()
		{
			throw null;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000022ED File Offset: 0x000004ED
		[global::Cpp2ILInjected.Token(Token = "0x6000112")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB309C", Offset = "0x1FB309C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
		{
			throw null;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000022F0 File Offset: 0x000004F0
		[global::Cpp2ILInjected.Token(Token = "0x6000113")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB30B8", Offset = "0x1FB30B8", Length = "0x26C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "GetColor", ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "Equals", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TweenRunner<>), Member = "StopTween", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityAction<Color>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ColorTween), Member = "AddOnChangedCallback", MemberParameters = new object[] { typeof(UnityAction<Color>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TweenRunner<>), Member = "StartTween", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB)
		{
			throw null;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000022F3 File Offset: 0x000004F3
		[global::Cpp2ILInjected.Token(Token = "0x6000114")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB3324", Offset = "0x1FB3324", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static Color CreateColorFromAlpha(float alpha)
		{
			throw null;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000022F6 File Offset: 0x000004F6
		[global::Cpp2ILInjected.Token(Token = "0x6000115")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB3338", Offset = "0x1FB3338", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
		{
			throw null;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000022F9 File Offset: 0x000004F9
		[global::Cpp2ILInjected.Token(Token = "0x6000116")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB33D4", Offset = "0x1FB33D4", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
		{
			typeof(Delegate),
			typeof(Delegate)
		}, ReturnType = typeof(Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void RegisterDirtyLayoutCallback(UnityAction action)
		{
			throw null;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000022FC File Offset: 0x000004FC
		[global::Cpp2ILInjected.Token(Token = "0x6000117")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB3454", Offset = "0x1FB3454", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
		{
			typeof(Delegate),
			typeof(Delegate)
		}, ReturnType = typeof(Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void UnregisterDirtyLayoutCallback(UnityAction action)
		{
			throw null;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000022FF File Offset: 0x000004FF
		[global::Cpp2ILInjected.Token(Token = "0x6000118")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB34D4", Offset = "0x1FB34D4", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "set_textComponent", MemberParameters = new object[] { typeof(Text) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
		{
			typeof(Delegate),
			typeof(Delegate)
		}, ReturnType = typeof(Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void RegisterDirtyVerticesCallback(UnityAction action)
		{
			throw null;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002302 File Offset: 0x00000502
		[global::Cpp2ILInjected.Token(Token = "0x6000119")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB3554", Offset = "0x1FB3554", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "set_textComponent", MemberParameters = new object[] { typeof(Text) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
		{
			typeof(Delegate),
			typeof(Delegate)
		}, ReturnType = typeof(Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void UnregisterDirtyVerticesCallback(UnityAction action)
		{
			throw null;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002305 File Offset: 0x00000505
		[global::Cpp2ILInjected.Token(Token = "0x600011A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB35D4", Offset = "0x1FB35D4", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "set_textComponent", MemberParameters = new object[] { typeof(Text) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
		{
			typeof(Delegate),
			typeof(Delegate)
		}, ReturnType = typeof(Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void RegisterDirtyMaterialCallback(UnityAction action)
		{
			throw null;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002308 File Offset: 0x00000508
		[global::Cpp2ILInjected.Token(Token = "0x600011B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB3654", Offset = "0x1FB3654", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "set_textComponent", MemberParameters = new object[] { typeof(Text) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
		{
			typeof(Delegate),
			typeof(Delegate)
		}, ReturnType = typeof(Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void UnregisterDirtyMaterialCallback(UnityAction action)
		{
			throw null;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000230B File Offset: 0x0000050B
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600011C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB36D4", Offset = "0x1FB36D4", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static Graphic()
		{
			throw null;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000230E File Offset: 0x0000050E
		[global::Cpp2ILInjected.Token(Token = "0x600011D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB375C", Offset = "0x1FB375C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		private Transform UnityEngine.UI.ICanvasElement.get_transform()
		{
			throw null;
		}

		// Token: 0x0400004E RID: 78
		[global::Cpp2ILInjected.Token(Token = "0x4000068")]
		protected static Material s_DefaultUI;

		// Token: 0x0400004F RID: 79
		[global::Cpp2ILInjected.Token(Token = "0x4000069")]
		protected static Texture2D s_WhiteTexture;

		// Token: 0x04000050 RID: 80
		[SerializeField]
		[FormerlySerializedAs("m_Mat")]
		[global::Cpp2ILInjected.Token(Token = "0x400006A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected Material m_Material;

		// Token: 0x04000051 RID: 81
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400006B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Color m_Color;

		// Token: 0x04000052 RID: 82
		[global::Cpp2ILInjected.Token(Token = "0x400006C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		[NonSerialized]
		protected bool m_SkipLayoutUpdate;

		// Token: 0x04000053 RID: 83
		[global::Cpp2ILInjected.Token(Token = "0x400006D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x31")]
		[NonSerialized]
		protected bool m_SkipMaterialUpdate;

		// Token: 0x04000054 RID: 84
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400006E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x32")]
		private bool m_RaycastTarget;

		// Token: 0x04000055 RID: 85
		[global::Cpp2ILInjected.Token(Token = "0x400006F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x33")]
		private bool m_RaycastTargetCache;

		// Token: 0x04000056 RID: 86
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000070")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private Vector4 m_RaycastPadding;

		// Token: 0x04000057 RID: 87
		[global::Cpp2ILInjected.Token(Token = "0x4000071")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		[NonSerialized]
		private RectTransform m_RectTransform;

		// Token: 0x04000058 RID: 88
		[global::Cpp2ILInjected.Token(Token = "0x4000072")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		[NonSerialized]
		private CanvasRenderer m_CanvasRenderer;

		// Token: 0x04000059 RID: 89
		[global::Cpp2ILInjected.Token(Token = "0x4000073")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		[NonSerialized]
		private Canvas m_Canvas;

		// Token: 0x0400005A RID: 90
		[global::Cpp2ILInjected.Token(Token = "0x4000074")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		[NonSerialized]
		private bool m_VertsDirty;

		// Token: 0x0400005B RID: 91
		[global::Cpp2ILInjected.Token(Token = "0x4000075")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x61")]
		[NonSerialized]
		private bool m_MaterialDirty;

		// Token: 0x0400005C RID: 92
		[global::Cpp2ILInjected.Token(Token = "0x4000076")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		[NonSerialized]
		protected UnityAction m_OnDirtyLayoutCallback;

		// Token: 0x0400005D RID: 93
		[global::Cpp2ILInjected.Token(Token = "0x4000077")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		[NonSerialized]
		protected UnityAction m_OnDirtyVertsCallback;

		// Token: 0x0400005E RID: 94
		[global::Cpp2ILInjected.Token(Token = "0x4000078")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		[NonSerialized]
		protected UnityAction m_OnDirtyMaterialCallback;

		// Token: 0x0400005F RID: 95
		[global::Cpp2ILInjected.Token(Token = "0x4000079")]
		[NonSerialized]
		protected static Mesh s_Mesh;

		// Token: 0x04000060 RID: 96
		[global::Cpp2ILInjected.Token(Token = "0x400007A")]
		[NonSerialized]
		private static readonly VertexHelper s_VertexHelper;

		// Token: 0x04000061 RID: 97
		[global::Cpp2ILInjected.Token(Token = "0x400007B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		[NonSerialized]
		protected Mesh m_CachedMesh;

		// Token: 0x04000062 RID: 98
		[global::Cpp2ILInjected.Token(Token = "0x400007C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		[NonSerialized]
		protected Vector2[] m_CachedUvs;

		// Token: 0x04000063 RID: 99
		[global::Cpp2ILInjected.Token(Token = "0x400007D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		[NonSerialized]
		private readonly TweenRunner<ColorTween> m_ColorTweenRunner;

		// Token: 0x04000064 RID: 100
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400007E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private bool <useLegacyMeshGeneration>k__BackingField;
	}
}
