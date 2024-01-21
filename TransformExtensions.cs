using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000249")]
public static class TransformExtensions
{
	[Cpp2IlInjected.Token(Token = "0x6001090")]
	[Cpp2IlInjected.Address(RVA = "0x10D244C", Offset = "0x10D244C", VA = "0x10D244C")]
	public static Transform[] FindAllInChildren(this Transform transform, string name)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001091")]
	[Cpp2IlInjected.Address(RVA = "0x10D24EC", Offset = "0x10D24EC", VA = "0x10D24EC")]
	private static void FindAllInChildren(this Transform transform, string name, List<Transform> results)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001092")]
	[Cpp2IlInjected.Address(RVA = "0x10D25CC", Offset = "0x10D25CC", VA = "0x10D25CC")]
	public static Transform GetChildByName(this Transform transform, string name)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001093")]
	[Cpp2IlInjected.Address(RVA = "0x10D2650", Offset = "0x10D2650", VA = "0x10D2650")]
	public static Transform FindInChildren(this Transform transform, string name)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001094")]
	[Cpp2IlInjected.Address(RVA = "0x15F1ED8", Offset = "0x15F1ED8", VA = "0x15F1ED8")]
	public static T FindInObjectOrChildren<T>(this Transform transform) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001095")]
	[Cpp2IlInjected.Address(RVA = "0x15F1DB4", Offset = "0x15F1DB4", VA = "0x15F1DB4")]
	public static T FindInChildren<T>(this Transform transform) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001096")]
	[Cpp2IlInjected.Address(RVA = "0x15F2048", Offset = "0x15F2048", VA = "0x15F2048")]
	public static T FindInParents<T>(this Transform transform) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001097")]
	[Cpp2IlInjected.Address(RVA = "0x10D276C", Offset = "0x10D276C", VA = "0x10D276C")]
	public static void SetLayer(this Transform transform, int layer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001098")]
	[Cpp2IlInjected.Address(RVA = "0x10D27E0", Offset = "0x10D27E0", VA = "0x10D27E0")]
	public static string GetPath(this Transform transform)
	{
		return null;
	}
}
