using System;
using Cpp2ILInjected;

namespace UnityEngine
{
	[global::Cpp2ILInjected.Token(Token = "0x2000009")]
	public interface ICanvasRaycastFilter
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000057")]
		bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera);
	}
}
