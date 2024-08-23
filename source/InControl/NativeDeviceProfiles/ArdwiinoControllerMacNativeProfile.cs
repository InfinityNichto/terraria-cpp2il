using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000117 RID: 279
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x2000124")]
	public class ArdwiinoControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006B8 RID: 1720 RVA: 0x00003455 File Offset: 0x00001655
		[global::Cpp2ILInjected.Token(Token = "0x60006D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2100C", Offset = "0x1A2100C", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00003458 File Offset: 0x00001658
		[global::Cpp2ILInjected.Token(Token = "0x60006D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A210D8", Offset = "0x1A210D8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public ArdwiinoControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
