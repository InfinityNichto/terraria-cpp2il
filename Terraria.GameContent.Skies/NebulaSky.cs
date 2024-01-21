using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies;

[Cpp2IlInjected.Token(Token = "0x2000662")]
public class NebulaSky : CustomSky
{
	[Cpp2IlInjected.Token(Token = "0x2000A4E")]
	private struct LightPillar
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008DF2")]
		public Vector2 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008DF3")]
		public float Depth;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006CED")]
	private LightPillar[] _pillars;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006CEE")]
	private UnifiedRandom _random;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006CEF")]
	private Asset<Texture2D> _planetTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006CF0")]
	private Asset<Texture2D> _bgTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4006CF1")]
	private Asset<Texture2D> _beamTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4006CF2")]
	private Asset<Texture2D>[] _rockTextures;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4006CF3")]
	private bool _isActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4006CF4")]
	private float _fadeOpacity;

	[Cpp2IlInjected.Token(Token = "0x6004006")]
	[Cpp2IlInjected.Address(RVA = "0x13C5E0C", Offset = "0x13C5E0C", VA = "0x13C5E0C", Slot = "4")]
	public override void OnLoad()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004007")]
	[Cpp2IlInjected.Address(RVA = "0x13C626C", Offset = "0x13C626C", VA = "0x13C626C", Slot = "8")]
	public override void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004008")]
	[Cpp2IlInjected.Address(RVA = "0x13C6354", Offset = "0x13C6354", VA = "0x13C6354", Slot = "12")]
	public override Color OnTileColor(Color inColor)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6004009")]
	[Cpp2IlInjected.Address(RVA = "0x13C64A8", Offset = "0x13C64A8", VA = "0x13C64A8", Slot = "9")]
	public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600400A")]
	[Cpp2IlInjected.Address(RVA = "0x13C7274", Offset = "0x13C7274", VA = "0x13C7274", Slot = "13")]
	public override float GetCloudAlpha()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600400B")]
	[Cpp2IlInjected.Address(RVA = "0x13C729C", Offset = "0x13C729C", VA = "0x13C729C", Slot = "6")]
	public override void Activate(Vector2 position, params object[] args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600400C")]
	[Cpp2IlInjected.Address(RVA = "0x13C74FC", Offset = "0x13C74FC", VA = "0x13C74FC")]
	private int SortMethod(LightPillar pillar1, LightPillar pillar2)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600400D")]
	[Cpp2IlInjected.Address(RVA = "0x13C753C", Offset = "0x13C753C", VA = "0x13C753C", Slot = "7")]
	public override void Deactivate(params object[] args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600400E")]
	[Cpp2IlInjected.Address(RVA = "0x13C7548", Offset = "0x13C7548", VA = "0x13C7548", Slot = "11")]
	public override void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600400F")]
	[Cpp2IlInjected.Address(RVA = "0x13C7554", Offset = "0x13C7554", VA = "0x13C7554", Slot = "10")]
	public override bool IsActive()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004010")]
	[Cpp2IlInjected.Address(RVA = "0x13C7588", Offset = "0x13C7588", VA = "0x13C7588")]
	public NebulaSky()
	{
	}
}
