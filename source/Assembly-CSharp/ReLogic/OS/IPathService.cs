using System;
using Cpp2ILInjected;

namespace ReLogic.OS
{
	// Token: 0x02000722 RID: 1826
	[global::Cpp2ILInjected.Token(Token = "0x2000B20")]
	public interface IPathService
	{
		// Token: 0x06004693 RID: 18067
		[global::Cpp2ILInjected.Token(Token = "0x6005346")]
		string GetStoragePath();

		// Token: 0x06004694 RID: 18068
		[global::Cpp2ILInjected.Token(Token = "0x6005347")]
		string GetStoragePath(string subfolder);

		// Token: 0x06004695 RID: 18069
		[global::Cpp2ILInjected.Token(Token = "0x6005348")]
		string ExpandPathVariables(string path);
	}
}
