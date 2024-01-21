using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using ReLogic.Content.Sources;

namespace ReLogic.Content;

[Cpp2IlInjected.Token(Token = "0x200073C")]
public sealed class Asset<T> : IAsset, IDisposable where T : class
{
	[Cpp2IlInjected.Token(Token = "0x4007352")]
	public static readonly Asset<T> Empty;

	[Cpp2IlInjected.Token(Token = "0x1700080C")]
	public string Name
	{
		[Cpp2IlInjected.Token(Token = "0x6004743")]
		[Cpp2IlInjected.Address(RVA = "0x1976588", Offset = "0x1976588", VA = "0x1976588", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6004744")]
		[Cpp2IlInjected.Address(RVA = "0x1976590", Offset = "0x1976590", VA = "0x1976590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700080D")]
	public bool IsLoaded
	{
		[Cpp2IlInjected.Token(Token = "0x6004745")]
		[Cpp2IlInjected.Address(RVA = "0x1976598", Offset = "0x1976598", VA = "0x1976598", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700080E")]
	public AssetState State
	{
		[Cpp2IlInjected.Token(Token = "0x6004746")]
		[Cpp2IlInjected.Address(RVA = "0x19765C4", Offset = "0x19765C4", VA = "0x19765C4", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(AssetState);
		}
		[Cpp2IlInjected.Token(Token = "0x6004747")]
		[Cpp2IlInjected.Address(RVA = "0x19765CC", Offset = "0x19765CC", VA = "0x19765CC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700080F")]
	public bool IsDisposed
	{
		[Cpp2IlInjected.Token(Token = "0x6004748")]
		[Cpp2IlInjected.Address(RVA = "0x19765D4", Offset = "0x19765D4", VA = "0x19765D4", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6004749")]
		[Cpp2IlInjected.Address(RVA = "0x19765DC", Offset = "0x19765DC", VA = "0x19765DC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000810")]
	public IContentSource Source
	{
		[Cpp2IlInjected.Token(Token = "0x600474A")]
		[Cpp2IlInjected.Address(RVA = "0x19765E4", Offset = "0x19765E4", VA = "0x19765E4", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600474B")]
		[Cpp2IlInjected.Address(RVA = "0x19765EC", Offset = "0x19765EC", VA = "0x19765EC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000811")]
	public T Value
	{
		[Cpp2IlInjected.Token(Token = "0x600474C")]
		[Cpp2IlInjected.Address(RVA = "0x19765F4", Offset = "0x19765F4", VA = "0x19765F4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600474D")]
		[Cpp2IlInjected.Address(RVA = "0x19765FC", Offset = "0x19765FC", VA = "0x19765FC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600474E")]
	[Cpp2IlInjected.Address(RVA = "0x1976604", Offset = "0x1976604", VA = "0x1976604", Slot = "9")]
	public void ActionUnityLoad()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600474F")]
	[Cpp2IlInjected.Address(RVA = "0x19766D8", Offset = "0x19766D8", VA = "0x19766D8")]
	internal Asset(string name)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004750")]
	[Cpp2IlInjected.Address(RVA = "0x1976730", Offset = "0x1976730", VA = "0x1976730")]
	public static explicit operator T(Asset<T> asset)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004751")]
	[Cpp2IlInjected.Address(RVA = "0x197679C", Offset = "0x197679C", VA = "0x197679C")]
	internal void Unload()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004752")]
	[Cpp2IlInjected.Address(RVA = "0x19768DC", Offset = "0x19768DC", VA = "0x19768DC")]
	internal void SubmitLoadedContent(T value, IContentSource source)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004753")]
	[Cpp2IlInjected.Address(RVA = "0x1976A84", Offset = "0x1976A84", VA = "0x1976A84")]
	internal void SetToLoadingState()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004754")]
	[Cpp2IlInjected.Address(RVA = "0x1976A9C", Offset = "0x1976A9C", VA = "0x1976A9C")]
	private void Dispose(bool disposing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004755")]
	[Cpp2IlInjected.Address(RVA = "0x1976C2C", Offset = "0x1976C2C", VA = "0x1976C2C", Slot = "10")]
	public void Dispose()
	{
	}
}
