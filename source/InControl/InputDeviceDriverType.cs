using System;
using Cpp2ILInjected;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200002D RID: 45
	[global::Cpp2ILInjected.Token(Token = "0x200002F")]
	public enum InputDeviceDriverType : ushort
	{
		// Token: 0x04000235 RID: 565
		[global::Cpp2ILInjected.Token(Token = "0x400023C")]
		Unknown,
		// Token: 0x04000236 RID: 566
		[global::Cpp2ILInjected.Token(Token = "0x400023D")]
		HID,
		// Token: 0x04000237 RID: 567
		[global::Cpp2ILInjected.Token(Token = "0x400023E")]
		USB,
		// Token: 0x04000238 RID: 568
		[global::Cpp2ILInjected.Token(Token = "0x400023F")]
		Bluetooth,
		// Token: 0x04000239 RID: 569
		[InspectorName("XInput")]
		[global::Cpp2ILInjected.Token(Token = "0x4000240")]
		XInput,
		// Token: 0x0400023A RID: 570
		[InspectorName("DirectInput")]
		[global::Cpp2ILInjected.Token(Token = "0x4000241")]
		DirectInput,
		// Token: 0x0400023B RID: 571
		[InspectorName("RawInput")]
		[global::Cpp2ILInjected.Token(Token = "0x4000242")]
		RawInput
	}
}
