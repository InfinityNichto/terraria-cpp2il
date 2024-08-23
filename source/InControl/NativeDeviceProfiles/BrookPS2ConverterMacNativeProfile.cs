using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200011D RID: 285
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x200012A")]
	public class BrookPS2ConverterMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006C4 RID: 1732 RVA: 0x00003479 File Offset: 0x00001679
		[global::Cpp2ILInjected.Token(Token = "0x60006E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A21558", Offset = "0x1A21558", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0000347C File Offset: 0x0000167C
		[global::Cpp2ILInjected.Token(Token = "0x60006E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A21624", Offset = "0x1A21624", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public BrookPS2ConverterMacNativeProfile()
		{
			throw null;
		}
	}
}
