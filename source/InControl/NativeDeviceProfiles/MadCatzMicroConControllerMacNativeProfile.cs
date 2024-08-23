using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200015C RID: 348
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000169")]
	public class MadCatzMicroConControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000742 RID: 1858 RVA: 0x000035F3 File Offset: 0x000017F3
		[global::Cpp2ILInjected.Token(Token = "0x600075F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2659C", Offset = "0x1A2659C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x000035F6 File Offset: 0x000017F6
		[global::Cpp2ILInjected.Token(Token = "0x6000760")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A26664", Offset = "0x1A26664", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public MadCatzMicroConControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
