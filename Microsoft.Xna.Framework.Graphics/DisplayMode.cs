using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x200029F")]
[DataContract]
public class DisplayMode
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001EF3")]
	private SurfaceFormat format;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001EF4")]
	private int height;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001EF5")]
	private int width;

	[Cpp2IlInjected.Token(Token = "0x1700026C")]
	public float AspectRatio
	{
		[Cpp2IlInjected.Token(Token = "0x6001555")]
		[Cpp2IlInjected.Address(RVA = "0x139A240", Offset = "0x139A240", VA = "0x139A240")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026D")]
	public SurfaceFormat Format
	{
		[Cpp2IlInjected.Token(Token = "0x6001556")]
		[Cpp2IlInjected.Address(RVA = "0x139A25C", Offset = "0x139A25C", VA = "0x139A25C")]
		get
		{
			return default(SurfaceFormat);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026E")]
	public int Height
	{
		[Cpp2IlInjected.Token(Token = "0x6001557")]
		[Cpp2IlInjected.Address(RVA = "0x139A264", Offset = "0x139A264", VA = "0x139A264")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026F")]
	public int Width
	{
		[Cpp2IlInjected.Token(Token = "0x6001558")]
		[Cpp2IlInjected.Address(RVA = "0x139A26C", Offset = "0x139A26C", VA = "0x139A26C")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000270")]
	public Rectangle TitleSafeArea
	{
		[Cpp2IlInjected.Token(Token = "0x6001559")]
		[Cpp2IlInjected.Address(RVA = "0x139A274", Offset = "0x139A274", VA = "0x139A274")]
		get
		{
			return default(Rectangle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001554")]
	[Cpp2IlInjected.Address(RVA = "0x139A234", Offset = "0x139A234", VA = "0x139A234")]
	public void UpdateSize(int newWidth, int newHeight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600155A")]
	[Cpp2IlInjected.Address(RVA = "0x139A3EC", Offset = "0x139A3EC", VA = "0x139A3EC")]
	internal DisplayMode(int width, int height, SurfaceFormat format)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600155B")]
	[Cpp2IlInjected.Address(RVA = "0x139A418", Offset = "0x139A418", VA = "0x139A418")]
	public static bool operator !=(DisplayMode left, DisplayMode right)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600155C")]
	[Cpp2IlInjected.Address(RVA = "0x139A470", Offset = "0x139A470", VA = "0x139A470")]
	public static bool operator ==(DisplayMode left, DisplayMode right)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600155D")]
	[Cpp2IlInjected.Address(RVA = "0x139A4CC", Offset = "0x139A4CC", VA = "0x139A4CC", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600155E")]
	[Cpp2IlInjected.Address(RVA = "0x139A5A8", Offset = "0x139A5A8", VA = "0x139A5A8", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600155F")]
	[Cpp2IlInjected.Address(RVA = "0x139A5E8", Offset = "0x139A5E8", VA = "0x139A5E8", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
