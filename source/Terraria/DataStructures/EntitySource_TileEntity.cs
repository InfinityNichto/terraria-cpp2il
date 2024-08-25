using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.Tile_Entities;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000669")]
	public class EntitySource_TileEntity : IEntitySource
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003707")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D850", Offset = "0x141D850", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TETrainingDummy), Member = "Activate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EntitySource_TileEntity(TileEntity tileEntity)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007811")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public TileEntity TileEntity;
	}
}
