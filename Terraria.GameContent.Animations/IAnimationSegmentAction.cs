using Cpp2IlInjected;

namespace Terraria.GameContent.Animations;

[Cpp2IlInjected.Token(Token = "0x200064B")]
public interface IAnimationSegmentAction<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000775")]
	int ExpectedLengthOfActionInFrames
	{
		[Cpp2IlInjected.Token(Token = "0x6003F5D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6003F5C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BindTo(T obj);

	[Cpp2IlInjected.Token(Token = "0x6003F5E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ApplyTo(T obj, float localTimeForObj);

	[Cpp2IlInjected.Token(Token = "0x6003F5F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SetDelay(float delay);
}
