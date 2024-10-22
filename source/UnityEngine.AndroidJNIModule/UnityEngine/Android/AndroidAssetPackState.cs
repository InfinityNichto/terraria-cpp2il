﻿using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Android
{
	[global::Cpp2ILInjected.Token(Token = "0x2000012")]
	public class AndroidAssetPackState
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000181")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6595C", Offset = "0x1F6595C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal AndroidAssetPackState(string name, AndroidAssetPackStatus status, AndroidAssetPackError error)
		{
			throw null;
		}

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400003B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <name>k__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400003C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly AndroidAssetPackStatus <status>k__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400003D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private readonly AndroidAssetPackError <error>k__BackingField;
	}
}
