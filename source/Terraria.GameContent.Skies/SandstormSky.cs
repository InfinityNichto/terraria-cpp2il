using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies;

[Cpp2IlInjected.Token(Token = "0x2000663")]
public class SandstormSky : CustomSky
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006CF5")]
	private UnifiedRandom _random;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006CF6")]
	private bool _isActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4006CF7")]
	private bool _isLeaving;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006CF8")]
	private float _opacity;

	[Cpp2IlInjected.Token(Token = "0x6004011")]
	[Cpp2IlInjected.Address(RVA = "0x13C8A64", Offset = "0x13C8A64", VA = "0x13C8A64", Slot = "4")]
	public override void OnLoad()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004012")]
	[Cpp2IlInjected.Address(RVA = "0x13C8A68", Offset = "0x13C8A68", VA = "0x13C8A68", Slot = "8")]
	public override void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004013")]
	[Cpp2IlInjected.Address(RVA = "0x13C8BA8", Offset = "0x13C8BA8", VA = "0x13C8BA8", Slot = "9")]
	public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004014")]
	[Cpp2IlInjected.Address(RVA = "0x13C8EB4", Offset = "0x13C8EB4", VA = "0x13C8EB4", Slot = "6")]
	public override void Activate(Vector2 position, params object[] args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004015")]
	[Cpp2IlInjected.Address(RVA = "0x13C8EC0", Offset = "0x13C8EC0", VA = "0x13C8EC0", Slot = "7")]
	public override void Deactivate(params object[] args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004016")]
	[Cpp2IlInjected.Address(RVA = "0x13C8ECC", Offset = "0x13C8ECC", VA = "0x13C8ECC", Slot = "11")]
	public override void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004017")]
	[Cpp2IlInjected.Address(RVA = "0x13C8EDC", Offset = "0x13C8EDC", VA = "0x13C8EDC", Slot = "10")]
	public override bool IsActive()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004018")]
	[Cpp2IlInjected.Address(RVA = "0x13C8EE4", Offset = "0x13C8EE4", VA = "0x13C8EE4")]
	public SandstormSky()
	{
	}
}
