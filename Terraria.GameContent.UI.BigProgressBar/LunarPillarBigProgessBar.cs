using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar;

[Cpp2IlInjected.Token(Token = "0x2000706")]
public abstract class LunarPillarBigProgessBar : IBigProgressBar
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4007123")]
	private BigProgressBarCache _cache;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4007124")]
	private int _headIndex;

	[Cpp2IlInjected.Token(Token = "0x60045E8")]
	[Cpp2IlInjected.Address(RVA = "0x11809A0", Offset = "0x11809A0", VA = "0x11809A0", Slot = "4")]
	public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60045E9")]
	[Cpp2IlInjected.Address(RVA = "0x1180C30", Offset = "0x1180C30", VA = "0x1180C30", Slot = "5")]
	public void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045EA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	internal abstract float GetCurrentShieldValue();

	[Cpp2IlInjected.Token(Token = "0x60045EB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	internal abstract float GetMaxShieldValue();

	[Cpp2IlInjected.Token(Token = "0x60045EC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	internal abstract bool IsPlayerInCombatArea();

	[Cpp2IlInjected.Token(Token = "0x60045ED")]
	[Cpp2IlInjected.Address(RVA = "0x1180D68", Offset = "0x1180D68", VA = "0x1180D68")]
	protected LunarPillarBigProgessBar()
	{
	}
}
