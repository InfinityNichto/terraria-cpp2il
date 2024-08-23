using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000144 RID: 324
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000151")]
	public class JoytekXbox360ControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000712 RID: 1810 RVA: 0x00003563 File Offset: 0x00001763
		[global::Cpp2ILInjected.Token(Token = "0x600072F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A23838", Offset = "0x1A23838", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00003566 File Offset: 0x00001766
		[global::Cpp2ILInjected.Token(Token = "0x6000730")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A23904", Offset = "0x1A23904", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public JoytekXbox360ControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
