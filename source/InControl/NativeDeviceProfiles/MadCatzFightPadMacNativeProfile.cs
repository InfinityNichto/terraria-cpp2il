using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000154 RID: 340
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000161")]
	public class MadCatzFightPadMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000732 RID: 1842 RVA: 0x000035C3 File Offset: 0x000017C3
		[global::Cpp2ILInjected.Token(Token = "0x600074F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A25F3C", Offset = "0x1A25F3C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x000035C6 File Offset: 0x000017C6
		[global::Cpp2ILInjected.Token(Token = "0x6000750")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A26004", Offset = "0x1A26004", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public MadCatzFightPadMacNativeProfile()
		{
			throw null;
		}
	}
}
