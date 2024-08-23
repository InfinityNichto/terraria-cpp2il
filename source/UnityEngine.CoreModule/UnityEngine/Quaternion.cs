using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000BE RID: 190
	[NativeHeader("Runtime/Math/MathScripting.h")]
	[DefaultMember("Item")]
	[NativeType(Header = "Runtime/Math/Quaternion.h")]
	[Il2CppEagerStaticClassConstruction]
	[UsedByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x20000D0")]
	public struct Quaternion : IEquatable<Quaternion>, IFormattable
	{
		// Token: 0x060003FD RID: 1021 RVA: 0x000028E7 File Offset: 0x00000AE7
		[FreeFunction(IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000411")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82238", Offset = "0x1F82238", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Selectable", Member = "FindSelectable", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = "UnityEngine.UI.Selectable")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static Quaternion Inverse(Quaternion rotation)
		{
			throw null;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x000028EA File Offset: 0x00000AEA
		[FreeFunction("EulerToQuaternion", IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000412")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F822D0", Offset = "0x1F822D0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.QuaternionConverter", Member = "ReadJson", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonReader",
			typeof(Type),
			typeof(object),
			"Newtonsoft.Json.JsonSerializer"
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Quaternion), Member = "set_eulerAngles", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static Quaternion Internal_FromEulerRad(Vector3 euler)
		{
			throw null;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x000028ED File Offset: 0x00000AED
		[FreeFunction("QuaternionScripting::ToEuler", IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000413")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82368", Offset = "0x1F82368", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.QuaternionConverter", Member = "WriteJson", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonWriter",
			typeof(object),
			"Newtonsoft.Json.JsonSerializer"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Quaternion), Member = "get_eulerAngles", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static Vector3 Internal_ToEulerRad(Quaternion rotation)
		{
			throw null;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x000028F0 File Offset: 0x00000AF0
		[FreeFunction("QuaternionScripting::AngleAxis", IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000414")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82404", Offset = "0x1F82404", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchControl", Member = "SnapTo", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static Quaternion AngleAxis(float angle, Vector3 axis)
		{
			throw null;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x000028F3 File Offset: 0x00000AF3
		[global::Cpp2ILInjected.Token(Token = "0x6000415")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F824BC", Offset = "0x1F824BC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public Quaternion(float x, float y, float z, float w)
		{
			throw null;
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x000028F6 File Offset: 0x00000AF6
		[global::Cpp2ILInjected.Token(Token = "0x170000DD")]
		public static Quaternion identity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000416")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F824C8", Offset = "0x1F824C8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x000028F9 File Offset: 0x00000AF9
		[global::Cpp2ILInjected.Token(Token = "0x6000417")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82514", Offset = "0x1F82514", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchControl", Member = "SnapTo", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Selectable", Member = "FindSelectable", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = "UnityEngine.UI.Selectable")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Selectable", Member = "FindSelectableOnLeft", ReturnType = "UnityEngine.UI.Selectable")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Selectable", Member = "FindSelectableOnRight", ReturnType = "UnityEngine.UI.Selectable")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Selectable", Member = "FindSelectableOnUp", ReturnType = "UnityEngine.UI.Selectable")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Selectable", Member = "FindSelectableOnDown", ReturnType = "UnityEngine.UI.Selectable")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "ScreenPointToWorldPointInRectangle", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(Vector2),
			typeof(Camera),
			typeof(ref Vector3)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		public static Vector3 operator *(Quaternion rotation, Vector3 point)
		{
			throw null;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x000028FC File Offset: 0x00000AFC
		[global::Cpp2ILInjected.Token(Token = "0x6000418")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F825B8", Offset = "0x1F825B8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		private static bool IsEqualUsingDot(float dot)
		{
			throw null;
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x000028FF File Offset: 0x00000AFF
		[global::Cpp2ILInjected.Token(Token = "0x6000419")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F825CC", Offset = "0x1F825CC", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static bool operator ==(Quaternion lhs, Quaternion rhs)
		{
			throw null;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00002902 File Offset: 0x00000B02
		[global::Cpp2ILInjected.Token(Token = "0x600041A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F825FC", Offset = "0x1F825FC", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static bool operator !=(Quaternion lhs, Quaternion rhs)
		{
			throw null;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00002905 File Offset: 0x00000B05
		[global::Cpp2ILInjected.Token(Token = "0x600041B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8262C", Offset = "0x1F8262C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static float Dot(Quaternion a, Quaternion b)
		{
			throw null;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00002908 File Offset: 0x00000B08
		[global::Cpp2ILInjected.Token(Token = "0x600041C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8264C", Offset = "0x1F8264C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.QuaternionConverter", Member = "WriteJson", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonWriter",
			typeof(object),
			"Newtonsoft.Json.JsonSerializer"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Quaternion), Member = "get_eulerAngles", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		private static Vector3 Internal_MakePositive(Vector3 euler)
		{
			throw null;
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x0000290B File Offset: 0x00000B0B
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x0000290E File Offset: 0x00000B0E
		[global::Cpp2ILInjected.Token(Token = "0x170000DE")]
		public Vector3 eulerAngles
		{
			[global::Cpp2ILInjected.Token(Token = "0x600041D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F826D4", Offset = "0x1F826D4", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Quaternion), Member = "Internal_ToEulerRad", MemberParameters = new object[] { typeof(Quaternion) }, ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Quaternion), Member = "Internal_MakePositive", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Vector3))]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600041E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F82700", Offset = "0x1F82700", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Quaternion))]
			[MethodImpl(256)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00002911 File Offset: 0x00000B11
		[global::Cpp2ILInjected.Token(Token = "0x600041F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82730", Offset = "0x1F82730", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00002914 File Offset: 0x00000B14
		[global::Cpp2ILInjected.Token(Token = "0x6000420")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82794", Offset = "0x1F82794", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "Equals", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		public override bool Equals(object other)
		{
			throw null;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00002917 File Offset: 0x00000B17
		[global::Cpp2ILInjected.Token(Token = "0x6000421")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82868", Offset = "0x1F82868", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "Equals", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(bool))]
		[MethodImpl(256)]
		public bool Equals(Quaternion other)
		{
			throw null;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0000291A File Offset: 0x00000B1A
		[global::Cpp2ILInjected.Token(Token = "0x6000422")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F828E8", Offset = "0x1F828E8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0000291D File Offset: 0x00000B1D
		[global::Cpp2ILInjected.Token(Token = "0x6000423")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F828F4", Offset = "0x1F828F4", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			throw null;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00002920 File Offset: 0x00000B20
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000424")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82AC0", Offset = "0x1F82AC0", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static Quaternion()
		{
			throw null;
		}

		// Token: 0x06000411 RID: 1041
		[global::Cpp2ILInjected.Token(Token = "0x6000425")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8228C", Offset = "0x1F8228C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void Inverse_Injected(ref Quaternion rotation, out Quaternion ret);

		// Token: 0x06000412 RID: 1042
		[global::Cpp2ILInjected.Token(Token = "0x6000426")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82324", Offset = "0x1F82324", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void Internal_FromEulerRad_Injected(ref Vector3 euler, out Quaternion ret);

		// Token: 0x06000413 RID: 1043
		[global::Cpp2ILInjected.Token(Token = "0x6000427")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F823C0", Offset = "0x1F823C0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void Internal_ToEulerRad_Injected(ref Quaternion rotation, out Vector3 ret);

		// Token: 0x06000414 RID: 1044
		[global::Cpp2ILInjected.Token(Token = "0x6000428")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82468", Offset = "0x1F82468", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void AngleAxis_Injected(float angle, ref Vector3 axis, out Quaternion ret);

		// Token: 0x0400038C RID: 908
		[global::Cpp2ILInjected.Token(Token = "0x40003C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public float x;

		// Token: 0x0400038D RID: 909
		[global::Cpp2ILInjected.Token(Token = "0x40003C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public float y;

		// Token: 0x0400038E RID: 910
		[global::Cpp2ILInjected.Token(Token = "0x40003C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public float z;

		// Token: 0x0400038F RID: 911
		[global::Cpp2ILInjected.Token(Token = "0x40003C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public float w;

		// Token: 0x04000390 RID: 912
		[global::Cpp2ILInjected.Token(Token = "0x40003C8")]
		private static readonly Quaternion identityQuaternion;
	}
}
