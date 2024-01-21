using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200027C")]
public sealed class GameComponentCollection : Collection<IGameComponent>
{
	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event EventHandler<GameComponentCollectionEventArgs> ComponentAdded
	{
		[Cpp2IlInjected.Token(Token = "0x60013B5")]
		[Cpp2IlInjected.Address(RVA = "0x13937C0", Offset = "0x13937C0", VA = "0x13937C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60013B6")]
		[Cpp2IlInjected.Address(RVA = "0x1393870", Offset = "0x1393870", VA = "0x1393870")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event EventHandler<GameComponentCollectionEventArgs> ComponentRemoved
	{
		[Cpp2IlInjected.Token(Token = "0x60013B7")]
		[Cpp2IlInjected.Address(RVA = "0x1393920", Offset = "0x1393920", VA = "0x1393920")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60013B8")]
		[Cpp2IlInjected.Address(RVA = "0x13939D0", Offset = "0x13939D0", VA = "0x13939D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60013B9")]
	[Cpp2IlInjected.Address(RVA = "0x1393A80", Offset = "0x1393A80", VA = "0x1393A80", Slot = "34")]
	protected override void ClearItems()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60013BA")]
	[Cpp2IlInjected.Address(RVA = "0x1393C64", Offset = "0x1393C64", VA = "0x1393C64", Slot = "35")]
	protected override void InsertItem(int index, IGameComponent item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60013BB")]
	[Cpp2IlInjected.Address(RVA = "0x1393D7C", Offset = "0x1393D7C", VA = "0x1393D7C")]
	private void OnComponentAdded(GameComponentCollectionEventArgs eventArgs)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60013BC")]
	[Cpp2IlInjected.Address(RVA = "0x1393BF0", Offset = "0x1393BF0", VA = "0x1393BF0")]
	private void OnComponentRemoved(GameComponentCollectionEventArgs eventArgs)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60013BD")]
	[Cpp2IlInjected.Address(RVA = "0x1393DF0", Offset = "0x1393DF0", VA = "0x1393DF0", Slot = "36")]
	protected override void RemoveItem(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60013BE")]
	[Cpp2IlInjected.Address(RVA = "0x1393EAC", Offset = "0x1393EAC", VA = "0x1393EAC", Slot = "37")]
	protected override void SetItem(int index, IGameComponent item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60013BF")]
	[Cpp2IlInjected.Address(RVA = "0x139153C", Offset = "0x139153C", VA = "0x139153C")]
	public GameComponentCollection()
	{
	}
}
