using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Modules/Physics2D/Public/Rigidbody2D.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000004")]
	public sealed class Rigidbody2D : Component
	{
	}
}
