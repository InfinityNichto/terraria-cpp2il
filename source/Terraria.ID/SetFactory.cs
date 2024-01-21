using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.ID;

[Cpp2IlInjected.Token(Token = "0x2000405")]
public class SetFactory
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4005A74")]
	protected int _size;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4005A75")]
	private readonly Queue<int[]> _intBufferCache;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4005A76")]
	private readonly Queue<ushort[]> _ushortBufferCache;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4005A77")]
	private readonly Queue<bool[]> _boolBufferCache;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4005A78")]
	private readonly Queue<float[]> _floatBufferCache;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4005A79")]
	private object _queueLock;

	[Cpp2IlInjected.Token(Token = "0x60030B0")]
	[Cpp2IlInjected.Address(RVA = "0x1468CEC", Offset = "0x1468CEC", VA = "0x1468CEC")]
	public SetFactory(int size)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60030B1")]
	[Cpp2IlInjected.Address(RVA = "0x14730A0", Offset = "0x14730A0", VA = "0x14730A0")]
	protected bool[] GetBoolBuffer()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60030B2")]
	[Cpp2IlInjected.Address(RVA = "0x14731A8", Offset = "0x14731A8", VA = "0x14731A8")]
	protected int[] GetIntBuffer()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60030B3")]
	[Cpp2IlInjected.Address(RVA = "0x14732B0", Offset = "0x14732B0", VA = "0x14732B0")]
	protected ushort[] GetUshortBuffer()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60030B4")]
	[Cpp2IlInjected.Address(RVA = "0x14733B8", Offset = "0x14733B8", VA = "0x14733B8")]
	protected float[] GetFloatBuffer()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60030B5")]
	[Cpp2IlInjected.Address(RVA = "0x15A5EF0", Offset = "0x15A5EF0", VA = "0x15A5EF0")]
	public void Recycle<T>(T[] buffer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60030B6")]
	[Cpp2IlInjected.Address(RVA = "0x1468E8C", Offset = "0x1468E8C", VA = "0x1468E8C")]
	public bool[] CreateBoolSet(params int[] types)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60030B7")]
	[Cpp2IlInjected.Address(RVA = "0x1472D28", Offset = "0x1472D28", VA = "0x1472D28")]
	public bool[] CreateBoolSet(bool defaultState, params int[] types)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60030B8")]
	[Cpp2IlInjected.Address(RVA = "0x14734C0", Offset = "0x14734C0", VA = "0x14734C0")]
	public int[] CreateIntSet(params int[] types)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60030B9")]
	[Cpp2IlInjected.Address(RVA = "0x1468E98", Offset = "0x1468E98", VA = "0x1468E98")]
	public int[] CreateIntSet(int defaultState, params int[] inputs)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60030BA")]
	[Cpp2IlInjected.Address(RVA = "0x14734CC", Offset = "0x14734CC", VA = "0x14734CC")]
	public ushort[] CreateUshortSet(ushort defaultState, params ushort[] inputs)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60030BB")]
	[Cpp2IlInjected.Address(RVA = "0x1472D98", Offset = "0x1472D98", VA = "0x1472D98")]
	public float[] CreateFloatSet(float defaultState, params float[] inputs)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60030BC")]
	[Cpp2IlInjected.Address(RVA = "0x206B67C", Offset = "0x206B67C", VA = "0x206B67C")]
	public T[] CreateCustomSet<T>(T defaultState, params object[] inputs)
	{
		return null;
	}
}
