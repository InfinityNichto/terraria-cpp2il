using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000659")]
	public class EntitySource_ByItemSourceId : IEntitySource
	{
		[global::Cpp2ILInjected.Token(Token = "0x60036F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D67C", Offset = "0x141D67C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "GetItemSource_Misc", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetItemSource_Misc", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItemSource_Death", ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItemSource_Misc", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TorchAttack", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "MassWireOperationInner", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Point),
			typeof(Point),
			typeof(Vector2),
			typeof(bool),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EntitySource_ByItemSourceId(Entity entity, int itemSourceId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007806")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly Entity Entity;

		[global::Cpp2ILInjected.Token(Token = "0x4007807")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly int SourceId;
	}
}
