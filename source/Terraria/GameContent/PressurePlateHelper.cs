using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.IO;
using Terraria.Localization;

namespace Terraria.GameContent
{
	// Token: 0x02000541 RID: 1345
	[global::Cpp2ILInjected.Token(Token = "0x20007B3")]
	public class PressurePlateHelper
	{
		// Token: 0x06003975 RID: 14709 RVA: 0x0002C42F File Offset: 0x0002A62F
		[global::Cpp2ILInjected.Token(Token = "0x600403C")]
		[global::Cpp2ILInjected.Address(RVA = "0x76B040", Offset = "0x76B040", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdateInWorld", MemberParameters = new object[] { typeof(Stopwatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>), Member = "get_Keys", ReturnType = "KeyCollection<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>.KeyCollection), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>.KeyCollection.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PressurePlateHelper), Member = "PokeLocation", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>.KeyCollection.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static void Update()
		{
			throw null;
		}

		// Token: 0x06003976 RID: 14710 RVA: 0x0002C432 File Offset: 0x0002A632
		[global::Cpp2ILInjected.Token(Token = "0x600403D")]
		[global::Cpp2ILInjected.Address(RVA = "0x76B330", Offset = "0x76B330", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWeightedPressurePlates", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadWeightedPressurePlates", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadWeightedPressurePlates", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void Reset()
		{
			throw null;
		}

		// Token: 0x06003977 RID: 14711 RVA: 0x0002C435 File Offset: 0x0002A635
		[global::Cpp2ILInjected.Token(Token = "0x600403E")]
		[global::Cpp2ILInjected.Address(RVA = "0x76B464", Offset = "0x76B464", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player.Hooks), Member = "PlayerConnect", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player.Hooks), Member = "PlayerDisconnect", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>), Member = "get_Keys", ReturnType = "KeyCollection<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToArray", MemberTypeParameters = new object[] { typeof(Point) }, MemberParameters = new object[] { typeof(IEnumerable<Point>) }, ReturnType = "TSource[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PressurePlateHelper), Member = "MoveAwayFrom", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void ResetPlayer(int player)
		{
			throw null;
		}

		// Token: 0x06003978 RID: 14712 RVA: 0x0002C438 File Offset: 0x0002A638
		[global::Cpp2ILInjected.Token(Token = "0x600403F")]
		[global::Cpp2ILInjected.Address(RVA = "0x76B73C", Offset = "0x76B73C", Length = "0x634")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Teleport", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToVector2", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Size", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "GetTilesIn", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(List<Point>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_BottomRight", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Hitbox", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Inflate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Intersects", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>), Member = "Contains", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PressurePlateHelper), Member = "MoveAwayFrom", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PressurePlateHelper), Member = "MoveInto", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public static void UpdatePlayerPosition(Player player)
		{
			throw null;
		}

		// Token: 0x06003979 RID: 14713 RVA: 0x0002C43B File Offset: 0x0002A63B
		[global::Cpp2ILInjected.Token(Token = "0x6004040")]
		[global::Cpp2ILInjected.Address(RVA = "0x76BFA4", Offset = "0x76BFA4", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "KillTile_GetItemDrops", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Tile),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>), Member = "Remove", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PressurePlateHelper), Member = "PokeLocation", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void DestroyPlate(Point location)
		{
			throw null;
		}

		// Token: 0x0600397A RID: 14714 RVA: 0x0002C43E File Offset: 0x0002A63E
		[global::Cpp2ILInjected.Token(Token = "0x6004041")]
		[global::Cpp2ILInjected.Address(RVA = "0x76C078", Offset = "0x76C078", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PressurePlateHelper), Member = "MoveInto", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PressurePlateHelper), Member = "MoveAwayFrom", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void UpdatePlatePosition(Point location, int player, bool onIt)
		{
			throw null;
		}

		// Token: 0x0600397B RID: 14715 RVA: 0x0002C441 File Offset: 0x0002A641
		[global::Cpp2ILInjected.Token(Token = "0x6004042")]
		[global::Cpp2ILInjected.Address(RVA = "0x76BD70", Offset = "0x76BD70", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PressurePlateHelper), Member = "UpdatePlayerPosition", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PressurePlateHelper), Member = "UpdatePlatePosition", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>), Member = "get_Item", MemberParameters = new object[] { typeof(Point) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PressurePlateHelper), Member = "PokeLocation", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private static void MoveInto(Point location, int player)
		{
			throw null;
		}

		// Token: 0x0600397C RID: 14716 RVA: 0x0002C444 File Offset: 0x0002A644
		[global::Cpp2ILInjected.Token(Token = "0x6004043")]
		[global::Cpp2ILInjected.Address(RVA = "0x76B550", Offset = "0x76B550", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PressurePlateHelper), Member = "ResetPlayer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PressurePlateHelper), Member = "UpdatePlayerPosition", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PressurePlateHelper), Member = "UpdatePlatePosition", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>), Member = "Remove", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PressurePlateHelper), Member = "PokeLocation", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private static void MoveAwayFrom(Point location, int player)
		{
			throw null;
		}

		// Token: 0x0600397D RID: 14717 RVA: 0x0002C447 File Offset: 0x0002A647
		[global::Cpp2ILInjected.Token(Token = "0x6004044")]
		[global::Cpp2ILInjected.Address(RVA = "0x76B224", Offset = "0x76B224", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PressurePlateHelper), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PressurePlateHelper), Member = "DestroyPlate", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PressurePlateHelper), Member = "MoveInto", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PressurePlateHelper), Member = "MoveAwayFrom", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LogicHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Wiring), Member = "HitSwitch", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
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
		private static void PokeLocation(Point location)
		{
			throw null;
		}

		// Token: 0x0600397E RID: 14718 RVA: 0x0002C44A File Offset: 0x0002A64A
		[global::Cpp2ILInjected.Token(Token = "0x6004045")]
		[global::Cpp2ILInjected.Address(RVA = "0x76C0F4", Offset = "0x76C0F4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public PressurePlateHelper()
		{
			throw null;
		}

		// Token: 0x0600397F RID: 14719 RVA: 0x0002C44D File Offset: 0x0002A64D
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6004046")]
		[global::Cpp2ILInjected.Address(RVA = "0x76C0FC", Offset = "0x76C0FC", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		static PressurePlateHelper()
		{
			throw null;
		}

		// Token: 0x040068BA RID: 26810
		[global::Cpp2ILInjected.Token(Token = "0x4007E0B")]
		public static object EntityCreationLock;

		// Token: 0x040068BB RID: 26811
		[global::Cpp2ILInjected.Token(Token = "0x4007E0C")]
		public static Dictionary<Point, bool[]> PressurePlatesPressed;

		// Token: 0x040068BC RID: 26812
		[global::Cpp2ILInjected.Token(Token = "0x4007E0D")]
		public static bool NeedsFirstUpdate;

		// Token: 0x040068BD RID: 26813
		[global::Cpp2ILInjected.Token(Token = "0x4007E0E")]
		private static Vector2[] PlayerLastPosition;

		// Token: 0x040068BE RID: 26814
		[global::Cpp2ILInjected.Token(Token = "0x4007E0F")]
		private static Rectangle pressurePlateBounds;

		// Token: 0x040068BF RID: 26815
		[global::Cpp2ILInjected.Token(Token = "0x4007E10")]
		private static List<Point> tilesOld;

		// Token: 0x040068C0 RID: 26816
		[global::Cpp2ILInjected.Token(Token = "0x4007E11")]
		private static List<Point> tilesNew;
	}
}
