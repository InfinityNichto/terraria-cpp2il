using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector;

[Cpp2IlInjected.Token(Token = "0x20002E7")]
public interface IPackedVector
{
	[Cpp2IlInjected.Token(Token = "0x600186E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PackFromVector4(Vector4 vector);

	[Cpp2IlInjected.Token(Token = "0x600186F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector4 ToVector4();
}
[Cpp2IlInjected.Token(Token = "0x20002E8")]
public interface IPackedVector<TPacked> : IPackedVector
{
	[Cpp2IlInjected.Token(Token = "0x1700033D")]
	TPacked PackedValue
	{
		[Cpp2IlInjected.Token(Token = "0x6001870")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6001871")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
