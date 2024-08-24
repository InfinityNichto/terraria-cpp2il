using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.GameContent.Drawing;
using Terraria.ID;
using Terraria.Localization;

namespace Terraria.GameContent.Tile_Entities
{
	// Token: 0x0200057C RID: 1404
	[global::Cpp2ILInjected.Token(Token = "0x2000814")]
	public class TEItemFrame : TileEntity, IFixLoadedData
	{
		// Token: 0x06003B23 RID: 15139 RVA: 0x0002C900 File Offset: 0x0002AB00
		[global::Cpp2ILInjected.Token(Token = "0x600423A")]
		[global::Cpp2ILInjected.Address(RVA = "0x78E1B0", Offset = "0x78E1B0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void RegisterTileEntityID(int assignedID)
		{
			throw null;
		}

		// Token: 0x06003B24 RID: 15140 RVA: 0x0002C903 File Offset: 0x0002AB03
		[global::Cpp2ILInjected.Token(Token = "0x600423B")]
		[global::Cpp2ILInjected.Address(RVA = "0x78E1FC", Offset = "0x78E1FC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void NetPlaceEntityAttempt(int x, int y)
		{
			throw null;
		}

		// Token: 0x06003B25 RID: 15141 RVA: 0x0002C906 File Offset: 0x0002AB06
		[global::Cpp2ILInjected.Token(Token = "0x600423C")]
		[global::Cpp2ILInjected.Address(RVA = "0x78E208", Offset = "0x78E208", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TEItemFrame), Member = "Place", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void NetPlaceEntity(int x, int y)
		{
			throw null;
		}

		// Token: 0x06003B26 RID: 15142 RVA: 0x0002C909 File Offset: 0x0002AB09
		[global::Cpp2ILInjected.Token(Token = "0x600423D")]
		[global::Cpp2ILInjected.Address(RVA = "0x78E494", Offset = "0x78E494", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TEItemFrame), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override TileEntity GenerateInstance()
		{
			throw null;
		}

		// Token: 0x06003B27 RID: 15143 RVA: 0x0002C90C File Offset: 0x0002AB0C
		[global::Cpp2ILInjected.Token(Token = "0x600423E")]
		[global::Cpp2ILInjected.Address(RVA = "0x78E4E4", Offset = "0x78E4E4", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileEntitiesManager), Member = "RegisterAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEItemFrame), Member = "GenerateInstance", ReturnType = typeof(TileEntity))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEItemFrame), Member = "Place", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileEntity), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public TEItemFrame()
		{
			throw null;
		}

		// Token: 0x06003B28 RID: 15144 RVA: 0x0002C90F File Offset: 0x0002AB0F
		[global::Cpp2ILInjected.Token(Token = "0x600423F")]
		[global::Cpp2ILInjected.Address(RVA = "0x78E2B4", Offset = "0x78E2B4", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEItemFrame), Member = "NetPlaceEntity", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEItemFrame), Member = "Hook_AfterPlacement", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TEItemFrame), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point16), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileEntity), Member = "AssignNewID", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileEntity), Member = "get_PositionKey", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static int Place(int x, int y)
		{
			throw null;
		}

		// Token: 0x06003B29 RID: 15145 RVA: 0x0002C912 File Offset: 0x0002AB12
		[global::Cpp2ILInjected.Token(Token = "0x6004240")]
		[global::Cpp2ILInjected.Address(RVA = "0x78E56C", Offset = "0x78E56C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool IsTileValidForEntity(int x, int y)
		{
			throw null;
		}

		// Token: 0x06003B2A RID: 15146 RVA: 0x0002C915 File Offset: 0x0002AB15
		[global::Cpp2ILInjected.Token(Token = "0x6004241")]
		[global::Cpp2ILInjected.Address(RVA = "0x78E708", Offset = "0x78E708", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendTileSquare", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(TileChangeType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TEItemFrame), Member = "Place", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static int Hook_AfterPlacement(int x, int y, int type = 395, int style = 0, int direction = 1, int alternate = 0)
		{
			throw null;
		}

		// Token: 0x06003B2B RID: 15147 RVA: 0x0002C918 File Offset: 0x0002AB18
		[global::Cpp2ILInjected.Token(Token = "0x6004242")]
		[global::Cpp2ILInjected.Address(RVA = "0x78E8C0", Offset = "0x78E8C0", Length = "0x208")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CheckSign", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileEntity), Member = "GetKey", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static void Kill(int x, int y)
		{
			throw null;
		}

		// Token: 0x06003B2C RID: 15148 RVA: 0x0002C91B File Offset: 0x0002AB1B
		[global::Cpp2ILInjected.Token(Token = "0x6004243")]
		[global::Cpp2ILInjected.Address(RVA = "0x78EAC8", Offset = "0x78EAC8", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "CanInteract", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Item),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "CompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryWriter),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TileInteractionsMouseOver", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CheckSign", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "KillTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEItemFrame), Member = "TryPlacing", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEItemFrame), Member = "OnPlayerInteraction", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEItemFrame), Member = "PlaceItemInFrame", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "CacheSpecialDraws", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileEntity), Member = "GetKey", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static int Find(int x, int y)
		{
			throw null;
		}

		// Token: 0x06003B2D RID: 15149 RVA: 0x0002C91E File Offset: 0x0002AB1E
		[global::Cpp2ILInjected.Token(Token = "0x6004244")]
		[global::Cpp2ILInjected.Address(RVA = "0x78E578", Offset = "0x78E578", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static bool ValidTile(int x, int y)
		{
			throw null;
		}

		// Token: 0x06003B2E RID: 15150 RVA: 0x0002C921 File Offset: 0x0002AB21
		[global::Cpp2ILInjected.Token(Token = "0x6004245")]
		[global::Cpp2ILInjected.Address(RVA = "0x78EBAC", Offset = "0x78EBAC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteExtraData(BinaryWriter writer, bool networkSend)
		{
			throw null;
		}

		// Token: 0x06003B2F RID: 15151 RVA: 0x0002C924 File Offset: 0x0002AB24
		[global::Cpp2ILInjected.Token(Token = "0x6004246")]
		[global::Cpp2ILInjected.Address(RVA = "0x78EC14", Offset = "0x78EC14", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "netDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Prefix", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void ReadExtraData(BinaryReader reader, bool networkSend)
		{
			throw null;
		}

		// Token: 0x06003B30 RID: 15152 RVA: 0x0002C927 File Offset: 0x0002AB27
		[global::Cpp2ILInjected.Token(Token = "0x6004247")]
		[global::Cpp2ILInjected.Address(RVA = "0x78ECE0", Offset = "0x78ECE0", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(short), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06003B31 RID: 15153 RVA: 0x0002C92A File Offset: 0x0002AB2A
		[global::Cpp2ILInjected.Token(Token = "0x6004248")]
		[global::Cpp2ILInjected.Address(RVA = "0x78EE58", Offset = "0x78EE58", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CheckSign", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "KillTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEItemFrame), Member = "TryPlacing", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LogicHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntitySource_TileBreak), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "NewItem", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void DropItem()
		{
			throw null;
		}

		// Token: 0x06003B32 RID: 15154 RVA: 0x0002C92D File Offset: 0x0002AB2D
		[global::Cpp2ILInjected.Token(Token = "0x6004249")]
		[global::Cpp2ILInjected.Address(RVA = "0x78EF88", Offset = "0x78EF88", Length = "0x350")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEItemFrame), Member = "PlaceItemInFrame", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "RangeFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TEItemFrame), Member = "Find", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TEItemFrame), Member = "DropItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "netDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Prefix", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntitySource_TileBreak), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "NewItem", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static void TryPlacing(int x, int y, int netid, int prefix, int stack)
		{
			throw null;
		}

		// Token: 0x06003B33 RID: 15155 RVA: 0x0002C930 File Offset: 0x0002AB30
		[global::Cpp2ILInjected.Token(Token = "0x600424A")]
		[global::Cpp2ILInjected.Address(RVA = "0x78F2D8", Offset = "0x78F2D8", Length = "0x33C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TileInteractionsUse", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TEItemFrame), Member = "Find", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "GamepadEnableGrappleCooldown", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "KillTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClient", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TEItemFrame), Member = "PlaceItemInFrame", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public static void OnPlayerInteraction(Player player, int clickX, int clickY)
		{
			throw null;
		}

		// Token: 0x06003B34 RID: 15156 RVA: 0x0002C933 File Offset: 0x0002AB33
		[global::Cpp2ILInjected.Token(Token = "0x600424B")]
		[global::Cpp2ILInjected.Address(RVA = "0x78F614", Offset = "0x78F614", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool FitsItemFrame(Item i)
		{
			throw null;
		}

		// Token: 0x06003B35 RID: 15157 RVA: 0x0002C936 File Offset: 0x0002AB36
		[global::Cpp2ILInjected.Token(Token = "0x600424C")]
		[global::Cpp2ILInjected.Address(RVA = "0x78F624", Offset = "0x78F624", Length = "0x450")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEItemFrame), Member = "OnPlayerInteraction", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TEItemFrame), Member = "Find", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "KillTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClient", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_tileTargetX", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TEItemFrame), Member = "TryPlacing", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Clone", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseItem", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "RangeFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public static void PlaceItemInFrame(Player player, int x, int y)
		{
			throw null;
		}

		// Token: 0x06003B36 RID: 15158 RVA: 0x0002C939 File Offset: 0x0002AB39
		[global::Cpp2ILInjected.Token(Token = "0x600424D")]
		[global::Cpp2ILInjected.Address(RVA = "0x78FA74", Offset = "0x78FA74", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "FixAgainstExploit", ReturnType = typeof(void))]
		public void FixLoadedData()
		{
			throw null;
		}

		// Token: 0x04006AF2 RID: 27378
		[global::Cpp2ILInjected.Token(Token = "0x40080D0")]
		private static byte _myEntityID;

		// Token: 0x04006AF3 RID: 27379
		[global::Cpp2ILInjected.Token(Token = "0x40080D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public Item item;
	}
}
