using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x020000C6 RID: 198
	[NativeHeader("Runtime/BaseClasses/TagManager.h")]
	[global::Cpp2ILInjected.Token(Token = "0x20000D8")]
	public struct SortingLayer
	{
		// Token: 0x0600045F RID: 1119
		[FreeFunction("GetTagManager().GetSortingLayerValueFromUniqueID")]
		[global::Cpp2ILInjected.Token(Token = "0x6000473")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F84178", Offset = "0x1F84178", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "RaycastComparer", MemberParameters = new object[] { "UnityEngine.EventSystems.RaycastResult", "UnityEngine.EventSystems.RaycastResult" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern int GetLayerValueFromID(int id);

		// Token: 0x04000397 RID: 919
		[global::Cpp2ILInjected.Token(Token = "0x40003CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int m_Id;
	}
}
