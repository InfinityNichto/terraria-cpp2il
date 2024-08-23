using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000051 RID: 81
	[global::Cpp2ILInjected.Token(Token = "0x200005B")]
	public static class TouchUtility
	{
		// Token: 0x06000429 RID: 1065 RVA: 0x00002CAB File Offset: 0x00000EAB
		[global::Cpp2ILInjected.Token(Token = "0x6000438")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A15DC", Offset = "0x19A15DC", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchControl), Member = "OffsetToWorldPosition", MemberParameters = new object[]
		{
			typeof(TouchControlAnchor),
			typeof(Vector2),
			typeof(TouchUnitType),
			typeof(bool)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static Vector2 AnchorToViewPoint(TouchControlAnchor touchControlAnchor)
		{
			throw null;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00002CAE File Offset: 0x00000EAE
		[global::Cpp2ILInjected.Token(Token = "0x6000439")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A1374", Offset = "0x19A1374", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchControl), Member = "OffsetToWorldPosition", MemberParameters = new object[]
		{
			typeof(TouchControlAnchor),
			typeof(Vector2),
			typeof(TouchUnitType),
			typeof(bool)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchSprite), Member = "Update", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector2 RoundVector(Vector2 vector)
		{
			throw null;
		}
	}
}
