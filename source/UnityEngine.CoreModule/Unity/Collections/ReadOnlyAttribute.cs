using System;
using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace Unity.Collections
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x2000018")]
	public sealed class ReadOnlyAttribute : Attribute
	{
	}
}
