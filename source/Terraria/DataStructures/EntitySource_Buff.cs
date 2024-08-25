using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x200064D")]
	public class EntitySource_Buff : IEntitySource
	{
		[global::Cpp2ILInjected.Token(Token = "0x60036EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D368", Offset = "0x141D368", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetProjectileSource_Buff", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EntitySource_Buff(Entity entity, int buffId, int buffIndex)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40077F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly Entity Entity;

		[global::Cpp2ILInjected.Token(Token = "0x40077F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly int BuffId;

		[global::Cpp2ILInjected.Token(Token = "0x40077FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public readonly int BuffIndex;
	}
}
