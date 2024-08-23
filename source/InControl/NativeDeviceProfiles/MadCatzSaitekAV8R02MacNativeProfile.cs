using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000162 RID: 354
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x200016F")]
	public class MadCatzSaitekAV8R02MacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600074E RID: 1870 RVA: 0x00003617 File Offset: 0x00001817
		[global::Cpp2ILInjected.Token(Token = "0x600076B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A26A64", Offset = "0x1A26A64", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0000361A File Offset: 0x0000181A
		[global::Cpp2ILInjected.Token(Token = "0x600076C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A26B2C", Offset = "0x1A26B2C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public MadCatzSaitekAV8R02MacNativeProfile()
		{
			throw null;
		}
	}
}
