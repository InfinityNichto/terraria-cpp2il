using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200011B RID: 283
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x2000128")]
	public class BigBenControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006C0 RID: 1728 RVA: 0x0000346D File Offset: 0x0000166D
		[global::Cpp2ILInjected.Token(Token = "0x60006DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A213B0", Offset = "0x1A213B0", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00003470 File Offset: 0x00001670
		[global::Cpp2ILInjected.Token(Token = "0x60006DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2147C", Offset = "0x1A2147C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public BigBenControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
