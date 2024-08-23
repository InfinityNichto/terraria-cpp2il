﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000155 RID: 341
	[Preserve]
	[NativeInputDeviceProfile]
	[global::Cpp2ILInjected.Token(Token = "0x2000162")]
	public class MadCatzFightStickTE2MacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000734 RID: 1844 RVA: 0x000035C9 File Offset: 0x000017C9
		[global::Cpp2ILInjected.Token(Token = "0x6000751")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A26008", Offset = "0x1A26008", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x000035CC File Offset: 0x000017CC
		[global::Cpp2ILInjected.Token(Token = "0x6000752")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A260D0", Offset = "0x1A260D0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Xbox360DriverMacNativeProfile), Member = ".ctor", ReturnType = typeof(void))]
		public MadCatzFightStickTE2MacNativeProfile()
		{
			throw null;
		}
	}
}