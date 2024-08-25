using System;
using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace Unity.IO.LowLevel.Unsafe
{
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x200000C")]
	public enum FileState
	{
		[global::Cpp2ILInjected.Token(Token = "0x400000E")]
		Absent,
		[global::Cpp2ILInjected.Token(Token = "0x400000F")]
		Exists
	}
}
