using System;
using Cpp2IlInjected;
using ReLogic.Content.Sources;

namespace ReLogic.Content;

[Cpp2IlInjected.Token(Token = "0x200074C")]
public interface IAsyncAssetLoader : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000820")]
	bool IsRunning
	{
		[Cpp2IlInjected.Token(Token = "0x6004796")]
		[Cpp2IlInjected.Address(RVA = "0xC08111E6", VA = "0xC08111E6", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000821")]
	int Remaining
	{
		[Cpp2IlInjected.Token(Token = "0x6004797")]
		[Cpp2IlInjected.Address(RVA = "0xAFA4478D", VA = "0xAFA4478D", Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6004798")]
	[Cpp2IlInjected.Address(RVA = "0xF46D926F", VA = "0xF46D926F", Slot = "2")]
	void Start();

	[Cpp2IlInjected.Token(Token = "0x6004799")]
	[Cpp2IlInjected.Address(RVA = "0x183E55A3", VA = "0x183E55A3", Slot = "3")]
	void Stop();

	[Cpp2IlInjected.Token(Token = "0x600479A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void Load<T>(string assetName, IContentSource source, LoadAssetDelegate<T> callback) where T : class;

	[Cpp2IlInjected.Token(Token = "0x600479B")]
	[Cpp2IlInjected.Address(RVA = "0x7673831F", VA = "0x7673831F", Slot = "5")]
	void TransferCompleted();
}
