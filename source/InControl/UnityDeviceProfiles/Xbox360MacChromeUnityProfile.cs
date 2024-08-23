using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000DF RID: 223
	[Preserve]
	[UnityInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20000EC")]
	public class Xbox360MacChromeUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000648 RID: 1608 RVA: 0x00003305 File Offset: 0x00001505
		[global::Cpp2ILInjected.Token(Token = "0x6000665")]
		[global::Cpp2ILInjected.Address(RVA = "0x19FDE60", Offset = "0x19FDE60", Length = "0xD00")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 99)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00003308 File Offset: 0x00001508
		[global::Cpp2ILInjected.Token(Token = "0x6000666")]
		[global::Cpp2ILInjected.Address(RVA = "0x19FEB60", Offset = "0x19FEB60", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Xbox360MacChromeUnityProfile()
		{
			throw null;
		}
	}
}
