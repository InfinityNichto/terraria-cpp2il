﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001AF RID: 431
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20001BC")]
	public class PowerANintendoSwitchMacNativeProfile : InputDeviceProfile
	{
		// Token: 0x060007E8 RID: 2024 RVA: 0x000037E5 File Offset: 0x000019E5
		[global::Cpp2ILInjected.Token(Token = "0x6000805")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A320A4", Offset = "0x1A320A4", Length = "0xC30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 94)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x000037E8 File Offset: 0x000019E8
		[global::Cpp2ILInjected.Token(Token = "0x6000806")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A32CD4", Offset = "0x1A32CD4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public PowerANintendoSwitchMacNativeProfile()
		{
			throw null;
		}
	}
}