using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000146 RID: 326
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000153")]
	public class LogitechChillStreamControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000716 RID: 1814 RVA: 0x0000356F File Offset: 0x0000176F
		[global::Cpp2ILInjected.Token(Token = "0x6000733")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A239E0", Offset = "0x1A239E0", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00003572 File Offset: 0x00001772
		[global::Cpp2ILInjected.Token(Token = "0x6000734")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A23AAC", Offset = "0x1A23AAC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public LogitechChillStreamControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
