using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x200064F")]
	public class EntitySource_ItemOpen : IEntitySource
	{
		[global::Cpp2ILInjected.Token(Token = "0x60036ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D3D0", Offset = "0x141D3D0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItemSource_OpenItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EntitySource_ItemOpen(Entity entity, int itemType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40077FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly Entity Entity;

		[global::Cpp2ILInjected.Token(Token = "0x40077FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly int ItemType;
	}
}
