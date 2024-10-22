﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20001A6")]
	public class ThrustMasterFerrari430RacingWheelMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		[global::Cpp2ILInjected.Token(Token = "0x60007D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2A050", Offset = "0x1A2A050", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60007DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2A118", Offset = "0x1A2A118", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public ThrustMasterFerrari430RacingWheelMacNativeProfile()
		{
			throw null;
		}
	}
}
