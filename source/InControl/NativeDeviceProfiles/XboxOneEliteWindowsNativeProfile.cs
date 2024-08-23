using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001D5 RID: 469
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20001E2")]
	public class XboxOneEliteWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000834 RID: 2100 RVA: 0x000038C9 File Offset: 0x00001AC9
		[global::Cpp2ILInjected.Token(Token = "0x6000851")]
		[global::Cpp2ILInjected.Address(RVA = "0x19AD1FC", Offset = "0x19AD1FC", Length = "0xBEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 90)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x000038CC File Offset: 0x00001ACC
		[global::Cpp2ILInjected.Token(Token = "0x6000852")]
		[global::Cpp2ILInjected.Address(RVA = "0x19ADDE8", Offset = "0x19ADDE8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XboxOneEliteWindowsNativeProfile()
		{
			throw null;
		}
	}
}
