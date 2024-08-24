using System;
using System.IO;
using Cpp2ILInjected;

namespace ReLogic.Content.Readers
{
	// Token: 0x02000750 RID: 1872
	[global::Cpp2ILInjected.Token(Token = "0x2000B52")]
	public interface IAssetReader
	{
		// Token: 0x0600479A RID: 18330
		[global::Cpp2ILInjected.Token(Token = "0x6005458")]
		T FromStream<T>(Stream stream) where T : class;
	}
}
