using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x020000C5 RID: 197
	[NativeHeader("Runtime/Misc/ResourceManagerUtility.h")]
	[NativeHeader("Runtime/Export/Resources/Resources.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x20000D7")]
	public sealed class Resources
	{
		// Token: 0x06000453 RID: 1107 RVA: 0x000029B9 File Offset: 0x00000BB9
		[global::Cpp2ILInjected.Token(Token = "0x6000467")]
		[global::Cpp2ILInjected.Address(RVA = "0x1595B18", Offset = "0x1595B18", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static T[] ConvertObjects<T>(Object[] rawObjects) where T : Object
		{
			throw null;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x000029BC File Offset: 0x00000BBC
		[global::Cpp2ILInjected.Token(Token = "0x6000468")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83EC4", Offset = "0x1F83EC4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundManager", Member = "get_MasterMixer", ReturnType = "UnityEngine.Audio.AudioMixer")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "CSVReader", Member = "Begin", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.TitleContainer", Member = "OpenStream", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.Texture2D", Member = "LoadSourceTexture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Content.ContentManager.TextureLoadEntry", Member = "Update", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Content.ContentManager", Member = "LoadUnityResource", MemberTypeParameters = new object[] { "ResourceType" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "ResourceType")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Content.ContentManager", Member = "ConstructFromUnityResource", MemberTypeParameters = new object[] { "ResourceType" }, MemberParameters = new object[]
		{
			typeof(string),
			"Microsoft.Xna.Framework.Content.ThreadContentRequest.ObjectCreate"
		}, ReturnType = "ResourceType")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Content.ContentManager", Member = "ConstructFromUnityResources", MemberTypeParameters = new object[] { "ResourceType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			"Microsoft.Xna.Framework.Content.ThreadContentRequest.ObjectCreate2"
		}, ReturnType = "ResourceType")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Content.ContentManager", Member = "ConstructFromUnityResources", MemberTypeParameters = new object[] { "ResourceType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			"Microsoft.Xna.Framework.Content.ThreadContentRequest.ObjectCreate3"
		}, ReturnType = "ResourceType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resources), Member = "Load", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type)
		}, ReturnType = typeof(Object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static Object Load(string path)
		{
			throw null;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x000029BF File Offset: 0x00000BBF
		[global::Cpp2ILInjected.Token(Token = "0x6000469")]
		[global::Cpp2ILInjected.Address(RVA = "0x1595CA8", Offset = "0x1595CA8", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LayoutDefinition", Member = "LoadReleaseLayout", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PixelShader", Member = "LoadPass", MemberParameters = new object[]
		{
			"System.Collections.Generic.List`1<EffectPass>",
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.ScreenShader", Member = "LoadPass", MemberParameters = new object[]
		{
			"System.Collections.Generic.List`1<EffectPass>",
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.TileShader", Member = "LoadPass", MemberParameters = new object[]
		{
			"System.Collections.Generic.List`1<EffectPass>",
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Player", Member = "LoadTutorialPlayer", ReturnType = "Terraria.IO.PlayerFileData")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldBuilding.WorldGenConfiguration", Member = "LoadOnMainThread", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile", Member = "GetTutorialMetadata", ReturnType = "Terraria.IO.WorldFileData")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile", Member = "LoadTutorialOnMainThread", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Metadata.TileMaterials", Member = "DeserializeEmbeddedResource", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Creative.CreativeItemSacrificesCatalog", Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resources), Member = "Load", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type)
		}, ReturnType = typeof(Object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static T Load<T>(string path) where T : Object
		{
			throw null;
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x000029C2 File Offset: 0x00000BC2
		[global::Cpp2ILInjected.Token(Token = "0x600046A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83A4C", Offset = "0x1F83A4C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Singleton`1", Member = "Create", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Resources), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourcesAPI), Member = "get_ActiveAPI", ReturnType = typeof(ResourcesAPI))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static Object Load(string path, Type systemTypeInstance)
		{
			throw null;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x000029C5 File Offset: 0x00000BC5
		[global::Cpp2ILInjected.Token(Token = "0x600046B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83F48", Offset = "0x1F83F48", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Content.ThreadContentRequest", Member = "BeginLoad", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static ResourceRequest LoadAsync(string path)
		{
			throw null;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x000029C8 File Offset: 0x00000BC8
		[global::Cpp2ILInjected.Token(Token = "0x600046C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83FCC", Offset = "0x1F83FCC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourcesAPI), Member = "get_ActiveAPI", ReturnType = typeof(ResourcesAPI))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static ResourceRequest LoadAsync(string path, Type type)
		{
			throw null;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x000029CB File Offset: 0x00000BCB
		[global::Cpp2ILInjected.Token(Token = "0x600046D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8403C", Offset = "0x1F8403C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Resources), Member = "LoadAll", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourcesAPI), Member = "get_ActiveAPI", ReturnType = typeof(ResourcesAPI))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static Object[] LoadAll(string path, Type systemTypeInstance)
		{
			throw null;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x000029CE File Offset: 0x00000BCE
		[global::Cpp2ILInjected.Token(Token = "0x600046E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1595D6C", Offset = "0x1595D6C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Localization.LanguageManager", Member = "LoadFilesForCulture", MemberParameters = new object[] { "Terraria.Localization.GameCulture" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resources), Member = "LoadAll", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type)
		}, ReturnType = typeof(Object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static T[] LoadAll<T>(string path) where T : Object
		{
			throw null;
		}

		// Token: 0x0600045B RID: 1115
		[FreeFunction("GetScriptingBuiltinResource", ThrowsException = true)]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		[global::Cpp2ILInjected.Token(Token = "0x600046F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F840AC", Offset = "0x1F840AC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Resources), Member = "GetBuiltinResource", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern Object GetBuiltinResource([NotNull("ArgumentNullException")] Type type, string path);

		// Token: 0x0600045C RID: 1116 RVA: 0x000029D1 File Offset: 0x00000BD1
		[global::Cpp2ILInjected.Token(Token = "0x6000470")]
		[global::Cpp2ILInjected.Address(RVA = "0x1595BE8", Offset = "0x1595BE8", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Text", Member = "AssignDefaultFont", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Text", Member = "AssignDefaultFontIfNecessary", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resources), Member = "GetBuiltinResource", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string)
		}, ReturnType = typeof(Object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static T GetBuiltinResource<T>(string path) where T : Object
		{
			throw null;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x000029D4 File Offset: 0x00000BD4
		[global::Cpp2ILInjected.Token(Token = "0x6000471")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F840F0", Offset = "0x1F840F0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TextureAtlasDB", Member = "SetNumberOfAtlasPages", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.Texture2D", Member = "ResetLoaded", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourcesAPI), Member = "get_ActiveAPI", ReturnType = typeof(ResourcesAPI))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void UnloadAsset(Object assetToUnload)
		{
			throw null;
		}

		// Token: 0x0600045E RID: 1118
		[FreeFunction("Resources_Bindings::UnloadUnusedAssets")]
		[global::Cpp2ILInjected.Token(Token = "0x6000472")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F84150", Offset = "0x1F84150", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchControl", Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern AsyncOperation UnloadUnusedAssets();
	}
}
