using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Converters;
using Terraria;
using Terraria.Achievements;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.ItemDropRules;
using Terraria.GameContent.Liquid;
using Terraria.Graphics.Effects;
using Terraria.Initializers;
using Terraria.IO;
using Terraria.Utilities;
using UnityEngine;

// Token: 0x02000212 RID: 530
[global::Cpp2ILInjected.Token(Token = "0x20002B8")]
public class LocalUser
{
	// Token: 0x06000EEB RID: 3819 RVA: 0x000247BE File Offset: 0x000229BE
	[global::Cpp2ILInjected.Token(Token = "0x600101B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3D198", Offset = "0xA3D198", Length = "0x758")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserManagement), Member = "SwitchPrimaryUser", MemberParameters = new object[] { typeof(PlatformUser) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserManagement), Member = "AddUser", MemberParameters = new object[]
	{
		typeof(ControllerDevice),
		typeof(PlatformUser)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SkyManager), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FilterManager), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OverlayManager), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PersistentUserData), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUserGameState), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUserXNAState), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileManager), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(PlatformUser),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformAwardNotifierFactory), Member = "CreateForActivePlatform", ReturnType = typeof(IPlatformAwardNotifier))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "Create", ReturnType = typeof(CursorManager))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "Create", ReturnType = typeof(ControllerActionManager))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "Create", ReturnType = typeof(GUIInputRegionManager))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MPSessionManager), Member = "Create", ReturnType = typeof(MPSessionManager))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LiquidRenderer), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "SetupMappings", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUser), Member = "GetUICamera", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Camera))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUICameraSettings), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(Camera),
		typeof(XNAUICameraSettings)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUser), Member = "GetWorldCamera", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Camera))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(Camera),
		typeof(XNAWorldCameraSettings)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponents", MemberTypeParameters = new object[] { "T" }, ReturnType = "T[]")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUser), Member = "SetupState", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 55)]
	public LocalUser(int userIndex, PlatformUser user)
	{
		throw null;
	}

	// Token: 0x06000EEC RID: 3820 RVA: 0x000247C1 File Offset: 0x000229C1
	[global::Cpp2ILInjected.Token(Token = "0x600101C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3E994", Offset = "0xA3E994", Length = "0x45C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(PlatformUser)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserManagement), Member = "UserSignIn", MemberParameters = new object[]
	{
		typeof(ControllerDevice),
		typeof(PlatformUser)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserManagement), Member = "UserSignedOut", MemberParameters = new object[] { typeof(PlatformUser) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateTrialMode", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUser), Member = "LoadState", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MPSession_Local), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldSections), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_sectionManager", MemberParameters = new object[] { typeof(WorldSections) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rain), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PopupText), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectManager<>), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenEffectInitializer), Member = "Load", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SceneMetrics), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "Initialize", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsOverlay), Member = "Init", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SavePath", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
	public void SetupState()
	{
		throw null;
	}

	// Token: 0x06000EED RID: 3821 RVA: 0x000247C4 File Offset: 0x000229C4
	[global::Cpp2ILInjected.Token(Token = "0x600101D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3F14C", Offset = "0xA3F14C", Length = "0x88")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public void LoadThreadstate()
	{
		throw null;
	}

	// Token: 0x06000EEE RID: 3822 RVA: 0x000247C7 File Offset: 0x000229C7
	[global::Cpp2ILInjected.Token(Token = "0x600101E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3EDF0", Offset = "0xA3EDF0", Length = "0x35C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = "SetupState", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = "UnloadState", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserManagement), Member = "SwitchPrimaryUser", MemberParameters = new object[] { typeof(PlatformUser) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "OnApplicationPause", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "AnglerQuestSwap", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdateInWorld", MemberParameters = new object[] { typeof(Stopwatch) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateWeather", MemberParameters = new object[]
	{
		typeof(GameTime),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "DropItemInstanced", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(int),
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "OnHit", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float),
		typeof(Entity)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "KillMe", MemberParameters = new object[]
	{
		typeof(PlayerDeathReason),
		typeof(double),
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Damage", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommonCode), Member = "DropItemLocalPerClientAndSetNPCMoneyTo0", MemberParameters = new object[]
	{
		typeof(NPC),
		typeof(int),
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerDeviceManager), Member = "UpdateDevices", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 38)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "ForceActiveController", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "SetActive", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
	public void LoadState()
	{
		throw null;
	}

	// Token: 0x06000EEF RID: 3823 RVA: 0x000247CA File Offset: 0x000229CA
	[global::Cpp2ILInjected.Token(Token = "0x600101F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3F1D4", Offset = "0xA3F1D4", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "OnApplicationPause", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "AnglerQuestSwap", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdateInWorld", MemberParameters = new object[] { typeof(Stopwatch) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateWeather", MemberParameters = new object[]
	{
		typeof(GameTime),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerDeviceManager), Member = "UpdateDevices", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUser), Member = "LoadState", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static void UnloadState()
	{
		throw null;
	}

	// Token: 0x06000EF0 RID: 3824 RVA: 0x000247CD File Offset: 0x000229CD
	[global::Cpp2ILInjected.Token(Token = "0x6001020")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3F22C", Offset = "0xA3F22C", Length = "0xAF4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementManager), Member = "Load", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = "set_TypeNameHandling", MemberParameters = new object[] { typeof(TypeNameHandling) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = "set_MetadataPropertyHandling", MemberParameters = new object[] { typeof(MetadataPropertyHandling) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringEnumConverter), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SavePath", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PersistentUserData), Member = "EnsureObjects", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert[]), Member = "DeserializeObject", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_OldSavePath", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PersistentUserData), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 73)]
	public void LoadPersistantData()
	{
		throw null;
	}

	// Token: 0x06000EF1 RID: 3825 RVA: 0x000247D0 File Offset: 0x000229D0
	[global::Cpp2ILInjected.Token(Token = "0x6001021")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3FE18", Offset = "0xA3FE18", Length = "0x6BC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "SavePlayer", MemberParameters = new object[]
	{
		typeof(PlayerFileData),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementManager), Member = "Save", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = "set_TypeNameHandling", MemberParameters = new object[] { typeof(TypeNameHandling) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = "set_MetadataPropertyHandling", MemberParameters = new object[] { typeof(MetadataPropertyHandling) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringEnumConverter), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SavePath", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 44)]
	public void SavePersistantData()
	{
		throw null;
	}

	// Token: 0x17000164 RID: 356
	// (get) Token: 0x06000EF3 RID: 3827 RVA: 0x000247D6 File Offset: 0x000229D6
	// (set) Token: 0x06000EF2 RID: 3826 RVA: 0x000247D3 File Offset: 0x000229D3
	[global::Cpp2ILInjected.Token(Token = "0x1700018C")]
	public Rect ViewportRegion
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001023")]
		[global::Cpp2ILInjected.Address(RVA = "0xA40530", Offset = "0xA40530", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_rect", ReturnType = typeof(Rect))]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x6001022")]
		[global::Cpp2ILInjected.Address(RVA = "0xA404D4", Offset = "0xA404D4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		set
		{
			throw null;
		}
	}

	// Token: 0x06000EF4 RID: 3828 RVA: 0x000247D9 File Offset: 0x000229D9
	[global::Cpp2ILInjected.Token(Token = "0x6001024")]
	[global::Cpp2ILInjected.Address(RVA = "0xA40540", Offset = "0xA40540", Length = "0x78")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = "GetWorldCamera", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Camera))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = "GetUICamera", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Camera))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "Find", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(GameObject))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObjectExtensions), Member = "FindInChildren", MemberParameters = new object[]
	{
		typeof(GameObject),
		typeof(string)
	}, ReturnType = typeof(GameObject))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private static Camera GetCamera(string name)
	{
		throw null;
	}

	// Token: 0x06000EF5 RID: 3829 RVA: 0x000247DC File Offset: 0x000229DC
	[global::Cpp2ILInjected.Token(Token = "0x6001025")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3E748", Offset = "0xA3E748", Length = "0x24C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(PlatformUser)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserManagement), Member = "SwitchPrimaryUser", MemberParameters = new object[] { typeof(PlatformUser) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUser), Member = "GetCamera", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Camera))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
	public static Camera GetWorldCamera(int index)
	{
		throw null;
	}

	// Token: 0x06000EF6 RID: 3830 RVA: 0x000247DF File Offset: 0x000229DF
	[global::Cpp2ILInjected.Token(Token = "0x6001026")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3E4FC", Offset = "0xA3E4FC", Length = "0x24C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(PlatformUser)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserManagement), Member = "SwitchPrimaryUser", MemberParameters = new object[] { typeof(PlatformUser) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUser), Member = "GetCamera", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Camera))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
	public static Camera GetUICamera(int index)
	{
		throw null;
	}

	// Token: 0x06000EF7 RID: 3831 RVA: 0x000247E2 File Offset: 0x000229E2
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x6001027")]
	[global::Cpp2ILInjected.Address(RVA = "0xA405B8", Offset = "0xA405B8", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	static LocalUser()
	{
		throw null;
	}

	// Token: 0x04001874 RID: 6260
	[global::Cpp2ILInjected.Token(Token = "0x4001DA0")]
	private static byte[] _cryptoKey;

	// Token: 0x04001875 RID: 6261
	[global::Cpp2ILInjected.Token(Token = "0x4001DA1")]
	public static LocalUser Active;

	// Token: 0x04001876 RID: 6262
	[global::Cpp2ILInjected.Token(Token = "0x4001DA2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public SkyManager SkyManager;

	// Token: 0x04001877 RID: 6263
	[global::Cpp2ILInjected.Token(Token = "0x4001DA3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public FilterManager FilterManager;

	// Token: 0x04001878 RID: 6264
	[global::Cpp2ILInjected.Token(Token = "0x4001DA4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public OverlayManager OverlayManager;

	// Token: 0x04001879 RID: 6265
	[global::Cpp2ILInjected.Token(Token = "0x4001DA5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private bool usingKeyboardMouse;

	// Token: 0x0400187A RID: 6266
	[global::Cpp2ILInjected.Token(Token = "0x4001DA6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public ControllerDevice ActiveController;

	// Token: 0x0400187B RID: 6267
	[global::Cpp2ILInjected.Token(Token = "0x4001DA7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public GUIInstance GUIInstance;

	// Token: 0x0400187C RID: 6268
	[global::Cpp2ILInjected.Token(Token = "0x4001DA8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public CursorManager cursorManager;

	// Token: 0x0400187D RID: 6269
	[global::Cpp2ILInjected.Token(Token = "0x4001DA9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public ControllerActionManager controllerActionManager;

	// Token: 0x0400187E RID: 6270
	[global::Cpp2ILInjected.Token(Token = "0x4001DAA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public GUIInputRegionManager guiInputRegionManager;

	// Token: 0x0400187F RID: 6271
	[global::Cpp2ILInjected.Token(Token = "0x4001DAB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public MPSessionManager mpSessionManager;

	// Token: 0x04001880 RID: 6272
	[global::Cpp2ILInjected.Token(Token = "0x4001DAC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public XNAUIInputLayer xnaUIInputLayer;

	// Token: 0x04001881 RID: 6273
	[global::Cpp2ILInjected.Token(Token = "0x4001DAD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public FileManager fileManager;

	// Token: 0x04001882 RID: 6274
	[global::Cpp2ILInjected.Token(Token = "0x4001DAE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public LiquidRenderer liquidRenderer;

	// Token: 0x04001883 RID: 6275
	[global::Cpp2ILInjected.Token(Token = "0x4001DAF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public int UserIndex;

	// Token: 0x04001884 RID: 6276
	[global::Cpp2ILInjected.Token(Token = "0x4001DB0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public PlatformUser UserId;

	// Token: 0x04001885 RID: 6277
	[global::Cpp2ILInjected.Token(Token = "0x4001DB1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public IPlatformAwardNotifier PlatformAwards;

	// Token: 0x04001886 RID: 6278
	[global::Cpp2ILInjected.Token(Token = "0x4001DB2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public PersistentUserData PersistentUserData;

	// Token: 0x04001887 RID: 6279
	[global::Cpp2ILInjected.Token(Token = "0x4001DB3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public XNAUICameraSettings UICameraSettings;

	// Token: 0x04001888 RID: 6280
	[global::Cpp2ILInjected.Token(Token = "0x4001DB4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public XNAWorldCameraSettings WorldCameraSettings;

	// Token: 0x04001889 RID: 6281
	[global::Cpp2ILInjected.Token(Token = "0x4001DB5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public LocalUserGameState GameState;

	// Token: 0x0400188A RID: 6282
	[global::Cpp2ILInjected.Token(Token = "0x4001DB6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public LocalUserXNAState XNAState;

	// Token: 0x0400188B RID: 6283
	[global::Cpp2ILInjected.Token(Token = "0x4001DB7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public InterfaceProfile_Layout[] CustomProfiles;

	// Token: 0x0400188C RID: 6284
	[global::Cpp2ILInjected.Token(Token = "0x4001DB8")]
	private static Camera _worldCam2;

	// Token: 0x0400188D RID: 6285
	[global::Cpp2ILInjected.Token(Token = "0x4001DB9")]
	private static Camera _worldCam3;

	// Token: 0x0400188E RID: 6286
	[global::Cpp2ILInjected.Token(Token = "0x4001DBA")]
	private static Camera _worldCam4;

	// Token: 0x0400188F RID: 6287
	[global::Cpp2ILInjected.Token(Token = "0x4001DBB")]
	private static Camera _uiCam2;

	// Token: 0x04001890 RID: 6288
	[global::Cpp2ILInjected.Token(Token = "0x4001DBC")]
	private static Camera _uiCam3;

	// Token: 0x04001891 RID: 6289
	[global::Cpp2ILInjected.Token(Token = "0x4001DBD")]
	private static Camera _uiCam4;
}
