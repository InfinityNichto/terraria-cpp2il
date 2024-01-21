using System;
using Cpp2IlInjected;
using ReLogic.Content.Sources;

namespace ReLogic.Content;

[Cpp2IlInjected.Token(Token = "0x2000749")]
public interface IAsset : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000818")]
	AssetState State
	{
		[Cpp2IlInjected.Token(Token = "0x6004788")]
		[Cpp2IlInjected.Address(RVA = "0xB419EAC3", VA = "0xB419EAC3", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000819")]
	IContentSource Source
	{
		[Cpp2IlInjected.Token(Token = "0x6004789")]
		[Cpp2IlInjected.Address(RVA = "0xBB33C600", VA = "0xBB33C600", Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700081A")]
	string Name
	{
		[Cpp2IlInjected.Token(Token = "0x600478A")]
		[Cpp2IlInjected.Address(RVA = "0xC0AE7DF5", VA = "0xC0AE7DF5", Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700081B")]
	bool IsLoaded
	{
		[Cpp2IlInjected.Token(Token = "0x600478B")]
		[Cpp2IlInjected.Address(RVA = "0xCEEA61F3", VA = "0xCEEA61F3", Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700081C")]
	bool IsDisposed
	{
		[Cpp2IlInjected.Token(Token = "0x600478C")]
		[Cpp2IlInjected.Address(RVA = "0x3867767", VA = "0x3867767", Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600478D")]
	[Cpp2IlInjected.Address(RVA = "0xB9A16B2", VA = "0xB9A16B2", Slot = "5")]
	void ActionUnityLoad();
}
