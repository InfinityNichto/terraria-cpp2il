using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001A3 RID: 419
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20001B0")]
	public class BuffaloClassicMacNativeProfile : InputDeviceProfile
	{
		// Token: 0x060007D0 RID: 2000 RVA: 0x0000379D File Offset: 0x0000199D
		[global::Cpp2ILInjected.Token(Token = "0x60007ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2A898", Offset = "0x1A2A898", Length = "0x6B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt32), Member = "op_Implicit", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(OptionalUInt32))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 52)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x000037A0 File Offset: 0x000019A0
		[global::Cpp2ILInjected.Token(Token = "0x60007EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2AF48", Offset = "0x1A2AF48", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public BuffaloClassicMacNativeProfile()
		{
			throw null;
		}
	}
}
