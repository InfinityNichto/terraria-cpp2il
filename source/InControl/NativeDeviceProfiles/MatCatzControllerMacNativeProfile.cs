using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000169 RID: 361
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x2000176")]
	public class MatCatzControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600075C RID: 1884 RVA: 0x00003641 File Offset: 0x00001841
		[global::Cpp2ILInjected.Token(Token = "0x6000779")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A26FF8", Offset = "0x1A26FF8", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00003644 File Offset: 0x00001844
		[global::Cpp2ILInjected.Token(Token = "0x600077A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A270C0", Offset = "0x1A270C0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public MatCatzControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
