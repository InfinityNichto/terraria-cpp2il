using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000ED RID: 237
	[Preserve]
	[UnityInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20000FA")]
	public class EightBitdoNES30ProWindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000664 RID: 1636 RVA: 0x00003359 File Offset: 0x00001559
		[global::Cpp2ILInjected.Token(Token = "0x6000681")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A086E4", Offset = "0x1A086E4", Length = "0xB9C")]
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

		// Token: 0x06000665 RID: 1637 RVA: 0x0000335C File Offset: 0x0000155C
		[global::Cpp2ILInjected.Token(Token = "0x6000682")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A09280", Offset = "0x1A09280", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public EightBitdoNES30ProWindowsUnityProfile()
		{
			throw null;
		}
	}
}
