using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000F1 RID: 241
	[Preserve]
	[UnityInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20000FE")]
	public class GameCubeMayflashWindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600066C RID: 1644 RVA: 0x00003371 File Offset: 0x00001571
		[global::Cpp2ILInjected.Token(Token = "0x6000689")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A0A98C", Offset = "0x1A0A98C", Length = "0xC14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "set_UpperDeadZone", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 91)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00003374 File Offset: 0x00001574
		[global::Cpp2ILInjected.Token(Token = "0x600068A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A0B5A0", Offset = "0x1A0B5A0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public GameCubeMayflashWindowsUnityProfile()
		{
			throw null;
		}
	}
}
