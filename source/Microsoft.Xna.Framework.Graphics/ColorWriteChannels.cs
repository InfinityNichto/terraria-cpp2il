using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x200029D")]
[Flags]
public enum ColorWriteChannels
{
	[Cpp2IlInjected.Token(Token = "0x4001EE6")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4001EE7")]
	Red = 1,
	[Cpp2IlInjected.Token(Token = "0x4001EE8")]
	Green = 2,
	[Cpp2IlInjected.Token(Token = "0x4001EE9")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x4001EEA")]
	Alpha = 8,
	[Cpp2IlInjected.Token(Token = "0x4001EEB")]
	All = 0xF
}
