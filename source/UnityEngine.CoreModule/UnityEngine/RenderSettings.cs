using System;
using Cpp2ILInjected;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/Camera/RenderSettings.h")]
	[StaticAccessor("GetRenderSettings()", StaticAccessorType.Dot)]
	[NativeHeader("Runtime/Graphics/QualitySettingsTypes.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000057")]
	public sealed class RenderSettings : Object
	{
	}
}
