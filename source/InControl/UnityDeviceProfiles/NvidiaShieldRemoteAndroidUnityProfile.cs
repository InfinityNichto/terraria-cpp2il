﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.UnityDeviceProfiles
{
	[Preserve]
	[UnityInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x20000AB")]
	public class NvidiaShieldRemoteAndroidUnityProfile : InputDeviceProfile
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x19D734C", Offset = "0x19D734C", Length = "0x2DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "DPadLeftMapping", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlMapping))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "DPadRightMapping", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlMapping))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "DPadUpMapping", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlMapping))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "DPadDownMapping", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlMapping))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public override void Define()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60005DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x19D7628", Offset = "0x19D7628", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public NvidiaShieldRemoteAndroidUnityProfile()
		{
			throw null;
		}
	}
}
