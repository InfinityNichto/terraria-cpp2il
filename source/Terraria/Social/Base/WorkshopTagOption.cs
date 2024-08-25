using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Social.Base
{
	[global::Cpp2ILInjected.Token(Token = "0x2000539")]
	public class WorkshopTagOption
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003225")]
		[global::Cpp2ILInjected.Address(RVA = "0x132A950", Offset = "0x132A950", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public WorkshopTagOption(string nameKey, string internalName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003B7D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly string NameKey;

		[global::Cpp2ILInjected.Token(Token = "0x4003B7E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly string InternalNameForAPIs;
	}
}
