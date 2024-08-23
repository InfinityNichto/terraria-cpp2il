using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000BC RID: 188
	[Preserve]
	[UnityInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20000C9")]
	public class EightBitdoNES30ProMacUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000602 RID: 1538 RVA: 0x00003233 File Offset: 0x00001433
		[global::Cpp2ILInjected.Token(Token = "0x600061F")]
		[global::Cpp2ILInjected.Address(RVA = "0x19E9A8C", Offset = "0x19E9A8C", Length = "0xBA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 90)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00003236 File Offset: 0x00001436
		[global::Cpp2ILInjected.Token(Token = "0x6000620")]
		[global::Cpp2ILInjected.Address(RVA = "0x19EA62C", Offset = "0x19EA62C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public EightBitdoNES30ProMacUnityProfile()
		{
			throw null;
		}
	}
}
