using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine.Events;

[Cpp2IlInjected.Token(Token = "0x200024A")]
public static class UnityEventBaseExtensions
{
	[Cpp2IlInjected.Token(Token = "0x6001099")]
	[Cpp2IlInjected.Address(RVA = "0xE87C90", Offset = "0xE87C90", VA = "0xE87C90")]
	public static MethodInfo FindMethod(this UnityEventBase eventBase, string name, object listener, PersistentListenerMode mode, Type argumentType)
	{
		return null;
	}
}
