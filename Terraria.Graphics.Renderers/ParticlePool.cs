using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.Graphics.Renderers;

[Cpp2IlInjected.Token(Token = "0x20004F8")]
public class ParticlePool<T> where T : IPooledParticle
{
	[Cpp2IlInjected.Token(Token = "0x200095F")]
	public delegate T ParticleInstantiator();

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006786")]
	private ParticleInstantiator _instantiator;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006787")]
	private List<T> _particles;

	[Cpp2IlInjected.Token(Token = "0x6003779")]
	[Cpp2IlInjected.Address(RVA = "0x16443C8", Offset = "0x16443C8", VA = "0x16443C8")]
	public int CountParticlesInUse()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600377A")]
	[Cpp2IlInjected.Address(RVA = "0x164440C", Offset = "0x164440C", VA = "0x164440C")]
	public ParticlePool(int initialPoolSize, ParticleInstantiator instantiator)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600377B")]
	[Cpp2IlInjected.Address(RVA = "0x1644480", Offset = "0x1644480", VA = "0x1644480")]
	public T RequestParticle()
	{
		return (T)null;
	}
}
