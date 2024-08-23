using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200015F RID: 351
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x200016C")]
	public class MadCatzNeoFightStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000748 RID: 1864 RVA: 0x00003605 File Offset: 0x00001805
		[global::Cpp2ILInjected.Token(Token = "0x6000765")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A26800", Offset = "0x1A26800", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00003608 File Offset: 0x00001808
		[global::Cpp2ILInjected.Token(Token = "0x6000766")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A268C8", Offset = "0x1A268C8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public MadCatzNeoFightStickMacNativeProfile()
		{
			throw null;
		}
	}
}
