using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001A2 RID: 418
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20001AF")]
	public class Xbox360ProEXControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007CE RID: 1998 RVA: 0x00003797 File Offset: 0x00001997
		[global::Cpp2ILInjected.Token(Token = "0x60007EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2A7CC", Offset = "0x1A2A7CC", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x0000379A File Offset: 0x0000199A
		[global::Cpp2ILInjected.Token(Token = "0x60007EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2A894", Offset = "0x1A2A894", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public Xbox360ProEXControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
