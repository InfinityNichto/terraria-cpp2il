using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x02000247 RID: 583
[global::Cpp2ILInjected.Token(Token = "0x2000300")]
public static class TransformExtensions
{
	// Token: 0x06001077 RID: 4215 RVA: 0x00024C47 File Offset: 0x00022E47
	[global::Cpp2ILInjected.Token(Token = "0x60011C6")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6EC8C", Offset = "0xA6EC8C", Length = "0xA8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TransformExtensions), Member = "FindAllInChildren", MemberParameters = new object[]
	{
		typeof(Transform),
		typeof(string),
		typeof(List<Transform>)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "ToArray", ReturnType = "T[]")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public static Transform[] FindAllInChildren(this Transform transform, string name)
	{
		throw null;
	}

	// Token: 0x06001078 RID: 4216 RVA: 0x00024C4A File Offset: 0x00022E4A
	[global::Cpp2ILInjected.Token(Token = "0x60011C7")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6ED34", Offset = "0xA6ED34", Length = "0x120")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TransformExtensions), Member = "FindAllInChildren", MemberParameters = new object[]
	{
		typeof(Transform),
		typeof(string)
	}, ReturnType = typeof(Transform[]))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TransformExtensions), Member = "FindAllInChildren", MemberParameters = new object[]
	{
		typeof(Transform),
		typeof(string),
		typeof(List<Transform>)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Transform))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "get_name", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TransformExtensions), Member = "FindAllInChildren", MemberParameters = new object[]
	{
		typeof(Transform),
		typeof(string),
		typeof(List<Transform>)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private static void FindAllInChildren(this Transform transform, string name, List<Transform> results)
	{
		throw null;
	}

	// Token: 0x06001079 RID: 4217 RVA: 0x00024C4D File Offset: 0x00022E4D
	[global::Cpp2ILInjected.Token(Token = "0x60011C8")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6EE54", Offset = "0xA6EE54", Length = "0x8C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Transform))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "get_name", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	public static Transform GetChildByName(this Transform transform, string name)
	{
		throw null;
	}

	// Token: 0x0600107A RID: 4218 RVA: 0x00024C50 File Offset: 0x00022E50
	[global::Cpp2ILInjected.Token(Token = "0x60011C9")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6E5E0", Offset = "0xA6E5E0", Length = "0xFC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameObjectExtensions), Member = "FindInChildren", MemberParameters = new object[]
	{
		typeof(GameObject),
		typeof(string)
	}, ReturnType = typeof(GameObject))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TransformExtensions), Member = "FindInChildren", MemberParameters = new object[]
	{
		typeof(Transform),
		typeof(string)
	}, ReturnType = typeof(Transform))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Transform))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "get_name", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TransformExtensions), Member = "FindInChildren", MemberParameters = new object[]
	{
		typeof(Transform),
		typeof(string)
	}, ReturnType = typeof(Transform))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static Transform FindInChildren(this Transform transform, string name)
	{
		throw null;
	}

	// Token: 0x0600107B RID: 4219 RVA: 0x00024C53 File Offset: 0x00022E53
	[global::Cpp2ILInjected.Token(Token = "0x60011CA")]
	[global::Cpp2ILInjected.Address(RVA = "0x15A1BB4", Offset = "0x15A1BB4", Length = "0x134")]
	[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Transform))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public static T FindInObjectOrChildren<T>(this Transform transform) where T : Component
	{
		throw null;
	}

	// Token: 0x0600107C RID: 4220 RVA: 0x00024C56 File Offset: 0x00022E56
	[global::Cpp2ILInjected.Token(Token = "0x60011CB")]
	[global::Cpp2ILInjected.Address(RVA = "0x15A1AB8", Offset = "0x15A1AB8", Length = "0xFC")]
	[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Transform))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public static T FindInChildren<T>(this Transform transform) where T : Component
	{
		throw null;
	}

	// Token: 0x0600107D RID: 4221 RVA: 0x00024C59 File Offset: 0x00022E59
	[global::Cpp2ILInjected.Token(Token = "0x60011CC")]
	[global::Cpp2ILInjected.Address(RVA = "0x15A1CE8", Offset = "0x15A1CE8", Length = "0x130")]
	[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_parent", ReturnType = typeof(Transform))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public static T FindInParents<T>(this Transform transform) where T : Component
	{
		throw null;
	}

	// Token: 0x0600107E RID: 4222 RVA: 0x00024C5C File Offset: 0x00022E5C
	[global::Cpp2ILInjected.Token(Token = "0x60011CD")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6E76C", Offset = "0xA6E76C", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TransformExtensions), Member = "SetLayer", MemberParameters = new object[]
	{
		typeof(Transform),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "set_layer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Transform))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TransformExtensions), Member = "SetLayer", MemberParameters = new object[]
	{
		typeof(Transform),
		typeof(int)
	}, ReturnType = typeof(void))]
	public static void SetLayer(this Transform transform, int layer)
	{
		throw null;
	}

	// Token: 0x0600107F RID: 4223 RVA: 0x00024C5F File Offset: 0x00022E5F
	[global::Cpp2ILInjected.Token(Token = "0x60011CE")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6E9C4", Offset = "0xA6E9C4", Length = "0xE4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TransformExtensions), Member = "GetPath", MemberParameters = new object[] { typeof(Transform) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_parent", ReturnType = typeof(Transform))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "get_name", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TransformExtensions), Member = "GetPath", MemberParameters = new object[] { typeof(Transform) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public static string GetPath(this Transform transform)
	{
		throw null;
	}
}
