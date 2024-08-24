using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Drawing;
using Terraria.ID;
using Terraria.Localization;

namespace Terraria
{
	// Token: 0x02000334 RID: 820
	[global::Cpp2ILInjected.Token(Token = "0x200043F")]
	public static class Minecart
	{
		// Token: 0x06002651 RID: 9809 RVA: 0x00028D2A File Offset: 0x00026F2A
		[global::Cpp2ILInjected.Token(Token = "0x60028E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x11549F8", Offset = "0x11549F8", Length = "0x1818")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "PostContentLoadInitialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 75)]
		public static void Initialize()
		{
			throw null;
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x00028D2D File Offset: 0x00026F2D
		[global::Cpp2ILInjected.Token(Token = "0x60028E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1156210", Offset = "0x1156210", Length = "0x88C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "CanInteract", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Item),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "AddInteractBanner", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Item)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "CanInteract", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Item)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		public static bool CanSwitchTrack(int i, int j)
		{
			throw null;
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x00028D30 File Offset: 0x00026F30
		[global::Cpp2ILInjected.Token(Token = "0x60028E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1156AD4", Offset = "0x1156AD4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "IsItATrigger", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		public static bool IsPressurePlate(Tile tile)
		{
			throw null;
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x00028D33 File Offset: 0x00026F33
		[global::Cpp2ILInjected.Token(Token = "0x60028E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1156B48", Offset = "0x1156B48", Length = "0x1204")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Minecart), Member = "GetWheelsPositions", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(Mount.MountDelegatesData),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Normalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "nactive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Minecart), Member = "WheelSparks", MemberParameters = new object[]
		{
			typeof(Action<Vector2>),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Round", MemberParameters = new object[]
		{
			typeof(double),
			typeof(int),
			typeof(MidpointRounding)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "CreateRotationZ", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Transform", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Matrix)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 50)]
		public static BitsByte TrackCollision(Player Player, ref Vector2 Position, ref Vector2 Velocity, ref Vector2 lastBoost, int Width, int Height, bool followDown, bool followUp, int fallStart, bool trackOnly, Mount.MountDelegatesData delegatesData)
		{
			throw null;
		}

		// Token: 0x06002655 RID: 9813 RVA: 0x00028D36 File Offset: 0x00026F36
		[global::Cpp2ILInjected.Token(Token = "0x60028E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1157E9C", Offset = "0x1157E9C", Length = "0xA50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_UseMiningTools_TryPoundingTile", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(int),
			typeof(ref bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Minecart), Member = "FlipSwitchTrack", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "TileFrameDoWork", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinecartDiggerHelper), Member = "PoundTrack", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Minecart), Member = "GetNearbyTilesSetLookupIndex", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_frameX", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_frameY", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "KillTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
		public static bool FrameTrack(int i, int j, bool pound, bool mute = false)
		{
			throw null;
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x00028D39 File Offset: 0x00026F39
		[global::Cpp2ILInjected.Token(Token = "0x60028EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x11588EC", Offset = "0x11588EC", Length = "0x2F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Minecart), Member = "FrameTrack", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Minecart), Member = "TryFittingTileOrientation", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int?),
			typeof(int?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static int GetNearbyTilesSetLookupIndex(int i, int j)
		{
			throw null;
		}

		// Token: 0x06002657 RID: 9815 RVA: 0x00028D3C File Offset: 0x00026F3C
		[global::Cpp2ILInjected.Token(Token = "0x60028EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1158C1C", Offset = "0x1158C1C", Length = "0x2E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GrappleMovement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static bool GetOnTrack(int tileX, int tileY, ref Vector2 Position, int Width, int Height)
		{
			throw null;
		}

		// Token: 0x06002658 RID: 9816 RVA: 0x00028D3F File Offset: 0x00026F3F
		[global::Cpp2ILInjected.Token(Token = "0x60028EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1158F04", Offset = "0x1158F04", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static bool OnTrack(Vector2 Position, int Width, int Height)
		{
			throw null;
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x00028D42 File Offset: 0x00026F42
		[global::Cpp2ILInjected.Token(Token = "0x60028ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x11590BC", Offset = "0x11590BC", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Minecart), Member = "GetWheelsPositions", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(Mount.MountDelegatesData),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static float TrackRotation(Player player, ref float rotation, Vector2 Position, int Width, int Height, bool followDown, bool followUp, Mount.MountDelegatesData delegatesData)
		{
			throw null;
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x00028D45 File Offset: 0x00026F45
		[global::Cpp2ILInjected.Token(Token = "0x60028EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1159224", Offset = "0x1159224", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Minecart), Member = "TrackRotation", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(ref float),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(Mount.MountDelegatesData)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Minecart), Member = "TrackCollision", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(ref Vector2),
			typeof(ref Vector2),
			typeof(ref Vector2),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(Mount.MountDelegatesData)
		}, ReturnType = typeof(BitsByte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void GetWheelsPositions(Player player, Vector2 Position, int Width, int Height, bool followDown, bool followUp, Mount.MountDelegatesData delegatesData, out Vector2 leftWheel, out Vector2 rightWheel)
		{
			throw null;
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x00028D48 File Offset: 0x00026F48
		[global::Cpp2ILInjected.Token(Token = "0x60028EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x11593F8", Offset = "0x11593F8", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Minecart), Member = "GetMagnetPosition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Vector2))]
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
		public static void HitTrackSwitch(Vector2 Position, int Width, int Height)
		{
			throw null;
		}

		// Token: 0x0600265C RID: 9820 RVA: 0x00028D4B File Offset: 0x00026F4B
		[global::Cpp2ILInjected.Token(Token = "0x60028F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1159540", Offset = "0x1159540", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Minecart), Member = "HitTrackSwitch", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Vector2 GetMagnetPosition(Vector2 Position, int Width, int Height)
		{
			throw null;
		}

		// Token: 0x0600265D RID: 9821 RVA: 0x00028D4E File Offset: 0x00026F4E
		[global::Cpp2ILInjected.Token(Token = "0x60028F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1159670", Offset = "0x1159670", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "HitWireSingle", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_frameX", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_frameY", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Minecart), Member = "FrameTrack", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendTileSquare", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(TileChangeType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static void FlipSwitchTrack(int i, int j)
		{
			throw null;
		}

		// Token: 0x0600265E RID: 9822 RVA: 0x00028D51 File Offset: 0x00026F51
		[global::Cpp2ILInjected.Token(Token = "0x60028F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x115983C", Offset = "0x115983C", Length = "0x334")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTile_MinecartTrack", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(TileDrawInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "color", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void TrackColors(int i, int j, Tile trackTile, out int frontColor, out int backColor)
		{
			throw null;
		}

		// Token: 0x0600265F RID: 9823 RVA: 0x00028D54 File Offset: 0x00026F54
		[global::Cpp2ILInjected.Token(Token = "0x60028F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1159B70", Offset = "0x1159B70", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTile_MinecartTrack", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(TileDrawInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool DrawLeftDecoration(int frameID)
		{
			throw null;
		}

		// Token: 0x06002660 RID: 9824 RVA: 0x00028D57 File Offset: 0x00026F57
		[global::Cpp2ILInjected.Token(Token = "0x60028F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1159BEC", Offset = "0x1159BEC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTile_MinecartTrack", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(TileDrawInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool DrawRightDecoration(int frameID)
		{
			throw null;
		}

		// Token: 0x06002661 RID: 9825 RVA: 0x00028D5A File Offset: 0x00026F5A
		[global::Cpp2ILInjected.Token(Token = "0x60028F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1159C68", Offset = "0x1159C68", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTile_MinecartTrack", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(TileDrawInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool DrawBumper(int frameID)
		{
			throw null;
		}

		// Token: 0x06002662 RID: 9826 RVA: 0x00028D5D File Offset: 0x00026F5D
		[global::Cpp2ILInjected.Token(Token = "0x60028F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1159D20", Offset = "0x1159D20", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTile_MinecartTrack", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(TileDrawInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool DrawBouncyBumper(int frameID)
		{
			throw null;
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x00028D60 File Offset: 0x00026F60
		[global::Cpp2ILInjected.Token(Token = "0x60028F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1159DD8", Offset = "0x1159DD8", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "PlaceTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_type", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_frameY", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_frameX", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void PlaceTrack(Tile trackCache, int style)
		{
			throw null;
		}

		// Token: 0x06002664 RID: 9828 RVA: 0x00028D63 File Offset: 0x00026F63
		[global::Cpp2ILInjected.Token(Token = "0x60028F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1159EE0", Offset = "0x1159EE0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int GetTrackItem(Tile trackCache)
		{
			throw null;
		}

		// Token: 0x06002665 RID: 9829 RVA: 0x00028D66 File Offset: 0x00026F66
		[global::Cpp2ILInjected.Token(Token = "0x60028F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1159F6C", Offset = "0x1159F6C", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTile_MinecartTrack", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(TileDrawInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static Rectangle GetSourceRect(int frameID, int animationFrame = 0)
		{
			throw null;
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x00028D69 File Offset: 0x00026F69
		[global::Cpp2ILInjected.Token(Token = "0x60028FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x115A098", Offset = "0x115A098", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinecartDiggerHelper), Member = "AlreadyLeadsIntoWantedTrack", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Point)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static bool GetAreExpectationsForSidesMet(Point tileCoords, int? expectedYOffsetForLeft, int? expectedYOffsetForRight)
		{
			throw null;
		}

		// Token: 0x06002667 RID: 9831 RVA: 0x00028D6C File Offset: 0x00026F6C
		[global::Cpp2ILInjected.Token(Token = "0x60028FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x115A264", Offset = "0x115A264", Length = "0x2E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinecartDiggerHelper), Member = "CorrectTrackConnections", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Minecart), Member = "GetNearbyTilesSetLookupIndex", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Framing), Member = "GetTileSafely", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_frameX", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendTileSquare", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(TileChangeType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static void TryFittingTileOrientation(Point tileCoords, int? expectedYOffsetForLeft, int? expectedYOffsetForRight)
		{
			throw null;
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x00028D6F File Offset: 0x00026F6F
		[global::Cpp2ILInjected.Token(Token = "0x60028FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x115A244", Offset = "0x115A244", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int ConvertOffsetYToTrackConnectionValue(int offsetY)
		{
			throw null;
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x00028D72 File Offset: 0x00026F72
		[global::Cpp2ILInjected.Token(Token = "0x60028FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x115A548", Offset = "0x115A548", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int ConvertTrackConnectionValueToOffsetY(int trackConnectionValue)
		{
			throw null;
		}

		// Token: 0x0600266A RID: 9834 RVA: 0x00028D75 File Offset: 0x00026F75
		[global::Cpp2ILInjected.Token(Token = "0x60028FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1157D4C", Offset = "0x1157D4C", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "HorizontalMovement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GrappleMovement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Minecart), Member = "TrackCollision", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(ref Vector2),
			typeof(ref Vector2),
			typeof(ref Vector2),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(Mount.MountDelegatesData)
		}, ReturnType = typeof(BitsByte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void WheelSparks(Action<Vector2> DustAction, Vector2 Position, int Width, int Height, int sparkCount)
		{
			throw null;
		}

		// Token: 0x0600266B RID: 9835 RVA: 0x00028D78 File Offset: 0x00026F78
		[global::Cpp2ILInjected.Token(Token = "0x60028FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1156A9C", Offset = "0x1156A9C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		private static short FrontTrack(this Tile tileTrack)
		{
			throw null;
		}

		// Token: 0x0600266C RID: 9836 RVA: 0x00028D7B File Offset: 0x00026F7B
		[global::Cpp2ILInjected.Token(Token = "0x6002900")]
		[global::Cpp2ILInjected.Address(RVA = "0x1158BE4", Offset = "0x1158BE4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_frameX", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		private static void FrontTrack(this Tile tileTrack, short trackID)
		{
			throw null;
		}

		// Token: 0x0600266D RID: 9837 RVA: 0x00028D7E File Offset: 0x00026F7E
		[global::Cpp2ILInjected.Token(Token = "0x6002901")]
		[global::Cpp2ILInjected.Address(RVA = "0x1156AB8", Offset = "0x1156AB8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		private static short BackTrack(this Tile tileTrack)
		{
			throw null;
		}

		// Token: 0x0600266E RID: 9838 RVA: 0x00028D81 File Offset: 0x00026F81
		[global::Cpp2ILInjected.Token(Token = "0x6002902")]
		[global::Cpp2ILInjected.Address(RVA = "0x1158C00", Offset = "0x1158C00", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_frameY", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		private static void BackTrack(this Tile tileTrack, short trackID)
		{
			throw null;
		}

		// Token: 0x0600266F RID: 9839 RVA: 0x00028D84 File Offset: 0x00026F84
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002903")]
		[global::Cpp2ILInjected.Address(RVA = "0x115A560", Offset = "0x115A560", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static Minecart()
		{
			throw null;
		}

		// Token: 0x04002E4F RID: 11855
		[global::Cpp2ILInjected.Token(Token = "0x40035B7")]
		private const int TotalFrames = 36;

		// Token: 0x04002E50 RID: 11856
		[global::Cpp2ILInjected.Token(Token = "0x40035B8")]
		public const int LeftDownDecoration = 36;

		// Token: 0x04002E51 RID: 11857
		[global::Cpp2ILInjected.Token(Token = "0x40035B9")]
		public const int RightDownDecoration = 37;

		// Token: 0x04002E52 RID: 11858
		[global::Cpp2ILInjected.Token(Token = "0x40035BA")]
		public const int BouncyBumperDecoration = 38;

		// Token: 0x04002E53 RID: 11859
		[global::Cpp2ILInjected.Token(Token = "0x40035BB")]
		public const int RegularBumperDecoration = 39;

		// Token: 0x04002E54 RID: 11860
		[global::Cpp2ILInjected.Token(Token = "0x40035BC")]
		public const int Flag_OnTrack = 0;

		// Token: 0x04002E55 RID: 11861
		[global::Cpp2ILInjected.Token(Token = "0x40035BD")]
		public const int Flag_BouncyBumper = 1;

		// Token: 0x04002E56 RID: 11862
		[global::Cpp2ILInjected.Token(Token = "0x40035BE")]
		public const int Flag_UsedRamp = 2;

		// Token: 0x04002E57 RID: 11863
		[global::Cpp2ILInjected.Token(Token = "0x40035BF")]
		public const int Flag_HitSwitch = 3;

		// Token: 0x04002E58 RID: 11864
		[global::Cpp2ILInjected.Token(Token = "0x40035C0")]
		public const int Flag_BoostLeft = 4;

		// Token: 0x04002E59 RID: 11865
		[global::Cpp2ILInjected.Token(Token = "0x40035C1")]
		public const int Flag_BoostRight = 5;

		// Token: 0x04002E5A RID: 11866
		[global::Cpp2ILInjected.Token(Token = "0x40035C2")]
		private const int NoConnection = -1;

		// Token: 0x04002E5B RID: 11867
		[global::Cpp2ILInjected.Token(Token = "0x40035C3")]
		private const int TopConnection = 0;

		// Token: 0x04002E5C RID: 11868
		[global::Cpp2ILInjected.Token(Token = "0x40035C4")]
		private const int MiddleConnection = 1;

		// Token: 0x04002E5D RID: 11869
		[global::Cpp2ILInjected.Token(Token = "0x40035C5")]
		private const int BottomConnection = 2;

		// Token: 0x04002E5E RID: 11870
		[global::Cpp2ILInjected.Token(Token = "0x40035C6")]
		private const int BumperEnd = -1;

		// Token: 0x04002E5F RID: 11871
		[global::Cpp2ILInjected.Token(Token = "0x40035C7")]
		private const int BouncyEnd = -2;

		// Token: 0x04002E60 RID: 11872
		[global::Cpp2ILInjected.Token(Token = "0x40035C8")]
		private const int RampEnd = -3;

		// Token: 0x04002E61 RID: 11873
		[global::Cpp2ILInjected.Token(Token = "0x40035C9")]
		private const int OpenEnd = -4;

		// Token: 0x04002E62 RID: 11874
		[global::Cpp2ILInjected.Token(Token = "0x40035CA")]
		public const float BoosterSpeed = 4f;

		// Token: 0x04002E63 RID: 11875
		[global::Cpp2ILInjected.Token(Token = "0x40035CB")]
		private const int Type_Normal = 0;

		// Token: 0x04002E64 RID: 11876
		[global::Cpp2ILInjected.Token(Token = "0x40035CC")]
		private const int Type_Pressure = 1;

		// Token: 0x04002E65 RID: 11877
		[global::Cpp2ILInjected.Token(Token = "0x40035CD")]
		private const int Type_Booster = 2;

		// Token: 0x04002E66 RID: 11878
		[global::Cpp2ILInjected.Token(Token = "0x40035CE")]
		private static Vector2 _trackMagnetOffset;

		// Token: 0x04002E67 RID: 11879
		[global::Cpp2ILInjected.Token(Token = "0x40035CF")]
		private const float MinecartTextureWidth = 50f;

		// Token: 0x04002E68 RID: 11880
		[global::Cpp2ILInjected.Token(Token = "0x40035D0")]
		private static int[] _leftSideConnection;

		// Token: 0x04002E69 RID: 11881
		[global::Cpp2ILInjected.Token(Token = "0x40035D1")]
		private static int[] _rightSideConnection;

		// Token: 0x04002E6A RID: 11882
		[global::Cpp2ILInjected.Token(Token = "0x40035D2")]
		private static int[] _trackType;

		// Token: 0x04002E6B RID: 11883
		[global::Cpp2ILInjected.Token(Token = "0x40035D3")]
		private static bool[] _boostLeft;

		// Token: 0x04002E6C RID: 11884
		[global::Cpp2ILInjected.Token(Token = "0x40035D4")]
		private static Vector2[] _texturePosition;

		// Token: 0x04002E6D RID: 11885
		[global::Cpp2ILInjected.Token(Token = "0x40035D5")]
		private static short _firstPressureFrame;

		// Token: 0x04002E6E RID: 11886
		[global::Cpp2ILInjected.Token(Token = "0x40035D6")]
		private static short _firstLeftBoostFrame;

		// Token: 0x04002E6F RID: 11887
		[global::Cpp2ILInjected.Token(Token = "0x40035D7")]
		private static short _firstRightBoostFrame;

		// Token: 0x04002E70 RID: 11888
		[global::Cpp2ILInjected.Token(Token = "0x40035D8")]
		private static int[][] _trackSwitchOptions;

		// Token: 0x04002E71 RID: 11889
		[global::Cpp2ILInjected.Token(Token = "0x40035D9")]
		private static int[][] _tileHeight;

		// Token: 0x02000865 RID: 2149
		[global::Cpp2ILInjected.Token(Token = "0x2000440")]
		private enum TrackState
		{
			// Token: 0x04007F1F RID: 32543
			[global::Cpp2ILInjected.Token(Token = "0x40035DB")]
			NoTrack = -1,
			// Token: 0x04007F20 RID: 32544
			[global::Cpp2ILInjected.Token(Token = "0x40035DC")]
			AboveTrack,
			// Token: 0x04007F21 RID: 32545
			[global::Cpp2ILInjected.Token(Token = "0x40035DD")]
			OnTrack,
			// Token: 0x04007F22 RID: 32546
			[global::Cpp2ILInjected.Token(Token = "0x40035DE")]
			BelowTrack,
			// Token: 0x04007F23 RID: 32547
			[global::Cpp2ILInjected.Token(Token = "0x40035DF")]
			AboveFront,
			// Token: 0x04007F24 RID: 32548
			[global::Cpp2ILInjected.Token(Token = "0x40035E0")]
			AboveBack,
			// Token: 0x04007F25 RID: 32549
			[global::Cpp2ILInjected.Token(Token = "0x40035E1")]
			OnFront,
			// Token: 0x04007F26 RID: 32550
			[global::Cpp2ILInjected.Token(Token = "0x40035E2")]
			OnBack
		}
	}
}
