using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001A5 RID: 421
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20001B2")]
	public class EightBitdoNES30ProUSBMacNativeProfile : InputDeviceProfile
	{
		// Token: 0x060007D4 RID: 2004 RVA: 0x000037A9 File Offset: 0x000019A9
		[global::Cpp2ILInjected.Token(Token = "0x60007F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2BB60", Offset = "0x1A2BB60", Length = "0xB68")]
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

		// Token: 0x060007D5 RID: 2005 RVA: 0x000037AC File Offset: 0x000019AC
		[global::Cpp2ILInjected.Token(Token = "0x60007F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2C6C8", Offset = "0x1A2C6C8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public EightBitdoNES30ProUSBMacNativeProfile()
		{
			throw null;
		}
	}
}
