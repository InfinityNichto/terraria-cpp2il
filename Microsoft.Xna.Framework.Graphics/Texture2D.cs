using System.IO;
using Cpp2IlInjected;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002DC")]
public class Texture2D : Texture
{
	[Cpp2IlInjected.Token(Token = "0x2000827")]
	protected internal enum SurfaceType
	{
		[Cpp2IlInjected.Token(Token = "0x4007E08")]
		Texture,
		[Cpp2IlInjected.Token(Token = "0x4007E09")]
		RenderTarget,
		[Cpp2IlInjected.Token(Token = "0x4007E0A")]
		SwapChainRenderTarget
	}

	[Cpp2IlInjected.Token(Token = "0x2000828")]
	public delegate UnityEngine.Texture2D TextureLoader(int data);

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4002121")]
	public int UnityWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4002122")]
	public int UnityHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4002123")]
	public readonly int Width;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4002124")]
	public readonly int Height;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4002125")]
	internal int ArraySize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4002126")]
	internal float TexelWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4002127")]
	internal float TexelHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4002128")]
	public float TextureOffsetScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4002129")]
	public bool SharedBatching;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x400212A")]
	public bool NonSharedHeadInsert;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400212B")]
	public TextureAtlasEntry PackedEntry;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400212C")]
	private bool loadRequested;

	[Cpp2IlInjected.Token(Token = "0x400212D")]
	public static bool ignoreLoad;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4D")]
	[Cpp2IlInjected.Token(Token = "0x400212E")]
	private bool _textureLoaded;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400212F")]
	private RenderTexture _unityRenderTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4002130")]
	private UnityEngine.Texture2D _unityTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4002131")]
	private UnityEngine.Texture2D _unityAlphaTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4002132")]
	private UnityEngine.Texture2D _unityPalTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4002133")]
	public TextureAtlasDB _textureAtlas;

	[Cpp2IlInjected.Token(Token = "0x4002134")]
	private static int _nextTextureId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4002135")]
	private readonly int _batchTextureIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4002136")]
	public int BatchTextureIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4002137")]
	private string _sourceLoadAsset;

	[Cpp2IlInjected.Token(Token = "0x17000325")]
	public int UnityTextureWidth
	{
		[Cpp2IlInjected.Token(Token = "0x60017CD")]
		[Cpp2IlInjected.Address(RVA = "0x154BFD4", Offset = "0x154BFD4", VA = "0x154BFD4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000326")]
	public int UnityTextureHeight
	{
		[Cpp2IlInjected.Token(Token = "0x60017D0")]
		[Cpp2IlInjected.Address(RVA = "0x154C648", Offset = "0x154C648", VA = "0x154C648")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000327")]
	public UnityEngine.Texture UnityBindTexture
	{
		[Cpp2IlInjected.Token(Token = "0x60017D1")]
		[Cpp2IlInjected.Address(RVA = "0x154C020", Offset = "0x154C020", VA = "0x154C020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000328")]
	public UnityEngine.Texture2D UnityTexture
	{
		[Cpp2IlInjected.Token(Token = "0x60017D3")]
		[Cpp2IlInjected.Address(RVA = "0x154C694", Offset = "0x154C694", VA = "0x154C694")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000329")]
	public UnityEngine.Texture2D UnityAlphaTexture
	{
		[Cpp2IlInjected.Token(Token = "0x60017D4")]
		[Cpp2IlInjected.Address(RVA = "0x154C8A8", Offset = "0x154C8A8", VA = "0x154C8A8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032A")]
	public UnityEngine.Texture2D UnityPalTexture
	{
		[Cpp2IlInjected.Token(Token = "0x60017D5")]
		[Cpp2IlInjected.Address(RVA = "0x154C8B0", Offset = "0x154C8B0", VA = "0x154C8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032B")]
	public Rectangle Bounds
	{
		[Cpp2IlInjected.Token(Token = "0x60017D8")]
		[Cpp2IlInjected.Address(RVA = "0x154C940", Offset = "0x154C940", VA = "0x154C940")]
		get
		{
			return default(Rectangle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60017CC")]
	[Cpp2IlInjected.Address(RVA = "0x154BDC8", Offset = "0x154BDC8", VA = "0x154BDC8")]
	public void ResetLoaded()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017CE")]
	[Cpp2IlInjected.Address(RVA = "0x154C0BC", Offset = "0x154C0BC", VA = "0x154C0BC")]
	private void LoadCallback(UnityEngine.Texture2D tex0, UnityEngine.Texture2D tex1, UnityEngine.Texture2D tex2, int page)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017CF")]
	[Cpp2IlInjected.Address(RVA = "0x154C284", Offset = "0x154C284", VA = "0x154C284")]
	private void LoadSourceTexture()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017D2")]
	[Cpp2IlInjected.Address(RVA = "0x154C7F4", Offset = "0x154C7F4", VA = "0x154C7F4")]
	public void RefreshAtlasTexture()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017D6")]
	[Cpp2IlInjected.Address(RVA = "0x154C8B8", Offset = "0x154C8B8", VA = "0x154C8B8")]
	public static int GetBatchId()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60017D7")]
	[Cpp2IlInjected.Address(RVA = "0x154BF98", Offset = "0x154BF98", VA = "0x154BF98")]
	public void RefreshBatchIndex()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017D9")]
	[Cpp2IlInjected.Address(RVA = "0x154C978", Offset = "0x154C978", VA = "0x154C978")]
	public Texture2D(string sourceAsset, int width, int height)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017DA")]
	[Cpp2IlInjected.Address(RVA = "0x154CC2C", Offset = "0x154CC2C", VA = "0x154CC2C")]
	public Texture2D(UnityEngine.Texture2D texture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017DB")]
	[Cpp2IlInjected.Address(RVA = "0x154CCE0", Offset = "0x154CCE0", VA = "0x154CCE0")]
	public Texture2D(RenderTexture texture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017DC")]
	[Cpp2IlInjected.Address(RVA = "0x154CD98", Offset = "0x154CD98", VA = "0x154CD98")]
	public Texture2D(UnityEngine.Texture2D texture, UnityEngine.Texture2D texture2)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017DD")]
	[Cpp2IlInjected.Address(RVA = "0x154CF04", Offset = "0x154CF04", VA = "0x154CF04")]
	public Texture2D(UnityEngine.Texture2D texture, UnityEngine.Texture2D texture2, UnityEngine.Texture2D texture3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017DE")]
	[Cpp2IlInjected.Address(RVA = "0x154D138", Offset = "0x154D138", VA = "0x154D138")]
	public Texture2D(UnityEngine.Texture2D texture, TextureAtlasEntry entry)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017DF")]
	[Cpp2IlInjected.Address(RVA = "0x154D258", Offset = "0x154D258", VA = "0x154D258")]
	public Texture2D(TextureAtlasDB textureAtlas, TextureAtlasEntry entry)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017E0")]
	[Cpp2IlInjected.Address(RVA = "0x154D3A4", Offset = "0x154D3A4", VA = "0x154D3A4")]
	private void CreateEmptyTexture(object data)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017E1")]
	[Cpp2IlInjected.Address(RVA = "0x154D42C", Offset = "0x154D42C", VA = "0x154D42C")]
	public Texture2D(GraphicsDevice device, int width, int height)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017E2")]
	[Cpp2IlInjected.Address(RVA = "0x154D594", Offset = "0x154D594", VA = "0x154D594")]
	public Texture2D(GraphicsDevice device, int width, int height, bool mipmap, SurfaceFormat format)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017E3")]
	[Cpp2IlInjected.Address(RVA = "0x154D5CC", Offset = "0x154D5CC", VA = "0x154D5CC")]
	public Texture2D(GraphicsDevice device, int width, int height, bool mipmap, SurfaceFormat format, int arraySize)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017E4")]
	[Cpp2IlInjected.Address(RVA = "0x154D604", Offset = "0x154D604", VA = "0x154D604")]
	internal Texture2D(GraphicsDevice device, int width, int height, bool mipmap, SurfaceFormat format, SurfaceType type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017E5")]
	[Cpp2IlInjected.Address(RVA = "0x154C9D8", Offset = "0x154C9D8", VA = "0x154C9D8")]
	protected Texture2D(GraphicsDevice device, int width, int height, bool mipmap, SurfaceFormat format, SurfaceType type, bool shared, int arraySize)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017E6")]
	[Cpp2IlInjected.Address(RVA = "0x154D63C", Offset = "0x154D63C", VA = "0x154D63C")]
	public void SaveAsPng(Stream stream, int width, int height)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017E7")]
	[Cpp2IlInjected.Address(RVA = "0x1606F14", Offset = "0x1606F14", VA = "0x1606F14")]
	public void SetData<T>(T[] data, int start, int length)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017E8")]
	[Cpp2IlInjected.Address(RVA = "0x154D640", Offset = "0x154D640", VA = "0x154D640")]
	private static void ConvertToABGR(int pixelHeight, int pixelWidth, int[] pixels)
	{
	}
}
