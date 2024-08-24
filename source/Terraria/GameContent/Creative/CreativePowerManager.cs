using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.NetModules;
using Terraria.IO;
using Terraria.Net;

namespace Terraria.GameContent.Creative
{
	// Token: 0x0200067C RID: 1660
	[global::Cpp2ILInjected.Token(Token = "0x2000A0B")]
	public class CreativePowerManager
	{
		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06004155 RID: 16725 RVA: 0x0002DADC File Offset: 0x0002BCDC
		[global::Cpp2ILInjected.Token(Token = "0x17000871")]
		public static CreativePowerManager Instance
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004BE5")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B23EC", Offset = "0x8B23EC", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 114)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06004156 RID: 16726 RVA: 0x0002DADF File Offset: 0x0002BCDF
		// (set) Token: 0x06004157 RID: 16727 RVA: 0x0002DAE2 File Offset: 0x0002BCE2
		[global::Cpp2ILInjected.Token(Token = "0x17000872")]
		private static bool _initialized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004BE6")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B2438", Offset = "0x8B2438", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowerManager), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6004BE7")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B2484", Offset = "0x8B2484", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowerManager), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06004158 RID: 16728 RVA: 0x0002DAE5 File Offset: 0x0002BCE5
		[global::Cpp2ILInjected.Token(Token = "0x6004BE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B24D4", Offset = "0x8B24D4", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUserGameState), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public CreativePowerManager()
		{
			throw null;
		}

		// Token: 0x06004159 RID: 16729 RVA: 0x0002DAE8 File Offset: 0x0002BCE8
		[global::Cpp2ILInjected.Token(Token = "0x6004BE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1579044", Offset = "0x1579044", Length = "0x2A4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowerManager), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void Register<T>(string nameInServerConfig) where T : ICreativePower, new()
		{
			throw null;
		}

		// Token: 0x0600415A RID: 16730 RVA: 0x0002DAEB File Offset: 0x0002BCEB
		[global::Cpp2ILInjected.Token(Token = "0x6004BEA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1578F68", Offset = "0x1578F68", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 77)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>), Member = "get_Item", MemberParameters = new object[] { typeof(ushort) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public T GetPower<T>() where T : class, ICreativePower
		{
			throw null;
		}

		// Token: 0x0600415B RID: 16731 RVA: 0x0002DAEE File Offset: 0x0002BCEE
		[global::Cpp2ILInjected.Token(Token = "0x6004BEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x157901C", Offset = "0x157901C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ushort GetPowerId<T>() where T : ICreativePower
		{
			throw null;
		}

		// Token: 0x0600415C RID: 16732 RVA: 0x0002DAF1 File Offset: 0x0002BCF1
		[global::Cpp2ILInjected.Token(Token = "0x6004BEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B2598", Offset = "0x8B2598", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetCreativePowersModule), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetCreativePowerPermissionsModule), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool TryGetPower(ushort id, out ICreativePower power)
		{
			throw null;
		}

		// Token: 0x0600415D RID: 16733 RVA: 0x0002DAF4 File Offset: 0x0002BCF4
		[global::Cpp2ILInjected.Token(Token = "0x6004BED")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B25F8", Offset = "0x8B25F8", Length = "0x254")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadDedConfig", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[]
		{
			typeof(char),
			typeof(StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "get_Instance", ReturnType = typeof(CreativePowerManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static void TryListingPermissionsFrom(string line)
		{
			throw null;
		}

		// Token: 0x0600415E RID: 16734 RVA: 0x0002DAF7 File Offset: 0x0002BCF7
		[global::Cpp2ILInjected.Token(Token = "0x6004BEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B284C", Offset = "0x8B284C", Length = "0x3B8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = "SetupState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowerManager), Member = "TryListingPermissionsFrom", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "get__initialized", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "get_Instance", ReturnType = typeof(CreativePowerManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "Register", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "set__initialized", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		public static void Initialize()
		{
			throw null;
		}

		// Token: 0x0600415F RID: 16735 RVA: 0x0002DAFA File Offset: 0x0002BCFA
		[global::Cpp2ILInjected.Token(Token = "0x6004BEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B2C04", Offset = "0x8B2C04", Length = "0x340")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadWorld_Version2", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x06004160 RID: 16736 RVA: 0x0002DAFD File Offset: 0x0002BCFD
		[global::Cpp2ILInjected.Token(Token = "0x6004BF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B2F44", Offset = "0x8B2F44", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "SaveCreativePowers", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public void SaveToWorld(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x06004161 RID: 16737 RVA: 0x0002DB00 File Offset: 0x0002BD00
		[global::Cpp2ILInjected.Token(Token = "0x6004BF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B3178", Offset = "0x8B3178", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadWorld_Version2", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadCreativePowers", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void LoadFromWorld(BinaryReader reader, int versionGameWasLastSavedOn)
		{
			throw null;
		}

		// Token: 0x06004162 RID: 16738 RVA: 0x0002DB03 File Offset: 0x0002BD03
		[global::Cpp2ILInjected.Token(Token = "0x6004BF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B32B8", Offset = "0x8B32B8", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "ValidateWorld", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void ValidateWorld(BinaryReader reader, int versionGameWasLastSavedOn)
		{
			throw null;
		}

		// Token: 0x06004163 RID: 16739 RVA: 0x0002DB06 File Offset: 0x0002BD06
		[global::Cpp2ILInjected.Token(Token = "0x6004BF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B33F8", Offset = "0x8B33F8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "FinaliseOnMainThread", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUser), Member = "LoadThreadstate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "get_Instance", ReturnType = typeof(CreativePowerManager))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void SyncSplitScreenPlayer(int playerIndex)
		{
			throw null;
		}

		// Token: 0x06004164 RID: 16740 RVA: 0x0002DB09 File Offset: 0x0002BD09
		[global::Cpp2ILInjected.Token(Token = "0x6004BF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B3464", Offset = "0x8B3464", Length = "0x47C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetCreativePowerPermissionsModule), Member = "SerializeCurrentPowerPermissionLevel", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(int)
		}, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToServerOrLoopback", MemberParameters = new object[] { typeof(NetPacket) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		private void SyncSplitScreenPlayerInternal(int playerIndex)
		{
			throw null;
		}

		// Token: 0x06004165 RID: 16741 RVA: 0x0002DB0C File Offset: 0x0002BD0C
		[global::Cpp2ILInjected.Token(Token = "0x6004BF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B38E0", Offset = "0x8B38E0", Length = "0x39C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DedServ", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetCreativePowerPermissionsModule), Member = "SerializeCurrentPowerPermissionLevel", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(int)
		}, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToClient", MemberParameters = new object[]
		{
			typeof(NetPacket),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public void SyncThingsToJoiningPlayer(int playerIndex)
		{
			throw null;
		}

		// Token: 0x06004166 RID: 16742 RVA: 0x0002DB0F File Offset: 0x0002BD0F
		[global::Cpp2ILInjected.Token(Token = "0x6004BF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B3C7C", Offset = "0x8B3C7C", Length = "0x23C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "InternalSavePlayerFile", MemberParameters = new object[] { typeof(PlayerFileData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public void SaveToPlayer(Player player, BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x06004167 RID: 16743 RVA: 0x0002DB12 File Offset: 0x0002BD12
		[global::Cpp2ILInjected.Token(Token = "0x6004BF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B3EB8", Offset = "0x8B3EB8", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "LoadTutorialPlayer", ReturnType = typeof(PlayerFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "LoadPlayer", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(PlayerFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "ResetPowersForPlayer", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void LoadToPlayer(Player player, BinaryReader reader, int versionGameWasLastSavedOn)
		{
			throw null;
		}

		// Token: 0x06004168 RID: 16744 RVA: 0x0002DB15 File Offset: 0x0002BD15
		[global::Cpp2ILInjected.Token(Token = "0x6004BF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B41E4", Offset = "0x8B41E4", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "SetPlayerDataToOutOfClassFields", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public void ApplyLoadedDataToPlayer(Player player)
		{
			throw null;
		}

		// Token: 0x06004169 RID: 16745 RVA: 0x0002DB18 File Offset: 0x0002BD18
		[global::Cpp2ILInjected.Token(Token = "0x6004BF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B4020", Offset = "0x8B4020", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowerManager), Member = "LoadToPlayer", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public void ResetPowersForPlayer(Player player)
		{
			throw null;
		}

		// Token: 0x0600416A RID: 16746 RVA: 0x0002DB1B File Offset: 0x0002BD1B
		[global::Cpp2ILInjected.Token(Token = "0x6004BFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B43A8", Offset = "0x8B43A8", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "SetupStartingItems", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "LoadTutorialPlayer", ReturnType = typeof(PlayerFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "LoadPlayer", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(PlayerFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public void ResetDataForNewPlayer(Player player)
		{
			throw null;
		}

		// Token: 0x04006DB2 RID: 28082
		[global::Cpp2ILInjected.Token(Token = "0x4008617")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Dictionary<ushort, ICreativePower> _powersById;

		// Token: 0x04006DB3 RID: 28083
		[global::Cpp2ILInjected.Token(Token = "0x4008618")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Dictionary<string, ICreativePower> _powersByName;

		// Token: 0x04006DB4 RID: 28084
		[global::Cpp2ILInjected.Token(Token = "0x4008619")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private ushort _powersCount;

		// Token: 0x04006DB5 RID: 28085
		[global::Cpp2ILInjected.Token(Token = "0x400861A")]
		private const string _powerPermissionsLineHeader = "journeypermission_";

		// Token: 0x02000A6E RID: 2670
		[global::Cpp2ILInjected.Token(Token = "0x2000A0C")]
		private class PowerTypeStorage<T> where T : ICreativePower
		{
			// Token: 0x060050BC RID: 20668 RVA: 0x000303D1 File Offset: 0x0002E5D1
			[global::Cpp2ILInjected.Token(Token = "0x6004BFB")]
			[global::Cpp2ILInjected.Address(RVA = "0x181A2B4", Offset = "0x181A2B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public PowerTypeStorage()
			{
				throw null;
			}

			// Token: 0x04008E7E RID: 36478
			[global::Cpp2ILInjected.Token(Token = "0x400861B")]
			public static ushort Id;

			// Token: 0x04008E7F RID: 36479
			[global::Cpp2ILInjected.Token(Token = "0x400861C")]
			public static string Name;
		}
	}
}
