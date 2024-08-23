using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000B7 RID: 183
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[NativeClass("Vector2f")]
	[Il2CppEagerStaticClassConstruction]
	[global::Cpp2ILInjected.Token(Token = "0x20000C9")]
	public struct Vector2 : IEquatable<Vector2>, IFormattable
	{
		// Token: 0x170000B6 RID: 182
		[global::Cpp2ILInjected.Token(Token = "0x170000B8")]
		public float this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000382")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7ED3C", Offset = "0x1F7ED3C", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000383")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7EDA4", Offset = "0x1F7EDA4", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			[MethodImpl(256)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00002743 File Offset: 0x00000943
		[global::Cpp2ILInjected.Token(Token = "0x6000384")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7EE0C", Offset = "0x1F7EE0C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public Vector2(float x, float y)
		{
			throw null;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00002746 File Offset: 0x00000946
		[global::Cpp2ILInjected.Token(Token = "0x6000385")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7EE14", Offset = "0x1F7EE14", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static Vector2 Lerp(Vector2 a, Vector2 b, float t)
		{
			throw null;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00002749 File Offset: 0x00000949
		[global::Cpp2ILInjected.Token(Token = "0x6000386")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7EE44", Offset = "0x1F7EE44", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static Vector2 Scale(Vector2 a, Vector2 b)
		{
			throw null;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0000274C File Offset: 0x0000094C
		[global::Cpp2ILInjected.Token(Token = "0x6000387")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7EE50", Offset = "0x1F7EE50", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[MethodImpl(256)]
		public void Normalize()
		{
			throw null;
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000374 RID: 884 RVA: 0x0000274F File Offset: 0x0000094F
		[global::Cpp2ILInjected.Token(Token = "0x170000B9")]
		public Vector2 normalized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000388")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7EF18", Offset = "0x1F7EF18", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00002752 File Offset: 0x00000952
		[global::Cpp2ILInjected.Token(Token = "0x6000389")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7EFC8", Offset = "0x1F7EFC8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TestInputManager", Member = "OnGUI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.PointerEventData", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.RaycastResult", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TouchExample.CubeController", Member = "OnGUI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00002755 File Offset: 0x00000955
		[global::Cpp2ILInjected.Token(Token = "0x600038A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7EFD4", Offset = "0x1F7EFD4", Length = "0x164")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			throw null;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00002758 File Offset: 0x00000958
		[global::Cpp2ILInjected.Token(Token = "0x600038B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7F138", Offset = "0x1F7F138", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000275B File Offset: 0x0000095B
		[global::Cpp2ILInjected.Token(Token = "0x600038C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7F16C", Offset = "0x1F7F16C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		public override bool Equals(object other)
		{
			throw null;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0000275E File Offset: 0x0000095E
		[global::Cpp2ILInjected.Token(Token = "0x600038D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7F1F4", Offset = "0x1F7F1F4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public bool Equals(Vector2 other)
		{
			throw null;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00002761 File Offset: 0x00000961
		[global::Cpp2ILInjected.Token(Token = "0x600038E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7F218", Offset = "0x1F7F218", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static float Dot(Vector2 lhs, Vector2 rhs)
		{
			throw null;
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600037B RID: 891 RVA: 0x00002764 File Offset: 0x00000964
		[global::Cpp2ILInjected.Token(Token = "0x170000BA")]
		public float magnitude
		{
			[global::Cpp2ILInjected.Token(Token = "0x600038F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7F228", Offset = "0x1F7F228", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600037C RID: 892 RVA: 0x00002767 File Offset: 0x00000967
		[global::Cpp2ILInjected.Token(Token = "0x170000BB")]
		public float sqrMagnitude
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000390")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7F294", Offset = "0x1F7F294", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000276A File Offset: 0x0000096A
		[global::Cpp2ILInjected.Token(Token = "0x6000391")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7F2A8", Offset = "0x1F7F2A8", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		[MethodImpl(256)]
		public static float Angle(Vector2 from, Vector2 to)
		{
			throw null;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000276D File Offset: 0x0000096D
		[global::Cpp2ILInjected.Token(Token = "0x6000392")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7F39C", Offset = "0x1F7F39C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static Vector2 operator +(Vector2 a, Vector2 b)
		{
			throw null;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00002770 File Offset: 0x00000970
		[global::Cpp2ILInjected.Token(Token = "0x6000393")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7F3A8", Offset = "0x1F7F3A8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static Vector2 operator -(Vector2 a, Vector2 b)
		{
			throw null;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00002773 File Offset: 0x00000973
		[global::Cpp2ILInjected.Token(Token = "0x6000394")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7F3B4", Offset = "0x1F7F3B4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static Vector2 operator *(Vector2 a, Vector2 b)
		{
			throw null;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00002776 File Offset: 0x00000976
		[global::Cpp2ILInjected.Token(Token = "0x6000395")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7F3C0", Offset = "0x1F7F3C0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static Vector2 operator /(Vector2 a, Vector2 b)
		{
			throw null;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00002779 File Offset: 0x00000979
		[global::Cpp2ILInjected.Token(Token = "0x6000396")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7F3CC", Offset = "0x1F7F3CC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static Vector2 operator -(Vector2 a)
		{
			throw null;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0000277C File Offset: 0x0000097C
		[global::Cpp2ILInjected.Token(Token = "0x6000397")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7F3D8", Offset = "0x1F7F3D8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static Vector2 operator *(Vector2 a, float d)
		{
			throw null;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0000277F File Offset: 0x0000097F
		[global::Cpp2ILInjected.Token(Token = "0x6000398")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7F3E4", Offset = "0x1F7F3E4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static Vector2 operator /(Vector2 a, float d)
		{
			throw null;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00002782 File Offset: 0x00000982
		[global::Cpp2ILInjected.Token(Token = "0x6000399")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7F3F0", Offset = "0x1F7F3F0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static bool operator ==(Vector2 lhs, Vector2 rhs)
		{
			throw null;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00002785 File Offset: 0x00000985
		[global::Cpp2ILInjected.Token(Token = "0x600039A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7F418", Offset = "0x1F7F418", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static bool operator !=(Vector2 lhs, Vector2 rhs)
		{
			throw null;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00002788 File Offset: 0x00000988
		[global::Cpp2ILInjected.Token(Token = "0x600039B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7F440", Offset = "0x1F7F440", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static implicit operator Vector2(Vector3 v)
		{
			throw null;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000278B File Offset: 0x0000098B
		[global::Cpp2ILInjected.Token(Token = "0x600039C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7F444", Offset = "0x1F7F444", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static implicit operator Vector3(Vector2 v)
		{
			throw null;
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000389 RID: 905 RVA: 0x0000278E File Offset: 0x0000098E
		[global::Cpp2ILInjected.Token(Token = "0x170000BC")]
		public static Vector2 zero
		{
			[global::Cpp2ILInjected.Token(Token = "0x600039D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7F44C", Offset = "0x1F7F44C", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600038A RID: 906 RVA: 0x00002791 File Offset: 0x00000991
		[global::Cpp2ILInjected.Token(Token = "0x170000BD")]
		public static Vector2 one
		{
			[global::Cpp2ILInjected.Token(Token = "0x600039E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7F494", Offset = "0x1F7F494", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600038B RID: 907 RVA: 0x00002794 File Offset: 0x00000994
		[global::Cpp2ILInjected.Token(Token = "0x170000BE")]
		public static Vector2 up
		{
			[global::Cpp2ILInjected.Token(Token = "0x600039F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7F4DC", Offset = "0x1F7F4DC", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600038C RID: 908 RVA: 0x00002797 File Offset: 0x00000997
		[global::Cpp2ILInjected.Token(Token = "0x170000BF")]
		public static Vector2 right
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7F524", Offset = "0x1F7F524", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000279A File Offset: 0x0000099A
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60003A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7F56C", Offset = "0x1F7F56C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static Vector2()
		{
			throw null;
		}

		// Token: 0x04000345 RID: 837
		[global::Cpp2ILInjected.Token(Token = "0x400037D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public float x;

		// Token: 0x04000346 RID: 838
		[global::Cpp2ILInjected.Token(Token = "0x400037E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public float y;

		// Token: 0x04000347 RID: 839
		[global::Cpp2ILInjected.Token(Token = "0x400037F")]
		private static readonly Vector2 zeroVector;

		// Token: 0x04000348 RID: 840
		[global::Cpp2ILInjected.Token(Token = "0x4000380")]
		private static readonly Vector2 oneVector;

		// Token: 0x04000349 RID: 841
		[global::Cpp2ILInjected.Token(Token = "0x4000381")]
		private static readonly Vector2 upVector;

		// Token: 0x0400034A RID: 842
		[global::Cpp2ILInjected.Token(Token = "0x4000382")]
		private static readonly Vector2 downVector;

		// Token: 0x0400034B RID: 843
		[global::Cpp2ILInjected.Token(Token = "0x4000383")]
		private static readonly Vector2 leftVector;

		// Token: 0x0400034C RID: 844
		[global::Cpp2ILInjected.Token(Token = "0x4000384")]
		private static readonly Vector2 rightVector;

		// Token: 0x0400034D RID: 845
		[global::Cpp2ILInjected.Token(Token = "0x4000385")]
		private static readonly Vector2 positiveInfinityVector;

		// Token: 0x0400034E RID: 846
		[global::Cpp2ILInjected.Token(Token = "0x4000386")]
		private static readonly Vector2 negativeInfinityVector;

		// Token: 0x0400034F RID: 847
		[global::Cpp2ILInjected.Token(Token = "0x4000387")]
		public const float kEpsilon = 1E-05f;

		// Token: 0x04000350 RID: 848
		[global::Cpp2ILInjected.Token(Token = "0x4000388")]
		public const float kEpsilonNormalSqrt = 1E-15f;
	}
}
