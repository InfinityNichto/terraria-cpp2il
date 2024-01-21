using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000426")]
public class DoubleStack<T1>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40062BC")]
	private T1[][] _segmentList;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40062BD")]
	private readonly int _segmentSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40062BE")]
	private int _segmentCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40062BF")]
	private readonly int _segmentShiftPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40062C0")]
	private int _start;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40062C1")]
	private int _end;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40062C2")]
	private int _size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40062C3")]
	private int _last;

	[Cpp2IlInjected.Token(Token = "0x1700060B")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x60030F7")]
		[Cpp2IlInjected.Address(RVA = "0x163C9A4", Offset = "0x163C9A4", VA = "0x163C9A4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60030EF")]
	[Cpp2IlInjected.Address(RVA = "0x163C054", Offset = "0x163C054", VA = "0x163C054")]
	public DoubleStack(int segmentSize = 1024, int initialSize = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60030F0")]
	[Cpp2IlInjected.Address(RVA = "0x163C18C", Offset = "0x163C18C", VA = "0x163C18C")]
	public void PushFront(T1 front)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60030F1")]
	[Cpp2IlInjected.Address(RVA = "0x163C328", Offset = "0x163C328", VA = "0x163C328")]
	public T1 PopFront()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60030F2")]
	[Cpp2IlInjected.Address(RVA = "0x163C508", Offset = "0x163C508", VA = "0x163C508")]
	public T1 PeekFront()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60030F3")]
	[Cpp2IlInjected.Address(RVA = "0x163C5D4", Offset = "0x163C5D4", VA = "0x163C5D4")]
	public void PushBack(T1 back)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60030F4")]
	[Cpp2IlInjected.Address(RVA = "0x163C760", Offset = "0x163C760", VA = "0x163C760")]
	public T1 PopBack()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60030F5")]
	[Cpp2IlInjected.Address(RVA = "0x163C868", Offset = "0x163C868", VA = "0x163C868")]
	public T1 PeekBack()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60030F6")]
	[Cpp2IlInjected.Address(RVA = "0x163C934", Offset = "0x163C934", VA = "0x163C934")]
	public void Clear(bool quickClear = false)
	{
	}
}
