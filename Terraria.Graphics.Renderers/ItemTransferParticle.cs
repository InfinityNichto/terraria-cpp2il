using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers;

[Cpp2IlInjected.Token(Token = "0x20004FB")]
public class ItemTransferParticle : IPooledParticle, IParticle
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006791")]
	public Vector2 StartPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006792")]
	public Vector2 EndPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006793")]
	public Vector2 BezierHelper1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4006794")]
	public Vector2 BezierHelper2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4006795")]
	private Item _itemInstance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4006796")]
	private int _lifeTimeCounted;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4006797")]
	private int _lifeTimeTotal;

	[Cpp2IlInjected.Token(Token = "0x170006EE")]
	public bool ShouldBeRemovedFromRenderer
	{
		[Cpp2IlInjected.Token(Token = "0x600378A")]
		[Cpp2IlInjected.Address(RVA = "0x123E860", Offset = "0x123E860", VA = "0x123E860", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600378B")]
		[Cpp2IlInjected.Address(RVA = "0x123E868", Offset = "0x123E868", VA = "0x123E868")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170006EF")]
	public bool IsRestingInPool
	{
		[Cpp2IlInjected.Token(Token = "0x6003790")]
		[Cpp2IlInjected.Address(RVA = "0x123F050", Offset = "0x123F050", VA = "0x123F050", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6003791")]
		[Cpp2IlInjected.Address(RVA = "0x123F058", Offset = "0x123F058", VA = "0x123F058")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600378C")]
	[Cpp2IlInjected.Address(RVA = "0x123E870", Offset = "0x123E870", VA = "0x123E870")]
	public ItemTransferParticle()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600378D")]
	[Cpp2IlInjected.Address(RVA = "0x123E8E4", Offset = "0x123E8E4", VA = "0x123E8E4", Slot = "8")]
	public void Update(ref ParticleRendererSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600378E")]
	[Cpp2IlInjected.Address(RVA = "0x123E904", Offset = "0x123E904", VA = "0x123E904")]
	public void Prepare(int itemType, int lifeTimeTotal, Vector2 playerPosition, Vector2 chestPosition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600378F")]
	[Cpp2IlInjected.Address(RVA = "0x123ED30", Offset = "0x123ED30", VA = "0x123ED30", Slot = "9")]
	public void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003792")]
	[Cpp2IlInjected.Address(RVA = "0x123F060", Offset = "0x123F060", VA = "0x123F060", Slot = "5")]
	public void RestInPool()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003793")]
	[Cpp2IlInjected.Address(RVA = "0x123F06C", Offset = "0x123F06C", VA = "0x123F06C", Slot = "10")]
	public virtual void FetchFromPool()
	{
	}
}
