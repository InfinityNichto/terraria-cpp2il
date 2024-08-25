using System;
using Cpp2ILInjected;

namespace ReLogic.Content
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B4C")]
	public delegate void LoadAssetDelegate<T>(bool loadedSuccessfully, T theAsset) where T : class;
}
