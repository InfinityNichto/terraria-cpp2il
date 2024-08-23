﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000E5 RID: 229
	[Preserve]
	[UnityInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20000F2")]
	public class NintendoSwitchProWindowsChromeUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000654 RID: 1620 RVA: 0x00003329 File Offset: 0x00001529
		[global::Cpp2ILInjected.Token(Token = "0x6000671")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A02B38", Offset = "0x1A02B38", Length = "0xD24")]
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

		// Token: 0x06000655 RID: 1621 RVA: 0x0000332C File Offset: 0x0000152C
		[global::Cpp2ILInjected.Token(Token = "0x6000672")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A0385C", Offset = "0x1A0385C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public NintendoSwitchProWindowsChromeUnityProfile()
		{
			throw null;
		}
	}
}