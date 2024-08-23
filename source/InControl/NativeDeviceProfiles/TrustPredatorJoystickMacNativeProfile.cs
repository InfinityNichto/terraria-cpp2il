using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200019F RID: 415
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20001AC")]
	public class TrustPredatorJoystickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007C8 RID: 1992 RVA: 0x00003785 File Offset: 0x00001985
		[global::Cpp2ILInjected.Token(Token = "0x60007E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2A568", Offset = "0x1A2A568", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00003788 File Offset: 0x00001988
		[global::Cpp2ILInjected.Token(Token = "0x60007E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2A630", Offset = "0x1A2A630", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public TrustPredatorJoystickMacNativeProfile()
		{
			throw null;
		}
	}
}
