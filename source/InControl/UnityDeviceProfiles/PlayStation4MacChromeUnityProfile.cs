using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000DD RID: 221
	[Preserve]
	[UnityInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20000EA")]
	public class PlayStation4MacChromeUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000644 RID: 1604 RVA: 0x000032F9 File Offset: 0x000014F9
		[global::Cpp2ILInjected.Token(Token = "0x6000661")]
		[global::Cpp2ILInjected.Address(RVA = "0x19FC3E4", Offset = "0x19FC3E4", Length = "0xD24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 100)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x000032FC File Offset: 0x000014FC
		[global::Cpp2ILInjected.Token(Token = "0x6000662")]
		[global::Cpp2ILInjected.Address(RVA = "0x19FD108", Offset = "0x19FD108", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public PlayStation4MacChromeUnityProfile()
		{
			throw null;
		}
	}
}
