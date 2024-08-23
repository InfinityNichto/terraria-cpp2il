using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Enums;
using Terraria.IO;

namespace Terraria.GameContent
{
	// Token: 0x0200056F RID: 1391
	[global::Cpp2ILInjected.Token(Token = "0x2000801")]
	public class TownRoomManager
	{
		// Token: 0x06003A9D RID: 15005 RVA: 0x0002C76E File Offset: 0x0002A96E
		[global::Cpp2ILInjected.Token(Token = "0x60041AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x782008", Offset = "0x782008", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCHousesInWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "IsThereASpawnablePrioritizedTownNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "IsThereASpawnablePrioritizedTownNPC_Old", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TownRoomManager), Member = "AddOccupantsToList", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(List<int>)
		}, ReturnType = typeof(void))]
		public void AddOccupantsToList(int x, int y, List<int> occupantsList)
		{
			throw null;
		}

		// Token: 0x06003A9E RID: 15006 RVA: 0x0002C771 File Offset: 0x0002A971
		[global::Cpp2ILInjected.Token(Token = "0x60041AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x782044", Offset = "0x782044", Length = "0x204")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TownRoomManager), Member = "AddOccupantsToList", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(List<int>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Point)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public void AddOccupantsToList(Point tilePosition, List<int> occupants)
		{
			throw null;
		}

		// Token: 0x06003A9F RID: 15007 RVA: 0x0002C774 File Offset: 0x0002A974
		[global::Cpp2ILInjected.Token(Token = "0x60041AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x782248", Offset = "0x782248", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "IsThereASpawnablePrioritizedTownNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "IsThereASpawnablePrioritizedTownNPC_Old", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public bool HasRoomQuick(int npcID)
		{
			throw null;
		}

		// Token: 0x06003AA0 RID: 15008 RVA: 0x0002C777 File Offset: 0x0002A977
		[global::Cpp2ILInjected.Token(Token = "0x60041AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x782258", Offset = "0x782258", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "SpawnTownNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(TownNPCSpawnResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public bool HasRoom(int npcID, out Point roomPosition)
		{
			throw null;
		}

		// Token: 0x06003AA1 RID: 15009 RVA: 0x0002C77A File Offset: 0x0002A97A
		[global::Cpp2ILInjected.Token(Token = "0x60041AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x7823F4", Offset = "0x7823F4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "moveRoom", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TownRoomManager), Member = "SetRoom", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Point)
		}, ReturnType = typeof(void))]
		public void SetRoom(int npcID, int x, int y)
		{
			throw null;
		}

		// Token: 0x06003AA2 RID: 15010 RVA: 0x0002C77D File Offset: 0x0002A97D
		[global::Cpp2ILInjected.Token(Token = "0x60041AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x782448", Offset = "0x782448", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TownRoomManager), Member = "SetRoom", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Predicate<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAll", MemberParameters = new object[] { typeof(Predicate<object>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tuple[]), Member = "Create", MemberTypeParameters = new object[]
		{
			typeof(int),
			typeof(Point)
		}, MemberParameters = new object[]
		{
			typeof(int),
			typeof(Point)
		}, ReturnType = "System.Tuple`2<T1, T2>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public void SetRoom(int npcID, Point pt)
		{
			throw null;
		}

		// Token: 0x06003AA3 RID: 15011 RVA: 0x0002C780 File Offset: 0x0002A980
		[global::Cpp2ILInjected.Token(Token = "0x60041B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x782690", Offset = "0x782690", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "kickOut", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TownRoomManager), Member = "KickOut", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public void KickOut(NPC n)
		{
			throw null;
		}

		// Token: 0x06003AA4 RID: 15012 RVA: 0x0002C783 File Offset: 0x0002A983
		[global::Cpp2ILInjected.Token(Token = "0x60041B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x7826C4", Offset = "0x7826C4", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TownRoomManager), Member = "KickOut", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Predicate<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAll", MemberParameters = new object[] { typeof(Predicate<object>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public void KickOut(int npcType)
		{
			throw null;
		}

		// Token: 0x06003AA5 RID: 15013 RVA: 0x0002C786 File Offset: 0x0002A986
		[global::Cpp2ILInjected.Token(Token = "0x60041B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x782870", Offset = "0x782870", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(byte)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "QuickDust", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Color)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public void DisplayRooms()
		{
			throw null;
		}

		// Token: 0x06003AA6 RID: 15014 RVA: 0x0002C789 File Offset: 0x0002A989
		[global::Cpp2ILInjected.Token(Token = "0x60041B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x782A70", Offset = "0x782A70", Length = "0x29C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "SaveTownManager", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public void Save(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x06003AA7 RID: 15015 RVA: 0x0002C78C File Offset: 0x0002A98C
		[global::Cpp2ILInjected.Token(Token = "0x60041B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x782D0C", Offset = "0x782D0C", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadTownManager", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadTownManager", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadTownManager", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TownRoomManager), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tuple[]), Member = "Create", MemberTypeParameters = new object[]
		{
			typeof(int),
			typeof(Point)
		}, MemberParameters = new object[]
		{
			typeof(int),
			typeof(Point)
		}, ReturnType = "System.Tuple`2<T1, T2>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Load(BinaryReader reader)
		{
			throw null;
		}

		// Token: 0x06003AA8 RID: 15016 RVA: 0x0002C78F File Offset: 0x0002A98F
		[global::Cpp2ILInjected.Token(Token = "0x60041B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x782E80", Offset = "0x782E80", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TownRoomManager), Member = "Load", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06003AA9 RID: 15017 RVA: 0x0002C792 File Offset: 0x0002A992
		[global::Cpp2ILInjected.Token(Token = "0x60041B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x782F0C", Offset = "0x782F0C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "SendNPCHousesAndTravelShop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "UpdateHomeTileState", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "UpdateNetworkCode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public byte GetHouseholdStatus(NPC n)
		{
			throw null;
		}

		// Token: 0x06003AAA RID: 15018 RVA: 0x0002C795 File Offset: 0x0002A995
		[global::Cpp2ILInjected.Token(Token = "0x60041B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x782F34", Offset = "0x782F34", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "IsRoomConsideredAlreadyOccupied", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "ScoreRoom_IsThisRoomOccupiedBySomeone", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool CanNPCsLiveWithEachOther(int npc1ByType, NPC npc2)
		{
			throw null;
		}

		// Token: 0x06003AAB RID: 15019 RVA: 0x0002C798 File Offset: 0x0002A998
		[global::Cpp2ILInjected.Token(Token = "0x60041B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x782FE4", Offset = "0x782FE4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "IsRoomConsideredOccupiedForNPCIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public bool CanNPCsLiveWithEachOther(NPC npc1, NPC npc2)
		{
			throw null;
		}

		// Token: 0x06003AAC RID: 15020 RVA: 0x0002C79B File Offset: 0x0002A99B
		[global::Cpp2ILInjected.Token(Token = "0x60041B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x782FF8", Offset = "0x782FF8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "GetNearbyResidentNPCs", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(List<NPC>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public bool CanNPCsLiveWithEachOther_ShopHelper(NPC npc1, NPC npc2)
		{
			throw null;
		}

		// Token: 0x06003AAD RID: 15021 RVA: 0x0002C79E File Offset: 0x0002A99E
		[global::Cpp2ILInjected.Token(Token = "0x60041BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x78300C", Offset = "0x78300C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public TownRoomManager()
		{
			throw null;
		}

		// Token: 0x06003AAE RID: 15022 RVA: 0x0002C7A1 File Offset: 0x0002A9A1
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60041BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x7830AC", Offset = "0x7830AC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static TownRoomManager()
		{
			throw null;
		}

		// Token: 0x04006ABD RID: 27325
		[global::Cpp2ILInjected.Token(Token = "0x4008084")]
		public static object EntityCreationLock;

		// Token: 0x04006ABE RID: 27326
		[global::Cpp2ILInjected.Token(Token = "0x4008085")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<Tuple<int, Point>> _roomLocationPairs;

		// Token: 0x04006ABF RID: 27327
		[global::Cpp2ILInjected.Token(Token = "0x4008086")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool[] _hasRoom;

		// Token: 0x0200099D RID: 2461
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000802")]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06004DE2 RID: 19938 RVA: 0x0002FBEE File Offset: 0x0002DDEE
			[global::Cpp2ILInjected.Token(Token = "0x60041BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x782688", Offset = "0x782688", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass8_0()
			{
				throw null;
			}

			// Token: 0x06004DE3 RID: 19939 RVA: 0x0002FBF1 File Offset: 0x0002DDF1
			[global::Cpp2ILInjected.Token(Token = "0x60041BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x78311C", Offset = "0x78311C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <SetRoom>b__0(Tuple<int, Point> x)
			{
				throw null;
			}

			// Token: 0x04008C7C RID: 35964
			[global::Cpp2ILInjected.Token(Token = "0x4008087")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int npcID;
		}

		// Token: 0x0200099E RID: 2462
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000803")]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x06004DE4 RID: 19940 RVA: 0x0002FBF4 File Offset: 0x0002DDF4
			[global::Cpp2ILInjected.Token(Token = "0x60041BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x782868", Offset = "0x782868", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass10_0()
			{
				throw null;
			}

			// Token: 0x06004DE5 RID: 19941 RVA: 0x0002FBF7 File Offset: 0x0002DDF7
			[global::Cpp2ILInjected.Token(Token = "0x60041BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x783168", Offset = "0x783168", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <KickOut>b__0(Tuple<int, Point> x)
			{
				throw null;
			}

			// Token: 0x04008C7D RID: 35965
			[global::Cpp2ILInjected.Token(Token = "0x4008088")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int npcType;
		}
	}
}
