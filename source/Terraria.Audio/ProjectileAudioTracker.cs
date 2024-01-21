using Cpp2IlInjected;

namespace Terraria.Audio;

[Cpp2IlInjected.Token(Token = "0x2000484")]
public class ProjectileAudioTracker
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40064AD")]
	private int _expectedType;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40064AE")]
	private int _expectedIndex;

	[Cpp2IlInjected.Token(Token = "0x60032CA")]
	[Cpp2IlInjected.Address(RVA = "0x11C7EBC", Offset = "0x11C7EBC", VA = "0x11C7EBC")]
	public ProjectileAudioTracker(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032CB")]
	[Cpp2IlInjected.Address(RVA = "0x11C7EE8", Offset = "0x11C7EE8", VA = "0x11C7EE8")]
	public bool IsActiveAndInGame()
	{
		return default(bool);
	}
}
