using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200012B RID: 299
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x2000138")]
	public class HoriEdgeFightingStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006E0 RID: 1760 RVA: 0x000034CD File Offset: 0x000016CD
		[global::Cpp2ILInjected.Token(Token = "0x60006FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2223C", Offset = "0x1A2223C", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x000034D0 File Offset: 0x000016D0
		[global::Cpp2ILInjected.Token(Token = "0x60006FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A22308", Offset = "0x1A22308", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public HoriEdgeFightingStickMacNativeProfile()
		{
			throw null;
		}
	}
}
