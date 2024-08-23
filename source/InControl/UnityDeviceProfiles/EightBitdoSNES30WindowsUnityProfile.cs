using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000EF RID: 239
	[Preserve]
	[UnityInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20000FC")]
	public class EightBitdoSNES30WindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000668 RID: 1640 RVA: 0x00003365 File Offset: 0x00001565
		[global::Cpp2ILInjected.Token(Token = "0x6000685")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A099C4", Offset = "0x1A099C4", Length = "0x694")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 53)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00003368 File Offset: 0x00001568
		[global::Cpp2ILInjected.Token(Token = "0x6000686")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A0A058", Offset = "0x1A0A058", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public EightBitdoSNES30WindowsUnityProfile()
		{
			throw null;
		}
	}
}
