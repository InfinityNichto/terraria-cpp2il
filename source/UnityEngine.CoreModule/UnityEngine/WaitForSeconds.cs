using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x200009C")]
	[StructLayout(0)]
	public sealed class WaitForSeconds : YieldInstruction
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000346")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal float m_Seconds;
	}
}
