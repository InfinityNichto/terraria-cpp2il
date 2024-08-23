using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200019B RID: 411
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20001A8")]
	public class ThrustMasterFerrari458SpiderRacingWheelMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007C0 RID: 1984 RVA: 0x0000376D File Offset: 0x0000196D
		[global::Cpp2ILInjected.Token(Token = "0x60007DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2A210", Offset = "0x1A2A210", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00003770 File Offset: 0x00001970
		[global::Cpp2ILInjected.Token(Token = "0x60007DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2A2D8", Offset = "0x1A2A2D8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public ThrustMasterFerrari458SpiderRacingWheelMacNativeProfile()
		{
			throw null;
		}
	}
}
