using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000122 RID: 290
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x200012F")]
	public class GameStopControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006CE RID: 1742 RVA: 0x00003497 File Offset: 0x00001697
		[global::Cpp2ILInjected.Token(Token = "0x60006EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A219A4", Offset = "0x1A219A4", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x0000349A File Offset: 0x0000169A
		[global::Cpp2ILInjected.Token(Token = "0x60006EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A21AEC", Offset = "0x1A21AEC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public GameStopControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
