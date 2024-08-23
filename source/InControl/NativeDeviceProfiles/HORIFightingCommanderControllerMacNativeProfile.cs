using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200012D RID: 301
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x200013A")]
	public class HORIFightingCommanderControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006E4 RID: 1764 RVA: 0x000034D9 File Offset: 0x000016D9
		[global::Cpp2ILInjected.Token(Token = "0x6000701")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A22438", Offset = "0x1A22438", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x000034DC File Offset: 0x000016DC
		[global::Cpp2ILInjected.Token(Token = "0x6000702")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A22504", Offset = "0x1A22504", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public HORIFightingCommanderControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
