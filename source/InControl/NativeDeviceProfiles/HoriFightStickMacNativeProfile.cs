using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000133 RID: 307
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000140")]
	public class HoriFightStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006F0 RID: 1776 RVA: 0x000034FD File Offset: 0x000016FD
		[global::Cpp2ILInjected.Token(Token = "0x600070D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A229D4", Offset = "0x1A229D4", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00003500 File Offset: 0x00001700
		[global::Cpp2ILInjected.Token(Token = "0x600070E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A22AA0", Offset = "0x1A22AA0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public HoriFightStickMacNativeProfile()
		{
			throw null;
		}
	}
}
