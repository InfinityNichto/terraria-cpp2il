using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies;

[Cpp2IlInjected.Token(Token = "0x2000661")]
public class MoonLordSky : CustomSky
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006CE8")]
	private UnifiedRandom _random;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006CE9")]
	private bool _isActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006CEA")]
	private int _moonLordIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006CEB")]
	private bool _forPlayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4006CEC")]
	private float _fadeOpacity;

	[Cpp2IlInjected.Token(Token = "0x6003FFA")]
	[Cpp2IlInjected.Address(RVA = "0x13C55D4", Offset = "0x13C55D4", VA = "0x13C55D4")]
	public MoonLordSky(bool forPlayer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FFB")]
	[Cpp2IlInjected.Address(RVA = "0x13C5658", Offset = "0x13C5658", VA = "0x13C5658", Slot = "4")]
	public override void OnLoad()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FFC")]
	[Cpp2IlInjected.Address(RVA = "0x13C565C", Offset = "0x13C565C", VA = "0x13C565C", Slot = "8")]
	public override void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FFD")]
	[Cpp2IlInjected.Address(RVA = "0x13C5750", Offset = "0x13C5750", VA = "0x13C5750")]
	private float GetIntensity()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6003FFE")]
	[Cpp2IlInjected.Address(RVA = "0x13C5ABC", Offset = "0x13C5ABC", VA = "0x13C5ABC", Slot = "12")]
	public override Color OnTileColor(Color inColor)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6003FFF")]
	[Cpp2IlInjected.Address(RVA = "0x13C5904", Offset = "0x13C5904", VA = "0x13C5904")]
	private bool UpdateMoonLordIndex()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004000")]
	[Cpp2IlInjected.Address(RVA = "0x13C5BDC", Offset = "0x13C5BDC", VA = "0x13C5BDC", Slot = "9")]
	public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004001")]
	[Cpp2IlInjected.Address(RVA = "0x13C5D74", Offset = "0x13C5D74", VA = "0x13C5D74", Slot = "13")]
	public override float GetCloudAlpha()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6004002")]
	[Cpp2IlInjected.Address(RVA = "0x13C5D88", Offset = "0x13C5D88", VA = "0x13C5D88", Slot = "6")]
	public override void Activate(Vector2 position, params object[] args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004003")]
	[Cpp2IlInjected.Address(RVA = "0x13C5DB0", Offset = "0x13C5DB0", VA = "0x13C5DB0", Slot = "7")]
	public override void Deactivate(params object[] args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004004")]
	[Cpp2IlInjected.Address(RVA = "0x13C5DC8", Offset = "0x13C5DC8", VA = "0x13C5DC8", Slot = "11")]
	public override void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004005")]
	[Cpp2IlInjected.Address(RVA = "0x13C5DD8", Offset = "0x13C5DD8", VA = "0x13C5DD8", Slot = "10")]
	public override bool IsActive()
	{
		return default(bool);
	}
}
