using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace ReLogic.Content;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x200073D")]
public class AssetLoadException : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6004757")]
	[Cpp2IlInjected.Address(RVA = "0x10BD2B0", Offset = "0x10BD2B0", VA = "0x10BD2B0")]
	private AssetLoadException(string text, Exception innerException)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004758")]
	[Cpp2IlInjected.Address(RVA = "0x10BD33C", Offset = "0x10BD33C", VA = "0x10BD33C")]
	public static AssetLoadException FromMissingAsset(string assetName, [Optional] Exception innerException)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004759")]
	[Cpp2IlInjected.Address(RVA = "0x166B218", Offset = "0x166B218", VA = "0x166B218")]
	public static AssetLoadException FromInvalidReader<TReaderType, TAssetType>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600475A")]
	[Cpp2IlInjected.Address(RVA = "0x10BD3CC", Offset = "0x10BD3CC", VA = "0x10BD3CC")]
	public static AssetLoadException FromMissingReader(string extension)
	{
		return null;
	}
}
