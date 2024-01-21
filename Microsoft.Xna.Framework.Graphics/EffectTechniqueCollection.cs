using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002A7")]
[Cpp2IlInjected.Attribute(Name = "DefaultMemberAttribute", RVA = "0x384DBC", Offset = "0x384DBC")]
public class EffectTechniqueCollection : IEnumerable<EffectTechnique>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001F0A")]
	private readonly EffectTechnique[] _techniques;

	[Cpp2IlInjected.Token(Token = "0x17000281")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600159B")]
		[Cpp2IlInjected.Address(RVA = "0x139BE60", Offset = "0x139BE60", VA = "0x139BE60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000282")]
	public EffectTechnique Item
	{
		[Cpp2IlInjected.Token(Token = "0x600159E")]
		[Cpp2IlInjected.Address(RVA = "0x139BFC0", Offset = "0x139BFC0", VA = "0x139BFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000283")]
	public EffectTechnique Item
	{
		[Cpp2IlInjected.Token(Token = "0x600159F")]
		[Cpp2IlInjected.Address(RVA = "0x139BFD0", Offset = "0x139BFD0", VA = "0x139BFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600159C")]
	[Cpp2IlInjected.Address(RVA = "0x139BE6C", Offset = "0x139BE6C", VA = "0x139BE6C")]
	internal EffectTechniqueCollection(EffectTechnique[] techniques)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600159D")]
	[Cpp2IlInjected.Address(RVA = "0x139BE8C", Offset = "0x139BE8C", VA = "0x139BE8C")]
	internal EffectTechniqueCollection Clone(Effect effect)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60015A0")]
	[Cpp2IlInjected.Address(RVA = "0x139C02C", Offset = "0x139C02C", VA = "0x139C02C", Slot = "4")]
	public IEnumerator<EffectTechnique> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60015A1")]
	[Cpp2IlInjected.Address(RVA = "0x139C0EC", Offset = "0x139C0EC", VA = "0x139C0EC", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
