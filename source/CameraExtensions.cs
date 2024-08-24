using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x02000243 RID: 579
[global::Cpp2ILInjected.Token(Token = "0x20002FC")]
public static class CameraExtensions
{
	// Token: 0x06001069 RID: 4201 RVA: 0x00024C1D File Offset: 0x00022E1D
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
