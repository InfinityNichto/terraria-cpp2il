﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000164 RID: 356
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x2000171")]
	public class MadCatzSF4FightStickSEMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000752 RID: 1874 RVA: 0x00003623 File Offset: 0x00001823
		[global::Cpp2ILInjected.Token(Token = "0x600076F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A26BFC", Offset = "0x1A26BFC", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00003626 File Offset: 0x00001826
		[global::Cpp2ILInjected.Token(Token = "0x6000770")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A26CC4", Offset = "0x1A26CC4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public MadCatzSF4FightStickSEMacNativeProfile()
		{
			throw null;
		}
	}
}