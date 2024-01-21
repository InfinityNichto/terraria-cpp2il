using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using ReLogic.Content.Sources;

namespace ReLogic.Content;

[Cpp2IlInjected.Token(Token = "0x200074B")]
public interface IAssetRepository : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700081D")]
	int PendingAssets
	{
		[Cpp2IlInjected.Token(Token = "0x600478F")]
		[Cpp2IlInjected.Address(RVA = "0xD83F800D", VA = "0xD83F800D", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700081E")]
	int TotalAssets
	{
		[Cpp2IlInjected.Token(Token = "0x6004790")]
		[Cpp2IlInjected.Address(RVA = "0x1D9A55BD", VA = "0x1D9A55BD", Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700081F")]
	int LoadedAssets
	{
		[Cpp2IlInjected.Token(Token = "0x6004791")]
		[Cpp2IlInjected.Address(RVA = "0x8FF5A17E", VA = "0x8FF5A17E", Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6004792")]
	[Cpp2IlInjected.Address(RVA = "0xB663ED41", VA = "0xB663ED41", Slot = "3")]
	void SetSources(IEnumerable<IContentSource> sources, AssetRequestMode mode = AssetRequestMode.ImmediateLoad);

	[Cpp2IlInjected.Token(Token = "0x6004793")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Asset<T> Request<T>(string assetName, AssetRequestMode mode = AssetRequestMode.ImmediateLoad) where T : class;

	[Cpp2IlInjected.Token(Token = "0x6004794")]
	[Cpp2IlInjected.Address(RVA = "0x9434B432", VA = "0x9434B432", Slot = "5")]
	void TransferCompletedAssets();

	[Cpp2IlInjected.Token(Token = "0x6004795")]
	[Cpp2IlInjected.Address(RVA = "0xAFE99AD0", VA = "0xAFE99AD0", Slot = "6")]
	void ProcessAsyncLoad();
}
