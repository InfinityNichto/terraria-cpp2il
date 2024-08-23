using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000145 RID: 325
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000152")]
	public class KonamiDancePadMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000714 RID: 1812 RVA: 0x00003569 File Offset: 0x00001769
		[global::Cpp2ILInjected.Token(Token = "0x6000731")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2390C", Offset = "0x1A2390C", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x0000356C File Offset: 0x0000176C
		[global::Cpp2ILInjected.Token(Token = "0x6000732")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A239D8", Offset = "0x1A239D8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public KonamiDancePadMacNativeProfile()
		{
			throw null;
		}
	}
}
