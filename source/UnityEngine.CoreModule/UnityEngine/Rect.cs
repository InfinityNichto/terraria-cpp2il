using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200007A RID: 122
	[NativeHeader("Runtime/Math/Rect.h")]
	[NativeClass("Rectf", "template<typename T> class RectT; typedef RectT<float> Rectf;")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000087")]
	public struct Rect : IEquatable<Rect>, IFormattable
	{
		// Token: 0x06000244 RID: 580 RVA: 0x000024B2 File Offset: 0x000006B2
		[global::Cpp2ILInjected.Token(Token = "0x6000252")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F780AC", Offset = "0x1F780AC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 81)]
		public Rect(float x, float y, float width, float height)
		{
			throw null;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x000024B5 File Offset: 0x000006B5
		[global::Cpp2ILInjected.Token(Token = "0x6000253")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F780B8", Offset = "0x1F780B8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XNAWorldCameraSettings", Member = "ApplyCamera", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.MaskableGraphic", Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUI", Member = "DoLabel", MemberParameters = new object[]
		{
			typeof(Rect),
			"UnityEngine.GUIContent",
			"UnityEngine.GUIStyle"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public Rect(Vector2 position, Vector2 size)
		{
			throw null;
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000246 RID: 582 RVA: 0x000024B8 File Offset: 0x000006B8
		[global::Cpp2ILInjected.Token(Token = "0x17000080")]
		public static Rect zero
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000254")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F780C4", Offset = "0x1F780C4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Sprite), Member = "get_textureRect", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.RectMask2D", Member = "PerformClipping", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUIUtility", Member = "GetControlID", MemberParameters = new object[]
			{
				typeof(int),
				"UnityEngine.FocusType"
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x000024BB File Offset: 0x000006BB
		[global::Cpp2ILInjected.Token(Token = "0x6000255")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F780D8", Offset = "0x1F780D8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayout", Member = "BeginArea", MemberParameters = new object[]
		{
			typeof(Rect),
			"UnityEngine.GUIContent",
			"UnityEngine.GUIStyle"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax)
		{
			throw null;
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000248 RID: 584 RVA: 0x000024BE File Offset: 0x000006BE
		// (set) Token: 0x06000249 RID: 585 RVA: 0x000024C1 File Offset: 0x000006C1
		[global::Cpp2ILInjected.Token(Token = "0x17000081")]
		public float x
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000256")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F780E4", Offset = "0x1F780E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUISafeRegionEdit", Member = "DrawBacking", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIVirtualInputControllerEdit", Member = "DrawBacking", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DeviceVPPICalculator", Member = "GetViewportSafeRegion", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XNAUICameraSettings", Member = "GetViewportSafeRegion", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectTransform), Member = "GetLocalCorners", MemberParameters = new object[] { typeof(Vector3[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "OnPopulateMesh", MemberParameters = new object[] { "UnityEngine.UI.VertexHelper" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "PreserveSpriteAspectRatio", MemberParameters = new object[]
			{
				typeof(ref Rect),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "GetDrawingDimensions", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Vector4))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSlicedSprite", MemberParameters = new object[] { "UnityEngine.UI.VertexHelper" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "IsRaycastLocationValid", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Camera)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.RawImage", Member = "OnPopulateMesh", MemberParameters = new object[] { "UnityEngine.UI.VertexHelper" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutEntry", Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutUtility", Member = "LayoutSingleGroup", MemberParameters = new object[] { "UnityEngine.GUILayoutGroup" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUIScrollGroup", Member = "SetVertical", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000257")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F780EC", Offset = "0x1F780EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "PreserveSpriteAspectRatio", MemberParameters = new object[]
			{
				typeof(ref Rect),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutEntry", Member = "SetHorizontal", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "SetHorizontal", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600024A RID: 586 RVA: 0x000024C4 File Offset: 0x000006C4
		// (set) Token: 0x0600024B RID: 587 RVA: 0x000024C7 File Offset: 0x000006C7
		[global::Cpp2ILInjected.Token(Token = "0x17000082")]
		public float y
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000258")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F780F4", Offset = "0x1F780F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUISafeRegionEdit", Member = "DrawBacking", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIVirtualInputControllerEdit", Member = "DrawBacking", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DeviceVPPICalculator", Member = "GetSafeArea", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DeviceVPPICalculator", Member = "SetSafeArea", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectTransform), Member = "GetLocalCorners", MemberParameters = new object[] { typeof(Vector3[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "OnPopulateMesh", MemberParameters = new object[] { "UnityEngine.UI.VertexHelper" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "PreserveSpriteAspectRatio", MemberParameters = new object[]
			{
				typeof(ref Rect),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "GetDrawingDimensions", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Vector4))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSlicedSprite", MemberParameters = new object[] { "UnityEngine.UI.VertexHelper" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "IsRaycastLocationValid", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Camera)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.RawImage", Member = "OnPopulateMesh", MemberParameters = new object[] { "UnityEngine.UI.VertexHelper" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutEntry", Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutUtility", Member = "LayoutSingleGroup", MemberParameters = new object[] { "UnityEngine.GUILayoutGroup" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000259")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F780FC", Offset = "0x1F780FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "PreserveSpriteAspectRatio", MemberParameters = new object[]
			{
				typeof(ref Rect),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutEntry", Member = "SetVertical", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "SetVertical", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600024C RID: 588 RVA: 0x000024CA File Offset: 0x000006CA
		[global::Cpp2ILInjected.Token(Token = "0x17000083")]
		public Vector2 position
		{
			[global::Cpp2ILInjected.Token(Token = "0x600025A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F78104", Offset = "0x1F78104", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateTiledSprite", MemberParameters = new object[] { "UnityEngine.UI.VertexHelper" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Scrollbar", Member = "UpdateDrag", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Slider", Member = "UpdateDrag", MemberParameters = new object[]
			{
				"UnityEngine.EventSystems.PointerEventData",
				typeof(Camera)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600024D RID: 589 RVA: 0x000024CD File Offset: 0x000006CD
		[global::Cpp2ILInjected.Token(Token = "0x17000084")]
		public Vector2 center
		{
			[global::Cpp2ILInjected.Token(Token = "0x600025B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7810C", Offset = "0x1F7810C", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UserManagement", Member = "UpdateViewPorts", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Scrollbar", Member = "OnBeginDrag", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "SetLayoutVertical", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "UpdateBounds", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Selectable", Member = "FindSelectable", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = "UnityEngine.UI.Selectable")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Selectable", Member = "GetPointOnRectEdge", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(Vector2)
			}, ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600024E RID: 590 RVA: 0x000024D0 File Offset: 0x000006D0
		[global::Cpp2ILInjected.Token(Token = "0x17000085")]
		public Vector2 min
		{
			[global::Cpp2ILInjected.Token(Token = "0x600025C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F78124", Offset = "0x1F78124", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XNAUICameraSettings", Member = "RectRoughlyEqual", MemberParameters = new object[]
			{
				typeof(Rect),
				typeof(Rect)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600024F RID: 591 RVA: 0x000024D3 File Offset: 0x000006D3
		[global::Cpp2ILInjected.Token(Token = "0x17000086")]
		public Vector2 max
		{
			[global::Cpp2ILInjected.Token(Token = "0x600025D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7813C", Offset = "0x1F7813C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XNAUICameraSettings", Member = "RectRoughlyEqual", MemberParameters = new object[]
			{
				typeof(Rect),
				typeof(Rect)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000250 RID: 592 RVA: 0x000024D6 File Offset: 0x000006D6
		// (set) Token: 0x06000251 RID: 593 RVA: 0x000024D9 File Offset: 0x000006D9
		[global::Cpp2ILInjected.Token(Token = "0x17000087")]
		public float width
		{
			[global::Cpp2ILInjected.Token(Token = "0x600025E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7816C", Offset = "0x1F7816C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 56)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600025F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F78174", Offset = "0x1F78174", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "PreserveSpriteAspectRatio", MemberParameters = new object[]
			{
				typeof(ref Rect),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutEntry", Member = "SetHorizontal", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "SetHorizontal", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUIScrollGroup", Member = "SetHorizontal", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUIScrollGroup", Member = "SetVertical", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000252 RID: 594 RVA: 0x000024DC File Offset: 0x000006DC
		// (set) Token: 0x06000253 RID: 595 RVA: 0x000024DF File Offset: 0x000006DF
		[global::Cpp2ILInjected.Token(Token = "0x17000088")]
		public float height
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000260")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7817C", Offset = "0x1F7817C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 59)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000261")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F78184", Offset = "0x1F78184", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "PreserveSpriteAspectRatio", MemberParameters = new object[]
			{
				typeof(ref Rect),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutEntry", Member = "SetVertical", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "SetVertical", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUIScrollGroup", Member = "SetVertical", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000254 RID: 596 RVA: 0x000024E2 File Offset: 0x000006E2
		[global::Cpp2ILInjected.Token(Token = "0x17000089")]
		public Vector2 size
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000262")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7818C", Offset = "0x1F7818C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 42)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000255 RID: 597 RVA: 0x000024E5 File Offset: 0x000006E5
		// (set) Token: 0x06000256 RID: 598 RVA: 0x000024E8 File Offset: 0x000006E8
		[global::Cpp2ILInjected.Token(Token = "0x1700008A")]
		public float xMin
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000263")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7812C", Offset = "0x1F7812C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUISafeRegionEdit", Member = "UpdateCursor", MemberParameters = new object[] { "Cursor" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUISafeRegionEdit", Member = "UpdateCursorDragging", MemberParameters = new object[] { typeof(ref Rect) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DeviceVPPICalculator", Member = "IsSafeAreaValid", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DeviceVPPICalculator", Member = "GetViewportSafeRegion", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DeviceVPPICalculator", Member = "GetSafeArea", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DeviceVPPICalculator", Member = "SetSafeArea", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XNAUICameraSettings", Member = "GetViewportSafeRegion", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XNAUICameraSettings", Member = "ApplyCamera", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "SaveSettings", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "PercentToWorldRect", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "PixelToWorldRect", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Utility", Member = "DrawRectGizmo", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Clipping", Member = "FindCullAndClipWorldRect", MemberParameters = new object[]
			{
				"System.Collections.Generic.List`1<RectMask2D>",
				typeof(ref bool)
			}, ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField.<MouseDragOutsideRect>d__194", Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateHighlight", MemberParameters = new object[]
			{
				"UnityEngine.UI.VertexHelper",
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.RawImage", Member = "OnPopulateMesh", MemberParameters = new object[] { "UnityEngine.UI.VertexHelper" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUIUtility", Member = "HitTest", MemberParameters = new object[]
			{
				typeof(Rect),
				typeof(Vector2),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayout", Member = "BeginArea", MemberParameters = new object[]
			{
				typeof(Rect),
				"UnityEngine.GUIContent",
				"UnityEngine.GUIStyle"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 34)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000264")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F78194", Offset = "0x1F78194", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUISafeRegionEdit", Member = "UpdateCursorDragging", MemberParameters = new object[] { typeof(ref Rect) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DeviceVPPICalculator", Member = "GetSafeArea", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "SaveSettings", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000257 RID: 599 RVA: 0x000024EB File Offset: 0x000006EB
		// (set) Token: 0x06000258 RID: 600 RVA: 0x000024EE File Offset: 0x000006EE
		[global::Cpp2ILInjected.Token(Token = "0x1700008B")]
		public float yMin
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000265")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F78134", Offset = "0x1F78134", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUISafeRegionEdit", Member = "UpdateCursor", MemberParameters = new object[] { "Cursor" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUISafeRegionEdit", Member = "UpdateCursorDragging", MemberParameters = new object[] { typeof(ref Rect) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DeviceVPPICalculator", Member = "IsSafeAreaValid", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DeviceVPPICalculator", Member = "GetViewportSafeRegion", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DeviceVPPICalculator", Member = "GetSafeArea", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DeviceVPPICalculator", Member = "SetSafeArea", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XNAUICameraSettings", Member = "GetViewportSafeRegion", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XNAUICameraSettings", Member = "ApplyCamera", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "SaveSettings", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "PercentToWorldRect", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "PixelToWorldRect", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Utility", Member = "DrawRectGizmo", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Clipping", Member = "FindCullAndClipWorldRect", MemberParameters = new object[]
			{
				"System.Collections.Generic.List`1<RectMask2D>",
				typeof(ref bool)
			}, ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField.<MouseDragOutsideRect>d__194", Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.RawImage", Member = "OnPopulateMesh", MemberParameters = new object[] { "UnityEngine.UI.VertexHelper" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUIUtility", Member = "HitTest", MemberParameters = new object[]
			{
				typeof(Rect),
				typeof(Vector2),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayout", Member = "BeginArea", MemberParameters = new object[]
			{
				typeof(Rect),
				"UnityEngine.GUIContent",
				"UnityEngine.GUIStyle"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 35)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000266")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F781B0", Offset = "0x1F781B0", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUISafeRegionEdit", Member = "UpdateCursorDragging", MemberParameters = new object[] { typeof(ref Rect) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DeviceVPPICalculator", Member = "GetDefaultSafeArea", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DeviceVPPICalculator", Member = "GetSafeArea", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "SaveSettings", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000259 RID: 601 RVA: 0x000024F1 File Offset: 0x000006F1
		// (set) Token: 0x0600025A RID: 602 RVA: 0x000024F4 File Offset: 0x000006F4
		[global::Cpp2ILInjected.Token(Token = "0x1700008C")]
		public float xMax
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000267")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7814C", Offset = "0x1F7814C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUISafeRegionEdit", Member = "UpdateCursor", MemberParameters = new object[] { "Cursor" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUISafeRegionEdit", Member = "UpdateCursorDragging", MemberParameters = new object[] { typeof(ref Rect) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DeviceVPPICalculator", Member = "IsSafeAreaValid", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DeviceVPPICalculator", Member = "GetViewportSafeRegion", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DeviceVPPICalculator", Member = "GetSafeArea", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DeviceVPPICalculator", Member = "SetSafeArea", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XNAUICameraSettings", Member = "GetViewportSafeRegion", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "SaveSettings", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Utility", Member = "DrawRectGizmo", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectTransform), Member = "GetLocalCorners", MemberParameters = new object[] { typeof(Vector3[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Clipping", Member = "FindCullAndClipWorldRect", MemberParameters = new object[]
			{
				"System.Collections.Generic.List`1<RectMask2D>",
				typeof(ref bool)
			}, ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField.<MouseDragOutsideRect>d__194", Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new object[]
			{
				"UnityEngine.UI.VertexHelper",
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateHighlight", MemberParameters = new object[]
			{
				"UnityEngine.UI.VertexHelper",
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.RawImage", Member = "OnPopulateMesh", MemberParameters = new object[] { "UnityEngine.UI.VertexHelper" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutEntry", Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUIUtility", Member = "HitTest", MemberParameters = new object[]
			{
				typeof(Rect),
				typeof(Vector2),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayout", Member = "BeginArea", MemberParameters = new object[]
			{
				typeof(Rect),
				"UnityEngine.GUIContent",
				"UnityEngine.GUIStyle"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 37)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000268")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F781CC", Offset = "0x1F781CC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUISafeRegionEdit", Member = "UpdateCursorDragging", MemberParameters = new object[] { typeof(ref Rect) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DeviceVPPICalculator", Member = "GetSafeArea", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "SaveSettings", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600025B RID: 603 RVA: 0x000024F7 File Offset: 0x000006F7
		// (set) Token: 0x0600025C RID: 604 RVA: 0x000024FA File Offset: 0x000006FA
		[global::Cpp2ILInjected.Token(Token = "0x1700008D")]
		public float yMax
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000269")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7815C", Offset = "0x1F7815C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUISafeRegionEdit", Member = "UpdateCursor", MemberParameters = new object[] { "Cursor" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUISafeRegionEdit", Member = "UpdateCursorDragging", MemberParameters = new object[] { typeof(ref Rect) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DeviceVPPICalculator", Member = "IsSafeAreaValid", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DeviceVPPICalculator", Member = "GetViewportSafeRegion", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DeviceVPPICalculator", Member = "GetSafeArea", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DeviceVPPICalculator", Member = "SetSafeArea", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XNAUICameraSettings", Member = "GetViewportSafeRegion", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "SaveSettings", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Utility", Member = "DrawRectGizmo", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectTransform), Member = "GetLocalCorners", MemberParameters = new object[] { typeof(Vector3[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Clipping", Member = "FindCullAndClipWorldRect", MemberParameters = new object[]
			{
				"System.Collections.Generic.List`1<RectMask2D>",
				typeof(ref bool)
			}, ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField.<MouseDragOutsideRect>d__194", Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.RawImage", Member = "OnPopulateMesh", MemberParameters = new object[] { "UnityEngine.UI.VertexHelper" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutEntry", Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUIUtility", Member = "HitTest", MemberParameters = new object[]
			{
				typeof(Rect),
				typeof(Vector2),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayout", Member = "BeginArea", MemberParameters = new object[]
			{
				typeof(Rect),
				"UnityEngine.GUIContent",
				"UnityEngine.GUIStyle"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 33)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600026A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F781DC", Offset = "0x1F781DC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUISafeRegionEdit", Member = "UpdateCursorDragging", MemberParameters = new object[] { typeof(ref Rect) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DeviceVPPICalculator", Member = "GetDefaultSafeArea", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DeviceVPPICalculator", Member = "GetSafeArea", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "SaveSettings", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x000024FD File Offset: 0x000006FD
		[global::Cpp2ILInjected.Token(Token = "0x600026B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F781EC", Offset = "0x1F781EC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUI", Member = "DoLabel", MemberParameters = new object[]
		{
			typeof(Rect),
			"UnityEngine.GUIContent",
			"UnityEngine.GUIStyle"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUI", Member = "DoButton", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(int),
			"UnityEngine.GUIContent",
			"UnityEngine.GUIStyle"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUI", Member = "BeginGroup", MemberParameters = new object[]
		{
			typeof(Rect),
			"UnityEngine.GUIContent",
			"UnityEngine.GUIStyle",
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public bool Contains(Vector2 point)
		{
			throw null;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00002500 File Offset: 0x00000700
		[global::Cpp2ILInjected.Token(Token = "0x600026C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F78230", Offset = "0x1F78230", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchStickControl", Member = "TouchBegan", MemberParameters = new object[] { "InControl.Touch" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchSwipeControl", Member = "TouchBegan", MemberParameters = new object[] { "InControl.Touch" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchTrackControl", Member = "TouchBegan", MemberParameters = new object[] { "InControl.Touch" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "ComputeRayAndDistance", MemberParameters = new object[]
		{
			"UnityEngine.EventSystems.PointerEventData",
			typeof(ref Ray),
			typeof(ref int),
			typeof(ref float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public bool Contains(Vector3 point)
		{
			throw null;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00002503 File Offset: 0x00000703
		[global::Cpp2ILInjected.Token(Token = "0x600026D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F78274", Offset = "0x1F78274", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static Rect OrderMinMax(Rect rect)
		{
			throw null;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00002506 File Offset: 0x00000706
		[global::Cpp2ILInjected.Token(Token = "0x600026E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F782A0", Offset = "0x1F782A0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Overlaps(Rect other)
		{
			throw null;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002509 File Offset: 0x00000709
		[global::Cpp2ILInjected.Token(Token = "0x600026F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F782EC", Offset = "0x1F782EC", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.MaskableGraphic", Member = "Cull", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.RectMask2D", Member = "PerformClipping", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public bool Overlaps(Rect other, bool allowInverse)
		{
			throw null;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000250C File Offset: 0x0000070C
		[global::Cpp2ILInjected.Token(Token = "0x6000270")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F78380", Offset = "0x1F78380", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchStickControl", Member = "set_ActiveArea", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchSwipeControl", Member = "set_ActiveArea", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchTrackControl", Member = "set_ActiveArea", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.RectMask2D", Member = "PerformClipping", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public static bool operator !=(Rect lhs, Rect rhs)
		{
			throw null;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000250F File Offset: 0x0000070F
		[global::Cpp2ILInjected.Token(Token = "0x6000271")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F783B4", Offset = "0x1F783B4", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.RawImage", Member = "set_uvRect", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static bool operator ==(Rect lhs, Rect rhs)
		{
			throw null;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00002512 File Offset: 0x00000712
		[global::Cpp2ILInjected.Token(Token = "0x6000272")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F783E8", Offset = "0x1F783E8", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002515 File Offset: 0x00000715
		[global::Cpp2ILInjected.Token(Token = "0x6000273")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F78470", Offset = "0x1F78470", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object other)
		{
			throw null;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00002518 File Offset: 0x00000718
		[global::Cpp2ILInjected.Token(Token = "0x6000274")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F784EC", Offset = "0x1F784EC", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "Equals", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(bool))]
		public bool Equals(Rect other)
		{
			throw null;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000251B File Offset: 0x0000071B
		[global::Cpp2ILInjected.Token(Token = "0x6000275")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7858C", Offset = "0x1F7858C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000251E File Offset: 0x0000071E
		[global::Cpp2ILInjected.Token(Token = "0x6000276")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F78598", Offset = "0x1F78598", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			throw null;
		}

		// Token: 0x040002F0 RID: 752
		[NativeName("x")]
		[global::Cpp2ILInjected.Token(Token = "0x400031B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private float m_XMin;

		// Token: 0x040002F1 RID: 753
		[NativeName("y")]
		[global::Cpp2ILInjected.Token(Token = "0x400031C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private float m_YMin;

		// Token: 0x040002F2 RID: 754
		[NativeName("width")]
		[global::Cpp2ILInjected.Token(Token = "0x400031D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private float m_Width;

		// Token: 0x040002F3 RID: 755
		[NativeName("height")]
		[global::Cpp2ILInjected.Token(Token = "0x400031E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		private float m_Height;
	}
}
