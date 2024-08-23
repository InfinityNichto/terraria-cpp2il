using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000098 RID: 152
	[NativeHeader("Runtime/BaseClasses/TagManager.h")]
	[NativeClass("BitField", "struct BitField;")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[NativeHeader("Runtime/BaseClasses/BitField.h")]
	[global::Cpp2ILInjected.Token(Token = "0x20000A6")]
	public struct LayerMask
	{
		// Token: 0x060002FB RID: 763 RVA: 0x00002632 File Offset: 0x00000832
		[global::Cpp2ILInjected.Token(Token = "0x6000309")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7B7F4", Offset = "0x1F7B7F4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "get_finalEventMask", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public static implicit operator int(LayerMask mask)
		{
			throw null;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00002635 File Offset: 0x00000835
		[global::Cpp2ILInjected.Token(Token = "0x600030A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7B7F8", Offset = "0x1F7B7F8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.Physics2DRaycaster", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public static implicit operator LayerMask(int intVal)
		{
			throw null;
		}

		// Token: 0x04000333 RID: 819
		[NativeName("m_Bits")]
		[global::Cpp2ILInjected.Token(Token = "0x4000363")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int m_Mask;
	}
}
