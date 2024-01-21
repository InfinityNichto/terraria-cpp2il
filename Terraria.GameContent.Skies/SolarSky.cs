using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies;

[Cpp2IlInjected.Token(Token = "0x2000665")]
public class SolarSky : CustomSky
{
	[Cpp2IlInjected.Token(Token = "0x2000A50")]
	private struct Meteor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008DFE")]
		public Vector2 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008DFF")]
		public float Depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008E00")]
		public int FrameCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008E01")]
		public float Scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008E02")]
		public float StartX;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006CFF")]
	private UnifiedRandom _random;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006D00")]
	private Asset<Texture2D> _planetTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006D01")]
	private Asset<Texture2D> _bgTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006D02")]
	private Asset<Texture2D> _meteorTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4006D03")]
	private bool _isActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4006D04")]
	private Meteor[] _meteors;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4006D05")]
	private float _fadeOpacity;

	[Cpp2IlInjected.Token(Token = "0x6004022")]
	[Cpp2IlInjected.Address(RVA = "0x13CA31C", Offset = "0x13CA31C", VA = "0x13CA31C", Slot = "4")]
	public override void OnLoad()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004023")]
	[Cpp2IlInjected.Address(RVA = "0x13CA5D4", Offset = "0x13CA5D4", VA = "0x13CA5D4", Slot = "8")]
	public override void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004024")]
	[Cpp2IlInjected.Address(RVA = "0x13CA804", Offset = "0x13CA804", VA = "0x13CA804", Slot = "12")]
	public override Color OnTileColor(Color inColor)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6004025")]
	[Cpp2IlInjected.Address(RVA = "0x13CA958", Offset = "0x13CA958", VA = "0x13CA958", Slot = "9")]
	public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004026")]
	[Cpp2IlInjected.Address(RVA = "0x13CB538", Offset = "0x13CB538", VA = "0x13CB538", Slot = "13")]
	public override float GetCloudAlpha()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6004027")]
	[Cpp2IlInjected.Address(RVA = "0x13CB560", Offset = "0x13CB560", VA = "0x13CB560", Slot = "6")]
	public override void Activate(Vector2 position, params object[] args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004028")]
	[Cpp2IlInjected.Address(RVA = "0x13CB8D0", Offset = "0x13CB8D0", VA = "0x13CB8D0")]
	private int SortMethod(Meteor meteor1, Meteor meteor2)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6004029")]
	[Cpp2IlInjected.Address(RVA = "0x13CB914", Offset = "0x13CB914", VA = "0x13CB914", Slot = "7")]
	public override void Deactivate(params object[] args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600402A")]
	[Cpp2IlInjected.Address(RVA = "0x13CB920", Offset = "0x13CB920", VA = "0x13CB920", Slot = "11")]
	public override void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600402B")]
	[Cpp2IlInjected.Address(RVA = "0x13CB92C", Offset = "0x13CB92C", VA = "0x13CB92C", Slot = "10")]
	public override bool IsActive()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600402C")]
	[Cpp2IlInjected.Address(RVA = "0x13CB960", Offset = "0x13CB960", VA = "0x13CB960")]
	public SolarSky()
	{
	}
}
