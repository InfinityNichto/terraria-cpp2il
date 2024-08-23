using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000128 RID: 296
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000135")]
	public class HoriBlueSoloControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006DA RID: 1754 RVA: 0x000034BB File Offset: 0x000016BB
		[global::Cpp2ILInjected.Token(Token = "0x60006F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A21F18", Offset = "0x1A21F18", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x000034BE File Offset: 0x000016BE
		[global::Cpp2ILInjected.Token(Token = "0x60006F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A21FE4", Offset = "0x1A21FE4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public HoriBlueSoloControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
