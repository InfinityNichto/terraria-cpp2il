using System;
using Cpp2ILInjected;

namespace UnityEngine
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20000A2")]
	public enum HideFlags
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000354")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4000355")]
		HideInHierarchy = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4000356")]
		HideInInspector = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4000357")]
		DontSaveInEditor = 4,
		[global::Cpp2ILInjected.Token(Token = "0x4000358")]
		NotEditable = 8,
		[global::Cpp2ILInjected.Token(Token = "0x4000359")]
		DontSaveInBuild = 16,
		[global::Cpp2ILInjected.Token(Token = "0x400035A")]
		DontUnloadUnusedAsset = 32,
		[global::Cpp2ILInjected.Token(Token = "0x400035B")]
		DontSave = 52,
		[global::Cpp2ILInjected.Token(Token = "0x400035C")]
		HideAndDontSave = 61
	}
}
