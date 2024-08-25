using System;
using Cpp2ILInjected;

namespace UnityEngine.Android
{
	[global::Cpp2ILInjected.Token(Token = "0x200000F")]
	public enum AndroidAssetPackStatus
	{
		[global::Cpp2ILInjected.Token(Token = "0x400001E")]
		Unknown,
		[global::Cpp2ILInjected.Token(Token = "0x400001F")]
		Pending,
		[global::Cpp2ILInjected.Token(Token = "0x4000020")]
		Downloading,
		[global::Cpp2ILInjected.Token(Token = "0x4000021")]
		Transferring,
		[global::Cpp2ILInjected.Token(Token = "0x4000022")]
		Completed,
		[global::Cpp2ILInjected.Token(Token = "0x4000023")]
		Failed,
		[global::Cpp2ILInjected.Token(Token = "0x4000024")]
		Canceled,
		[global::Cpp2ILInjected.Token(Token = "0x4000025")]
		WaitingForWifi,
		[global::Cpp2ILInjected.Token(Token = "0x4000026")]
		NotInstalled
	}
}
