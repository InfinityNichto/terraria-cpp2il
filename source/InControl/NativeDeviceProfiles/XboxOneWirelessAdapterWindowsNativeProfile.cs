using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001D9 RID: 473
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20001E6")]
	public class XboxOneWirelessAdapterWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x0600083C RID: 2108 RVA: 0x000038E1 File Offset: 0x00001AE1
		[global::Cpp2ILInjected.Token(Token = "0x6000859")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B04D0", Offset = "0x19B04D0", Length = "0xBCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 90)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x000038E4 File Offset: 0x00001AE4
		[global::Cpp2ILInjected.Token(Token = "0x600085A")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B109C", Offset = "0x19B109C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XboxOneWirelessAdapterWindowsNativeProfile()
		{
			throw null;
		}
	}
}
