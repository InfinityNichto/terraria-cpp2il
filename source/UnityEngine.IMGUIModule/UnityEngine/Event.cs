using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000B RID: 11
	[StaticAccessor("GUIEvent", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/IMGUI/Event.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200000C")]
	[StructLayout(0)]
	public sealed class Event
	{
		// Token: 0x06000034 RID: 52 RVA: 0x000020D4 File Offset: 0x000002D4
		[global::Cpp2ILInjected.Token(Token = "0x6000036")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F98598", Offset = "0x1F98598", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Event()
		{
			throw null;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000020D7 File Offset: 0x000002D7
		[global::Cpp2ILInjected.Token(Token = "0x6000037")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F98620", Offset = "0x1F98620", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Event), Member = "Internal_MakeMasterEventCurrent", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Event(int displayIndex)
		{
			throw null;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000020DA File Offset: 0x000002DA
		[global::Cpp2ILInjected.Token(Token = "0x6000038")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F98670", Offset = "0x1F98670", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000037 RID: 55 RVA: 0x000020DD File Offset: 0x000002DD
		[global::Cpp2ILInjected.Token(Token = "0x1700000D")]
		public bool shift
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000039")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F972BC", Offset = "0x1F972BC", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000020E0 File Offset: 0x000002E0
		[global::Cpp2ILInjected.Token(Token = "0x1700000E")]
		public bool control
		{
			[global::Cpp2ILInjected.Token(Token = "0x600003A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F97344", Offset = "0x1F97344", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000020E3 File Offset: 0x000002E3
		[global::Cpp2ILInjected.Token(Token = "0x1700000F")]
		public bool alt
		{
			[global::Cpp2ILInjected.Token(Token = "0x600003B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F97278", Offset = "0x1F97278", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000020E6 File Offset: 0x000002E6
		[global::Cpp2ILInjected.Token(Token = "0x17000010")]
		public bool command
		{
			[global::Cpp2ILInjected.Token(Token = "0x600003C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F97300", Offset = "0x1F97300", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003B RID: 59 RVA: 0x000020E9 File Offset: 0x000002E9
		[global::Cpp2ILInjected.Token(Token = "0x17000011")]
		public static Event current
		{
			[global::Cpp2ILInjected.Token(Token = "0x600003D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F96EE8", Offset = "0x1F96EE8", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutUtility), Member = "BeginLayoutArea", MemberParameters = new object[]
			{
				typeof(GUIStyle),
				typeof(Type)
			}, ReturnType = typeof(GUILayoutGroup))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutGroup), Member = "GetNext", ReturnType = typeof(GUILayoutEntry))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000020EC File Offset: 0x000002EC
		[global::Cpp2ILInjected.Token(Token = "0x17000012")]
		public bool isKey
		{
			[global::Cpp2ILInjected.Token(Token = "0x600003E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F98808", Offset = "0x1F98808", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003D RID: 61 RVA: 0x000020EF File Offset: 0x000002EF
		[global::Cpp2ILInjected.Token(Token = "0x17000013")]
		public bool isMouse
		{
			[global::Cpp2ILInjected.Token(Token = "0x600003F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F98854", Offset = "0x1F98854", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Event), Member = "GetHashCode", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Event), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Event), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000020F2 File Offset: 0x000002F2
		[global::Cpp2ILInjected.Token(Token = "0x17000014")]
		internal bool isDirectManipulationDevice
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000040")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F988B8", Offset = "0x1F988B8", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIUtility), Member = "HitTest", MemberParameters = new object[]
			{
				typeof(Rect),
				typeof(Event)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000020F5 File Offset: 0x000002F5
		[global::Cpp2ILInjected.Token(Token = "0x6000041")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F98970", Offset = "0x1F98970", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Event), Member = "get_isMouse", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Event), Member = "get_mousePosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000020F8 File Offset: 0x000002F8
		[global::Cpp2ILInjected.Token(Token = "0x6000042")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F98A70", Offset = "0x1F98A70", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Event), Member = "get_isMouse", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Event), Member = "get_mousePosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000020FB File Offset: 0x000002FB
		[global::Cpp2ILInjected.Token(Token = "0x6000043")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F98CA4", Offset = "0x1F98CA4", Length = "0x790")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Event), Member = "get_isMouse", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Event), Member = "get_mousePosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 59)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000020FE File Offset: 0x000002FE
		[global::Cpp2ILInjected.Token(Token = "0x6000044")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F970C8", Offset = "0x1F970C8", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUI), Member = "DoControl", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(GUIContent),
			typeof(GUIStyle)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public void Use()
		{
			throw null;
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000043 RID: 67
		[NativeProperty("type", false, TargetType.Field)]
		[global::Cpp2ILInjected.Token(Token = "0x17000015")]
		public extern EventType rawType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000045")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F994E8", Offset = "0x1F994E8", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "OnUpdateSelected", MemberParameters = new object[] { "UnityEngine.EventSystems.BaseEventData" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutGroup), Member = "GetNext", ReturnType = typeof(GUILayoutEntry))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00002101 File Offset: 0x00000301
		[NativeProperty("mousePosition", false, TargetType.Field)]
		[global::Cpp2ILInjected.Token(Token = "0x17000016")]
		public Vector2 mousePosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000046")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9748C", Offset = "0x1F9748C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUI), Member = "DoLabel", MemberParameters = new object[]
			{
				typeof(Rect),
				typeof(GUIContent),
				typeof(GUIStyle)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUI), Member = "DoButton", MemberParameters = new object[]
			{
				typeof(Rect),
				typeof(int),
				typeof(GUIContent),
				typeof(GUIStyle)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUI), Member = "BeginGroup", MemberParameters = new object[]
			{
				typeof(Rect),
				typeof(GUIContent),
				typeof(GUIStyle),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Event), Member = "GetHashCode", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Event), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Event), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIUtility), Member = "HitTest", MemberParameters = new object[]
			{
				typeof(Rect),
				typeof(Event)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000045 RID: 69
		[NativeProperty("pointerType", false, TargetType.Field)]
		[global::Cpp2ILInjected.Token(Token = "0x17000017")]
		public extern PointerType pointerType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000047")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F98934", Offset = "0x1F98934", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000046 RID: 70
		[NativeProperty("modifiers", false, TargetType.Field)]
		[global::Cpp2ILInjected.Token(Token = "0x17000018")]
		public extern EventModifiers modifiers
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000048")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F987CC", Offset = "0x1F987CC", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "KeyPressed", MemberParameters = new object[] { typeof(Event) }, ReturnType = "UnityEngine.UI.InputField.EditState")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "OnUpdateSelected", MemberParameters = new object[] { "UnityEngine.EventSystems.BaseEventData" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000047 RID: 71
		[NativeProperty("character", false, TargetType.Field)]
		[global::Cpp2ILInjected.Token(Token = "0x17000019")]
		public extern char character
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000049")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F99434", Offset = "0x1F99434", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "KeyPressed", MemberParameters = new object[] { typeof(Event) }, ReturnType = "UnityEngine.UI.InputField.EditState")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "OnUpdateSelected", MemberParameters = new object[] { "UnityEngine.EventSystems.BaseEventData" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000048 RID: 72
		[NativeProperty("keycode", false, TargetType.Field)]
		[global::Cpp2ILInjected.Token(Token = "0x1700001A")]
		public extern KeyCode keyCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600004A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F97388", Offset = "0x1F97388", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "KeyPressed", MemberParameters = new object[] { typeof(Event) }, ReturnType = "UnityEngine.UI.InputField.EditState")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x1700001B RID: 27
		// (set) Token: 0x06000049 RID: 73
		[NativeProperty("displayIndex", false, TargetType.Field)]
		[global::Cpp2ILInjected.Token(Token = "0x1700001B")]
		public extern int displayIndex
		{
			[global::Cpp2ILInjected.Token(Token = "0x600004B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F99568", Offset = "0x1F99568", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600004A RID: 74
		[global::Cpp2ILInjected.Token(Token = "0x1700001C")]
		public extern EventType type
		{
			[FreeFunction("GUIEvent::GetType", HasExplicitThis = true)]
			[global::Cpp2ILInjected.Token(Token = "0x600004C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F96F30", Offset = "0x1F96F30", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "OnUpdateSelected", MemberParameters = new object[] { "UnityEngine.EventSystems.BaseEventData" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutUtility), Member = "BeginLayoutArea", MemberParameters = new object[]
			{
				typeof(GUIStyle),
				typeof(Type)
			}, ReturnType = typeof(GUILayoutGroup))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600004B RID: 75
		[global::Cpp2ILInjected.Token(Token = "0x1700001D")]
		public extern string commandName
		{
			[FreeFunction("GUIEvent::GetCommandName", HasExplicitThis = true)]
			[global::Cpp2ILInjected.Token(Token = "0x600004D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F99470", Offset = "0x1F99470", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "OnUpdateSelected", MemberParameters = new object[] { "UnityEngine.EventSystems.BaseEventData" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x0600004C RID: 76
		[NativeMethod("Use")]
		[global::Cpp2ILInjected.Token(Token = "0x600004E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F994AC", Offset = "0x1F994AC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void Internal_Use();

		// Token: 0x0600004D RID: 77
		[FreeFunction("GUIEvent::Internal_Create", IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x600004F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F985E4", Offset = "0x1F985E4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern IntPtr Internal_Create(int displayIndex);

		// Token: 0x0600004E RID: 78
		[FreeFunction("GUIEvent::Internal_Destroy", IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000050")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F98790", Offset = "0x1F98790", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void Internal_Destroy(IntPtr ptr);

		// Token: 0x0600004F RID: 79
		[global::Cpp2ILInjected.Token(Token = "0x6000051")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F995AC", Offset = "0x1F995AC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "OnUpdateSelected", MemberParameters = new object[] { "UnityEngine.EventSystems.BaseEventData" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern bool PopEvent([NotNull("ArgumentNullException")] Event outEvent);

		// Token: 0x06000050 RID: 80
		[global::Cpp2ILInjected.Token(Token = "0x6000052")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F995E8", Offset = "0x1F995E8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void Internal_SetNativeEvent(IntPtr ptr);

		// Token: 0x06000051 RID: 81 RVA: 0x00002104 File Offset: 0x00000304
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000053")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F99624", Offset = "0x1F99624", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Event), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static void Internal_MakeMasterEventCurrent(int displayIndex)
		{
			throw null;
		}

		// Token: 0x06000052 RID: 82
		[global::Cpp2ILInjected.Token(Token = "0x6000054")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F99524", Offset = "0x1F99524", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void get_mousePosition_Injected(out Vector2 ret);

		// Token: 0x04000054 RID: 84
		[global::Cpp2ILInjected.Token(Token = "0x4000054")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		[NonSerialized]
		internal IntPtr m_Ptr;

		// Token: 0x04000055 RID: 85
		[global::Cpp2ILInjected.Token(Token = "0x4000055")]
		private static Event s_Current;

		// Token: 0x04000056 RID: 86
		[global::Cpp2ILInjected.Token(Token = "0x4000056")]
		private static Event s_MasterEvent;
	}
}
