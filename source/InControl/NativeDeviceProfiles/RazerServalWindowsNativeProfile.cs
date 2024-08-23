using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001D0 RID: 464
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20001DD")]
	public class RazerServalWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x0600082A RID: 2090 RVA: 0x000038AB File Offset: 0x00001AAB
		[global::Cpp2ILInjected.Token(Token = "0x6000847")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A95A8", Offset = "0x19A95A8", Length = "0xB78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 88)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x000038AE File Offset: 0x00001AAE
		[global::Cpp2ILInjected.Token(Token = "0x6000848")]
		[global::Cpp2ILInjected.Address(RVA = "0x19AA120", Offset = "0x19AA120", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public RazerServalWindowsNativeProfile()
		{
			throw null;
		}
	}
}
