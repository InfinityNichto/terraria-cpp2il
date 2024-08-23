using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000137 RID: 311
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x2000144")]
	public class HoriRealArcadeProEXMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006F8 RID: 1784 RVA: 0x00003515 File Offset: 0x00001715
		[global::Cpp2ILInjected.Token(Token = "0x6000715")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A22D24", Offset = "0x1A22D24", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00003518 File Offset: 0x00001718
		[global::Cpp2ILInjected.Token(Token = "0x6000716")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A22DF0", Offset = "0x1A22DF0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public HoriRealArcadeProEXMacNativeProfile()
		{
			throw null;
		}
	}
}
