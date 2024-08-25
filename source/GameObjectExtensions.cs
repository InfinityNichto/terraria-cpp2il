using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x20002FD")]
public static class GameObjectExtensions
{
	[global::Cpp2ILInjected.Token(Token = "0x60011B9")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6E514", Offset = "0xA6E514", Length = "0xCC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = "GetCamera", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Camera))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DistortionRenderTargetManager), Member = "get_Instance", ReturnType = typeof(DistortionRenderTargetManager))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterRenderTargetManager), Member = "get_Instance", ReturnType = typeof(WaterRenderTargetManager))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstanceList), Member = "SetupParent", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TransformExtensions), Member = "FindInChildren", MemberParameters = new object[]
	{
		typeof(Transform),
		typeof(string)
	}, ReturnType = typeof(Transform))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public static GameObject FindInChildren(this GameObject gameObject, string name)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60011BA")]
	[global::Cpp2ILInjected.Address(RVA = "0x158AE00", Offset = "0x158AE00", Length = "0x9C")]
	[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public static T FindInChildren<T>(this GameObject gameObject) where T : Component
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60011BB")]
	[global::Cpp2ILInjected.Address(RVA = "0x158AE9C", Offset = "0x158AE9C", Length = "0x9C")]
	[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public static T FindInObjectOrChildren<T>(this GameObject gameObject) where T : Component
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60011BC")]
	[global::Cpp2ILInjected.Address(RVA = "0x158B0B4", Offset = "0x158B0B4", Length = "0x100")]
	[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static T[] GetComponentsInObjectChildren<T>(this GameObject gameObject) where T : Component
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60011BD")]
	[global::Cpp2ILInjected.Address(RVA = "0x158B018", Offset = "0x158B018", Length = "0x9C")]
	[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public static T FindInParents<T>(this GameObject gameObject) where T : Component
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60011BE")]
	[global::Cpp2ILInjected.Address(RVA = "0x158AF38", Offset = "0x158AF38", Length = "0xE0")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public static T FindInObjectOrParents<T>(this GameObject gameObject) where T : Component
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60011BF")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6E6DC", Offset = "0xA6E6DC", Length = "0x90")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameObjectExtensions), Member = "InstantiatePrefabAsChild", MemberParameters = new object[]
	{
		typeof(GameObject),
		typeof(GameObject)
	}, ReturnType = typeof(GameObject))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstanceList), Member = "GetBatchInstance", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GeometryBufferInstance))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstanceList), Member = "GetInstance", MemberParameters = new object[]
	{
		typeof(SpriteBatcher.VertexData[]),
		typeof(short[]),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(GeometryBufferInstance))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstanceList), Member = "GetInstance", MemberParameters = new object[]
	{
		typeof(List<Vector3>),
		typeof(List<Vector2>),
		typeof(List<Vector4>),
		typeof(List<Color32>),
		typeof(List<int>),
		typeof(int)
	}, ReturnType = typeof(GeometryBufferInstance))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static void SetLayer(this GameObject gameObject, int layer)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60011C0")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6E7F0", Offset = "0xA6E7F0", Length = "0x1C0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "Instantiate", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T" }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "set_parent", MemberParameters = new object[] { typeof(Transform) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new object[] { typeof(Quaternion) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObjectExtensions), Member = "SetLayer", MemberParameters = new object[]
	{
		typeof(GameObject),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public static GameObject InstantiatePrefabAsChild(this GameObject gameObject, GameObject prefab)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60011C1")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6E9B0", Offset = "0xA6E9B0", Length = "0x14")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	public static string GetPath(this GameObject gameObject)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60011C2")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6EAA8", Offset = "0xA6EAA8", Length = "0xA8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_parent", ReturnType = typeof(Transform))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static GameObject Parent(this GameObject gameObject)
	{
		throw null;
	}
}
