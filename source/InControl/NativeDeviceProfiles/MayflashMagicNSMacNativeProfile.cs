using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200016A RID: 362
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000177")]
	public class MayflashMagicNSMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600075E RID: 1886 RVA: 0x00003647 File Offset: 0x00001847
		[global::Cpp2ILInjected.Token(Token = "0x600077B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A270C4", Offset = "0x1A270C4", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x0000364A File Offset: 0x0000184A
		[global::Cpp2ILInjected.Token(Token = "0x600077C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2718C", Offset = "0x1A2718C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public MayflashMagicNSMacNativeProfile()
		{
			throw null;
		}
	}
}
