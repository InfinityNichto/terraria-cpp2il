using Cpp2IlInjected;

namespace Terraria.Graphics.Renderers;

[Cpp2IlInjected.Token(Token = "0x20004F9")]
public interface IPooledParticle : IParticle
{
	[Cpp2IlInjected.Token(Token = "0x170006EB")]
	bool IsRestingInPool
	{
		[Cpp2IlInjected.Token(Token = "0x600377C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600377D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RestInPool();

	[Cpp2IlInjected.Token(Token = "0x600377E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FetchFromPool();
}
