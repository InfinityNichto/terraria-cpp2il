using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using UnityEngine;

namespace Microsoft.Xna.Framework.Content;

[Cpp2IlInjected.Token(Token = "0x20002F2")]
public class ContentManager
{
	[Cpp2IlInjected.Token(Token = "0x200082A")]
	public class TextureLoadEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007E0E")]
		public string loadAsset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007E0F")]
		public string loadAsset1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007E10")]
		public string loadAsset2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4007E11")]
		public UnityEngine.Texture2D request0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4007E12")]
		public UnityEngine.Texture2D request1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4007E13")]
		public UnityEngine.Texture2D request2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4007E14")]
		public int page;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4007E15")]
		public Action<UnityEngine.Texture2D, UnityEngine.Texture2D, UnityEngine.Texture2D, int> Callback;

		[Cpp2IlInjected.Token(Token = "0x6004989")]
		[Cpp2IlInjected.Address(RVA = "0x12E418C", Offset = "0x12E418C", VA = "0x12E418C")]
		public bool Update()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600498A")]
		[Cpp2IlInjected.Address(RVA = "0x12E44E0", Offset = "0x12E44E0", VA = "0x12E44E0")]
		public TextureLoadEntry()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200082B")]
	public struct SourceAssetEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007E16")]
		public readonly string Asset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4007E17")]
		public readonly int Width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007E18")]
		public readonly int Height;

		[Cpp2IlInjected.Token(Token = "0x600498B")]
		[Cpp2IlInjected.Address(RVA = "0x39E2F0", Offset = "0x39E2F0", VA = "0x39E2F0")]
		public SourceAssetEntry(string asset, int width, int height)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400214F")]
	public static ContentManager Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4002150")]
	private IServiceProvider serviceProvider;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4002151")]
	private string p;

	[Cpp2IlInjected.Token(Token = "0x4002152")]
	private static List<TextureLoadEntry> LoadingAssets;

	[Cpp2IlInjected.Token(Token = "0x4002153")]
	private static UnityEngine.Texture2D emptyTexture;

	[Cpp2IlInjected.Token(Token = "0x4002154")]
	private static SourceAssetEntry[] sourceAssets;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4002155")]
	private List<Microsoft.Xna.Framework.Graphics.Texture2D> _sourceTexturesLoaded;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4002156")]
	private Dictionary<string, Microsoft.Xna.Framework.Graphics.Texture2D> _loadedTextures;

	[Cpp2IlInjected.Token(Token = "0x4002157")]
	private static int total;

	[Cpp2IlInjected.Token(Token = "0x17000347")]
	public IServiceProvider ServiceProvider
	{
		[Cpp2IlInjected.Token(Token = "0x60018EB")]
		[Cpp2IlInjected.Address(RVA = "0x12E3D58", Offset = "0x12E3D58", VA = "0x12E3D58")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000348")]
	public static bool AsyncLoadStillRequired
	{
		[Cpp2IlInjected.Token(Token = "0x60018EE")]
		[Cpp2IlInjected.Address(RVA = "0x12E3E60", Offset = "0x12E3E60", VA = "0x12E3E60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000349")]
	private static UnityEngine.Texture2D Empty
	{
		[Cpp2IlInjected.Token(Token = "0x60018F7")]
		[Cpp2IlInjected.Address(RVA = "0x12E4768", Offset = "0x12E4768", VA = "0x12E4768")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034A")]
	public string RootDirectory
	{
		[Cpp2IlInjected.Token(Token = "0x60018FF")]
		[Cpp2IlInjected.Address(RVA = "0x12E5AE4", Offset = "0x12E5AE4", VA = "0x12E5AE4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001900")]
		[Cpp2IlInjected.Address(RVA = "0x12E5AEC", Offset = "0x12E5AEC", VA = "0x12E5AEC")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60018EC")]
	[Cpp2IlInjected.Address(RVA = "0x12E3D60", Offset = "0x12E3D60", VA = "0x12E3D60")]
	public ContentManager(IServiceProvider serviceProvider, string p)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60018ED")]
	[Cpp2IlInjected.Address(RVA = "0x15F3094", Offset = "0x15F3094", VA = "0x15F3094")]
	internal T1 Load<T1>(string asset) where T1 : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60018EF")]
	[Cpp2IlInjected.Address(RVA = "0x12E3EE8", Offset = "0x12E3EE8", VA = "0x12E3EE8")]
	public static void UpdateAysncLoad()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60018F0")]
	[Cpp2IlInjected.Address(RVA = "0x12E4368", Offset = "0x12E4368", VA = "0x12E4368")]
	public static void LoadUnityTexturePageAsync(string asset0, string asset1, string asset2, int pageIndex, Action<UnityEngine.Texture2D, UnityEngine.Texture2D, UnityEngine.Texture2D, int> loadedCallback)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60018F1")]
	[Cpp2IlInjected.Address(RVA = "0x166BEC8", Offset = "0x166BEC8", VA = "0x166BEC8")]
	public static ResourceType LoadUnityResource<ResourceType>(string asset) where ResourceType : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60018F2")]
	[Cpp2IlInjected.Address(RVA = "0x166B9F4", Offset = "0x166B9F4", VA = "0x166B9F4")]
	public static ResourceType ConstructFromUnityResource<ResourceType>(string asset, ThreadContentRequest.ObjectCreate createFunction) where ResourceType : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60018F3")]
	[Cpp2IlInjected.Address(RVA = "0x166BB70", Offset = "0x166BB70", VA = "0x166BB70")]
	public static ResourceType ConstructFromUnityResources<ResourceType>(string asset, string asset2, ThreadContentRequest.ObjectCreate2 createFunction) where ResourceType : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60018F4")]
	[Cpp2IlInjected.Address(RVA = "0x166BD08", Offset = "0x166BD08", VA = "0x166BD08")]
	public static ResourceType ConstructFromUnityResources<ResourceType>(string asset, string asset2, string asset3, ThreadContentRequest.ObjectCreate3 createFunction) where ResourceType : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60018F5")]
	[Cpp2IlInjected.Address(RVA = "0x12E44E8", Offset = "0x12E44E8", VA = "0x12E44E8")]
	private static object CreateTextureAsset(object resource)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60018F6")]
	[Cpp2IlInjected.Address(RVA = "0x12E45EC", Offset = "0x12E45EC", VA = "0x12E45EC")]
	private static object CreateTextureAssets(object resource, object resource2)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60018F8")]
	[Cpp2IlInjected.Address(RVA = "0x12E48AC", Offset = "0x12E48AC", VA = "0x12E48AC")]
	private static object CreateTextureAssetsWithPal(object resource, object resource2, object resource3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60018F9")]
	[Cpp2IlInjected.Address(RVA = "0x12E4A10", Offset = "0x12E4A10", VA = "0x12E4A10")]
	public void UnloadSourceTextures()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60018FA")]
	[Cpp2IlInjected.Address(RVA = "0x12E4AA0", Offset = "0x12E4AA0", VA = "0x12E4AA0")]
	private Microsoft.Xna.Framework.Graphics.Texture2D LoadTexture2D(string asset)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60018FB")]
	[Cpp2IlInjected.Address(RVA = "0x12E5138", Offset = "0x12E5138", VA = "0x12E5138")]
	private SpriteFont LoadSpriteFont(string asset)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60018FC")]
	[Cpp2IlInjected.Address(RVA = "0x12E589C", Offset = "0x12E589C", VA = "0x12E589C")]
	private static object CreateSoundEffect(object resource)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60018FD")]
	[Cpp2IlInjected.Address(RVA = "0x12E59A4", Offset = "0x12E59A4", VA = "0x12E59A4")]
	private SoundEffect LoadSoundEffect(string asset)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60018FE")]
	[Cpp2IlInjected.Address(RVA = "0x12E5AE0", Offset = "0x12E5AE0", VA = "0x12E5AE0")]
	internal void Unload()
	{
	}
}
