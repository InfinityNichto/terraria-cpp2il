using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/Export/Input/Cursor.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000043")]
	public class Cursor
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000014")]
		public static extern CursorLockMode lockState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000091")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6CDF8", Offset = "0x1F6CDF8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.PointerInputModule", Member = "GetMousePointerEventData", MemberParameters = new object[] { typeof(int) }, ReturnType = "UnityEngine.EventSystems.PointerInputModule.MouseState")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.PointerInputModule", Member = "ProcessMove", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.PointerInputModule", Member = "ProcessDrag", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}
	}
}
