﻿using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000007 RID: 7
	[NativeHeader("Runtime/Camera/Camera.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000007")]
	internal class CameraRaycastHelper
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002071 File Offset: 0x00000271
		[FreeFunction("CameraScripting::RaycastTry")]
		[global::Cpp2ILInjected.Token(Token = "0x600000C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA0D78", Offset = "0x1FA0D78", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask)
		{
			throw null;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002074 File Offset: 0x00000274
		[FreeFunction("CameraScripting::RaycastTry2D")]
		[global::Cpp2ILInjected.Token(Token = "0x600000D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA0E40", Offset = "0x1FA0E40", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask)
		{
			throw null;
		}

		// Token: 0x0600000E RID: 14
		[global::Cpp2ILInjected.Token(Token = "0x600000E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA0DDC", Offset = "0x1FA0DDC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern GameObject RaycastTry_Injected(Camera cam, ref Ray ray, float distance, int layerMask);

		// Token: 0x0600000F RID: 15
		[global::Cpp2ILInjected.Token(Token = "0x600000F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA0EA4", Offset = "0x1FA0EA4", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern GameObject RaycastTry2D_Injected(Camera cam, ref Ray ray, float distance, int layerMask);
	}
}