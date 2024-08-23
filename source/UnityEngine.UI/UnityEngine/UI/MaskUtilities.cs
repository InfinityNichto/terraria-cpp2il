using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Pool;

namespace UnityEngine.UI
{
	// Token: 0x0200002B RID: 43
	[global::Cpp2ILInjected.Token(Token = "0x2000056")]
	public class MaskUtilities
	{
		// Token: 0x060002F9 RID: 761 RVA: 0x000028E7 File Offset: 0x00000AE7
		[global::Cpp2ILInjected.Token(Token = "0x6000353")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCF4C8", Offset = "0x1FCF4C8", Length = "0x24C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectMask2D), Member = "set_padding", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectMask2D), Member = "set_softness", MemberParameters = new object[] { typeof(Vector2Int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectMask2D), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectMask2D), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Get", ReturnType = "TCollection")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponentsInChildren", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.List`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Release", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static void Notify2DMaskStateChanged(Component mask)
		{
			throw null;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x000028EA File Offset: 0x00000AEA
		[global::Cpp2ILInjected.Token(Token = "0x6000354")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCDCBC", Offset = "0x1FCDCBC", Length = "0x248")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mask), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mask), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskableGraphic), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskableGraphic), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Get", ReturnType = "TCollection")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponentsInChildren", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.List`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Release", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static void NotifyStencilStateChanged(Component mask)
		{
			throw null;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x000028ED File Offset: 0x00000AED
		[global::Cpp2ILInjected.Token(Token = "0x6000355")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCE3DC", Offset = "0x1FCE3DC", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mask), Member = "GetModifiedMaterial", MemberParameters = new object[] { typeof(Material) }, ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskableGraphic), Member = "GetModifiedMaterial", MemberParameters = new object[] { typeof(Material) }, ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Get", ReturnType = "TCollection")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponentsInParent", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(bool),
			"System.Collections.Generic.List`1<T>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_overrideSorting", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Release", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static Transform FindRootSortOverrideCanvas(Transform start)
		{
			throw null;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x000028F0 File Offset: 0x00000AF0
		[global::Cpp2ILInjected.Token(Token = "0x6000356")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCE568", Offset = "0x1FCE568", Length = "0x26C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mask), Member = "GetModifiedMaterial", MemberParameters = new object[] { typeof(Material) }, ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskableGraphic), Member = "GetModifiedMaterial", MemberParameters = new object[] { typeof(Material) }, ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_parent", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Get", ReturnType = "TCollection")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.List`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mask), Member = "get_graphic", ReturnType = typeof(Graphic))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Release", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static int GetStencilDepth(Transform transform, Transform stopAfter)
		{
			throw null;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x000028F3 File Offset: 0x00000AF3
		[global::Cpp2ILInjected.Token(Token = "0x6000357")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCF714", Offset = "0x1FCF714", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskUtilities), Member = "GetRectMaskForClippable", MemberParameters = new object[] { typeof(IClippable) }, ReturnType = typeof(RectMask2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskUtilities), Member = "GetRectMasksForClip", MemberParameters = new object[]
		{
			typeof(RectMask2D),
			typeof(List<RectMask2D>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_parent", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static bool IsDescendantOrSelf(Transform father, Transform child)
		{
			throw null;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x000028F6 File Offset: 0x00000AF6
		[global::Cpp2ILInjected.Token(Token = "0x6000358")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCEF44", Offset = "0x1FCEF44", Length = "0x3F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskableGraphic), Member = "UpdateClipParent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Get", ReturnType = "TCollection")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponentsInParent", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(bool),
			"System.Collections.Generic.List`1<T>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Release", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskUtilities), Member = "IsDescendantOrSelf", MemberParameters = new object[]
		{
			typeof(Transform),
			typeof(Transform)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_overrideSorting", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public static RectMask2D GetRectMaskForClippable(IClippable clippable)
		{
			throw null;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x000028F9 File Offset: 0x00000AF9
		[global::Cpp2ILInjected.Token(Token = "0x6000359")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCF85C", Offset = "0x1FCF85C", Length = "0x334")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectMask2D), Member = "PerformClipping", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Get", ReturnType = "TCollection")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponentsInParent", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(bool),
			"System.Collections.Generic.List`1<T>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskUtilities), Member = "IsDescendantOrSelf", MemberParameters = new object[]
		{
			typeof(Transform),
			typeof(Transform)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_overrideSorting", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Release", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static void GetRectMasksForClip(RectMask2D clipper, List<RectMask2D> masks)
		{
			throw null;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x000028FC File Offset: 0x00000AFC
		[global::Cpp2ILInjected.Token(Token = "0x600035A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCFB90", Offset = "0x1FCFB90", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MaskUtilities()
		{
			throw null;
		}
	}
}
