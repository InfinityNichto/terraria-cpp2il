using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;

namespace Terraria.Audio;

[Cpp2IlInjected.Token(Token = "0x2000483")]
public class ActiveSound
{
	[Cpp2IlInjected.Token(Token = "0x200092F")]
	public delegate bool LoopedPlayCondition();

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40064A7")]
	public readonly bool IsGlobal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40064A8")]
	public Vector2 Position;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40064A9")]
	public float Volume;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40064AA")]
	public float Pitch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40064AC")]
	public LoopedPlayCondition Condition;

	[Cpp2IlInjected.Token(Token = "0x1700063E")]
	public SoundEffectInstance Sound
	{
		[Cpp2IlInjected.Token(Token = "0x60032BC")]
		[Cpp2IlInjected.Address(RVA = "0x106E0F0", Offset = "0x106E0F0", VA = "0x106E0F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60032BD")]
		[Cpp2IlInjected.Address(RVA = "0x106E0F8", Offset = "0x106E0F8", VA = "0x106E0F8")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700063F")]
	public SoundStyle Style
	{
		[Cpp2IlInjected.Token(Token = "0x60032BE")]
		[Cpp2IlInjected.Address(RVA = "0x106E100", Offset = "0x106E100", VA = "0x106E100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60032BF")]
		[Cpp2IlInjected.Address(RVA = "0x106E108", Offset = "0x106E108", VA = "0x106E108")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000640")]
	public bool IsPlaying
	{
		[Cpp2IlInjected.Token(Token = "0x60032C0")]
		[Cpp2IlInjected.Address(RVA = "0x106E110", Offset = "0x106E110", VA = "0x106E110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60032C1")]
	[Cpp2IlInjected.Address(RVA = "0x106E138", Offset = "0x106E138", VA = "0x106E138")]
	public ActiveSound(SoundStyle style, Vector2 position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032C2")]
	[Cpp2IlInjected.Address(RVA = "0x106E27C", Offset = "0x106E27C", VA = "0x106E27C")]
	public ActiveSound(SoundStyle style)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032C3")]
	[Cpp2IlInjected.Address(RVA = "0x106E38C", Offset = "0x106E38C", VA = "0x106E38C")]
	public ActiveSound(SoundStyle style, Vector2 position, LoopedPlayCondition condition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032C4")]
	[Cpp2IlInjected.Address(RVA = "0x106E188", Offset = "0x106E188", VA = "0x106E188")]
	private void Play()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032C5")]
	[Cpp2IlInjected.Address(RVA = "0x106E3E0", Offset = "0x106E3E0", VA = "0x106E3E0")]
	private void PlayLooped(LoopedPlayCondition condition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032C6")]
	[Cpp2IlInjected.Address(RVA = "0x106E858", Offset = "0x106E858", VA = "0x106E858")]
	public void Stop()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032C7")]
	[Cpp2IlInjected.Address(RVA = "0x106E878", Offset = "0x106E878", VA = "0x106E878")]
	public void Pause()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032C8")]
	[Cpp2IlInjected.Address(RVA = "0x106E8C4", Offset = "0x106E8C4", VA = "0x106E8C4")]
	public void Resume()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032C9")]
	[Cpp2IlInjected.Address(RVA = "0x106E4F4", Offset = "0x106E4F4", VA = "0x106E4F4")]
	public void Update()
	{
	}
}
