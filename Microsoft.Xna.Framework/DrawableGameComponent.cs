using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000260")]
public class DrawableGameComponent : GameComponent, IDrawable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001C45")]
	private bool _isInitialized;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
	[Cpp2IlInjected.Token(Token = "0x4001C46")]
	private bool _isVisible;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001C47")]
	private int _drawOrder;

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	public int DrawOrder
	{
		[Cpp2IlInjected.Token(Token = "0x6001171")]
		[Cpp2IlInjected.Address(RVA = "0x13910B4", Offset = "0x13910B4", VA = "0x13910B4", Slot = "17")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001172")]
		[Cpp2IlInjected.Address(RVA = "0x13910BC", Offset = "0x13910BC", VA = "0x13910BC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	public bool Visible
	{
		[Cpp2IlInjected.Token(Token = "0x6001173")]
		[Cpp2IlInjected.Address(RVA = "0x139114C", Offset = "0x139114C", VA = "0x139114C", Slot = "18")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001174")]
		[Cpp2IlInjected.Address(RVA = "0x1390F70", Offset = "0x1390F70", VA = "0x1390F70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event EventHandler<EventArgs> DrawOrderChanged
	{
		[Cpp2IlInjected.Token(Token = "0x6001169")]
		[Cpp2IlInjected.Address(RVA = "0x1390C4C", Offset = "0x1390C4C", VA = "0x1390C4C", Slot = "19")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600116A")]
		[Cpp2IlInjected.Address(RVA = "0x1390CFC", Offset = "0x1390CFC", VA = "0x1390CFC", Slot = "20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event EventHandler<EventArgs> VisibleChanged
	{
		[Cpp2IlInjected.Token(Token = "0x600116B")]
		[Cpp2IlInjected.Address(RVA = "0x1390DAC", Offset = "0x1390DAC", VA = "0x1390DAC", Slot = "21")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600116C")]
		[Cpp2IlInjected.Address(RVA = "0x1390E5C", Offset = "0x1390E5C", VA = "0x1390E5C", Slot = "22")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600116D")]
	[Cpp2IlInjected.Address(RVA = "0x1390F0C", Offset = "0x1390F0C", VA = "0x1390F0C")]
	public DrawableGameComponent(Game game)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600116E")]
	[Cpp2IlInjected.Address(RVA = "0x1391088", Offset = "0x1391088", VA = "0x1391088", Slot = "13")]
	public override void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600116F")]
	[Cpp2IlInjected.Address(RVA = "0x13910AC", Offset = "0x13910AC", VA = "0x13910AC", Slot = "24")]
	protected virtual void LoadContent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001170")]
	[Cpp2IlInjected.Address(RVA = "0x13910B0", Offset = "0x13910B0", VA = "0x13910B0", Slot = "25")]
	protected virtual void UnloadContent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001175")]
	[Cpp2IlInjected.Address(RVA = "0x1391154", Offset = "0x1391154", VA = "0x1391154", Slot = "26")]
	public virtual void Draw(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001176")]
	[Cpp2IlInjected.Address(RVA = "0x1391158", Offset = "0x1391158", VA = "0x1391158", Slot = "27")]
	protected virtual void OnVisibleChanged(object sender, EventArgs args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001177")]
	[Cpp2IlInjected.Address(RVA = "0x139115C", Offset = "0x139115C", VA = "0x139115C", Slot = "28")]
	protected virtual void OnDrawOrderChanged(object sender, EventArgs args)
	{
	}
}
