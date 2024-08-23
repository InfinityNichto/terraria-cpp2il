using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000135 RID: 309
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x2000142")]
	public class HoriPadUltimateMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006F4 RID: 1780 RVA: 0x00003509 File Offset: 0x00001709
		[global::Cpp2ILInjected.Token(Token = "0x6000711")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A22B7C", Offset = "0x1A22B7C", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x0000350C File Offset: 0x0000170C
		[global::Cpp2ILInjected.Token(Token = "0x6000712")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A22C48", Offset = "0x1A22C48", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public HoriPadUltimateMacNativeProfile()
		{
			throw null;
		}
	}
}
