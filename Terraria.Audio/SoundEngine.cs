using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using ReLogic.Utilities;

namespace Terraria.Audio;

[Cpp2IlInjected.Token(Token = "0x200048A")]
public static class SoundEngine
{
	[Cpp2IlInjected.Token(Token = "0x4006508")]
	public static LegacySoundPlayer LegacySoundPlayer;

	[Cpp2IlInjected.Token(Token = "0x4006509")]
	public static SoundPlayer SoundPlayer;

	[Cpp2IlInjected.Token(Token = "0x400650A")]
	public static bool AreSoundsPaused;

	[Cpp2IlInjected.Token(Token = "0x17000644")]
	public static bool IsAudioSupported
	{
		[Cpp2IlInjected.Token(Token = "0x6003304")]
		[Cpp2IlInjected.Address(RVA = "0x11C7FC4", Offset = "0x11C7FC4", VA = "0x11C7FC4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6003305")]
		[Cpp2IlInjected.Address(RVA = "0x11C801C", Offset = "0x11C801C", VA = "0x11C801C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003306")]
	[Cpp2IlInjected.Address(RVA = "0x11C8078", Offset = "0x11C8078", VA = "0x11C8078")]
	public static void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003307")]
	[Cpp2IlInjected.Address(RVA = "0x11C80DC", Offset = "0x11C80DC", VA = "0x11C80DC")]
	public static void Load(IServiceProvider services)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003308")]
	[Cpp2IlInjected.Address(RVA = "0x11C8254", Offset = "0x11C8254", VA = "0x11C8254")]
	public static void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003309")]
	[Cpp2IlInjected.Address(RVA = "0x11C8E88", Offset = "0x11C8E88", VA = "0x11C8E88")]
	public static void Reload()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600330A")]
	[Cpp2IlInjected.Address(RVA = "0x11C8F50", Offset = "0x11C8F50", VA = "0x11C8F50")]
	public static void PlaySound(int type, Vector2 position, int style = 1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600330B")]
	[Cpp2IlInjected.Address(RVA = "0x11C90B8", Offset = "0x11C90B8", VA = "0x11C90B8")]
	public static SoundEffectInstance PlaySound(LegacySoundStyle type, Vector2 position)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600330C")]
	[Cpp2IlInjected.Address(RVA = "0x11C90D4", Offset = "0x11C90D4", VA = "0x11C90D4")]
	public static SoundEffectInstance PlaySound(LegacySoundStyle type, int x = -1, int y = -1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600330D")]
	[Cpp2IlInjected.Address(RVA = "0x11C8F90", Offset = "0x11C8F90", VA = "0x11C8F90")]
	public static SoundEffectInstance PlaySound(int type, int x = -1, int y = -1, int Style = 1, float volumeScale = 1f, float pitchOffset = 0f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600330E")]
	[Cpp2IlInjected.Address(RVA = "0x11C920C", Offset = "0x11C920C", VA = "0x11C920C")]
	public static ActiveSound GetActiveSound(SlotId id)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600330F")]
	[Cpp2IlInjected.Address(RVA = "0x11C9388", Offset = "0x11C9388", VA = "0x11C9388")]
	public static SlotId PlayTrackedSound(SoundStyle style, Vector2 position)
	{
		return default(SlotId);
	}

	[Cpp2IlInjected.Token(Token = "0x6003310")]
	[Cpp2IlInjected.Address(RVA = "0x11C9700", Offset = "0x11C9700", VA = "0x11C9700")]
	public static SlotId PlayTrackedLoopedSound(SoundStyle style, Vector2 position, [Optional] ActiveSound.LoopedPlayCondition loopingCondition)
	{
		return default(SlotId);
	}

	[Cpp2IlInjected.Token(Token = "0x6003311")]
	[Cpp2IlInjected.Address(RVA = "0x11C9A88", Offset = "0x11C9A88", VA = "0x11C9A88")]
	public static SlotId PlayTrackedSound(SoundStyle style)
	{
		return default(SlotId);
	}

	[Cpp2IlInjected.Token(Token = "0x6003312")]
	[Cpp2IlInjected.Address(RVA = "0x11C9CD0", Offset = "0x11C9CD0", VA = "0x11C9CD0")]
	public static void StopTrackedSounds()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003313")]
	[Cpp2IlInjected.Address(RVA = "0x11C7D54", Offset = "0x11C7D54", VA = "0x11C7D54")]
	public static SoundEffect GetTrackableSoundByStyleId(int id)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003314")]
	[Cpp2IlInjected.Address(RVA = "0x11CA070", Offset = "0x11CA070", VA = "0x11CA070")]
	public static void StopAmbientSounds()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003315")]
	[Cpp2IlInjected.Address(RVA = "0x11CA158", Offset = "0x11CA158", VA = "0x11CA158")]
	public static ActiveSound FindActiveSound(SoundStyle style)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003316")]
	[Cpp2IlInjected.Address(RVA = "0x11C80D4", Offset = "0x11C80D4", VA = "0x11C80D4")]
	private static bool TestAudioSupport()
	{
		return default(bool);
	}
}
