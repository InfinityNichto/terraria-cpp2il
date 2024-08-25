using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequiredByNativeCode]
	[NativeHeader("Modules/Physics/Collider.h")]
	[RequireComponent(typeof(Transform))]
	[global::Cpp2ILInjected.Token(Token = "0x2000004")]
	public class Collider : Component
	{
	}
}
