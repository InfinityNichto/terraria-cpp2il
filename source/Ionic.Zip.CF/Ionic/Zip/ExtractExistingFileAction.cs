using System;
using Cpp2ILInjected;

namespace Ionic.Zip
{
	[global::Cpp2ILInjected.Token(Token = "0x2000015")]
	public enum ExtractExistingFileAction
	{
		[global::Cpp2ILInjected.Token(Token = "0x400002A")]
		Throw,
		[global::Cpp2ILInjected.Token(Token = "0x400002B")]
		OverwriteSilently,
		[global::Cpp2ILInjected.Token(Token = "0x400002C")]
		DoNotOverwrite,
		[global::Cpp2ILInjected.Token(Token = "0x400002D")]
		InvokeExtractProgressEvent
	}
}
