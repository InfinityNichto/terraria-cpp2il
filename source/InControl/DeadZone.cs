using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200001B RID: 27
	[global::Cpp2ILInjected.Token(Token = "0x200001C")]
	public static class DeadZone
	{
		// Token: 0x06000128 RID: 296 RVA: 0x000023D5 File Offset: 0x000005D5
		[global::Cpp2ILInjected.Token(Token = "0x6000128")]
		[global::Cpp2ILInjected.Address(RVA = "0x1985E54", Offset = "0x1985E54", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector2 SeparateNotNormalized(float x, float y, float lowerDeadZone, float upperDeadZone)
		{
			throw null;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000023D8 File Offset: 0x000005D8
		[global::Cpp2ILInjected.Token(Token = "0x6000129")]
		[global::Cpp2ILInjected.Address(RVA = "0x1985F0C", Offset = "0x1985F0C", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static Vector2 Separate(float x, float y, float lowerDeadZone, float upperDeadZone)
		{
			throw null;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000023DB File Offset: 0x000005DB
		[global::Cpp2ILInjected.Token(Token = "0x600012A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1986084", Offset = "0x1986084", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchControl), Member = "SubmitAnalogValue", MemberParameters = new object[]
		{
			typeof(TouchControl.AnalogTarget),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static Vector2 Circular(float x, float y, float lowerDeadZone, float upperDeadZone)
		{
			throw null;
		}
	}
}
