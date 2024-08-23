using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000188 RID: 392
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x2000195")]
	public class QanbaFightStickPlusMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600079A RID: 1946 RVA: 0x000036FB File Offset: 0x000018FB
		[global::Cpp2ILInjected.Token(Token = "0x60007B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A29124", Offset = "0x1A29124", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x000036FE File Offset: 0x000018FE
		[global::Cpp2ILInjected.Token(Token = "0x60007B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A291EC", Offset = "0x1A291EC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public QanbaFightStickPlusMacNativeProfile()
		{
			throw null;
		}
	}
}
