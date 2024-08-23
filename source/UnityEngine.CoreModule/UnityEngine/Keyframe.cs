using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000032 RID: 50
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x2000035")]
	public struct Keyframe
	{
		// Token: 0x0600003E RID: 62 RVA: 0x000020D7 File Offset: 0x000002D7
		[global::Cpp2ILInjected.Token(Token = "0x6000046")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6AA28", Offset = "0x1F6AA28", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Keyframe(float time, float value)
		{
			throw null;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000020DA File Offset: 0x000002DA
		[global::Cpp2ILInjected.Token(Token = "0x6000047")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6AA38", Offset = "0x1F6AA38", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Keyframe(float time, float value, float inTangent, float outTangent)
		{
			throw null;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000020DD File Offset: 0x000002DD
		[global::Cpp2ILInjected.Token(Token = "0x6000048")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6AA4C", Offset = "0x1F6AA4C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LayoutDefinition", Member = "LoadFields", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public Keyframe(float time, float value, float inTangent, float outTangent, float inWeight, float outWeight)
		{
			throw null;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000020E0 File Offset: 0x000002E0
		[global::Cpp2ILInjected.Token(Token = "0x17000005")]
		public float time
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000049")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6AA64", Offset = "0x1F6AA64", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIWorldOperationProgress", Member = "Draw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LayoutDefinition", Member = "SaveFields", MemberParameters = new object[]
			{
				typeof(BinaryWriter),
				typeof(Type),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XNAUICameraSettings", Member = "GetMaxResolution", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DoDraw_UpdateCameraPosition", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000020E3 File Offset: 0x000002E3
		[global::Cpp2ILInjected.Token(Token = "0x17000006")]
		public float value
		{
			[global::Cpp2ILInjected.Token(Token = "0x600004A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6AA6C", Offset = "0x1F6AA6C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LayoutDefinition", Member = "SaveFields", MemberParameters = new object[]
			{
				typeof(BinaryWriter),
				typeof(Type),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XNAUICameraSettings", Member = "GetMaxResolution", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000020E6 File Offset: 0x000002E6
		[global::Cpp2ILInjected.Token(Token = "0x17000007")]
		public float inTangent
		{
			[global::Cpp2ILInjected.Token(Token = "0x600004B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6AA74", Offset = "0x1F6AA74", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LayoutDefinition", Member = "SaveFields", MemberParameters = new object[]
			{
				typeof(BinaryWriter),
				typeof(Type),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000044 RID: 68 RVA: 0x000020E9 File Offset: 0x000002E9
		[global::Cpp2ILInjected.Token(Token = "0x17000008")]
		public float outTangent
		{
			[global::Cpp2ILInjected.Token(Token = "0x600004C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6AA7C", Offset = "0x1F6AA7C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LayoutDefinition", Member = "SaveFields", MemberParameters = new object[]
			{
				typeof(BinaryWriter),
				typeof(Type),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000020EC File Offset: 0x000002EC
		[global::Cpp2ILInjected.Token(Token = "0x17000009")]
		public float inWeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x600004D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6AA84", Offset = "0x1F6AA84", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LayoutDefinition", Member = "SaveFields", MemberParameters = new object[]
			{
				typeof(BinaryWriter),
				typeof(Type),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000046 RID: 70 RVA: 0x000020EF File Offset: 0x000002EF
		[global::Cpp2ILInjected.Token(Token = "0x1700000A")]
		public float outWeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x600004E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6AA8C", Offset = "0x1F6AA8C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LayoutDefinition", Member = "SaveFields", MemberParameters = new object[]
			{
				typeof(BinaryWriter),
				typeof(Type),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040000B1 RID: 177
		[global::Cpp2ILInjected.Token(Token = "0x40000B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private float m_Time;

		// Token: 0x040000B2 RID: 178
		[global::Cpp2ILInjected.Token(Token = "0x40000B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private float m_Value;

		// Token: 0x040000B3 RID: 179
		[global::Cpp2ILInjected.Token(Token = "0x40000B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private float m_InTangent;

		// Token: 0x040000B4 RID: 180
		[global::Cpp2ILInjected.Token(Token = "0x40000B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		private float m_OutTangent;

		// Token: 0x040000B5 RID: 181
		[global::Cpp2ILInjected.Token(Token = "0x40000B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int m_WeightedMode;

		// Token: 0x040000B6 RID: 182
		[global::Cpp2ILInjected.Token(Token = "0x40000BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private float m_InWeight;

		// Token: 0x040000B7 RID: 183
		[global::Cpp2ILInjected.Token(Token = "0x40000BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private float m_OutWeight;
	}
}
