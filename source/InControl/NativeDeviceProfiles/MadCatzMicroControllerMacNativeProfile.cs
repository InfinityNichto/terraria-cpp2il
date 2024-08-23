using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200015D RID: 349
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x200016A")]
	public class MadCatzMicroControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000744 RID: 1860 RVA: 0x000035F9 File Offset: 0x000017F9
		[global::Cpp2ILInjected.Token(Token = "0x6000761")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A26668", Offset = "0x1A26668", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x000035FC File Offset: 0x000017FC
		[global::Cpp2ILInjected.Token(Token = "0x6000762")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A26730", Offset = "0x1A26730", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public MadCatzMicroControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
