using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000660")]
	public class EntitySource_DropAsItem : IEntitySource
	{
		[global::Cpp2ILInjected.Token(Token = "0x60036FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D6FC", Offset = "0x141D6FC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "GetItemSource_DropAsItem", ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EntitySource_DropAsItem(Entity entity)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007809")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly Entity Entity;
	}
}
