using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000120 RID: 288
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x200012D")]
	public class ElecomControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006CA RID: 1738 RVA: 0x0000348B File Offset: 0x0000168B
		[global::Cpp2ILInjected.Token(Token = "0x60006E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A217D4", Offset = "0x1A217D4", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0000348E File Offset: 0x0000168E
		[global::Cpp2ILInjected.Token(Token = "0x60006E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A218A0", Offset = "0x1A218A0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public ElecomControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
