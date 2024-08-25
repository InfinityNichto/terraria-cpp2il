using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000664")]
	public abstract class AEntitySource_OnHit : IEntitySource
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003702")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D79C", Offset = "0x141D79C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public AEntitySource_OnHit(Entity entityStriking, Entity entityStruck)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400780D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly Entity EntityStriking;

		[global::Cpp2ILInjected.Token(Token = "0x400780E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly Entity EntityStruck;
	}
}
