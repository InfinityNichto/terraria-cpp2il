using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	// Token: 0x02000040 RID: 64
	[global::Cpp2ILInjected.Token(Token = "0x2000045")]
	public class OuyaEverywhereDeviceManager : InputDeviceManager
	{
		// Token: 0x06000356 RID: 854 RVA: 0x00002A4D File Offset: 0x00000C4D
		[global::Cpp2ILInjected.Token(Token = "0x600035F")]
		[global::Cpp2ILInjected.Address(RVA = "0x199D848", Offset = "0x199D848", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OuyaEverywhereDevice), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public OuyaEverywhereDeviceManager()
		{
			throw null;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00002A50 File Offset: 0x00000C50
		[global::Cpp2ILInjected.Token(Token = "0x6000360")]
		[global::Cpp2ILInjected.Address(RVA = "0x199D958", Offset = "0x199D958", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "DetachDevice", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Update(ulong updateTick, float deltaTime)
		{
			throw null;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00002A53 File Offset: 0x00000C53
		[global::Cpp2ILInjected.Token(Token = "0x6000361")]
		[global::Cpp2ILInjected.Address(RVA = "0x199DA54", Offset = "0x199DA54", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Enable()
		{
			throw null;
		}

		// Token: 0x040002DE RID: 734
		[global::Cpp2ILInjected.Token(Token = "0x40002ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool[] deviceConnected;
	}
}
