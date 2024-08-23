using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200012F RID: 303
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200013C")]
	public class HoriFightingEdgeArcadeStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006E8 RID: 1768 RVA: 0x000034E5 File Offset: 0x000016E5
		[global::Cpp2ILInjected.Token(Token = "0x6000705")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A22608", Offset = "0x1A22608", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x000034E8 File Offset: 0x000016E8
		[global::Cpp2ILInjected.Token(Token = "0x6000706")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A226D4", Offset = "0x1A226D4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public HoriFightingEdgeArcadeStickMacNativeProfile()
		{
			throw null;
		}
	}
}
