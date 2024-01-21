using Cpp2IlInjected;

namespace ReLogic.Content;

[Cpp2IlInjected.Token(Token = "0x200074D")]
public delegate void LoadAssetDelegate<T>(bool loadedSuccessfully, T theAsset) where T : class;
