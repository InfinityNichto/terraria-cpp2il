using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000CF RID: 207
	[NativeHeader("Runtime/Transform/RectTransform.h")]
	[NativeClass("UI::RectTransform")]
	[global::Cpp2ILInjected.Token(Token = "0x20000E4")]
	public sealed class RectTransform : Transform
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060004AE RID: 1198 RVA: 0x00002A58 File Offset: 0x00000C58
		// (remove) Token: 0x060004AF RID: 1199 RVA: 0x00002A5B File Offset: 0x00000C5B
		[global::Cpp2ILInjected.Token(Token = "0x14000002")]
		public static event RectTransform.ReapplyDrivenProperties reapplyDrivenProperties
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60004CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F85CF8", Offset = "0x1F85CF8", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutRebuilder", Member = ".cctor", ReturnType = typeof(void))]
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
			[global::Cpp2ILInjected.Token(Token = "0x60004CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F85DB0", Offset = "0x1F85DB0", Length = "0xB8")]
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

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00002A5E File Offset: 0x00000C5E
		[global::Cpp2ILInjected.Token(Token = "0x170000F8")]
		public Rect rect
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F85E68", Offset = "0x1F85E68", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 52)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x00002A61 File Offset: 0x00000C61
		// (set) Token: 0x060004B2 RID: 1202 RVA: 0x00002A64 File Offset: 0x00000C64
		[global::Cpp2ILInjected.Token(Token = "0x170000F9")]
		public Vector2 anchorMin
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F85F04", Offset = "0x1F85F04", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectTransform), Member = "SetSizeWithCurrentAnchors", MemberParameters = new object[]
			{
				typeof(RectTransform.Axis),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "SetNativeSize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.AspectRatioFitter", Member = "GetSizeDeltaToProduceSize", MemberParameters = new object[]
			{
				typeof(float),
				typeof(int)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.RawImage", Member = "SetNativeSize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "UpdateScrollbarLayout", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Slider", Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "FlipLayoutOnAxis", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(int),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "FlipLayoutAxes", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F85F94", Offset = "0x1F85F94", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 40)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x00002A67 File Offset: 0x00000C67
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x00002A6A File Offset: 0x00000C6A
		[global::Cpp2ILInjected.Token(Token = "0x170000FA")]
		public Vector2 anchorMax
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F86020", Offset = "0x1F86020", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectTransform), Member = "SetSizeWithCurrentAnchors", MemberParameters = new object[]
			{
				typeof(RectTransform.Axis),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.AspectRatioFitter", Member = "GetSizeDeltaToProduceSize", MemberParameters = new object[]
			{
				typeof(float),
				typeof(int)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "UpdateScrollbarLayout", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Slider", Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "FlipLayoutOnAxis", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(int),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "FlipLayoutAxes", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F860B0", Offset = "0x1F860B0", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 42)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x00002A6D File Offset: 0x00000C6D
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x00002A70 File Offset: 0x00000C70
		[global::Cpp2ILInjected.Token(Token = "0x170000FB")]
		public Vector2 anchoredPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8613C", Offset = "0x1F8613C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectTransform), Member = "set_offsetMin", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectTransform), Member = "set_offsetMax", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "SetChildAlongAxisWithScale", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "SetChildAlongAxisWithScale", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(int),
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "OnScroll", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "OnBeginDrag", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "OnDrag", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "SetContentAnchoredPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "LateUpdate", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "UpdatePrevData", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "SetNormalizedPosition", MemberParameters = new object[]
			{
				typeof(float),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "UpdateScrollbarLayout", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "UpdateBounds", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "FlipLayoutOnAxis", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(int),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "FlipLayoutAxes", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 38)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F861CC", Offset = "0x1F861CC", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectTransform), Member = "set_offsetMin", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectTransform), Member = "set_offsetMax", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "CreatePanel", MemberParameters = new object[] { "UnityEngine.UI.DefaultControls.Resources" }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "CreateSlider", MemberParameters = new object[] { "UnityEngine.UI.DefaultControls.Resources" }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "CreateToggle", MemberParameters = new object[] { "UnityEngine.UI.DefaultControls.Resources" }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "CreateDropdown", MemberParameters = new object[] { "UnityEngine.UI.DefaultControls.Resources" }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.AspectRatioFitter", Member = "UpdateRect", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "SetChildAlongAxisWithScale", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "SetChildAlongAxisWithScale", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(int),
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "SetContentAnchoredPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "SetNormalizedPosition", MemberParameters = new object[]
			{
				typeof(float),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "UpdateScrollbarLayout", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "FlipLayoutOnAxis", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(int),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "FlipLayoutAxes", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00002A73 File Offset: 0x00000C73
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x00002A76 File Offset: 0x00000C76
		[global::Cpp2ILInjected.Token(Token = "0x170000FC")]
		public Vector2 sizeDelta
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F86258", Offset = "0x1F86258", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectTransform), Member = "set_offsetMin", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectTransform), Member = "set_offsetMax", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectTransform), Member = "SetSizeWithCurrentAnchors", MemberParameters = new object[]
			{
				typeof(RectTransform.Axis),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "CreateDropdown", MemberParameters = new object[] { "UnityEngine.UI.DefaultControls.Resources" }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "CreateScrollView", MemberParameters = new object[] { "UnityEngine.UI.DefaultControls.Resources" }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.HorizontalOrVerticalLayoutGroup", Member = "SetChildrenAlongAxis", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.HorizontalOrVerticalLayoutGroup", Member = "GetChildSizes", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(int),
				typeof(bool),
				typeof(bool),
				typeof(ref float),
				typeof(ref float),
				typeof(ref float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "SetChildAlongAxisWithScale", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "SetChildAlongAxisWithScale", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(int),
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Scrollbar", Member = "UpdateDrag", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "UpdateScrollbarLayout", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "FlipLayoutAxes", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 30)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F862E8", Offset = "0x1F862E8", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 46)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00002A79 File Offset: 0x00000C79
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x00002A7C File Offset: 0x00000C7C
		[global::Cpp2ILInjected.Token(Token = "0x170000FD")]
		public Vector2 pivot
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F86374", Offset = "0x1F86374", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectTransform), Member = "set_offsetMin", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectTransform), Member = "set_offsetMax", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "PreserveSpriteAspectRatio", MemberParameters = new object[]
			{
				typeof(ref Rect),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new object[]
			{
				"UnityEngine.UI.VertexHelper",
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "IsRaycastLocationValid", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Camera)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "SetChildAlongAxisWithScale", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "SetChildAlongAxisWithScale", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(int),
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "UpdateBounds", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Text", Member = "GetGenerationSettings", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = "UnityEngine.TextGenerationSettings")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "FlipLayoutOnAxis", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(int),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "FlipLayoutAxes", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F86404", Offset = "0x1F86404", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "CreateDropdown", MemberParameters = new object[] { "UnityEngine.UI.DefaultControls.Resources" }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "CreateScrollView", MemberParameters = new object[] { "UnityEngine.UI.DefaultControls.Resources" }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "FlipLayoutOnAxis", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(int),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "FlipLayoutAxes", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000FB RID: 251
		// (set) Token: 0x060004BB RID: 1211 RVA: 0x00002A7F File Offset: 0x00000C7F
		[global::Cpp2ILInjected.Token(Token = "0x170000FE")]
		public Vector2 offsetMin
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F86490", Offset = "0x1F86490", Length = "0xF4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "CreateToggle", MemberParameters = new object[] { "UnityEngine.UI.DefaultControls.Resources" }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "CreateInputField", MemberParameters = new object[] { "UnityEngine.UI.DefaultControls.Resources" }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "CreateDropdown", MemberParameters = new object[] { "UnityEngine.UI.DefaultControls.Resources" }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000FC RID: 252
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x00002A82 File Offset: 0x00000C82
		[global::Cpp2ILInjected.Token(Token = "0x170000FF")]
		public Vector2 offsetMax
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F86584", Offset = "0x1F86584", Length = "0xFC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "CreateToggle", MemberParameters = new object[] { "UnityEngine.UI.DefaultControls.Resources" }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "CreateInputField", MemberParameters = new object[] { "UnityEngine.UI.DefaultControls.Resources" }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "CreateDropdown", MemberParameters = new object[] { "UnityEngine.UI.DefaultControls.Resources" }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00002A85 File Offset: 0x00000C85
		[global::Cpp2ILInjected.Token(Token = "0x60004D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F86680", Offset = "0x1F86680", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectTransform), Member = "GetWorldCorners", MemberParameters = new object[] { typeof(Vector3[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_x", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_y", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_xMax", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_yMax", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void GetLocalCorners(Vector3[] fourCornersArray)
		{
			throw null;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00002A88 File Offset: 0x00000C88
		[global::Cpp2ILInjected.Token(Token = "0x60004DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F86790", Offset = "0x1F86790", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.RectangularVertexClipper", Member = "GetCanvasRect", MemberParameters = new object[]
		{
			typeof(RectTransform),
			"UnityEngine.Canvas"
		}, ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.MaskableGraphic", Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.RectMask2D", Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "GetBounds", ReturnType = typeof(Bounds))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "GetLocalCorners", MemberParameters = new object[] { typeof(Vector3[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void GetWorldCorners(Vector3[] fourCornersArray)
		{
			throw null;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00002A8B File Offset: 0x00000C8B
		[global::Cpp2ILInjected.Token(Token = "0x60004DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F868C8", Offset = "0x1F868C8", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.AspectRatioFitter", Member = "UpdateRect", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ContentSizeFitter", Member = "HandleSelfFittingAlongAxis", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "GetParentSize", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_anchorMax", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_anchorMin", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void SetSizeWithCurrentAnchors(RectTransform.Axis axis, float size)
		{
			throw null;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00002A8E File Offset: 0x00000C8E
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60004DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F86AD8", Offset = "0x1F86AD8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void SendReapplyDrivenProperties(RectTransform driven)
		{
			throw null;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00002A91 File Offset: 0x00000C91
		[global::Cpp2ILInjected.Token(Token = "0x60004DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F869C0", Offset = "0x1F869C0", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectTransform), Member = "SetSizeWithCurrentAnchors", MemberParameters = new object[]
		{
			typeof(RectTransform.Axis),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_size", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private Vector2 GetParentSize()
		{
			throw null;
		}

		// Token: 0x060004C2 RID: 1218
		[global::Cpp2ILInjected.Token(Token = "0x60004DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F85EC0", Offset = "0x1F85EC0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void get_rect_Injected(out Rect ret);

		// Token: 0x060004C3 RID: 1219
		[global::Cpp2ILInjected.Token(Token = "0x60004DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F85F50", Offset = "0x1F85F50", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void get_anchorMin_Injected(out Vector2 ret);

		// Token: 0x060004C4 RID: 1220
		[global::Cpp2ILInjected.Token(Token = "0x60004E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F85FDC", Offset = "0x1F85FDC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void set_anchorMin_Injected(ref Vector2 value);

		// Token: 0x060004C5 RID: 1221
		[global::Cpp2ILInjected.Token(Token = "0x60004E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8606C", Offset = "0x1F8606C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void get_anchorMax_Injected(out Vector2 ret);

		// Token: 0x060004C6 RID: 1222
		[global::Cpp2ILInjected.Token(Token = "0x60004E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F860F8", Offset = "0x1F860F8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void set_anchorMax_Injected(ref Vector2 value);

		// Token: 0x060004C7 RID: 1223
		[global::Cpp2ILInjected.Token(Token = "0x60004E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F86188", Offset = "0x1F86188", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void get_anchoredPosition_Injected(out Vector2 ret);

		// Token: 0x060004C8 RID: 1224
		[global::Cpp2ILInjected.Token(Token = "0x60004E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F86214", Offset = "0x1F86214", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void set_anchoredPosition_Injected(ref Vector2 value);

		// Token: 0x060004C9 RID: 1225
		[global::Cpp2ILInjected.Token(Token = "0x60004E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F862A4", Offset = "0x1F862A4", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void get_sizeDelta_Injected(out Vector2 ret);

		// Token: 0x060004CA RID: 1226
		[global::Cpp2ILInjected.Token(Token = "0x60004E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F86330", Offset = "0x1F86330", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void set_sizeDelta_Injected(ref Vector2 value);

		// Token: 0x060004CB RID: 1227
		[global::Cpp2ILInjected.Token(Token = "0x60004E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F863C0", Offset = "0x1F863C0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void get_pivot_Injected(out Vector2 ret);

		// Token: 0x060004CC RID: 1228
		[global::Cpp2ILInjected.Token(Token = "0x60004E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8644C", Offset = "0x1F8644C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void set_pivot_Injected(ref Vector2 value);

		// Token: 0x040003BE RID: 958
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40003F8")]
		private static RectTransform.ReapplyDrivenProperties reapplyDrivenProperties;

		// Token: 0x02000175 RID: 373
		[global::Cpp2ILInjected.Token(Token = "0x20000E5")]
		public enum Axis
		{
			// Token: 0x0400066B RID: 1643
			[global::Cpp2ILInjected.Token(Token = "0x40003FA")]
			Horizontal,
			// Token: 0x0400066C RID: 1644
			[global::Cpp2ILInjected.Token(Token = "0x40003FB")]
			Vertical
		}

		// Token: 0x02000176 RID: 374
		// (Invoke) Token: 0x060006D1 RID: 1745
		[global::Cpp2ILInjected.Token(Token = "0x20000E6")]
		public delegate void ReapplyDrivenProperties(RectTransform driven);
	}
}
