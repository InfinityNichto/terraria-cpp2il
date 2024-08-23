using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001A1 RID: 417
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20001AE")]
	public class Xbox360MortalKombatFightStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007CC RID: 1996 RVA: 0x00003791 File Offset: 0x00001991
		[global::Cpp2ILInjected.Token(Token = "0x60007E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2A700", Offset = "0x1A2A700", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00003794 File Offset: 0x00001994
		[global::Cpp2ILInjected.Token(Token = "0x60007EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2A7C8", Offset = "0x1A2A7C8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public Xbox360MortalKombatFightStickMacNativeProfile()
		{
			throw null;
		}
	}
}
