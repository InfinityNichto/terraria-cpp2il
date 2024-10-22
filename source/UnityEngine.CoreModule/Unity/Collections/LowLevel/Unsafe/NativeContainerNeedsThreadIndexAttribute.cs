﻿using System;
using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace Unity.Collections.LowLevel.Unsafe
{
	[RequiredByNativeCode]
	[Obsolete("Use NativeSetThreadIndexAttribute instead")]
	[AttributeUsage(AttributeTargets.Struct)]
	[global::Cpp2ILInjected.Token(Token = "0x2000028")]
	public sealed class NativeContainerNeedsThreadIndexAttribute : Attribute
	{
	}
}
