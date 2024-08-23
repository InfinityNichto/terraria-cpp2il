using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000089 RID: 137
	[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
	[UsedByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x2000097")]
	public class Behaviour : Component
	{
		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600029A RID: 666
		// (set) Token: 0x0600029B RID: 667
		[RequiredByNativeCode]
		[NativeProperty]
		[global::Cpp2ILInjected.Token(Token = "0x170000A2")]
		public extern bool enabled
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F79708", Offset = "0x1F79708", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "ShouldActivateModule", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchControl", Member = "Setup", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchControl", Member = "OnDrawGizmosSelected", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchControl", Member = "OnDrawGizmos", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "SubmitControlStates", MemberParameters = new object[]
			{
				typeof(ulong),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "CommitControlStates", MemberParameters = new object[]
			{
				typeof(ulong),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "SendTouchBegan", MemberParameters = new object[] { "InControl.Touch" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "SendTouchMoved", MemberParameters = new object[] { "InControl.Touch" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "SendTouchEnded", MemberParameters = new object[] { "InControl.Touch" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "Raycast", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Camera)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "Validate", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(char)
			}, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Selectable", Member = "OnCanvasGroupChanged", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.BaseInputModule", Member = "ShouldActivateModule", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x60002A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F79744", Offset = "0x1F79744", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ScreenPostProcessor", Member = "EndUpdate", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "set_controlsEnabled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.SingletonMonoBehavior`1", Member = "get_EnforceSingleton", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.SingletonMonoBehavior`1", Member = "Awake", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Awake", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "RefreshShownValue", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "AddItem", MemberParameters = new object[]
			{
				"UnityEngine.UI.Dropdown.OptionData",
				typeof(bool),
				"UnityEngine.UI.Dropdown.DropdownItem",
				"System.Collections.Generic.List`1<DropdownItem>"
			}, ReturnType = "UnityEngine.UI.Dropdown.DropdownItem")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateLabel", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "DeactivateInputField", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.AspectRatioFitter", Member = "Start", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600029C RID: 668
		[NativeProperty]
		[global::Cpp2ILInjected.Token(Token = "0x170000A3")]
		public extern bool isActiveAndEnabled
		{
			[NativeMethod("IsAddedToManager")]
			[global::Cpp2ILInjected.Token(Token = "0x60002AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F79788", Offset = "0x1F79788", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "set_raycastTarget", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "SetRaycastDirty", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "CacheCanvas", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "Raycast", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Camera)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutRebuilder.<>c", Member = "<StripDisabledBehavioursFromList>b__10_0", MemberParameters = new object[] { typeof(Component) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutRebuilder", Member = "MarkLayoutForRebuild", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutRebuilder", Member = "ValidController", MemberParameters = new object[]
			{
				typeof(RectTransform),
				"System.Collections.Generic.List`1<Component>"
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutUtility", Member = "GetLayoutProperty", MemberParameters = new object[]
			{
				typeof(RectTransform),
				"System.Func`2<ILayoutElement, Single>",
				typeof(float),
				"UnityEngine.UI.ILayoutElement&"
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Mask", Member = "IsRaycastLocationValid", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Camera)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.MaskableGraphic", Member = "OnTransformParentChanged", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.MaskableGraphic", Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.MaskUtilities", Member = "GetRectMaskForClippable", MemberParameters = new object[] { "UnityEngine.UI.IClippable" }, ReturnType = "UnityEngine.UI.RectMask2D")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.RectMask2D", Member = "IsRaycastLocationValid", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Camera)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Selectable", Member = "TriggerAnimation", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Text", Member = "set_font", MemberParameters = new object[] { "UnityEngine.Font" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Toggle", Member = "Set", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.ExecuteEvents", Member = "ShouldSendToComponent", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(Component) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.UIBehaviour", Member = "IsActive", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00002572 File Offset: 0x00000772
		[global::Cpp2ILInjected.Token(Token = "0x60002AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F760A4", Offset = "0x1F760A4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Canvas", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = ".ctor", ReturnType = typeof(void))]
		public Behaviour()
		{
			throw null;
		}
	}
}
