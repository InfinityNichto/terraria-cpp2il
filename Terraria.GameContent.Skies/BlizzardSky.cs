using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies;

[Cpp2IlInjected.Token(Token = "0x200065D")]
public class BlizzardSky : CustomSky
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006CCE")]
	private UnifiedRandom _random;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006CCF")]
	private bool _isActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4006CD0")]
	private bool _isLeaving;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006CD1")]
	private float _opacity;

	[Cpp2IlInjected.Token(Token = "0x6003FD6")]
	[Cpp2IlInjected.Address(RVA = "0x111D498", Offset = "0x111D498", VA = "0x111D498", Slot = "4")]
	public override void OnLoad()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FD7")]
	[Cpp2IlInjected.Address(RVA = "0x111D49C", Offset = "0x111D49C", VA = "0x111D49C", Slot = "8")]
	public override void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FD8")]
	[Cpp2IlInjected.Address(RVA = "0x111D5DC", Offset = "0x111D5DC", VA = "0x111D5DC", Slot = "9")]
	public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FD9")]
	[Cpp2IlInjected.Address(RVA = "0x111D8A8", Offset = "0x111D8A8", VA = "0x111D8A8", Slot = "6")]
	public override void Activate(Vector2 position, params object[] args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FDA")]
	[Cpp2IlInjected.Address(RVA = "0x111D8B4", Offset = "0x111D8B4", VA = "0x111D8B4", Slot = "7")]
	public override void Deactivate(params object[] args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FDB")]
	[Cpp2IlInjected.Address(RVA = "0x111D8C0", Offset = "0x111D8C0", VA = "0x111D8C0", Slot = "11")]
	public override void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FDC")]
	[Cpp2IlInjected.Address(RVA = "0x111D8D0", Offset = "0x111D8D0", VA = "0x111D8D0", Slot = "10")]
	public override bool IsActive()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003FDD")]
	[Cpp2IlInjected.Address(RVA = "0x111D8D8", Offset = "0x111D8D8", VA = "0x111D8D8")]
	public BlizzardSky()
	{
	}
}
