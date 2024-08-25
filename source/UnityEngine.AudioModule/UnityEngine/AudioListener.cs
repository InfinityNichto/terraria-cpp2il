using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[StaticAccessor("AudioListenerBindings", StaticAccessorType.DoubleColon)]
	[RequireComponent(typeof(Transform))]
	[global::Cpp2ILInjected.Token(Token = "0x2000009")]
	public sealed class AudioListener : AudioBehaviour
	{
	}
}
