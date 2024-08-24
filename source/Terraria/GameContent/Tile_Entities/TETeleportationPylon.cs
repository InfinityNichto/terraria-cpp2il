using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.Map;

namespace Terraria.GameContent.Tile_Entities
{
	// Token: 0x0200057E RID: 1406
	[global::Cpp2ILInjected.Token(Token = "0x2000817")]
	public class TETeleportationPylon : TileEntity
	{
		// Token: 0x06003B50 RID: 15184 RVA: 0x0002C987 File Offset: 0x0002AB87
		[global::Cpp2ILInjected.Token(Token = "0x6004267")]
		[global::Cpp2ILInjected.Address(RVA = "0x792034", Offset = "0x792034", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void RegisterTileEntityID(int assignedID)
		{
			throw null;
		}

		// Token: 0x06003B51 RID: 15185 RVA: 0x0002C98A File Offset: 0x0002AB8A
		[global::Cpp2ILInjected.Token(Token = "0x6004268")]
		[global::Cpp2ILInjected.Address(RVA = "0x792080", Offset = "0x792080", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileEntitiesManager), Member = "RegisterAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TETeleportationPylon), Member = "GenerateInstance", ReturnType = typeof(TileEntity))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TETeleportationPylon), Member = "Place", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileEntity), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public TETeleportationPylon()
		{
			throw null;
		}

		// Token: 0x06003B52 RID: 15186 RVA: 0x0002C98D File Offset: 0x0002AB8D
		[global::Cpp2ILInjected.Token(Token = "0x6004269")]
		[global::Cpp2ILInjected.Address(RVA = "0x7920D8", Offset = "0x7920D8", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TETeleportationPylon), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override TileEntity GenerateInstance()
		{
			throw null;
		}

		// Token: 0x06003B53 RID: 15187 RVA: 0x0002C990 File Offset: 0x0002AB90
		[global::Cpp2ILInjected.Token(Token = "0x600426A")]
		[global::Cpp2ILInjected.Address(RVA = "0x792128", Offset = "0x792128", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TETeleportationPylon), Member = "TryGetPylonTypeFromTileCoords", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref TeleportPylonType)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TeleportPylonsSystem), Member = "HasPylonOfType", MemberParameters = new object[] { typeof(TeleportPylonType) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TETeleportationPylon), Member = "RejectPlacementFromNet", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TETeleportationPylon), Member = "Place", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void NetPlaceEntityAttempt(int x, int y)
		{
			throw null;
		}

		// Token: 0x06003B54 RID: 15188 RVA: 0x0002C993 File Offset: 0x0002AB93
		[global::Cpp2ILInjected.Token(Token = "0x600426B")]
		[global::Cpp2ILInjected.Address(RVA = "0x792644", Offset = "0x792644", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeleportPylonsSystem), Member = "UpdatePylonsListAndBroadcastChanges", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TETeleportationPylon), Member = "TryGetPylonTypeFromTileCoords", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref TeleportPylonType)
		}, ReturnType = typeof(bool))]
		public bool TryGetPylonType(out TeleportPylonType pylonType)
		{
			throw null;
		}

		// Token: 0x06003B55 RID: 15189 RVA: 0x0002C996 File Offset: 0x0002AB96
		[global::Cpp2ILInjected.Token(Token = "0x600426C")]
		[global::Cpp2ILInjected.Address(RVA = "0x792324", Offset = "0x792324", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TETeleportationPylon), Member = "NetPlaceEntityAttempt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "KillTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void RejectPlacementFromNet(int x, int y)
		{
			throw null;
		}

		// Token: 0x06003B56 RID: 15190 RVA: 0x0002C999 File Offset: 0x0002AB99
		[global::Cpp2ILInjected.Token(Token = "0x600426D")]
		[global::Cpp2ILInjected.Address(RVA = "0x79242C", Offset = "0x79242C", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TETeleportationPylon), Member = "NetPlaceEntityAttempt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TETeleportationPylon), Member = "PlacementPreviewHook_AfterPlacement", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TETeleportationPylon), Member = ".ctor", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TeleportPylonsSystem), Member = "RequestImmediateUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static int Place(int x, int y)
		{
			throw null;
		}

		// Token: 0x06003B57 RID: 15191 RVA: 0x0002C99C File Offset: 0x0002AB9C
		[global::Cpp2ILInjected.Token(Token = "0x600426E")]
		[global::Cpp2ILInjected.Address(RVA = "0x792658", Offset = "0x792658", Length = "0x254")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TETeleportationPylon), Member = "Framing_CheckTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TeleportPylonsSystem), Member = "RequestImmediateUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public static void Kill(int x, int y)
		{
			throw null;
		}

		// Token: 0x06003B58 RID: 15192 RVA: 0x0002C99F File Offset: 0x0002AB9F
		[global::Cpp2ILInjected.Token(Token = "0x600426F")]
		[global::Cpp2ILInjected.Address(RVA = "0x7928AC", Offset = "0x7928AC", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(short), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06003B59 RID: 15193 RVA: 0x0002C9A2 File Offset: 0x0002ABA2
		[global::Cpp2ILInjected.Token(Token = "0x6004270")]
		[global::Cpp2ILInjected.Address(RVA = "0x79294C", Offset = "0x79294C", Length = "0x47C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "TileFrameDoWork", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Framing), Member = "GetTileSafely", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTileAllowBottomSlope", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TETeleportationPylon), Member = "Kill", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "KillTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static void Framing_CheckTile(int callX, int callY)
		{
			throw null;
		}

		// Token: 0x06003B5A RID: 15194 RVA: 0x0002C9A5 File Offset: 0x0002ABA5
		[global::Cpp2ILInjected.Token(Token = "0x6004271")]
		[global::Cpp2ILInjected.Address(RVA = "0x792DC8", Offset = "0x792DC8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TileInteractionsMouseOver", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		public static int GetPylonStyleFromTile(Tile tile)
		{
			throw null;
		}

		// Token: 0x06003B5B RID: 15195 RVA: 0x0002C9A8 File Offset: 0x0002ABA8
		[global::Cpp2ILInjected.Token(Token = "0x6004272")]
		[global::Cpp2ILInjected.Address(RVA = "0x792E04", Offset = "0x792E04", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TileInteractionsMouseOver", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeleportPylonsMapLayer), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ref MapOverlayDrawContext),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static int GetPylonItemTypeFromTileStyle(int style)
		{
			throw null;
		}

		// Token: 0x06003B5C RID: 15196 RVA: 0x0002C9AB File Offset: 0x0002ABAB
		[global::Cpp2ILInjected.Token(Token = "0x6004273")]
		[global::Cpp2ILInjected.Address(RVA = "0x792E28", Offset = "0x792E28", Length = "0x190")]
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
		public override bool IsTileValidForEntity(int x, int y)
		{
			throw null;
		}

		// Token: 0x06003B5D RID: 15197 RVA: 0x0002C9AE File Offset: 0x0002ABAE
		[global::Cpp2ILInjected.Token(Token = "0x6004274")]
		[global::Cpp2ILInjected.Address(RVA = "0x792FB8", Offset = "0x792FB8", Length = "0x1D0")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TETeleportationPylon), Member = "Place", MemberParameters = new object[]
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
		public static int PlacementPreviewHook_AfterPlacement(int x, int y, int type = 597, int style = 0, int direction = 1, int alternate = 0)
		{
			throw null;
		}

		// Token: 0x06003B5E RID: 15198 RVA: 0x0002C9B1 File Offset: 0x0002ABB1
		[global::Cpp2ILInjected.Token(Token = "0x6004275")]
		[global::Cpp2ILInjected.Address(RVA = "0x793188", Offset = "0x793188", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TeleportPylonsSystem), Member = "HasPylonOfType", MemberParameters = new object[] { typeof(TeleportPylonType) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int PlacementPreviewHook_CheckIfCanPlace(int x, int y, int type = 597, int style = 0, int direction = 1, int alternate = 0)
		{
			throw null;
		}

		// Token: 0x06003B5F RID: 15199 RVA: 0x0002C9B4 File Offset: 0x0002ABB4
		[global::Cpp2ILInjected.Token(Token = "0x6004276")]
		[global::Cpp2ILInjected.Address(RVA = "0x792234", Offset = "0x792234", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TETeleportationPylon), Member = "NetPlaceEntityAttempt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TETeleportationPylon), Member = "TryGetPylonType", MemberParameters = new object[] { typeof(ref TeleportPylonType) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool TryGetPylonTypeFromTileCoords(int x, int y, out TeleportPylonType pylonType)
		{
			throw null;
		}

		// Token: 0x06003B60 RID: 15200 RVA: 0x0002C9B7 File Offset: 0x0002ABB7
		[global::Cpp2ILInjected.Token(Token = "0x6004277")]
		[global::Cpp2ILInjected.Address(RVA = "0x7931F4", Offset = "0x7931F4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static TeleportPylonType GetPylonTypeFromPylonTileStyle(int pylonStyle)
		{
			throw null;
		}

		// Token: 0x06003B61 RID: 15201 RVA: 0x0002C9BA File Offset: 0x0002ABBA
		[global::Cpp2ILInjected.Token(Token = "0x6004278")]
		[global::Cpp2ILInjected.Address(RVA = "0x7931F8", Offset = "0x7931F8", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "CompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryWriter),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static int Find(int x, int y)
		{
			throw null;
		}

		// Token: 0x04006AFD RID: 27389
		[global::Cpp2ILInjected.Token(Token = "0x40080E4")]
		private static byte _myEntityID;

		// Token: 0x04006AFE RID: 27390
		[global::Cpp2ILInjected.Token(Token = "0x40080E5")]
		private const int MyTileID = 597;

		// Token: 0x04006AFF RID: 27391
		[global::Cpp2ILInjected.Token(Token = "0x40080E6")]
		private const int entityTileWidth = 3;

		// Token: 0x04006B00 RID: 27392
		[global::Cpp2ILInjected.Token(Token = "0x40080E7")]
		private const int entityTileHeight = 4;
	}
}
