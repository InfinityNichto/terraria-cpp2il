using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Linq;
using Terraria.GameContent.Achievements;
using Terraria.GameContent.UI.Chat;
using Terraria.GameContent.UI.Elements;
using Terraria.GameContent.UI.States;
using Terraria.Initializers;
using Terraria.IO;
using Terraria.UI;
using Terraria.UI.Chat;
using Terraria.Utilities;
using UnityEngine;

namespace Terraria.Achievements
{
	// Token: 0x0200048F RID: 1167
	[global::Cpp2ILInjected.Token(Token = "0x2000695")]
	public class AchievementManager
	{
		// Token: 0x1400003D RID: 61
		// (add) Token: 0x06003311 RID: 13073 RVA: 0x0002B21D File Offset: 0x0002941D
		// (remove) Token: 0x06003312 RID: 13074 RVA: 0x0002B220 File Offset: 0x00029420
		[global::Cpp2ILInjected.Token(Token = "0x14000043")]
		public event Achievement.AchievementCompleted OnAchievementCompleted
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003846")]
			[global::Cpp2ILInjected.Address(RVA = "0x1439140", Offset = "0x1439140", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementInitializer), Member = "Load", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGameNotificationsTracker), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003847")]
			[global::Cpp2ILInjected.Address(RVA = "0x14391DC", Offset = "0x14391DC", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x06003313 RID: 13075 RVA: 0x0002B223 File Offset: 0x00029423
		[global::Cpp2ILInjected.Token(Token = "0x6003848")]
		[global::Cpp2ILInjected.Address(RVA = "0x1439278", Offset = "0x1439278", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SavePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public AchievementManager(LocalUser user)
		{
			throw null;
		}

		// Token: 0x06003314 RID: 13076 RVA: 0x0002B226 File Offset: 0x00029426
		[global::Cpp2ILInjected.Token(Token = "0x6003849")]
		[global::Cpp2ILInjected.Address(RVA = "0x14394B8", Offset = "0x14394B8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "SavePlayer", MemberParameters = new object[]
		{
			typeof(PlayerFileData),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementManager), Member = "Load", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementManager), Member = "ClearAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementManager), Member = "AchievementCompleted", MemberParameters = new object[] { typeof(Achievement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementManager), Member = "Save", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUser), Member = "SavePersistantData", ReturnType = typeof(void))]
		public void Save()
		{
			throw null;
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x0002B229 File Offset: 0x00029429
		[global::Cpp2ILInjected.Token(Token = "0x600384A")]
		[global::Cpp2ILInjected.Address(RVA = "0x14394E8", Offset = "0x14394E8", Length = "0x70C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementManager), Member = "Save", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RijndaelManaged), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(ICryptoTransform),
			typeof(CryptoStreamMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "Create", MemberParameters = new object[] { typeof(JsonSerializerSettings) }, ReturnType = typeof(JsonSerializer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoStream), Member = "FlushFinalBlock", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "WriteAllBytes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 49)]
		private void Save(string path, bool cloud)
		{
			throw null;
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x0002B22C File Offset: 0x0002942C
		[global::Cpp2ILInjected.Token(Token = "0x600384B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1439BF4", Offset = "0x1439BF4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAchievementsMenu), Member = "get_Achievements", ReturnType = typeof(List<Achievement>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementsMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Values", ReturnType = "ValueCollection<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public List<Achievement> CreateAchievementsList()
		{
			throw null;
		}

		// Token: 0x06003317 RID: 13079 RVA: 0x0002B22F File Offset: 0x0002942F
		[global::Cpp2ILInjected.Token(Token = "0x600384C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1439C60", Offset = "0x1439C60", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementManager), Member = "Load", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUser), Member = "LoadPersistantData", ReturnType = typeof(void))]
		public void Load()
		{
			throw null;
		}

		// Token: 0x06003318 RID: 13080 RVA: 0x0002B232 File Offset: 0x00029432
		[global::Cpp2ILInjected.Token(Token = "0x600384D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1439C90", Offset = "0x1439C90", Length = "0xAA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementManager), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementManager), Member = "Load", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "Exists", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "ReadAllBytes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RijndaelManaged), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(ICryptoTransform),
			typeof(CryptoStreamMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonReader), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "Create", MemberParameters = new object[] { typeof(JsonSerializerSettings) }, ReturnType = typeof(JsonSerializer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer[]), Member = "Deserialize", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SavePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_OldSavePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementManager), Member = "Load", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Achievement), Member = "Load", MemberParameters = new object[] { typeof(Dictionary<string, JObject>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Achievement), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Achievement), Member = "ClearProgress", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementManager), Member = "Save", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "Delete", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 75)]
		private void Load(string path, bool cloud)
		{
			throw null;
		}

		// Token: 0x06003319 RID: 13081 RVA: 0x0002B235 File Offset: 0x00029435
		[global::Cpp2ILInjected.Token(Token = "0x600384E")]
		[global::Cpp2ILInjected.Address(RVA = "0x143A730", Offset = "0x143A730", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Achievement), Member = "ClearProgress", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementManager), Member = "Save", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public void ClearAll()
		{
			throw null;
		}

		// Token: 0x0600331A RID: 13082 RVA: 0x0002B238 File Offset: 0x00029438
		[global::Cpp2ILInjected.Token(Token = "0x600384F")]
		[global::Cpp2ILInjected.Address(RVA = "0x143A8A0", Offset = "0x143A8A0", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserManagement), Member = "SwitchPrimaryUser", MemberParameters = new object[] { typeof(PlatformUser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserManagement), Member = "UserSignedOut", MemberParameters = new object[] { typeof(PlatformUser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserManagement), Member = "LocalUserQuit", MemberParameters = new object[] { typeof(LocalUser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Achievement), Member = "Shutdown", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void Shutdown()
		{
			throw null;
		}

		// Token: 0x0600331B RID: 13083 RVA: 0x0002B23B File Offset: 0x0002943B
		[global::Cpp2ILInjected.Token(Token = "0x6003850")]
		[global::Cpp2ILInjected.Address(RVA = "0x143A9E4", Offset = "0x143A9E4", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementManager), Member = "Save", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void AchievementCompleted(Achievement achievement)
		{
			throw null;
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x0002B23E File Offset: 0x0002943E
		[global::Cpp2ILInjected.Token(Token = "0x6003851")]
		[global::Cpp2ILInjected.Address(RVA = "0x143AA28", Offset = "0x143AA28", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 115)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Achievement.AchievementCompleted), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Achievement), Member = "add_OnCompleted", MemberParameters = new object[] { typeof(Achievement.AchievementCompleted) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Register(Achievement achievement)
		{
			throw null;
		}

		// Token: 0x0600331D RID: 13085 RVA: 0x0002B241 File Offset: 0x00029441
		[global::Cpp2ILInjected.Token(Token = "0x6003852")]
		[global::Cpp2ILInjected.Address(RVA = "0x143AAD8", Offset = "0x143AAD8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 115)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void RegisterIconIndex(string achievementName, int iconIndex)
		{
			throw null;
		}

		// Token: 0x0600331E RID: 13086 RVA: 0x0002B244 File Offset: 0x00029444
		[global::Cpp2ILInjected.Token(Token = "0x6003853")]
		[global::Cpp2ILInjected.Address(RVA = "0x143AB38", Offset = "0x143AB38", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 114)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void RegisterAchievementCategory(string achievementName, AchievementCategory category)
		{
			throw null;
		}

		// Token: 0x0600331F RID: 13087 RVA: 0x0002B247 File Offset: 0x00029447
		[global::Cpp2ILInjected.Token(Token = "0x6003854")]
		[global::Cpp2ILInjected.Address(RVA = "0x143AB9C", Offset = "0x143AB9C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementTagHandler), Member = "Terraria.UI.Chat.ITagHandler.Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(string)
		}, ReturnType = typeof(TextSnippet))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Achievement GetAchievement(string achievementName)
		{
			throw null;
		}

		// Token: 0x06003320 RID: 13088 RVA: 0x0002B24A File Offset: 0x0002944A
		[global::Cpp2ILInjected.Token(Token = "0x6003855")]
		[global::Cpp2ILInjected.Address(RVA = "0x14C79FC", Offset = "0x14C79FC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementManager), Member = "GetCondition", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(AchievementCondition))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public T GetCondition<T>(string achievementName, string conditionName) where T : AchievementCondition
		{
			throw null;
		}

		// Token: 0x06003321 RID: 13089 RVA: 0x0002B24D File Offset: 0x0002944D
		[global::Cpp2ILInjected.Token(Token = "0x6003856")]
		[global::Cpp2ILInjected.Address(RVA = "0x143AC0C", Offset = "0x143AC0C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlatformAwardNotifier_Stub), Member = "NoteTraveled", MemberParameters = new object[] { typeof(eDistanceStatistics) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Kill", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementManager), Member = "GetCondition", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementsHelper), Member = "OnPlayerEnteredWorld", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementsHelper), Member = "HandleOnEquip", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementsHelper), Member = "HandleSpecialEvent", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementsHelper), Member = "HandleNurseService", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementsHelper), Member = "HandleAnglerService", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementsHelper), Member = "HandleRunning", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementsHelper), Member = "HandleMining", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 28)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Achievement), Member = "GetCondition", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(AchievementCondition))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public AchievementCondition GetCondition(string achievementName, string conditionName)
		{
			throw null;
		}

		// Token: 0x06003322 RID: 13090 RVA: 0x0002B250 File Offset: 0x00029450
		[global::Cpp2ILInjected.Token(Token = "0x6003857")]
		[global::Cpp2ILInjected.Address(RVA = "0x143AC94", Offset = "0x143AC94", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAchievementsMenu), Member = "AchievementDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGamePopups.AchievementUnlockedPopup), Member = ".ctor", MemberParameters = new object[] { typeof(Achievement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementListItem), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Achievement),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public int GetIconIndex(string achievementName)
		{
			throw null;
		}

		// Token: 0x06003323 RID: 13091 RVA: 0x0002B253 File Offset: 0x00029453
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003858")]
		[global::Cpp2ILInjected.Address(RVA = "0x143AD04", Offset = "0x143AD04", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static AchievementManager()
		{
			throw null;
		}

		// Token: 0x04006529 RID: 25897
		[global::Cpp2ILInjected.Token(Token = "0x4007925")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _savePath;

		// Token: 0x0400652A RID: 25898
		[global::Cpp2ILInjected.Token(Token = "0x4007926")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool _isCloudSave;

		// Token: 0x0400652B RID: 25899
		[global::Cpp2ILInjected.Token(Token = "0x4007927")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private LocalUser User;

		// Token: 0x0400652C RID: 25900
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007928")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Achievement.AchievementCompleted OnAchievementCompleted;

		// Token: 0x0400652D RID: 25901
		[global::Cpp2ILInjected.Token(Token = "0x4007929")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Dictionary<string, Achievement> _achievements;

		// Token: 0x0400652E RID: 25902
		[global::Cpp2ILInjected.Token(Token = "0x400792A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly JsonSerializerSettings _serializerSettings;

		// Token: 0x0400652F RID: 25903
		[global::Cpp2ILInjected.Token(Token = "0x400792B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private byte[] _cryptoKey;

		// Token: 0x04006530 RID: 25904
		[global::Cpp2ILInjected.Token(Token = "0x400792C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private Dictionary<string, int> _achievementIconIndexes;

		// Token: 0x04006531 RID: 25905
		[global::Cpp2ILInjected.Token(Token = "0x400792D")]
		private static object _ioLock;

		// Token: 0x0200093B RID: 2363
		[global::Cpp2ILInjected.Token(Token = "0x2000696")]
		private class StoredAchievement
		{
			// Token: 0x06004CAA RID: 19626 RVA: 0x0002F8F4 File Offset: 0x0002DAF4
			[global::Cpp2ILInjected.Token(Token = "0x6003859")]
			[global::Cpp2ILInjected.Address(RVA = "0x143AD74", Offset = "0x143AD74", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public StoredAchievement()
			{
				throw null;
			}

			// Token: 0x04008ADB RID: 35547
			[JsonProperty]
			[global::Cpp2ILInjected.Token(Token = "0x400792E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Dictionary<string, JObject> Conditions;
		}
	}
}
