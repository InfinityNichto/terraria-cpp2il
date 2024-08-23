using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200018E RID: 398
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x200019B")]
	public class RazerWildcatControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007A6 RID: 1958 RVA: 0x0000371F File Offset: 0x0000191F
		[global::Cpp2ILInjected.Token(Token = "0x60007C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2968C", Offset = "0x1A2968C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00003722 File Offset: 0x00001922
		[global::Cpp2ILInjected.Token(Token = "0x60007C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A29754", Offset = "0x1A29754", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public RazerWildcatControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
