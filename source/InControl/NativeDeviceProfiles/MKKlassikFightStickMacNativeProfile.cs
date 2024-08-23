using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000171 RID: 369
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x200017E")]
	public class MKKlassikFightStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600076C RID: 1900 RVA: 0x00003671 File Offset: 0x00001871
		[global::Cpp2ILInjected.Token(Token = "0x6000789")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A278A0", Offset = "0x1A278A0", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00003674 File Offset: 0x00001874
		[global::Cpp2ILInjected.Token(Token = "0x600078A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A27968", Offset = "0x1A27968", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public MKKlassikFightStickMacNativeProfile()
		{
			throw null;
		}
	}
}
