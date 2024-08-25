using System;
using Cpp2ILInjected;

namespace Terraria.GameContent.Bestiary
{
	[global::Cpp2ILInjected.Token(Token = "0x2000948")]
	public struct BestiaryUICollectionInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x4008379")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public BestiaryEntry OwnerEntry;

		[global::Cpp2ILInjected.Token(Token = "0x400837A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public BestiaryEntryUnlockState UnlockState;
	}
}
