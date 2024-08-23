using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000C0 RID: 192
	[Preserve]
	[UnityInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20000CD")]
	public class GoogleStadiaMacUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600060A RID: 1546 RVA: 0x0000324B File Offset: 0x0000144B
		[global::Cpp2ILInjected.Token(Token = "0x6000627")]
		[global::Cpp2ILInjected.Address(RVA = "0x19EBD90", Offset = "0x19EBD90", Length = "0xCA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 98)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0000324E File Offset: 0x0000144E
		[global::Cpp2ILInjected.Token(Token = "0x6000628")]
		[global::Cpp2ILInjected.Address(RVA = "0x19ECA30", Offset = "0x19ECA30", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public GoogleStadiaMacUnityProfile()
		{
			throw null;
		}
	}
}
