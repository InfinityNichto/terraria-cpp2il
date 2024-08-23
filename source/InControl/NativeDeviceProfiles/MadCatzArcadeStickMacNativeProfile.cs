using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200014E RID: 334
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x200015B")]
	public class MadCatzArcadeStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000726 RID: 1830 RVA: 0x0000359F File Offset: 0x0000179F
		[global::Cpp2ILInjected.Token(Token = "0x6000743")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A250A8", Offset = "0x1A250A8", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x000035A2 File Offset: 0x000017A2
		[global::Cpp2ILInjected.Token(Token = "0x6000744")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A25A40", Offset = "0x1A25A40", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public MadCatzArcadeStickMacNativeProfile()
		{
			throw null;
		}
	}
}
