using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Graphics;
using UnityEngine;

namespace Microsoft.Xna.Framework.Content
{
	[global::Cpp2ILInjected.Token(Token = "0x20003C3")]
	public class ContentManager
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000370")]
		public IServiceProvider ServiceProvider
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A33")]
			[global::Cpp2ILInjected.Address(RVA = "0xB42120", Offset = "0xB42120", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A34")]
		[global::Cpp2ILInjected.Address(RVA = "0xB42128", Offset = "0xB42128", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Game), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public ContentManager(IServiceProvider serviceProvider, string p)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A35")]
		[global::Cpp2ILInjected.Address(RVA = "0x15786C4", Offset = "0x15786C4", Length = "0x424")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerInputButton), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPopoutMenu), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventorySplitStack), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneyModeSettings), Member = "GetIconTexture", MemberParameters = new object[]
		{
			typeof(GUISettingID),
			typeof(ref Rectangle)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "LoadItemIcon", MemberParameters = new object[]
		{
			typeof(ContentManager),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "LoadNPCIcon", MemberParameters = new object[]
		{
			typeof(ContentManager),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettings), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutCalculator), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundBank), Member = "LoadMusicId", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureManager), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 119)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager), Member = "LoadTexture2D", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileShader), Member = "get_Effect", ReturnType = typeof(TileShader))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager), Member = "LoadSpriteFont", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(SpriteFont))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PixelShader), Member = "get_Effect", ReturnType = typeof(PixelShader))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager), Member = "LoadSoundEffect", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(SoundEffect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShader), Member = "get_Effect", ReturnType = typeof(ScreenShader))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteEffect), Member = "get_Effect", ReturnType = typeof(SpriteEffect))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		internal T1 Load<T1>(string asset) where T1 : class
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000371")]
		public static bool AsyncLoadStillRequired
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A36")]
			[global::Cpp2ILInjected.Address(RVA = "0xB42234", Offset = "0xB42234", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "TcpClientLoop", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "playWorldCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "serverLoadWorldCallBack", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A37")]
		[global::Cpp2ILInjected.Address(RVA = "0xB422A4", Offset = "0xB422A4", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadContentRequest), Member = "UpdatingLoading", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager.TextureLoadEntry), Member = "Update", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static void UpdateAysncLoad()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A38")]
		[global::Cpp2ILInjected.Address(RVA = "0xB42614", Offset = "0xB42614", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "LoadTexturesAsync", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = "LoadSourceTexture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static void LoadUnityTexturePageAsync(string asset0, string asset1, string asset2, int pageIndex, Action<global::UnityEngine.Texture2D, global::UnityEngine.Texture2D, global::UnityEngine.Texture2D, int> loadedCallback)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A39")]
		[global::Cpp2ILInjected.Address(RVA = "0x1578AE8", Offset = "0x1578AE8", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "AltlasTexture", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::UnityEngine.Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteEffect), Member = "get_Effect", ReturnType = typeof(SpriteEffect))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentManager), Member = "LoadSpriteFont", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(SpriteFont))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadContentRequest), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::UnityEngine.Object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resources), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::UnityEngine.Object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static ResourceType LoadUnityResource<ResourceType>(string asset) where ResourceType : global::UnityEngine.Object
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x157828C", Offset = "0x157828C", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentManager), Member = "LoadSoundEffect", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(SoundEffect))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resources), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::UnityEngine.Object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static ResourceType ConstructFromUnityResource<ResourceType>(string asset, ThreadContentRequest.ObjectCreate createFunction) where ResourceType : class
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A3B")]
		[global::Cpp2ILInjected.Address(RVA = "0x15783D0", Offset = "0x15783D0", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentManager), Member = "LoadTexture2D", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resources), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::UnityEngine.Object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static ResourceType ConstructFromUnityResources<ResourceType>(string asset, string asset2, ThreadContentRequest.ObjectCreate2 createFunction) where ResourceType : class
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x157853C", Offset = "0x157853C", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentManager), Member = "LoadTexture2D", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resources), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::UnityEngine.Object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static ResourceType ConstructFromUnityResources<ResourceType>(string asset, string asset2, string asset3, ThreadContentRequest.ObjectCreate3 createFunction) where ResourceType : class
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A3D")]
		[global::Cpp2ILInjected.Address(RVA = "0xB427D4", Offset = "0xB427D4", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = ".ctor", MemberParameters = new object[] { typeof(global::UnityEngine.Texture2D) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static object CreateTextureAsset(object resource)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A3E")]
		[global::Cpp2ILInjected.Address(RVA = "0xB428AC", Offset = "0xB428AC", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager), Member = "get_Empty", ReturnType = typeof(global::UnityEngine.Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = ".ctor", MemberParameters = new object[] { typeof(global::UnityEngine.Texture2D) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Texture2D),
			typeof(global::UnityEngine.Texture2D)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static object CreateTextureAssets(object resource, object resource2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000372")]
		private static global::UnityEngine.Texture2D Empty
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A3F")]
			[global::Cpp2ILInjected.Address(RVA = "0xB429EC", Offset = "0xB429EC", Length = "0x100")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentManager), Member = "CreateTextureAssets", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentManager), Member = "CreateTextureAssetsWithPal", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(global::UnityEngine.Object),
				typeof(global::UnityEngine.Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Texture2D), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A40")]
		[global::Cpp2ILInjected.Address(RVA = "0xB42AEC", Offset = "0xB42AEC", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager), Member = "get_Empty", ReturnType = typeof(global::UnityEngine.Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Texture2D),
			typeof(global::UnityEngine.Texture2D),
			typeof(global::UnityEngine.Texture2D)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static object CreateTextureAssetsWithPal(object resource, object resource2, object resource3)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A41")]
		[global::Cpp2ILInjected.Address(RVA = "0xB42C0C", Offset = "0xB42C0C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "ActionPendingUnloadAssets", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = "ResetLoaded", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void UnloadSourceTextures()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A42")]
		[global::Cpp2ILInjected.Address(RVA = "0xB42C94", Offset = "0xB42C94", Length = "0x604")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentManager), Member = "Load", MemberTypeParameters = new object[] { "T1" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T1")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentManager), Member = "LoadSpriteFont", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(SpriteFont))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Contains", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "LoadTexture", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref TextureAtlasDB),
			typeof(ref TextureAtlasEntry)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TextureAtlasDB),
			typeof(TextureAtlasEntry)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadContentRequest.ObjectCreate3), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadContentRequest.ObjectCreate2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager), Member = "ConstructFromUnityResources", MemberTypeParameters = new object[] { "ResourceType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(ThreadContentRequest.ObjectCreate2)
		}, ReturnType = "ResourceType")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager), Member = "ConstructFromUnityResources", MemberTypeParameters = new object[] { "ResourceType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(ThreadContentRequest.ObjectCreate3)
		}, ReturnType = "ResourceType")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "IsCurrentPlatform", MemberParameters = new object[] { typeof(DrPlatform.DrPlatformType) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = "get_UnityTexture", ReturnType = typeof(global::UnityEngine.Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
		private Microsoft.Xna.Framework.Graphics.Texture2D LoadTexture2D(string asset)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A43")]
		[global::Cpp2ILInjected.Address(RVA = "0xB43504", Offset = "0xB43504", Length = "0x7D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentManager), Member = "Load", MemberTypeParameters = new object[] { "T1" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T1")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager), Member = "LoadUnityResource", MemberTypeParameters = new object[] { "ResourceType" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "ResourceType")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextAsset), Member = "get_bytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char?), Member = ".ctor", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager), Member = "LoadTexture2D", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Graphics.Texture2D[]),
			typeof(SpriteFont.Glyph[]),
			typeof(int),
			typeof(float),
			typeof(char?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
		private SpriteFont LoadSpriteFont(string asset)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A44")]
		[global::Cpp2ILInjected.Address(RVA = "0xB43CD8", Offset = "0xB43CD8", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "get_name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEffect), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(AudioClip)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static object CreateSoundEffect(object resource)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A45")]
		[global::Cpp2ILInjected.Address(RVA = "0xB43E80", Offset = "0xB43E80", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentManager), Member = "Load", MemberTypeParameters = new object[] { "T1" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T1")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadContentRequest.ObjectCreate), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager), Member = "ConstructFromUnityResource", MemberTypeParameters = new object[] { "ResourceType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(ThreadContentRequest.ObjectCreate)
		}, ReturnType = "ResourceType")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private SoundEffect LoadSoundEffect(string asset)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A46")]
		[global::Cpp2ILInjected.Address(RVA = "0xB440E0", Offset = "0xB440E0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Unload()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000373")]
		public string RootDirectory
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001A47")]
			[global::Cpp2ILInjected.Address(RVA = "0xB440E4", Offset = "0xB440E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001A48")]
			[global::Cpp2ILInjected.Address(RVA = "0xB440EC", Offset = "0xB440EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001A49")]
		[global::Cpp2ILInjected.Address(RVA = "0xB440F4", Offset = "0xB440F4", Length = "0x4E5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 552)]
		static ContentManager()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40027AD")]
		public static ContentManager Instance;

		[global::Cpp2ILInjected.Token(Token = "0x40027AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IServiceProvider serviceProvider;

		[global::Cpp2ILInjected.Token(Token = "0x40027AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string p;

		[global::Cpp2ILInjected.Token(Token = "0x40027B0")]
		private static List<ContentManager.TextureLoadEntry> LoadingAssets;

		[global::Cpp2ILInjected.Token(Token = "0x40027B1")]
		private static global::UnityEngine.Texture2D emptyTexture;

		[global::Cpp2ILInjected.Token(Token = "0x40027B2")]
		private static ContentManager.SourceAssetEntry[] sourceAssets;

		[global::Cpp2ILInjected.Token(Token = "0x40027B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<Microsoft.Xna.Framework.Graphics.Texture2D> _sourceTexturesLoaded;

		[global::Cpp2ILInjected.Token(Token = "0x40027B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Dictionary<string, Microsoft.Xna.Framework.Graphics.Texture2D> _loadedTextures;

		[global::Cpp2ILInjected.Token(Token = "0x40027B5")]
		private static int total;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40027B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string <RootDirectory>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x20003C4")]
		public class TextureLoadEntry
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A4A")]
			[global::Cpp2ILInjected.Address(RVA = "0xB424A0", Offset = "0xB424A0", Length = "0x174")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentManager), Member = "UpdateAysncLoad", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resources), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::UnityEngine.Object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool Update()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001A4B")]
			[global::Cpp2ILInjected.Address(RVA = "0xB427CC", Offset = "0xB427CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public TextureLoadEntry()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40027B7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string loadAsset0;

			[global::Cpp2ILInjected.Token(Token = "0x40027B8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public string loadAsset1;

			[global::Cpp2ILInjected.Token(Token = "0x40027B9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public string loadAsset2;

			[global::Cpp2ILInjected.Token(Token = "0x40027BA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public global::UnityEngine.Texture2D request0;

			[global::Cpp2ILInjected.Token(Token = "0x40027BB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public global::UnityEngine.Texture2D request1;

			[global::Cpp2ILInjected.Token(Token = "0x40027BC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public global::UnityEngine.Texture2D request2;

			[global::Cpp2ILInjected.Token(Token = "0x40027BD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public int page;

			[global::Cpp2ILInjected.Token(Token = "0x40027BE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			public Action<global::UnityEngine.Texture2D, global::UnityEngine.Texture2D, global::UnityEngine.Texture2D, int> Callback;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20003C5")]
		public struct SourceAssetEntry
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A4C")]
			[global::Cpp2ILInjected.Address(RVA = "0xB434F8", Offset = "0xB434F8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public SourceAssetEntry(string asset, int width, int height)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40027BF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public readonly string Asset;

			[global::Cpp2ILInjected.Token(Token = "0x40027C0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public readonly int Width;

			[global::Cpp2ILInjected.Token(Token = "0x40027C1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public readonly int Height;
		}
	}
}
