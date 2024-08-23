using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000D8 RID: 216
	[Preserve]
	[UnityInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20000E5")]
	public class PlayStation4UnityProfile : InputDeviceProfile
	{
		// Token: 0x0600063A RID: 1594 RVA: 0x000032DB File Offset: 0x000014DB
		[global::Cpp2ILInjected.Token(Token = "0x6000657")]
		[global::Cpp2ILInjected.Address(RVA = "0x19F8EAC", Offset = "0x19F8EAC", Length = "0xBAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 91)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x000032DE File Offset: 0x000014DE
		[global::Cpp2ILInjected.Token(Token = "0x6000658")]
		[global::Cpp2ILInjected.Address(RVA = "0x19F9A58", Offset = "0x19F9A58", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public PlayStation4UnityProfile()
		{
			throw null;
		}
	}
}
