using System;
using Cpp2ILInjected;

namespace Microsoft.Xna.Framework
{
	// Token: 0x0200025F RID: 607
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000320")]
	public enum BatteryChargeStatus
	{
		// Token: 0x04001C47 RID: 7239
		[global::Cpp2ILInjected.Token(Token = "0x4002221")]
		Charging = 8,
		// Token: 0x04001C48 RID: 7240
		[global::Cpp2ILInjected.Token(Token = "0x4002222")]
		Critical = 4,
		// Token: 0x04001C49 RID: 7241
		[global::Cpp2ILInjected.Token(Token = "0x4002223")]
		High = 1,
		// Token: 0x04001C4A RID: 7242
		[global::Cpp2ILInjected.Token(Token = "0x4002224")]
		Low = 2,
		// Token: 0x04001C4B RID: 7243
		[global::Cpp2ILInjected.Token(Token = "0x4002225")]
		NoSystemBattery = 128,
		// Token: 0x04001C4C RID: 7244
		[global::Cpp2ILInjected.Token(Token = "0x4002226")]
		Unknown = 255
	}
}
