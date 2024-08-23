using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001D4 RID: 468
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20001E1")]
	public class XboxOneEliteWindows10AENativeProfile : InputDeviceProfile
	{
		// Token: 0x06000832 RID: 2098 RVA: 0x000038C3 File Offset: 0x00001AC3
		[global::Cpp2ILInjected.Token(Token = "0x600084F")]
		[global::Cpp2ILInjected.Address(RVA = "0x19AC50C", Offset = "0x19AC50C", Length = "0xC98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 96)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x000038C6 File Offset: 0x00001AC6
		[global::Cpp2ILInjected.Token(Token = "0x6000850")]
		[global::Cpp2ILInjected.Address(RVA = "0x19AD1A4", Offset = "0x19AD1A4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XboxOneEliteWindows10AENativeProfile()
		{
			throw null;
		}
	}
}
