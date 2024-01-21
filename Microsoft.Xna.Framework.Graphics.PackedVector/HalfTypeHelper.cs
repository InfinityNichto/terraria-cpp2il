using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector;

[Cpp2IlInjected.Token(Token = "0x20002E4")]
internal class HalfTypeHelper
{
	[StructLayout(2)]
	[Cpp2IlInjected.Token(Token = "0x2000829")]
	private struct uif
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007E0B")]
		public float f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007E0C")]
		public int i;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007E0D")]
		public uint u;
	}

	[Cpp2IlInjected.Token(Token = "0x600184F")]
	[Cpp2IlInjected.Address(RVA = "0x158B810", Offset = "0x158B810", VA = "0x158B810")]
	internal static ushort Convert(float f)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6001850")]
	[Cpp2IlInjected.Address(RVA = "0x158BA9C", Offset = "0x158BA9C", VA = "0x158BA9C")]
	internal static ushort Convert(int i)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6001851")]
	[Cpp2IlInjected.Address(RVA = "0x158B82C", Offset = "0x158B82C", VA = "0x158B82C")]
	internal static float Convert(ushort value)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6001852")]
	[Cpp2IlInjected.Address(RVA = "0x158BB6C", Offset = "0x158BB6C", VA = "0x158BB6C")]
	public HalfTypeHelper()
	{
	}
}
