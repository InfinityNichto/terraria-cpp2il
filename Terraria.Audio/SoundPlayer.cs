using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;

namespace Terraria.Audio;

[Cpp2IlInjected.Token(Token = "0x200048C")]
public class SoundPlayer
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400650D")]
	private readonly SlotVector<ActiveSound> _trackedSounds;

	[Cpp2IlInjected.Token(Token = "0x600331A")]
	[Cpp2IlInjected.Address(RVA = "0x11C94C4", Offset = "0x11C94C4", VA = "0x11C94C4")]
	public SlotId Play(SoundStyle style, Vector2 position)
	{
		return default(SlotId);
	}

	[Cpp2IlInjected.Token(Token = "0x600331B")]
	[Cpp2IlInjected.Address(RVA = "0x11C9844", Offset = "0x11C9844", VA = "0x11C9844")]
	public SlotId PlayLooped(SoundStyle style, Vector2 position, ActiveSound.LoopedPlayCondition loopingCondition)
	{
		return default(SlotId);
	}

	[Cpp2IlInjected.Token(Token = "0x600331C")]
	[Cpp2IlInjected.Address(RVA = "0x11C8F4C", Offset = "0x11C8F4C", VA = "0x11C8F4C")]
	public void Reload()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600331D")]
	[Cpp2IlInjected.Address(RVA = "0x11C9BA8", Offset = "0x11C9BA8", VA = "0x11C9BA8")]
	public SlotId Play(SoundStyle style)
	{
		return default(SlotId);
	}

	[Cpp2IlInjected.Token(Token = "0x600331E")]
	[Cpp2IlInjected.Address(RVA = "0x11C92F8", Offset = "0x11C92F8", VA = "0x11C92F8")]
	public ActiveSound GetActiveSound(SlotId id)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600331F")]
	[Cpp2IlInjected.Address(RVA = "0x11C85B4", Offset = "0x11C85B4", VA = "0x11C85B4")]
	public void PauseAll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003320")]
	[Cpp2IlInjected.Address(RVA = "0x11C8854", Offset = "0x11C8854", VA = "0x11C8854")]
	public void ResumeAll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003321")]
	[Cpp2IlInjected.Address(RVA = "0x11C9DB0", Offset = "0x11C9DB0", VA = "0x11C9DB0")]
	public void StopAll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003322")]
	[Cpp2IlInjected.Address(RVA = "0x11C8AF4", Offset = "0x11C8AF4", VA = "0x11C8AF4")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003323")]
	[Cpp2IlInjected.Address(RVA = "0x11CA244", Offset = "0x11CA244", VA = "0x11CA244")]
	public ActiveSound FindActiveSound(SoundStyle style)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003324")]
	[Cpp2IlInjected.Address(RVA = "0x11C81CC", Offset = "0x11C81CC", VA = "0x11C81CC")]
	public SoundPlayer()
	{
	}
}
