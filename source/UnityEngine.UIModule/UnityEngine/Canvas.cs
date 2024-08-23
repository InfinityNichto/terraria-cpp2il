using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	[RequireComponent(typeof(RectTransform))]
	[NativeHeader("Modules/UI/Canvas.h")]
	[NativeHeader("Modules/UI/CanvasManager.h")]
	[NativeClass("UI::Canvas")]
	[NativeHeader("Modules/UI/UIStructs.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000005")]
	public sealed class Canvas : Behaviour
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600002F RID: 47 RVA: 0x0000208F File Offset: 0x0000028F
		// (remove) Token: 0x06000030 RID: 48 RVA: 0x00002092 File Offset: 0x00000292
		[global::Cpp2ILInjected.Token(Token = "0x14000001")]
		public static event Canvas.WillRenderCanvases preWillRenderCanvases
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600002F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FF136C", Offset = "0x1FF136C", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "OnEnable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000030")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FF1424", Offset = "0x1FF1424", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "OnDisable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000031 RID: 49 RVA: 0x00002095 File Offset: 0x00000295
		// (remove) Token: 0x06000032 RID: 50 RVA: 0x00002098 File Offset: 0x00000298
		[global::Cpp2ILInjected.Token(Token = "0x14000002")]
		public static event Canvas.WillRenderCanvases willRenderCanvases
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000031")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FF14DC", Offset = "0x1FF14DC", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CanvasUpdateRegistry", Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000032")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FF1598", Offset = "0x1FF1598", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000033 RID: 51
		[global::Cpp2ILInjected.Token(Token = "0x17000008")]
		public extern RenderMode renderMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000033")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FF1654", Offset = "0x1FF1654", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "PixelAdjustPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "get_sortOrderPriority", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "get_renderOrderPriority", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "get_eventCamera", ReturnType = typeof(Camera))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "ScreenToLocal", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new object[]
			{
				"UnityEngine.UI.VertexHelper",
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.AspectRatioFitter", Member = "IsComponentValidOnObject", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "Handle", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.RectMask2D", Member = "PerformClipping", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000034 RID: 52
		[global::Cpp2ILInjected.Token(Token = "0x17000009")]
		public extern bool isRootCanvas
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000034")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FF1690", Offset = "0x1FF1690", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.AspectRatioFitter", Member = "IsComponentValidOnObject", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "Handle", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000035 RID: 53
		// (set) Token: 0x06000036 RID: 54
		[global::Cpp2ILInjected.Token(Token = "0x1700000A")]
		public extern float scaleFactor
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000035")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FF16CC", Offset = "0x1FF16CC", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "PixelAdjustPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Text", Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6000036")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FF1708", Offset = "0x1FF1708", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "OnDisable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleWorldCanvas", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleConstantPixelSize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleConstantPhysicalSize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "SetScaleFactor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000037 RID: 55
		// (set) Token: 0x06000038 RID: 56
		[global::Cpp2ILInjected.Token(Token = "0x1700000B")]
		public extern float referencePixelsPerUnit
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000037")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FF1754", Offset = "0x1FF1754", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6000038")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FF1790", Offset = "0x1FF1790", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "OnDisable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleWorldCanvas", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleConstantPixelSize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleConstantPhysicalSize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "SetReferencePixelsPerUnit", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000039 RID: 57
		[global::Cpp2ILInjected.Token(Token = "0x1700000C")]
		public extern bool pixelPerfect
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000039")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FF17DC", Offset = "0x1FF17DC", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "PixelAdjustPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600003A RID: 58
		[global::Cpp2ILInjected.Token(Token = "0x1700000D")]
		public extern int renderOrder
		{
			[global::Cpp2ILInjected.Token(Token = "0x600003A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FF1818", Offset = "0x1FF1818", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "get_renderOrderPriority", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003B RID: 59
		// (set) Token: 0x0600003C RID: 60
		[global::Cpp2ILInjected.Token(Token = "0x1700000E")]
		public extern bool overrideSorting
		{
			[global::Cpp2ILInjected.Token(Token = "0x600003B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FF1854", Offset = "0x1FF1854", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "Raycast", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Camera)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.MaskUtilities", Member = "FindRootSortOverrideCanvas", MemberParameters = new object[] { typeof(Transform) }, ReturnType = typeof(Transform))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.MaskUtilities", Member = "GetRectMaskForClippable", MemberParameters = new object[] { "UnityEngine.UI.IClippable" }, ReturnType = "UnityEngine.UI.RectMask2D")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.MaskUtilities", Member = "GetRectMasksForClip", MemberParameters = new object[] { "UnityEngine.UI.RectMask2D", "System.Collections.Generic.List`1<RectMask2D>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x600003C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FF1890", Offset = "0x1FF1890", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetupTemplate", MemberParameters = new object[] { typeof(Canvas) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new object[] { typeof(Canvas) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003D RID: 61
		// (set) Token: 0x0600003E RID: 62
		[global::Cpp2ILInjected.Token(Token = "0x1700000F")]
		public extern int sortingOrder
		{
			[global::Cpp2ILInjected.Token(Token = "0x600003D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FF18D4", Offset = "0x1FF18D4", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new object[] { typeof(Canvas) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "get_sortOrderPriority", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x600003E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FF1910", Offset = "0x1FF1910", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetupTemplate", MemberParameters = new object[] { typeof(Canvas) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new object[] { typeof(Canvas) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003F RID: 63
		[global::Cpp2ILInjected.Token(Token = "0x17000010")]
		public extern int targetDisplay
		{
			[global::Cpp2ILInjected.Token(Token = "0x600003F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FF1954", Offset = "0x1FF1954", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new object[]
			{
				"UnityEngine.UI.VertexHelper",
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000040 RID: 64
		// (set) Token: 0x06000041 RID: 65
		[global::Cpp2ILInjected.Token(Token = "0x17000011")]
		public extern int sortingLayerID
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000040")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FF1990", Offset = "0x1FF1990", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetupTemplate", MemberParameters = new object[] { typeof(Canvas) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new object[] { typeof(Canvas) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6000041")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FF19CC", Offset = "0x1FF19CC", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetupTemplate", MemberParameters = new object[] { typeof(Canvas) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new object[] { typeof(Canvas) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000042 RID: 66
		[global::Cpp2ILInjected.Token(Token = "0x17000012")]
		public extern Canvas rootCanvas
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000042")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FF1A10", Offset = "0x1FF1A10", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "get_renderOrderPriority", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.MaskableGraphic", Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.RectMask2D", Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.RectMask2D", Member = "PerformClipping", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000043 RID: 67 RVA: 0x0000209B File Offset: 0x0000029B
		[global::Cpp2ILInjected.Token(Token = "0x17000013")]
		public Vector2 renderingDisplaySize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000043")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FF1A4C", Offset = "0x1FF1A4C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000044 RID: 68 RVA: 0x0000209E File Offset: 0x0000029E
		[global::Cpp2ILInjected.Token(Token = "0x17000014")]
		internal static Action<int> externBeginRenderOverlays
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000044")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FF1ADC", Offset = "0x1FF1ADC", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000020A1 File Offset: 0x000002A1
		[global::Cpp2ILInjected.Token(Token = "0x17000015")]
		internal static Action<int, int> externRenderOverlaysBefore
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000045")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FF1B24", Offset = "0x1FF1B24", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000046 RID: 70 RVA: 0x000020A4 File Offset: 0x000002A4
		[global::Cpp2ILInjected.Token(Token = "0x17000016")]
		internal static Action<int> externEndRenderOverlays
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000046")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FF1B6C", Offset = "0x1FF1B6C", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000047 RID: 71
		[NativeProperty("Camera", false, TargetType.Function)]
		[global::Cpp2ILInjected.Token(Token = "0x17000017")]
		public extern Camera worldCamera
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000047")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FF1BB4", Offset = "0x1FF1BB4", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "get_eventCamera", ReturnType = typeof(Camera))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "ScreenToLocal", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new object[]
			{
				"UnityEngine.UI.VertexHelper",
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x06000048 RID: 72
		[FreeFunction("UI::GetDefaultUIMaterial")]
		[global::Cpp2ILInjected.Token(Token = "0x6000048")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FF1BF0", Offset = "0x1FF1BF0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "get_defaultGraphicMaterial", ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern Material GetDefaultCanvasMaterial();

		// Token: 0x06000049 RID: 73
		[FreeFunction("UI::GetETC1SupportedCanvasMaterial")]
		[global::Cpp2ILInjected.Token(Token = "0x6000049")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FF1C18", Offset = "0x1FF1C18", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "get_defaultETC1GraphicMaterial", ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern Material GetETC1SupportedCanvasMaterial();

		// Token: 0x0600004A RID: 74 RVA: 0x000020A7 File Offset: 0x000002A7
		[global::Cpp2ILInjected.Token(Token = "0x600004A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FF1C40", Offset = "0x1FF1C40", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "EnsureLayoutHasRebuilt", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "SendPreWillRenderCanvases", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "SendWillRenderCanvases", ReturnType = typeof(void))]
		public static void ForceUpdateCanvases()
		{
			throw null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000020AA File Offset: 0x000002AA
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600004B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FF1C50", Offset = "0x1FF1C50", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Canvas), Member = "ForceUpdateCanvases", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void SendPreWillRenderCanvases()
		{
			throw null;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000020AD File Offset: 0x000002AD
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600004C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FF1CB4", Offset = "0x1FF1CB4", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Canvas), Member = "ForceUpdateCanvases", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void SendWillRenderCanvases()
		{
			throw null;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000020B0 File Offset: 0x000002B0
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600004D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FF1D18", Offset = "0x1FF1D18", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void BeginRenderExtraOverlays(int displayIndex)
		{
			throw null;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000020B3 File Offset: 0x000002B3
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600004E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FF1D84", Offset = "0x1FF1D84", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder)
		{
			throw null;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000020B6 File Offset: 0x000002B6
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600004F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FF1DF8", Offset = "0x1FF1DF8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void EndRenderExtraOverlays(int displayIndex)
		{
			throw null;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000020B9 File Offset: 0x000002B9
		[global::Cpp2ILInjected.Token(Token = "0x6000050")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FF1E64", Offset = "0x1FF1E64", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = ".ctor", ReturnType = typeof(void))]
		public Canvas()
		{
			throw null;
		}

		// Token: 0x06000051 RID: 81
		[global::Cpp2ILInjected.Token(Token = "0x6000051")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FF1A98", Offset = "0x1FF1A98", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void get_renderingDisplaySize_Injected(out Vector2 ret);

		// Token: 0x04000007 RID: 7
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000007")]
		private static Canvas.WillRenderCanvases preWillRenderCanvases;

		// Token: 0x04000008 RID: 8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000008")]
		private static Canvas.WillRenderCanvases willRenderCanvases;

		// Token: 0x04000009 RID: 9
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000009")]
		private static Action<int> <externBeginRenderOverlays>k__BackingField;

		// Token: 0x0400000A RID: 10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400000A")]
		private static Action<int, int> <externRenderOverlaysBefore>k__BackingField;

		// Token: 0x0400000B RID: 11
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400000B")]
		private static Action<int> <externEndRenderOverlays>k__BackingField;

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x06000069 RID: 105
		[global::Cpp2ILInjected.Token(Token = "0x2000006")]
		public delegate void WillRenderCanvases();
	}
}
