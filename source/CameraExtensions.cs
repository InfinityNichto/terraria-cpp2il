using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x20002FC")]
public static class CameraExtensions
{
	[global::Cpp2ILInjected.Token(Token = "0x60011B8")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6E4B4", Offset = "0xA6E4B4", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_fieldOfView", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_aspect", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static float GetHFOV(this Camera camera)
	{
		throw null;
	}
}
