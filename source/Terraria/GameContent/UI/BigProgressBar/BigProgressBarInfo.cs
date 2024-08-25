using System;
using Cpp2ILInjected;

namespace Terraria.GameContent.UI.BigProgressBar
{
	[global::Cpp2ILInjected.Token(Token = "0x2000AE5")]
	public struct BigProgressBarInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x4008A5C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int npcIndexToAimAt;

		[global::Cpp2ILInjected.Token(Token = "0x4008A5D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public bool validatedAtLeastOnce;

		[global::Cpp2ILInjected.Token(Token = "0x4008A5E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5")]
		public bool showText;
	}
}
