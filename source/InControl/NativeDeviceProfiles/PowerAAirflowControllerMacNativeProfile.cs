using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000180 RID: 384
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200018D")]
	public class PowerAAirflowControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600078A RID: 1930 RVA: 0x000036CB File Offset: 0x000018CB
		[global::Cpp2ILInjected.Token(Token = "0x60007A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A28A60", Offset = "0x1A28A60", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x000036CE File Offset: 0x000018CE
		[global::Cpp2ILInjected.Token(Token = "0x60007A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A28B28", Offset = "0x1A28B28", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public PowerAAirflowControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
