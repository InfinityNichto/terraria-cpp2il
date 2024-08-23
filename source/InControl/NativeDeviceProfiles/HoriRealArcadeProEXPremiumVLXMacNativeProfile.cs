using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000138 RID: 312
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000145")]
	public class HoriRealArcadeProEXPremiumVLXMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006FA RID: 1786 RVA: 0x0000351B File Offset: 0x0000171B
		[global::Cpp2ILInjected.Token(Token = "0x6000717")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A22DF8", Offset = "0x1A22DF8", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x0000351E File Offset: 0x0000171E
		[global::Cpp2ILInjected.Token(Token = "0x6000718")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A22EC4", Offset = "0x1A22EC4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public HoriRealArcadeProEXPremiumVLXMacNativeProfile()
		{
			throw null;
		}
	}
}
