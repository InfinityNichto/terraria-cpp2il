using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x020000B3 RID: 179
	[NativeHeader("Runtime/Export/Scripting/Component.bindings.h")]
	[RequiredByNativeCode]
	[NativeClass("Unity::Component")]
	[global::Cpp2ILInjected.Token(Token = "0x20000C4")]
	public class Component : Object
	{
		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000349 RID: 841
		[global::Cpp2ILInjected.Token(Token = "0x170000B4")]
		public extern Transform transform
		{
			[FreeFunction("GetTransform", HasExplicitThis = true, ThrowsException = true)]
			[global::Cpp2ILInjected.Token(Token = "0x600035B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7DF84", Offset = "0x1F7DF84", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 118)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600034A RID: 842
		[global::Cpp2ILInjected.Token(Token = "0x170000B5")]
		public extern GameObject gameObject
		{
			[FreeFunction("GetGameObject", HasExplicitThis = true)]
			[global::Cpp2ILInjected.Token(Token = "0x600035C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7DFC0", Offset = "0x1F7DFC0", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 107)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x000026DD File Offset: 0x000008DD
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		[global::Cpp2ILInjected.Token(Token = "0x600035D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7DFFC", Offset = "0x1F7DFFC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "get_isRootLayoutGroup", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutRebuilder", Member = "PerformLayoutCalculation", MemberParameters = new object[]
		{
			typeof(RectTransform),
			"UnityEngine.Events.UnityAction`1<Component>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Component GetComponent(Type type)
		{
			throw null;
		}

		// Token: 0x0600034C RID: 844
		[FreeFunction(HasExplicitThis = true, ThrowsException = true)]
		[global::Cpp2ILInjected.Token(Token = "0x600035E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7E06C", Offset = "0x1F7E06C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		internal extern void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue);

		// Token: 0x0600034D RID: 845 RVA: 0x000026E0 File Offset: 0x000008E0
		[global::Cpp2ILInjected.Token(Token = "0x600035F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1577EAC", Offset = "0x1577EAC", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 33)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponentFastPath", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public T GetComponent<T>()
		{
			throw null;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x000026E3 File Offset: 0x000008E3
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		[global::Cpp2ILInjected.Token(Token = "0x6000360")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7E0C0", Offset = "0x1F7E0C0", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Component GetComponentInChildren(Type t, bool includeInactive)
		{
			throw null;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x000026E6 File Offset: 0x000008E6
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x6000361")]
		[global::Cpp2ILInjected.Address(RVA = "0x1577F44", Offset = "0x1577F44", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetupTemplate", MemberParameters = new object[] { "UnityEngine.Canvas" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(Component))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public T GetComponentInChildren<T>()
		{
			throw null;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x000026E9 File Offset: 0x000008E9
		[global::Cpp2ILInjected.Token(Token = "0x6000362")]
		[global::Cpp2ILInjected.Address(RVA = "0x157817C", Offset = "0x157817C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public T[] GetComponentsInChildren<T>(bool includeInactive)
		{
			throw null;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x000026EC File Offset: 0x000008EC
		[global::Cpp2ILInjected.Token(Token = "0x6000363")]
		[global::Cpp2ILInjected.Address(RVA = "0x15781CC", Offset = "0x15781CC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void GetComponentsInChildren<T>(bool includeInactive, List<T> result)
		{
			throw null;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x000026EF File Offset: 0x000008EF
		[global::Cpp2ILInjected.Token(Token = "0x6000364")]
		[global::Cpp2ILInjected.Address(RVA = "0x15781B0", Offset = "0x15781B0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.MaskUtilities", Member = "Notify2DMaskStateChanged", MemberParameters = new object[] { typeof(Component) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.MaskUtilities", Member = "NotifyStencilStateChanged", MemberParameters = new object[] { typeof(Component) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void GetComponentsInChildren<T>(List<T> results)
		{
			throw null;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x000026F2 File Offset: 0x000008F2
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		[global::Cpp2ILInjected.Token(Token = "0x6000365")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7E140", Offset = "0x1F7E140", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Component), Member = "GetComponentInParent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Component GetComponentInParent(Type t, bool includeInactive)
		{
			throw null;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x000026F5 File Offset: 0x000008F5
		[global::Cpp2ILInjected.Token(Token = "0x6000366")]
		[global::Cpp2ILInjected.Address(RVA = "0x157800C", Offset = "0x157800C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown.DropdownItem", Member = "OnCancel", MemberParameters = new object[] { "UnityEngine.EventSystems.BaseEventData" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponentInParent", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(Component))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public T GetComponentInParent<T>()
		{
			throw null;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x000026F8 File Offset: 0x000008F8
		[global::Cpp2ILInjected.Token(Token = "0x6000367")]
		[global::Cpp2ILInjected.Address(RVA = "0x157821C", Offset = "0x157821C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public T[] GetComponentsInParent<T>(bool includeInactive)
		{
			throw null;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x000026FB File Offset: 0x000008FB
		[global::Cpp2ILInjected.Token(Token = "0x6000368")]
		[global::Cpp2ILInjected.Address(RVA = "0x1578250", Offset = "0x1578250", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.MaskUtilities", Member = "FindRootSortOverrideCanvas", MemberParameters = new object[] { typeof(Transform) }, ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.MaskUtilities", Member = "GetRectMasksForClip", MemberParameters = new object[] { "UnityEngine.UI.RectMask2D", "System.Collections.Generic.List`1<RectMask2D>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void GetComponentsInParent<T>(bool includeInactive, List<T> results)
		{
			throw null;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x000026FE File Offset: 0x000008FE
		[global::Cpp2ILInjected.Token(Token = "0x6000369")]
		[global::Cpp2ILInjected.Address(RVA = "0x1578208", Offset = "0x1578208", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.BaseRaycaster", Member = "get_rootRaycaster", ReturnType = "UnityEngine.EventSystems.BaseRaycaster")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public T[] GetComponentsInParent<T>()
		{
			throw null;
		}

		// Token: 0x06000358 RID: 856
		[FreeFunction(HasExplicitThis = true, ThrowsException = true)]
		[global::Cpp2ILInjected.Token(Token = "0x600036A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7E1C0", Offset = "0x1F7E1C0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.List`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void GetComponentsForListInternal(Type searchType, object resultList);

		// Token: 0x06000359 RID: 857 RVA: 0x00002701 File Offset: 0x00000901
		[global::Cpp2ILInjected.Token(Token = "0x600036B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7E214", Offset = "0x1F7E214", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "get_materialForRendering", ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "DoMeshGeneration", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "DoLegacyMeshGeneration", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutRebuilder", Member = "PerformLayoutControl", MemberParameters = new object[]
		{
			typeof(RectTransform),
			"UnityEngine.Events.UnityAction`1<Component>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutRebuilder", Member = "PerformLayoutCalculation", MemberParameters = new object[]
		{
			typeof(RectTransform),
			"UnityEngine.Events.UnityAction`1<Component>"
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void GetComponents(Type type, List<Component> results)
		{
			throw null;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00002704 File Offset: 0x00000904
		[global::Cpp2ILInjected.Token(Token = "0x600036C")]
		[global::Cpp2ILInjected.Address(RVA = "0x15780F8", Offset = "0x15780F8", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "Raycast", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Camera)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.MaskUtilities", Member = "GetStencilDepth", MemberParameters = new object[]
		{
			typeof(Transform),
			typeof(Transform)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Selectable", Member = "OnCanvasGroupChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "UpdateModules", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponentsForListInternal", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void GetComponents<T>(List<T> results)
		{
			throw null;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00002707 File Offset: 0x00000907
		[global::Cpp2ILInjected.Token(Token = "0x600036D")]
		[global::Cpp2ILInjected.Address(RVA = "0x15780D4", Offset = "0x15780D4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetupTemplate", MemberParameters = new object[] { "UnityEngine.Canvas" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new object[] { "UnityEngine.Canvas" }, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.BaseInputModule", Member = "get_input", ReturnType = "UnityEngine.EventSystems.BaseInput")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public T[] GetComponents<T>()
		{
			throw null;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000270A File Offset: 0x0000090A
		[global::Cpp2ILInjected.Token(Token = "0x600036E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F797C4", Offset = "0x1F797C4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Camera), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Behaviour), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Transform), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Component()
		{
			throw null;
		}
	}
}
