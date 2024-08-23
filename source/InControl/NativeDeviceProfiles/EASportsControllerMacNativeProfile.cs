using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200011F RID: 287
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200012C")]
	public class EASportsControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006C8 RID: 1736 RVA: 0x00003485 File Offset: 0x00001685
		[global::Cpp2ILInjected.Token(Token = "0x60006E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A21700", Offset = "0x1A21700", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00003488 File Offset: 0x00001688
		[global::Cpp2ILInjected.Token(Token = "0x60006E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A217CC", Offset = "0x1A217CC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public EASportsControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
