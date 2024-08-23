using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200014F RID: 335
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200015C")]
	public class MadCatzBeatPadMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000728 RID: 1832 RVA: 0x000035A5 File Offset: 0x000017A5
		[global::Cpp2ILInjected.Token(Token = "0x6000745")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A25A9C", Offset = "0x1A25A9C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x000035A8 File Offset: 0x000017A8
		[global::Cpp2ILInjected.Token(Token = "0x6000746")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A25B64", Offset = "0x1A25B64", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public MadCatzBeatPadMacNativeProfile()
		{
			throw null;
		}
	}
}
