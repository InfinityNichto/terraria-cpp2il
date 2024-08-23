using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200018B RID: 395
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x2000198")]
	public class RazerOnzaTEControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007A0 RID: 1952 RVA: 0x0000370D File Offset: 0x0000190D
		[global::Cpp2ILInjected.Token(Token = "0x60007BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A293D8", Offset = "0x1A293D8", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00003710 File Offset: 0x00001910
		[global::Cpp2ILInjected.Token(Token = "0x60007BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A294C8", Offset = "0x1A294C8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public RazerOnzaTEControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
