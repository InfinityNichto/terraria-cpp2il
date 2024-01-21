using System.Collections.Concurrent;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics;

[Cpp2IlInjected.Token(Token = "0x20004E2")]
internal static class TextureManager
{
	[Cpp2IlInjected.Token(Token = "0x2000959")]
	private struct LoadPair
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008B81")]
		public string Path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008B82")]
		public Ref<Texture2D> TextureRef;

		[Cpp2IlInjected.Token(Token = "0x6004D72")]
		[Cpp2IlInjected.Address(RVA = "0x39DF70", Offset = "0x39DF70", VA = "0x39DF70")]
		public LoadPair(string path, Ref<Texture2D> textureRef)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4006721")]
	private static ConcurrentDictionary<string, Texture2D> _textures;

	[Cpp2IlInjected.Token(Token = "0x4006722")]
	private static ConcurrentQueue<LoadPair> _loadQueue;

	[Cpp2IlInjected.Token(Token = "0x4006723")]
	private static Thread _loadThread;

	[Cpp2IlInjected.Token(Token = "0x4006724")]
	private static readonly object _loadThreadLock;

	[Cpp2IlInjected.Token(Token = "0x4006725")]
	public static Texture2D BlankTexture;

	[Cpp2IlInjected.Token(Token = "0x60036E1")]
	[Cpp2IlInjected.Address(RVA = "0x124D2B8", Offset = "0x124D2B8", VA = "0x124D2B8")]
	public static void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036E2")]
	[Cpp2IlInjected.Address(RVA = "0x124D3AC", Offset = "0x124D3AC", VA = "0x124D3AC")]
	public static Texture2D Load(string name)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60036E3")]
	[Cpp2IlInjected.Address(RVA = "0x124D638", Offset = "0x124D638", VA = "0x124D638")]
	public static Ref<Texture2D> Retrieve(string name)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60036E4")]
	[Cpp2IlInjected.Address(RVA = "0x124D6EC", Offset = "0x124D6EC", VA = "0x124D6EC")]
	public static void Run(object context)
	{
	}
}
