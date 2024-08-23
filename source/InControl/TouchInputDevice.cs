using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	// Token: 0x0200004A RID: 74
	[global::Cpp2ILInjected.Token(Token = "0x2000052")]
	public class TouchInputDevice : InputDevice
	{
		// Token: 0x060003C8 RID: 968 RVA: 0x00002B88 File Offset: 0x00000D88
		[global::Cpp2ILInjected.Token(Token = "0x60003D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A1C68", Offset = "0x19A1C68", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "CreateDevice", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public TouchInputDevice()
		{
			throw null;
		}
	}
}
