using Cpp2IlInjected;

namespace Terraria.Cinematics;

[Cpp2IlInjected.Token(Token = "0x200052A")]
public struct FrameEventData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006889")]
	private int _absoluteFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400688A")]
	private int _start;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400688B")]
	private int _duration;

	[Cpp2IlInjected.Token(Token = "0x1700070F")]
	public int AbsoluteFrame
	{
		[Cpp2IlInjected.Token(Token = "0x60038F8")]
		[Cpp2IlInjected.Address(RVA = "0x39D1FC", Offset = "0x39D1FC", VA = "0x39D1FC")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000710")]
	public int Start
	{
		[Cpp2IlInjected.Token(Token = "0x60038F9")]
		[Cpp2IlInjected.Address(RVA = "0x39D204", Offset = "0x39D204", VA = "0x39D204")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000711")]
	public int Duration
	{
		[Cpp2IlInjected.Token(Token = "0x60038FA")]
		[Cpp2IlInjected.Address(RVA = "0x39D20C", Offset = "0x39D20C", VA = "0x39D20C")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000712")]
	public int Frame
	{
		[Cpp2IlInjected.Token(Token = "0x60038FB")]
		[Cpp2IlInjected.Address(RVA = "0x39D214", Offset = "0x39D214", VA = "0x39D214")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000713")]
	public bool IsFirstFrame
	{
		[Cpp2IlInjected.Token(Token = "0x60038FC")]
		[Cpp2IlInjected.Address(RVA = "0x39D224", Offset = "0x39D224", VA = "0x39D224")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000714")]
	public bool IsLastFrame
	{
		[Cpp2IlInjected.Token(Token = "0x60038FD")]
		[Cpp2IlInjected.Address(RVA = "0x39D23C", Offset = "0x39D23C", VA = "0x39D23C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000715")]
	public int Remaining
	{
		[Cpp2IlInjected.Token(Token = "0x60038FE")]
		[Cpp2IlInjected.Address(RVA = "0x39D260", Offset = "0x39D260", VA = "0x39D260")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60038FF")]
	[Cpp2IlInjected.Address(RVA = "0x39D27C", Offset = "0x39D27C", VA = "0x39D27C")]
	public FrameEventData(int absoluteFrame, int start, int duration)
	{
	}
}
