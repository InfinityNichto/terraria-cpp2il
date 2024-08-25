using System;
using Cpp2ILInjected;
using UnityEngine;

namespace InControl
{
	[global::Cpp2ILInjected.Token(Token = "0x200001B")]
	public delegate Vector2 DeadZoneFunc(float x, float y, float lowerDeadZone, float upperDeadZone);
}
