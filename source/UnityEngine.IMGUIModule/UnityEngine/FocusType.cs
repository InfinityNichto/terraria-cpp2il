using System;
using Cpp2ILInjected;

namespace UnityEngine
{
	[global::Cpp2ILInjected.Token(Token = "0x2000006")]
	public enum FocusType
	{
		[Obsolete("FocusType.Native now behaves the same as FocusType.Passive in all OS cases. (UnityUpgradable) -> Passive", false)]
		[global::Cpp2ILInjected.Token(Token = "0x400001D")]
		Native,
		[global::Cpp2ILInjected.Token(Token = "0x400001E")]
		Keyboard,
		[global::Cpp2ILInjected.Token(Token = "0x400001F")]
		Passive
	}
}
