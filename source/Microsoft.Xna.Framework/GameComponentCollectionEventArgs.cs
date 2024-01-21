using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200027D")]
public class GameComponentCollectionEventArgs : EventArgs
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001CF2")]
	private IGameComponent _gameComponent;

	[Cpp2IlInjected.Token(Token = "0x170001F3")]
	public IGameComponent GameComponent
	{
		[Cpp2IlInjected.Token(Token = "0x60013C1")]
		[Cpp2IlInjected.Address(RVA = "0x1393F24", Offset = "0x1393F24", VA = "0x1393F24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60013C0")]
	[Cpp2IlInjected.Address(RVA = "0x1393B6C", Offset = "0x1393B6C", VA = "0x1393B6C")]
	public GameComponentCollectionEventArgs(IGameComponent gameComponent)
	{
	}
}
