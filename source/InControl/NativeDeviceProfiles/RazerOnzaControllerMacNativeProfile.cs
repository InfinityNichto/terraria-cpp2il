using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200018A RID: 394
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x2000197")]
	public class RazerOnzaControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600079E RID: 1950 RVA: 0x00003707 File Offset: 0x00001907
		[global::Cpp2ILInjected.Token(Token = "0x60007BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A292E4", Offset = "0x1A292E4", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0000370A File Offset: 0x0000190A
		[global::Cpp2ILInjected.Token(Token = "0x60007BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A293D4", Offset = "0x1A293D4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public RazerOnzaControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
