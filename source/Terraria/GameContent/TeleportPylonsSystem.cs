using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Chat;
using Terraria.DataStructures;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Tile_Entities;
using Terraria.ID;
using Terraria.Localization;
using Terraria.Map;
using Terraria.Net;

namespace Terraria.GameContent
{
	// Token: 0x02000568 RID: 1384
	[global::Cpp2ILInjected.Token(Token = "0x20007F3")]
	public class TeleportPylonsSystem : IOnPlayerJoining
	{
		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06003A7D RID: 14973 RVA: 0x0002C71A File Offset: 0x0002A91A
		[global::Cpp2ILInjected.Token(Token = "0x170007C1")]
		public List<TeleportPylonInfo> Pylons
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004171")]
			[global::Cpp2ILInjected.Address(RVA = "0x77B9F4", Offset = "0x77B9F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06003A7E RID: 14974 RVA: 0x0002C71D File Offset: 0x0002A91D
		[global::Cpp2ILInjected.Token(Token = "0x6004172")]
		[global::Cpp2ILInjected.Address(RVA = "0x77B9FC", Offset = "0x77B9FC", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x06003A7F RID: 14975 RVA: 0x0002C720 File Offset: 0x0002A920
		[global::Cpp2ILInjected.Token(Token = "0x6004173")]
		[global::Cpp2ILInjected.Address(RVA = "0x77C328", Offset = "0x77C328", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TETeleportationPylon), Member = "NetPlaceEntityAttempt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TETeleportationPylon), Member = "PlacementPreviewHook_CheckIfCanPlace", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TeleportPylonsSystem.<>c__DisplayClass8_0), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<TeleportPylonInfo, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Any", MemberTypeParameters = new object[] { typeof(TeleportPylonInfo) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<TeleportPylonInfo>),
			typeof(Func<TeleportPylonInfo, bool>)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public bool HasPylonOfType(TeleportPylonType pylonType)
		{
			throw null;
		}

		// Token: 0x06003A80 RID: 14976 RVA: 0x0002C723 File Offset: 0x0002A923
		[global::Cpp2ILInjected.Token(Token = "0x6004174")]
		[global::Cpp2ILInjected.Address(RVA = "0x77C3FC", Offset = "0x77C3FC", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool HasAnyPylon()
		{
			throw null;
		}

		// Token: 0x06003A81 RID: 14977 RVA: 0x0002C726 File Offset: 0x0002A926
		[global::Cpp2ILInjected.Token(Token = "0x6004175")]
		[global::Cpp2ILInjected.Address(RVA = "0x77C444", Offset = "0x77C444", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TETeleportationPylon), Member = "Place", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TETeleportationPylon), Member = "Kill", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TeleportPylonsSystem), Member = "UpdatePylonsListAndBroadcastChanges", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void RequestImmediateUpdate()
		{
			throw null;
		}

		// Token: 0x06003A82 RID: 14978 RVA: 0x0002C729 File Offset: 0x0002A929
		[global::Cpp2ILInjected.Token(Token = "0x6004176")]
		[global::Cpp2ILInjected.Address(RVA = "0x77BA80", Offset = "0x77BA80", Length = "0x8A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeleportPylonsSystem), Member = "RequestImmediateUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Swap", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(ref object),
			typeof(ref object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Values", ReturnType = "ValueCollection<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.ValueCollection), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.ValueCollection.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TETeleportationPylon), Member = "TryGetPylonType", MemberParameters = new object[] { typeof(ref TeleportPylonType) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.ValueCollection.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Except", MemberTypeParameters = new object[] { typeof(TeleportPylonInfo) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<TeleportPylonInfo>),
			typeof(IEnumerable<TeleportPylonInfo>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetTeleportPylonModule), Member = "SerializePylonWasAddedOrRemoved", MemberParameters = new object[]
		{
			typeof(TeleportPylonInfo),
			typeof(NetTeleportPylonModule.SubPacketType)
		}, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "BroadcastOrLoopback", MemberParameters = new object[] { typeof(NetPacket) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 44)]
		private void UpdatePylonsListAndBroadcastChanges()
		{
			throw null;
		}

		// Token: 0x06003A83 RID: 14979 RVA: 0x0002C72C File Offset: 0x0002A92C
		[global::Cpp2ILInjected.Token(Token = "0x6004177")]
		[global::Cpp2ILInjected.Address(RVA = "0x77C4B8", Offset = "0x77C4B8", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetTeleportPylonModule), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<TeleportPylonInfo>), Member = "Contains", MemberParameters = new object[] { typeof(TeleportPylonInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void AddForClient(TeleportPylonInfo info)
		{
			throw null;
		}

		// Token: 0x06003A84 RID: 14980 RVA: 0x0002C72F File Offset: 0x0002A92F
		[global::Cpp2ILInjected.Token(Token = "0x6004178")]
		[global::Cpp2ILInjected.Address(RVA = "0x77C598", Offset = "0x77C598", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetTeleportPylonModule), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TeleportPylonsSystem.<>c__DisplayClass13_0), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Predicate<TeleportPylonInfo>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<TeleportPylonInfo>), Member = "RemoveAll", MemberParameters = new object[] { typeof(Predicate<TeleportPylonInfo>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void RemoveForClient(TeleportPylonInfo info)
		{
			throw null;
		}

		// Token: 0x06003A85 RID: 14981 RVA: 0x0002C732 File Offset: 0x0002A932
		[global::Cpp2ILInjected.Token(Token = "0x6004179")]
		[global::Cpp2ILInjected.Address(RVA = "0x77C674", Offset = "0x77C674", Length = "0x77C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetTeleportPylonModule), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TeleportPylonsSystem), Member = "IsPlayerNearAPylon", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TeleportPylonsSystem), Member = "DoesPositionHaveEnoughNPCs", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Point16)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "AnyDanger", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "FromKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatHelper), Member = "SendChatMessageToClient", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Framing), Member = "GetTileSafely", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_wall", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToWorldCoordinates", MemberParameters = new object[]
		{
			typeof(Point16),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SceneMetrics), Member = "ScanAndExportToMain", MemberParameters = new object[] { typeof(SceneMetricsScanSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TeleportPylonsSystem), Member = "DoesPylonAcceptTeleportation", MemberParameters = new object[]
		{
			typeof(TeleportPylonInfo),
			typeof(Player)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<TeleportPylonInfo>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileReachCheckSettings), Member = "get_Pylons", ReturnType = typeof(TileReachCheckSettings))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "InInteractionRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TileReachCheckSettings)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_HeightOffsetBoost", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "Teleport", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemoteClient), Member = "CheckSection", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2),
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
		public void HandleTeleportRequest(TeleportPylonInfo info, int playerIndex)
		{
			throw null;
		}

		// Token: 0x06003A86 RID: 14982 RVA: 0x0002C735 File Offset: 0x0002A935
		[global::Cpp2ILInjected.Token(Token = "0x600417A")]
		[global::Cpp2ILInjected.Address(RVA = "0x77CDF0", Offset = "0x77CDF0", Length = "0x2BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeleportPylonsMapLayer), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ref MapOverlayDrawContext),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeleportPylonsSystem), Member = "HandleTeleportRequest", MemberParameters = new object[]
		{
			typeof(TeleportPylonInfo),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_tileRangeX", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_tileRangeY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<TeleportPylonInfo>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Intersects", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static bool IsPlayerNearAPylon(Player player)
		{
			throw null;
		}

		// Token: 0x06003A87 RID: 14983 RVA: 0x0002C738 File Offset: 0x0002A938
		[global::Cpp2ILInjected.Token(Token = "0x600417B")]
		[global::Cpp2ILInjected.Address(RVA = "0x77D0C4", Offset = "0x77D0C4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TeleportPylonsSystem), Member = "DoesPositionHaveEnoughNPCs", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Point16)
		}, ReturnType = typeof(bool))]
		private bool DoesPylonHaveEnoughNPCsAroundIt(TeleportPylonInfo info, int necessaryNPCCount)
		{
			throw null;
		}

		// Token: 0x06003A88 RID: 14984 RVA: 0x0002C73B File Offset: 0x0002A93B
		[global::Cpp2ILInjected.Token(Token = "0x600417C")]
		[global::Cpp2ILInjected.Address(RVA = "0x77D59C", Offset = "0x77D59C", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chest), Member = "SetupShop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeleportPylonsSystem), Member = "HandleTeleportRequest", MemberParameters = new object[]
		{
			typeof(TeleportPylonInfo),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeleportPylonsSystem), Member = "DoesPylonHaveEnoughNPCsAroundIt", MemberParameters = new object[]
		{
			typeof(TeleportPylonInfo),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_isLikeATownNPC", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static bool DoesPositionHaveEnoughNPCs(int necessaryNPCCount, Point16 centerPoint)
		{
			throw null;
		}

		// Token: 0x06003A89 RID: 14985 RVA: 0x0002C73E File Offset: 0x0002A93E
		[global::Cpp2ILInjected.Token(Token = "0x600417D")]
		[global::Cpp2ILInjected.Address(RVA = "0x77D774", Offset = "0x77D774", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeleportPylonsMapLayer), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ref MapOverlayDrawContext),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetTeleportPylonModule), Member = "SerializeUseRequest", MemberParameters = new object[] { typeof(TeleportPylonInfo) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToServerOrLoopback", MemberParameters = new object[] { typeof(NetPacket) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void RequestTeleportation(TeleportPylonInfo info, Player player)
		{
			throw null;
		}

		// Token: 0x06003A8A RID: 14986 RVA: 0x0002C741 File Offset: 0x0002A941
		[global::Cpp2ILInjected.Token(Token = "0x600417E")]
		[global::Cpp2ILInjected.Address(RVA = "0x77D0E0", Offset = "0x77D0E0", Length = "0x4BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeleportPylonsSystem), Member = "HandleTeleportRequest", MemberParameters = new object[]
		{
			typeof(TeleportPylonInfo),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_DroneCameraTracker", ReturnType = typeof(DroneCameraTracker))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SceneMetrics), Member = "get_EnoughTilesForHallow", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SceneMetrics), Member = "get_EnoughTilesForGlowingMushroom", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SceneMetrics), Member = "get_EnoughTilesForJungle", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SceneMetrics), Member = "get_EnoughTilesForDesert", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SceneMetrics), Member = "get_EnoughTilesForSnow", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SceneMetrics), Member = "get_EnoughTilesForCrimson", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SceneMetrics), Member = "get_EnoughTilesForCorruption", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private bool DoesPylonAcceptTeleportation(TeleportPylonInfo info, Player player)
		{
			throw null;
		}

		// Token: 0x06003A8B RID: 14987 RVA: 0x0002C744 File Offset: 0x0002A944
		[global::Cpp2ILInjected.Token(Token = "0x600417F")]
		[global::Cpp2ILInjected.Address(RVA = "0x77D0AC", Offset = "0x77D0AC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int HowManyNPCsDoesPylonNeed(TeleportPylonInfo info, Player player)
		{
			throw null;
		}

		// Token: 0x06003A8C RID: 14988 RVA: 0x0002C747 File Offset: 0x0002A947
		[global::Cpp2ILInjected.Token(Token = "0x6004180")]
		[global::Cpp2ILInjected.Address(RVA = "0x77D7F4", Offset = "0x77D7F4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x06003A8D RID: 14989 RVA: 0x0002C74A File Offset: 0x0002A94A
		[global::Cpp2ILInjected.Token(Token = "0x6004181")]
		[global::Cpp2ILInjected.Address(RVA = "0x77D840", Offset = "0x77D840", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DedServ", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<TeleportPylonInfo>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<TeleportPylonInfo>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetTeleportPylonModule), Member = "SerializePylonWasAddedOrRemoved", MemberParameters = new object[]
		{
			typeof(TeleportPylonInfo),
			typeof(NetTeleportPylonModule.SubPacketType)
		}, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToClient", MemberParameters = new object[]
		{
			typeof(NetPacket),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<TeleportPylonInfo>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public void OnPlayerJoining(int playerIndex)
		{
			throw null;
		}

		// Token: 0x06003A8E RID: 14990 RVA: 0x0002C74D File Offset: 0x0002A94D
		[global::Cpp2ILInjected.Token(Token = "0x6004182")]
		[global::Cpp2ILInjected.Address(RVA = "0x77DA04", Offset = "0x77DA04", Length = "0x204")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "TeleportEffect", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(TeleportationSide),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "UpdateTeleportVisuals", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTeleportationPylons", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "TopLeft", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static void SpawnInWorldDust(int tileStyle, Rectangle dustBox)
		{
			throw null;
		}

		// Token: 0x06003A8F RID: 14991 RVA: 0x0002C750 File Offset: 0x0002A950
		[global::Cpp2ILInjected.Token(Token = "0x6004183")]
		[global::Cpp2ILInjected.Address(RVA = "0x77DC08", Offset = "0x77DC08", Length = "0x10C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<TeleportPylonInfo>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SceneMetrics), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public TeleportPylonsSystem()
		{
			throw null;
		}

		// Token: 0x04006954 RID: 26964
		[global::Cpp2ILInjected.Token(Token = "0x4007F07")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<TeleportPylonInfo> _pylons;

		// Token: 0x04006955 RID: 26965
		[global::Cpp2ILInjected.Token(Token = "0x4007F08")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<TeleportPylonInfo> _pylonsOld;

		// Token: 0x04006956 RID: 26966
		[global::Cpp2ILInjected.Token(Token = "0x4007F09")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _cooldownForUpdatingPylonsList;

		// Token: 0x04006957 RID: 26967
		[global::Cpp2ILInjected.Token(Token = "0x4007F0A")]
		private const int CooldownTimePerPylonsListUpdate = 2147483647;

		// Token: 0x04006958 RID: 26968
		[global::Cpp2ILInjected.Token(Token = "0x4007F0B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private SceneMetrics _sceneMetrics;

		// Token: 0x02000996 RID: 2454
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20007F4")]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06004DC9 RID: 19913 RVA: 0x0002FBA3 File Offset: 0x0002DDA3
			[global::Cpp2ILInjected.Token(Token = "0x6004184")]
			[global::Cpp2ILInjected.Address(RVA = "0x77ECC8", Offset = "0x77ECC8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeleportPylonsSystem), Member = "HasPylonOfType", MemberParameters = new object[] { typeof(TeleportPylonType) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass8_0()
			{
				throw null;
			}

			// Token: 0x06004DCA RID: 19914 RVA: 0x0002FBA6 File Offset: 0x0002DDA6
			[global::Cpp2ILInjected.Token(Token = "0x6004185")]
			[global::Cpp2ILInjected.Address(RVA = "0x77ECD0", Offset = "0x77ECD0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <HasPylonOfType>b__0(TeleportPylonInfo x)
			{
				throw null;
			}

			// Token: 0x04008C68 RID: 35944
			[global::Cpp2ILInjected.Token(Token = "0x4007F0C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public TeleportPylonType pylonType;
		}

		// Token: 0x02000997 RID: 2455
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20007F5")]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06004DCB RID: 19915 RVA: 0x0002FBA9 File Offset: 0x0002DDA9
			[global::Cpp2ILInjected.Token(Token = "0x6004186")]
			[global::Cpp2ILInjected.Address(RVA = "0x77ECE4", Offset = "0x77ECE4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeleportPylonsSystem), Member = "RemoveForClient", MemberParameters = new object[] { typeof(TeleportPylonInfo) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass13_0()
			{
				throw null;
			}

			// Token: 0x06004DCC RID: 19916 RVA: 0x0002FBAC File Offset: 0x0002DDAC
			[global::Cpp2ILInjected.Token(Token = "0x6004187")]
			[global::Cpp2ILInjected.Address(RVA = "0x77ECEC", Offset = "0x77ECEC", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TeleportPylonInfo), Member = "Equals", MemberParameters = new object[] { typeof(TeleportPylonInfo) }, ReturnType = typeof(bool))]
			internal bool <RemoveForClient>b__0(TeleportPylonInfo x)
			{
				throw null;
			}

			// Token: 0x04008C69 RID: 35945
			[global::Cpp2ILInjected.Token(Token = "0x4007F0D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public TeleportPylonInfo info;
		}
	}
}
