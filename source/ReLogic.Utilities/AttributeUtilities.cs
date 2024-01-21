using System;
using System.Reflection;
using Cpp2IlInjected;

namespace ReLogic.Utilities;

[Cpp2IlInjected.Token(Token = "0x2000710")]
public static class AttributeUtilities
{
	[Cpp2IlInjected.Token(Token = "0x2000AC6")]
	private static class TypeAttributeCache<T, A> where A : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x4008F72")]
		public static readonly A Value;
	}

	[Cpp2IlInjected.Token(Token = "0x6004618")]
	[Cpp2IlInjected.Address(RVA = "0x15ADBFC", Offset = "0x15ADBFC", VA = "0x15ADBFC")]
	public static T GetAttribute<T>(this MethodBase method) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004619")]
	[Cpp2IlInjected.Address(RVA = "0x15ADB24", Offset = "0x15ADB24", VA = "0x15ADB24")]
	public static T GetAttribute<T>(this Enum value) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600461A")]
	[Cpp2IlInjected.Address(RVA = "0x16646AC", Offset = "0x16646AC", VA = "0x16646AC")]
	public static A GetCacheableAttribute<A, T>() where A : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600461B")]
	[Cpp2IlInjected.Address(RVA = "0x15ADD0C", Offset = "0x15ADD0C", VA = "0x15ADD0C")]
	public static T GetAttribute<T>(this Type type) where T : Attribute
	{
		return null;
	}
}
