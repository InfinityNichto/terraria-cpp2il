using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000088 RID: 136
	[NativeHeader("Runtime/Export/Bootstrap/BootConfig.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000096")]
	internal class BootConfigData
	{
		// Token: 0x06000298 RID: 664 RVA: 0x0000256C File Offset: 0x0000076C
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60002A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F795F0", Offset = "0x1F795F0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BootConfigData), Member = ".ctor", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static BootConfigData WrapBootConfigData(IntPtr nativeHandle)
		{
			throw null;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000256F File Offset: 0x0000076F
		[global::Cpp2ILInjected.Token(Token = "0x60002A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F79648", Offset = "0x1F79648", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BootConfigData), Member = "WrapBootConfigData", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(BootConfigData))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private BootConfigData(IntPtr nativeHandle)
		{
			throw null;
		}

		// Token: 0x04000315 RID: 789
		[global::Cpp2ILInjected.Token(Token = "0x4000345")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IntPtr m_Ptr;
	}
}
