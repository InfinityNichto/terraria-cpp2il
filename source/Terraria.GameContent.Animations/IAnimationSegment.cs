using Cpp2IlInjected;

namespace Terraria.GameContent.Animations;

[Cpp2IlInjected.Token(Token = "0x200064F")]
public interface IAnimationSegment
{
	[Cpp2IlInjected.Token(Token = "0x17000776")]
	float DedicatedTimeNeeded
	{
		[Cpp2IlInjected.Token(Token = "0x6003F61")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6003F62")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Draw(ref GameAnimationSegment info);
}
