using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.Graphics.CameraModifiers
{
	[global::Cpp2ILInjected.Token(Token = "0x2000772")]
	public class PunchCameraModifier : ICameraModifier
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x4007D24")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _framesToLast;

		[global::Cpp2ILInjected.Token(Token = "0x4007D25")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private Vector2 _startPosition;

		[global::Cpp2ILInjected.Token(Token = "0x4007D26")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private Vector2 _direction;

		[global::Cpp2ILInjected.Token(Token = "0x4007D27")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private float _distanceFalloff;

		[global::Cpp2ILInjected.Token(Token = "0x4007D28")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private float _strength;

		[global::Cpp2ILInjected.Token(Token = "0x4007D29")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private float _vibrationCyclesPerSecond;

		[global::Cpp2ILInjected.Token(Token = "0x4007D2A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int _framesLasted;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007D2B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string <UniqueIdentity>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007D2C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool <Finished>k__BackingField;
	}
}
