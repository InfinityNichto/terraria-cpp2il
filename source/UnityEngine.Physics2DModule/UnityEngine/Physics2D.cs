﻿using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[StaticAccessor("GetPhysicsManager2D()", StaticAccessorType.Arrow)]
	[NativeHeader("Modules/Physics2D/PhysicsManager2D.h")]
	[NativeHeader("Physics2DScriptingClasses.h")]
	[NativeHeader("Physics2DScriptingClasses.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000002")]
	public class Physics2D
	{
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000001")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA3740", Offset = "0x1FA3740", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static Physics2D()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000001")]
		private static List<Rigidbody2D> m_LastDisabledRigidbody2D;
	}
}
