﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine
{
	[global::Cpp2ILInjected.Token(Token = "0x200001D")]
	public sealed class ExitGUIException : Exception
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000128")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9A870", Offset = "0x1F9A870", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutUtility), Member = "BeginLayoutArea", MemberParameters = new object[]
		{
			typeof(GUIStyle),
			typeof(Type)
		}, ReturnType = typeof(GUILayoutGroup))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal ExitGUIException(string message)
		{
			throw null;
		}
	}
}
