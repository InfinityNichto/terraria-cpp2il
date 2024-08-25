using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[global::Cpp2ILInjected.Token(Token = "0x2000009")]
	internal class SendMouseEvents
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000031")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA174C", Offset = "0x1FA174C", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SendMouseEvents), Member = "DoSendMouseEvents", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static void UpdateMouse()
		{
			throw null;
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000032")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA1908", Offset = "0x1FA1908", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void SetMouseMoved()
		{
			throw null;
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000033")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA1964", Offset = "0x1FA1964", Length = "0x840")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SendMouseEvents), Member = "UpdateMouse", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_allCamerasCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "GetAllCameras", MemberParameters = new object[] { typeof(Camera[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_targetTexture", ReturnType = typeof(RenderTexture))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_targetDisplay", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Display), Member = "RelativeMouseAt", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Display), Member = "get_systemWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Display), Member = "get_systemHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_pixelRect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "Contains", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_eventMask", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "ScreenPointToRay", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Ray))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ray), Member = "get_direction", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_farClipPlane", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_nearClipPlane", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_cullingMask", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_clearFlags", ReturnType = typeof(CameraClearFlags))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SendMouseEvents), Member = "SendEvents", MemberParameters = new object[]
		{
			typeof(int),
			typeof(SendMouseEvents.HitInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		private static void DoSendMouseEvents(int skipRTCameras)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000034")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA21A4", Offset = "0x1FA21A4", Length = "0x390")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SendMouseEvents), Member = "DoSendMouseEvents", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SendMouseEvents.HitInfo), Member = "op_Implicit", MemberParameters = new object[] { typeof(SendMouseEvents.HitInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "SendMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(SendMessageOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SendMouseEvents.HitInfo), Member = "Compare", MemberParameters = new object[]
		{
			typeof(SendMouseEvents.HitInfo),
			typeof(SendMouseEvents.HitInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private static void SendEvents(int i, SendMouseEvents.HitInfo hit)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000035")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA269C", Offset = "0x1FA269C", Length = "0x10A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static SendMouseEvents()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000025")]
		private static bool s_MouseUsed;

		[global::Cpp2ILInjected.Token(Token = "0x4000026")]
		private static readonly SendMouseEvents.HitInfo[] m_LastHit;

		[global::Cpp2ILInjected.Token(Token = "0x4000027")]
		private static readonly SendMouseEvents.HitInfo[] m_MouseDownHit;

		[global::Cpp2ILInjected.Token(Token = "0x4000028")]
		private static readonly SendMouseEvents.HitInfo[] m_CurrentHit;

		[global::Cpp2ILInjected.Token(Token = "0x4000029")]
		private static Camera[] m_Cameras;

		[global::Cpp2ILInjected.Token(Token = "0x400002A")]
		public static Func<KeyValuePair<int, Vector2>> s_GetMouseState;

		[global::Cpp2ILInjected.Token(Token = "0x400002B")]
		private static Vector2 s_MousePosition;

		[global::Cpp2ILInjected.Token(Token = "0x400002C")]
		private static bool s_MouseButtonPressedThisFrame;

		[global::Cpp2ILInjected.Token(Token = "0x400002D")]
		private static bool s_MouseButtonIsPressed;

		[global::Cpp2ILInjected.Token(Token = "0x200000A")]
		private struct HitInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000036")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA25D4", Offset = "0x1FA25D4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "SendMessage", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object),
				typeof(SendMessageOptions)
			}, ReturnType = typeof(void))]
			public void SendMessage(string name)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000037")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA2534", Offset = "0x1FA2534", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SendMouseEvents), Member = "SendEvents", MemberParameters = new object[]
			{
				typeof(int),
				typeof(SendMouseEvents.HitInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public static implicit operator bool(SendMouseEvents.HitInfo exists)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000038")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA25E8", Offset = "0x1FA25E8", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SendMouseEvents), Member = "SendEvents", MemberParameters = new object[]
			{
				typeof(int),
				typeof(SendMouseEvents.HitInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public static bool Compare(SendMouseEvents.HitInfo lhs, SendMouseEvents.HitInfo rhs)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400002E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public GameObject target;

			[global::Cpp2ILInjected.Token(Token = "0x400002F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public Camera camera;
		}
	}
}
