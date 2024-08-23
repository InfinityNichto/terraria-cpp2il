using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000066 RID: 102
	[global::Cpp2ILInjected.Token(Token = "0x2000072")]
	public class TestInputManager : MonoBehaviour
	{
		// Token: 0x0600053E RID: 1342 RVA: 0x00002FE7 File Offset: 0x000011E7
		[global::Cpp2ILInjected.Token(Token = "0x6000556")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B8EF8", Offset = "0x19B8EF8", Length = "0x2EC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "set_targetFrameRate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(QualitySettings), Member = "set_vSyncCount", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "set_timeScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<LogMessage>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logger), Member = "add_OnLogMessage", MemberParameters = new object[] { typeof(Action<LogMessage>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "add_OnDeviceAttached", MemberParameters = new object[] { typeof(Action<InputDevice>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "add_OnDeviceDetached", MemberParameters = new object[] { typeof(Action<InputDevice>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "add_OnActiveDeviceChanged", MemberParameters = new object[] { typeof(Action<InputDevice>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<ulong, float>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "add_OnUpdate", MemberParameters = new object[] { typeof(Action<ulong, float>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		private void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00002FEA File Offset: 0x000011EA
		[global::Cpp2ILInjected.Token(Token = "0x6000557")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B91E4", Offset = "0x19B91E4", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TestInputManager), Member = "CheckForPauseButton", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_LeftTrigger", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "op_Implicit", MemberParameters = new object[] { typeof(OneAxisInputControl) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_RightTrigger", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void HandleInputUpdate(ulong updateTick, float deltaTime)
		{
			throw null;
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00002FED File Offset: 0x000011ED
		[global::Cpp2ILInjected.Token(Token = "0x6000558")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B93D8", Offset = "0x19B93D8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00002FF0 File Offset: 0x000011F0
		[global::Cpp2ILInjected.Token(Token = "0x6000559")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B93DC", Offset = "0x19B93DC", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetKeyDown", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "LoadScene", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "set_Enabled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00002FF3 File Offset: 0x000011F3
		[global::Cpp2ILInjected.Token(Token = "0x600055A")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B9310", Offset = "0x19B9310", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TestInputManager), Member = "HandleInputUpdate", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetKeyDown", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "set_timeScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void CheckForPauseButton()
		{
			throw null;
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00002FF6 File Offset: 0x000011F6
		[global::Cpp2ILInjected.Token(Token = "0x600055B")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B94DC", Offset = "0x19B94DC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "get_normal", ReturnType = typeof(GUIStyleState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyleState), Member = "set_textColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		private void SetColor(Color color)
		{
			throw null;
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00002FF9 File Offset: 0x000011F9
		[global::Cpp2ILInjected.Token(Token = "0x600055C")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B9528", Offset = "0x19B9528", Length = "0x1F2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUI), Member = "get_skin", ReturnType = typeof(GUISkin))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "set_font", MemberParameters = new object[] { typeof(Font) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "get_normal", ReturnType = typeof(GUIStyleState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyleState), Member = "set_textColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "get_ActiveDevice", ReturnType = typeof(InputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_Direction", ReturnType = typeof(TwoAxisInputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUI), Member = "Label", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(string),
			typeof(GUIStyle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_IsUnknown", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ulong), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "get_State", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "get_Value", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_Command", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_LeftStickX", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_LeftStickY", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TwoAxisInputControl), Member = "get_Angle", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_RightStickX", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_RightStickY", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_DPadX", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_DPadY", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_AnyButton", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "op_Implicit", MemberParameters = new object[] { typeof(OneAxisInputControl) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<LogMessage>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[]
		{
			typeof(char),
			typeof(StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 93)]
		private void OnGUI()
		{
			throw null;
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00002FFC File Offset: 0x000011FC
		[global::Cpp2ILInjected.Token(Token = "0x600055D")]
		[global::Cpp2ILInjected.Address(RVA = "0x19BB454", Offset = "0x19BB454", Length = "0x678")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "get_normal", ReturnType = typeof(GUIStyleState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyleState), Member = "set_textColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetJoystickNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUI), Member = "Label", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(string),
			typeof(GUIStyle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetKey", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetAxisRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
		private void DrawUnityInputDebugger()
		{
			throw null;
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00002FFF File Offset: 0x000011FF
		[global::Cpp2ILInjected.Token(Token = "0x600055E")]
		[global::Cpp2ILInjected.Address(RVA = "0x19BBACC", Offset = "0x19BBACC", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "get_ActiveDevice", ReturnType = typeof(InputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_Direction", ReturnType = typeof(TwoAxisInputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Gizmos), Member = "set_color", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Gizmos), Member = "DrawSphere", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Gizmos), Member = "DrawLine", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void OnDrawGizmos()
		{
			throw null;
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00003002 File Offset: 0x00001202
		[global::Cpp2ILInjected.Token(Token = "0x600055F")]
		[global::Cpp2ILInjected.Address(RVA = "0x19BBC6C", Offset = "0x19BBC6C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<LogMessage>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public TestInputManager()
		{
			throw null;
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00003005 File Offset: 0x00001205
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6000560")]
		[global::Cpp2ILInjected.Address(RVA = "0x19BBD14", Offset = "0x19BBD14", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void <OnEnable>b__4_0(LogMessage logMessage)
		{
			throw null;
		}

		// Token: 0x040003B1 RID: 945
		[global::Cpp2ILInjected.Token(Token = "0x4000401")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public Font font;

		// Token: 0x040003B2 RID: 946
		[global::Cpp2ILInjected.Token(Token = "0x4000402")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly GUIStyle style;

		// Token: 0x040003B3 RID: 947
		[global::Cpp2ILInjected.Token(Token = "0x4000403")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly List<LogMessage> logMessages;

		// Token: 0x040003B4 RID: 948
		[global::Cpp2ILInjected.Token(Token = "0x4000404")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool isPaused;

		// Token: 0x020001F6 RID: 502
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000073")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000868 RID: 2152 RVA: 0x00003965 File Offset: 0x00001B65
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6000561")]
			[global::Cpp2ILInjected.Address(RVA = "0x19BBDC4", Offset = "0x19BBDC4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06000869 RID: 2153 RVA: 0x00003968 File Offset: 0x00001B68
			[global::Cpp2ILInjected.Token(Token = "0x6000562")]
			[global::Cpp2ILInjected.Address(RVA = "0x19BBE20", Offset = "0x19BBE20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x0600086A RID: 2154 RVA: 0x0000396B File Offset: 0x00001B6B
			[global::Cpp2ILInjected.Token(Token = "0x6000563")]
			[global::Cpp2ILInjected.Address(RVA = "0x19BBE28", Offset = "0x19BBE28", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal void <OnEnable>b__4_1(InputDevice inputDevice)
			{
				throw null;
			}

			// Token: 0x0600086B RID: 2155 RVA: 0x0000396E File Offset: 0x00001B6E
			[global::Cpp2ILInjected.Token(Token = "0x6000564")]
			[global::Cpp2ILInjected.Address(RVA = "0x19BBEB4", Offset = "0x19BBEB4", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal void <OnEnable>b__4_2(InputDevice inputDevice)
			{
				throw null;
			}

			// Token: 0x0600086C RID: 2156 RVA: 0x00003971 File Offset: 0x00001B71
			[global::Cpp2ILInjected.Token(Token = "0x6000565")]
			[global::Cpp2ILInjected.Address(RVA = "0x19BBF40", Offset = "0x19BBF40", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal void <OnEnable>b__4_3(InputDevice inputDevice)
			{
				throw null;
			}

			// Token: 0x04000422 RID: 1058
			[global::Cpp2ILInjected.Token(Token = "0x4000405")]
			public static readonly TestInputManager.<>c <>9;

			// Token: 0x04000423 RID: 1059
			[global::Cpp2ILInjected.Token(Token = "0x4000406")]
			public static Action<InputDevice> <>9__4_1;

			// Token: 0x04000424 RID: 1060
			[global::Cpp2ILInjected.Token(Token = "0x4000407")]
			public static Action<InputDevice> <>9__4_2;

			// Token: 0x04000425 RID: 1061
			[global::Cpp2ILInjected.Token(Token = "0x4000408")]
			public static Action<InputDevice> <>9__4_3;
		}
	}
}
