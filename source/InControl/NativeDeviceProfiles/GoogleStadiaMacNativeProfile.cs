using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001A8 RID: 424
	[NativeInputDeviceProfile]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20001B5")]
	public class GoogleStadiaMacNativeProfile : InputDeviceProfile
	{
		// Token: 0x060007DA RID: 2010 RVA: 0x000037BB File Offset: 0x000019BB
		[global::Cpp2ILInjected.Token(Token = "0x60007F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2D560", Offset = "0x1A2D560", Length = "0xC94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(OptionalUInt16))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Button", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Analog", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(InputControlSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 97)]
		public override void Define()
		{
			throw null;
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x000037BE File Offset: 0x000019BE
		[global::Cpp2ILInjected.Token(Token = "0x60007F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A2E1F4", Offset = "0x1A2E1F4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public GoogleStadiaMacNativeProfile()
		{
			throw null;
		}
	}
}
