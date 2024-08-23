using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000176 RID: 374
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000183")]
	public class PDPAfterglowPrismaticControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000776 RID: 1910 RVA: 0x0000368F File Offset: 0x0000188F
		[global::Cpp2ILInjected.Token(Token = "0x6000793")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A27EF8", Offset = "0x1A27EF8", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00003692 File Offset: 0x00001892
		[global::Cpp2ILInjected.Token(Token = "0x6000794")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A28014", Offset = "0x1A28014", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public PDPAfterglowPrismaticControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
