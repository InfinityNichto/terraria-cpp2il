using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Animations;
using Terraria.GameContent.Skies.CreditsRoll;
using Terraria.Graphics.Effects;

namespace Terraria.GameContent.Skies;

[Cpp2IlInjected.Token(Token = "0x200065E")]
public class CreditsRollSky : CustomSky
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006CD2")]
	private int _endTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006CD3")]
	private int _currentTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006CD4")]
	private CreditsRollComposer _composer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006CD5")]
	private List<IAnimationSegment> _segmentsInGame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4006CD6")]
	private List<IAnimationSegment> _segmentsInMainMenu;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4006CD7")]
	private bool _isActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4006CD8")]
	private bool _wantsToBeSeen;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4006CD9")]
	private float _opacity;

	[Cpp2IlInjected.Token(Token = "0x1700077A")]
	public int AmountOfTimeNeededForFullPlay
	{
		[Cpp2IlInjected.Token(Token = "0x6003FDE")]
		[Cpp2IlInjected.Address(RVA = "0x13C1C98", Offset = "0x13C1C98", VA = "0x13C1C98")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003FDF")]
	[Cpp2IlInjected.Address(RVA = "0x13C1CA0", Offset = "0x13C1CA0", VA = "0x13C1CA0")]
	public CreditsRollSky()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FE0")]
	[Cpp2IlInjected.Address(RVA = "0x13C1E30", Offset = "0x13C1E30", VA = "0x13C1E30", Slot = "8")]
	public override void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FE1")]
	[Cpp2IlInjected.Address(RVA = "0x13C2114", Offset = "0x13C2114", VA = "0x13C2114", Slot = "9")]
	public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FE2")]
	[Cpp2IlInjected.Address(RVA = "0x13C239C", Offset = "0x13C239C", VA = "0x13C239C", Slot = "10")]
	public override bool IsActive()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003FE3")]
	[Cpp2IlInjected.Address(RVA = "0x13C23A4", Offset = "0x13C23A4", VA = "0x13C23A4", Slot = "11")]
	public override void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FE4")]
	[Cpp2IlInjected.Address(RVA = "0x13C23C4", Offset = "0x13C23C4", VA = "0x13C23C4", Slot = "6")]
	public override void Activate(Vector2 position, params object[] args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FE5")]
	[Cpp2IlInjected.Address(RVA = "0x13C1D64", Offset = "0x13C1D64", VA = "0x13C1D64")]
	private void EnsureSegmentsAreMade()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FE6")]
	[Cpp2IlInjected.Address(RVA = "0x13C23FC", Offset = "0x13C23FC", VA = "0x13C23FC", Slot = "7")]
	public override void Deactivate(params object[] args)
	{
	}
}
