using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.Graphics.CameraModifiers
{
	// Token: 0x0200050C RID: 1292
	[global::Cpp2ILInjected.Token(Token = "0x2000772")]
	public class PunchCameraModifier : ICameraModifier
	{
		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x060037D4 RID: 14292 RVA: 0x0002BF9A File Offset: 0x0002A19A
		// (set) Token: 0x060037D5 RID: 14293 RVA: 0x0002BF9D File Offset: 0x0002A19D
		[global::Cpp2ILInjected.Token(Token = "0x17000794")]
		public string UniqueIdentity
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003E70")]
			[global::Cpp2ILInjected.Address(RVA = "0x14B6B68", Offset = "0x14B6B68", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003E71")]
			[global::Cpp2ILInjected.Address(RVA = "0x14B6B70", Offset = "0x14B6B70", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x060037D6 RID: 14294 RVA: 0x0002BFA0 File Offset: 0x0002A1A0
		// (set) Token: 0x060037D7 RID: 14295 RVA: 0x0002BFA3 File Offset: 0x0002A1A3
		[global::Cpp2ILInjected.Token(Token = "0x17000795")]
		public bool Finished
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003E72")]
			[global::Cpp2ILInjected.Address(RVA = "0x14B6B78", Offset = "0x14B6B78", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003E73")]
			[global::Cpp2ILInjected.Address(RVA = "0x14B6B80", Offset = "0x14B6B80", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x060037D8 RID: 14296 RVA: 0x0002BFA6 File Offset: 0x0002A1A6
		[global::Cpp2ILInjected.Token(Token = "0x6003E74")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B6B8C", Offset = "0x14B6B8C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_123_Deerclops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_123_Deerclops_MakeSpikesForward", MemberParameters = new object[]
		{
			typeof(int),
			typeof(NPCAimedTarget)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_123_Deerclops_MakeSpikesBothSides", MemberParameters = new object[]
		{
			typeof(int),
			typeof(NPCAimedTarget)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public PunchCameraModifier(Vector2 startPosition, Vector2 direction, float strength, float vibrationCyclesPerSecond, int frames, float distanceFalloff = -1f, string uniqueIdentity = null)
		{
			throw null;
		}

		// Token: 0x060037D9 RID: 14297 RVA: 0x0002BFA9 File Offset: 0x0002A1A9
		[global::Cpp2ILInjected.Token(Token = "0x6003E75")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B6C08", Offset = "0x14B6C08", Length = "0x210")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Remap", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void Update(ref CameraInfo cameraInfo)
		{
			throw null;
		}

		// Token: 0x04006809 RID: 26633
		[global::Cpp2ILInjected.Token(Token = "0x4007D24")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _framesToLast;

		// Token: 0x0400680A RID: 26634
		[global::Cpp2ILInjected.Token(Token = "0x4007D25")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private Vector2 _startPosition;

		// Token: 0x0400680B RID: 26635
		[global::Cpp2ILInjected.Token(Token = "0x4007D26")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private Vector2 _direction;

		// Token: 0x0400680C RID: 26636
		[global::Cpp2ILInjected.Token(Token = "0x4007D27")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private float _distanceFalloff;

		// Token: 0x0400680D RID: 26637
		[global::Cpp2ILInjected.Token(Token = "0x4007D28")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private float _strength;

		// Token: 0x0400680E RID: 26638
		[global::Cpp2ILInjected.Token(Token = "0x4007D29")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private float _vibrationCyclesPerSecond;

		// Token: 0x0400680F RID: 26639
		[global::Cpp2ILInjected.Token(Token = "0x4007D2A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int _framesLasted;

		// Token: 0x04006810 RID: 26640
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007D2B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string <UniqueIdentity>k__BackingField;

		// Token: 0x04006811 RID: 26641
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007D2C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool <Finished>k__BackingField;
	}
}
