using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000178 RID: 376
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x2000185")]
	public class PDPMarvelControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600077A RID: 1914 RVA: 0x0000369B File Offset: 0x0000189B
		[global::Cpp2ILInjected.Token(Token = "0x6000797")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A280EC", Offset = "0x1A280EC", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x0000369E File Offset: 0x0000189E
		[global::Cpp2ILInjected.Token(Token = "0x6000798")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A281B4", Offset = "0x1A281B4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public PDPMarvelControllerMacNativeProfile()
		{
			throw null;
		}
	}
}
