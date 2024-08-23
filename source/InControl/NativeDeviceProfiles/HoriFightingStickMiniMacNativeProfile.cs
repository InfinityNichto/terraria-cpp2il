using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000131 RID: 305
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200013E")]
	public class HoriFightingStickMiniMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006EC RID: 1772 RVA: 0x000034F1 File Offset: 0x000016F1
		[global::Cpp2ILInjected.Token(Token = "0x6000709")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A22804", Offset = "0x1A22804", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x000034F4 File Offset: 0x000016F4
		[global::Cpp2ILInjected.Token(Token = "0x600070A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A228D0", Offset = "0x1A228D0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public HoriFightingStickMiniMacNativeProfile()
		{
			throw null;
		}
	}
}
