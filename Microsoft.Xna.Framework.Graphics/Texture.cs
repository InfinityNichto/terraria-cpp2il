using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002DB")]
public abstract class Texture : GraphicsResource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400211D")]
	internal SurfaceFormat _format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400211E")]
	internal int _levelCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400211F")]
	private readonly int _sortingKey;

	[Cpp2IlInjected.Token(Token = "0x4002120")]
	private static int _lastSortingKey;

	[Cpp2IlInjected.Token(Token = "0x17000322")]
	internal int SortingKey
	{
		[Cpp2IlInjected.Token(Token = "0x60017C3")]
		[Cpp2IlInjected.Address(RVA = "0x154BAF0", Offset = "0x154BAF0", VA = "0x154BAF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000323")]
	public SurfaceFormat Format
	{
		[Cpp2IlInjected.Token(Token = "0x60017C4")]
		[Cpp2IlInjected.Address(RVA = "0x154BAF8", Offset = "0x154BAF8", VA = "0x154BAF8")]
		get
		{
			return default(SurfaceFormat);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000324")]
	public int LevelCount
	{
		[Cpp2IlInjected.Token(Token = "0x60017C5")]
		[Cpp2IlInjected.Address(RVA = "0x154BB00", Offset = "0x154BB00", VA = "0x154BB00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60017C6")]
	[Cpp2IlInjected.Address(RVA = "0x154BB08", Offset = "0x154BB08", VA = "0x154BB08")]
	internal static int CalculateMipLevels(int width, int height = 0, int depth = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60017C7")]
	[Cpp2IlInjected.Address(RVA = "0x154BBC8", Offset = "0x154BBC8", VA = "0x154BBC8")]
	internal static void GetSizeForLevel(int width, int height, int level, out int w, out int h)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017C8")]
	[Cpp2IlInjected.Address(RVA = "0x154BC30", Offset = "0x154BC30", VA = "0x154BC30")]
	internal static void GetSizeForLevel(int width, int height, int depth, int level, out int w, out int h, out int d)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017C9")]
	[Cpp2IlInjected.Address(RVA = "0x154BCCC", Offset = "0x154BCCC", VA = "0x154BCCC")]
	internal int GetPitch(int width)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60017CA")]
	[Cpp2IlInjected.Address(RVA = "0x154BD54", Offset = "0x154BD54", VA = "0x154BD54", Slot = "4")]
	protected internal override void GraphicsDeviceResetting()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017CB")]
	[Cpp2IlInjected.Address(RVA = "0x154BD58", Offset = "0x154BD58", VA = "0x154BD58")]
	protected Texture()
	{
	}
}
