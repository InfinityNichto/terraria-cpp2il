using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200027B")]
public class GameComponent : IGameComponent, IUpdateable, IComparable<GameComponent>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001CEB")]
	private Game _game;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001CEC")]
	private int _updateOrder;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001CED")]
	private bool _enabled;

	[Cpp2IlInjected.Token(Token = "0x170001EF")]
	public Game Game
	{
		[Cpp2IlInjected.Token(Token = "0x60013A8")]
		[Cpp2IlInjected.Address(RVA = "0x1393654", Offset = "0x1393654", VA = "0x1393654")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001F0")]
	public GraphicsDevice GraphicsDevice
	{
		[Cpp2IlInjected.Token(Token = "0x60013AB")]
		[Cpp2IlInjected.Address(RVA = "0x1393664", Offset = "0x1393664", VA = "0x1393664")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001F1")]
	public bool Enabled
	{
		[Cpp2IlInjected.Token(Token = "0x60013AC")]
		[Cpp2IlInjected.Address(RVA = "0x139366C", Offset = "0x139366C", VA = "0x139366C", Slot = "10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60013AD")]
		[Cpp2IlInjected.Address(RVA = "0x13935A4", Offset = "0x13935A4", VA = "0x13935A4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001F2")]
	public int UpdateOrder
	{
		[Cpp2IlInjected.Token(Token = "0x60013AE")]
		[Cpp2IlInjected.Address(RVA = "0x13936EC", Offset = "0x13936EC", VA = "0x13936EC", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60013AF")]
		[Cpp2IlInjected.Address(RVA = "0x13936F4", Offset = "0x13936F4", VA = "0x13936F4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event EventHandler<EventArgs> UpdateOrderChanged
	{
		[Cpp2IlInjected.Token(Token = "0x60013A3")]
		[Cpp2IlInjected.Address(RVA = "0x13932E4", Offset = "0x13932E4", VA = "0x13932E4", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60013A4")]
		[Cpp2IlInjected.Address(RVA = "0x1393394", Offset = "0x1393394", VA = "0x1393394", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event EventHandler<EventArgs> EnabledChanged
	{
		[Cpp2IlInjected.Token(Token = "0x60013A5")]
		[Cpp2IlInjected.Address(RVA = "0x1393444", Offset = "0x1393444", VA = "0x1393444", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60013A6")]
		[Cpp2IlInjected.Address(RVA = "0x13934F4", Offset = "0x13934F4", VA = "0x13934F4", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60013A7")]
	[Cpp2IlInjected.Address(RVA = "0x1390F44", Offset = "0x1390F44", VA = "0x1390F44")]
	public GameComponent(Game game)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60013A9")]
	[Cpp2IlInjected.Address(RVA = "0x139365C", Offset = "0x139365C", VA = "0x139365C", Slot = "13")]
	public virtual void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60013AA")]
	[Cpp2IlInjected.Address(RVA = "0x1393660", Offset = "0x1393660", VA = "0x1393660", Slot = "14")]
	public virtual void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60013B0")]
	[Cpp2IlInjected.Address(RVA = "0x1393674", Offset = "0x1393674", VA = "0x1393674")]
	private void Raise(EventHandler<EventArgs> handler, EventArgs e)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60013B1")]
	[Cpp2IlInjected.Address(RVA = "0x13937A4", Offset = "0x13937A4", VA = "0x13937A4", Slot = "15")]
	protected virtual void OnUpdateOrderChanged(object sender, EventArgs args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60013B2")]
	[Cpp2IlInjected.Address(RVA = "0x13937A8", Offset = "0x13937A8", VA = "0x13937A8", Slot = "16")]
	protected virtual void OnEnabledChanged(object sender, EventArgs args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60013B3")]
	[Cpp2IlInjected.Address(RVA = "0x13937AC", Offset = "0x13937AC", VA = "0x13937AC")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60013B4")]
	[Cpp2IlInjected.Address(RVA = "0x13937B0", Offset = "0x13937B0", VA = "0x13937B0", Slot = "12")]
	public int CompareTo(GameComponent other)
	{
		return default(int);
	}
}
