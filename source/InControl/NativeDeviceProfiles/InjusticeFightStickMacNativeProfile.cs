using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000142 RID: 322
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x200014F")]
	public class InjusticeFightStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600070E RID: 1806 RVA: 0x00003557 File Offset: 0x00001757
		[global::Cpp2ILInjected.Token(Token = "0x600072B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A23690", Offset = "0x1A23690", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x0000355A File Offset: 0x0000175A
		[global::Cpp2ILInjected.Token(Token = "0x600072C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2375C", Offset = "0x1A2375C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public InjusticeFightStickMacNativeProfile()
		{
			throw null;
		}
	}
}
