using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200014D RID: 333
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x200015A")]
	public class LogitechThunderpadMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000724 RID: 1828 RVA: 0x00003599 File Offset: 0x00001799
		[global::Cpp2ILInjected.Token(Token = "0x6000741")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A23FD4", Offset = "0x1A23FD4", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x0000359C File Offset: 0x0000179C
		[global::Cpp2ILInjected.Token(Token = "0x6000742")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A240A0", Offset = "0x1A240A0", Length = "0x1008")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public LogitechThunderpadMacNativeProfile()
		{
			throw null;
		}
	}
}
