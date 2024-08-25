using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	[global::Cpp2ILInjected.Token(Token = "0x20003DE")]
	[global::System.Serializable]
	internal class FixupHolder
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001F67")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B57F10", Offset = "0x1B57F10", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal FixupHolder(long id, object fixupInfo, int fixupType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000FB0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal long m_id;

		[global::Cpp2ILInjected.Token(Token = "0x4000FB1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal object m_fixupInfo;

		[global::Cpp2ILInjected.Token(Token = "0x4000FB2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int m_fixupType;
	}
}
