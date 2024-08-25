using System;
using Cpp2ILInjected;

namespace UnityEngine.Android
{
	[global::Cpp2ILInjected.Token(Token = "0x2000010")]
	public enum AndroidAssetPackError
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000028")]
		NoError,
		[global::Cpp2ILInjected.Token(Token = "0x4000029")]
		AppUnavailable = -1,
		[global::Cpp2ILInjected.Token(Token = "0x400002A")]
		PackUnavailable = -2,
		[global::Cpp2ILInjected.Token(Token = "0x400002B")]
		InvalidRequest = -3,
		[global::Cpp2ILInjected.Token(Token = "0x400002C")]
		DownloadNotFound = -4,
		[global::Cpp2ILInjected.Token(Token = "0x400002D")]
		ApiNotAvailable = -5,
		[global::Cpp2ILInjected.Token(Token = "0x400002E")]
		NetworkError = -6,
		[global::Cpp2ILInjected.Token(Token = "0x400002F")]
		AccessDenied = -7,
		[global::Cpp2ILInjected.Token(Token = "0x4000030")]
		InsufficientStorage = -10,
		[global::Cpp2ILInjected.Token(Token = "0x4000031")]
		PlayStoreNotFound = -11,
		[global::Cpp2ILInjected.Token(Token = "0x4000032")]
		NetworkUnrestricted = -12,
		[global::Cpp2ILInjected.Token(Token = "0x4000033")]
		AppNotOwned = -13,
		[global::Cpp2ILInjected.Token(Token = "0x4000034")]
		InternalError = -100
	}
}
