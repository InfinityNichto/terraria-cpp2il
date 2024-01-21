using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using ReLogic.Content.Sources;

namespace ReLogic.Content;

[Cpp2IlInjected.Token(Token = "0x2000745")]
public class AssetRepository : IAssetRepository, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400735D")]
	private readonly Dictionary<string, IAsset> _assets;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400735E")]
	private IEnumerable<IContentSource> _sources;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400735F")]
	private readonly Dictionary<Type, Action<IAsset, AssetRequestMode>> _typeSpecificReloadActions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4007360")]
	private readonly AsyncAssetLoader _asyncLoader;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4007361")]
	private readonly IAssetLoader _loader;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4007362")]
	private List<IAsset> _queuedAssets;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4007363")]
	private readonly object _requestLock;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4007364")]
	private bool _isDisposed;

	[Cpp2IlInjected.Token(Token = "0x17000812")]
	public int PendingAssets
	{
		[Cpp2IlInjected.Token(Token = "0x600476C")]
		[Cpp2IlInjected.Address(RVA = "0x10BD6E8", Offset = "0x10BD6E8", VA = "0x10BD6E8", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000813")]
	public int TotalAssets
	{
		[Cpp2IlInjected.Token(Token = "0x600476D")]
		[Cpp2IlInjected.Address(RVA = "0x10BD734", Offset = "0x10BD734", VA = "0x10BD734", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600476E")]
		[Cpp2IlInjected.Address(RVA = "0x10BD73C", Offset = "0x10BD73C", VA = "0x10BD73C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000814")]
	public int LoadedAssets
	{
		[Cpp2IlInjected.Token(Token = "0x600476F")]
		[Cpp2IlInjected.Address(RVA = "0x10BD744", Offset = "0x10BD744", VA = "0x10BD744", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6004770")]
		[Cpp2IlInjected.Address(RVA = "0x10BD74C", Offset = "0x10BD74C", VA = "0x10BD74C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000815")]
	public bool IsAsyncLoadingEnabled
	{
		[Cpp2IlInjected.Token(Token = "0x6004771")]
		[Cpp2IlInjected.Address(RVA = "0x10BD754", Offset = "0x10BD754", VA = "0x10BD754")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004772")]
	[Cpp2IlInjected.Address(RVA = "0x10BD75C", Offset = "0x10BD75C", VA = "0x10BD75C")]
	public AssetRepository(IAssetLoader syncLoader, AsyncAssetLoader asyncLoader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004773")]
	[Cpp2IlInjected.Address(RVA = "0x10BD89C", Offset = "0x10BD89C", VA = "0x10BD89C")]
	internal AssetRepository(IAssetLoader syncLoader, AsyncAssetLoader asyncLoader, bool useAsync)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004774")]
	[Cpp2IlInjected.Address(RVA = "0x10BD9DC", Offset = "0x10BD9DC", VA = "0x10BD9DC", Slot = "10")]
	public void ProcessAsyncLoad()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004775")]
	[Cpp2IlInjected.Address(RVA = "0x10BDC1C", Offset = "0x10BDC1C", VA = "0x10BDC1C", Slot = "7")]
	public void SetSources(IEnumerable<IContentSource> sources, AssetRequestMode mode = AssetRequestMode.ImmediateLoad)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004776")]
	[Cpp2IlInjected.Address(RVA = "0x166B320", Offset = "0x166B320", VA = "0x166B320", Slot = "8")]
	public Asset<T> Request<T>(string assetName, AssetRequestMode mode = AssetRequestMode.ImmediateLoad) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004777")]
	[Cpp2IlInjected.Address(RVA = "0x10BE3FC", Offset = "0x10BE3FC", VA = "0x10BE3FC", Slot = "9")]
	public void TransferCompletedAssets()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004778")]
	[Cpp2IlInjected.Address(RVA = "0x10BDEC8", Offset = "0x10BDEC8", VA = "0x10BDEC8")]
	private void ReloadAssetsIfSourceChanged(AssetRequestMode mode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004779")]
	[Cpp2IlInjected.Address(RVA = "0x16074D4", Offset = "0x16074D4", VA = "0x16074D4")]
	private void LoadAsset<T>(Asset<T> asset, AssetRequestMode mode) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600477A")]
	[Cpp2IlInjected.Address(RVA = "0x1607548", Offset = "0x1607548", VA = "0x1607548")]
	private void TryLoadingAsset<T>(Asset<T> asset, AssetRequestMode mode) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600477B")]
	[Cpp2IlInjected.Address(RVA = "0x10BE580", Offset = "0x10BE580", VA = "0x10BE580")]
	private void ForceReloadAsset(IAsset asset, AssetRequestMode mode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600477C")]
	[Cpp2IlInjected.Address(RVA = "0x160734C", Offset = "0x160734C", VA = "0x160734C")]
	private void EnsureReloadActionExistsForType<T>() where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600477D")]
	[Cpp2IlInjected.Address(RVA = "0x1607438", Offset = "0x1607438", VA = "0x1607438")]
	private void ForceReloadAsset<T>(IAsset asset, AssetRequestMode mode) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600477E")]
	[Cpp2IlInjected.Address(RVA = "0x10BE488", Offset = "0x10BE488", VA = "0x10BE488")]
	private IContentSource FindSourceForAsset(string assetName)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600477F")]
	[Cpp2IlInjected.Address(RVA = "0x10BDD2C", Offset = "0x10BDD2C", VA = "0x10BDD2C")]
	private void ThrowIfDisposed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004780")]
	[Cpp2IlInjected.Address(RVA = "0x10BE62C", Offset = "0x10BE62C", VA = "0x10BE62C", Slot = "12")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004781")]
	[Cpp2IlInjected.Address(RVA = "0x10BE7E8", Offset = "0x10BE7E8", VA = "0x10BE7E8", Slot = "11")]
	public void Dispose()
	{
	}
}
