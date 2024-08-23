using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000196 RID: 406
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20001A3")]
	public class RockCandyXbox360ControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007B6 RID: 1974 RVA: 0x0000374F File Offset: 0x0000194F
		[global::Cpp2ILInjected.Token(Token = "0x60007D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A29D14", Offset = "0x1A29D14", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00003752 File Offset: 0x00001952
		[global::Cpp2ILInjected.Token(Token = "0x60007D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A29E30", Offset = "0x1A29E30", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public RockCandyXbox360ControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
