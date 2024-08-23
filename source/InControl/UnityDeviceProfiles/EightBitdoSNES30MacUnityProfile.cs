using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000BE RID: 190
	[Preserve]
	[UnityInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20000CB")]
	public class EightBitdoSNES30MacUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000606 RID: 1542 RVA: 0x0000323F File Offset: 0x0000143F
		[global::Cpp2ILInjected.Token(Token = "0x6000623")]
		[global::Cpp2ILInjected.Address(RVA = "0x19EAD9C", Offset = "0x19EAD9C", Length = "0x6C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 54)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00003242 File Offset: 0x00001442
		[global::Cpp2ILInjected.Token(Token = "0x6000624")]
		[global::Cpp2ILInjected.Address(RVA = "0x19EB45C", Offset = "0x19EB45C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public EightBitdoSNES30MacUnityProfile()
		{
			throw null;
		}
	}
}
