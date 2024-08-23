using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Events;
using UnityEngine.Pool;

namespace UnityEngine.UI
{
	// Token: 0x02000026 RID: 38
	[global::Cpp2ILInjected.Token(Token = "0x200004E")]
	public class LayoutRebuilder : ICanvasElement
	{
		// Token: 0x060002B4 RID: 692 RVA: 0x00002818 File Offset: 0x00000A18
		[global::Cpp2ILInjected.Token(Token = "0x60002FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCB35C", Offset = "0x1FCB35C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Initialize(RectTransform controller)
		{
			throw null;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000281B File Offset: 0x00000A1B
		[global::Cpp2ILInjected.Token(Token = "0x60002FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCB388", Offset = "0x1FCB388", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Clear()
		{
			throw null;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000281E File Offset: 0x00000A1E
		[global::Cpp2ILInjected.Token(Token = "0x60002FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCB394", Offset = "0x1FCB394", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectPool<>), Member = ".ctor", MemberParameters = new object[]
		{
			"System.Func`1<T>",
			"System.Action`1<T>",
			"System.Action`1<T>",
			"System.Action`1<T>",
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform.ReapplyDrivenProperties), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "add_reapplyDrivenProperties", MemberParameters = new object[] { typeof(RectTransform.ReapplyDrivenProperties) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		static LayoutRebuilder()
		{
			throw null;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00002821 File Offset: 0x00000A21
		[global::Cpp2ILInjected.Token(Token = "0x60002FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCB570", Offset = "0x1FCB570", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void ReapplyDrivenProperties(RectTransform driven)
		{
			throw null;
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x00002824 File Offset: 0x00000A24
		[global::Cpp2ILInjected.Token(Token = "0x170000D4")]
		public Transform transform
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCB5C4", Offset = "0x1FCB5C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00002827 File Offset: 0x00000A27
		[global::Cpp2ILInjected.Token(Token = "0x60002FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCB5CC", Offset = "0x1FCB5CC", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool IsDestroyed()
		{
			throw null;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0000282A File Offset: 0x00000A2A
		[global::Cpp2ILInjected.Token(Token = "0x6000300")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCB62C", Offset = "0x1FCB62C", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutRebuilder), Member = "PerformLayoutControl", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(UnityAction<Component>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutRebuilder), Member = "PerformLayoutCalculation", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(UnityAction<Component>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Predicate<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAll", MemberParameters = new object[] { typeof(Predicate<object>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static void StripDisabledBehavioursFromList(List<Component> components)
		{
			throw null;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000282D File Offset: 0x00000A2D
		[global::Cpp2ILInjected.Token(Token = "0x6000301")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCB724", Offset = "0x1FCB724", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectPool<>), Member = "Get", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutRebuilder), Member = "Rebuild", MemberParameters = new object[] { typeof(CanvasUpdate) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectPool<>), Member = "Release", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot)
		{
			throw null;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00002830 File Offset: 0x00000A30
		[global::Cpp2ILInjected.Token(Token = "0x6000302")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCB7F4", Offset = "0x1FCB7F4", Length = "0x2A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutRebuilder), Member = "ForceRebuildLayoutImmediate", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityAction<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutRebuilder), Member = "PerformLayoutCalculation", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(UnityAction<Component>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutRebuilder), Member = "PerformLayoutControl", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(UnityAction<Component>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public void Rebuild(CanvasUpdate executing)
		{
			throw null;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00002833 File Offset: 0x00000A33
		[global::Cpp2ILInjected.Token(Token = "0x6000303")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCBD88", Offset = "0x1FCBD88", Length = "0x3C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutRebuilder), Member = "Rebuild", MemberParameters = new object[] { typeof(CanvasUpdate) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutRebuilder), Member = "PerformLayoutControl", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(UnityAction<Component>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Get", ReturnType = "TCollection")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponents", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(List<Component>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutRebuilder), Member = "StripDisabledBehavioursFromList", MemberParameters = new object[] { typeof(List<Component>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutRebuilder), Member = "PerformLayoutControl", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(UnityAction<Component>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Release", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		private void PerformLayoutControl(RectTransform rect, UnityAction<Component> action)
		{
			throw null;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00002836 File Offset: 0x00000A36
		[global::Cpp2ILInjected.Token(Token = "0x6000304")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCBA94", Offset = "0x1FCBA94", Length = "0x2F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutRebuilder), Member = "Rebuild", MemberParameters = new object[] { typeof(CanvasUpdate) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutRebuilder), Member = "PerformLayoutCalculation", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(UnityAction<Component>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Get", ReturnType = "TCollection")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponents", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(List<Component>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutRebuilder), Member = "StripDisabledBehavioursFromList", MemberParameters = new object[] { typeof(List<Component>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponent", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Component))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutRebuilder), Member = "PerformLayoutCalculation", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(UnityAction<Component>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Release", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private void PerformLayoutCalculation(RectTransform rect, UnityAction<Component> action)
		{
			throw null;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00002839 File Offset: 0x00000A39
		[global::Cpp2ILInjected.Token(Token = "0x6000305")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC6BA0", Offset = "0x1FC6BA0", Length = "0x3DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "SetLayoutDirty", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "OnBeforeTransformParentChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AspectRatioFitter), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSizeFitter), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSizeFitter), Member = "SetDirty", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutElement), Member = "SetDirty", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutGroup.<DelayedSetDirty>d__56", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutGroup), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutGroup), Member = "SetDirty", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutRebuilder), Member = "ReapplyDrivenProperties", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "SetDirty", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Get", ReturnType = "TCollection")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_parent", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponents", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(List<Component>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutRebuilder), Member = "ValidController", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(List<Component>)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutRootForRebuild", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Release", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public static void MarkLayoutForRebuild(RectTransform rect)
		{
			throw null;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0000283C File Offset: 0x00000A3C
		[global::Cpp2ILInjected.Token(Token = "0x6000306")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCC14C", Offset = "0x1FCC14C", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponents", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(List<Component>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static bool ValidController(RectTransform layoutRoot, List<Component> comps)
		{
			throw null;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0000283F File Offset: 0x00000A3F
		[global::Cpp2ILInjected.Token(Token = "0x6000307")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCC334", Offset = "0x1FCC334", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectPool<>), Member = "Get", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasUpdateRegistry), Member = "TryRegisterCanvasElementForLayoutRebuild", MemberParameters = new object[] { typeof(ICanvasElement) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectPool<>), Member = "Release", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void MarkLayoutRootForRebuild(RectTransform controller)
		{
			throw null;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00002842 File Offset: 0x00000A42
		[global::Cpp2ILInjected.Token(Token = "0x6000308")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCC484", Offset = "0x1FCC484", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectPool<>), Member = "Release", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void LayoutComplete()
		{
			throw null;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00002845 File Offset: 0x00000A45
		[global::Cpp2ILInjected.Token(Token = "0x6000309")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCC4FC", Offset = "0x1FCC4FC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void GraphicUpdateComplete()
		{
			throw null;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00002848 File Offset: 0x00000A48
		[global::Cpp2ILInjected.Token(Token = "0x600030A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCC500", Offset = "0x1FCC500", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000284B File Offset: 0x00000A4B
		[global::Cpp2ILInjected.Token(Token = "0x600030B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCC508", Offset = "0x1FCC508", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000284E File Offset: 0x00000A4E
		[global::Cpp2ILInjected.Token(Token = "0x600030C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCC550", Offset = "0x1FCC550", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00002851 File Offset: 0x00000A51
		[global::Cpp2ILInjected.Token(Token = "0x600030D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCC5BC", Offset = "0x1FCC5BC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public LayoutRebuilder()
		{
			throw null;
		}

		// Token: 0x040000F4 RID: 244
		[global::Cpp2ILInjected.Token(Token = "0x4000180")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private RectTransform m_ToRebuild;

		// Token: 0x040000F5 RID: 245
		[global::Cpp2ILInjected.Token(Token = "0x4000181")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int m_CachedHashFromTransform;

		// Token: 0x040000F6 RID: 246
		[global::Cpp2ILInjected.Token(Token = "0x4000182")]
		private static ObjectPool<LayoutRebuilder> s_Rebuilders;

		// Token: 0x020000A7 RID: 167
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200004F")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060006AA RID: 1706 RVA: 0x0000338E File Offset: 0x0000158E
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x600030E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCC5C4", Offset = "0x1FCC5C4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x060006AB RID: 1707 RVA: 0x00003391 File Offset: 0x00001591
			[global::Cpp2ILInjected.Token(Token = "0x600030F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCC620", Offset = "0x1FCC620", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x060006AC RID: 1708 RVA: 0x00003394 File Offset: 0x00001594
			[global::Cpp2ILInjected.Token(Token = "0x6000310")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCC628", Offset = "0x1FCC628", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal LayoutRebuilder <.cctor>b__5_0()
			{
				throw null;
			}

			// Token: 0x060006AD RID: 1709 RVA: 0x00003397 File Offset: 0x00001597
			[global::Cpp2ILInjected.Token(Token = "0x6000311")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCC67C", Offset = "0x1FCC67C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal void <.cctor>b__5_1(LayoutRebuilder x)
			{
				throw null;
			}

			// Token: 0x060006AE RID: 1710 RVA: 0x0000339A File Offset: 0x0000159A
			[global::Cpp2ILInjected.Token(Token = "0x6000312")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCC688", Offset = "0x1FCC688", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <StripDisabledBehavioursFromList>b__10_0(Component e)
			{
				throw null;
			}

			// Token: 0x060006AF RID: 1711 RVA: 0x0000339D File Offset: 0x0000159D
			[global::Cpp2ILInjected.Token(Token = "0x6000313")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCC714", Offset = "0x1FCC714", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			internal void <Rebuild>b__12_0(Component e)
			{
				throw null;
			}

			// Token: 0x060006B0 RID: 1712 RVA: 0x000033A0 File Offset: 0x000015A0
			[global::Cpp2ILInjected.Token(Token = "0x6000314")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCC7C8", Offset = "0x1FCC7C8", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			internal void <Rebuild>b__12_1(Component e)
			{
				throw null;
			}

			// Token: 0x060006B1 RID: 1713 RVA: 0x000033A3 File Offset: 0x000015A3
			[global::Cpp2ILInjected.Token(Token = "0x6000315")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCC87C", Offset = "0x1FCC87C", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			internal void <Rebuild>b__12_2(Component e)
			{
				throw null;
			}

			// Token: 0x060006B2 RID: 1714 RVA: 0x000033A6 File Offset: 0x000015A6
			[global::Cpp2ILInjected.Token(Token = "0x6000316")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCC934", Offset = "0x1FCC934", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			internal void <Rebuild>b__12_3(Component e)
			{
				throw null;
			}

			// Token: 0x040002D5 RID: 725
			[global::Cpp2ILInjected.Token(Token = "0x4000183")]
			public static readonly LayoutRebuilder.<>c <>9;

			// Token: 0x040002D6 RID: 726
			[global::Cpp2ILInjected.Token(Token = "0x4000184")]
			public static Predicate<Component> <>9__10_0;

			// Token: 0x040002D7 RID: 727
			[global::Cpp2ILInjected.Token(Token = "0x4000185")]
			public static UnityAction<Component> <>9__12_0;

			// Token: 0x040002D8 RID: 728
			[global::Cpp2ILInjected.Token(Token = "0x4000186")]
			public static UnityAction<Component> <>9__12_1;

			// Token: 0x040002D9 RID: 729
			[global::Cpp2ILInjected.Token(Token = "0x4000187")]
			public static UnityAction<Component> <>9__12_2;

			// Token: 0x040002DA RID: 730
			[global::Cpp2ILInjected.Token(Token = "0x4000188")]
			public static UnityAction<Component> <>9__12_3;
		}
	}
}
