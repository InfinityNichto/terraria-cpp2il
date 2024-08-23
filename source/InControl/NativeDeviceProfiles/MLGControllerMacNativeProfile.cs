using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000172 RID: 370
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x200017F")]
	public class MLGControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600076E RID: 1902 RVA: 0x00003677 File Offset: 0x00001877
		[global::Cpp2ILInjected.Token(Token = "0x600078B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2796C", Offset = "0x1A2796C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0000367A File Offset: 0x0000187A
		[global::Cpp2ILInjected.Token(Token = "0x600078C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A27A34", Offset = "0x1A27A34", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public MLGControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
