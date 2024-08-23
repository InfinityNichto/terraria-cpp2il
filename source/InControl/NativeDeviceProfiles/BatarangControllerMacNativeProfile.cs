using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000119 RID: 281
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x2000126")]
	public class BatarangControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006BC RID: 1724 RVA: 0x00003461 File Offset: 0x00001661
		[global::Cpp2ILInjected.Token(Token = "0x60006D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A21208", Offset = "0x1A21208", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00003464 File Offset: 0x00001664
		[global::Cpp2ILInjected.Token(Token = "0x60006DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A212D4", Offset = "0x1A212D4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public BatarangControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
