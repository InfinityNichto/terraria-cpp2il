using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000234")]
public class TextureAtlasDB
{
	[Cpp2IlInjected.Token(Token = "0x200080A")]
	public enum AtlasIds
	{
		[Cpp2IlInjected.Token(Token = "0x4007D40")]
		Tiles,
		[Cpp2IlInjected.Token(Token = "0x4007D41")]
		Misc,
		[Cpp2IlInjected.Token(Token = "0x4007D42")]
		NPC,
		[Cpp2IlInjected.Token(Token = "0x4007D43")]
		Walls,
		[Cpp2IlInjected.Token(Token = "0x4007D44")]
		Waterfall,
		[Cpp2IlInjected.Token(Token = "0x4007D45")]
		Trees,
		[Cpp2IlInjected.Token(Token = "0x4007D46")]
		Player,
		[Cpp2IlInjected.Token(Token = "0x4007D47")]
		Item,
		[Cpp2IlInjected.Token(Token = "0x4007D48")]
		Projectile,
		[Cpp2IlInjected.Token(Token = "0x4007D49")]
		Gore,
		[Cpp2IlInjected.Token(Token = "0x4007D4A")]
		Glow,
		[Cpp2IlInjected.Token(Token = "0x4007D4B")]
		MapBG,
		[Cpp2IlInjected.Token(Token = "0x4007D4C")]
		UI,
		[Cpp2IlInjected.Token(Token = "0x4007D4D")]
		Buff,
		[Cpp2IlInjected.Token(Token = "0x4007D4E")]
		MiniMap,
		[Cpp2IlInjected.Token(Token = "0x4007D4F")]
		Background,
		[Cpp2IlInjected.Token(Token = "0x4007D50")]
		Count
	}

	[Cpp2IlInjected.Token(Token = "0x200080B")]
	private struct SwitchEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007D51")]
		public int atlas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4007D52")]
		public bool useLowRes;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001B5F")]
	public int[] BatchTextureIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001B60")]
	public int[] TextureWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001B61")]
	public int[] TextureHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001B62")]
	private bool UseLowResTextures;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16")]
	[Cpp2IlInjected.Token(Token = "0x4001B63")]
	private short NumberOfPages;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001B64")]
	private string Id;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001B65")]
	private bool loaded;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001B66")]
	private bool[] TexturesLoadRequested;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001B67")]
	private Texture2D[] Textures;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001B68")]
	private Texture2D[] TexturesAlpha;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4001B69")]
	private Texture2D[] TexturesPal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4001B6A")]
	private Dictionary<int, TextureAtlasEntry> AtlasEntries;

	[Cpp2IlInjected.Token(Token = "0x4001B6B")]
	public static List<TextureAtlasDB> AltlasDBs;

	[Cpp2IlInjected.Token(Token = "0x4001B6C")]
	private static bool _uiTexturesHigh;

	[Cpp2IlInjected.Token(Token = "0x4001B6D")]
	private static bool _characterTexturesHigh;

	[Cpp2IlInjected.Token(Token = "0x4001B6E")]
	private static bool _projectileTexturesHigh;

	[Cpp2IlInjected.Token(Token = "0x4001B6F")]
	private static bool _backgroundTexturesHigh;

	[Cpp2IlInjected.Token(Token = "0x4001B70")]
	private static bool _goreTexturesHigh;

	[Cpp2IlInjected.Token(Token = "0x4001B71")]
	private static bool _glowTexturesHigh;

	[Cpp2IlInjected.Token(Token = "0x4001B72")]
	private static bool _environmentTexturesHigh;

	[Cpp2IlInjected.Token(Token = "0x4001B73")]
	private static List<SwitchEntry> pendingSwitches;

	[Cpp2IlInjected.Token(Token = "0x4001B74")]
	private static bool PendingUnload;

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public static bool DefaultTexturesHigh
	{
		[Cpp2IlInjected.Token(Token = "0x6000FF4")]
		[Cpp2IlInjected.Address(RVA = "0x10C99A4", Offset = "0x10C99A4", VA = "0x10C99A4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	private string ContentRoot
	{
		[Cpp2IlInjected.Token(Token = "0x6000FF7")]
		[Cpp2IlInjected.Address(RVA = "0x10C9F04", Offset = "0x10C9F04", VA = "0x10C9F04")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public static bool UITexturesHigh
	{
		[Cpp2IlInjected.Token(Token = "0x6001006")]
		[Cpp2IlInjected.Address(RVA = "0x10CBAA8", Offset = "0x10CBAA8", VA = "0x10CBAA8")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001007")]
		[Cpp2IlInjected.Address(RVA = "0x10CBB20", Offset = "0x10CBB20", VA = "0x10CBB20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public static bool CharacterTexturesHigh
	{
		[Cpp2IlInjected.Token(Token = "0x6001008")]
		[Cpp2IlInjected.Address(RVA = "0x10CBC0C", Offset = "0x10CBC0C", VA = "0x10CBC0C")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001009")]
		[Cpp2IlInjected.Address(RVA = "0x10CBC84", Offset = "0x10CBC84", VA = "0x10CBC84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public static bool ProjectileTexturesHigh
	{
		[Cpp2IlInjected.Token(Token = "0x600100A")]
		[Cpp2IlInjected.Address(RVA = "0x10CBD58", Offset = "0x10CBD58", VA = "0x10CBD58")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600100B")]
		[Cpp2IlInjected.Address(RVA = "0x10CBDD0", Offset = "0x10CBDD0", VA = "0x10CBDD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public static bool BackgroundTexturesHigh
	{
		[Cpp2IlInjected.Token(Token = "0x600100C")]
		[Cpp2IlInjected.Address(RVA = "0x10CBE94", Offset = "0x10CBE94", VA = "0x10CBE94")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600100D")]
		[Cpp2IlInjected.Address(RVA = "0x10CBF0C", Offset = "0x10CBF0C", VA = "0x10CBF0C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public static bool GoreTexturesHigh
	{
		[Cpp2IlInjected.Token(Token = "0x600100E")]
		[Cpp2IlInjected.Address(RVA = "0x10CBFEC", Offset = "0x10CBFEC", VA = "0x10CBFEC")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600100F")]
		[Cpp2IlInjected.Address(RVA = "0x10CC064", Offset = "0x10CC064", VA = "0x10CC064")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public static bool GlowTexturesHigh
	{
		[Cpp2IlInjected.Token(Token = "0x6001010")]
		[Cpp2IlInjected.Address(RVA = "0x10CC128", Offset = "0x10CC128", VA = "0x10CC128")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001011")]
		[Cpp2IlInjected.Address(RVA = "0x10CC1A0", Offset = "0x10CC1A0", VA = "0x10CC1A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public static bool EnvironmentTexturesHigh
	{
		[Cpp2IlInjected.Token(Token = "0x6001012")]
		[Cpp2IlInjected.Address(RVA = "0x10CC264", Offset = "0x10CC264", VA = "0x10CC264")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001013")]
		[Cpp2IlInjected.Address(RVA = "0x10CC2DC", Offset = "0x10CC2DC", VA = "0x10CC2DC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000FF5")]
	[Cpp2IlInjected.Address(RVA = "0x10C99D8", Offset = "0x10C99D8", VA = "0x10C99D8")]
	public static void LoadTextureDBs()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FF6")]
	[Cpp2IlInjected.Address(RVA = "0x10C9C14", Offset = "0x10C9C14", VA = "0x10C9C14")]
	public static bool LoadTexture(string file, out TextureAtlasDB atlas, out TextureAtlasEntry atlasEntry)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000FF8")]
	[Cpp2IlInjected.Address(RVA = "0x10C9B9C", Offset = "0x10C9B9C", VA = "0x10C9B9C")]
	private static TextureAtlasDB LoadDB(string id, bool useLowResTextures = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000FF9")]
	[Cpp2IlInjected.Address(RVA = "0x10C9F70", Offset = "0x10C9F70", VA = "0x10C9F70")]
	public TextureAtlasDB(string id)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FFA")]
	[Cpp2IlInjected.Address(RVA = "0x10CA5D8", Offset = "0x10CA5D8", VA = "0x10CA5D8")]
	public void SetNumberOfAtlasPages(short pages)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FFB")]
	[Cpp2IlInjected.Address(RVA = "0x10CA84C", Offset = "0x10CA84C", VA = "0x10CA84C")]
	private void LoadTextures()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FFC")]
	[Cpp2IlInjected.Address(RVA = "0x10CAC60", Offset = "0x10CAC60", VA = "0x10CAC60")]
	public void AddEntry(TextureAtlasEntry entry)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FFD")]
	[Cpp2IlInjected.Address(RVA = "0x10CA004", Offset = "0x10CA004", VA = "0x10CA004")]
	public void Load()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000FFE")]
	[Cpp2IlInjected.Address(RVA = "0x10CAF44", Offset = "0x10CAF44", VA = "0x10CAF44")]
	public byte[] Save()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000FFF")]
	[Cpp2IlInjected.Address(RVA = "0x10CB52C", Offset = "0x10CB52C", VA = "0x10CB52C")]
	private void LoadCallback(Texture2D tex0, Texture2D tex1, Texture2D tex2, int page)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001000")]
	[Cpp2IlInjected.Address(RVA = "0x10CB76C", Offset = "0x10CB76C", VA = "0x10CB76C")]
	public void LoadTexturesAsync(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001001")]
	[Cpp2IlInjected.Address(RVA = "0x10CA890", Offset = "0x10CA890", VA = "0x10CA890")]
	public Texture2D AltlasTexture(int index)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001002")]
	[Cpp2IlInjected.Address(RVA = "0x10CB984", Offset = "0x10CB984", VA = "0x10CB984")]
	public Texture2D AltlasAlphaTexture(int index)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001003")]
	[Cpp2IlInjected.Address(RVA = "0x10CB994", Offset = "0x10CB994", VA = "0x10CB994")]
	public Texture2D AltlasPalTexture(int index)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001004")]
	[Cpp2IlInjected.Address(RVA = "0x10C9E78", Offset = "0x10C9E78", VA = "0x10C9E78")]
	public bool GetTexture(int fileUID, out TextureAtlasDB atlas, out TextureAtlasEntry atlasEntry)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001005")]
	[Cpp2IlInjected.Address(RVA = "0x10CB9A4", Offset = "0x10CB9A4", VA = "0x10CB9A4")]
	private static void SwitchAtlas(int atlas, bool useLowRes)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001014")]
	[Cpp2IlInjected.Address(RVA = "0x10CC3C8", Offset = "0x10CC3C8", VA = "0x10CC3C8")]
	public static bool PendingAssetUnload()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001015")]
	[Cpp2IlInjected.Address(RVA = "0x10CC478", Offset = "0x10CC478", VA = "0x10CC478")]
	public static void ActionPendingUnloadAssets(bool fromLowMemory = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001016")]
	[Cpp2IlInjected.Address(RVA = "0x10CC7A4", Offset = "0x10CC7A4", VA = "0x10CC7A4")]
	public static void UnloadAssets()
	{
	}
}
