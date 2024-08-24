using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.Tile_Entities;
using Terraria.IO;

namespace Terraria.DataStructures
{
	// Token: 0x0200047A RID: 1146
	[global::Cpp2ILInjected.Token(Token = "0x200067D")]
	public class TileEntitiesManager
	{
		// Token: 0x06003222 RID: 12834 RVA: 0x0002AF7D File Offset: 0x0002917D
		[global::Cpp2ILInjected.Token(Token = "0x600374B")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E8C8", Offset = "0x141E8C8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int AssignNewID()
		{
			throw null;
		}

		// Token: 0x06003223 RID: 12835 RVA: 0x0002AF80 File Offset: 0x00029180
		[global::Cpp2ILInjected.Token(Token = "0x600374C")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E8DC", Offset = "0x141E8DC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool InvalidEntityID(int id)
		{
			throw null;
		}

		// Token: 0x06003224 RID: 12836 RVA: 0x0002AF83 File Offset: 0x00029183
		[global::Cpp2ILInjected.Token(Token = "0x600374D")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E8F8", Offset = "0x141E8F8", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileEntity), Member = "InitializeAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TETrainingDummy), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileEntitiesManager), Member = "Register", MemberParameters = new object[] { typeof(TileEntity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TEItemFrame), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TELogicSensor), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TEDisplayDoll), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TEWeaponsRack), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TEHatRack), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TEFoodPlatter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TETeleportationPylon), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public void RegisterAll()
		{
			throw null;
		}

		// Token: 0x06003225 RID: 12837 RVA: 0x0002AF86 File Offset: 0x00029186
		[global::Cpp2ILInjected.Token(Token = "0x600374E")]
		[global::Cpp2ILInjected.Address(RVA = "0x141EAE0", Offset = "0x141EAE0", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileEntitiesManager), Member = "RegisterAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Register(TileEntity entity)
		{
			throw null;
		}

		// Token: 0x06003226 RID: 12838 RVA: 0x0002AF89 File Offset: 0x00029189
		[global::Cpp2ILInjected.Token(Token = "0x600374F")]
		[global::Cpp2ILInjected.Address(RVA = "0x141EB60", Offset = "0x141EB60", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadTileEntities", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadTileEntities", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadTileEntities", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool CheckValidTile(int id, int x, int y)
		{
			throw null;
		}

		// Token: 0x06003227 RID: 12839 RVA: 0x0002AF8C File Offset: 0x0002918C
		[global::Cpp2ILInjected.Token(Token = "0x6003750")]
		[global::Cpp2ILInjected.Address(RVA = "0x141EBFC", Offset = "0x141EBFC", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileEntity), Member = "PlaceEntityNet", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void NetPlaceEntity(int id, int x, int y)
		{
			throw null;
		}

		// Token: 0x06003228 RID: 12840 RVA: 0x0002AF8F File Offset: 0x0002918F
		[global::Cpp2ILInjected.Token(Token = "0x6003751")]
		[global::Cpp2ILInjected.Address(RVA = "0x141ECC0", Offset = "0x141ECC0", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileEntity), Member = "Read", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(bool)
		}, ReturnType = typeof(TileEntity))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileEntity), Member = "ReadPos32", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(bool)
		}, ReturnType = typeof(TileEntity))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public TileEntity GenerateInstance(int id)
		{
			throw null;
		}

		// Token: 0x06003229 RID: 12841 RVA: 0x0002AF92 File Offset: 0x00029192
		[global::Cpp2ILInjected.Token(Token = "0x6003752")]
		[global::Cpp2ILInjected.Address(RVA = "0x141ED40", Offset = "0x141ED40", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileEntity), Member = "InitializeAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public TileEntitiesManager()
		{
			throw null;
		}

		// Token: 0x04006478 RID: 25720
		[global::Cpp2ILInjected.Token(Token = "0x4007874")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _nextEntityID;

		// Token: 0x04006479 RID: 25721
		[global::Cpp2ILInjected.Token(Token = "0x4007875")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Dictionary<int, TileEntity> _types;
	}
}
