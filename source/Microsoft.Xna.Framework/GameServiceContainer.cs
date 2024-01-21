using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000276")]
public class GameServiceContainer : IServiceProvider
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001CDB")]
	private Dictionary<Type, object> services;

	[Cpp2IlInjected.Token(Token = "0x600136D")]
	[Cpp2IlInjected.Address(RVA = "0x13914B8", Offset = "0x13914B8", VA = "0x13914B8")]
	public GameServiceContainer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600136E")]
	[Cpp2IlInjected.Address(RVA = "0x1393F2C", Offset = "0x1393F2C", VA = "0x1393F2C")]
	public void AddService(Type type, object provider)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600136F")]
	[Cpp2IlInjected.Address(RVA = "0x1393F98", Offset = "0x1393F98", VA = "0x1393F98", Slot = "4")]
	public object GetService(Type type)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001370")]
	[Cpp2IlInjected.Address(RVA = "0x139401C", Offset = "0x139401C", VA = "0x139401C")]
	public void RemoveService(Type type)
	{
	}
}
