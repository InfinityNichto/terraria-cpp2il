using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200013C RID: 316
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000149")]
	public class HoriRealArcadeProVHayabusaMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000702 RID: 1794 RVA: 0x00003533 File Offset: 0x00001733
		[global::Cpp2ILInjected.Token(Token = "0x600071F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A23148", Offset = "0x1A23148", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00003536 File Offset: 0x00001736
		[global::Cpp2ILInjected.Token(Token = "0x6000720")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A23214", Offset = "0x1A23214", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public HoriRealArcadeProVHayabusaMacNativeProfile()
		{
			throw null;
		}
	}
}
